namespace crystalrdlc
{
    partial class WebCamera
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)){components.Dispose();}
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picHourGlass = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnProcess = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.pbUpdate = new System.Windows.Forms.ProgressBar();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.ctrlCamera1 = new crystalrdlc.ctrlCamera();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHourGlass)).BeginInit();
            this.panelCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 1000;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // picCamera
            // 
            this.picCamera.BackColor = System.Drawing.Color.White;
            this.picCamera.Location = new System.Drawing.Point(-2, -2);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(359, 357);
            this.picCamera.TabIndex = 48;
            this.picCamera.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picHourGlass
            // 
            this.picHourGlass.Location = new System.Drawing.Point(6, 371);
            this.picHourGlass.Name = "picHourGlass";
            this.picHourGlass.Size = new System.Drawing.Size(25, 25);
            this.picHourGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHourGlass.TabIndex = 194;
            this.picHourGlass.TabStop = false;
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 16);
            this.label6.TabIndex = 193;
            this.label6.Text = "Click the process to get the picture.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(4, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 192;
            this.label5.Text = "[ Web Camera ]";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(274, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 191;
            this.label13.Text = "&Process";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(325, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 190;
            this.label11.Text = "&Cancel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnProcess
            // 
            this.bttnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnProcess.Location = new System.Drawing.Point(279, 403);
            this.bttnProcess.Name = "bttnProcess";
            this.bttnProcess.Size = new System.Drawing.Size(40, 40);
            this.bttnProcess.TabIndex = 188;
            this.bttnProcess.UseVisualStyleBackColor = true;
            this.bttnProcess.Click += new System.EventHandler(this.bttnProcess_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(324, 403);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 189;
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // pbUpdate
            // 
            this.pbUpdate.Location = new System.Drawing.Point(33, 370);
            this.pbUpdate.Maximum = 200;
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(333, 27);
            this.pbUpdate.TabIndex = 187;
            this.pbUpdate.UseWaitCursor = true;
            // 
            // panelCamera
            // 
            this.panelCamera.BackColor = System.Drawing.Color.White;
            this.panelCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCamera.Controls.Add(this.picCamera);
            this.panelCamera.Location = new System.Drawing.Point(6, 5);
            this.panelCamera.Name = "panelCamera";
            this.panelCamera.Size = new System.Drawing.Size(361, 359);
            this.panelCamera.TabIndex = 186;
            // 
            // ctrlCamera1
            // 
            this.ctrlCamera1.CaptureHeight = 240;
            this.ctrlCamera1.CaptureWidth = 320;
            this.ctrlCamera1.FrameNumber = ((ulong)(0ul));
            this.ctrlCamera1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCamera1.Name = "ctrlCamera";
            this.ctrlCamera1.TabIndex = 0;
            this.ctrlCamera1.TimeToCapture_milliseconds = 100;
            this.ctrlCamera1.ImageCaptured += new crystalrdlc.ctrlCamera.WebCamEventHandler(this.ctrlCamera1_ImageCaptured);
            // 
            // WebCamera
            // 
            this.AcceptButton = this.bttnProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bttnCancel;
            this.ClientSize = new System.Drawing.Size(371, 466);
            this.ControlBox = false;
            this.Controls.Add(this.picHourGlass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttnProcess);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.pbUpdate);
            this.Controls.Add(this.panelCamera);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WebCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebCamera_FormClosing);
            this.Load += new System.EventHandler(this.WebCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHourGlass)).EndInit();
            this.panelCamera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerDelay;
        public System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picHourGlass;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttnProcess;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.ProgressBar pbUpdate;
        private System.Windows.Forms.Panel panelCamera;
        private ctrlCamera ctrlCamera1;
    }
}