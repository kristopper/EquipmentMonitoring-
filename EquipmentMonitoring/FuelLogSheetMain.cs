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
    public partial class FuelLogSheetMain : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public FuelLogSheetMain()
        {
            InitializeComponent();
            FuelCategory();
            CategoryParent(cmbfueltype.SelectedValue.ToString());
            DateRefillParent(cmbTanktruck.SelectedValue.ToString());
            Param(cmbDate.SelectedValue.ToString(), cmbTanktruck.SelectedValue.ToString());
        }

        private void FuelCategory()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_FuelList.FuelType from m_FuelList with(nolock)  order by id asc", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbfueltype.DataSource = dt;
                cmbfueltype.DisplayMember = "FuelType";
                cmbfueltype.ValueMember = "FuelType";
            }
        }


        private void CategoryParent(string Fuel)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_TankList with(nolock) where IsMainTank = 1 and TypeOfFuel = '" + Fuel + "' order by id asc", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTanktruck.DataSource = dt;
                cmbTanktruck.DisplayMember = "TankName";
                cmbTanktruck.ValueMember = "TankName";
            }
        }

        public void Param(string Date, string pTankname)
        {

            SqlDataAdapter DATA1 = new SqlDataAdapter("select CONVERT(VARCHAR(10), Date, 101) as Date, NoLiters, RemainingFuel, AddFromPrev" +
                " , TotalLitersPullOut, BaseOnGauge, TankName from m_FuelPriceList with (nolock) where TankName = '" + pTankname + "' and Date = '" + Date + "'", Connection);
            DataTable dt1 = new DataTable();
            DATA1.Fill(dt1);

            foreach (DataRow row in dt1.Rows)
            {
                lblDate.Text = row["Date"].ToString();
                lblTankTruck.Text = row["TankName"].ToString();
                lblBaseongauge.Text = row["BaseOnGauge"].ToString();
                lblpullout.Text = row["TotalLitersPullOut"].ToString();
                lblRemaining.Text = row["RemainingFuel"].ToString();
                lblTankRefill.Text = row["NoLiters"].ToString();
                lblPrevious.Text = row["AddFromPrev"].ToString();
            }


            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_RefillDetails with (nolock) where TankRefll = '" + pTankname + "' and TankDate = '" + Date + "'  order by id asc", Connection);
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
        private void DateRefillParent(string pTankname)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select CONVERT(VARCHAR(10), Date, 101) as Datevalue from m_FuelPriceList with (nolock) where TankName = '" + pTankname + "'  order by id asc", Con);

                da.Fill(dt);
                // CONVERT(VARCHAR(10), Date, 101)
                cmbDate.DataSource = dt;
                cmbDate.DisplayMember = "Datevalue";
                cmbDate.ValueMember = "Datevalue";
            }
        }

        private void cmbfueltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryParent(cmbfueltype.SelectedValue.ToString());
        }

        private void cmbTanktruck_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateRefillParent(cmbTanktruck.SelectedValue.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Param(cmbDate.SelectedValue.ToString(), cmbTanktruck.SelectedValue.ToString());
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void lnkViewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllMainTankerLog allMain = new AllMainTankerLog();
            this.Hide();
            allMain.ShowDialog();
            this.Close();
        }
    }
}
