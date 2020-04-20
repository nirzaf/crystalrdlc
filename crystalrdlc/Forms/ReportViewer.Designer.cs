namespace crystalrdlc
{
    partial class ReportViewer
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
            this.rdlcviewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.crystalviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rdlcviewer
            // 
            this.rdlcviewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdlcviewer.Location = new System.Drawing.Point(25, 36);
            this.rdlcviewer.Name = "rdlcviewer";
            this.rdlcviewer.Size = new System.Drawing.Size(368, 268);
            this.rdlcviewer.TabIndex = 0;
            this.rdlcviewer.Visible = false;
            // 
            // crystalviewer
            // 
            this.crystalviewer.ActiveViewIndex = -1;
            this.crystalviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalviewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crystalviewer.DisplayGroupTree = false;
            this.crystalviewer.Location = new System.Drawing.Point(399, 36);
            this.crystalviewer.Name = "crystalviewer";
            this.crystalviewer.SelectionFormula = "";
            this.crystalviewer.ShowCloseButton = false;
            this.crystalviewer.ShowGroupTreeButton = false;
            this.crystalviewer.ShowRefreshButton = false;
            this.crystalviewer.Size = new System.Drawing.Size(230, 250);
            this.crystalviewer.TabIndex = 1;
            this.crystalviewer.ViewTimeSelectionFormula = "";
            this.crystalviewer.Visible = false;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 524);
            this.Controls.Add(this.crystalviewer);
            this.Controls.Add(this.rdlcviewer);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rdlcviewer;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalviewer;
    }
}