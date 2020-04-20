using System;
using System.Data;
using System.Windows.Forms;

namespace crystalrdlc
{
    public partial class MainForm : Form
    {
        public MainForm(){InitializeComponent();}

        //CLASS VARIABLES
        clsADONET sADONET = new clsADONET();

        //FORM VARIABLES
        public static MainForm publicCustomers;

        //DATASET VARIABLES
        DataSet dsCustomers = new DataSet();
        DataSet dsSearchCust = new DataSet();

        //BOOLEAN VARIABLES
        public static bool boolSTATUS;

        //STRING VARIABLES
        public static string sWHERE;
        string sSQL_FULL = "SELECT tblCustomers.CustomerCode, tblCustomers.CourtesyTitle, tblCustomers.LastName + ', ' + tblCustomers.FirstName + ' ' +  tblCustomers.MiddleName AS Fullname, tblCustomers.CreditLimit, tblCustomers.Gender, tblCustomers.StreetAddress + ', ' + tblPostalCodes.CityTown + ', ' +  tblPostalCodes.StateProv + ', ' + tblPostalCodes.PostalCode AS Address, tblCustomers.PhoneNumber, tblCustomers.CellPhone, tblCustomers.Status FROM tblCustomers INNER JOIN tblPostalCodes ON  tblCustomers.PostalCode = tblPostalCodes.PostalCode ORDER BY tblCustomers.CustomerCode ASC";

        private void MainForm_Load(object sender, EventArgs e)
        {
            setImages();
            clsADONET.setCompanyProfile();
            sADONET.setNavigation(1, sSQL_FULL, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy");
            clsListViewSorter.setComlumnSorter(lvCustomers);

            boolSTATUS = true;
            publicCustomers = this;
        }

        private void setImages()
        {
            tsbNew.Image = i32x32.Images[0];
            tsbModify.Image = i32x32.Images[1];
            tsbSearch.Image = i32x32.Images[2];
            tsbDelete.Image = i32x32.Images[3];
            tsbReload.Image = i32x32.Images[4];
            tsbPreview.Image = i32x32.Images[5];
            tsbClose.Image = i32x32.Images[6];

            bttnFirst.Image = i24x24.Images[0];
            bttnPrevious.Image = i24x24.Images[1];
            bttnNext.Image = i24x24.Images[2];
            bttnLast.Image = i24x24.Images[3];

            cmsItemNew.Image = i16x16.Images[5];
            cmsItemModify.Image = i16x16.Images[6];
            cmsItemDelete.Image = i16x16.Images[7];
            cmsItemSearch.Image = i16x16.Images[8];
            cmsItemReload.Image = i16x16.Images[9];
            cmsItemPreview.Image = i16x16.Images[10];
            cmsItemClose.Image = i16x16.Images[11];

            lvCustomers.SmallImageList = i24x24;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will close the application. Do you want to continue?", "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) { e.Cancel = true; }
        }

        private void tsbClose_Click(object sender, EventArgs e){Close();}

        private void lvCustomers_Click(object sender, EventArgs e) { clsADONET.setSelectedItem(lblSelected, lvCustomers); }

        private void lvCustomers_ColumnClick(object sender, ColumnClickEventArgs e) { clsADONET.setColumnClick(sender, e); }

        private void lvCustomers_Leave(object sender, EventArgs e) { lblSelected.Text = "Selected Record: NONE"; }

        private void bttnLast_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvCustomers);
            if (boolSTATUS == true) { sADONET.setNavigation(4, sSQL_FULL, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy"); }
            else { sADONET.setNavigation(4, sWHERE, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy"); }
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvCustomers);
            if (boolSTATUS == true) { sADONET.setNavigation(2, sSQL_FULL, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy"); }
            else { sADONET.setNavigation(2, sWHERE, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy"); }
        }

        private void bttnPrevious_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvCustomers);
            if (boolSTATUS == true) { sADONET.setNavigation(3, sSQL_FULL, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy"); }
            else { sADONET.setNavigation(3, sWHERE, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy"); }
        }

        private void bttnFirst_Click(object sender, EventArgs e)
        {
            clsADONET.setComlumnSorter(lvCustomers);
            if (boolSTATUS == true) { sADONET.setNavigation(1, sSQL_FULL, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy"); }
            else { sADONET.setNavigation(1, sWHERE, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy"); }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Selected Record: NONE";
            setLoadModify("", true, true);
        }

        private void tsbRDLC_All_Click(object sender, EventArgs e)
        {
            ReportViewer.sSQL = "SELECT tblCustomers.CustomerCode, tblCustomers.CourtesyTitle, tblCustomers.LastName + ', ' + tblCustomers.FirstName + ' ' +  tblCustomers.MiddleName AS Fullname, tblCustomers.Gender, tblCustomers.StreetAddress + ', ' + tblPostalCodes.CityTown + ', ' +  tblPostalCodes.StateProv + ', ' + tblPostalCodes.PostalCode AS Address, tblCustomers.PhoneNumber, tblCustomers.CellPhone, tblCustomers.Comments, tblCustomers.Status, tblCustomers.CreditLimit, tblCustomers.InsertedBy, tblCustomers.DateInserted, tblCustomers.UpdatedBy, tblCustomers.DateUpdated FROM tblCustomers INNER JOIN tblPostalCodes ON  tblCustomers.PostalCode = tblPostalCodes.PostalCode ORDER BY tblCustomers.CustomerCode ASC";
            setPreview(true);
        }


        private void tsbRDLC_Selected_Click(object sender, EventArgs e)
        {
            ReportViewer.sSQL = "SELECT tblCustomers.CustomerCode, tblCustomers.CourtesyTitle, tblCustomers.LastName + ', ' + tblCustomers.FirstName + ' ' +  tblCustomers.MiddleName AS Fullname, tblCustomers.Gender, tblCustomers.StreetAddress + ', ' + tblPostalCodes.CityTown + ', ' +  tblPostalCodes.StateProv + ', ' + tblPostalCodes.PostalCode AS Address, tblCustomers.PhoneNumber, tblCustomers.CellPhone, tblCustomers.Comments, tblCustomers.Status, tblCustomers.CreditLimit, tblCustomers.InsertedBy, tblCustomers.DateInserted, tblCustomers.UpdatedBy, tblCustomers.DateUpdated FROM tblCustomers INNER JOIN tblPostalCodes ON  tblCustomers.PostalCode = tblPostalCodes.PostalCode WHERE tblCustomers.CustomerCode LIKE '" + lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[0].Text + "' ORDER BY tblCustomers.CustomerCode ASC";
            setPreview(true);
        }

        private void RDLC_Selected_Click(object sender, EventArgs e){tsbRDLC_Selected_Click(sender, e);}

        private void RDLC_All_Click(object sender, EventArgs e){tsbRDLC_All_Click(sender, e);}

        private void tsbCrystal_All_Click(object sender, EventArgs e)
        {
            ReportViewer.sSQL = "SELECT tblCustomers.CustomerCode, tblCustomers.CourtesyTitle, tblCustomers.LastName + ', ' + tblCustomers.FirstName + ' ' +  tblCustomers.MiddleName AS Fullname, tblCustomers.Gender, tblCustomers.StreetAddress + ', ' + tblPostalCodes.CityTown + ', ' +  tblPostalCodes.StateProv + ', ' + tblPostalCodes.PostalCode AS Address, tblCustomers.PhoneNumber, tblCustomers.CellPhone, tblCustomers.Comments, tblCustomers.Status, tblCustomers.CreditLimit, tblCustomers.InsertedBy, tblCustomers.DateInserted, tblCustomers.UpdatedBy, tblCustomers.DateUpdated FROM tblCustomers INNER JOIN tblPostalCodes ON  tblCustomers.PostalCode = tblPostalCodes.PostalCode ORDER BY tblCustomers.CustomerCode ASC";
            setPreview(false);
        }

        private void tsbCrystal_Selected_Click(object sender, EventArgs e)
        {
            ReportViewer.sSQL = "SELECT tblCustomers.CustomerCode, tblCustomers.CourtesyTitle, tblCustomers.LastName + ', ' + tblCustomers.FirstName + ' ' +  tblCustomers.MiddleName AS Fullname, tblCustomers.Gender, tblCustomers.StreetAddress + ', ' + tblPostalCodes.CityTown + ', ' +  tblPostalCodes.StateProv + ', ' + tblPostalCodes.PostalCode AS Address, tblCustomers.PhoneNumber, tblCustomers.CellPhone, tblCustomers.Comments, tblCustomers.Status, tblCustomers.CreditLimit, tblCustomers.InsertedBy, tblCustomers.DateInserted, tblCustomers.UpdatedBy, tblCustomers.DateUpdated FROM tblCustomers INNER JOIN tblPostalCodes ON  tblCustomers.PostalCode = tblPostalCodes.PostalCode WHERE tblCustomers.CustomerCode LIKE '" + lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[0].Text + "' ORDER BY tblCustomers.CustomerCode ASC";
            setPreview(false);
        }

        private void cmsCrystal_Selected_Click(object sender, EventArgs e){tsbCrystal_Selected_Click(sender, e);}

        private void cmsCrystal_All_Click(object sender, EventArgs e){tsbCrystal_All_Click(sender, e);}

        protected void setPreview(bool loadSTATUS)
        {
            ReportViewer.boolSTATUS = loadSTATUS;
            ReportViewer.sSelect = "Customers Records";
            ReportViewer.sTable = "tblCustomers";
            ReportViewer sForm = new ReportViewer();
            sForm.ShowDialog();
        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvCustomers.Items.Count > 0 || lvCustomers.FocusedItem.Index < 1) { setLoadModify(lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[0].Text, false, false); }
                else { MessageBox.Show("No record to modify.", "Unable to Modify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvCustomers.Items.Count > 0 || lvCustomers.FocusedItem.Index < 1)
                {
                    clsADONET.setRemoveListviewItem(lvCustomers, "DELETE FROM tblCustomers WHERE CustomerCode LIKE '" + lvCustomers.Items[lvCustomers.FocusedItem.Index].SubItems[0].Text + "' ", "tblCustomers", "frmCustomers");
                }
                else { MessageBox.Show("No record to delete.", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex) { MessageBox.Show("Select a record to delete. Pls. try again.", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbSearch_Click(object sender, EventArgs e) 
        { 
            lblSelected.Text = "Selected Record: NONE";
            SearchFilter.sSelect = "Customer Records";
            SearchFilter sForm = new SearchFilter();
            sForm.ShowDialog();
        }

        public void LoadSearch()
        {
            sADONET.setFillRecord(lvCustomers, lblRecordCount, 1, sWHERE, "tblCustomers", 100, 4, bttnFirst, bttnPrevious, bttnNext, bttnLast, dsSearchCust, 8, "MMMM dd, yyyy");
        }

        private void tsbReload_Click(object sender, EventArgs e) { setReload(); }

        public void setReload()
        {
            clsADONET.setComlumnSorter(lvCustomers);
            sADONET.setNavigation(5, sSQL_FULL, lvCustomers, lblRecordCount, "tblCustomers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsCustomers, 100, 4, 8, "MMMM dd, yyyy");
            lblSelected.Text = "Selected Record: NONE";
            boolSTATUS = true;
        }

        protected void setLoadModify(string sSearch, bool boolSTATUS, bool boolHavePics)
        {
            frmCustomers_Modify.sSearch = sSearch;
            frmCustomers_Modify.boolSTATUS = boolSTATUS;
            frmCustomers_Modify.boolHavePics = boolHavePics;
            frmCustomers_Modify sForm = new frmCustomers_Modify();
            sForm.ShowDialog();
        }

        private void cmsItemNew_Click(object sender, EventArgs e){tsbNew_Click(sender, e);}

        private void cmsItemModify_Click(object sender, EventArgs e){tsbModify_Click(sender, e);}

        private void cmsItemDelete_Click(object sender, EventArgs e) { tsbDelete_Click(sender, e); }

        private void cmsItemSearch_Click(object sender, EventArgs e) { tsbSearch_Click(sender, e); }

        private void cmsItemReload_Click(object sender, EventArgs e) { tsbReload_Click(sender, e); }

        private void cmsItemClose_Click(object sender, EventArgs e){Close();}

        private void lvCustomers_DoubleClick(object sender, EventArgs e) { tsbModify_Click(sender, e); }
    }
}