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
    public partial class ProjectSiteDetail : Form
    {

        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        DataSet data;

        public string MonthYear { get; set; }
        public string p_ProjectId { get; set; }
        public string p_ProjectSite { get; set; }
        public string p_ProjectDate { get; set; }

        public ProjectSiteDetail()
        {
            InitializeComponent();
        }

        public void Param(string ProjectId, string ProjectNo, string ProjectSite, string ProjectDate, string PMonth, string PYear)
        {
            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_ProjectSiteM_Detail '" + ProjectId + "'," + "'" + ProjectNo + "'," + "'" + ProjectSite + "'," + "'" + ProjectDate + "'," + "'" + PMonth + "'," + "'" + PYear + "'"));
            data = dsKey;
            MonthYear = (PMonth == string.Empty ? " " : PMonth) + " " + (PYear == string.Empty ? " " : PYear);
            p_ProjectId = ProjectNo;
            p_ProjectSite = ProjectSite;
            p_ProjectDate = ProjectDate;
        }

        private void ProjectSiteDetail_Load(object sender, EventArgs e)
        {

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            ReportParameter[] rptParams = new ReportParameter[(4)];
            rptParams[0] = new ReportParameter("ProjectId", p_ProjectId);
            rptParams[1] = new ReportParameter("ProjectSite", p_ProjectSite);
            rptParams[2] = new ReportParameter("ProjectDate", p_ProjectDate);
            rptParams[3] = new ReportParameter("Date", MonthYear);

            reportViewer1.LocalReport.SetParameters(rptParams);

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
