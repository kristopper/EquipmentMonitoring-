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
    public partial class UpdateDeleteForm : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public string strDate { get; set; }
        public string strDrivers { get; set; }
        public string strRefill { get; set; }
        public string strLocation { get; set; }
        public string strLastRefuel { get; set; }
        public string strDuringRefuel { get; set; }
        public string strKmTravel { get; set; }
        public string strHourUsed { get; set; }
        public string strTotalUsed { get; set; }
        public string strID { get; set; }
        public string strEquipNo { get; set; }
        public string strModel { get; set; }
        public string strPlateNo { get; set; }
        public string Trucktype { get; set; }
        public string maintenance { get; set; }
      

        public UpdateDeleteForm()
        {
            InitializeComponent();

        }

        private void UpdateDeleteForm_Load(object sender, EventArgs e)
        {
            //From_today.ToString("M/d/yyyy")
          //  dtpDate.Text = DateTime.ParseExact(strDate, "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            txtDrivers.Text = strDrivers;
            txtDuringRefuel.Text = strDuringRefuel;
            txtHourUsed.Text = strHourUsed;
            txtKmTravel.Text = strKmTravel;
            txtLastRefuel.Text = strLastRefuel;
            txtrefill.Text = strRefill;
            txtLocation.Text = strLocation;
            lbltotal.Text = strTotalUsed;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            strTotalUsed = lbltotal.Text;
            this.Hide();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string result;
            SqlDataReader reader;
            string Date = "'" + dtpDate.Text.ToString() + "'";
            string Drivers = "'" + txtDrivers.Text + "'";
            string Refill = "'" + txtrefill.Text.Replace(",", "") + "'";
            string Location = "'" +  txtLocation.Text + "'";
            string LastRefuel = "'" + txtLastRefuel.Text.Replace(",", "") + "'";
            string DuringRefuel = "'" + txtDuringRefuel.Text.Replace(",", "") + "'";
            string kmTravel = "'" + txtKmTravel.Text.Replace(",","") + "'";
            string HourUsed = "'" + txtHourUsed.Text.Replace(",", "") + "'";
            string Equipno = "'" + strEquipNo  + "'";
            string Model = "'" + strModel + "'";
            string PlateNo = "'" + strPlateNo + "'";
            string id = "'" + strID + "'";
            string type = "'" + Trucktype + "'";
            string spName = "sp_update_Monitoring";

            reader = monitoring.ExecuteReader(spName, id, Equipno, Model, PlateNo, Date, Drivers, Refill, Location, LastRefuel, DuringRefuel
                , kmTravel, HourUsed, type);
            DataTable Detail = new DataTable();
            Detail.Load(reader);
            if (Trucktype == "TRUCK")
            {
                strTotalUsed = Detail.Rows[0]["Kms_Used"].ToString();
                maintenance = Detail.Rows[0]["IsMaintenance"].ToString();


                strDrivers = txtDrivers.Text;
                strDuringRefuel = txtDuringRefuel.Text;
                strHourUsed = txtHourUsed.Text;
                strKmTravel = txtKmTravel.Text;
                strLastRefuel = txtLastRefuel.Text;
                strRefill = txtrefill.Text;
                strLocation = txtLocation.Text;

            }
            else
            {
                strHourUsed = Detail.Rows[0]["Hrs_Used"].ToString();
                maintenance = Detail.Rows[0]["IsMaintenance"].ToString();

                strDrivers = txtDrivers.Text;
                strDuringRefuel = txtDuringRefuel.Text;
                strHourUsed = txtHourUsed.Text;
                strKmTravel = txtKmTravel.Text;
                strLastRefuel = txtLastRefuel.Text;
                strRefill = txtrefill.Text;
                strLocation = txtLocation.Text;
            }
            result = Detail.Rows[0]["Result"].ToString();
            if (result == "1")
            {
                MessageBox.Show("Successfully Update");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Update");
            }
        }

        private void txtDrivers_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtrefill_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLocation_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLastRefuel_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDuringRefuel_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtKmTravel_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtHourUsed_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSave_Click(btnSave, EventArgs.Empty);
            }
        }
    }
}
