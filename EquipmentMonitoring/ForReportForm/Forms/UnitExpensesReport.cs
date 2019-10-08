using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring.ForReportForm.Forms
{
    public partial class UnitExpensesReport : Form
    {
        DataTable data;

        public string EquipmentNo { get; set; }
        public string Model { get; set; }
        public string PlateNo { get; set; }
        public string DateParam { get; set; }
        public UnitExpensesReport()
        {
            InitializeComponent();
        }

        public void Param(DataTable dtUnitExpenses, string pEquipNo, string pModel, string pPlate, string FromDate, string ToDate)
        {
            data = dtUnitExpenses;
            EquipmentNo = pEquipNo;
            Model = pModel;
            PlateNo = pPlate;

            DateParam = (FromDate == string.Empty ? " " : FromDate.Replace(" 12:00:00 AM", "")) + " To " + (ToDate == string.Empty ? " " : ToDate.Replace(" 12:00:00 AM", ""));

        }

        private void UnitExpensesReport_Load(object sender, EventArgs e)
        {

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            ReportParameter[] rptParams = new ReportParameter[(4)];
            rptParams[0] = new ReportParameter("EquipmentNo", EquipmentNo);
            rptParams[1] = new ReportParameter("Model", Model);
            rptParams[2] = new ReportParameter("PlateNo", PlateNo);
            rptParams[3] = new ReportParameter("Date", DateParam);

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

            this.maintenanceDataSet08132019BindingSource.DataSource = data;
            this.reportViewer1.RefreshReport();
        }
    }
}
