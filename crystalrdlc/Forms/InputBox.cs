using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace crystalrdlc
{
    public partial class InputBox : Form
    {
        public InputBox(){InitializeComponent();}

        //SQL COMMAND VARIABLES
        OleDbCommand sCommand = new OleDbCommand();

        //STRING VARIABLES
        public static string sSelect;
        public static string sEntryTable;

        private void InputBox_Load(object sender, EventArgs e)
        {
            if (sSelect == "frmCustomers") { if (sEntryTable == "tblCourtesyTitle") { setCourtesyTitle(); } }

            //Set Connection
            clsADONET.setConnection();
            clsADONET.sConnection.Open();

            picLOGO.Image = MainForm.publicCustomers.i32x32.Images[10];
        }

        private void bttnCancel_Click(object sender, EventArgs e) {Close(); }

        private void InputBox_FormClosing(object sender, FormClosingEventArgs e) { clsADONET.sConnection.Close(); }

        private void InputBox_Activated(object sender, EventArgs e) { txtEntry.Focus(); }

        protected void setUpdateRec(string sSQL, string sParameter, int iNum)
        {
            sCommand.Connection = clsADONET.sConnection;
            sCommand.CommandText = sSQL;
            sCommand.Parameters.Add(sParameter, OleDbType.VarChar, iNum);
            sCommand.Parameters[sParameter].Value = txtEntry.Text;
        }

        protected void setMessageBox(string sName)
        {
            MessageBox.Show(sName + " was already exist. Please check it and change it!", "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void setSuccessfull()
        {
            MessageBox.Show("Record has been successfully added.", "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        protected void setCourtesyTitle()
        {
            this.Text = "Enter new Courtesy Title";
            lblEntry.Text = "New Courtesy Title";
        }

        protected void setUpdateCourtesy()
        {
            clsADONET.setConnCommand_Open(sCommand);
            setUpdateRec("INSERT INTO tblCourtesyTitle(CourtesyTitle) VALUES (@CourtesyTitle)", "@CourtesyTitle", 50);
            sCommand.Parameters.Add("@CourtesyTitle", OleDbType.VarChar, 20);

            sCommand.Parameters["@CourtesyTitle"].Value = txtEntry.Text;

            clsADONET.setConnCommand_Close(sCommand);
            setSuccessfull();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text == "")
            {
                clsADONET.isStringEmpty("Data Entry Field");
                txtEntry.Focus();
            }
            else
            {
                if (sSelect == "frmCustomers")
                {
                    if (sEntryTable == "tblCourtesyTitle")
                    {
                        if (clsADONET.isRecordExist("SELECT CourtesyTitle FROM tblCourtesyTitle WHERE CourtesyTitle LIKE '" + txtEntry.Text + "' ", "tblCourtesyTitle") == true) { setMessageBox("Courtesy Title"); }
                        else
                        {
                            setUpdateCourtesy();
                            frmCustomers_Modify.publicCustModify.setDBComboBox();
                        }
                    }
                }
            }
        }

    }
}