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
    public partial class AddTankList : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        string IsCheck;

        public AddTankList()
        {
            InitializeComponent();
            CategoryParent();
          
        }

        private void CategoryParent()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_fuellist.Id, m_fuellist.FuelType from m_fuellist with(nolock)", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTypeofFuel.DataSource = dt;
                cmbTypeofFuel.DisplayMember = "FuelType";
                cmbTypeofFuel.ValueMember = "FuelType";
            }
        }

        private void txtTankName_keydown(object sender, KeyEventArgs e)
        {

        }

        private void txtNoName_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSave_Click(btnSave, EventArgs.Empty);
            }
        }

        private void txtEquipmentNo_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes if you want to SAVE", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtTankName.Text.Replace(" ", "") == string.Empty)
                {
                    MessageBox.Show("Please enter a value to TankName!");
                    return;
                }
                else
                {
                    SqlDataReader reader;
                    string spName = "sp_Add_Tanklist";
                    string ischeckparam = "'" + IsCheck + "'";
                    string TankName = txtTankName.Text;

                    string ParamTypeOfType = "'" + cmbTypeofFuel.SelectedValue.ToString() + "'";
                    string ParamTankName = "'" + txtTankName.Text + "'";
                    string ParamEquipmentNo = "'" + txtEquipmentNo.Text + "'";
                    string ParamModelName = "'" + txtModelName.Text + "'";
                    string ParamPlateNo = "'" + txtPlateNo.Text + "'";
                    string paramTankGauge = "'" + txtGauge.Text + "'";
                    string  ParamTankCapacity = "'" + txtTankCapacity.Text.Replace(",", "").Replace(" ", "") + "'";
                   
                        reader = monitoring.ExecuteReader(spName, ParamTypeOfType, ParamTankName, ParamEquipmentNo, ParamPlateNo, ParamModelName, ParamTankCapacity, paramTankGauge, ischeckparam);
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
                            txtTankName.Text = "";
                            txtEquipmentNo.Text = "";
                            txtModelName.Text = "";
                            txtPlateNo.Text = "";
                            txtTankCapacity.Text = "";
                            txtGauge.Text = "";
                        }
                        else if (Result == "3")
                        {
                            MessageBox.Show("Please Refill the Main Tank");
                        }
                        else if (Result == "4")
                        {
                            MessageBox.Show("Please Refill the Tanker Truck");
                        }
                        else
                        {
                            MessageBox.Show("Already Saved..");
                        }
                    
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void txtTankCapacity_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void txtGauge_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void chkIsMain_ChekedChanged(object sender, EventArgs e)
        {
            if (chkIsMain.Checked == true)
            {
                IsCheck = "1";
            }
            else
            {
                IsCheck = "0";
            }
        }
    }
}
