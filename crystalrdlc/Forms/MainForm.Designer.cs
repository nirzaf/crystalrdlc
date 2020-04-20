namespace crystalrdlc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelBOTTOM = new System.Windows.Forms.Panel();
            this.panelBOTTOM_RIGHT = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.panelBOTTOM_RIGHT_RIGHT = new System.Windows.Forms.Panel();
            this.bttnLast = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.bttnPrevious = new System.Windows.Forms.Button();
            this.bttnFirst = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPreview = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbCrystalReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCrystal_Selected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCrystal_All = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRDLCReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRDLC_Selected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRDLC_All = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.chCustomerCode = new System.Windows.Forms.ColumnHeader();
            this.chCourtesyTitle = new System.Windows.Forms.ColumnHeader();
            this.chFullname = new System.Windows.Forms.ColumnHeader();
            this.chCreditLimit = new System.Windows.Forms.ColumnHeader();
            this.chGender = new System.Windows.Forms.ColumnHeader();
            this.chAddress = new System.Windows.Forms.ColumnHeader();
            this.chPhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.chCellNumber = new System.Windows.Forms.ColumnHeader();
            this.chStatus = new System.Windows.Forms.ColumnHeader();
            this.cmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemReload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCrystalReport = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCrystal_Selected = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCrystal_All = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRDLCReport = new System.Windows.Forms.ToolStripMenuItem();
            this.RDLC_Selected = new System.Windows.Forms.ToolStripMenuItem();
            this.RDLC_All = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.i24x24 = new System.Windows.Forms.ImageList(this.components);
            this.i32x32 = new System.Windows.Forms.ImageList(this.components);
            this.i16x16 = new System.Windows.Forms.ImageList(this.components);
            this.panelBOTTOM.SuspendLayout();
            this.panelBOTTOM_RIGHT.SuspendLayout();
            this.panelBOTTOM_RIGHT_RIGHT.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.cmenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBOTTOM
            // 
            this.panelBOTTOM.BackColor = System.Drawing.Color.White;
            this.panelBOTTOM.Controls.Add(this.panelBOTTOM_RIGHT);
            this.panelBOTTOM.Controls.Add(this.lblSelected);
            this.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBOTTOM.Location = new System.Drawing.Point(0, 381);
            this.panelBOTTOM.Name = "panelBOTTOM";
            this.panelBOTTOM.Size = new System.Drawing.Size(515, 34);
            this.panelBOTTOM.TabIndex = 5;
            // 
            // panelBOTTOM_RIGHT
            // 
            this.panelBOTTOM_RIGHT.BackColor = System.Drawing.Color.Transparent;
            this.panelBOTTOM_RIGHT.Controls.Add(this.lblRecordCount);
            this.panelBOTTOM_RIGHT.Controls.Add(this.panelBOTTOM_RIGHT_RIGHT);
            this.panelBOTTOM_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBOTTOM_RIGHT.Location = new System.Drawing.Point(60, 0);
            this.panelBOTTOM_RIGHT.Name = "panelBOTTOM_RIGHT";
            this.panelBOTTOM_RIGHT.Size = new System.Drawing.Size(455, 34);
            this.panelBOTTOM_RIGHT.TabIndex = 2;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Location = new System.Drawing.Point(47, 11);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(278, 15);
            this.lblRecordCount.TabIndex = 8;
            this.lblRecordCount.Text = "Record 0 - 0 of 0";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelBOTTOM_RIGHT_RIGHT
            // 
            this.panelBOTTOM_RIGHT_RIGHT.Controls.Add(this.bttnLast);
            this.panelBOTTOM_RIGHT_RIGHT.Controls.Add(this.bttnNext);
            this.panelBOTTOM_RIGHT_RIGHT.Controls.Add(this.bttnPrevious);
            this.panelBOTTOM_RIGHT_RIGHT.Controls.Add(this.bttnFirst);
            this.panelBOTTOM_RIGHT_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBOTTOM_RIGHT_RIGHT.Location = new System.Drawing.Point(326, 0);
            this.panelBOTTOM_RIGHT_RIGHT.Name = "panelBOTTOM_RIGHT_RIGHT";
            this.panelBOTTOM_RIGHT_RIGHT.Size = new System.Drawing.Size(129, 34);
            this.panelBOTTOM_RIGHT_RIGHT.TabIndex = 7;
            // 
            // bttnLast
            // 
            this.bttnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLast.Enabled = false;
            this.bttnLast.Location = new System.Drawing.Point(94, 3);
            this.bttnLast.Name = "bttnLast";
            this.bttnLast.Size = new System.Drawing.Size(30, 30);
            this.bttnLast.TabIndex = 10;
            this.bttnLast.UseVisualStyleBackColor = true;
            this.bttnLast.Click += new System.EventHandler(this.bttnLast_Click);
            // 
            // bttnNext
            // 
            this.bttnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNext.Enabled = false;
            this.bttnNext.Location = new System.Drawing.Point(65, 3);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(30, 30);
            this.bttnNext.TabIndex = 9;
            this.bttnNext.UseVisualStyleBackColor = true;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click);
            // 
            // bttnPrevious
            // 
            this.bttnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnPrevious.Enabled = false;
            this.bttnPrevious.Location = new System.Drawing.Point(36, 3);
            this.bttnPrevious.Name = "bttnPrevious";
            this.bttnPrevious.Size = new System.Drawing.Size(30, 30);
            this.bttnPrevious.TabIndex = 8;
            this.bttnPrevious.UseVisualStyleBackColor = true;
            this.bttnPrevious.Click += new System.EventHandler(this.bttnPrevious_Click);
            // 
            // bttnFirst
            // 
            this.bttnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFirst.Enabled = false;
            this.bttnFirst.Location = new System.Drawing.Point(7, 3);
            this.bttnFirst.Name = "bttnFirst";
            this.bttnFirst.Size = new System.Drawing.Size(30, 30);
            this.bttnFirst.TabIndex = 7;
            this.bttnFirst.UseVisualStyleBackColor = true;
            this.bttnFirst.Click += new System.EventHandler(this.bttnFirst_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(3, 10);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(139, 15);
            this.lblSelected.TabIndex = 0;
            this.lblSelected.Text = "Selected Record: NONE";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator1,
            this.tsbModify,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.tsbSearch,
            this.toolStripSeparator4,
            this.tsbReload,
            this.toolStripSeparator5,
            this.tsbPreview,
            this.toolStripSeparator6,
            this.tsbClose,
            this.toolStripSeparator7});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(515, 39);
            this.toolStrip.TabIndex = 7;
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 36);
            this.tsbNew.ToolTipText = "ADD NEW";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbModify
            // 
            this.tsbModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(36, 36);
            this.tsbModify.ToolTipText = "MODIFY";
            this.tsbModify.Click += new System.EventHandler(this.tsbModify_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(36, 36);
            this.tsbDelete.ToolTipText = "DELETE";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(36, 36);
            this.tsbSearch.ToolTipText = "SEARCH";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.Image = ((System.Drawing.Image)(resources.GetObject("tsbReload.Image")));
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(36, 36);
            this.tsbReload.ToolTipText = "RELOAD";
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbPreview
            // 
            this.tsbPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPreview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCrystalReport,
            this.tsbRDLCReport});
            this.tsbPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbPreview.Image")));
            this.tsbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreview.Name = "tsbPreview";
            this.tsbPreview.Size = new System.Drawing.Size(45, 36);
            this.tsbPreview.Text = "toolStripDropDownButton1";
            // 
            // tsbCrystalReport
            // 
            this.tsbCrystalReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCrystal_Selected,
            this.tsbCrystal_All});
            this.tsbCrystalReport.Name = "tsbCrystalReport";
            this.tsbCrystalReport.Size = new System.Drawing.Size(161, 22);
            this.tsbCrystalReport.Text = "&Crystal Report";
            // 
            // tsbCrystal_Selected
            // 
            this.tsbCrystal_Selected.Name = "tsbCrystal_Selected";
            this.tsbCrystal_Selected.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsbCrystal_Selected.Size = new System.Drawing.Size(180, 22);
            this.tsbCrystal_Selected.Text = "&Print Selected";
            this.tsbCrystal_Selected.Click += new System.EventHandler(this.tsbCrystal_Selected_Click);
            // 
            // tsbCrystal_All
            // 
            this.tsbCrystal_All.Name = "tsbCrystal_All";
            this.tsbCrystal_All.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tsbCrystal_All.Size = new System.Drawing.Size(180, 22);
            this.tsbCrystal_All.Text = "&Print All";
            this.tsbCrystal_All.Click += new System.EventHandler(this.tsbCrystal_All_Click);
            // 
            // tsbRDLCReport
            // 
            this.tsbRDLCReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRDLC_Selected,
            this.tsbRDLC_All});
            this.tsbRDLCReport.Name = "tsbRDLCReport";
            this.tsbRDLCReport.Size = new System.Drawing.Size(161, 22);
            this.tsbRDLCReport.Text = "&RDLC Report";
            // 
            // tsbRDLC_Selected
            // 
            this.tsbRDLC_Selected.Name = "tsbRDLC_Selected";
            this.tsbRDLC_Selected.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.tsbRDLC_Selected.Size = new System.Drawing.Size(180, 22);
            this.tsbRDLC_Selected.Text = "&Print Selected";
            this.tsbRDLC_Selected.Click += new System.EventHandler(this.tsbRDLC_Selected_Click);
            // 
            // tsbRDLC_All
            // 
            this.tsbRDLC_All.Name = "tsbRDLC_All";
            this.tsbRDLC_All.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.tsbRDLC_All.Size = new System.Drawing.Size(180, 22);
            this.tsbRDLC_All.Text = "&Print All";
            this.tsbRDLC_All.Click += new System.EventHandler(this.tsbRDLC_All_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(36, 36);
            this.tsbClose.ToolTipText = "CLOSE";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // lvCustomers
            // 
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCustomerCode,
            this.chCourtesyTitle,
            this.chFullname,
            this.chCreditLimit,
            this.chGender,
            this.chAddress,
            this.chPhoneNumber,
            this.chCellNumber,
            this.chStatus});
            this.lvCustomers.ContextMenuStrip = this.cmenustrip;
            this.lvCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCustomers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCustomers.ForeColor = System.Drawing.Color.Black;
            this.lvCustomers.FullRowSelect = true;
            this.lvCustomers.GridLines = true;
            this.lvCustomers.Location = new System.Drawing.Point(0, 39);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(515, 342);
            this.lvCustomers.TabIndex = 8;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            this.lvCustomers.DoubleClick += new System.EventHandler(this.lvCustomers_DoubleClick);
            this.lvCustomers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvCustomers_ColumnClick);
            this.lvCustomers.Leave += new System.EventHandler(this.lvCustomers_Leave);
            this.lvCustomers.Click += new System.EventHandler(this.lvCustomers_Click);
            // 
            // chCustomerCode
            // 
            this.chCustomerCode.Text = "Customer Code";
            this.chCustomerCode.Width = 150;
            // 
            // chCourtesyTitle
            // 
            this.chCourtesyTitle.Text = "Courtesy Title";
            this.chCourtesyTitle.Width = 120;
            // 
            // chFullname
            // 
            this.chFullname.Text = "Fullname";
            this.chFullname.Width = 250;
            // 
            // chCreditLimit
            // 
            this.chCreditLimit.Text = "Credit Limit";
            this.chCreditLimit.Width = 250;
            // 
            // chGender
            // 
            this.chGender.Text = "Gender";
            this.chGender.Width = 100;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Complete Address";
            this.chAddress.Width = 350;
            // 
            // chPhoneNumber
            // 
            this.chPhoneNumber.Text = "Phone Number";
            this.chPhoneNumber.Width = 150;
            // 
            // chCellNumber
            // 
            this.chCellNumber.Text = "Cell Number";
            this.chCellNumber.Width = 150;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 100;
            // 
            // cmenustrip
            // 
            this.cmenustrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemNew,
            this.toolStripSeparator8,
            this.cmsItemModify,
            this.toolStripSeparator9,
            this.cmsItemDelete,
            this.toolStripSeparator10,
            this.cmsItemSearch,
            this.toolStripSeparator11,
            this.cmsItemReload,
            this.toolStripSeparator12,
            this.cmsItemPreview,
            this.toolStripSeparator13,
            this.cmsItemClose});
            this.cmenustrip.Name = "cmenustrip";
            this.cmenustrip.Size = new System.Drawing.Size(148, 194);
            // 
            // cmsItemNew
            // 
            this.cmsItemNew.Name = "cmsItemNew";
            this.cmsItemNew.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.cmsItemNew.Size = new System.Drawing.Size(147, 22);
            this.cmsItemNew.Text = "&Add New";
            this.cmsItemNew.Click += new System.EventHandler(this.cmsItemNew_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(144, 6);
            // 
            // cmsItemModify
            // 
            this.cmsItemModify.Name = "cmsItemModify";
            this.cmsItemModify.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cmsItemModify.Size = new System.Drawing.Size(147, 22);
            this.cmsItemModify.Text = "&Modify";
            this.cmsItemModify.Click += new System.EventHandler(this.cmsItemModify_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(144, 6);
            // 
            // cmsItemDelete
            // 
            this.cmsItemDelete.Name = "cmsItemDelete";
            this.cmsItemDelete.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.cmsItemDelete.Size = new System.Drawing.Size(147, 22);
            this.cmsItemDelete.Text = "&Delete";
            this.cmsItemDelete.Click += new System.EventHandler(this.cmsItemDelete_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(144, 6);
            // 
            // cmsItemSearch
            // 
            this.cmsItemSearch.Name = "cmsItemSearch";
            this.cmsItemSearch.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cmsItemSearch.Size = new System.Drawing.Size(147, 22);
            this.cmsItemSearch.Text = "&Search";
            this.cmsItemSearch.Click += new System.EventHandler(this.cmsItemSearch_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(144, 6);
            // 
            // cmsItemReload
            // 
            this.cmsItemReload.Name = "cmsItemReload";
            this.cmsItemReload.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.cmsItemReload.Size = new System.Drawing.Size(147, 22);
            this.cmsItemReload.Text = "&Reload";
            this.cmsItemReload.Click += new System.EventHandler(this.cmsItemReload_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(144, 6);
            // 
            // cmsItemPreview
            // 
            this.cmsItemPreview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCrystalReport,
            this.cmsRDLCReport});
            this.cmsItemPreview.Name = "cmsItemPreview";
            this.cmsItemPreview.Size = new System.Drawing.Size(147, 22);
            this.cmsItemPreview.Text = "&Preview";
            // 
            // cmsCrystalReport
            // 
            this.cmsCrystalReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCrystal_Selected,
            this.cmsCrystal_All});
            this.cmsCrystalReport.Name = "cmsCrystalReport";
            this.cmsCrystalReport.Size = new System.Drawing.Size(155, 22);
            this.cmsCrystalReport.Text = "&Crystal Report";
            // 
            // cmsCrystal_Selected
            // 
            this.cmsCrystal_Selected.Name = "cmsCrystal_Selected";
            this.cmsCrystal_Selected.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.cmsCrystal_Selected.Size = new System.Drawing.Size(170, 22);
            this.cmsCrystal_Selected.Text = "&Print Selected";
            this.cmsCrystal_Selected.Click += new System.EventHandler(this.cmsCrystal_Selected_Click);
            // 
            // cmsCrystal_All
            // 
            this.cmsCrystal_All.Name = "cmsCrystal_All";
            this.cmsCrystal_All.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.cmsCrystal_All.Size = new System.Drawing.Size(170, 22);
            this.cmsCrystal_All.Text = "&Print All";
            this.cmsCrystal_All.Click += new System.EventHandler(this.cmsCrystal_All_Click);
            // 
            // cmsRDLCReport
            // 
            this.cmsRDLCReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RDLC_Selected,
            this.RDLC_All});
            this.cmsRDLCReport.Name = "cmsRDLCReport";
            this.cmsRDLCReport.Size = new System.Drawing.Size(155, 22);
            this.cmsRDLCReport.Text = "&RDLC Report";
            // 
            // RDLC_Selected
            // 
            this.RDLC_Selected.Name = "RDLC_Selected";
            this.RDLC_Selected.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.RDLC_Selected.Size = new System.Drawing.Size(170, 22);
            this.RDLC_Selected.Text = "&Print Selected";
            this.RDLC_Selected.Click += new System.EventHandler(this.RDLC_Selected_Click);
            // 
            // RDLC_All
            // 
            this.RDLC_All.Name = "RDLC_All";
            this.RDLC_All.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.RDLC_All.Size = new System.Drawing.Size(170, 22);
            this.RDLC_All.Text = "&Print All";
            this.RDLC_All.Click += new System.EventHandler(this.RDLC_All_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(144, 6);
            // 
            // cmsItemClose
            // 
            this.cmsItemClose.Name = "cmsItemClose";
            this.cmsItemClose.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.cmsItemClose.Size = new System.Drawing.Size(147, 22);
            this.cmsItemClose.Text = "&Close";
            this.cmsItemClose.Click += new System.EventHandler(this.cmsItemClose_Click);
            // 
            // i24x24
            // 
            this.i24x24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i24x24.ImageStream")));
            this.i24x24.TransparentColor = System.Drawing.Color.Transparent;
            this.i24x24.Images.SetKeyName(0, "_2player_start.png");
            this.i24x24.Images.SetKeyName(1, "_2player_play_prev.png");
            this.i24x24.Images.SetKeyName(2, "_2player_play.png");
            this.i24x24.Images.SetKeyName(3, "_2player_end.png");
            this.i24x24.Images.SetKeyName(4, "purchase.png");
            this.i24x24.Images.SetKeyName(5, "3.png");
            this.i24x24.Images.SetKeyName(6, "1.png");
            this.i24x24.Images.SetKeyName(7, "2.png");
            this.i24x24.Images.SetKeyName(8, "3.png");
            this.i24x24.Images.SetKeyName(9, "4.png");
            this.i24x24.Images.SetKeyName(10, "3.png");
            // 
            // i32x32
            // 
            this.i32x32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i32x32.ImageStream")));
            this.i32x32.TransparentColor = System.Drawing.Color.Transparent;
            this.i32x32.Images.SetKeyName(0, "ADD-NEW.png");
            this.i32x32.Images.SetKeyName(1, "MODIFY.png");
            this.i32x32.Images.SetKeyName(2, "SEARCH.png");
            this.i32x32.Images.SetKeyName(3, "DELETE.png");
            this.i32x32.Images.SetKeyName(4, "RELOAD.png");
            this.i32x32.Images.SetKeyName(5, "PREVIEW.png");
            this.i32x32.Images.SetKeyName(6, "CLOSE.png");
            this.i32x32.Images.SetKeyName(7, "hand.png");
            this.i32x32.Images.SetKeyName(8, "17.png");
            this.i32x32.Images.SetKeyName(9, "error.png");
            this.i32x32.Images.SetKeyName(10, "business info.png");
            this.i32x32.Images.SetKeyName(11, "VIEW.png");
            this.i32x32.Images.SetKeyName(12, "SELECT.png");
            // 
            // i16x16
            // 
            this.i16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i16x16.ImageStream")));
            this.i16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.i16x16.Images.SetKeyName(0, "");
            this.i16x16.Images.SetKeyName(1, "");
            this.i16x16.Images.SetKeyName(2, "");
            this.i16x16.Images.SetKeyName(3, "");
            this.i16x16.Images.SetKeyName(4, "");
            this.i16x16.Images.SetKeyName(5, "");
            this.i16x16.Images.SetKeyName(6, "");
            this.i16x16.Images.SetKeyName(7, "");
            this.i16x16.Images.SetKeyName(8, "");
            this.i16x16.Images.SetKeyName(9, "");
            this.i16x16.Images.SetKeyName(10, "");
            this.i16x16.Images.SetKeyName(11, "");
            this.i16x16.Images.SetKeyName(12, "");
            this.i16x16.Images.SetKeyName(13, "");
            this.i16x16.Images.SetKeyName(14, "");
            this.i16x16.Images.SetKeyName(15, "");
            this.i16x16.Images.SetKeyName(16, "");
            this.i16x16.Images.SetKeyName(17, "purchase.png");
            this.i16x16.Images.SetKeyName(18, "224.png");
            this.i16x16.Images.SetKeyName(19, "SELECT.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 415);
            this.Controls.Add(this.lvCustomers);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panelBOTTOM);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRYSTAL V.S. RDLC REPORT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelBOTTOM.ResumeLayout(false);
            this.panelBOTTOM.PerformLayout();
            this.panelBOTTOM_RIGHT.ResumeLayout(false);
            this.panelBOTTOM_RIGHT_RIGHT.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.cmenustrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBOTTOM;
        private System.Windows.Forms.Panel panelBOTTOM_RIGHT;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Panel panelBOTTOM_RIGHT_RIGHT;
        private System.Windows.Forms.Button bttnLast;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Button bttnPrevious;
        private System.Windows.Forms.Button bttnFirst;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton tsbPreview;
        private System.Windows.Forms.ToolStripMenuItem tsbCrystalReport;
        private System.Windows.Forms.ToolStripMenuItem tsbRDLCReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader chCustomerCode;
        private System.Windows.Forms.ColumnHeader chCourtesyTitle;
        private System.Windows.Forms.ColumnHeader chFullname;
        private System.Windows.Forms.ColumnHeader chCreditLimit;
        private System.Windows.Forms.ColumnHeader chGender;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chPhoneNumber;
        private System.Windows.Forms.ColumnHeader chCellNumber;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ContextMenuStrip cmenustrip;
        private System.Windows.Forms.ToolStripMenuItem cmsItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem cmsItemModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem cmsItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem cmsItemSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem cmsItemReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem cmsItemPreview;
        private System.Windows.Forms.ToolStripMenuItem cmsCrystalReport;
        private System.Windows.Forms.ToolStripMenuItem cmsRDLCReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem cmsItemClose;
        public System.Windows.Forms.ImageList i24x24;
        public System.Windows.Forms.ImageList i32x32;
        public System.Windows.Forms.ImageList i16x16;
        private System.Windows.Forms.ToolStripMenuItem tsbCrystal_Selected;
        private System.Windows.Forms.ToolStripMenuItem tsbCrystal_All;
        private System.Windows.Forms.ToolStripMenuItem tsbRDLC_Selected;
        private System.Windows.Forms.ToolStripMenuItem tsbRDLC_All;
        private System.Windows.Forms.ToolStripMenuItem cmsCrystal_Selected;
        private System.Windows.Forms.ToolStripMenuItem cmsCrystal_All;
        private System.Windows.Forms.ToolStripMenuItem RDLC_Selected;
        private System.Windows.Forms.ToolStripMenuItem RDLC_All;
    }
}