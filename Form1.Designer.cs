namespace ROV_CONTROLLER1
{
    partial class rov_ui
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ROV_Cam = new LibVLCSharp.WinForms.VideoView();
            ((System.ComponentModel.ISupportInitialize)ROV_Cam).BeginInit();
            SuspendLayout();
            // 
            // ROV_Cam
            // 
            ROV_Cam.BackColor = Color.Black;
            ROV_Cam.Location = new Point(-1, -1);
            ROV_Cam.MediaPlayer = null;
            ROV_Cam.Name = "ROV_Cam";
            ROV_Cam.Size = new Size(1920, 1080);
            ROV_Cam.TabIndex = 1;
            ROV_Cam.Text = "videoView1";
            // 
            // rov_ui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1665, 818);
            Controls.Add(ROV_Cam);
            Name = "rov_ui";
            Text = "rov_ui";
            ((System.ComponentModel.ISupportInitialize)ROV_Cam).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView ROV_Cam;
    }
}
