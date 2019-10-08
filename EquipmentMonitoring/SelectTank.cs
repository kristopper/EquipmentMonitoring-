using EquipmentMonitoring.Libs;
using EquipmentMonitoring.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class SelectTank : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public SelectTank()
        {
            InitializeComponent();
            CategoryParent();
        }

        private void CategoryParent()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_tanklist.TankName from m_tanklist with(nolock)", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTanktype.DataSource = dt;
                cmbTanktype.DisplayMember = "TankName";
                cmbTanktype.ValueMember = "TankName";
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            DateTime From_today = DateTime.Today; // As DateTime
            string f_today = "'" + From_today.ToString("M/d/yyyy") + "'";

            DateTime To_today = DateTime.Today; // As DateTime
            string t_today = "'" + To_today.ToString("M/d/yyyy") + "'";

            RefillEquipment_main refill = new RefillEquipment_main();

            refill.Param(f_today, t_today);
            refill.Text = cmbTanktype.SelectedValue.ToString().ToUpper();
            refill.Param2(cmbTanktype.SelectedValue.ToString().ToUpper());
            this.Hide();
            refill.ShowDialog();
            this.Close();
        }
    }
}
