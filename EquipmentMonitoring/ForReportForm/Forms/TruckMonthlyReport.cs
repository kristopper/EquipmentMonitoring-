﻿using EquipmentMonitoring.Libs;
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
    public partial class TruckMonthlyReport : Form
    {
        //GenericFunctions GenericFunc = new GenericFunctions();
        //string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        //DataSet data;

        DataTable DataGridl = new DataTable();
        public string MonthYear { get; set; }

        public TruckMonthlyReport()
        {
            InitializeComponent();
        }

        public void Param(DataTable dtlabel, DataTable datagridlist, string SearchMonth, string SearchYear)
        {
            DataGridl = datagridlist;
            MonthYear = (SearchMonth == string.Empty ? " " : SearchMonth) + " " + (SearchYear == string.Empty ? " " : SearchYear);
        }

        private void TruckMonthlyReport_Load(object sender, EventArgs e)
        {

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            ReportParameter[] rptParams = new ReportParameter[(1)];
            rptParams[0] = new ReportParameter("MonthYear", MonthYear);

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
            this.maintenanceDataSet08132019BindingSource.DataSource = DataGridl;
            this.reportViewer1.RefreshReport();

        }
        //public void Param(string SearchType, string SearchValue, string SearchMonth, string SearchYear)
        //{
        //    DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_GetProjectSiteMonthly '" + SearchType + "'," + "'" + SearchValue + "'," + "'" + SearchMonth + "'," + "'" + SearchYear + "'"));
        //    data = dsKey;
        //    MonthYear = SearchMonth + " " + SearchYear;
        //}

    }
}
