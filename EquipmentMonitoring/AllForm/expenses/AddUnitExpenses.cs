using EquipmentMonitoring.Repository;
using System;
using System.Collections;
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

namespace EquipmentMonitoring.AllForm.expenses
{
    public partial class AddUnitExpenses : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();


        ArrayList EmployeeList = new ArrayList();
        ArrayList EquipArray = new ArrayList();
        ArrayList ProjectSiteArray = new ArrayList();

        //AutoCompleteStringCollection EmployeeText = new AutoCompleteStringCollection();
        //AutoCompleteStringCollection UnitList = new AutoCompleteStringCollection();

        string isItem = "0";
        string isBorrowItem = "0";
        string isStartRepair = "0";
        string IsRepairCompleted = "0";
        string IsForPMS = "0";


        public string UserID { get; set; }

        DataGridViewComboBoxColumn dgvcmdCategory = new DataGridViewComboBoxColumn();
        public AddUnitExpenses()
        {
            InitializeComponent();
            
            //employeeControl.cmbEmpSearchType.SelectedIndex = 0;
        }

        private void EmployeeNo(AutoCompleteStringCollection data)
        {
            foreach (var item in EmployeeList)
                data.AddRange(new string[] { item.ToString() });
        }

        private void EquipList(AutoCompleteStringCollection data)
        {
            foreach (var item in EquipArray)
                data.AddRange(new string[] { item.ToString() });
        }

        private void ProjectArrayList(AutoCompleteStringCollection data)
        {
            foreach (var item in ProjectSiteArray)
                data.AddRange(new string[] { item.ToString() });
        }



        public string ValidateDate(string Date)
        {
            Regex dateRegExp = new Regex("^(((0?[1-9]|[12]\\d|3[01])[\\.\\-\\/](0?[13578]|1[02])[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|((0?[1-9]|[12]\\d|30)[\\.\\-\\/](0?[13456789]|1[012])[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|((0?[1-9]|1\\d|2[0-8])[\\.\\-\\/]0?2[\\.\\-\\/]((1[6-9]|[2-9]\\d)?\\d{2}|\\d))|(29[\\.\\-\\/]0?2[\\.\\-\\/]((1[6-9]|[2-9]\\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00|[048])))$");
            string result = "false";

            Match m = dateRegExp.Match(Date);


            if (m.Success)
            {
                result = "true";
            }
            else
            {
                result = "false";
            }

            return result;
        }

        public void ClearField()
        {
            txtEquipment.Text = "";
            txtProjectSite.Text = "";
            txtDriver.Text = "";
            txtmileage.Text = "0";
            txtProblem.Text = "";
            txtDiagnosis.Text = "";
            txtStartRepair.Text = "";
            txtRepairComplete.Text = "";
            txtRemarks.Text = "";
            chkItem.Checked = false;
            chkBorrow.Checked = false;
            chkPMS.Checked = false;
            chkRepairDate.Checked = false;
            chkRepairComplete.Checked = false;

            dgvItem.DataSource = null;
            if (this.dgvItem.DataSource != null)
            {
                this.dgvItem.DataSource = null;
            }
            else
            {
                this.dgvItem.Rows.Clear();
            }

            dgvMechanic.DataSource = null;
            if (this.dgvMechanic.DataSource != null)
            {
                this.dgvMechanic.DataSource = null;
            }
            else
            {
                this.dgvMechanic.Rows.Clear();
            }

            dgvBorrowItem.DataSource = null;
            if (this.dgvBorrowItem.DataSource != null)
            {
                this.dgvBorrowItem.DataSource = null;
            }
            else
            {
                this.dgvBorrowItem.Rows.Clear();
            }


        }

        //public void Param(AutoCompleteStringCollection EmployeeTextAll, AutoCompleteStringCollection ContractIDAll, AutoCompleteStringCollection unitAll, DataTable CategoryAll)
        public void Param(ArrayList EmployeeTextAll, ArrayList ContractIDAll, ArrayList unitAll, DataTable CategoryAll, string username)
        {
            EmployeeList = EmployeeTextAll;
            EquipArray = unitAll;
            ProjectSiteArray = ContractIDAll;

            UserID = username;

            //EmployeeText = EmployeeTextAll;
            //UnitList = unitAll;



            AutoCompleteStringCollection EmployeeText = new AutoCompleteStringCollection();
            EmployeeNo(EmployeeText);

            AutoCompleteStringCollection ProjectList = new AutoCompleteStringCollection();
            ProjectArrayList(ProjectList);


            AutoCompleteStringCollection UnitListAll = new AutoCompleteStringCollection();
            EquipList(UnitListAll);


            txtDriver.AutoCompleteCustomSource = EmployeeText;
            txtProjectSite.AutoCompleteCustomSource = ProjectList;
            txtEquipment.AutoCompleteCustomSource = UnitListAll;

            dgvcmdCategory.HeaderText = "CATEGORY";
            dgvcmdCategory.Name = "Category";

            ArrayList row = new ArrayList();

            foreach (DataRow dr in CategoryAll.Rows)
            {
                row.Add(dr["Sub-Category"].ToString());
            }


            dgvcmdCategory.Items.AddRange(row.ToArray());
            dgvItem.Columns.Add(dgvcmdCategory);
            dgvItem.Columns[9].Width = 180;

            //dgvItem.Columns.Add(CategoryAll);
            //dgvItem.Columns[11].Width = 257;

        }

        private void dgvMechanic_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox auto = e.Control as TextBox;

            if (dgvMechanic.CurrentCell.ColumnIndex == 0)
            {
                try
                {
                    if (auto != null)
                    {
                        auto.AutoCompleteCustomSource.Clear();
                        auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                        auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        EmployeeNo(data);
                        auto.AutoCompleteCustomSource = data;
                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                }
                catch { }
            }
        }

        private void dgvBorrowItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox auto = e.Control as TextBox;

            if (dgvBorrowItem.CurrentCell.ColumnIndex == 0)
            {
                try
                {
                    if (auto != null)
                    {
                        auto.AutoCompleteCustomSource.Clear();
                        auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                        auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        EquipList(data);
                        //EquipList(data);
                        auto.AutoCompleteCustomSource = data;
                        //auto.AutoCompleteCustomSource = UnitList;
                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                }
                catch { }
            }
        }

        private void chkItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem.Checked == true)
            {
                dgvItem.Enabled = true;
                isItem = "1";
            }
            else
            {
                dgvItem.Enabled = false;
                isItem = "0";
            }
        }

        private void chkBorrow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBorrow.Checked == true)
            {
                dgvBorrowItem.Enabled = true;
                isBorrowItem = "1";
            }
            else
            {
                dgvBorrowItem.Enabled = false;
                isBorrowItem = "0";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select For Approval or Pending");
            }
            else
            {
                //MessageBox.Show(cmbStatus.SelectedItem.ToString());
                string Valid = "0";
                if (isStartRepair == "1")
                {
                    string result = ValidateDate(txtStartRepair.Text);
                    if (result == "true")
                    {
                        if (IsRepairCompleted == "1")
                        {

                            string isRepair = ValidateDate(txtStartRepair.Text);
                            if (isRepair == "true")
                            {
                                Valid = "0";
                            }
                            else
                            {
                                Valid = "2";
                            }
                        }
                        else
                        {
                            Valid = "0";
                        }
                    }
                    else
                    {
                        Valid = "1";
                    }
                }
                else
                {
                    if (IsRepairCompleted == "1")
                    {
                        Valid = "3";
                    }
                    else
                    {
                        Valid = "0";
                    }
                }

                if (Valid == "0")
                {

                    DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue", "Save", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string result = "";
                        string ExpID = "";
                        string ServiceID = "";
                        SqlDataReader reader;
                        string spName = "sp_Request_RepairAndMaintenance";
                        string Date = "'" + cmdDate.Text + "'";
                        string EquipmentNo = "'" + txtEquipment.Text + "'";
                        string Driver = "'" + txtDriver.Text + "'";
                        string ContractID = "'" + txtProjectSite.Text + "'";
                        string Mileage = "'" + txtmileage.Text + "'";
                        string Problem = "'" + txtProblem.Text + "'";
                        string Diagnosis = "'" + txtDiagnosis.Text + "'";
                        string Remarks = "'" + txtRemarks.Text + "'";
                        string IsStartR = "'" + isStartRepair + "'";
                        string StartDate = "'" + txtStartRepair.Text + "'";
                        string IsRepairC = "'" + IsRepairCompleted + "'";
                        string RepairComplete = "'" + txtRepairComplete.Text + "'";
                        string pIsForPMS = "'" + IsForPMS + "'";
                        string User = "'" + UserID + "'";
                        string statuscode = "'" + cmbStatus.SelectedItem.ToString() + "'";

                        reader = monitoring.ExecuteReader(spName, EquipmentNo, ContractID, Driver, Mileage, Date, Problem, Diagnosis, Remarks, IsStartR, StartDate, IsRepairC, RepairComplete, pIsForPMS, User, statuscode);
                        DataTable Detail = new DataTable();
                        Detail.Load(reader);
                        result = Detail.Rows[0]["Result"].ToString();
                        ExpID = Detail.Rows[0]["ExpID"].ToString();
                        ServiceID = Detail.Rows[0]["ServiceID"].ToString();

                        //string pExpID = "'" + ExpID + "'";
                        //string pServiceID = "'" + ServiceID + "'";

                        if (result == "1")
                        {

                            string RequestDate = cmdDate.Text;

                            //add MEchanic and Electrician
                            int Mcount = dgvMechanic.Rows.Count;
                            if (Mcount > 0)
                            {

                                using (SqlConnection con = new SqlConnection(Connection))
                                {
                                    int mloop = Mcount - 1;
                                    con.Open();

                                    string MEName = "";

                                    for (int i = 0; i < mloop; i++)
                                    {
                                        if (Convert.ToString(dgvMechanic.Rows[i].Cells[0].FormattedValue) != string.Empty)
                                        {
                                            MEName = dgvMechanic.Rows[i].Cells[0].FormattedValue.ToString();
                                        }
                                        else
                                        {
                                            MEName = "";
                                        }

                                        string trim = Regex.Replace(MEName, @"s", "");

                                        if (trim != "" | trim != "''")
                                        {
                                            using (SqlCommand cmdItem = new SqlCommand("sp_Request_RepairME", con))
                                            {
                                                cmdItem.CommandType = CommandType.StoredProcedure;

                                                cmdItem.Parameters.Add("@Mechanic", SqlDbType.VarChar).Value = MEName;
                                                cmdItem.Parameters.Add("@ExpID", SqlDbType.VarChar).Value = ExpID;
                                                cmdItem.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                                                cmdItem.ExecuteNonQuery();
                                            }
                                        }


                                    }
                                }
                            }


                            //add Item
                            if (isItem == "1")
                            {
                                //string pExpID = ExpID;
                                //string pServiceID = ServiceID;

                                int Icount = dgvItem.Rows.Count;
                                if (Icount > 0)
                                {
                                    using (SqlConnection con = new SqlConnection(Connection))
                                    {
                                        int Iloop = Icount - 1;
                                        con.Open();

                                        string pqty = "";
                                        string pitem = "";
                                        string pIsPurchase = "0";
                                        string pPMS = "";
                                        string pRepair = "";
                                        string pTire = "";
                                        string pPartsNo = "";
                                        string pSerialNo = "";
                                        string pAllocationNo = "";
                                        //string pCategory = "";
                                        string CategoryL = "";
                                        //Item


                                        //  DriversName = "'" + dgvExpenses.Rows[i].Cells[7].FormattedValue.ToString().Replace(",", "") + "'";

                                        for (int i = 0; i < Iloop; i++)
                                        {

                                            if (Convert.ToString(dgvItem.Rows[i].Cells[0].FormattedValue) != string.Empty)
                                            {
                                                pqty = dgvItem.Rows[i].Cells[0].FormattedValue.ToString();
                                            }
                                            else
                                            {
                                                pqty = "0";
                                            }

                                            if (Convert.ToString(dgvItem.Rows[i].Cells[1].FormattedValue) != string.Empty)
                                            {
                                                pitem = dgvItem.Rows[i].Cells[1].FormattedValue.ToString();
                                            }


                                            pIsPurchase = "1";

                                            //if (Convert.ToString(dgvItem.Rows[i].Cells["Purchase"].Value) == "1")
                                            //// if (Convert.ToBoolean(dgvExpenses.Rows[i].Cells[7].Value) == true)
                                            //{
                                            //    pIsPurchase = "1";
                                            //}
                                            //else
                                            //{
                                            //    pIsPurchase = "0";
                                            //}



                                            if (Convert.ToString(dgvItem.Rows[i].Cells[3].FormattedValue) != string.Empty)
                                            {
                                                pPMS = dgvItem.Rows[i].Cells[3].FormattedValue.ToString();
                                            }
                                            else
                                            {
                                                pPMS = "0";
                                            }

                                            if (Convert.ToString(dgvItem.Rows[i].Cells[4].FormattedValue) != string.Empty)
                                            {
                                                pRepair = dgvItem.Rows[i].Cells[4].FormattedValue.ToString();
                                            }
                                            else
                                            {
                                                pRepair = "0";
                                            }

                                            if (Convert.ToString(dgvItem.Rows[i].Cells[5].FormattedValue) != string.Empty)
                                            {
                                                pTire = dgvItem.Rows[i].Cells[5].FormattedValue.ToString();
                                            }
                                            else
                                            {
                                                pTire = "0";
                                            }



                                            if (Convert.ToString(dgvItem.Rows[i].Cells[6].FormattedValue) != string.Empty)
                                            {
                                                pPartsNo = dgvItem.Rows[i].Cells[6].FormattedValue.ToString();
                                            }



                                            if (Convert.ToString(dgvItem.Rows[i].Cells[7].FormattedValue) != string.Empty)
                                            {
                                                pSerialNo = dgvItem.Rows[i].Cells[7].FormattedValue.ToString();
                                            }

                                            if (Convert.ToString(dgvItem.Rows[i].Cells[8].FormattedValue) != string.Empty)
                                            {
                                                pAllocationNo = dgvItem.Rows[i].Cells[8].FormattedValue.ToString();
                                            }
                                            else
                                            {
                                                pAllocationNo = "0";
                                            }

                                            if (Convert.ToString(dgvItem.Rows[i].Cells[9].FormattedValue) != string.Empty)
                                            {
                                                CategoryL = dgvItem.Rows[i].Cells[9].FormattedValue.ToString();
                                            }
                                            else
                                            {
                                                CategoryL = "0";
                                            }

                                            if (CategoryL == "0")
                                            {
                                                MessageBox.Show("Please Select Category");
                                            }
                                            else
                                            {
                                                string trim = Regex.Replace(pitem, @"s", "");
                                                if (trim != "")
                                                {
                                                    using (SqlCommand cmdItem = new SqlCommand("sp_Request_RepairItem", con))
                                                    {
                                                        cmdItem.CommandType = CommandType.StoredProcedure;

                                                        cmdItem.Parameters.Add("@ExpId", SqlDbType.VarChar).Value = ExpID;
                                                        cmdItem.Parameters.Add("@Date", SqlDbType.VarChar).Value = RequestDate;
                                                        cmdItem.Parameters.Add("@ServiceID", SqlDbType.VarChar).Value = ServiceID;
                                                        cmdItem.Parameters.Add("@quality", SqlDbType.VarChar).Value = pqty;
                                                        cmdItem.Parameters.Add("@Item", SqlDbType.VarChar).Value = pitem;
                                                        cmdItem.Parameters.Add("@IsPurchase", SqlDbType.VarChar).Value = pIsPurchase;
                                                        cmdItem.Parameters.Add("@PMS", SqlDbType.VarChar).Value = pPMS;
                                                        cmdItem.Parameters.Add("@Repair", SqlDbType.VarChar).Value = pRepair;
                                                        cmdItem.Parameters.Add("@Tire", SqlDbType.VarChar).Value = pTire;
                                                        cmdItem.Parameters.Add("@PartsNo", SqlDbType.VarChar).Value = pPartsNo;
                                                        cmdItem.Parameters.Add("@SerialNo", SqlDbType.VarChar).Value = pSerialNo;
                                                        cmdItem.Parameters.Add("@allocationNo", SqlDbType.VarChar).Value = pAllocationNo;
                                                        cmdItem.Parameters.Add("@SubCategory", SqlDbType.VarChar).Value = CategoryL;
                                                        cmdItem.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                                                        cmdItem.ExecuteNonQuery();
                                                    }
                                                }
                                            }


                                        }

                                    }
                                }

                            }

                            //add Borrow
                            if (isBorrowItem == "1")
                            {
                                //string pExpID = ExpID;
                                //string pServiceID = ServiceID;

                                int Icount = dgvBorrowItem.Rows.Count;
                                if (Icount > 0)
                                {
                                    using (SqlConnection con = new SqlConnection(Connection))
                                    {
                                        int Iloop = Icount - 1;
                                        con.Open();

                                        string pqty = "";
                                        string pitem = "";
                                        string pEquipmentNo = "";
                                        string pPartsNo = "";
                                        string pSerialNo = "";
                                        string pAllocationNo = "";
                                        //Item


                                        //  DriversName = "'" + dgvExpenses.Rows[i].Cells[7].FormattedValue.ToString().Replace(",", "") + "'";

                                        for (int i = 0; i < Iloop; i++)
                                        {

                                            if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[0].FormattedValue) != string.Empty)
                                            {
                                                pEquipmentNo = dgvBorrowItem.Rows[i].Cells[0].FormattedValue.ToString();
                                            }


                                            if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[1].FormattedValue) != string.Empty)
                                            {
                                                pqty = dgvBorrowItem.Rows[i].Cells[1].FormattedValue.ToString();
                                            }
                                            else
                                            {
                                                pqty = "0";
                                            }

                                            if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[2].FormattedValue) != string.Empty)
                                            {
                                                pitem = dgvBorrowItem.Rows[i].Cells[2].FormattedValue.ToString();
                                            }


                                            if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[3].FormattedValue) != string.Empty)
                                            {
                                                pPartsNo = dgvBorrowItem.Rows[i].Cells[3].FormattedValue.ToString();
                                            }



                                            if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[4].FormattedValue) != string.Empty)
                                            {
                                                pSerialNo = dgvBorrowItem.Rows[i].Cells[4].FormattedValue.ToString();
                                            }

                                            if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[5].FormattedValue) != string.Empty)
                                            {
                                                pAllocationNo = dgvBorrowItem.Rows[i].Cells[5].FormattedValue.ToString();
                                            }
                                            else
                                            {
                                                pAllocationNo = "0";
                                            }

                                            using (SqlCommand cmdItem = new SqlCommand("sp_Request_RepairBorrow", con))
                                            {
                                                cmdItem.CommandType = CommandType.StoredProcedure;

                                                cmdItem.Parameters.Add("@ExpId", SqlDbType.VarChar).Value = ExpID;
                                                cmdItem.Parameters.Add("@ServiceID", SqlDbType.VarChar).Value = ServiceID;
                                                cmdItem.Parameters.Add("@Equipno", SqlDbType.VarChar).Value = pEquipmentNo;
                                                cmdItem.Parameters.Add("@quality", SqlDbType.VarChar).Value = pqty;
                                                cmdItem.Parameters.Add("@Item", SqlDbType.VarChar).Value = pitem;
                                                cmdItem.Parameters.Add("@PartsNo", SqlDbType.VarChar).Value = pPartsNo;
                                                cmdItem.Parameters.Add("@SerialNo", SqlDbType.VarChar).Value = pSerialNo;
                                                cmdItem.Parameters.Add("@allocationNo", SqlDbType.VarChar).Value = pAllocationNo;
                                                cmdItem.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                                                cmdItem.ExecuteNonQuery();
                                            }
                                        }

                                    }
                                }

                            }

                        }

                        MessageBox.Show("Successfully Save");
                    }

                    ////
                }
                else if (Valid == "1")
                {
                    MessageBox.Show("Start of Repair Date Not Valid");
                }
                else if (Valid == "2")
                {
                    MessageBox.Show("Repair Completed Date Not Valid");
                }
                else if (Valid == "3")
                {
                    MessageBox.Show("Cannot Save Empty Start of Repair");
                }
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

        private void chkPMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRepairComplete.Checked == true)
            {
                IsForPMS = "1";
            }
            else
            {
                IsForPMS = "0";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
