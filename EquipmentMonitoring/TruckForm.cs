using EquipmentMonitoring.model;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class TruckForm : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        
        public int resultparam { get; set; }
        public string userlogin { get; set; }
        public TruckForm()
        {
            InitializeComponent();
            CategoryParent();
            FuelCategory();
            cmbPurchase.SelectedIndex = 0;
            resultparam = 0;
            cmbMonth.SelectedIndex = 1;
        }

        public void param(string userid)
        {
            userlogin = userid;
        }
        private void CategoryParent()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_TruckType.TruckId, m_TruckType.TruckType from m_TruckType with(nolock) where IsDelete = '1'", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbType.DataSource = dt;
                cmbType.DisplayMember = "TruckType";
                cmbType.ValueMember = "TruckId";
            }
        }
        private void FuelCategory()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_FuelList.FuelType from m_FuelList with(nolock) where IsDelete = '1'", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbfuel.DataSource = dt;
                cmbfuel.DisplayMember = "FuelType";
                cmbfuel.ValueMember = "FuelType";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ExistingKmR = "";

                string ExistingKmR1 = txtExisting.Text;

                string unitprice = "'" + txtUnitPrice.Text + "'";

                //if (Regex.Replace(StartRepair, @"\s+", "") == "")
               if (Regex.Replace(ExistingKmR1, @"\s+", "") == "") //(ExistingKmR1.Replace(" ", "") == "")
                {

                    ExistingKmR = "'0'";
                }
                else
                {
                    ExistingKmR = "'" + txtExisting.Text + "'";
                }
                if (Regex.Replace(unitprice, @"\s+", "") == "") //if (unitprice.Replace(" ", "") == "")
                {

                    unitprice = "'0'";
                }
                else
                {
                    unitprice = "'" + txtUnitPrice.Text + "'";
                }


                string HourlyRate = "'" + txtHourlyRate.Text + "'";

                if (Regex.Replace(HourlyRate, @"\s+", "") == "") //if (HourlyRate.Replace(" ", "") == "")
                {

                    HourlyRate = "'0'";
                }
                else
                {
                    HourlyRate = "'" + txtHourlyRate.Text + "'";
                }



                //MessageBox.Show(cmbType.SelectedValue.ToString());
                string TruckType = " ";
                string EquipmentNo = " ";
                string Model = " ";
                string PlateNumber = " ";
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
                string MonthExpired = "'" + cmbMonth.SelectedItem.ToString() + "'";
                string YearExpired = "'" + txtYear.Text + "'";

                string kmltr = "'" + txtkmsltr.Text + "'";
                string userid = "'" + userlogin + "'";

                /*
                string EngineNo;
                string ChassisNo;
                string Piston;
                string Cylinder;
                string Make;
                string Series;
                string BodyType;
                string GrossWT;
                string YearModel;
                string PurchaseType;
                string DateofPurchase;
                string Supplier;
                string CRno;
                string MVFileno;
                string ExistingKmR;
                string MonthExpired;
                string YearExpired;
                */


                string tempEquipmentNo = " ";
                string tempEquipmentName = " ";
                string tempPN_MN = " ";
                string spName = "sp_Add_Equipment";
                SqlDataReader reader;
                TruckType = "'" + cmbType.SelectedValue.ToString() + "'";
                string fueltype = "'" + cmbfuel.SelectedValue.ToString() + "'";
                //string ExistingKmR1 = txtExisting.Text;

                EquipmentNo = "'" + txtEqpNo.Text + "'";
                Model = "'" + txtEqpName.Text + "'";
                PlateNumber = "'" + txtPNModelName.Text + "'";
                tempEquipmentNo = txtEqpNo.Text;
                tempEquipmentName = txtEqpName.Text;
                tempPN_MN = txtPNModelName.Text;
                if (Regex.Replace(tempEquipmentNo, @"\s+", "") == "" && Regex.Replace(tempEquipmentName, @"\s+", "")  == "" || Regex.Replace(tempPN_MN, @"\s+", "") == "" && Regex.Replace(tempEquipmentName, @"\s+", "") == "")
                // if (tempEquipmentNo.Replace(" ","") == "" && tempEquipmentName.Replace(" ", "") == "" || tempPN_MN.Replace(" ", "") == "" && tempEquipmentName.Replace(" ", "") == "" && ExistingKmR1.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter EquipmentNo, EquipmentName and Plate No./Model Name ");
                }
                else
                {
                    reader = monitoring.ExecuteReader(spName, TruckType, EquipmentNo, Model, PlateNumber, fueltype, EngineNo, ChassisNo, Piston, Cylinder, Make, Series, BodyType, GrossWT, YearModel, PurchaseType, DateofPurchase, Supplier, CRno, MVFileno, ExistingKmR, MonthExpired, YearExpired, unitprice, HourlyRate, kmltr, userid);
                    DataTable result = new DataTable();
                    result.Load(reader);
                    string Result = result.Rows[0]["Result"].ToString();
                    string ServiceID = result.Rows[0]["ServiceID"].ToString();
                    if (Result == "0")
                    {
                        MessageBox.Show("Failed To Save..");
                    }
                    else if (Result == "1")
                    {
                        #region add tire and battery
                        /*
                        string EquipmentNoTB = txtEqpNo.Text;
                        string ModelTB = txtEqpName.Text;
                        string PlateNumberTB = txtPNModelName.Text;
                        string AllocationNo = "";
                        string Brand = "";
                        string SerialNo = "";

                        
                        string DateofPurchaseTB = dtpPurchase.Text;

                        int Tcount = dgvTire.Rows.Count;
                        int Tloop = Tcount - 1;

                        int Bcount = dgvBattery.Rows.Count;
                        int Bloop = Bcount - 1;

                        using (SqlConnection con = new SqlConnection(Connection))
                        {
                            con.Open();
                            //Tire
                            for (int i = 0; i < Tloop; i++)
                            {
                                AllocationNo = dgvTire.Rows[i].Cells[0].FormattedValue.ToString(); // dgvTire.Rows[i].Cells[0].FormattedValue.ToString());
                                Brand = dgvTire.Rows[i].Cells[1].FormattedValue.ToString();
                                SerialNo = dgvTire.Rows[i].Cells[2].FormattedValue.ToString();

                                using (SqlCommand cmdTire = new SqlCommand("sp_Add_EquipmentTire", con))
                                {
                                    cmdTire.CommandType = CommandType.StoredProcedure;

                                    cmdTire.Parameters.Add("@AllocationNo", SqlDbType.VarChar).Value = AllocationNo;
                                    cmdTire.Parameters.Add("@Brand", SqlDbType.VarChar).Value = Brand;
                                    cmdTire.Parameters.Add("@SerialNo", SqlDbType.VarChar).Value = SerialNo;
                                    cmdTire.Parameters.Add("@ServiceID", SqlDbType.VarChar).Value = ServiceID;
                                    cmdTire.Parameters.Add("@EquipmentNo", SqlDbType.Int).Value = EquipmentNoTB;
                                    cmdTire.Parameters.Add("@Model", SqlDbType.VarBinary).Value = ModelTB;
                                    cmdTire.Parameters.Add("@PlateNo", SqlDbType.VarChar).Value = PlateNumberTB;
                                    cmdTire.Parameters.Add("@DatePurchase", SqlDbType.VarChar).Value = DateofPurchaseTB;
                                    cmdTire.Parameters.Add("@userid", SqlDbType.VarChar).Value = userlogin;
                                    cmdTire.ExecuteNonQuery();
                                }
                            }

                            //Battery
                            for (int i = 0; i < Bloop; i++)
                            {
                                AllocationNo = dgvBattery.Rows[i].Cells[0].FormattedValue.ToString(); // dgvTire.Rows[i].Cells[0].FormattedValue.ToString());
                                Brand = dgvBattery.Rows[i].Cells[1].FormattedValue.ToString();
                                SerialNo = dgvBattery.Rows[i].Cells[2].FormattedValue.ToString();

                                using (SqlCommand cmdTire = new SqlCommand("sp_Add_EquipmentBattery", con))
                                {
                                    cmdTire.CommandType = CommandType.StoredProcedure;

                                    cmdTire.Parameters.Add("@AllocationNo", SqlDbType.VarChar).Value = AllocationNo;
                                    cmdTire.Parameters.Add("@Brand", SqlDbType.VarChar).Value = Brand;
                                    cmdTire.Parameters.Add("@SerialNo", SqlDbType.VarChar).Value = SerialNo;
                                    cmdTire.Parameters.Add("@ServiceID", SqlDbType.VarChar).Value = ServiceID;
                                    cmdTire.Parameters.Add("@EquipmentNo", SqlDbType.Int).Value = EquipmentNoTB;
                                    cmdTire.Parameters.Add("@Model", SqlDbType.VarBinary).Value = ModelTB;
                                    cmdTire.Parameters.Add("@PlateNo", SqlDbType.VarChar).Value = PlateNumberTB;
                                    cmdTire.Parameters.Add("@DatePurchase", SqlDbType.VarChar).Value = DateofPurchaseTB;
                                    cmdTire.Parameters.Add("@userid", SqlDbType.VarChar).Value = userlogin;
                                    cmdTire.ExecuteNonQuery();
                                }
                            }


                        }
                        */
                        #endregion

                        MessageBox.Show("Successfully Saved..");
                        txtEqpNo.Text = "";
                        txtEqpName.Text = "";
                        txtPNModelName.Text = "";
                        txtBodyType.Text = "";
                        txtChassisNo.Text = "";
                        txtCRNo.Text = "";
                        txtCylinder.Text = "";
                        txtEngineNo.Text = "";
                        txtExisting.Text = "0";
                        txtGrossWT.Text = "";
                        txtMake.Text = "";
                        txtMVFile.Text = "";
                        txtPiston.Text = "";
                        txtSeries.Text = "";
                        txtSupplier.Text = "";
                        txtUnitPrice.Text = "0";
                        txtYear.Text = "";
                        txtYearModel.Text = "";
                        //dgvBattery.Rows.Clear();
                        //dgvTire.Rows.Clear();
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
            /*
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSave_Click(btnSave, EventArgs.Empty);
            }
            */
        }
        

        private void cmbPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if(cmbPurchase.SelectedIndex == 1)
            {
                lblexisting.Visible = true;
                txtExisting.Visible = true;
                txtExisting.Text = "";
            }
            else
            {
                lblexisting.Visible = false;
                txtExisting.Visible = false;
                txtExisting.Text = "0";
            }
            */
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

        private void txtYear_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
            /*
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSave_Click(btnSave, EventArgs.Empty);
            }
            */
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            /*
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
            */
        }

    }
}
