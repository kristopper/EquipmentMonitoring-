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
    public partial class ProjectSiteOverAllReport : Form
    {
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        DataSet data;

        //public string MonthYear { get; set; }

        public ProjectSiteOverAllReport()
        {
            InitializeComponent();
        }

        public void Param(string SearchType, string SearchValue)
        {
            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_GetProjectSiteOverAll '" + SearchType + "'," + "'" + SearchValue + "'"));
            //DataTableReader drKey = dsKey.Tables[1].CreateDataReader();
            data = dsKey;
            //MonthYear = (SearchMonth == string.Empty ? " " : SearchMonth) + " " + (SearchYear == string.Empty ? " " : SearchYear);
        }

        private void ProjectSiteOverAllReport_Load(object sender, EventArgs e)
        {
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            //ReportParameter[] rptParams = new ReportParameter[(1)];
            //rptParams[0] = new ReportParameter("MonthYear", MonthYear);

            //reportViewer1.LocalReport.SetParameters(rptParams);

            pg.Margins.Top = 0; //Convert.ToInt32(0.2);
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;

            pg.Landscape = true;

            reportViewer1.SetPageSettings(pg);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            this.maintenanceDataSet08132019BindingSource.DataSource = data.Tables[0];
            this.reportViewer1.RefreshReport();
        }
    }
}
