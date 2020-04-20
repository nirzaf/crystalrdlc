namespace crystalrdlc
{
    partial class UpdateDelay
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
            this.picHourGlass = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pbUpdate = new System.Windows.Forms.ProgressBar();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHourGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // picHourGlass
            // 
            this.picHourGlass.Location = new System.Drawing.Point(2, 3);
            this.picHourGlass.Name = "picHourGlass";
            this.picHourGlass.Size = new System.Drawing.Size(25, 25);
            this.picHourGlass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHourGlass.TabIndex = 55;
            this.picHourGlass.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            // pbUpdate
            // 
            this.pbUpdate.Location = new System.Drawing.Point(30, 2);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(413, 27);
            this.pbUpdate.TabIndex = 54;
            // 
            // timerDelay
            // 
            this.timerDelay.Enabled = true;
            this.timerDelay.Interval = 1000;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UpdateDelay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 31);
            this.ControlBox = false;
            this.Controls.Add(this.picHourGlass);
            this.Controls.Add(this.pbUpdate);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateDelay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDelay";
            this.Load += new System.EventHandler(this.UpdateDelay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHourGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHourGlass;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ProgressBar pbUpdate;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Timer timer1;
    }
}