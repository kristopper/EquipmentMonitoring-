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
    public partial class AddFuelType : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public AddFuelType()
        {
            InitializeComponent();
        }

        private void txtTypeofFuel_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSave_Click(btnSave, EventArgs.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string spName = "sp_Add_FuelType";
            string FuelType = "";
            string ParamFuelType = "";
            SqlDataReader reader;

            FuelType = txtTypeofFuel.Text;

            if (FuelType == "" || FuelType == " " || FuelType == null)
            {
                MessageBox.Show("Please Enter Fuel Type");
            }
            else
            {
                ParamFuelType = "'" + FuelType + "'";
                DialogResult dialogResult = MessageBox.Show("Please Click Yes to Continue", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    reader = monitoring.ExecuteReader(spName, ParamFuelType);
                    DataTable result = new DataTable();
                    result.Load(reader);
                    string Result = result.Rows[0]["Result"].ToString();
                    if (Result == "0")
                    {
                        MessageBox.Show("Failed To Save..");
                    }
                    else if (Result == "1")
                    {
                        MessageBox.Show("Successfully Saved..");
                        txtTypeofFuel.Text = "";

                    }
                    else if (Result == "3")
                    {
                        MessageBox.Show("Please Enter Fuel Type");
                    }
                    else
                    {
                        MessageBox.Show("Already Saved..");
                    }
                }
                else
                {

                }
                
            }
        }
    }
}
