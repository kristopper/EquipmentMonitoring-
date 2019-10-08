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

namespace EquipmentMonitoring.AllForm.FuelForm.FuelPriceList
{
    public partial class UpdateFuelPriceForm : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public string pfueltype { get; set; }
        public string pDate { get; set; }
        public string pPrice { get; set; }
        public string pLiters { get; set; }
        public string psupplier { get; set; }
        public string pDriver { get; set; }
        public string pPlateno { get; set; }
        public string pPumpIncharge { get; set; }

        public UpdateFuelPriceForm()
        {
            InitializeComponent();
            FuelCategory();
        }

        private void FuelCategory()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_FuelList.FuelType from m_FuelList with(nolock) where IsDelete = 1", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbFueltype.DataSource = dt;
                cmbFueltype.DisplayMember = "FuelType";
                cmbFueltype.ValueMember = "FuelType";
            }
        }

        public void param(string id,string sdate, string sprice, string sliters, string sSupplier, string sDriver, string sPlateno, string sPumpIncharge, string sFuel)
        {
            pDate = sdate;
            pPrice = sprice;
            pLiters = sliters;
            psupplier = sSupplier;
            pDriver = sDriver;
            pPlateno = sPlateno;
            pPumpIncharge = sPumpIncharge;
            pfueltype = sFuel;

            lblId.Text = id;
            dtpDate.Text = sdate;
            txtPrice.Text = sprice;
            txtLiters.Text = sliters;
            txtSupplier.Text = sSupplier;
            txtDrivers.Text = sDriver;
            txtPlate.Text = sPlateno;
            txtPump.Text = sPumpIncharge;
            cmbFueltype.Text = sFuel;
        }

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
                string id = "'" + lblId.Text + "'";


                string spName = "sp_Update_Refill_Maintank";
                SqlDataReader reader;

                Date = "'" + dtpDate.Text + "'";
                Price = "'" + txtPrice.Text.Replace(",","") + "'";
                Liters = "'" + txtLiters.Text.Replace(",", "") + "'";
                supplier = "'" + txtSupplier.Text + "'";
                Driver = "'" + txtDrivers.Text + "'";
                Plateno = "'" + txtPlate.Text + "'";
                PumpIncharge = "'" + txtPump.Text + "'";


                if (txtPrice.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Price");
                }
                else if (txtLiters.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter No. Liters Refill");
                }
                else if (txtSupplier.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Supplier");
                }
                else if (txtDrivers.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Driver");
                }
                else if (txtPlate.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Plate No.");
                }
                else if (txtPump.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Pump-Incharge");
                }
                else
                {
                    reader = monitoring.ExecuteReader(spName, id, fueltype, Date, Price, Liters, supplier, Driver, Plateno, PumpIncharge);
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
                        pDate = dtpDate.Text;
                        pPrice = txtPrice.Text;
                        pLiters = txtLiters.Text;
                        psupplier = txtSupplier.Text;
                        pDriver = txtDrivers.Text;
                        pPlateno = txtPlate.Text;
                        pPumpIncharge = txtPump.Text;
                        pfueltype = cmbFueltype.SelectedValue.ToString();

                        txtPrice.Text = "";
                        txtLiters.Text = "";
                        txtLiters.Text = "";
                        txtSupplier.Text = "";
                        txtDrivers.Text = "";
                        txtPlate.Text = "";
                        txtPump.Text = "";
                        this.Close();
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
    }
}
