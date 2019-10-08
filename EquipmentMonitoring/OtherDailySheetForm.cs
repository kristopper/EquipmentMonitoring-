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
    public partial class OtherDailySheetForm : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public OtherDailySheetForm()
        {
            InitializeComponent();
            FuelCategory();
            CategoryParent(cmbfueltype.SelectedValue.ToString());
        }

        private void FuelCategory()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_FuelList.FuelType from m_FuelList with(nolock) order by id asc", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbfueltype.DataSource = dt;
                cmbfueltype.DisplayMember = "FuelType";
                cmbfueltype.ValueMember = "FuelType";
            }
        }

        public void Param(string pTankname)
        {
           //  SqlDataAdapter DATA = new SqlDataAdapter("select * from m_RefillDetails with (nolock) where TankRefll = '" + pTankname + "' and  order by id asc", Connection);
            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_OtherDailySheet with (nolock) order by id asc", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            dgvOtherDaily.DataSource = null;
            if (this.dgvOtherDaily.DataSource != null)
            {
                this.dgvOtherDaily.DataSource = null;
            }
            else
            {
                this.dgvOtherDaily.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvOtherDaily.Rows.Add(row["Id"].ToString()
                            , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , row["DriversName"].ToString()
                            , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["noltrsrefilled"]))//row["LitersRefill"].ToString()
                            //, String.Format("{0:#,###.0}", Convert.ToDecimal(row["Availability"]))//row["Availability"].ToString()
                            //, row["TankGauge"].ToString()
                            , row["ProjectSite"].ToString()
                            , row["Operation"].ToString()
                            , row["PumpIncharge"].ToString()
                            //, row["PrevUsage"].ToString()
                            , row["SourceOfFuel"].ToString()
                            );
                }
            }
            else
            {
            }

        }

        public void Paramsearch(string pTankname, string fromdate, string todate)
        {

            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_OtherDailySheet with (nolock) where SourceOfFuel = '" + pTankname + "' and Date Between '" + fromdate + "' and '" + todate + "' order by id asc", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            dgvOtherDaily.DataSource = null;
            if (this.dgvOtherDaily.DataSource != null)
            {
                this.dgvOtherDaily.DataSource = null;
            }
            else
            {
                this.dgvOtherDaily.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvOtherDaily.Rows.Add(row["Id"].ToString()
                            , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , row["DriversName"].ToString()
                            , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["noltrsrefilled"]))
                            //row["LitersRefill"].ToString()
                            //, String.Format("{0:#,###.0}", Convert.ToDecimal(row["Availability"]))//row["Availability"].ToString()
                            //, row["TankGauge"].ToString()
                            , row["ProjectSite"].ToString()
                            , row["Operation"].ToString()
                            , row["PumpIncharge"].ToString()
                            //, row["PrevUsage"].ToString()
                            , row["SourceOfFuel"].ToString()
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
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_TankList with(nolock) where IsMainTank = 0 and TypeOfFuel = '" + Fuel + "'  order by id asc", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTanktruck.DataSource = dt;
                cmbTanktruck.DisplayMember = "TankName";
                cmbTanktruck.ValueMember = "TankName";
            }
        }
        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Paramsearch(cmbTanktruck.SelectedValue.ToString(), dtpFromDate.Text, dtpToDate.Text);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Param(cmbTanktruck.SelectedValue.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete", "Delete Validation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvOtherDaily.SelectedRows)
                {
                        string result;
                        SqlDataReader reader;

                        string id = "'" + row.Cells[0].Value.ToString() + "'";

                        string spName = "sp_delete_OtherDailySheet";

                        reader = monitoring.ExecuteReader(spName, id);
                        DataTable Detail = new DataTable();
                        Detail.Load(reader);
                        //  MessageBox.Show(row.Cells[0].Value.ToString());
                        dgvOtherDaily.Rows.Remove(row);

                }
            }
        }
    }
}
