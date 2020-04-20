using System;
using System.Windows.Forms;

namespace crystalrdlc
{
    public partial class SearchFilter : Form
    {
        public SearchFilter(){InitializeComponent();}

        //STRING VARIABLES
        public static string sSelect;
        public static string sEmpCode;
        public static string sMonthYear;

        //OBJECT VARIABLES
        Object[] objCustomers = new Object[13] { "CustomerCode", "CourtesyTitle", "FirstName", "MiddleName", "LastName", "Gender", "StreetAddress", "CityTown", "StateProv", "PostalCode", "PhoneNumber", "CellPhone", "Status" };

        private void SearchFilter_Load(object sender, EventArgs e)
        {
            setComboBox(cbCondition1);
            setComboBox(cbCondition2);
            setImages();

            if (sSelect == "Customer Records") { cbFields.Items.AddRange(objCustomers); }
        }

        private void setImages()
        {
            picArrow1.Image = MainForm.publicCustomers.i24x24.Images[5];
            picArrow2.Image = MainForm.publicCustomers.i24x24.Images[5];
        }

        private void setComboBox(ComboBox sComboBox)
        {
            sComboBox.Items.Add("contains");
            sComboBox.Items.Add("is equal to");
            sComboBox.Items.Add("not euqal to");
            sComboBox.Items.Add("is greater than");
            sComboBox.Items.Add("is greater than or equal to");
            sComboBox.Items.Add("is less than");
            sComboBox.Items.Add("is less than or equal");
            sComboBox.Items.Add("between");
        }

        private void bttnCancel_Click(object sender, EventArgs e){Close();}

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strFilter = cbFields.Text;

                switch (cbCondition1.Text)
                {
                    case "contains":
                        strFilter = strFilter + " LIKE '%" + txtFilter1.Text + "%'"; break;
                    case "is equal to":
                        strFilter = strFilter + " = '" + txtFilter1.Text + "'"; break;
                    case "not euqal to":
                        strFilter = strFilter + " <> '" + txtFilter1.Text + "'"; break;
                    case "is greater than":
                        strFilter = strFilter + " > '" + txtFilter1.Text + "'"; break;
                    case "is greater than or equal to":
                        strFilter = strFilter + " >= '" + txtFilter1.Text + "'"; break;
                    case "is less than":
                        strFilter = strFilter + " < '" + txtFilter1.Text + "'"; break;
                    case "is less than or equal":
                        strFilter = strFilter + " <= '" + txtFilter1.Text + "'"; break;
                    case "between":
                        strFilter = strFilter + " BETWEEN #" + dtNow1.Value + "# AND #" + dtNow2.Value + "#"; break;
                }

                if (cbCondition2.Text != "")
                {
                    if (optionAND.Checked == true) { strFilter = strFilter + " AND "; }
                    else { strFilter = strFilter + " OR "; }

                    switch (cbCondition2.Text)
                    {
                        case "contains":
                            strFilter = strFilter + " LIKE '%" + txtFilter2.Text + "%'"; break;
                        case "is equal to":
                            strFilter = strFilter + " = '" + txtFilter2.Text + "'"; break;
                        case "not euqal to":
                            strFilter = strFilter + " <> '" + txtFilter2.Text + "'"; break;
                        case "is greater than":
                            strFilter = strFilter + " > '" + txtFilter2.Text + "'"; break;
                        case "is greater than or equal to":
                            strFilter = strFilter + " >= '" + txtFilter2.Text + "'"; break;
                        case "is less than":
                            strFilter = strFilter + " < '" + txtFilter2.Text + "'"; break;
                        case "is less than or equal":
                            strFilter = strFilter + " <= '" + txtFilter2.Text + "'"; break;
                        case "between":
                            strFilter = strFilter + " BETWEEN #" + dtNow3.Value + "# AND #" + dtNow4.Value + "#"; break;
                    }
                }

                if (cbFields.Text == "") { }
                else if (cbCondition1.Text == "") { if (txtFilter1.Text == "") { txtFilter1.Focus(); } }
                else if (txtFilter1.Text == "") { txtFilter1.Focus(); }
                else
                {
                    if (sSelect == "Customer Records")
                    {
                        MainForm.boolSTATUS = false;
                        MainForm.sWHERE = "SELECT tblCustomers.CustomerCode, tblCustomers.CourtesyTitle, tblCustomers.LastName + ', ' + tblCustomers.FirstName + ' ' +  tblCustomers.MiddleName AS Fullname, tblCustomers.CreditLimit, tblCustomers.Gender, tblCustomers.StreetAddress + ', ' + tblPostalCodes.CityTown + ', ' +  tblPostalCodes.StateProv + ', ' + tblPostalCodes.PostalCode AS Address, tblCustomers.PhoneNumber, tblCustomers.CellPhone, tblCustomers.Status FROM tblCustomers INNER JOIN tblPostalCodes ON  tblCustomers.PostalCode = tblPostalCodes.PostalCode WHERE " + strFilter + " ORDER BY tblCustomers.CustomerCode ASC";
                        MainForm.publicCustomers.LoadSearch();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid search operation.", "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCondition1_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void cbCondition2_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void cbFields_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void cbCondition1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCondition1.Text == "between") { txtFilter1.Visible = false; }
            else { txtFilter1.Visible = true; }
        }

        private void cbCondition2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCondition2.Text == "between") { txtFilter2.Visible = false; }
            else { txtFilter2.Visible = true; }
        }
    }
}