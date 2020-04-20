namespace crystalrdlc
{
    partial class InputBox
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
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.picLOGO = new System.Windows.Forms.PictureBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUpdate.Location = new System.Drawing.Point(254, 21);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(100, 25);
            this.bttnUpdate.TabIndex = 81;
            this.bttnUpdate.Text = "&OK";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // picLOGO
            // 
            this.picLOGO.Location = new System.Drawing.Point(11, 21);
            this.picLOGO.Name = "picLOGO";
            this.picLOGO.Size = new System.Drawing.Size(32, 32);
            this.picLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLOGO.TabIndex = 80;
            this.picLOGO.TabStop = false;
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(49, 23);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(0, 16);
            this.lblEntry.TabIndex = 79;
            // 
            // txtEntry
            // 
            this.txtEntry.BackColor = System.Drawing.Color.White;
            this.txtEntry.Location = new System.Drawing.Point(11, 103);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(342, 21);
            this.txtEntry.TabIndex = 77;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(254, 50);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(100, 25);
            this.bttnCancel.TabIndex = 78;
            this.bttnCancel.Text = "&Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // InputBox
            // 
            this.AcceptButton = this.bttnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bttnCancel;
            this.ClientSize = new System.Drawing.Size(367, 139);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.picLOGO);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.bttnCancel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.InputBox_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputBox_FormClosing);
            this.Load += new System.EventHandler(this.InputBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.PictureBox picLOGO;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button bttnCancel;
    }
}