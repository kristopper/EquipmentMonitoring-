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
    public partial class UpdateItemExpenses : Form
    {
        string SExpID;
        string UserRole;
        string SUserID;
        string SServiceID;
        string SDate;
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        public string IsCancel { get; set; }

        GenericFunctions GenericFunc = new GenericFunctions();

        DataGridViewComboBoxColumn dgvcmdCategory = new DataGridViewComboBoxColumn();
        public UpdateItemExpenses()
        {
            InitializeComponent();
        }
        public void Param(string pExpID, string pUserId, DataTable CategoryAll, string pServiceID, string pDate)
        {
            IsCancel = "1";
            SExpID = pExpID;
            SUserID = pUserId;
            SServiceID = pServiceID;
            SDate = pDate;


            dgvcmdCategory.HeaderText = "CATEGORY";
            dgvcmdCategory.Name = "category";

            ArrayList categoryL = new ArrayList();

            foreach (DataRow dr in CategoryAll.Rows)
            {
                categoryL.Add(dr["Sub-Category"].ToString());
            }


            dgvcmdCategory.Items.AddRange(categoryL.ToArray());
            dgvItem.Columns.Add(dgvcmdCategory);
            dgvItem.Columns[14].Width = 177;


            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_RepairAndMaintenanceItem '" + SExpID + "'"));

            int vw_ItemExpenses = dsKey.Tables[0].Rows.Count;

            dgvItem.DataSource = null;

            if (this.dgvItem.DataSource != null)
            {
                this.dgvItem.DataSource = null;
            }
            else
            {
                this.dgvItem.Rows.Clear();
            }


            if (vw_ItemExpenses > 0)
            {
                foreach (DataRow row in dsKey.Tables[0].Rows)
                {
                    dgvItem.Rows.Add(row["SourceID"].ToString()
                                //   , "false"
                                , row["Qty"].ToString()
                                , row["Item"].ToString()
                                , row["IsPurchase"].ToString()
                                , String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]))//row["PMS"].ToString()
                                , String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                                , String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                                , row["PartsNo"].ToString()
                                , row["SerialNo"].ToString()
                                , row["ReferenceNo"].ToString()
                                , row["AllocationNo"].ToString()
                                , row["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "")
                                , row["DateCompleted"].ToString().Replace(" 12:00:00 AM", "")
                            //  , row["Category"].ToString()
                                , row["Source"].ToString()
                                , row["SubCategory"].ToString()
                    //  , row["Approval"].ToString()
                    );
                }
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int Icount = dgvItem.Rows.Count;
            if (Icount > 0)
            {
                int Iloop = Icount - 1;

                string pid = "'" + "0" + "'";
                //string pqty = "'" + "0" + "'";
                //string pitem = "";
                string pIsPurchase = "0";
                string pPMS = "'" + "0" + "'";
                string pRepair = "'" + "0" + "'";
                string pTire = "'" + "0" + "'";
                string pPartsNo = "'" + "'";
                string pSerialNo = "'" + "'";
                string pReferenceNo = "'" + "'";
                string pAllocationNo = "'" + "'";
                string pDateOfPurchase = "'" + "'";
                string pPartComplete = "'" + "'";
                string CategoryL = "'" + "'";
                string Source = "'" + "'";

                string result = "";
                string ExpID = "'" + SExpID + "'";
                string Date = "'" + SDate + "'";
                string ServiceID = "'" + SServiceID + "'";
                string User = "'" + SUserID + "'";
                //Item

                /*
                  @Id varchar(100)
		        , @ExpId varchar(100)
		        , @ServiceID varchar(100)
		        , @IsPurchase varchar(2)
		        , @PMS varchar(50)
		        , @Repair varchar(50)
		        , @Tire varchar(50)
		        , @PartsNo varchar(500)
		        , @SerialNo varchar(500)
		        , @ReferenceNo varchar(500)
		        , @allocationNo varchar(5)
		        , @DateOfPurchase varchar(15)
		        , @PartComplete varchar(15)
		        , @SubCategory varchar(250)
		        , @UserID varchar(250)
		        , @Source varchar(100)
                */
                
                //  DriversName = "'" + dgvExpenses.Rows[i].Cells[7].FormattedValue.ToString().Replace(",", "") + "'";

                for (int i = 0; i < Iloop; i++)
                {

                    if (Convert.ToString(dgvItem.Rows[i].Cells[0].FormattedValue) != string.Empty)
                    {
                        pid = "'" + dgvItem.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pid = "'" + "0" + "'";
                    }

                    //if (Convert.ToString(dgvItem.Rows[i].Cells[1].FormattedValue) != string.Empty)
                    //{
                    //    pitem = "'" + dgvItem.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                    //}
                    //else
                    //{
                    //    pitem = "'" + "'";
                    //}

                    pIsPurchase = "'" + "1" + "'";
                    //if (Convert.ToString(dgvItem.Rows[i].Cells["Purchase"].Value) == "1")
                    //// if (Convert.ToBoolean(dgvExpenses.Rows[i].Cells[7].Value) == true)
                    //{
                    //    pIsPurchase = "'" + "1" + "'";
                    //}
                    //else
                    //{
                    //    pIsPurchase = "'" + "0" + "'";
                    //}


                    if (Convert.ToString(dgvItem.Rows[i].Cells[4].FormattedValue) != string.Empty)
                    {
                        pPMS = "'" + dgvItem.Rows[i].Cells[4].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pPMS = "'" + "0" + "'";
                    }

                    if (Convert.ToString(dgvItem.Rows[i].Cells[5].FormattedValue) != string.Empty)
                    {
                        pRepair = "'" + dgvItem.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pRepair = "'" + "0" + "'";
                    }

                    if (Convert.ToString(dgvItem.Rows[i].Cells[6].FormattedValue) != string.Empty)
                    {
                        pTire = "'" + dgvItem.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pTire = "'" + "0" + "'";
                    }



                    if (Convert.ToString(dgvItem.Rows[i].Cells[7].FormattedValue) != string.Empty)
                    {
                        pPartsNo = "'" + dgvItem.Rows[i].Cells[7].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pPartsNo = "'" + "'";
                    }


                    if (Convert.ToString(dgvItem.Rows[i].Cells[8].FormattedValue) != string.Empty)
                    {
                        pSerialNo = "'" + dgvItem.Rows[i].Cells[8].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pSerialNo = "'" + "'";
                    }

                    if (Convert.ToString(dgvItem.Rows[i].Cells[9].FormattedValue) != string.Empty)
                    {
                        pReferenceNo = "'" + dgvItem.Rows[i].Cells[9].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pReferenceNo = "'" + "'";
                    }


                    
                    if (Convert.ToString(dgvItem.Rows[i].Cells[10].FormattedValue) != string.Empty)
                    {
                        pAllocationNo = "'" + dgvItem.Rows[i].Cells[10].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pAllocationNo = "'" + "0" + "'";
                    }


                    if (Convert.ToString(dgvItem.Rows[i].Cells[11].FormattedValue) != string.Empty)
                    {
                        pDateOfPurchase = "'" + dgvItem.Rows[i].Cells[11].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pDateOfPurchase = "'" + "0" + "'";
                    }

                    if (Convert.ToString(dgvItem.Rows[i].Cells[12].FormattedValue) != string.Empty)
                    {
                        pPartComplete = "'" + dgvItem.Rows[i].Cells[12].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pPartComplete = "'" + "0" + "'";
                    }


                    if (Convert.ToString(dgvItem.Rows[i].Cells[13].FormattedValue) != string.Empty)
                    {
                        Source = "'" + dgvItem.Rows[i].Cells[13].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        Source = "'" + "0" + "'";
                    }

                    if (Convert.ToString(dgvItem.Rows[i].Cells[14].FormattedValue) != string.Empty)
                    {
                        CategoryL = "'" + dgvItem.Rows[i].Cells[14].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        CategoryL = "'" + "0" + "'";
                    }

                    if (CategoryL == "'" + "0")
                    {
                        MessageBox.Show("Please Select Category");
                    }
                    else
                    {

                            SqlDataReader reader;
                            string spName = "sp_Update_RepairItem";

                            try
                            {
                                reader = monitoring.ExecuteReader(spName, pid, ExpID, ServiceID, pIsPurchase, pPMS, pRepair, pTire, pPartsNo, pSerialNo, pReferenceNo, pAllocationNo, pDateOfPurchase, pPartComplete, CategoryL, User, Source);


                                DataTable Detail = new DataTable();
                                Detail.Load(reader);
                                result = Detail.Rows[0]["Result"].ToString();

                                if (result == "1")
                                {
                                    //dgvItem.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.bl };
                                    i = i++;

                                //i = i - 1;
                                //Iloop = Iloop - 1;


                                IsCancel = "0";
                                }
                                else
                                {

                                    dgvItem.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                    MessageBox.Show("Cannot Add Item because is already Approved.");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Failed to Add Item");
                            }

                            //using (SqlCommand cmdItem = new SqlCommand("sp_Add_RepairItem", con))
                            //{
                            //    cmdItem.CommandType = CommandType.StoredProcedure;

                            //    cmdItem.Parameters.Add("@ExpId", SqlDbType.VarChar).Value = SExpID;
                            //    cmdItem.Parameters.Add("@Date", SqlDbType.VarChar).Value = SDate;
                            //    cmdItem.Parameters.Add("@ServiceID", SqlDbType.VarChar).Value = SServiceID;
                            //    cmdItem.Parameters.Add("@quality", SqlDbType.VarChar).Value = pqty;
                            //    cmdItem.Parameters.Add("@Item", SqlDbType.VarChar).Value = pitem;
                            //    cmdItem.Parameters.Add("@IsPurchase", SqlDbType.VarChar).Value = pIsPurchase;
                            //    cmdItem.Parameters.Add("@PMS", SqlDbType.VarChar).Value = pPMS;
                            //    cmdItem.Parameters.Add("@Repair", SqlDbType.VarChar).Value = pRepair;
                            //    cmdItem.Parameters.Add("@Tire", SqlDbType.VarChar).Value = pTire;
                            //    cmdItem.Parameters.Add("@PartsNo", SqlDbType.VarChar).Value = pPartsNo;
                            //    cmdItem.Parameters.Add("@SerialNo", SqlDbType.VarChar).Value = pSerialNo;
                            //    cmdItem.Parameters.Add("@allocationNo", SqlDbType.VarChar).Value = pAllocationNo;
                            //    cmdItem.Parameters.Add("@SubCategory", SqlDbType.VarChar).Value = CategoryL;
                            //    cmdItem.Parameters.Add("@UserID", SqlDbType.VarChar).Value = SUserID;
                            //    cmdItem.ExecuteNonQuery();
                            //}
                    }


                }

                MessageBox.Show("Successfully Save");

            }

            //IsCancel = "0";

        }
    }
}
