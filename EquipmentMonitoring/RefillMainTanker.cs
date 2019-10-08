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
    public partial class RefillMainTanker : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public RefillMainTanker()
        {
            InitializeComponent();
            FuelCategory();
        }

        private void FuelCategory()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_FuelList.FuelType from m_FuelList with(nolock)", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbFueltype.DataSource = dt;
                cmbFueltype.DisplayMember = "FuelType";
                cmbFueltype.ValueMember = "FuelType";
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrice.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma))
            {

            }
            else
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -2)
                {
                    e.Handled = true;
                }
            }

        }

        private void txtLiters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrice.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma))
            {

            }
            else
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
                /*
                if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
                */

                if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -2)
                {
                    e.Handled = true;
                }

            }
        }
        
        //////////////--
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string fueltype = "'" + cmbFueltype.SelectedValue.ToString() + "'";
                string Date = " ";
                string Price = " ";
                string Liters = " ";
                string supplier = "";
                string Driver = " ";
                string Plateno = " ";
                string PumpIncharge = "";


                string spName = "sp_Refill_Maintank";
                SqlDataReader reader;

                Date = "'" + dtpDate.Text + "'";
                Price = "'" + txtPrice.Text + "'";
                Liters = "'" + txtLiters.Text + "'";
                supplier = "'" + txtSupplier.Text + "'";
                Driver = "'" + txtDrivers.Text + "'";
                Plateno = "'" + txtPlate.Text + "'";
                PumpIncharge = "'" + txtPump.Text + "'";

                reader = monitoring.ExecuteReader(spName, fueltype, Date, Price, Liters, supplier, Driver, Plateno, PumpIncharge);
                DataTable result = new DataTable();
                result.Load(reader);
                string Result = result.Rows[0]["Result"].ToString();
                if (Result == "0")
                {
                    MessageBox.Show("Failed To Save. Please Enter Price per liter and No. of Liters..");
                }
                else if (Result == "1")
                {
                    MessageBox.Show("Successfully Saved..");
                    txtPrice.Text = "";
                    txtLiters.Text = "";
                    txtLiters.Text = "";
                    txtSupplier.Text = "";
                    txtDrivers.Text = "";
                    txtPlate.Text = "";
                    txtPump.Text = "";
                    /*
                    txtEqpNo.Text = "";
                    txtEqpName.Text = "";
                    txtPNModelName.Text = "";
                    */

                }
                else
                {
                    MessageBox.Show("Already Saved..");
                }
            }
        }

        private void txtPrice_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLiters_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void lnkdefault_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtLiters.Text = "14000";
        }
    }
}
