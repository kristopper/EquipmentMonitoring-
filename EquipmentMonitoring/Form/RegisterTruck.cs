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
    public partial class RegisterTruck : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public RegisterTruck()
        {
            InitializeComponent();
            CategoryParent();
            FuelCategory();
            TruckFormControl.cmbPurchase.SelectedIndexChanged += new System.EventHandler(this.cmbPurchase_SelectedIndexChanged);
            TruckFormControl.txtChassisNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChassisNo_keydown);
            TruckFormControl.txtEngineNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEngineNo_keydown);
            TruckFormControl.txtEqpNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEqpNo_keydown);
            TruckFormControl.txtEqpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEqpName_keydown);
            TruckFormControl.txtPNModelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPNModelName_keydown);
            TruckFormControl.txtEngineNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEngineNo_keydown);
            TruckFormControl.txtPiston.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPiston_keydown);
            TruckFormControl.txtCylinder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCylinder_keydown);
            TruckFormControl.txtMake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMake_keydown);
            TruckFormControl.txtSeries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSeries_keydown);
            TruckFormControl.txtBodyType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBodyType_keydown);
            TruckFormControl.txtYearModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYearModel_keydown);
            TruckFormControl.txtGrossWT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGrossWT_keydown);
            TruckFormControl.txtCRNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCRNo_keydown);
            TruckFormControl.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_keydown);
            TruckFormControl.txtExisting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExisting_keydown);
            TruckFormControl.txtMVFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMVFile_keydown);

            TruckFormControl.cmbPurchase.SelectedIndex = 0;
            //TruckFormControl.cmbPurchase.SelectedIndexChanged += PurchaseChange;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void txtEqpNo_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtEqpName_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPNModelName_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void txtEngineNo_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
                }
        }

        private void txtChassisNo_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPiston_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCylinder_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMake_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSeries_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtBodyType_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtYearModel_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtGrossWT_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCRNo_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSupplier_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtExisting_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMVFile_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmbPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TruckFormControl.cmbPurchase.SelectedIndex == 1)
            {
                TruckFormControl.lblexisting.Visible = true;
                TruckFormControl.txtExisting.Visible = true;
                TruckFormControl.txtExisting.Text = "";
            }
            else
            {
                TruckFormControl.lblexisting.Visible = false;
                TruckFormControl.txtExisting.Visible = false;
                TruckFormControl.txtExisting.Text = "0";
            }
        }

        private void CategoryParent()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_TruckType.TruckId, m_TruckType.TruckType from m_TruckType with(nolock)", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TruckFormControl.cmbType.DataSource = dt;
                TruckFormControl.cmbType.DisplayMember = "TruckType";
                TruckFormControl.cmbType.ValueMember = "TruckId";
            }
        }
        private void FuelCategory()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_FuelList.FuelType from m_FuelList with(nolock)", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TruckFormControl.cmbfuel.DataSource = dt;
                TruckFormControl.cmbfuel.DisplayMember = "FuelType";
                TruckFormControl.cmbfuel.ValueMember = "FuelType";
            }
        }
        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string TruckType = " ";
            string EquipmentNo = " ";
            string Model = " ";
            string PlateNumber = " ";
            string EngineNo = "'" + TruckFormControl.txtEngineNo.Text + "'";
            string ChassisNo = "'" + TruckFormControl.txtChassisNo.Text + "'";
            string Piston = "'" + TruckFormControl.txtPiston.Text + "'";
            string Cylinder = "'" + TruckFormControl.txtCylinder.Text + "'";
            string Make = "'" + TruckFormControl.txtMake.Text + "'";
            string Series = "'" + TruckFormControl.txtSeries.Text + "'";
            string BodyType = "'" + TruckFormControl.txtBodyType.Text + "'";
            string GrossWT = "'" + TruckFormControl.txtGrossWT.Text + "'";
            string YearModel = "'" + TruckFormControl.txtYearModel.Text + "'";
            string PurchaseType = "'" + TruckFormControl.cmbPurchase.SelectedItem.ToString() + "'";
            string DateofPurchase = "'" + TruckFormControl.dtpPurchase.Text + "'";
            string Supplier = "'" + TruckFormControl.txtSupplier.Text + "'";
            string CRno = "'" + TruckFormControl.txtCRNo.Text + "'";
            string MVFileno = "'" + TruckFormControl.txtMVFile.Text + "'";
            string ExistingKmR = "'" + TruckFormControl.txtExisting.Text + "'";
            string MonthExpired = "'" + TruckFormControl.cmbMonth.SelectedItem.ToString() + "'";
            string YearExpired = "'" + TruckFormControl.txtYear.Text + "'";

            string tempEquipmentNo = " ";
            string tempEquipmentName = " ";
            string tempPN_MN = " ";
            string spName = "sp_Add_Equipment";
            SqlDataReader reader;
            TruckType = "'" + TruckFormControl.cmbType.SelectedValue.ToString() + "'";
            string fueltype = "'" + TruckFormControl.cmbfuel.SelectedValue.ToString() + "'";

            EquipmentNo = "'" + TruckFormControl.txtEqpNo.Text + "'";
            Model = "'" + TruckFormControl.txtEqpName.Text + "'";
            PlateNumber = "'" + TruckFormControl.txtPNModelName.Text + "'";
            tempEquipmentNo = TruckFormControl.txtEqpNo.Text;
            tempEquipmentName = TruckFormControl.txtEqpName.Text;
            tempPN_MN = TruckFormControl.txtPNModelName.Text;

            /*
            MessageBox.Show("Successfully Saved..");
            TruckFormControl.txtEqpNo.Text = "";
            TruckFormControl.txtEqpName.Text = "";
            TruckFormControl.txtPNModelName.Text = "";
            TruckFormControl.txtEngineNo.Text = "";
            TruckFormControl.txtChassisNo.Text = "";
            TruckFormControl.txtPiston.Text = "";
            TruckFormControl.txtCylinder.Text = "";
            TruckFormControl.txtMake.Text = "";
            TruckFormControl.txtSeries.Text = "";
            TruckFormControl.txtBodyType.Text = "";
            TruckFormControl.txtGrossWT.Text = "";
            TruckFormControl.txtYearModel.Text = "";
            TruckFormControl.dtpPurchase.Text = "";
            TruckFormControl.txtSupplier.Text = "";
            TruckFormControl.txtCRNo.Text = "";
            TruckFormControl.txtMVFile.Text = "";
            TruckFormControl.txtExisting.Text = "";
            TruckFormControl.txtYear.Text = "";
            TruckFormControl.cmbMonth.SelectedIndex = 0;
            */
           
            if (tempEquipmentNo == "" && tempEquipmentName == "" || tempPN_MN == "" && tempEquipmentName == "")
            {
                MessageBox.Show("Please Enter EquipmentNo, EquipmentName and Plate No./Model Name");
            }
            else
            {
                reader = monitoring.ExecuteReader(spName, TruckType, EquipmentNo, Model, PlateNumber, fueltype, EngineNo, ChassisNo, Piston, Cylinder, Make, Series, BodyType, GrossWT, YearModel, PurchaseType, DateofPurchase, Supplier, CRno, MVFileno, ExistingKmR, MonthExpired, YearExpired);
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
                    TruckFormControl.txtEqpNo.Text = "";
                    TruckFormControl.txtEqpName.Text = "";
                    TruckFormControl.txtPNModelName.Text = "";
                    TruckFormControl.txtEngineNo.Text = "";
                    TruckFormControl.txtChassisNo.Text = "";
                    TruckFormControl.txtPiston.Text = "";
                    TruckFormControl.txtCylinder.Text = "";
                    TruckFormControl.txtMake.Text = "";
                    TruckFormControl.txtSeries.Text = "";
                    TruckFormControl.txtBodyType.Text = "";
                    TruckFormControl.txtGrossWT.Text = "";
                    TruckFormControl.txtYearModel.Text = "";
                    TruckFormControl.dtpPurchase.Text = "";
                    TruckFormControl.txtSupplier.Text = "";
                    TruckFormControl.txtCRNo.Text = "";
                    TruckFormControl.txtMVFile.Text = "";
                    TruckFormControl.txtExisting.Text = "";
                    TruckFormControl.txtYear.Text = "";
                    TruckFormControl.cmbMonth.SelectedIndex = 0;
                    

                    /*   
                    string EngineNo = "'" + txtEngineNo.Text + "'";
                    string ChassisNo = "'" + txtChassisNo.Text + "'";
                    string Piston = "'" + txtPiston.Text + "'";
                    string Cylinder = "'" + txtCylinder.Text + "'";
                    string Make = "'" + txtMake.Text + "'";
                    string Series = "'" + txtSeries.Text + "'";
                    string BodyType = "'" + txtBodyType.Text + "'";
                    string GrossWT = "'" + txtGrossWT.Text + "'";
                    string YearModel = "'" + txtYearModel.Text + "'";
                    string PurchaseType = "'" + cmbPurchase.SelectedItem.ToString() + "'";
                    string DateofPurchase = "'" + dtpPurchase.Text + "'";
                    string Supplier = "'" + txtSupplier.Text + "'";
                    string CRno = "'" + txtCRNo.Text + "'";
                    string MVFileno = "'" + txtMVFile.Text + "'";
                    string ExistingKmR = "'" + txtExisting.Text + "'";
                    string MonthExpired = "'" + cmbMonth.SelectedItem.ToString() + "'";
                    string YearExpired = "'" + txtYear.Text + "'";    
                    */
                }
                else
                {
                    MessageBox.Show("Already Saved..");
                }
                   
            } 
        }
    }
}
