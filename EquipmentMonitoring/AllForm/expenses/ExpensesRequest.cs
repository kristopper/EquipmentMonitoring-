using EquipmentMonitoring.ForReportForm.Forms;
using EquipmentMonitoring.Libs;
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
    public partial class ExpensesRequest : Form
    {
        string SExpID;
        string UserRole;
        string SUserID;
        string SServiceID;
        DataTable SCategory = new DataTable();


        string IsUpdatePMS = "0";
        string IsRepairUpdate = "0";
        string IsRepairComplete = "0";

        AutoCompleteStringCollection ProjectSite = new AutoCompleteStringCollection();
        AutoCompleteStringCollection Employee = new AutoCompleteStringCollection();
        DataTable SProjectSite;

        GenericFunctions GenericFunc = new GenericFunctions();
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();


        ArrayList EquipArray = new ArrayList();

        public ExpensesRequest()
        {
            InitializeComponent();
        }

        //public void Param(string pEquipno, string pModel, string pPlateno, string pMileage, string pDriver,
        //    string pContractID, string pProjectSite, string pDate, string pIsPMS, string pProblem,
        //    string pSolution, string pRemarks, string pRepairStart, string pRepairComplete, string pStatusCode)



        public void GetItem()
        {
            string result;
            string strSQL = "exec sp_Get_RepairAndMaintenanceItem" + " '" + SExpID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            //DataTable data = new DataTable();
            //DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);
            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, strSQL);

            int results = dsKey.Tables[0].Rows.Count;
            //if (readesr.Read())
            //{
            //    result = readesr["Name"].ToString();
            //    //strUsrBranch = reader["Branch"].ToString();
            //}

            if (results > 0)
            {
                dgvRItem.DataSource = null;

                if (this.dgvRItem.DataSource != null)
                {
                    this.dgvRItem.DataSource = null;
                }
                else
                {
                    this.dgvRItem.Rows.Clear();
                }


                foreach (DataRow row in dsKey.Tables[0].Rows)
                {
                    dgvRItem.Rows.Add(row["SourceID"].ToString()
                             , "false"
                             , row["Qty"].ToString()
                             , row["Item"].ToString()
                             , String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]))//row["PMS"].ToString()
                             , String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                             , String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                             , row["PartsNo"].ToString()
                             , row["SerialNo"].ToString()
                             , row["ReferenceNo"].ToString()
                             , row["Approval"].ToString()
                             , row["Remark"].ToString()
                             //, ""//remarks
                             , row["AllocationNo"].ToString()
                             , row["Category"].ToString()
                             , row["SubCategory"].ToString()
                             , row["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "")
                             , row["DateCompleted"].ToString().Replace(" 12:00:00 AM", "")
                             , row["Source"].ToString()
                             //, row["REStatus"].ToString()
                  );
                }
            }

            foreach (DataRow row in dsKey.Tables[1].Rows)
            {
                lblStatus.Text = row["REStatus"].ToString(); 
            }
        }


        public void GetRepairME()
        {
            string result;
            string strSQL = "exec sp_Get_RepairME" + " '" + SExpID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            //DataTable data = new DataTable();
            //DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);
            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, strSQL);

            int results = dsKey.Tables[0].Rows.Count;
            //if (readesr.Read())
            //{
            //    result = readesr["Name"].ToString();
            //    //strUsrBranch = reader["Branch"].ToString();
            //}

            if(results > 0)
            {

                dgvMechanic.DataSource = null;

                if (this.dgvMechanic.DataSource != null)
                {
                    this.dgvMechanic.DataSource = null;
                }
                else
                {
                    this.dgvMechanic.Rows.Clear();
                }


                foreach (DataRow row in dsKey.Tables[0].Rows)
                {
                    dgvMechanic.Rows.Add(row["MechanicID"].ToString()
                             , row["IsComplete"].ToString()
                             , row["Name"].ToString()
                  );

                }
            }
        }


        public void GetBorrowItem()
        {
            string result;
            string strSQL = "exec sp_Get_BorrowItem" + " '" + SExpID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            //DataTable data = new DataTable();
            //DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);
            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, strSQL);

            int results = dsKey.Tables[0].Rows.Count;
            //if (readesr.Read())
            //{
            //    result = readesr["Name"].ToString();
            //    //strUsrBranch = reader["Branch"].ToString();
            //}

            if (results > 0)
            {

                dgvRBorrowItem.DataSource = null;

                if (this.dgvRBorrowItem.DataSource != null)
                {
                    this.dgvRBorrowItem.DataSource = null;
                }
                else
                {
                    this.dgvRBorrowItem.Rows.Clear();
                }

                foreach (DataRow row in dsKey.Tables[0].Rows)
                {
                    dgvRBorrowItem.Rows.Add(row["BorrowID"].ToString()
                             , row["DateBorrow"].ToString().Replace(" 12:00:00 AM", "")
                             , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                             , row["Qty"].ToString()
                             , row["Item"].ToString()
                             , row["PartsNo"].ToString()
                             , row["SerialNo"].ToString()
                             , row["AllocationNo"].ToString()
                             , row["BorrowApproval"].ToString()
                             , row["Remark"].ToString()
                             , row["ReturnApproval"].ToString()
                             , row["DateReturn"].ToString().Replace(" 12:00:00 AM", "")
                             , (UserRole == "0" ? (row["ReturnApproval"].ToString() != "PENDING" ? "Returned" : "Return") : (row["ReturnApproval"].ToString() != "PENDING" ? "Acknowledge" : "Return"))
                  //, (UserRole == "0" ? (row["ReturnApproval"].ToString() == "Return" ? "Returned" : "Return") : "Acknowledge")
                  //(row["ReturnApproval"].ToString() == "Return" ? "Returned" : "Acknowledge") //(UserRole == "0" ? "Return" : "Acknowledge")
                  //, (case when UserRole = "0" then "Return" else "Acknoledge" end)
                  );
                }
            }
        }

        public void Param(string ExpID, string pUserRole, DataTable dtProjectSite, AutoCompleteStringCollection EmployeeTextAll, string pUserId, DataTable CategoryAll, ArrayList unitAll)
        {

            SCategory.Clear();
            SUserID = pUserId;
            string StatusCode = "1";
            SExpID = ExpID;
            UserRole = pUserRole;

            EquipArray = unitAll;

            SCategory = CategoryAll;

            SProjectSite = dtProjectSite;

            foreach (DataRow dr in dtProjectSite.Rows)
            {
                ProjectSite.Add(dr["ProjectNo"].ToString());
            }
            Employee = EmployeeTextAll;
            //employeeControl.txtSupervisor.AutoCompleteCustomSource = EmployeeText;
            txtDriver.AutoCompleteCustomSource = EmployeeTextAll;
            txtContractID.AutoCompleteCustomSource = ProjectSite;

            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_RepairAndMaintenanceInfo '" + ExpID + "'"));

            int m_RepairAndMaintenance = dsKey.Tables[0].Rows.Count;
            int m_RepairME = dsKey.Tables[1].Rows.Count;
            int vw_ItemExpenses = dsKey.Tables[2].Rows.Count;
            int m_BorrowItems = dsKey.Tables[3].Rows.Count;

            if (m_RepairAndMaintenance > 0)
            {
                foreach (DataRow row in dsKey.Tables[0].Rows)
                {

                    //row["Model"].ToString()
                    txtEquipment.Text = row["EquipmentNo"].ToString();
                    txtModel.Text = row["Model"].ToString();
                    txtPlateNo.Text = row["PlateNo"].ToString();
                    txtmileage.Text = row["Mileage"].ToString();
                    txtDriver.Text = row["Driver"].ToString();
                    txtContractID.Text = row["ProjectNo"].ToString();
                    txtProjectSite.Text = row["ProjectSite"].ToString();
                    dtDate.Text = row["Date"].ToString().Replace(" 12:00:00 AM", "");

                    txtProblem.Text = row["Problem"].ToString();
                    txtDiagnosis.Text = row["Diagnosis"].ToString();
                    txtRemarks.Text = row["Remarks"].ToString();
                    txtStartRepair.Text = row["StartRepairDate"].ToString().Replace(" 12:00:00 AM", "");
                    txtRepairComplete.Text = row["RepairCompleted"].ToString().Replace(" 12:00:00 AM", "");
                    lblExpId.Text = row["ExpID"].ToString();
                    StatusCode = row["StatusCode"].ToString();
                    SServiceID = row["ServiceID"].ToString();

                    string Pms = row["IsPMS"].ToString();
                    if(Pms == "False")
                    {
                        chkPMS.Checked = false;
                    }
                    else
                    {
                        chkPMS.Checked = true;
                    }

                    lblStatus.Text = row["REStatus"].ToString();
                }
            }


            //GetRepairME();
            if (m_RepairME > 0)
            {

                dgvMechanic.DataSource = null;

                if (this.dgvMechanic.DataSource != null)
                {
                    this.dgvMechanic.DataSource = null;
                }
                else
                {
                    this.dgvMechanic.Rows.Clear();
                }

                foreach (DataRow row in dsKey.Tables[1].Rows)
                {
                    dgvMechanic.Rows.Add(row["MechanicID"].ToString()
                             , row["IsComplete"].ToString()
                             , row["Name"].ToString()
                  );
                }
            }

            if (vw_ItemExpenses > 0)
            {

                dgvRItem.DataSource = null;

                if (this.dgvRItem.DataSource != null)
                {
                    this.dgvRItem.DataSource = null;
                }
                else
                {
                    this.dgvRItem.Rows.Clear();
                }


                foreach (DataRow row in dsKey.Tables[2].Rows)
                {
                    dgvRItem.Rows.Add(row["SourceID"].ToString()
                             , "false"
                             , row["Qty"].ToString()
                             , row["Item"].ToString()
                             , String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]))//row["PMS"].ToString()
                             , String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                             , String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                             , row["PartsNo"].ToString()
                             , row["SerialNo"].ToString()
                             , row["ReferenceNo"].ToString()
                             , row["Approval"].ToString()
                             , row["Remark"].ToString()
                             , row["AllocationNo"].ToString()
                             , row["Category"].ToString()
                             , row["SubCategory"].ToString()
                             , row["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "")
                             , row["DateCompleted"].ToString().Replace(" 12:00:00 AM", "")
                             , row["Source"].ToString()

                  );
                }
            }


            if (m_BorrowItems > 0)
            {

                dgvRBorrowItem.DataSource = null;

                if (this.dgvRBorrowItem.DataSource != null)
                {
                    this.dgvRBorrowItem.DataSource = null;
                }
                else
                {
                    this.dgvRBorrowItem.Rows.Clear();
                }

                foreach (DataRow row in dsKey.Tables[3].Rows)
                {
                    dgvRBorrowItem.Rows.Add(row["BorrowID"].ToString()
                             , row["DateBorrow"].ToString().Replace(" 12:00:00 AM", "")
                             , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                             , row["Qty"].ToString()
                             , row["Item"].ToString()
                             , row["PartsNo"].ToString()
                             , row["SerialNo"].ToString()
                             , row["AllocationNo"].ToString()
                             , row["BorrowApproval"].ToString()
                             , row["Remark"].ToString()
                             , row["ReturnApproval"].ToString()
                             , row["DateReturn"].ToString().Replace(" 12:00:00 AM", "")
                             , (UserRole == "0" ? (row["ReturnApproval"].ToString() != "PENDING" ? "Returned" : "Return") : (row["ReturnApproval"].ToString() != "PENDING" ? "Acknowledge" : "Return"))
                             //, (UserRole == "0" ? (row["ReturnApproval"].ToString() == "Return" ? "Returned" : "Return") : "Acknowledge")
                  //(row["ReturnApproval"].ToString() == "Return" ? "Returned" : "Acknowledge") //(UserRole == "0" ? "Return" : "Acknowledge")
                  //, (case when UserRole = "0" then "Return" else "Acknoledge" end)
                  );
                }
            }


            if (UserRole == "1" | UserRole == "2")
            {
                dgvRItem.Columns[10].ReadOnly = false;
                dgvRItem.Columns[11].ReadOnly = false;

                dgvRBorrowItem.Columns[8].ReadOnly = false;
                dgvRBorrowItem.Columns[9].ReadOnly = false;

                btnBorrowApprove.Visible = false;
                btnApproveItem.Visible = false;
                btnAllAcknowledge.Visible = false;
                if (StatusCode == "1")
                {

                    //btnAddItem.Visible = true;
                    //btnAllAcknowledge.Visible = true;
                    //chkForApproval.Visible = false;
                    //btnAddBorrowItem.Visible = true;
                }
                else if (StatusCode == "0")
                {
                    //btnAddItem.Visible = true;
                    //btnAllAcknowledge.Visible = true;
                    chkForApproval.Visible = true;
                }
                else
                {   
                    //btnAddItem.Visible = false;
                    chkForApproval.Visible = false;

                    //btnAddBorrowItem.Visible = false;
                }
            }
            else
            {

                dgvRItem.Columns[11].ReadOnly = true;
                dgvRItem.Columns[10].ReadOnly = true;

                dgvRBorrowItem.Columns[8].ReadOnly = true;
                dgvRBorrowItem.Columns[9].ReadOnly = true;
                btnSaveItem.Visible = false;
                //btnAllApprove.Visible = false;
                btnBorrowApprove.Visible = false;
                btnBorrowSave.Visible = false;
                btnApproveItem.Visible = false;
                btnAllAcknowledge.Visible = false;
                if (StatusCode == "1")
                {
                    //btnAddItem.Visible = true;
                    chkForApproval.Visible = false;
                }
                else if (StatusCode == "0")
                {
                    //btnAddItem.Visible = true;
                    chkForApproval.Visible = true;
                }
                else
                {
                    chkForApproval.Visible = false;
                    //btnAddItem.Visible = false;
                }
            }
            //txtEquipment.Text = pEquipno;
            //txtModel.Text = pModel;
            //txtPlateNo.Text = pPlateno;
            //txtmileage.Text = pMileage;
            //txtDriver.Text = pDriver;
            //txtContractID.Text = pContractID;
            //txtProjectSite.Text = pProjectSite;
            //dtDate.Text = pDate;

            //txtProblem.Text = pProblem;
            //txtDiagnosis.Text = pSolution;
            //txtRemarks.Text = pRemarks;
            //txtStartRepair.Text = pSolution;
            //txtRepairComplete.Text = pRemarks;

        }

        private void BtnAddMechanic_Click(object sender, EventArgs e)
        {
            AddExpensesME addME = new AddExpensesME();
            addME.Param(Employee, SExpID, SUserID);
            addME.ShowDialog();
            if (addME.IsCancel == "0")
            {
                GetRepairME();
            }

        }

        private void dgvMechanic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RepairMeRemarks remarks = new RepairMeRemarks();
            //string pMechanicID, string pMechanicName, string pExpID, string pUserID
            remarks.Param(dgvMechanic[0, e.RowIndex].Value.ToString(), dgvMechanic[1, e.RowIndex].Value.ToString(), SExpID, SUserID);
            remarks.ShowDialog();
        }

        //private void dgvRItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    AddItemExpenses additem = new AddItemExpenses();
        //    additem.Param(SExpID, SUserID, SCategory);
        //    additem.ShowDialog();
        //}

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            string sDate = dtDate.Text;
            
            AddItemExpenses additem = new AddItemExpenses();
            additem.Param(SExpID, SUserID, SCategory, SServiceID, sDate);
            additem.ShowDialog();

            if (additem.IsCancel == "0")
            {
                GetItem();
            }
        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            string sDate = dtDate.Text;
            UpdateItemExpenses updateitem = new UpdateItemExpenses();
            updateitem.Param(SExpID, SUserID, SCategory, SServiceID, sDate);
            updateitem.ShowDialog();
         
            if (updateitem.IsCancel == "0")
            {
                GetItem();
            }

        }

        private void BtnApproveItem_Click(object sender, EventArgs e)
        {
            string result = "0";
            string strSQL = "exec sp_RAM_AllItemApprove" + " '" +  SExpID + "','" + SUserID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            DataTable data = new DataTable();
            DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

            if (readesr.Read())
            {
                result = readesr["Result"].ToString();
                //strUsrBranch = reader["Branch"].ToString();
            }


            if (result == "1")
            {
                GetItem();
                btnAddItem.Visible = false;
                MessageBox.Show("Successfully Save");
            }
            else
            {
                MessageBox.Show("Failed to Save");
            }
        }

        private void BtnReturnAll_Click(object sender, EventArgs e)
        {
            string result = "0";
            string strSQL = "exec sp_RAM_AllItemBorrowReturn" + " '" + SExpID + "','" + SUserID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            DataTable data = new DataTable();
            DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

            if (readesr.Read())
            {
                result = readesr["Result"].ToString();
                //strUsrBranch = reader["Branch"].ToString();
            }


            if (result == "1")
            {
                MessageBox.Show("Successfully Returned");
                GetBorrowItem();
            }
            else
            {
                MessageBox.Show("Failed to Return");
            }
        }

        private void BtnBorrowApprove_Click(object sender, EventArgs e)
        {
            string result = "0";
            string strSQL = "exec sp_RAM_AllItemBorrowApprove" + " '" + SExpID + "','" + SUserID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            DataTable data = new DataTable();
            DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

            if (readesr.Read())
            {
                result = readesr["Result"].ToString();
                //strUsrBranch = reader["Branch"].ToString();
            }


            if (result == "1")
            {
                MessageBox.Show("Successfully Approved");
                GetBorrowItem();
            }
            else
            {
                MessageBox.Show("Failed to Save");
            }

        }

        private void BtnAllAcknowledge_Click(object sender, EventArgs e)
        {
            string result = "0";
            string strSQL = "exec sp_RAM_AllItemApproveBorrowReturn" + " '" + SExpID + "','" + SUserID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            DataTable data = new DataTable();
            DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

            if (readesr.Read())
            {
                result = readesr["Result"].ToString();
                //strUsrBranch = reader["Branch"].ToString();
            }


            if (result == "1")
            {
                MessageBox.Show("Successfully Acknowledged item Borrow Return");
                GetBorrowItem();
            }
            else
            {
                MessageBox.Show("Failed to Acknowledge item Borrow Return");
            }
        }

        private void dgvRBorrowItem__CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == 12)
                    {
                        // , (UserRole == "0" ? (row["ReturnApproval"].ToString() != "PENDING" ? "Returned" : "Return") : (row["ReturnApproval"].ToString() != "PENDING" ? "Acknowledge" : "Return"))
                        string buttontext = dgvRBorrowItem.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
                        
                        if(buttontext == "Returned")
                        {
                            MessageBox.Show("You Already Return the Item");
                        }
                        else if (buttontext == "Return")
                        {
                            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Return", "Return", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                SqlDataReader reader;
                                string Userid = "'" + SUserID + "'";
                                string ExpID = "'" + SExpID + "'";
                                string id = "'" + dgvRBorrowItem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() + "'";
                                string spName = "sp_RAM_ItemBorrowReturn";

                                reader = monitoring.ExecuteReader(spName, ExpID, id, Userid);
                                DataTable result = new DataTable();
                                result.Load(reader);
                                string Result = result.Rows[0]["Result"].ToString();
                                if (Result == "1")
                                {
                                    MessageBox.Show("Successfully Borrow Return..");
                                    GetBorrowItem();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to Borrow Return.");
                                }


                            }
                        }
                        else
                        {
                            if (UserRole == "1" | UserRole == "2")
                            {
                                string ackStatus = dgvRBorrowItem.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();

                                if (ackStatus == "Acknowledged")
                                {
                                    MessageBox.Show("Already Acknowledge");
                                }
                                else
                                {

                                    DialogResult dialogResult = MessageBox.Show("Please Click Yes To Acknowledge", "Acknowledge", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        SqlDataReader reader;
                                        string Userid = "'" + SUserID + "'";
                                        string ExpID = "'" + SExpID + "'";
                                        string id = "'" + dgvRBorrowItem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() + "'";
                                        string spName = "sp_RAM_ItemApproveBorrowReturn";

                                        reader = monitoring.ExecuteReader(spName, ExpID, id, Userid);
                                        DataTable result = new DataTable();
                                        result.Load(reader);
                                        string Result = result.Rows[0]["Result"].ToString();
                                        if (Result == "1")
                                        {
                                            MessageBox.Show("Successfully Acknowledge Borrow Return..");
                                            GetBorrowItem();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to Acknowledge Borrow Return.");
                                        }


                                    }
                                }
                            }


                        }

                        //if (Isadmin == "0")
                        //{
                        //    MessageBox.Show("You Dont have Permission to Approve");
                        //}
                        //else
                        //{
                        //    //APPROVED

                        //    string Ap_Status = allMaintenanceExpenses.dgvExpenses.Rows[e.RowIndex].Cells[15].FormattedValue.ToString();

                        //    if (Ap_Status.ToLower() != "approved")
                        //    {

                        //        DialogResult dialogResult = MessageBox.Show("Please Click Yes To Approve", "Approve", MessageBoxButtons.YesNo);
                        //        if (dialogResult == DialogResult.Yes)
                        //        {
                        //            SqlDataReader reader;
                        //            string Userid = "'" + userlogin + "'";
                        //            string id = "'" + allMaintenanceExpenses.dgvExpenses.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() + "'";
                        //            string spName = "sp_Maintenance_Approve";

                        //            reader = monitoring.ExecuteReader(spName, id, Userid);
                        //            DataTable result = new DataTable();
                        //            result.Load(reader);
                        //            string Result = result.Rows[0]["Result"].ToString();
                        //            if (Result == "1")
                        //            {
                        //                MessageBox.Show("Successfully Updated..");
                        //            }
                        //            else
                        //            {
                        //                MessageBox.Show("Failed Update.");
                        //            }
                        //            //MessageBox.Show(allMaintenanceExpenses.dgvExpenses.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        //        }
                        //        //MessageBox.Show((e.RowIndex + 1).ToString() + " Row Clicked");
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Already Approved");
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnAddBorrowItem_Click(object sender, EventArgs e)
        {
            //public void Param(ArrayList unitAll, string pExpID, string pUserId, string pServiceID, string pDate)
            //EquipArray
            //            updateitem.Param(SExpID, SUserID, SCategory, SServiceID, sDate);

            string sDate = dtDate.Text;
            AddBorrowItem borrowitem = new AddBorrowItem();
            borrowitem.Param(EquipArray, SExpID, SUserID, SServiceID, sDate);
            borrowitem.ShowDialog();

            if (borrowitem.IsCancel == "0")
            {
                GetBorrowItem();
            }
        }

        private void BtnAllApprove_Click(object sender, EventArgs e)
        {
            string result = "0";
            string strSQL = "exec sp_RAM_AllRequestApprove" + " '" + SExpID + "','" + SUserID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            DataTable data = new DataTable();
            DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

            if (readesr.Read())
            {
                result = readesr["Result"].ToString();
                //strUsrBranch = reader["Branch"].ToString();
            }


            if (result == "1")
            {
                MessageBox.Show("Successfully Save");
                GetItem();
                GetBorrowItem();
                btnAddItem.Visible = false;
            }
            else
            {
                MessageBox.Show("Failed to Save");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = "0";
                string StartRepair = txtStartRepair.Text;
                string RepairComplete = txtRepairComplete.Text;

                if(IsRepairUpdate == "1")
                {
                    if (Regex.Replace(StartRepair, @"\s+", "") == "")
                    {
                        MessageBox.Show("Empty Start Of Repair");
                    }
                    else
                    {
                        if (IsRepairComplete == "1")
                        {
                            if (Regex.Replace(StartRepair, @"\s+", "") == "")
                            {
                                MessageBox.Show("Empty Repair Complete");
                            }
                            else
                            {

                                FinalMechanic final = new FinalMechanic();
                                final.Param(SExpID, SUserID);
                                final.ShowDialog();


                                string strSQL = "exec sp_Update_RepairAndMaintenance" + " '" + SExpID + "','" + txtmileage.Text + "','" + txtDriver.Text + "','" + txtContractID.Text + "','" + dtDate.Text + "','" + txtProblem.Text
                                    + "','" + txtDiagnosis.Text + "','" + txtRemarks.Text + "','" + IsRepairUpdate + "','" + txtStartRepair.Text + "','" + IsRepairComplete + "','" + txtRepairComplete.Text + "','" + IsUpdatePMS + "','" + SUserID + "'";
                                //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                                DataTable data = new DataTable();
                                DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

                                if (readesr.Read())
                                {
                                    result = readesr["Result"].ToString();
                                    //strUsrBranch = reader["Branch"].ToString();
                                }


                                if (result == "1")
                                {
                                    MessageBox.Show("Successfully Save");

                                    GetRepairME();
                                    //  GetBorrowItem();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to Save");
                                }

                            }

                        }
                        else
                        {

                            string strSQL = "exec sp_Update_RepairAndMaintenance" + " '" + SExpID + "','" + txtmileage.Text + "','" + txtDriver.Text + "','" + txtContractID.Text + "','" + dtDate.Text + "','" + txtProblem.Text
                                + "','" + txtDiagnosis.Text + "','" + txtRemarks.Text + "','" + IsRepairUpdate + "','" + txtStartRepair.Text + "','" + IsRepairComplete + "','" + txtRepairComplete.Text + "','" + IsUpdatePMS + "','" + SUserID + "'";
                            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                            DataTable data = new DataTable();
                            DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

                            if (readesr.Read())
                            {
                                result = readesr["Result"].ToString();
                                //strUsrBranch = reader["Branch"].ToString();
                            }


                            if (result == "1")
                            {
                                MessageBox.Show("Successfully Save");
                                //  GetBorrowItem();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Save");
                            }
                        }

                    }
                    //
                }
                else
                {
                    if (IsRepairComplete == "1")
                    {
                        if (Regex.Replace(StartRepair, @"\s+", "") == "")
                        {
                            MessageBox.Show("Empty Repair Complete");
                        }
                        else
                        {

                            FinalMechanic final = new FinalMechanic();
                            final.Param(SExpID, SUserID);
                            final.ShowDialog();


                            string strSQL = "exec sp_Update_RepairAndMaintenance" + " '" + SExpID + "','" + txtmileage.Text + "','" + txtDriver.Text + "','" + txtContractID.Text + "','" + dtDate.Text + "','" + txtProblem.Text
                                + "','" + txtDiagnosis.Text + "','" + txtRemarks.Text + "','" + IsRepairUpdate + "','" + txtStartRepair.Text + "','" + IsRepairComplete + "','" + txtRepairComplete.Text + "','" + IsUpdatePMS + "','" + SUserID + "'";
                            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                            DataTable data = new DataTable();
                            DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

                            if (readesr.Read())
                            {
                                result = readesr["Result"].ToString();
                                //strUsrBranch = reader["Branch"].ToString();
                            }


                            if (result == "1")
                            {
                                MessageBox.Show("Successfully Save");
                                //  GetBorrowItem();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Save");
                            }

                        }

                    }
                    else
                    {

                        string strSQL = "exec sp_Update_RepairAndMaintenance" + " '" + SExpID + "','" + txtmileage.Text + "','" + txtDriver.Text + "','" + txtContractID.Text + "','" + dtDate.Text + "','" + txtProblem.Text
                            + "','" + txtDiagnosis.Text + "','" + txtRemarks.Text + "','" + IsRepairUpdate + "','" + txtStartRepair.Text + "','" + IsRepairComplete + "','" + txtRepairComplete.Text + "','" + IsUpdatePMS + "','" + SUserID + "'";
                        //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                        DataTable data = new DataTable();
                        DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

                        if (readesr.Read())
                        {
                            result = readesr["Result"].ToString();
                            //strUsrBranch = reader["Branch"].ToString();
                        }


                        if (result == "1")
                        {
                            MessageBox.Show("Successfully Save");
                            //  GetBorrowItem();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Save");
                        }
                    }
                }


            }
            
        }

        private void chkRepairDate_CheckedChanged(object sender, EventArgs e)
        {

            if (chkRepairDate.Checked == true)
            {
                txtStartRepair.ReadOnly = false;
                IsRepairUpdate = "1";
            }
            else
            {
                txtStartRepair.ReadOnly = true;
                IsRepairUpdate = "0";
            }
        }

        private void chkRepairComplete_CheckedChanged(object sender, EventArgs e)
        {

            if (chkRepairComplete.Checked == true)
            {
                txtRepairComplete.ReadOnly = false;
                IsRepairComplete = "1";
            }
            else
            {
                txtRepairComplete.ReadOnly = true;
                IsRepairComplete = "0";
            }
        }

        private void chkPMS_CheckedChanged(object sender, EventArgs e)
        {

            if (chkPMS.Checked == true)
            {
                IsUpdatePMS = "1";
            }
            else
            {
                IsUpdatePMS = "0";
            }
        }

        private void BtnSaveItem_Click(object sender, EventArgs e)
        {

            if (dgvRItem.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection con = new SqlConnection(Connection))
                    {
                        con.Open();

                        foreach (DataGridViewRow row in dgvRItem.SelectedRows)
                        {

                            using (SqlCommand cmd = new SqlCommand("[sp_updateItemApprove]", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                string Id = row.Cells[0].EditedFormattedValue.ToString();
                                string Source = row.Cells[17].EditedFormattedValue.ToString();
                                string ExpID = SExpID;
                                string Status = row.Cells[10].EditedFormattedValue.ToString();
                                string Remark = row.Cells[11].EditedFormattedValue.ToString();
                                string UserID = SUserID;

                                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
                                cmd.Parameters.Add("@Source", SqlDbType.VarChar).Value = Source;
                                cmd.Parameters.Add("@ExpID", SqlDbType.VarChar).Value = ExpID;
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
                                cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = Remark;
                                cmd.Parameters.Add("@UserId", SqlDbType.VarChar).Value = UserID;

                                cmd.ExecuteNonQuery();

                                //@id varchar(50)
                                //, @Source varchar(350)
                                //, @ExpID varchar(150)
                                //, @Status varchar(100)
                                //, @remark varchar(max)
                                //, @UserId varchar(150)  
                            }
                            MessageBox.Show("Successfully Save");
                        }
                    }

                    GetItem();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int numRows = dgvRItem.Rows.Count;
                    int loop = numRows;

                    using (SqlConnection con = new SqlConnection(Connection))
                    {
                        con.Open();

                        for (int i = 0; i < loop; i++)
                        {
                            using (SqlCommand cmd = new SqlCommand("[sp_updateItemApprove]", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                string Id = dgvRItem.Rows[i].Cells[0].FormattedValue.ToString();
                                string Source = dgvRItem.Rows[i].Cells[17].FormattedValue.ToString();
                                string ExpID = SExpID;
                                string Status = dgvRItem.Rows[i].Cells[10].FormattedValue.ToString();
                                string Remark = dgvRItem.Rows[i].Cells[11].FormattedValue.ToString();
                                string UserID = SUserID;

                                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
                                cmd.Parameters.Add("@Source", SqlDbType.VarChar).Value = Source;
                                cmd.Parameters.Add("@ExpID", SqlDbType.VarChar).Value = ExpID;
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
                                cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = Remark;
                                cmd.Parameters.Add("@UserId", SqlDbType.VarChar).Value = UserID;

                                cmd.ExecuteNonQuery();
                            }
                        }

                    }

                    MessageBox.Show("Successfully Save");

                    GetItem();
                }
            }
        }

        private void BtnBorrowSave_Click(object sender, EventArgs e)
        {

            if (dgvRItem.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection con = new SqlConnection(Connection))
                    {
                        con.Open();

                        foreach (DataGridViewRow row in dgvRItem.SelectedRows)
                        {

                            using (SqlCommand cmd = new SqlCommand("[sp_updateBorrowApprove]", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                string Id = row.Cells[0].EditedFormattedValue.ToString();
                                string ExpID = SExpID;
                                string Status = row.Cells[8].EditedFormattedValue.ToString();
                                string Remark = row.Cells[9].EditedFormattedValue.ToString();
                                string UserID = SUserID;

                                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
                                cmd.Parameters.Add("@ExpID", SqlDbType.VarChar).Value = ExpID;
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
                                cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = Remark;
                                cmd.Parameters.Add("@UserId", SqlDbType.VarChar).Value = UserID;

                                cmd.ExecuteNonQuery();

                                //@id varchar(50)
                                //, @Source varchar(350)
                                //, @ExpID varchar(150)
                                //, @Status varchar(100)
                                //, @remark varchar(max)
                                //, @UserId varchar(150)  
                            }
                            MessageBox.Show("Successfully Save");
                        }
                    }

                    GetBorrowItem();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int numRows = dgvRItem.Rows.Count;
                    int loop = numRows - 1;

                    using (SqlConnection con = new SqlConnection(Connection))
                    {
                        con.Open();

                        for (int i = 0; i < loop; i++)
                        {
                            using (SqlCommand cmd = new SqlCommand("[sp_updateBorrowApprove]", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                string Id = dgvRBorrowItem.Rows[i].Cells[0].FormattedValue.ToString();
                                string ExpID = SExpID;
                                string Status = dgvRBorrowItem.Rows[i].Cells[8].FormattedValue.ToString();
                                string Remark = dgvRBorrowItem.Rows[i].Cells[9].FormattedValue.ToString();
                                string UserID = SUserID;

                                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
                                cmd.Parameters.Add("@ExpID", SqlDbType.VarChar).Value = ExpID;
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
                                cmd.Parameters.Add("@remark", SqlDbType.VarChar).Value = Remark;
                                cmd.Parameters.Add("@UserId", SqlDbType.VarChar).Value = UserID;

                                cmd.ExecuteNonQuery();
                            }
                        }

                    }

                    MessageBox.Show("Successfully Save");

                    GetBorrowItem();
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");

                RMaintenanceExpenses maintenance = new EquipmentMonitoring.ForReportForm.Forms.RMaintenanceExpenses();//new EquipmentMonitoring.ForReportForm.Forms.MaintenanceExpenses();
                //rMaintank.ShowDialog();
                //Projectsite.Param(TOverAllSearchType, overallReportControl.projectSiteOverAllControl.txtSearch.Text);
                //maintenance.Param(dtdata, allMaintenanceExpenses.cmbCategory.Text, allMaintenanceExpenses.cmbMaintenanceType.Text, allMaintenanceExpenses.txtProjectId.Text, allMaintenanceExpenses.dtfrom.Text, allMaintenanceExpenses.dtTo.Text, isCheck);
                //POverAllSearchType + "'," + "'" + overallReportControl.projectSiteOverAllControl.txtSearch.Text + "'")
                maintenance.Show();
            }
            catch
            {

            }
        }
    }
}
