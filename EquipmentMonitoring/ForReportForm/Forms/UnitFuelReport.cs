using EquipmentMonitoring.Libs;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring.ForReportForm.Forms
{
    public partial class UnitFuelReport : Form
    {
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        DataSet datavalue;
        public string EquipmentNo { get; set; }
        public string Model { get; set; }
        public string PlateNo { get; set; }
        public string DateParam { get; set; }
        public string TotalKm { get; set; }
        public string TotalHrs { get; set; }

        public UnitFuelReport()
        {
            InitializeComponent();
        }
        public void Param(string pEquipmentNo, string pModel, string pPlateNo, string StartDate, string EndDate)
        {

            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_InfoAndMonitoring '" + pEquipmentNo + "'," + "'" + pModel + "'," + "'" + pPlateNo + "'," + "'" + StartDate + "'," + "'" + EndDate  + "'"));
            datavalue = dsKey;
            EquipmentNo = pEquipmentNo;
            Model = pModel;
            PlateNo = pPlateNo;


            TotalKm = dsKey.Tables[1].Rows[0]["Kms_Used"].ToString();
            TotalHrs = dsKey.Tables[1].Rows[0]["Hrs_Used"].ToString();

            DateParam = (StartDate == string.Empty ? " " : StartDate.Replace(" 12:00:00 AM", "")) + " To " + (EndDate == string.Empty ? " " : EndDate.Replace(" 12:00:00 AM", ""));


        }

        private void UnitFuelReport_Load(object sender, EventArgs e)
        {

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            ReportParameter[] rptParams = new ReportParameter[(6)];
            rptParams[0] = new ReportParameter("EquipmentNo", EquipmentNo);
            rptParams[1] = new ReportParameter("Model", Model);
            rptParams[2] = new ReportParameter("PlateNo", PlateNo);
            rptParams[3] = new ReportParameter("Date", DateParam);
            rptParams[4] = new ReportParameter("TotalKmUsed", TotalKm);
            rptParams[5] = new ReportParameter("TotalhrsUsed", TotalHrs);

            reportViewer1.LocalReport.SetParameters(rptParams);

            pg.Margins.Top = 0; //Convert.ToInt32(0.2);
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;

            pg.Landscape = true;
            //pg.PaperSize.

            //pg.PaperSize.Height = 13;
            //pg.PaperSize.Width = 8;
            //reportViewer1.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom", 650, 325)
            reportViewer1.SetPageSettings(pg);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            this.maintenanceDataSet08132019BindingSource.DataSource = datavalue.Tables[3]; ;
            this.reportViewer1.RefreshReport();
        }
    }
}
