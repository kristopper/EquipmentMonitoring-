using EquipmentMonitoring.Libs;
using EquipmentMonitoring.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring.AllForm.expenses
{
    public partial class AddExpensesME : Form
    {

        GenericFunctions GenericFunc = new GenericFunctions();
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        string SExpID = "";
        string sUserID = "";

        public string Result { get; set; }

        public string IsCancel { get; set; }
        public AddExpensesME()
        {
            InitializeComponent();
        }
        public void Param(AutoCompleteStringCollection EmployeeTextAll, string pExpID, string pUserID)
        {
            SExpID = pExpID;
            IsCancel = "1";
            txtName.AutoCompleteCustomSource = EmployeeTextAll;
            sUserID = pUserID;

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {

            string Name = txtName.Text;
            //string a = Regex.Replace(Name, @"\s+", "");

            if (Regex.Replace(Name, @"\s+", "") != "")
            {
                string strSQL = "exec sp_Add_RepairAndMaintenanceME" + " '" + Name + "','" + SExpID + "','" + sUserID + "'";
                //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                DataTable data = new DataTable();
                DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

                if (readesr.Read())
                {
                    Result = readesr["Result"].ToString();
                    //strUsrBranch = reader["Branch"].ToString();
                }

                if (Result == "1")
                {
                    MessageBox.Show("Successfully Save");
                    txtName.Text = "";
                    IsCancel = "0";
                }
                else
                {
                    MessageBox.Show("Mechanic / Electrician already Exist!");
                    IsCancel = "1";
                }
            }
            else
            {
                MessageBox.Show("Mechanic / Electrician Empty!");
            }
        }
    }
}
