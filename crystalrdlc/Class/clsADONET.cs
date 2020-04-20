using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace crystalrdlc
{
    class clsADONET: clsListViewSorter
    {
        //OLEDB VARIABLES
        public static OleDbConnection sConnection = new OleDbConnection();
        public static OleDbCommand sCommand = new OleDbCommand();
        public static OleDbDataAdapter sAdapter = new OleDbDataAdapter();
        public static OleDbDataReader sDataReader;

        //DATASET VARIABLES
        public static DataSet sDataSet = new DataSet();
        public static DataSet dsCustrs = new dsCustomers();

        //LONG VARIABLES
        public static long m_lImageFileLength = 0;
        public long PAGE_CURRENT;
        public long PAGE_NEXT;
        public long PAGE_PREVIOUS;
        public long PAGE_TOTAL;

        //BYTE VARIABLES
        public static byte[] m_barrImg;

        //BOOLEAN VARIABLES
        public static bool nonNumberEntered = false;

        //FILE DIALOG VARIABLES
        public static OpenFileDialog openIMG = new OpenFileDialog();

        //STRING VARIABLES
        public static string sCompanyName;
        public static string sContactName;
        public static string sCompanyAddress;
        public static string sPhoneNumber;
        public static string sFaxNumber;
        public static string sEmailAddress;
        public static string sWebAddress;
        public static string sUserFullname = "Mr. Lagod, Junald Astronomo";

        public static string setConnectionString(string sLocation, string sPassword)
        {
            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sLocation + ";Persist Security Info=False;Jet OLEDB:Database Password=" + sPassword;
        }

        public static string setLeftStr(string source, int pos)
        {
            int i;
            string temp = "";
            for (i = 0; i < pos; i++) { temp += source[i]; }
            return temp;
        }

        public static string setMiddleStr(string source, int start, int stop)
        {
            int i;
            string temp = "";
            for (i = start; i < stop; i++) { temp += source[i]; }
            return temp;
        }

        public static void setConnection()
        {
            if (sConnection.State == ConnectionState.Open) sConnection.Close();
            sConnection.ConnectionString = setConnectionString(AppDomain.CurrentDomain.BaseDirectory + "\\@Database\\MasterFile.mdb", "jaslad");
        }

        public static void setConnCommand_Open(OleDbCommand sCommand)
        {
            setConnection();
            sConnection.Open();
            sCommand.Connection = sConnection;
        }

        public static void setConnCommand_Close(OleDbCommand sCommand)
        {
            sCommand.ExecuteNonQuery();
            sCommand.Parameters.Clear();
            sCommand.Connection.Close();
            sConnection.Close();
        }

        public static void setCommand(DataSet dsFill, OleDbDataAdapter daFill, string sSQL, string sTable)
        {
            setConnection();
            daFill.SelectCommand = new OleDbCommand(sSQL, sConnection);
            dsFill.Clear();
            daFill.Fill(dsFill, sTable);
        }

        public static void setOleDbCommand(string sSQL)
        {
            //Set Connection
            setConnection();
            sConnection.Open();
            OleDbCommand sCommand = new OleDbCommand();
            sCommand.Connection = sConnection;
            sCommand.CommandText = sSQL;
            sCommand.ExecuteNonQuery();
            sConnection.Close();
        }

        public void setNavigation(int iWhich, string sSQL, ListView sListView, Label sLabel, string sTable, Button bttnFirst, Button bttnPrevious, Button bttnNext, Button bttnLast, DataSet sDataSet, long SubRecord, int iConNum, int iNumField, string sDateFormat)
        {
            switch (iWhich)
            {
                case 1:
                    if (PAGE_CURRENT != 1) { setFillRecord(sListView, sLabel, 1, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat); }
                    break;
                case 2:
                    if (PAGE_CURRENT != PAGE_TOTAL) { setFillRecord(sListView, sLabel, PAGE_NEXT, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat); }
                    break;
                case 3:
                    if (PAGE_CURRENT != 1) { setFillRecord(sListView, sLabel, PAGE_PREVIOUS, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat); }
                    break;
                case 4:
                    if (PAGE_CURRENT != PAGE_TOTAL) { setFillRecord(sListView, sLabel, PAGE_TOTAL, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat); }
                    break;
                case 5:
                    setFillRecord(sListView, sLabel, 1, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat);
                    break;
            }
        }

        public void setFillRecord(ListView sListView, Label sLabel, long sPage, string sSQL, string sTable, long sSubRecord, int iIcon, Button sButton1, Button sButton2, Button sButton3, Button sButton4, DataSet dsSource, int iNumField, string sDateFormat)
        {
            setCommand(sDataSet, sAdapter, sSQL, sTable);

            long pos_start;
            long pos_end;
            PAGE_CURRENT = 1;
            PAGE_NEXT = 1;
            PAGE_PREVIOUS = 1;
            PAGE_TOTAL = 1;
            PAGE_CURRENT = sPage;

            try
            {
                long sTotal;
                decimal sDecimal = decimal.Divide(sDataSet.Tables[sTable].Rows.Count, sSubRecord);
                string sString = sDecimal.ToString();
                string sSubTotal;

                for (int i = 1; i <= sString.Length; i++)
                {
                    try
                    {
                        if (setMiddleStr(sString, i, sString.Length - 1).Equals("."))
                        {
                            sSubTotal = (setLeftStr(sString, i));
                            sTotal = (long.Parse(sSubTotal) + 1);
                            PAGE_TOTAL = sTotal;
                        }
                        else
                        {
                            sTotal = long.Parse(sDecimal.ToString());
                            PAGE_TOTAL = sTotal;
                        }
                    }
                    catch (Exception ex)
                    {
                        sSubTotal = (setLeftStr(sString, i));
                        sTotal = (long.Parse(sSubTotal) + 1);
                        PAGE_TOTAL = sTotal;
                    }

                }
            }
            catch (Exception ex) { }

            if (PAGE_TOTAL > PAGE_CURRENT) { PAGE_NEXT = PAGE_CURRENT + 1; }
            else if (PAGE_CURRENT > 1) { PAGE_PREVIOUS = PAGE_CURRENT - 1; }

            if (PAGE_TOTAL == 1)
            {
                pos_start = 1;
                pos_end = sDataSet.Tables[sTable].Rows.Count;
                sButton1.Enabled = false;
                sButton2.Enabled = false;
                sButton3.Enabled = false;
                sButton4.Enabled = false;
            }
            else if (PAGE_CURRENT == 1)
            {
                pos_start = 1;
                pos_end = sSubRecord;
                sButton1.Enabled = false;
                sButton2.Enabled = false;
                sButton3.Enabled = true;
                sButton4.Enabled = true;
            }
            else if (PAGE_CURRENT == PAGE_TOTAL && PAGE_CURRENT > 1)
            {
                pos_start = ((PAGE_CURRENT - 1) * sSubRecord) + 1;
                pos_end = sDataSet.Tables[sTable].Rows.Count;
                sButton1.Enabled = true;
                sButton2.Enabled = true;
                sButton3.Enabled = false;
                sButton4.Enabled = false;
            }
            else
            {
                pos_start = ((PAGE_CURRENT - 1) * sSubRecord) + 1;
                pos_end = (PAGE_NEXT - 1) * sSubRecord;
                sButton1.Enabled = true;
                sButton2.Enabled = true;
                sButton3.Enabled = true;
                sButton4.Enabled = true;
            }

            setListview(sListView, sSQL, sTable, pos_start, pos_end, iIcon, dsSource, iNumField, sDateFormat);
            setTrackList(sListView, sLabel, sSubRecord, sDataSet.Tables[sTable].Rows.Count);
            pos_start = 0;
            pos_end = 0;
        }

        private void setTrackList(ListView sListView, Label sLabel, long iEnd, long TotalRecords)
        {
            if (PAGE_TOTAL == 1) { sLabel.Text = "Results: " + (sListView.SelectedItems.Count + 1) + " - " + sListView.Items.Count.ToString() + " of about " + TotalRecords; }
            else if (PAGE_CURRENT == 1) { sLabel.Text = "Results: " + (sListView.SelectedItems.Count + 1) + " - " + sListView.Items.Count.ToString() + " of about " + TotalRecords; }
            else if (PAGE_CURRENT == PAGE_TOTAL && PAGE_CURRENT > 1) { sLabel.Text = "Results: " + (((PAGE_CURRENT - 1) * iEnd) + (sListView.SelectedItems.Count + 1)) + " - " + TotalRecords + " of about " + TotalRecords; }
            else { sLabel.Text = "Results: " + (((PAGE_CURRENT - 1) * iEnd) + (sListView.SelectedItems.Count + 1)) + " - " + (((PAGE_CURRENT - 1) * iEnd) + iEnd) + " of about " + TotalRecords; }
        }

        public void setListview(ListView sListView, string sSQL, string sTable, long iStart, long iEnd, int iIcon, DataSet dsSource, int iNumField, string sDateFormat)
        {
            try
            {
                long totalRow = 1;

                dsSource.Clear();
                sAdapter.Dispose();
                setCommand(dsSource, sAdapter, sSQL, sTable);

                totalRow = dsSource.Tables[sTable].Rows.Count;
                sListView.Items.Clear();

                iStart = iStart - 1;
                for (int x = int.Parse(iStart.ToString()); x <= iEnd - 1; x++)
                {
                    sListView.Items.Add(new ListViewItem("" + dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(0).ToString(), iIcon));
                    if (iNumField != 0)
                    {
                        for (int a = 1; a <= iNumField; a++)
                        {
                            int n = int.Parse(iStart.ToString());

                            if (dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(a).GetType().Equals(Type.GetType("System.String")))
                            {
                                sListView.Items[x - n].SubItems.Add("" + dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(a).ToString());
                            }
                            else if (dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(a).GetType().Equals(Type.GetType("System.DateTime")))
                            {
                                string sDate = dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(a).ToString();
                                sListView.Items[x - n].SubItems.Add("" + Convert.ToDateTime(sDate).ToString(sDateFormat));
                            }
                            else if (dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(a).GetType().Equals(Type.GetType("System.Decimal")))
                            {
                                string sDecimal = dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(a).ToString();
                                sListView.Items[x - n].SubItems.Add("" + Convert.ToDecimal(sDecimal).ToString("0,0.00"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void setSelectedItem(Label sLabel, ListView sListView)
        {
            try { sLabel.Text = "Selected Record: " + (sListView.FocusedItem.Index + 1); }
            catch (Exception ex) { }
        }

        public static void setColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView myListView = (ListView)sender;

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvColumnSorter.Order == SortOrder.Ascending) { lvColumnSorter.Order = SortOrder.Descending; }
                else { lvColumnSorter.Order = SortOrder.Ascending; }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvColumnSorter.SortColumn = e.Column;
                lvColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            myListView.Sort();
        }

        public static void setRemoveComboItem(string sSQL, string sTable, string sSelectedForm)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try { setCommand(sDataSet, sAdapter, sSQL, sTable); }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (sSelectedForm == "frmCustomers") { frmCustomers_Modify.publicCustModify.setDBComboBox(); }
                }
            }
            catch (Exception ex) { }
        }

        public static void setRemoveListviewItem(ListView sListView, string sSQL, string sTable, string sSelectedForm)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected record?\n\n" + "WARNING: You cannot undo this operation.", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    setCommand(sDataSet, sAdapter, sSQL, sTable);
                    setFocusListviewItems(sListView);
                    UpdateDelay sForm = new UpdateDelay();
                    sForm.ShowDialog();
                    if (sSelectedForm == "frmCustomers") { MainForm.publicCustomers.setReload(); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static void setFocusListviewItems(ListView sListView)
        {
            int lvw_pos;
            lvw_pos = sListView.FocusedItem.Index;

            if (sListView.Items.Count != 0 && sListView.Items.Count - 1 >= lvw_pos)
            {
                sListView.Items[sListView.FocusedItem.Index].Selected = false;
                sListView.Items[sListView.FocusedItem.Index].Focused = false;

                sListView.Items[lvw_pos].Focused = true;
                sListView.Items[lvw_pos].Selected = true;
                sListView.Items[lvw_pos].EnsureVisible();
            }
            lvw_pos = 0;
        }

        public static void setListviewTextbox(ListView sListView, int iSelect, TextBox sTextBox)
        {
            sTextBox.Text = sListView.Items[sListView.FocusedItem.Index].SubItems[iSelect].Text;
        }

        public static void setPanelBound(Panel sPanel, int iTop, int iLeft, int iWidth, int iHeight)
        {
            sPanel.Top = iTop;
            sPanel.Left = iLeft;
            sPanel.Width = iWidth;
            sPanel.Height = iHeight;
        }

        public static void setComboList(ComboBox sComboBox, string sSQL, string sTable, string sFieldName)
        {
            DataSet dsCourtesy = new DataSet();
            OleDbDataAdapter daCourtesy = new OleDbDataAdapter();
            setCommand(dsCourtesy, daCourtesy, sSQL, sTable);

            sComboBox.DataSource = dsCourtesy.Tables[0].DefaultView;
            sComboBox.DisplayMember = sFieldName;
            sComboBox.ValueMember = sFieldName;
        }

        public static void getPicToDB(PictureBox sPictureBox, Label sLabel, string sSQL)
        {
            try
            {
                setConnection();
                OleDbCommand cmdSelect = new OleDbCommand(sSQL, sConnection);
                sConnection.Open();

                byte[] barrImg = (byte[])cmdSelect.ExecuteScalar();
                string imgPath = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(imgPath, FileMode.CreateNew, FileAccess.Write);
                fs.Write(barrImg, 0, barrImg.Length);
                fs.Flush();
                fs.Close();

                sPictureBox.Image = Image.FromFile(imgPath);
                sLabel.Visible = false;
            }
            catch (Exception ex)
            {
                setRemovePic(sPictureBox);
                sLabel.Visible = true;
            }
        }

        public static void setRemovePic(PictureBox sPictureBox)
        {
            try
            {
                sPictureBox.Image.Dispose();
                sPictureBox.Image = null;
            }
            catch (Exception ex) { }
        }

        public static void setRemovePic(PictureBox sPictureBox, string sFile, string sFolder)
        {
            try
            {
                setRemovePic(sPictureBox);
                setRemoveFile(sFile, Path.GetTempPath().ToString() + sFolder);
            }
            catch (Exception ex) { }
        }

        public static void setBrowsePicture(PictureBox sPictureBox, Label sLabel, string imgPath)
        {
            try
            {
                openIMG.Filter = "Known graphics format (*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.jpeg;*.png";
                openIMG.ShowDialog();
                imgPath = openIMG.FileName;
                setPicture(sPictureBox, imgPath);
                sLabel.Visible = false;
            }
            catch (Exception ex) { }
        }

        public static void getIDGenerator(TextBox sTextBox, string sSQL, string sTable, string sInitial, string sSelect)
        {
            try
            {
                int iGenerateID;
                setCommand(sDataSet, sAdapter, sSQL, sTable);
                DataRow dtrGenerator = sDataSet.Tables[sTable].Rows[0];

                if (sDataSet.Tables[sTable].Rows.Count <= 1)
                {
                    sTextBox.Text = sInitial + setLeftStr("00000", ("00000".Length - dtrGenerator["NextNo"].ToString().Length)) + int.Parse(dtrGenerator["NextNo"].ToString());
                    iGenerateID = int.Parse(dtrGenerator["NextNo"].ToString()) + 1;
                    if (sSelect == "frmCustomers_Modify") { frmCustomers_Modify.iGenerateID = iGenerateID; }
                }
            }
            catch (Exception ex) { sTextBox.Text = sInitial + "00001"; }
        }

        public static DataSet setReport(DataSet ds, string sSQL, string sTable)
        {
            setCommand(ds, sAdapter, sSQL, sTable);
            return ds;
        }

        public static bool isRecordExist(string sSQL, string sTable)
        {
            long totalRow = 0;
            DataSet dsExist = new DataSet();
            OleDbDataAdapter daExist = new OleDbDataAdapter();
            setCommand(dsExist, daExist, sSQL, sTable);

            totalRow = Convert.ToInt32(dsExist.Tables[sTable].Rows.Count);
            if (totalRow > 0) { return true; }
            else { return false; }
        }

        public static void setCreateFile(PictureBox sPictureBox, string sFile, string sLocation)
        {
            try { if (File.Exists(sLocation + sFile) == false) { sPictureBox.Image.Save(sLocation + "\\" + sFile); } }
            catch (Exception ex) { }
        }

        public static void setRemoveFile(string sFile, string sLocation)
        {
            try { if (File.Exists(sLocation + sFile) == true) { File.Delete(sLocation + sFile); } }
            catch (Exception ex) { }
        }

        public static void setPicture(PictureBox sPictureBox, string sLocation)
        {
            try
            {
                sPictureBox.Image = Image.FromFile(sLocation);
                FileInfo fiImage = new FileInfo(sLocation);
                m_lImageFileLength = fiImage.Length;
                FileStream fs = new FileStream(sLocation, FileMode.Open, FileAccess.Read, FileShare.Read);
                m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
                int iBytesRead = fs.Read(m_barrImg, 0, Convert.ToInt32(m_lImageFileLength));
                fs.Close();
            }
            catch (Exception ex) { }
        }

        public static void setPanelVisible(Panel sPanel)
        {
            if (sPanel.Visible == true) { sPanel.Visible = false; }
            else { sPanel.Visible = true; }

            sPanel.Location.X.Equals(104);
            sPanel.Location.Y.Equals(322);
            sPanel.Focus();
        }

        public static void setKeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back) { nonNumberEntered = true; }
                    if (e.KeyCode == Keys.OemPeriod) { nonNumberEntered = false; }
                    if (e.KeyCode == Keys.Decimal) { nonNumberEntered = false; }
                }
            }
        }

        public static void setCompanyProfile()
        {
            try
            {
                string sSQL = "SELECT tblBusinessProfile.CompanyName, tblBusinessProfile.ContactName, tblBusinessProfile.StreetAddress + ', ' +  tblPostalCodes.CityTown  + ', ' +  tblPostalCodes.StateProv  + ', ' +  tblPostalCodes.PostalCode AS Address, tblBusinessProfile.PhoneNumber,  tblBusinessProfile.FaxNumber, tblBusinessProfile.EmailAddress,  tblBusinessProfile.Website FROM tblBusinessProfile INNER JOIN tblPostalCodes ON tblBusinessProfile.PostalCode = tblPostalCodes.PostalCode";

                setCommand(sDataSet, sAdapter, sSQL, "tblCustomers");
                DataRow sDataRow = sDataSet.Tables["tblCustomers"].Rows[0];

                sCompanyName = sDataRow["CompanyName"].ToString();
                sContactName = sDataRow["ContactName"].ToString();
                sCompanyAddress = sDataRow["Address"].ToString();
                sPhoneNumber = sDataRow["PhoneNumber"].ToString();
                sFaxNumber = sDataRow["FaxNumber"].ToString();
                sEmailAddress = sDataRow["EmailAddress"].ToString();
                sWebAddress = sDataRow["Website"].ToString();
            }
            catch (Exception ex) { }
        }

        public static void setWebCamera(string sSelect)
        {
            WebCamera.sSelect = sSelect;
            WebCamera sForm = new WebCamera();
            sForm.ShowDialog();
        }

        public static void setInputBox(string sSelect, string sEntryTable)
        {
            InputBox.sSelect = sSelect;
            InputBox.sEntryTable = sEntryTable;
            InputBox sForm = new InputBox();
            sForm.ShowDialog();
        }

        public static void setUpdateDelay()
        {
            UpdateDelay sForm = new UpdateDelay();
            sForm.ShowDialog();
        }

        public static void isStringEmpty(string sField)
        {
            MessageBox.Show(sField + " is empty.Please check it!", "CRYSTAL V.S. RDLC REPORT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void setIDGenerator(string sTableName, int iNextNo) { setOleDbCommand("UPDATE tblIDGenerator SET NextNo = '" + iNextNo + "' WHERE TableName LIKE '" + sTableName + "' "); }

        public static void setInsertID(string sTableName, int iNextNo) { setOleDbCommand("INSERT INTO tblIDGenerator (NextNo, TableName) Values('" + iNextNo + "', '" + sTableName + "')"); }
    }
}
