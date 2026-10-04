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
            ROV_Cam = new Microsoft.Web.WebView2.WinForms.WebView2();
            depth_label = new Label();
            depth_reading = new Label();
            temp_label = new Label();
            temp_reading = new Label();
            battery_voltage_label = new Label();
            battery_voltage_reading = new Label();
            current_draw_label = new Label();
            current_draw_reading = new Label();
            comms_label = new Label();
            comms_status = new Label();
            latency_label = new Label();
            latency_reading = new Label();
            roll_label = new Label();
            roll_reading = new Label();
            pitch_label = new Label();
            pitch_reading = new Label();
            yaw_label = new Label();
            yaw_reading = new Label();
            xa_label = new Label();
            xa_reading = new Label();
            ya_label = new Label();
            label4 = new Label();
            za_label = new Label();
            za_reading = new Label();
            ((System.ComponentModel.ISupportInitialize)ROV_Cam).BeginInit();
            SuspendLayout();
            // 
            // ROV_Cam
            // 
            ROV_Cam.AllowExternalDrop = true;
            ROV_Cam.CreationProperties = null;
            ROV_Cam.DefaultBackgroundColor = Color.Black;
            ROV_Cam.Location = new Point(3, -30);
            ROV_Cam.Name = "ROV_Cam";
            ROV_Cam.Size = new Size(1920, 1080);
            ROV_Cam.TabIndex = 1;
            ROV_Cam.ZoomFactor = 1D;
            // 
            // depth_label
            // 
            depth_label.AutoSize = true;
            depth_label.BackColor = Color.LimeGreen;
            depth_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depth_label.Location = new Point(3, 1103);
            depth_label.MaximumSize = new Size(150, 50);
            depth_label.MinimumSize = new Size(150, 50);
            depth_label.Name = "depth_label";
            depth_label.Size = new Size(150, 50);
            depth_label.TabIndex = 2;
            depth_label.Text = "Depth: ";
            depth_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // depth_reading
            // 
            depth_reading.AutoSize = true;
            depth_reading.BackColor = Color.LimeGreen;
            depth_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depth_reading.Location = new Point(148, 1103);
            depth_reading.MaximumSize = new Size(150, 50);
            depth_reading.MinimumSize = new Size(150, 50);
            depth_reading.Name = "depth_reading";
            depth_reading.Size = new Size(150, 50);
            depth_reading.TabIndex = 3;
            depth_reading.Text = "20.5m ";
            depth_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // temp_label
            // 
            temp_label.AutoSize = true;
            temp_label.BackColor = Color.DarkCyan;
            temp_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            temp_label.Location = new Point(295, 1103);
            temp_label.MaximumSize = new Size(150, 50);
            temp_label.MinimumSize = new Size(150, 50);
            temp_label.Name = "temp_label";
            temp_label.Size = new Size(150, 50);
            temp_label.TabIndex = 4;
            temp_label.Text = "Temp C:";
            temp_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // temp_reading
            // 
            temp_reading.AutoSize = true;
            temp_reading.BackColor = Color.DarkCyan;
            temp_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            temp_reading.Location = new Point(442, 1103);
            temp_reading.MaximumSize = new Size(100, 50);
            temp_reading.MinimumSize = new Size(100, 50);
            temp_reading.Name = "temp_reading";
            temp_reading.Size = new Size(100, 50);
            temp_reading.TabIndex = 5;
            temp_reading.Text = "27.3";
            temp_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // battery_voltage_label
            // 
            battery_voltage_label.AutoSize = true;
            battery_voltage_label.BackColor = Color.MediumPurple;
            battery_voltage_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            battery_voltage_label.Location = new Point(539, 1103);
            battery_voltage_label.MaximumSize = new Size(250, 50);
            battery_voltage_label.MinimumSize = new Size(250, 50);
            battery_voltage_label.Name = "battery_voltage_label";
            battery_voltage_label.Size = new Size(250, 50);
            battery_voltage_label.TabIndex = 6;
            battery_voltage_label.Text = "Battery Voltage:\r\n\r\n";
            battery_voltage_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // battery_voltage_reading
            // 
            battery_voltage_reading.AutoSize = true;
            battery_voltage_reading.BackColor = Color.MediumPurple;
            battery_voltage_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            battery_voltage_reading.ForeColor = Color.Lime;
            battery_voltage_reading.Location = new Point(786, 1103);
            battery_voltage_reading.MaximumSize = new Size(150, 50);
            battery_voltage_reading.MinimumSize = new Size(150, 50);
            battery_voltage_reading.Name = "battery_voltage_reading";
            battery_voltage_reading.Size = new Size(150, 50);
            battery_voltage_reading.TabIndex = 7;
            battery_voltage_reading.Text = "14.6V";
            battery_voltage_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // current_draw_label
            // 
            current_draw_label.AutoSize = true;
            current_draw_label.BackColor = Color.MediumPurple;
            current_draw_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            current_draw_label.Location = new Point(539, 1053);
            current_draw_label.MaximumSize = new Size(250, 50);
            current_draw_label.MinimumSize = new Size(250, 50);
            current_draw_label.Name = "current_draw_label";
            current_draw_label.Size = new Size(250, 50);
            current_draw_label.TabIndex = 8;
            current_draw_label.Text = "Current Draw:";
            current_draw_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // current_draw_reading
            // 
            current_draw_reading.AutoSize = true;
            current_draw_reading.BackColor = Color.MediumPurple;
            current_draw_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            current_draw_reading.ForeColor = Color.Lime;
            current_draw_reading.Location = new Point(786, 1053);
            current_draw_reading.MaximumSize = new Size(150, 50);
            current_draw_reading.MinimumSize = new Size(150, 50);
            current_draw_reading.Name = "current_draw_reading";
            current_draw_reading.Size = new Size(150, 50);
            current_draw_reading.TabIndex = 9;
            current_draw_reading.Text = "2500 mA";
            current_draw_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comms_label
            // 
            comms_label.AutoSize = true;
            comms_label.BackColor = Color.LightGoldenrodYellow;
            comms_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comms_label.Location = new Point(3, 1053);
            comms_label.MaximumSize = new Size(150, 50);
            comms_label.MinimumSize = new Size(150, 50);
            comms_label.Name = "comms_label";
            comms_label.Size = new Size(150, 50);
            comms_label.TabIndex = 10;
            comms_label.Text = "Comms:";
            comms_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comms_status
            // 
            comms_status.AutoSize = true;
            comms_status.BackColor = Color.LightGoldenrodYellow;
            comms_status.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comms_status.ForeColor = Color.Lime;
            comms_status.Location = new Point(148, 1053);
            comms_status.MaximumSize = new Size(150, 50);
            comms_status.MinimumSize = new Size(150, 50);
            comms_status.Name = "comms_status";
            comms_status.Size = new Size(150, 50);
            comms_status.TabIndex = 11;
            comms_status.Text = "LIVE";
            comms_status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // latency_label
            // 
            latency_label.AutoSize = true;
            latency_label.BackColor = Color.DarkCyan;
            latency_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            latency_label.Location = new Point(295, 1053);
            latency_label.MaximumSize = new Size(150, 50);
            latency_label.MinimumSize = new Size(150, 50);
            latency_label.Name = "latency_label";
            latency_label.Size = new Size(150, 50);
            latency_label.TabIndex = 12;
            latency_label.Text = "Latency";
            latency_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // latency_reading
            // 
            latency_reading.AutoSize = true;
            latency_reading.BackColor = Color.DarkCyan;
            latency_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            latency_reading.ForeColor = Color.Lime;
            latency_reading.Location = new Point(442, 1053);
            latency_reading.MaximumSize = new Size(100, 50);
            latency_reading.MinimumSize = new Size(100, 50);
            latency_reading.Name = "latency_reading";
            latency_reading.Size = new Size(100, 50);
            latency_reading.TabIndex = 13;
            latency_reading.Text = "25ms";
            latency_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roll_label
            // 
            roll_label.AutoSize = true;
            roll_label.BackColor = Color.LightSkyBlue;
            roll_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roll_label.ForeColor = Color.Black;
            roll_label.Location = new Point(933, 1053);
            roll_label.MaximumSize = new Size(100, 50);
            roll_label.MinimumSize = new Size(162, 50);
            roll_label.Name = "roll_label";
            roll_label.Size = new Size(162, 50);
            roll_label.TabIndex = 14;
            roll_label.Text = "Roll:";
            roll_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roll_reading
            // 
            roll_reading.AutoSize = true;
            roll_reading.BackColor = Color.LightSkyBlue;
            roll_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roll_reading.ForeColor = Color.Black;
            roll_reading.Location = new Point(1092, 1053);
            roll_reading.MaximumSize = new Size(100, 50);
            roll_reading.MinimumSize = new Size(162, 50);
            roll_reading.Name = "roll_reading";
            roll_reading.Size = new Size(162, 50);
            roll_reading.TabIndex = 15;
            roll_reading.Text = "175.23";
            roll_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pitch_label
            // 
            pitch_label.AutoSize = true;
            pitch_label.BackColor = Color.LightSkyBlue;
            pitch_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pitch_label.ForeColor = Color.Black;
            pitch_label.Location = new Point(1249, 1053);
            pitch_label.MaximumSize = new Size(100, 50);
            pitch_label.MinimumSize = new Size(162, 50);
            pitch_label.Name = "pitch_label";
            pitch_label.Size = new Size(162, 50);
            pitch_label.TabIndex = 16;
            pitch_label.Text = "Pitch:";
            pitch_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pitch_reading
            // 
            pitch_reading.AutoSize = true;
            pitch_reading.BackColor = Color.LightSkyBlue;
            pitch_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pitch_reading.ForeColor = Color.Black;
            pitch_reading.Location = new Point(1408, 1053);
            pitch_reading.MaximumSize = new Size(100, 50);
            pitch_reading.MinimumSize = new Size(162, 50);
            pitch_reading.Name = "pitch_reading";
            pitch_reading.Size = new Size(162, 50);
            pitch_reading.TabIndex = 17;
            pitch_reading.Text = "-25.66";
            pitch_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yaw_label
            // 
            yaw_label.AutoSize = true;
            yaw_label.BackColor = Color.LightSkyBlue;
            yaw_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yaw_label.ForeColor = Color.Black;
            yaw_label.Location = new Point(1566, 1053);
            yaw_label.MaximumSize = new Size(100, 50);
            yaw_label.MinimumSize = new Size(162, 50);
            yaw_label.Name = "yaw_label";
            yaw_label.Size = new Size(162, 50);
            yaw_label.TabIndex = 18;
            yaw_label.Text = "Yaw:";
            yaw_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yaw_reading
            // 
            yaw_reading.AutoSize = true;
            yaw_reading.BackColor = Color.LightSkyBlue;
            yaw_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yaw_reading.ForeColor = Color.Black;
            yaw_reading.Location = new Point(1728, 1053);
            yaw_reading.MaximumSize = new Size(100, 50);
            yaw_reading.MinimumSize = new Size(162, 50);
            yaw_reading.Name = "yaw_reading";
            yaw_reading.Size = new Size(162, 50);
            yaw_reading.TabIndex = 19;
            yaw_reading.Text = "30.19";
            yaw_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // xa_label
            // 
            xa_label.AutoSize = true;
            xa_label.BackColor = Color.Lavender;
            xa_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xa_label.ForeColor = Color.Black;
            xa_label.Location = new Point(933, 1103);
            xa_label.MaximumSize = new Size(100, 50);
            xa_label.MinimumSize = new Size(162, 50);
            xa_label.Name = "xa_label";
            xa_label.Size = new Size(162, 50);
            xa_label.TabIndex = 20;
            xa_label.Text = "Xa:";
            xa_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // xa_reading
            // 
            xa_reading.AutoSize = true;
            xa_reading.BackColor = Color.Lavender;
            xa_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xa_reading.ForeColor = Color.Black;
            xa_reading.Location = new Point(1092, 1103);
            xa_reading.MaximumSize = new Size(100, 50);
            xa_reading.MinimumSize = new Size(162, 50);
            xa_reading.Name = "xa_reading";
            xa_reading.Size = new Size(162, 50);
            xa_reading.TabIndex = 21;
            xa_reading.Text = "2.38";
            xa_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ya_label
            // 
            ya_label.AutoSize = true;
            ya_label.BackColor = Color.Lavender;
            ya_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ya_label.ForeColor = Color.Black;
            ya_label.Location = new Point(1249, 1103);
            ya_label.MaximumSize = new Size(100, 50);
            ya_label.MinimumSize = new Size(162, 50);
            ya_label.Name = "ya_label";
            ya_label.Size = new Size(162, 50);
            ya_label.TabIndex = 22;
            ya_label.Text = "Ya:";
            ya_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1408, 1103);
            label4.MaximumSize = new Size(100, 50);
            label4.MinimumSize = new Size(162, 50);
            label4.Name = "label4";
            label4.Size = new Size(162, 50);
            label4.TabIndex = 23;
            label4.Text = "-1.10";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // za_label
            // 
            za_label.AutoSize = true;
            za_label.BackColor = Color.Lavender;
            za_label.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            za_label.ForeColor = Color.Black;
            za_label.Location = new Point(1566, 1103);
            za_label.MaximumSize = new Size(100, 50);
            za_label.MinimumSize = new Size(162, 50);
            za_label.Name = "za_label";
            za_label.Size = new Size(162, 50);
            za_label.TabIndex = 24;
            za_label.Text = "Za:";
            za_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // za_reading
            // 
            za_reading.AutoSize = true;
            za_reading.BackColor = Color.Lavender;
            za_reading.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            za_reading.ForeColor = Color.Black;
            za_reading.Location = new Point(1728, 1103);
            za_reading.MaximumSize = new Size(100, 50);
            za_reading.MinimumSize = new Size(162, 50);
            za_reading.Name = "za_reading";
            za_reading.Size = new Size(162, 50);
            za_reading.TabIndex = 25;
            za_reading.Text = "0.54";
            za_reading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rov_ui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1902, 1153);
            Controls.Add(za_reading);
            Controls.Add(za_label);
            Controls.Add(label4);
            Controls.Add(ya_label);
            Controls.Add(xa_reading);
            Controls.Add(xa_label);
            Controls.Add(yaw_reading);
            Controls.Add(yaw_label);
            Controls.Add(pitch_reading);
            Controls.Add(pitch_label);
            Controls.Add(roll_reading);
            Controls.Add(roll_label);
            Controls.Add(latency_reading);
            Controls.Add(latency_label);
            Controls.Add(comms_status);
            Controls.Add(comms_label);
            Controls.Add(current_draw_reading);
            Controls.Add(current_draw_label);
            Controls.Add(battery_voltage_reading);
            Controls.Add(battery_voltage_label);
            Controls.Add(temp_reading);
            Controls.Add(temp_label);
            Controls.Add(depth_reading);
            Controls.Add(depth_label);
            Controls.Add(ROV_Cam);
            Name = "rov_ui";
            Text = "rov_ui";
            ((System.ComponentModel.ISupportInitialize)ROV_Cam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 ROV_Cam;
        private Label depth_label;
        private Label depth_reading;
        private Label temp_label;
        private Label temp_reading;
        private Label battery_voltage_label;
        private Label battery_voltage_reading;
        private Label current_draw_label;
        private Label current_draw_reading;
        private Label comms_label;
        private Label comms_status;
        private Label latency_label;
        private Label latency_reading;
        private Label roll_label;
        private Label roll_reading;
        private Label pitch_label;
        private Label pitch_reading;
        private Label yaw_label;
        private Label yaw_reading;
        private Label xa_label;
        private Label xa_reading;
        private Label ya_label;
        private Label label4;
        private Label za_label;
        private Label za_reading;
    }
}