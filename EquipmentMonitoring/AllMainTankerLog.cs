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
    public partial class AllMainTankerLog : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public AllMainTankerLog()
        {
            InitializeComponent();
            FuelCategory();
            CategoryParent(cmbfueltype.SelectedValue.ToString());
        }

        private void FuelCategory()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_FuelList.FuelType from m_FuelList with(nolock)", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbfueltype.DataSource = dt;
                cmbfueltype.DisplayMember = "FuelType";
                cmbfueltype.ValueMember = "FuelType";
            }
        }


        public void Param(string pTankname)
        {

            lblTankTruck.Text = pTankname;

            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_RefillDetails with (nolock) where TankRefll = '" + pTankname + "' order by id asc", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            dgvTankLog.DataSource = null;
            if (this.dgvTankLog.DataSource != null)
            {
                this.dgvTankLog.DataSource = null;
            }
            else
            {
                this.dgvTankLog.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvTankLog.Rows.Add(row["Id"].ToString()
                            , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , row["DriversName"].ToString()
                            , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["LitersRefill"]))//row["LitersRefill"].ToString()
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["Availability"]))//row["Availability"].ToString()
                            , row["TankGauge"].ToString()
                            , row["Site"].ToString()
                            , row["Operation"].ToString()
                            , row["PumpIncharge"].ToString()
                            , row["PrevUsage"].ToString()
                            , row["Deleteremark"].ToString()
                            );
                }
            }
            else
            {
            }

        }

        public void Paramsearch(string pTankname, string fromdate, string todate)
        {

            lblTankTruck.Text = pTankname;

            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_RefillDetails with (nolock) where TankRefll = '" + pTankname + "' and Date Between '" + fromdate + "' and '" + todate + "' order by id asc", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            dgvTankLog.DataSource = null;
            if (this.dgvTankLog.DataSource != null)
            {
                this.dgvTankLog.DataSource = null;
            }
            else
            {
                this.dgvTankLog.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvTankLog.Rows.Add(row["Id"].ToString()
                            , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , row["DriversName"].ToString()
                            , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["LitersRefill"]))//row["LitersRefill"].ToString()
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["Availability"]))//row["Availability"].ToString()
                            , row["TankGauge"].ToString()
                            , row["Site"].ToString()
                            , row["Operation"].ToString()
                            , row["PumpIncharge"].ToString()
                            , row["PrevUsage"].ToString()
                            , row["Deleteremark"].ToString()
                            );
                }
            }
            else
            {
            }

        }

        private void CategoryParent(string Fuel)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_TankList with(nolock) where IsMainTank = 1 and TypeOfFuel = '" + Fuel + "'", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTanktruck.DataSource = dt;
                cmbTanktruck.DisplayMember = "TankName";
                cmbTanktruck.ValueMember = "TankName";
            }
        }

        private void lblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FuelLogSheetMain fuelLog = new FuelLogSheetMain();
            this.Hide();
            fuelLog.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Paramsearch(cmbTanktruck.SelectedValue.ToString(), dtfrom.Text, dtTo.Text);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Param(cmbTanktruck.SelectedValue.ToString());
        }
    }
}
