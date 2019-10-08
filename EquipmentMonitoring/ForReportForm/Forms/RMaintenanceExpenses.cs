using EquipmentMonitoring.Libs;
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
    public partial class RMaintenanceExpenses : Form
    {

        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        DataSet data;

        public RMaintenanceExpenses()
        {
            InitializeComponent();
        }

        private void RMaintenanceExpenses_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void Param()//(string SearchType, string SearchValue, string SearchMonth, string SearchYear)
        {

            //DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_GetProjectSiteMonthly '" + SearchType + "'," + "'" + SearchValue + "'," + "'" + SearchMonth + "'," + "'" + SearchYear + "'"));
            //data = dsKey;

            //DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_GetProjectSiteMonthly '" + SearchType + "'," + "'" + SearchValue + "'," + "'" + SearchMonth + "'," + "'" + SearchYear + "'"));
            //data = dsKey;
            //MonthYear = (SearchMonth == string.Empty ? " " : SearchMonth) + " " + (SearchYear == string.Empty ? " " : SearchYear);
        }
    }
}
