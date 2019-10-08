using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring.ForReportForm.Forms
{
    public partial class AllMaintenanceExpensesReport : Form
    {

        DataTable data;
        public string Category { get; set; }
        public string TypeRepair { get; set; }
        public string ProjectId { get; set; }
        public string DateParam { get; set; }
        public string isCheck { get; set; }
        public AllMaintenanceExpensesReport()
        {
            InitializeComponent();
        }


        public void Param(DataTable dtAllMaintenanceExpenses, string pCategory, string pTypeRepair, string pProjectId, string pfromdate, string ptodate, string pischeck)
        {
            data = dtAllMaintenanceExpenses;
            Category = pCategory;
            TypeRepair = pTypeRepair;
            ProjectId = pProjectId;
            isCheck = pischeck;

            DateParam = (pfromdate == string.Empty ? " " : pfromdate.Replace(" 12:00:00 AM", "")) + " To " + (ptodate == string.Empty ? " " : ptodate.Replace(" 12:00:00 AM", ""));

        }

        private void AllMaintenanceExpensesReport_Load(object sender, EventArgs e)
        {

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            ReportParameter[] rptParams = new ReportParameter[(5)];
            rptParams[0] = new ReportParameter("Category", Category == string.Empty ? " ": Category);
            rptParams[1] = new ReportParameter("TypeRepair", TypeRepair == string.Empty ? " " : TypeRepair);
            rptParams[2] = new ReportParameter("ProjectId", ProjectId == string.Empty ? " " : ProjectId);
            rptParams[3] = new ReportParameter("Date", DateParam == string.Empty ? " " : DateParam);
            rptParams[4] = new ReportParameter("isCheck", isCheck == string.Empty ? " " : isCheck);

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
