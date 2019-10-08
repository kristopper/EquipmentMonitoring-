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
    public partial class RefillEquipment_main : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public string EName { get; set; }

        public RefillEquipment_main()
        {
            InitializeComponent();
            dtpFrom.Value = DateTime.Now;

        }
        public void Param2(string Name)
        {
            EName = Name;
        }

        public void Param(string f_today, string t_today)
        {
            SqlDataReader reader;


            string spName = "sp_Get_RefillDetails";

            reader = monitoring.ExecuteReader(spName, f_today, t_today);
            DataTable Detail = new DataTable();
            Detail.Load(reader);


            foreach (DataRow row in Detail.Rows)
            {
                dgvDetails.Rows.Add(row["Date"].ToString().Replace(" 12:00:00 AM", "")
                        , row["DriversName"].ToString()
                        , row["PlateNo"].ToString()
                        , row["LitersRefill"].ToString()
                        , row["Availability"].ToString()
                        , row["TankGauge"].ToString()
                        , row["PumpIncharge"].ToString()
                        , row["Site"].ToString()
                        , row["Operation"].ToString()
                        , row["kmhrs"].ToString()
                        );
            }
            //result = Detail.Rows[0]["Result"].ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

       
        private void btnRefillMain_Click(object sender, EventArgs e)
        { 
            /*
            RefillMainTank refill = new RefillMainTank();
            refill.Param2(EName);
            this.Hide();
            refill.ShowDialog();
            this.Close();
        */
        }

            private void btnSearch_Click(object sender, EventArgs e)
        {
            string fromdate = "'" + dtpFrom.Value.ToString("M/d/yyyy") + "'";
            string todate = "'" + dtpTo.Value.ToString("M/d/yyyy") + "'";
            Param(fromdate, todate);
        }

        /*

public void Param(string EquipmentNo, string Equipmentname, string Name, string id, DataTable data, string numbertable, string value, string TotalUsed, string isMaintenance)
{
lblEqpNo.Text = EquipmentNo;
lblEqpName.Text = Equipmentname;
lblNoName.Text = Name;
lblTotalUsed.Text = TotalUsed;

MEquipmentNo = EquipmentNo;
MEquipmentname = Equipmentname;
MName = Name;
mvalue = value;
Mid = id;
MTotalUsed = TotalUsed;
misMaintenance = isMaintenance;

if(misMaintenance == "0")
{
// MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
lblTotalUsed.ForeColor = Color.Black;
}
else
{
lblTotalUsed.ForeColor = Color.DarkRed;
}

foreach (DataRow row in data.Rows)
{
dgvDataMonitoring.Rows.Add(row["Id"].ToString()
      , row["Date"].ToString().Replace(" 12:00:00 AM","")
      , row["Drivers_OptName"].ToString()
      , row["kmhrs_duringRefuel"].ToString()
      , row["kmhrs_LastRefuel"].ToString()
      , row["Kmhrs_Used"].ToString()
      , row["NoLtrsRefill"].ToString()
      , row["PreventiveId"].ToString()
      , row["PLocation"].ToString()
      );
}
}
*/
    }
}
