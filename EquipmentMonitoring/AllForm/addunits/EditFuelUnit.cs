using EquipmentMonitoring.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring.AllForm.addunits
{
    public partial class EditFuelUnit : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();

        /*
        public string strDate { get; set; }
        public string strDrivers { get; set; }
        public string strRefill { get; set; }
        public string strcontractid { get; set; }
        public string strpumpincharge { get; set; }
        public string strKmTravel { get; set; }
        public string strHourUsed { get; set; }
        public string strTotalUsed { get; set; }
        public string strID { get; set; }
        public string Trucktype { get; set; }
        public string maintenance { get; set; }
        */

        public EditFuelUnit()
        {
            InitializeComponent();
        }

        private void EditFuelUnit_Load(object sender, EventArgs e)
        {
          //  txtDrivers.AutoCompleteCustomSource = EmployeeText;
            /*
            //Convert.ToDateTime(strDate);//DateTime.ParseExact("mm/dd/yyyy", strDate, CultureInfo.InvariantCulture);
            txtDrivers.Text = strDrivers;
            txtrefill.Text = strRefill;
            txtContractId.Text = strcontractid;
            txtPumpIncharge.Text = strpumpincharge;
            txtKmTravel.Text = strKmTravel;
            txtHourUsed.Text = strHourUsed;
            dtDate.Value = DateTime.Parse(strDate);
            */
            //dtDate.Value = DateTime.ParseExact(strDate, "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            // dtDate.Text = "04/20/2018";//DateTime.Parse(strDate);
        }


      
        public void param(string id, string date, string driver, string refill, string contractid, string pumpincharge, string km, string hr, AutoCompleteStringCollection EmployeeTextAll, DataTable dtProjectSite)
        {
         
            AutoCompleteStringCollection ProjectSite = new AutoCompleteStringCollection();

            foreach (DataRow dr in dtProjectSite.Rows)
            {
                ProjectSite.Add(dr["ProjectNo"].ToString());
            }
        
            //employeeControl.txtSupervisor.AutoCompleteCustomSource = EmployeeText;
            txtDrivers.AutoCompleteCustomSource = EmployeeTextAll;
            txtPumpIncharge.AutoCompleteCustomSource = EmployeeTextAll;
            txtContractId.AutoCompleteCustomSource = ProjectSite;

            txtDrivers.Text = driver;
            txtrefill.Text = refill;
            txtContractId.Text = contractid;
            txtPumpIncharge.Text = pumpincharge;
            txtKmTravel.Text = km;
            txtHourUsed.Text = hr;
            dtDate.Text = date;
            lblId.Text = id;

            //txtDrivers.AutoCompleteCustomSource = EmployeeTextAll;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string result;
            SqlDataReader reader;
            string Date = "'" + dtDate.Text.ToString() + "'";
            string Drivers = "'" + txtDrivers.Text + "'";
            string Refill = "'" + txtrefill.Text.Replace(",", "") + "'";
            string Location = "'" + txtContractId.Text + "'";
            string pumpincharge = "'" + txtPumpIncharge.Text.Replace(",", "") + "'";
            string kmTravel = "'" + txtKmTravel.Text.Replace(",", "") + "'";
            string HourUsed = "'" + txtHourUsed.Text.Replace(",", "") + "'";
            string id = "'" + lblId.Text + "'";
            string spName = "sp_update_MonitoringList_1";

            if(kmTravel.Replace(" ","").Replace("'","") == "")
            {
                kmTravel = "'0'";
            }
            if (HourUsed.Replace(" ", "").Replace("'", "") == "")
            {
                HourUsed = "'0'";
            }
            reader = monitoring.ExecuteReader(spName, id, Date, Drivers, Refill, Location, pumpincharge, kmTravel, HourUsed);
            DataTable Detail = new DataTable();
            Detail.Load(reader);
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
    }
}
