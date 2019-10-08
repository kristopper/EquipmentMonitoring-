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
    public partial class RMainTankLogSheet : Form
    {
        public string TankName { get; set; }
        public string TankRefill { get; set; }
        public string FuelType { get; set; }
        public string PreviousRemaining { get; set; }
        public string DateLog { get; set; }
        public string TankAvailability { get; set; }
        public string FuelPullOut { get; set; }
        public string TankRemaining { get; set; }

        DataTable DataGridl = new DataTable();
        public RMainTankLogSheet()
        {
            InitializeComponent();
        }

        public void Param(DataTable dtgrid, DataTable dtlabel)
        {
            foreach (DataRow row in dtlabel.Rows)
            {

                DateLog = row["Date"].ToString() == string.Empty ? " " : row["Date"].ToString().Replace(" 12:00:00 AM", "");
                TankName = row["TankName"].ToString() == string.Empty ? " " : row["TankName"].ToString();
                FuelType = row["FuelType"].ToString() == string.Empty ? " " : row["FuelType"].ToString();
                FuelPullOut = row["TotalLitersPullOut"].ToString() == string.Empty ? " " : row["TotalLitersPullOut"].ToString();
                TankRemaining = row["AvailableFuel"].ToString() == string.Empty ? " " : row["AvailableFuel"].ToString();
                TankRefill = row["NoLiters"].ToString() == string.Empty ? " " : row["NoLiters"].ToString();
                PreviousRemaining = row["AddFromPrev"].ToString() == string.Empty ? " " : row["AddFromPrev"].ToString();
                TankAvailability = row["TankAvailability"].ToString() == string.Empty ? " " : row["TankAvailability"].ToString();

                //fuelMainLogControl.lblDate.Text = row["Date"].ToString();
                //fuelMainLogControl.lblTankTruck.Text = row["TankName"].ToString();
                //fuelMainLogControl.lblpullout.Text = row["TotalLitersPullOut"].ToString();
                //fuelMainLogControl.lblRemaining.Text = row["AvailableFuel"].ToString();
                //fuelMainLogControl.lblTankRefill.Text = row["NoLiters"].ToString();
                //fuelMainLogControl.lblPrevious.Text = row["AddFromPrev"].ToString();
                //fuelMainLogControl.lblTankAvailability.Text = row["TankAvailability"].ToString();
            }
            DataGridl = dtgrid;

        }
        private void RMainTankLogSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceDataSet1.m_FuelMainLogSheetReport' table. You can move, or remove it, as needed.
            //this.m_FuelMainLogSheetReportTableAdapter.Fill(this.maintenanceDataSet1.m_FuelMainLogSheetReport);
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            ReportParameter[] rptParams = new ReportParameter[(8)];
            rptParams[0] = new ReportParameter("TankName", TankName);
            rptParams[1] = new ReportParameter("TankRefill", TankRefill);
            rptParams[2] = new ReportParameter("FuelType", FuelType);
            rptParams[3] = new ReportParameter("PreviousRemaining", PreviousRemaining);
            rptParams[4] = new ReportParameter("DateLog", DateLog);
            rptParams[5] = new ReportParameter("TankAvailability", TankAvailability);
            rptParams[6] = new ReportParameter("FuelPullOut", FuelPullOut);
            rptParams[7] = new ReportParameter("TankRemaining", TankRemaining);

            reportViewer1.LocalReport.SetParameters(rptParams);

            var setup = reportViewer1.GetPageSettings();
            //setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            pg.Margins.Top = 0; //Convert.ToInt32(0.2);
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;

            pg.Landscape = true;


            reportViewer1.SetPageSettings(pg);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            //this.reportviewer1.loca= datagridl;
            this.m_FuelMainLogSheetReportBindingSource.DataSource = DataGridl;
            this.reportViewer1.RefreshReport();


            ////this.reportViewer1.loca= DataGridl;
            ////this.m_FuelMainLogSheetReportBindingSource.DataSource = DataGridl;
            //ReportDataSource rds = new ReportDataSource("extraMove", DataGridl);
            //this.reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.RefreshReport();
        }
    }
}
