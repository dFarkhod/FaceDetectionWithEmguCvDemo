using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Capture VideoCapture = null;
        Image<Bgr, byte> ImgInput = null;
        Mat Matrix = new Mat();
        string FaceFilePath = string.Empty;
        string EyeFilePath = string.Empty;
        CascadeClassifier FaceClassifier = null;
        CascadeClassifier EyeClassifier = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            FaceFilePath = Path.GetFullPath("data/haarcascade_frontalface_default.xml");
            FaceClassifier = new CascadeClassifier(FaceFilePath);

            EyeFilePath = Path.GetFullPath("data/haarcascade_eye.xml");
            EyeClassifier = new CascadeClassifier(EyeFilePath);
        }

        private void detectEyesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detectEyesToolStripMenuItem.Checked = !detectEyesToolStripMenuItem.Checked;
        }

        private void detectFacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detectFacesToolStripMenuItem.Checked = !detectFacesToolStripMenuItem.Checked;
        }
        
        private void captureCamareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (VideoCapture != null)
                    VideoCapture.Dispose();

                VideoCapture = new Capture();
                Application.Idle += ProcessVideo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessVideo(object sender, EventArgs e)
        {
            if (VideoCapture != null && VideoCapture.Ptr != IntPtr.Zero)
            {
                VideoCapture.Retrieve(Matrix, 0);
                ImgInput = Matrix.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);

                Detect();
            }
        }

        private void Detect()
        {
            pictureBox1.Image = ImgInput.Bitmap;

            if (!detectFacesToolStripMenuItem.Checked)
                return;

            var imgGray = ImgInput.Convert<Gray, byte>().Clone();
            Rectangle[] faces = FaceClassifier.DetectMultiScale(imgGray, 1.1, 4);
            foreach (var face in faces)
            {
                ImgInput.Draw(face, new Bgr(Color.DarkRed), 3);

                if (detectEyesToolStripMenuItem.Checked)
                {
                    imgGray.ROI = face;
                    Rectangle[] eyes = EyeClassifier.DetectMultiScale(imgGray, 1.4, 5);
                    foreach (var eye in eyes)
                    {
                        var e = eye;
                        e.X += face.X;
                        e.Y += face.Y;
                        ImgInput.Draw(e, new Bgr(0, 255, 0), 2);
                    }
                }
            }
            pictureBox1.Image = ImgInput.Bitmap;
            if (ImgInput != null)
                ImgInput.Dispose();
        }
    }
}
