using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace crystalrdlc
{
    public partial class ReportViewer : Form
    {
        //STRING VARIABLES
        public static string sSelect;
        public static string sSQL;
        public static string sTable;

        //BOOLEAN VARIABLES
        public static bool boolSTATUS;

        //PARAMETER VARIABLES
        CrystalDecisions.Shared.ParameterValues pvCollection = new CrystalDecisions.Shared.ParameterValues();
        CrystalDecisions.Shared.ParameterDiscreteValue pdvBUSINESSNAME = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue pdvBUSINESSADDRESS = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue pdvBUSINESSCONTACTS = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue pdvPREPAREDBY = new CrystalDecisions.Shared.ParameterDiscreteValue();

        public ReportViewer(){InitializeComponent();}

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (boolSTATUS == true)//LOAD RDLC REPORT
            {
                rdlcviewer.Dock = DockStyle.Fill;
                rdlcviewer.Visible = true;
                setRDLCREport();
            }
            else//LOAD CRYSTAL REPORT
            {
                crystalviewer.Dock = DockStyle.Fill;
                crystalviewer.Visible = true;
                setCRYSTALReport();
            }
        }

        private void setCRYSTALReport()
        {
            dsCustomers dsReport = new dsCustomers();

            DataSet ds = clsADONET.setReport(dsReport, sSQL, sTable);
            crystalCustomers rptViewer = new crystalCustomers();

            rptViewer.SetDataSource(ds);
            crystalviewer.ReportSource = rptViewer;

            pdvBUSINESSNAME.Value = clsADONET.sCompanyName;
            pvCollection.Clear();
            pvCollection.Add(pdvBUSINESSNAME);
            rptViewer.DataDefinition.ParameterFields["CompanyName"].ApplyCurrentValues(pvCollection);

            pdvBUSINESSADDRESS.Value = clsADONET.sCompanyAddress;
            pvCollection.Clear();
            pvCollection.Add(pdvBUSINESSADDRESS);
            rptViewer.DataDefinition.ParameterFields["Address"].ApplyCurrentValues(pvCollection);

            pdvBUSINESSCONTACTS.Value = "Phone Number: " + clsADONET.sPhoneNumber + "  and  " + "Fax Number: " + clsADONET.sFaxNumber;
            pvCollection.Clear();
            pvCollection.Add(pdvBUSINESSCONTACTS);
            rptViewer.DataDefinition.ParameterFields["Contacts"].ApplyCurrentValues(pvCollection);

            pdvPREPAREDBY.Value = clsADONET.sUserFullname;
            pvCollection.Clear();
            pvCollection.Add(pdvPREPAREDBY);
            rptViewer.DataDefinition.ParameterFields["PreparedBy"].ApplyCurrentValues(pvCollection);
        }

        private void setRDLCREport()
        {
            clsADONET.setConnection();
            clsADONET.sConnection.Open();
            clsADONET.sCommand.Connection = clsADONET.sConnection;
            clsADONET.sCommand.CommandText = sSQL;
            clsADONET.sDataReader = clsADONET.sCommand.ExecuteReader();

            clsADONET.dsCustrs.Tables[0].Load(clsADONET.sDataReader);

            rdlcviewer.LocalReport.ReportEmbeddedResource = "crystalrdlc.rdlcCustomers.rdlc";
            ReportDataSource sReportDataSource = new ReportDataSource();
            sReportDataSource.Name = "dsCustomers_tblCustomers";
            sReportDataSource.Value = clsADONET.dsCustrs.Tables[0];
            rdlcviewer.LocalReport.DataSources.Add(sReportDataSource);

            //add report parameters
            ReportParameter[] Param = new ReportParameter[3];

            Param[0] = new ReportParameter("parReportCompanyName", clsADONET.sCompanyName);
            Param[1] = new ReportParameter("parReportAddress", clsADONET.sCompanyAddress);
            Param[2] = new ReportParameter("parReportContacts", "Phone Number: " + clsADONET.sPhoneNumber + "  and  " + "Fax Number: " + clsADONET.sFaxNumber);

            rdlcviewer.LocalReport.SetParameters(Param);
            rdlcviewer.RefreshReport();
        }
    }
}