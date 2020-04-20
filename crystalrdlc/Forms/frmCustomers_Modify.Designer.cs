namespace crystalrdlc
{
    partial class frmCustomers_Modify
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
            this.label2 = new System.Windows.Forms.Label();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.bttnCT_Remove = new System.Windows.Forms.Button();
            this.bttnCT_New = new System.Windows.Forms.Button();
            this.cbCourtesyTitle = new System.Windows.Forms.ComboBox();
            this.lblNoPic = new System.Windows.Forms.Label();
            this.chActive = new System.Windows.Forms.CheckBox();
            this.panelPostalViewer = new System.Windows.Forms.Panel();
            this.lvPostalCode = new System.Windows.Forms.ListView();
            this.chPostalCode = new System.Windows.Forms.ColumnHeader();
            this.chProvince = new System.Windows.Forms.ColumnHeader();
            this.chCity = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bttnReload_PC = new System.Windows.Forms.Button();
            this.bttnSearch_PC = new System.Windows.Forms.Button();
            this.txtSearch_PC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnLast_PC = new System.Windows.Forms.Button();
            this.bttnNext_PC = new System.Windows.Forms.Button();
            this.bttnPrevious_PC = new System.Windows.Forms.Button();
            this.bttnFirst_PC = new System.Windows.Forms.Button();
            this.lblRecordCount_PC = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttnClose_PC = new System.Windows.Forms.Button();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnReset = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtCellNumber = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStateProv = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCityTown = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnBrowse = new System.Windows.Forms.Button();
            this.bttnCamera = new System.Windows.Forms.Button();
            this.picPostalCode = new System.Windows.Forms.PictureBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.panelPostalViewer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 325;
            this.label2.Text = "Credit Limit:";
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnGenerate.Location = new System.Drawing.Point(354, 31);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(23, 23);
            this.bttnGenerate.TabIndex = 324;
            this.bttnGenerate.UseVisualStyleBackColor = true;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click);
            // 
            // bttnCT_Remove
            // 
            this.bttnCT_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCT_Remove.Location = new System.Drawing.Point(354, 57);
            this.bttnCT_Remove.Name = "bttnCT_Remove";
            this.bttnCT_Remove.Size = new System.Drawing.Size(23, 23);
            this.bttnCT_Remove.TabIndex = 323;
            this.bttnCT_Remove.UseVisualStyleBackColor = true;
            this.bttnCT_Remove.Click += new System.EventHandler(this.bttnCT_Remove_Click);
            // 
            // bttnCT_New
            // 
            this.bttnCT_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCT_New.Location = new System.Drawing.Point(330, 57);
            this.bttnCT_New.Name = "bttnCT_New";
            this.bttnCT_New.Size = new System.Drawing.Size(23, 23);
            this.bttnCT_New.TabIndex = 322;
            this.bttnCT_New.UseVisualStyleBackColor = true;
            this.bttnCT_New.Click += new System.EventHandler(this.bttnCT_New_Click);
            // 
            // cbCourtesyTitle
            // 
            this.cbCourtesyTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCourtesyTitle.FormattingEnabled = true;
            this.cbCourtesyTitle.Location = new System.Drawing.Point(104, 58);
            this.cbCourtesyTitle.Name = "cbCourtesyTitle";
            this.cbCourtesyTitle.Size = new System.Drawing.Size(225, 23);
            this.cbCourtesyTitle.TabIndex = 321;
            this.cbCourtesyTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCourtesyTitle_KeyPress);
            // 
            // lblNoPic
            // 
            this.lblNoPic.BackColor = System.Drawing.Color.Black;
            this.lblNoPic.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPic.ForeColor = System.Drawing.Color.White;
            this.lblNoPic.Location = new System.Drawing.Point(431, 108);
            this.lblNoPic.Name = "lblNoPic";
            this.lblNoPic.Size = new System.Drawing.Size(177, 41);
            this.lblNoPic.TabIndex = 320;
            this.lblNoPic.Text = "NO P!C";
            this.lblNoPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chActive
            // 
            this.chActive.AutoSize = true;
            this.chActive.Checked = true;
            this.chActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chActive.Location = new System.Drawing.Point(321, 170);
            this.chActive.Name = "chActive";
            this.chActive.Size = new System.Drawing.Size(60, 18);
            this.chActive.TabIndex = 319;
            this.chActive.Text = "Active";
            this.chActive.UseVisualStyleBackColor = true;
            // 
            // panelPostalViewer
            // 
            this.panelPostalViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPostalViewer.Controls.Add(this.lvPostalCode);
            this.panelPostalViewer.Controls.Add(this.panel4);
            this.panelPostalViewer.Controls.Add(this.panel3);
            this.panelPostalViewer.Location = new System.Drawing.Point(104, 230);
            this.panelPostalViewer.Name = "panelPostalViewer";
            this.panelPostalViewer.Size = new System.Drawing.Size(0, 0);
            this.panelPostalViewer.TabIndex = 326;
            this.panelPostalViewer.Visible = false;
            this.panelPostalViewer.Leave += new System.EventHandler(this.panelPostalViewer_Leave);
            // 
            // lvPostalCode
            // 
            this.lvPostalCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPostalCode,
            this.chProvince,
            this.chCity});
            this.lvPostalCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPostalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPostalCode.FullRowSelect = true;
            this.lvPostalCode.GridLines = true;
            this.lvPostalCode.Location = new System.Drawing.Point(0, 23);
            this.lvPostalCode.Name = "lvPostalCode";
            this.lvPostalCode.Size = new System.Drawing.Size(0, 0);
            this.lvPostalCode.TabIndex = 266;
            this.lvPostalCode.UseCompatibleStateImageBehavior = false;
            this.lvPostalCode.View = System.Windows.Forms.View.Details;
            this.lvPostalCode.DoubleClick += new System.EventHandler(this.lvPostalCode_DoubleClick);
            this.lvPostalCode.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvPostalCode_ColumnClick);
            // 
            // chPostalCode
            // 
            this.chPostalCode.Text = "PostalCode";
            this.chPostalCode.Width = 150;
            // 
            // chProvince
            // 
            this.chProvince.Text = "Province";
            this.chProvince.Width = 150;
            // 
            // chCity
            // 
            this.chCity.Text = "City/Town";
            this.chCity.Width = 155;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.bttnReload_PC);
            this.panel4.Controls.Add(this.bttnSearch_PC);
            this.panel4.Controls.Add(this.txtSearch_PC);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.bttnLast_PC);
            this.panel4.Controls.Add(this.bttnNext_PC);
            this.panel4.Controls.Add(this.bttnPrevious_PC);
            this.panel4.Controls.Add(this.bttnFirst_PC);
            this.panel4.Controls.Add(this.lblRecordCount_PC);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, -30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 30);
            this.panel4.TabIndex = 265;
            // 
            // bttnReload_PC
            // 
            this.bttnReload_PC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReload_PC.Location = new System.Drawing.Point(223, 4);
            this.bttnReload_PC.Name = "bttnReload_PC";
            this.bttnReload_PC.Size = new System.Drawing.Size(23, 23);
            this.bttnReload_PC.TabIndex = 270;
            this.bttnReload_PC.UseVisualStyleBackColor = true;
            this.bttnReload_PC.Click += new System.EventHandler(this.bttnReload_PC_Click);
            // 
            // bttnSearch_PC
            // 
            this.bttnSearch_PC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearch_PC.Location = new System.Drawing.Point(200, 4);
            this.bttnSearch_PC.Name = "bttnSearch_PC";
            this.bttnSearch_PC.Size = new System.Drawing.Size(23, 23);
            this.bttnSearch_PC.TabIndex = 269;
            this.bttnSearch_PC.UseVisualStyleBackColor = true;
            this.bttnSearch_PC.Click += new System.EventHandler(this.bttnSearch_PC_Click);
            // 
            // txtSearch_PC
            // 
            this.txtSearch_PC.BackColor = System.Drawing.Color.White;
            this.txtSearch_PC.Location = new System.Drawing.Point(53, 5);
            this.txtSearch_PC.MaxLength = 15;
            this.txtSearch_PC.Name = "txtSearch_PC";
            this.txtSearch_PC.Size = new System.Drawing.Size(145, 21);
            this.txtSearch_PC.TabIndex = 268;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 267;
            this.label4.Text = "Search:";
            // 
            // bttnLast_PC
            // 
            this.bttnLast_PC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLast_PC.Enabled = false;
            this.bttnLast_PC.Location = new System.Drawing.Point(451, 5);
            this.bttnLast_PC.Name = "bttnLast_PC";
            this.bttnLast_PC.Size = new System.Drawing.Size(22, 22);
            this.bttnLast_PC.TabIndex = 266;
            this.bttnLast_PC.UseVisualStyleBackColor = true;
            this.bttnLast_PC.Click += new System.EventHandler(this.bttnLast_PC_Click);
            // 
            // bttnNext_PC
            // 
            this.bttnNext_PC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNext_PC.Enabled = false;
            this.bttnNext_PC.Location = new System.Drawing.Point(428, 5);
            this.bttnNext_PC.Name = "bttnNext_PC";
            this.bttnNext_PC.Size = new System.Drawing.Size(22, 22);
            this.bttnNext_PC.TabIndex = 265;
            this.bttnNext_PC.UseVisualStyleBackColor = true;
            this.bttnNext_PC.Click += new System.EventHandler(this.bttnNext_PC_Click);
            // 
            // bttnPrevious_PC
            // 
            this.bttnPrevious_PC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnPrevious_PC.Enabled = false;
            this.bttnPrevious_PC.Location = new System.Drawing.Point(405, 5);
            this.bttnPrevious_PC.Name = "bttnPrevious_PC";
            this.bttnPrevious_PC.Size = new System.Drawing.Size(22, 22);
            this.bttnPrevious_PC.TabIndex = 264;
            this.bttnPrevious_PC.UseVisualStyleBackColor = true;
            this.bttnPrevious_PC.Click += new System.EventHandler(this.bttnPrevious_PC_Click);
            // 
            // bttnFirst_PC
            // 
            this.bttnFirst_PC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFirst_PC.Enabled = false;
            this.bttnFirst_PC.Location = new System.Drawing.Point(382, 5);
            this.bttnFirst_PC.Name = "bttnFirst_PC";
            this.bttnFirst_PC.Size = new System.Drawing.Size(22, 22);
            this.bttnFirst_PC.TabIndex = 263;
            this.bttnFirst_PC.UseVisualStyleBackColor = true;
            this.bttnFirst_PC.Click += new System.EventHandler(this.bttnFirst_PC_Click);
            // 
            // lblRecordCount_PC
            // 
            this.lblRecordCount_PC.Location = new System.Drawing.Point(240, 9);
            this.lblRecordCount_PC.Name = "lblRecordCount_PC";
            this.lblRecordCount_PC.Size = new System.Drawing.Size(140, 15);
            this.lblRecordCount_PC.TabIndex = 262;
            this.lblRecordCount_PC.Text = "Record 0 - 0 of 0";
            this.lblRecordCount_PC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.bttnClose_PC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 23);
            this.panel3.TabIndex = 263;
            // 
            // bttnClose_PC
            // 
            this.bttnClose_PC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose_PC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnClose_PC.Location = new System.Drawing.Point(456, 1);
            this.bttnClose_PC.Name = "bttnClose_PC";
            this.bttnClose_PC.Size = new System.Drawing.Size(20, 20);
            this.bttnClose_PC.TabIndex = 258;
            this.bttnClose_PC.UseVisualStyleBackColor = true;
            this.bttnClose_PC.Click += new System.EventHandler(this.bttnClose_PC_Click);
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.BackColor = System.Drawing.Color.White;
            this.txtCreditLimit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCreditLimit.Location = new System.Drawing.Point(105, 348);
            this.txtCreditLimit.MaxLength = 20;
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(272, 22);
            this.txtCreditLimit.TabIndex = 284;
            this.txtCreditLimit.Text = "0.00";
            this.txtCreditLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditLimit_KeyPress);
            this.txtCreditLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCreditLimit_KeyDown);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.Color.White;
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostalCode.Location = new System.Drawing.Point(105, 215);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.ReadOnly = true;
            this.txtPostalCode.Size = new System.Drawing.Size(246, 14);
            this.txtPostalCode.TabIndex = 317;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(104, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(271, 21);
            this.textBox1.TabIndex = 316;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 16);
            this.label6.TabIndex = 314;
            this.label6.Text = "This form contains all information about the customer.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(13, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 313;
            this.label5.Text = "[ Customer Entry ]";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(478, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 312;
            this.label13.Text = "&Update";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(526, 571);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 311;
            this.label12.Text = "&Reset";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(572, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 310;
            this.label11.Text = "&Cancel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnReset
            // 
            this.bttnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReset.Location = new System.Drawing.Point(526, 528);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(40, 40);
            this.bttnReset.TabIndex = 308;
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUpdate.Location = new System.Drawing.Point(480, 528);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(40, 40);
            this.bttnUpdate.TabIndex = 307;
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(572, 528);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 309;
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 306;
            this.label1.Text = "Cell Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(105, 380);
            this.txtPhoneNumber.Mask = "(999) 000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(272, 21);
            this.txtPhoneNumber.TabIndex = 285;
            // 
            // txtCellNumber
            // 
            this.txtCellNumber.BackColor = System.Drawing.Color.White;
            this.txtCellNumber.Location = new System.Drawing.Point(105, 411);
            this.txtCellNumber.MaxLength = 20;
            this.txtCellNumber.Name = "txtCellNumber";
            this.txtCellNumber.Size = new System.Drawing.Size(272, 21);
            this.txtCellNumber.TabIndex = 286;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 443);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 305;
            this.label18.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(105, 443);
            this.txtComments.MaxLength = 100;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(272, 64);
            this.txtComments.TabIndex = 287;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 385);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 15);
            this.label20.TabIndex = 304;
            this.label20.Text = "Phone Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 301;
            this.label14.Text = "Postal Code:";
            // 
            // txtStateProv
            // 
            this.txtStateProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.txtStateProv.Location = new System.Drawing.Point(104, 242);
            this.txtStateProv.MaxLength = 50;
            this.txtStateProv.Name = "txtStateProv";
            this.txtStateProv.ReadOnly = true;
            this.txtStateProv.Size = new System.Drawing.Size(271, 21);
            this.txtStateProv.TabIndex = 303;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 15);
            this.label15.TabIndex = 300;
            this.label15.Text = "State/Province:";
            // 
            // txtCityTown
            // 
            this.txtCityTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.txtCityTown.Location = new System.Drawing.Point(104, 273);
            this.txtCityTown.MaxLength = 50;
            this.txtCityTown.Name = "txtCityTown";
            this.txtCityTown.ReadOnly = true;
            this.txtCityTown.Size = new System.Drawing.Size(271, 21);
            this.txtCityTown.TabIndex = 302;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 299;
            this.label16.Text = "City/Town:";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.Color.White;
            this.txtStreetAddress.Location = new System.Drawing.Point(105, 303);
            this.txtStreetAddress.MaxLength = 100;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(271, 21);
            this.txtStreetAddress.TabIndex = 283;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 15);
            this.label17.TabIndex = 298;
            this.label17.Text = "Street Address:";
            // 
            // cbGender
            // 
            this.cbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(105, 167);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(145, 23);
            this.cbGender.TabIndex = 282;
            this.cbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGender_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(14, 63);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 15);
            this.label31.TabIndex = 297;
            this.label31.Text = "Courtesy Title:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 171);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 15);
            this.label30.TabIndex = 296;
            this.label30.Text = "Gender:";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.White;
            this.txtLastname.Location = new System.Drawing.Point(105, 140);
            this.txtLastname.MaxLength = 15;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(270, 21);
            this.txtLastname.TabIndex = 281;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 295;
            this.label9.Text = "Last Name:";
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.BackColor = System.Drawing.Color.White;
            this.txtMiddlename.Location = new System.Drawing.Point(105, 112);
            this.txtMiddlename.MaxLength = 15;
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(270, 21);
            this.txtMiddlename.TabIndex = 280;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 294;
            this.label10.Text = "Middle Name:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.White;
            this.txtFirstname.Location = new System.Drawing.Point(105, 85);
            this.txtFirstname.MaxLength = 15;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(270, 21);
            this.txtFirstname.TabIndex = 279;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 293;
            this.label8.Text = "First Name:";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.txtCustomerCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCustomerCode.Location = new System.Drawing.Point(105, 31);
            this.txtCustomerCode.MaxLength = 20;
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ReadOnly = true;
            this.txtCustomerCode.Size = new System.Drawing.Size(247, 21);
            this.txtCustomerCode.TabIndex = 292;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 291;
            this.label7.Text = "Customer Code:";
            // 
            // bttnBrowse
            // 
            this.bttnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnBrowse.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBrowse.Location = new System.Drawing.Point(429, 256);
            this.bttnBrowse.Name = "bttnBrowse";
            this.bttnBrowse.Size = new System.Drawing.Size(180, 24);
            this.bttnBrowse.TabIndex = 290;
            this.bttnBrowse.Text = "Browse Picture";
            this.bttnBrowse.UseVisualStyleBackColor = true;
            this.bttnBrowse.Click += new System.EventHandler(this.bttnBrowse_Click);
            // 
            // bttnCamera
            // 
            this.bttnCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCamera.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCamera.Location = new System.Drawing.Point(429, 230);
            this.bttnCamera.Name = "bttnCamera";
            this.bttnCamera.Size = new System.Drawing.Size(180, 24);
            this.bttnCamera.TabIndex = 289;
            this.bttnCamera.Text = "Camera Picture";
            this.bttnCamera.UseVisualStyleBackColor = true;
            this.bttnCamera.Click += new System.EventHandler(this.bttnCamera_Click);
            // 
            // picPostalCode
            // 
            this.picPostalCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPostalCode.Image = global::crystalrdlc.Properties.Resources.downarrow;
            this.picPostalCode.Location = new System.Drawing.Point(357, 213);
            this.picPostalCode.Name = "picPostalCode";
            this.picPostalCode.Size = new System.Drawing.Size(17, 19);
            this.picPostalCode.TabIndex = 318;
            this.picPostalCode.TabStop = false;
            this.picPostalCode.Click += new System.EventHandler(this.picPostalCode_Click);
            // 
            // picHeader
            // 
            this.picHeader.BackgroundImage = global::crystalrdlc.Properties.Resources.menu_09;
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(619, 29);
            this.picHeader.TabIndex = 315;
            this.picHeader.TabStop = false;
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.Color.Black;
            this.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomer.Location = new System.Drawing.Point(429, 34);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(180, 190);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomer.TabIndex = 288;
            this.picCustomer.TabStop = false;
            // 
            // frmCustomers_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.bttnCT_Remove);
            this.Controls.Add(this.bttnCT_New);
            this.Controls.Add(this.cbCourtesyTitle);
            this.Controls.Add(this.lblNoPic);
            this.Controls.Add(this.chActive);
            this.Controls.Add(this.panelPostalViewer);
            this.Controls.Add(this.txtCreditLimit);
            this.Controls.Add(this.picPostalCode);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCellNumber);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtStateProv);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCityTown);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttnBrowse);
            this.Controls.Add(this.bttnCamera);
            this.Controls.Add(this.picCustomer);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmCustomers_Modify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Customer ";
            this.Load += new System.EventHandler(this.frmCustomers_Modify_Load);
            this.panelPostalViewer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Windows.Forms.Button bttnCT_Remove;
        private System.Windows.Forms.Button bttnCT_New;
        private System.Windows.Forms.ComboBox cbCourtesyTitle;
        private System.Windows.Forms.Label lblNoPic;
        private System.Windows.Forms.CheckBox chActive;
        private System.Windows.Forms.Panel panelPostalViewer;
        private System.Windows.Forms.ListView lvPostalCode;
        private System.Windows.Forms.ColumnHeader chPostalCode;
        private System.Windows.Forms.ColumnHeader chProvince;
        private System.Windows.Forms.ColumnHeader chCity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bttnReload_PC;
        private System.Windows.Forms.Button bttnSearch_PC;
        private System.Windows.Forms.TextBox txtSearch_PC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnLast_PC;
        private System.Windows.Forms.Button bttnNext_PC;
        private System.Windows.Forms.Button bttnPrevious_PC;
        private System.Windows.Forms.Button bttnFirst_PC;
        private System.Windows.Forms.Label lblRecordCount_PC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bttnClose_PC;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.PictureBox picPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCellNumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStateProv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCityTown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttnBrowse;
        private System.Windows.Forms.Button bttnCamera;
        public System.Windows.Forms.PictureBox picCustomer;
    }
}