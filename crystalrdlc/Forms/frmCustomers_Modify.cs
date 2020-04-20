using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace crystalrdlc
{
    public partial class frmCustomers_Modify : Form
    {
        public frmCustomers_Modify(){InitializeComponent();}

        //CLASS VARIABLES
        clsADONET sADONET = new clsADONET();

        //FORM VARIABLES
        public static frmCustomers_Modify publicCustModify;

        //DATASET VARIABLES
        DataSet dsPostalCode = new DataSet();
        DataSet dsSearchPostalCode = new DataSet();

        //SQL COMMAND VARIABLES
        OleDbCommand sCommand = new OleDbCommand();

        //BOOLEAN VARIABLES
        public static bool boolSTATUS;
        public static bool boolPicture;
        public static bool boolHavePics;
        bool boolType;
        bool boolCamera;
        bool boolBrowse;

        //STRING VARIABLES
        public static string sSearch;
        string imgPath;
        string sWHERE;
        string sSQL_POSTAL = "SELECT * FROM tblPostalCodes ORDER BY PostalCode ASC";

        //INTEGER VARIABLES
        public static int iGenerateID;

        private void frmCustomers_Modify_Load(object sender, EventArgs e)
        {
            setImages();

            cbGender.Items.Clear();
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");

            setDBComboBox();

            sADONET.setNavigation(1, sSQL_POSTAL, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 1, 2, "");
            clsADONET.setComlumnSorter(lvPostalCode);
            clsADONET.setPanelBound(panelPostalViewer, 229, 104, 480, 310);

            if (boolSTATUS == true)
            {
                setGenerate();
                this.Text = "New Customer Entry";
            }
            else
            {
                this.Text = "Update Existing Customer";
                FillFields("", "", "", true);
                bttnGenerate.Enabled = false;
                boolHavePics = true;
            }

            publicCustModify = this;
        }

        public void setDBComboBox() { clsADONET.setComboList(cbCourtesyTitle, "SELECT CourtesyTitle FROM tblCourtesyTitle ORDER BY CourtesyTitle ASC", "tblCourtesyTitle", "CourtesyTitle"); }

        public void FillFields(string sCityTown, string sStateProv, string sPostalCode, bool sState)
        {
            if (boolSTATUS == false)
            {
                if (sState == true)
                {
                    string sSQL = "SELECT tblCustomers.CustomerCode, tblCustomers.CourtesyTitle, tblCustomers.FirstName, tblCustomers.MiddleName, tblCustomers.LastName, tblCustomers.Gender, tblCustomers.StreetAddress, tblPostalCodes.CityTown, tblPostalCodes.StateProv, tblCustomers.PostalCode, tblCustomers.PhoneNumber, tblCustomers.CellPhone, tblCustomers.Comments, tblCustomers.Status, tblCustomers.CreditLimit FROM tblCustomers INNER JOIN tblPostalCodes ON  tblCustomers.PostalCode = tblPostalCodes.PostalCode WHERE tblCustomers.CustomerCode LIKE '" + sSearch + "' ";

                    clsADONET.setCommand(clsADONET.sDataSet, clsADONET.sAdapter, sSQL, "tblCustomers");
                    DataRow sDataRow = clsADONET.sDataSet.Tables["tblCustomers"].Rows[0];

                    txtCustomerCode.Text = sDataRow["CustomerCode"].ToString();
                    cbCourtesyTitle.Text = sDataRow["CourtesyTitle"].ToString();
                    txtFirstname.Text = sDataRow["FirstName"].ToString();
                    txtMiddlename.Text = sDataRow["MiddleName"].ToString();
                    txtLastname.Text = sDataRow["LastName"].ToString();
                    cbGender.Text = sDataRow["Gender"].ToString();
                    txtStreetAddress.Text = sDataRow["StreetAddress"].ToString();
                    txtCreditLimit.Text = Convert.ToDecimal(sDataRow["CreditLimit"].ToString()).ToString("0,0.00");
                    txtPhoneNumber.Text = sDataRow["PhoneNumber"].ToString();
                    txtPhoneNumber.Text = sDataRow["PhoneNumber"].ToString();
                    txtCellNumber.Text = sDataRow["CellPhone"].ToString();
                    txtComments.Text = sDataRow["Comments"].ToString();

                    string sStatus = sDataRow["Status"].ToString();

                    if (sStatus == "Active") { chActive.Checked = true; }
                    else { chActive.Checked = false; }

                    txtCityTown.Text = sDataRow["CityTown"].ToString();
                    txtStateProv.Text = sDataRow["StateProv"].ToString();
                    txtPostalCode.Text = sDataRow["PostalCode"].ToString();

                    clsADONET.getPicToDB(picCustomer, lblNoPic, "SELECT Picture FROM tblCustomers WHERE CustomerCode LIKE '" + sSearch + "' ");
                }
                else
                {
                    txtCityTown.Text = sCityTown;
                    txtStateProv.Text = sStateProv;
                    txtPostalCode.Text = sPostalCode;
                }
            }
        }

        protected void setImages()
        {
            //Buttons
            bttnCancel.Image = MainForm.publicCustomers.i32x32.Images[9];
            bttnReset.Image = MainForm.publicCustomers.i32x32.Images[8];
            bttnUpdate.Image = MainForm.publicCustomers.i32x32.Images[7];
            bttnGenerate.Image = MainForm.publicCustomers.i16x16.Images[4];
            bttnCT_New.Image = MainForm.publicCustomers.i16x16.Images[2];
            bttnCT_Remove.Image = MainForm.publicCustomers.i16x16.Images[3];
            bttnReload_PC.Image = MainForm.publicCustomers.i16x16.Images[0];
            bttnSearch_PC.Image = MainForm.publicCustomers.i16x16.Images[2];
            bttnClose_PC.Image = MainForm.publicCustomers.i16x16.Images[3];
            bttnFirst_PC.Image = MainForm.publicCustomers.i16x16.Images[13];
            bttnPrevious_PC.Image = MainForm.publicCustomers.i16x16.Images[14];
            bttnNext_PC.Image = MainForm.publicCustomers.i16x16.Images[15];
            bttnLast_PC.Image = MainForm.publicCustomers.i16x16.Images[16];

            //Listview
            lvPostalCode.SmallImageList = MainForm.publicCustomers.i16x16;
        }

        public void setPicture(string sLocation, bool boolGet)
        {
            try
            {
                if (boolGet == true) { boolCamera = true; }
                clsADONET.setPicture(picCustomer, sLocation);
                lblNoPic.Visible = false;
            }
            catch (Exception ex) { }
        }

        protected void setGenerate() { clsADONET.getIDGenerator(txtCustomerCode, "SELECT * FROM tblIDGenerator WHERE TableName LIKE 'tblCustomers' ", "tblIDGenerator", "CUST-", "frmCustomers_Modify"); }

        private void bttnCancel_Click(object sender, EventArgs e){Close();}

        private void cbCourtesyTitle_KeyPress(object sender, KeyPressEventArgs e){e.Handled = true;}

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void picPostalCode_Click(object sender, EventArgs e) { clsADONET.setPanelVisible(panelPostalViewer); }

        private void txtCreditLimit_KeyDown(object sender, KeyEventArgs e) { clsADONET.setKeyDown(sender, e); }

        private void txtCreditLimit_KeyPress(object sender, KeyPressEventArgs e) { if (clsADONET.nonNumberEntered == true) { e.Handled = true; } }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            if (boolSTATUS == true)
            {
                cbCourtesyTitle.Text = "";
                txtFirstname.Clear();
                txtMiddlename.Clear();
                txtLastname.Clear();
                cbGender.Text = "";

                txtStreetAddress.Clear();
                txtCityTown.Clear();
                txtStateProv.Clear();
                txtPostalCode.Clear();

                txtCreditLimit.Clear();
                txtPhoneNumber.Clear();
                txtCellNumber.Clear();
                txtComments.Clear();

                chActive.Checked = true;
                lblNoPic.Visible = true;
                clsADONET.setRemovePic(picCustomer, "CustPic.tmp", "\\Customers Pics\\");
            }
            else
            {
                if (boolBrowse == true) { clsADONET.setPicture(picCustomer, imgPath); boolBrowse = false; }

                boolCamera = false;
                if (boolCamera == false) { WebCamera.boolGets = false; WebCamera.boolFill = false; }
                if (boolSTATUS == true)
                {
                    clsADONET.setRemovePic(picCustomer);
                    WebCamera.boolFill = false;
                    boolHavePics = true;
                }
                else
                {
                    FillFields("", "", "", true);
                    boolPicture = true;
                }
            }
        }

        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            if (clsADONET.isRecordExist("SELECT TableName FROM tblIDGenerator WHERE TableName LIKE 'tblCustomers' ", "tblIDGenerator") == false) { clsADONET.setInsertID("tblCustomers", 2); }
            else { clsADONET.setIDGenerator("tblCustomers", iGenerateID); }
            setGenerate();
        }

        private void bttnCT_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCourtesyTitle.Items.Count > 0)
                {
                    clsADONET.setRemoveComboItem("DELETE FROM tblCourtesyTitle WHERE CourtesyTitle LIKE '" + cbCourtesyTitle.Text + "' ", "tblCourtesyTitle", "frmCustomers");
                }
                else { MessageBox.Show("No record to delete.", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex) { MessageBox.Show("Pls. select a record to be deleted.", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void bttnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (boolCamera == true)
                {
                    WebCamera.boolGets = true;
                    WebCamera.boolFill = false;
                    boolBrowse = true;
                }
                clsADONET.setBrowsePicture(picCustomer, lblNoPic, imgPath);
                if (boolSTATUS == false) { boolPicture = false; }
                boolType = true;
                if (imgPath == "") { boolHavePics = true; }
                else { boolHavePics = false; }
            }
            catch (Exception ex) { }
        }

        private void bttnCamera_Click(object sender, EventArgs e)
        {
            try
            {
                boolType = false;
                picCustomer.Image.Dispose();
            }
            catch (Exception ex) { }

            WebCamera.boolFill = false;
            boolHavePics = false;
            if (boolSTATUS == false) { if (boolCamera == true) { WebCamera.boolGets = true; } }
            else { if (boolCamera == true) { WebCamera.boolGets = false; WebCamera.boolFill = true; } }

            clsADONET.setWebCamera("Customer Picture");
        }

        private void lvPostalCode_ColumnClick(object sender, ColumnClickEventArgs e) { clsADONET.setColumnClick(sender, e); }

        private void lvPostalCode_DoubleClick(object sender, EventArgs e)
        {
            clsADONET.setListviewTextbox(lvPostalCode, 0, txtPostalCode);
            clsADONET.setListviewTextbox(lvPostalCode, 1, txtStateProv);
            clsADONET.setListviewTextbox(lvPostalCode, 2, txtCityTown);
            clsADONET.setPanelVisible(panelPostalViewer);
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "")
            {
                clsADONET.isStringEmpty("Firstname");
                txtFirstname.Focus();
            }
            else if (txtLastname.Text == "")
            {
                clsADONET.isStringEmpty("Lastname");
                txtLastname.Focus();
            }
            else if (txtStreetAddress.Text == "")
            {
                clsADONET.isStringEmpty("Street Address");
                txtStreetAddress.Focus();
            }
            else if (txtPostalCode.Text == "")
            {
                clsADONET.isStringEmpty("Postal Code");
                picPostalCode.Focus();
            }
            else if (txtCreditLimit.Text == "" || txtCreditLimit.Text == ".")
            {
                clsADONET.isStringEmpty("Credit Limit");
                txtCreditLimit.Focus();
            }
            else
            {
                try
                {
                    clsADONET.setConnCommand_Open(sCommand);

                    if (boolSTATUS == true)
                    {
                        if (boolHavePics == true)
                        {
                            sCommand.CommandText = "INSERT INTO tblCustomers(CustomerCode, CourtesyTitle, FirstName, MiddleName, LastName, Gender, StreetAddress, PostalCode, PhoneNumber, CellPhone, Comments, Status, CreditLimit) values (@CustomerCode, @CourtesyTitle,  @FirstName, @MiddleName, @LastName, @Gender, @StreetAddress, @PostalCode, @PhoneNumber, @CellPhone, @Comments, @Status, @CreditLimit)";
                        }
                        else
                        {
                            sCommand.CommandText = "INSERT INTO tblCustomers(CustomerCode, CourtesyTitle, FirstName, MiddleName, LastName, Gender, StreetAddress, PostalCode, PhoneNumber, CellPhone, Comments, Status, CreditLimit, Picture) values (@CustomerCode, @CourtesyTitle,  @FirstName, @MiddleName, @LastName, @Gender, @StreetAddress, @PostalCode, @PhoneNumber, @CellPhone, @Comments, @Status, @CreditLimit, @Picture)";
                            sCommand.Parameters.Add("@Picture", OleDbType.BigInt);
                            if (boolType == true) { sCommand.Parameters["@Picture"].Value = clsADONET.m_barrImg; }
                            else
                            {
                                clsADONET.setPicture(picCustomer, Path.GetTempPath().ToString() + "\\Customers Pics\\CustPic.tmp");
                                sCommand.Parameters["@Picture"].Value = clsADONET.m_barrImg;
                            }
                        }
                    }
                    else
                    {
                        if (boolHavePics == true)
                        {
                            sCommand.CommandText = "UPDATE tblCustomers SET CourtesyTitle = @CourtesyTitle, FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Gender = @Gender, StreetAddress = @StreetAddress, PostalCode =@PostalCode, PhoneNumber = @PhoneNumber, CellPhone = @CellPhone, Comments = @Comments, Status = @Status, CreditLimit = @CreditLimit, WHERE CustomerCode LIKE '" + sSearch + "' ";
                        }
                        else
                        {
                            sCommand.CommandText = "UPDATE tblCustomers SET CourtesyTitle = @CourtesyTitle, FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Gender = @Gender, StreetAddress = @StreetAddress, PostalCode =@PostalCode, PhoneNumber = @PhoneNumber, CellPhone = @CellPhone, Comments = @Comments, Status = @Status, CreditLimit = @CreditLimit, Picture = @Picture WHERE CustomerCode LIKE '" + sSearch + "' ";
                            sCommand.Parameters.Add("@Picture", OleDbType.Binary);
                            if (boolType == true) { sCommand.Parameters["@Picture"].Value = clsADONET.m_barrImg; }
                            else
                            {
                                clsADONET.setPicture(picCustomer, Path.GetTempPath().ToString() + "\\Customers Pics\\CustPic.tmp");
                                sCommand.Parameters["@Picture"].Value = clsADONET.m_barrImg;
                            }
                        }
                    }

                    string sStatus;
                    if (chActive.Checked == true) { sStatus = "Active"; }
                    else { sStatus = "In-Active"; }

                    sCommand.Parameters.Add("@CustomerCode", OleDbType.VarChar, 20);
                    sCommand.Parameters.Add("@CourtesyTitle", OleDbType.VarChar, 20);
                    sCommand.Parameters.Add("@FirstName", OleDbType.VarChar, 15);
                    sCommand.Parameters.Add("@MiddleName", OleDbType.VarChar, 15);
                    sCommand.Parameters.Add("@LastName", OleDbType.VarChar, 15);
                    sCommand.Parameters.Add("@Gender", OleDbType.VarChar, 10);
                    sCommand.Parameters.Add("@StreetAddress", OleDbType.VarChar, 40);
                    sCommand.Parameters.Add("@PostalCode", OleDbType.VarChar, 10);
                    sCommand.Parameters.Add("@PhoneNumber", OleDbType.VarChar, 20);
                    sCommand.Parameters.Add("@CellPhone", OleDbType.VarChar, 20);
                    sCommand.Parameters.Add("@Comments", OleDbType.VarChar, 100);
                    sCommand.Parameters.Add("@Status", OleDbType.VarChar, 10);
                    sCommand.Parameters.Add("@CreditLimit", OleDbType.Decimal);

                    sCommand.Parameters["@CustomerCode"].Value = txtCustomerCode.Text;
                    sCommand.Parameters["@CourtesyTitle"].Value = cbCourtesyTitle.Text;
                    sCommand.Parameters["@FirstName"].Value = txtFirstname.Text;
                    sCommand.Parameters["@MiddleName"].Value = txtMiddlename.Text;
                    sCommand.Parameters["@LastName"].Value = txtLastname.Text;
                    sCommand.Parameters["@Gender"].Value = cbGender.Text;
                    sCommand.Parameters["@StreetAddress"].Value = txtStreetAddress.Text;
                    sCommand.Parameters["@PostalCode"].Value = txtPostalCode.Text;
                    sCommand.Parameters["@PhoneNumber"].Value = txtPhoneNumber.Text;
                    sCommand.Parameters["@CellPhone"].Value = txtCellNumber.Text;
                    sCommand.Parameters["@Comments"].Value = txtComments.Text;
                    sCommand.Parameters["@Status"].Value = sStatus;
                    sCommand.Parameters["@CreditLimit"].Value = txtCreditLimit.Text;

                    clsADONET.setConnCommand_Close(sCommand);
                    clsADONET.setUpdateDelay();
                    MainForm.publicCustomers.setReload();

                    if (boolSTATUS == false)
                    {
                        MessageBox.Show("Changes in record has been successfully saved.", "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        clsADONET.setIDGenerator("tblCustomers", iGenerateID);
                        MessageBox.Show("Record has been successfully added.", "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Do you want to add another record?", "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) { this.Close(); }
                        else
                        {
                            setGenerate();
                            boolHavePics = true;
                            bttnReset_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void bttnCT_New_Click(object sender, EventArgs e) { clsADONET.setInputBox("frmCustomers", "tblCourtesyTitle"); }

        private void panelPostalViewer_Leave(object sender, EventArgs e) { panelPostalViewer.Visible = false; }

        private void bttnClose_PC_Click(object sender, EventArgs e) { clsADONET.setPanelVisible(panelPostalViewer); }

        private void bttnSearch_PC_Click(object sender, EventArgs e)
        {
            if (txtSearch_PC.Text != "")
            {
                sWHERE = "SELECT PostalCode, StateProv, CityTown FROM tblPostalCodes WHERE PostalCode LIKE '%" + txtSearch_PC.Text + "%' ORDER BY PostalCode ASC";
                sADONET.setFillRecord(lvPostalCode, lblRecordCount_PC, 1, sWHERE, "tblPostalCodes", 50, 17, bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsSearchPostalCode, 2, "MMMM dd, yyyy");
            }
        }

        private void bttnReload_PC_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvPostalCode);
            sADONET.setNavigation(5, sSQL_POSTAL, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy");
        }

        private void bttnFirst_PC_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvPostalCode);
            if (boolSTATUS == true) { sADONET.setNavigation(1, sSQL_POSTAL, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy"); }
            else { sADONET.setNavigation(1, sWHERE, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy"); }
        }

        private void bttnPrevious_PC_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvPostalCode);
            if (boolSTATUS == true) { sADONET.setNavigation(3, sSQL_POSTAL, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy"); }
            else { sADONET.setNavigation(3, sWHERE, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy"); }
        }

        private void bttnNext_PC_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvPostalCode);
            if (boolSTATUS == true) { sADONET.setNavigation(2, sSQL_POSTAL, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy"); }
            else { sADONET.setNavigation(2, sWHERE, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy"); }
        }

        private void bttnLast_PC_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvPostalCode);
            if (boolSTATUS == true) { sADONET.setNavigation(4, sSQL_POSTAL, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy"); }
            else { sADONET.setNavigation(4, sWHERE, lvPostalCode, lblRecordCount_PC, "tblPostalCodes", bttnFirst_PC, bttnPrevious_PC, bttnNext_PC, bttnLast_PC, dsPostalCode, 50, 17, 2, "MMMM dd, yyyy"); }
        }
    }
}