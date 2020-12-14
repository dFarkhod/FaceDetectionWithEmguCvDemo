namespace FaceDetect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureCamareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectFacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectEyesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureCamareToolStripMenuItem,
            this.detectFacesToolStripMenuItem,
            this.detectEyesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.menuToolStripMenuItem.Text = "Meni bos";
            // 
            // captureCamareToolStripMenuItem
            // 
            this.captureCamareToolStripMenuItem.Name = "captureCamareToolStripMenuItem";
            this.captureCamareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.captureCamareToolStripMenuItem.Text = "Kamerani Ishlat";
            this.captureCamareToolStripMenuItem.Click += new System.EventHandler(this.captureCamareToolStripMenuItem_Click);
            // 
            // detectFacesToolStripMenuItem
            // 
            this.detectFacesToolStripMenuItem.Name = "detectFacesToolStripMenuItem";
            this.detectFacesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detectFacesToolStripMenuItem.Text = "Yuzni Aniqla";
            this.detectFacesToolStripMenuItem.Click += new System.EventHandler(this.detectFacesToolStripMenuItem_Click);
            // 
            // detectEyesToolStripMenuItem
            // 
            this.detectEyesToolStripMenuItem.Name = "detectEyesToolStripMenuItem";
            this.detectEyesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detectEyesToolStripMenuItem.Text = "Kozni Aniqla";
            this.detectEyesToolStripMenuItem.Click += new System.EventHandler(this.detectEyesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Yuz va ko\'z aniqlagich";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureCamareToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem detectFacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectEyesToolStripMenuItem;
    }
}

