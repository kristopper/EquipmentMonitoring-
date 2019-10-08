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
    public partial class UpdateExpenses : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        string ispurchase = "0";
        string isPartsCompleted = "0";
        string isStartRepair = "0";
        string IsRepairCompleted = "0";

        public string strEquipment { get; set; }
        public string strSolution { get; set; }
        public string strDriver { get; set; }
        public string strSite { get; set; }
        public string strremark { get; set; }
        public string strCategory { get; set; }
        public string strRepair { get; set; }
        public string strPStatus { get; set; }
        public string strRStatus { get; set; }
        public string strdate { get; set; }
        public int Cancel { get; set; }
        public string strItem { get; set; }
        public string strPcs { get; set; }
        public string strMechanic { get; set; }
        public string strMileage { get; set; }
        public string strUserID { get; set; }

        public UpdateExpenses()
        {
            InitializeComponent();
            CategoryParent();
            Cancel = 1;
        }

        private void CategoryParent()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from m_SubCategoryList with (nolock) where [Sub-Category] != 'ALL'  order by Category asc, id asc", Con);

                da.Fill(dt);
                
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "Sub-Category";
                cmbCategory.ValueMember = "Sub-Category";
                
            }
        }

        public void Param(string id, string Rstatus, string PStatus, DataTable dtProjectSite, AutoCompleteStringCollection EmployeeTextAll, string Userid)
        {

            strUserID = Userid;

            AutoCompleteStringCollection ProjectSite = new AutoCompleteStringCollection();
            AutoCompleteStringCollection Equipmeent = new AutoCompleteStringCollection();

            foreach (DataRow dr in dtProjectSite.Rows)
            {
                ProjectSite.Add(dr["ProjectNo"].ToString());
            }
            
            //employeeControl.txtSupervisor.AutoCompleteCustomSource = EmployeeText;
            txtDriver.AutoCompleteCustomSource = EmployeeTextAll;
            txtmechanic.AutoCompleteCustomSource = EmployeeTextAll;
            txtProjectSite.AutoCompleteCustomSource = ProjectSite;

            lblId.Text = id;
            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending' and Id = '"
            SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Id = '"
                 + id + "'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            txtEquipment.Text = dt.Rows[0]["EquipmentNo"].ToString();
            txtModel.Text = dt.Rows[0]["Model"].ToString();
            txtPlateNo.Text = dt.Rows[0]["PlateNo"].ToString();
            cmbCategory.Text = dt.Rows[0]["SubCategory"].ToString();
            dtDate.Text = dt.Rows[0]["Date"].ToString().Replace(" 12:00:00 AM", "");
            txtProjectSite.Text = dt.Rows[0]["ProjectNo"].ToString();
            txtDatePurchase.Text = dt.Rows[0]["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "");
            txtStartRepair.Text = dt.Rows[0]["StartRepairDate"].ToString().Replace(" 12:00:00 AM", "");
            txtDriver.Text = dt.Rows[0]["Driver"].ToString();
            txtPartsComplete.Text = dt.Rows[0]["PartsCompleted"].ToString().Replace(" 12:00:00 AM", "");
            txtRepairComplete.Text = dt.Rows[0]["RepairCompleted"].ToString().Replace(" 12:00:00 AM", "");
            txtProblem.Text = dt.Rows[0]["Problem"].ToString();
            txtDiagnosis.Text = dt.Rows[0]["Diagnosis"].ToString();
            txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();
            //(row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString())
            //txtPMS.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dt.Rows[0]["PMS"].ToString()));//dt.Rows[0]["PMS"].ToString();
            txtPMS.Text = (dt.Rows[0]["PMS"].ToString() == "0.0000" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(dt.Rows[0]["PMS"].ToString())));
            //txtRepair.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dt.Rows[0]["Repair"].ToString()));//dt.Rows[0]["Repair"].ToString();
            txtRepair.Text = (dt.Rows[0]["Repair"].ToString() == "0.0000" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(dt.Rows[0]["Repair"].ToString())));
            //txtTire.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dt.Rows[0]["Tire"].ToString()));//dt.Rows[0]["Tire"].ToString();
            txtTire.Text = (dt.Rows[0]["Tire"].ToString() == "0.0000" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(dt.Rows[0]["Tire"].ToString())));
            //(row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
            lblpurchase.Text = dt.Rows[0]["IsPurchase"].ToString();

            txtitem.Text = dt.Rows[0]["Item"].ToString();
            txtpcs.Text = dt.Rows[0]["Pcs"].ToString();
            txtmechanic.Text = dt.Rows[0]["Mechanic"].ToString();
            txtmileage.Text = dt.Rows[0]["Mileage"].ToString();

            strEquipment = (dt.Rows[0]["EquipmentNo"].ToString() == "" ? (dt.Rows[0]["Model"].ToString() == "" ? dt.Rows[0]["PlateNo"].ToString() : dt.Rows[0]["Model"].ToString()) : dt.Rows[0]["EquipmentNo"].ToString());
            strSolution = dt.Rows[0]["Diagnosis"].ToString();
            strDriver = dt.Rows[0]["Driver"].ToString();
            strSite = dt.Rows[0]["ProjectSite"].ToString();
            strremark = dt.Rows[0]["Remarks"].ToString();
            strCategory = dt.Rows[0]["SubCategory"].ToString();
            strRepair = txtRepair.Text;
            strdate = dt.Rows[0]["Date"].ToString().Replace(" 12:00:00 AM", "");
            strRStatus = Rstatus;
            strPStatus = PStatus;
            strItem = dt.Rows[0]["Item"].ToString();
            strPcs = dt.Rows[0]["Pcs"].ToString();
            strMechanic = dt.Rows[0]["Mechanic"].ToString();
            strMileage = dt.Rows[0]["Mileage"].ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue To Cancel", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Cancel = 1;
                this.Close();
            }
        }

        private void txtPMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPMS.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma))
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

        private void txtRepair_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRepair.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma))
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

        private void txtTire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTire.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma))
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

        private void txtDatePurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsDigit(e.KeyChar)
                     && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void txtStartRepair_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsDigit(e.KeyChar)
                     && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void txtPartsComplete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsDigit(e.KeyChar)
                     && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void txtRepairComplete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                     && !char.IsDigit(e.KeyChar)
                     && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

       
        private void txtPMS_TextChanged(object sender, EventArgs e)
        {
            string tempvalue = txtPMS.Text.Replace(",", "");
            string value = tempvalue + "." + "00";
            string[] strAmount = value.Split('.');

            try
            {

                int iKeep = txtPMS.SelectionStart - 1;

                for (int i = iKeep; i > 0; i--)

                    if (txtPMS.Text[i] == ',')

                        iKeep -= 1;


                txtPMS.Text = String.Format("{0:N0}", Convert.ToInt32(strAmount[0].Replace(",", ""))) + "." + strAmount[1];

                for (int i = 0; i < iKeep; i++)

                    if (txtPMS.Text[i] == ',')
                        iKeep += 1;

                txtPMS.SelectionStart = iKeep + 1;

            }

            catch
            {
            }
        }

        private void txtRepair_TextChanged(object sender, EventArgs e)
        {
            string tempvalue = txtRepair.Text.Replace(",", "");
            string value = tempvalue + "." + "00";
            string[] strAmount = value.Split('.');

            try
            {

                int iKeep = txtRepair.SelectionStart - 1;

                for (int i = iKeep; i > 0; i--)

                    if (txtRepair.Text[i] == ',')

                        iKeep -= 1;


                txtRepair.Text = String.Format("{0:N0}", Convert.ToInt32(strAmount[0].Replace(",", ""))) + "." + strAmount[1];

                for (int i = 0; i < iKeep; i++)

                    if (txtRepair.Text[i] == ',')
                        iKeep += 1;

                txtRepair.SelectionStart = iKeep + 1;

            }

            catch
            {
            }
        }

        private void txtTire_TextChanged(object sender, EventArgs e)
        {
            string tempvalue = txtTire.Text.Replace(",", "");
            string value = tempvalue + "." + "00";
            string[] strAmount = value.Split('.');

            try
            {

                int iKeep = txtTire.SelectionStart - 1;

                for (int i = iKeep; i > 0; i--)

                    if (txtTire.Text[i] == ',')

                        iKeep -= 1;


                txtTire.Text = String.Format("{0:N0}", Convert.ToInt32(strAmount[0].Replace(",", ""))) + "." + strAmount[1];

                for (int i = 0; i < iKeep; i++)

                    if (txtTire.Text[i] == ',')
                        iKeep += 1;

                txtTire.SelectionStart = iKeep + 1;

            }

            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue To Save", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = "";
                SqlDataReader reader;
                string id = "'" + lblId.Text + "'";
                string Date = "'" + dtDate.Text + "'";
                string category = "'" + cmbCategory.Text + "'";
                string ProjectSite = "'" + txtProjectSite.Text + "'";

                string Parampurchase = "'" + ispurchase + "'";
                string ParamPartsCompleted = "'" + isPartsCompleted + "'";
                string ParamStartRepair = "'" + isStartRepair + "'";
                string ParamRepairCompleted = "'" + IsRepairCompleted + "'";

                /*
                    string ispurchase = "0";
                    string isPartsCompleted = "0";
                    string isStartRepair = "0";
                    string IsRepairCompleted = "0";
                 */

                string DatePurchase = "";
                if (txtDatePurchase.Text.Replace(" ", "") == "")
                {
                    DatePurchase = "0";
                }
                else
                {
                    DatePurchase = "'" + txtDatePurchase.Text + "'";
                }

                string StartRepair = "";
                if (txtStartRepair.Text.Replace(" ", "") == "")
                {
                    StartRepair = "0";
                }
                else
                {
                    StartRepair = "'" + txtStartRepair.Text + "'";
                }

                string Driver = "'" + txtDriver.Text + "'";

                string PartsComplete = "";
                if (txtPartsComplete.Text.Replace(" ", "") == "")
                {
                    PartsComplete = "0";
                }
                else
                {
                    PartsComplete = "'" + txtPartsComplete.Text + "'";
                }

                string RepairComplete = "";
                if (txtRepairComplete.Text.Replace(" ", "") == "")
                {
                    RepairComplete = "0";
                }
                else
                {
                    RepairComplete = "'" + txtRepairComplete.Text + "'";
                }

                string Problem = "'" + txtProblem.Text + "'";
                string Diagnosis = "'" + txtDiagnosis.Text + "'";
                string Remarks = "'" + txtRemarks.Text + "'";
                string PMS = "";//"'" + txtPMS.Text + "'";

                string paramItem = "'" + txtitem.Text + "'";
                string paramPcs = "'" + txtpcs.Text + "'";
                string paramMileage = "'" + txtmileage.Text + "'";
                string paramMechanic = "'" + txtmechanic.Text + "'";

                if (txtPMS.Text.Replace(" ", "") == "")
                {
                    PMS = "0";
                }
                else
                {
                    PMS = "'" + txtPMS.Text.Replace(",", "") + "'";
                }
                string Repair = "";// = "'" + txtRepair.Text + "'";
                if (txtRepair.Text.Replace(" ", "") == "")
                {
                    Repair = "0";
                }
                else
                {
                    Repair = "'" + txtRepair.Text.Replace(",", "") + "'";
                }
                string Tire = "";//"'" + txtTire.Text + "'";
                if (txtTire.Text.Replace(" ", "") == "")
                {
                    Tire = "0";
                }
                else
                {
                    Tire = "'" + txtTire.Text.Replace(",","") + "'";
                }
                string spName = "sp_Update_Expenses";

                string userid = "'" + strUserID + "'";

                if (RepairComplete == "0")
                {
                    if (PartsComplete == "0")
                    {
                        reader = monitoring.ExecuteReader(spName, id, Date, category, ProjectSite, Driver, Problem, Diagnosis
                            , Remarks, PMS, Repair, Tire, DatePurchase, StartRepair, PartsComplete, RepairComplete, Parampurchase, ParamPartsCompleted, ParamStartRepair, ParamRepairCompleted, paramItem, paramPcs, paramMechanic, paramMileage, userid);
                        DataTable Detail = new DataTable();
                        Detail.Load(reader);
                        result = Detail.Rows[0]["Result"].ToString();

                        if (result == "1")
                        {
                            MessageBox.Show("Successfully Saved..");

                            Cancel = 0;
                            strEquipment = (txtEquipment.Text == "" ? (txtModel.Text == "" ? txtPlateNo.Text : txtModel.Text) : txtEquipment.Text);
                            strSolution = txtDiagnosis.Text;
                            strDriver = txtDriver.Text;
                            strSite = txtProjectSite.Text;
                            strremark = txtRemarks.Text;
                            strCategory = cmbCategory.Text;
                            strRepair = txtRepair.Text;
                            strdate = Date;
                            strRStatus = "Pending";

                            strItem = txtitem.Text;
                            strPcs = txtpcs.Text;
                            strMechanic = txtmechanic.Text;
                            strMileage = txtmileage.Text;

                            if (lblpurchase.Text == "0")
                            {
                                strPStatus = "N/A";
                            }
                            else
                            {
                                strPStatus = "Pending";
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed To Save..");
                        }
                    }
                    else
                    {
                        if(DatePurchase == "0")
                        {
                            MessageBox.Show("You Cannot Enter Parts Completed if the Date of Purchase is Empty!");
                        }
                        else
                        {
                            reader = monitoring.ExecuteReader(spName, id, Date, category, ProjectSite, Driver, Problem, Diagnosis
                                , Remarks, PMS, Repair, Tire, DatePurchase, StartRepair, PartsComplete, RepairComplete, Parampurchase, ParamPartsCompleted, ParamStartRepair, ParamRepairCompleted, paramItem, paramPcs, paramMechanic, paramMileage, userid);
                            DataTable Detail = new DataTable();
                            Detail.Load(reader);
                            result = Detail.Rows[0]["Result"].ToString();

                            if (result == "1")
                            {
                                Cancel = 0;
                                //(txtEquipment.Text == "" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(dt.Rows[0]["Tire"].ToString())));
                                strEquipment = (txtEquipment.Text == "" ? (txtModel.Text == "" ? txtPlateNo.Text : txtModel.Text) : txtEquipment.Text);
                                strSolution = txtDiagnosis.Text;
                                strDriver = txtDriver.Text;
                                strSite = txtProjectSite.Text;
                                strremark = txtRemarks.Text;
                                strCategory = cmbCategory.Text;
                                strRepair = txtRepair.Text;
                                strdate = Date;
                                strRStatus = "Pending";
                                strPStatus = "Completed on " + txtDatePurchase.Text;
                                strItem = txtitem.Text;
                                strPcs = txtpcs.Text;
                                strMechanic = txtmechanic.Text;
                                strMileage = txtmileage.Text;
                                MessageBox.Show("Successfully Saved..");

                                //Completed on 
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed To Save..");
                            }
                        }
  
                    }
                }
                else
                {
                    if (lblpurchase.Text == "0")
                    {
                        if (StartRepair == "0")
                        {
                            MessageBox.Show("You Cannot Enter Date on Repair Completed if the Start Date of Repair is Empty!");
                        }
                        else
                        {
                            if (PartsComplete == "0")
                            {
                                reader = monitoring.ExecuteReader(spName, id, Date, category, ProjectSite, Driver, Problem, Diagnosis
                                  , Remarks, PMS, Repair, Tire, DatePurchase, StartRepair, PartsComplete, RepairComplete, Parampurchase, ParamPartsCompleted, ParamStartRepair, ParamRepairCompleted, paramItem, paramPcs, paramMechanic, paramMileage, userid);
                                DataTable Detail = new DataTable();
                                Detail.Load(reader);
                                result = Detail.Rows[0]["Result"].ToString();

                                if (result == "1")
                                {
                                    Cancel = 0;
                                    MessageBox.Show("Successfully Saved..");
                                    strEquipment = (txtEquipment.Text == "" ? (txtModel.Text == "" ? txtPlateNo.Text : txtModel.Text) : txtEquipment.Text);
                                    strSolution = txtDiagnosis.Text;
                                    strDriver = txtDriver.Text;
                                    strSite = txtProjectSite.Text;
                                    strremark = txtRemarks.Text;
                                    strCategory = cmbCategory.Text;
                                    strRepair = txtRepair.Text;
                                    strdate = Date;
                                    strRStatus = "Completed on " + txtRepairComplete.Text;
                                    strPStatus = "N/A";
                                    strItem = txtitem.Text;
                                    strPcs = txtpcs.Text;
                                    strMechanic = txtmechanic.Text;
                                    strMileage = txtmileage.Text;
                                    /*
                                    if (ispurchase == "0")
                                    {
                                        strPStatus = "N/A";
                                    }
                                    else
                                    {
                                        strPStatus = "Pending";
                                    }
                                    */
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Failed To Save..");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Delete the Value of Parts Completed");
                            }
                        }
                    }
                    else
                    {
                        if (DatePurchase == "0")
                        {
                            MessageBox.Show("You Cannot Enter Date on Repair Completed if the Date of Purchase is Empty!");
                        }
                        else
                        {
                            if (PartsComplete == "0")
                            {
                                MessageBox.Show("You Cannot Enter Date on Repair Completed if the Parts Complete is Empty!");
                            }
                            else
                            {
                                reader = monitoring.ExecuteReader(spName, id, Date, category, ProjectSite, Driver, Problem, Diagnosis
                                  , Remarks, PMS, Repair, Tire, DatePurchase, StartRepair, PartsComplete, RepairComplete, Parampurchase, ParamPartsCompleted, ParamStartRepair, ParamRepairCompleted, paramItem, paramPcs, paramMechanic, paramMileage, userid);
                                DataTable Detail = new DataTable();
                                Detail.Load(reader);
                                result = Detail.Rows[0]["Result"].ToString();

                                if (result == "1")
                                {
                                    Cancel = 0;
                                    strEquipment = (txtEquipment.Text == "" ? (txtModel.Text == "" ? txtPlateNo.Text : txtModel.Text) : txtEquipment.Text);
                                    strSolution = txtDiagnosis.Text;
                                    strDriver = txtDriver.Text;
                                    strSite = txtProjectSite.Text;
                                    strremark = txtRemarks.Text;
                                    strCategory = cmbCategory.Text;
                                    strRepair = txtRepair.Text;
                                    strdate = Date;
                                    strRStatus = "Completed on " + txtRepairComplete.Text;
                                    strPStatus = "Completed on " + txtDatePurchase.Text;
                                    strItem = txtitem.Text;
                                    strPcs = txtpcs.Text;
                                    strMechanic = txtmechanic.Text;
                                    strMileage = txtmileage.Text;
                                    /*
                                    if (ispurchase == "0")
                                    {
                                        strPStatus = "N/A";
                                    }
                                    else
                                    {
                                        strPStatus = "Pending";
                                    }
                                    */
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Failed To Save..");
                                }
                            }
                        }
                    }

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue To DELETE", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = "";
                SqlDataReader reader;
                string id = "'" + lblId.Text + "'";
                string userid = "'" + strUserID + "'";

                string spName = "sp_Delete_Expenses";
                reader = monitoring.ExecuteReader(spName, id, userid);
                DataTable Detail = new DataTable();
                Detail.Load(reader);
                result = Detail.Rows[0]["Result"].ToString();

                if (result == "1")
                {
                    MessageBox.Show("Successfully Deleted..");
                }
                else
                {
                    MessageBox.Show("Failed To Delete..");
                }
             }
        }

        private void chkPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPurchase.Checked == true)
            {
                txtDatePurchase.ReadOnly = false;
                ispurchase = "1";
            }
            else
            {
                txtDatePurchase.ReadOnly = true;
                ispurchase = "0";
            }
        }

        private void chkpartComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpartComplete.Checked == true)
            {
                txtPartsComplete.ReadOnly = false;
                isPartsCompleted = "1";
            }
            else
            {
                txtPartsComplete.ReadOnly = true;
                isPartsCompleted = "0";
            }
        }

        private void chkRepairDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRepairDate.Checked == true)
            {
                txtStartRepair.ReadOnly = false;
                isStartRepair = "1";
            }
            else
            {
                txtRepairComplete.ReadOnly = true;
                isStartRepair = "0";
            }
        }

        private void chkRepairComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRepairComplete.Checked == true)
            {
                txtRepairComplete.ReadOnly = false;
                IsRepairCompleted = "1";
            }
            else
            {
                txtRepairComplete.ReadOnly = true;
                IsRepairCompleted = "0";
            }
        }


        //String.Format("{0:#,###.00}", Convert.ToDecimal(row["NoLiters"]))
    }
}
