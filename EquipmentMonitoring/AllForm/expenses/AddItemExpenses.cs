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
    public partial class AddItemExpenses : Form
    {

        string SExpID;
        string UserRole;
        string SUserID;
        string SServiceID;
        string SDate;
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        DataGridViewComboBoxColumn dgvcmdCategory = new DataGridViewComboBoxColumn();

        public string IsCancel { get; set; }

        public AddItemExpenses()
        {
            InitializeComponent();
        }

        public void Param(string pExpID, string pUserId, DataTable CategoryAll, string pServiceID, string pDate)
        {
            SExpID = pExpID;
            SUserID = pUserId;
            SServiceID = pServiceID;
            SDate = pDate;

            IsCancel = "1";


            dgvcmdCategory.HeaderText = "CATEGORY";
            dgvcmdCategory.Name = "category";

            ArrayList row = new ArrayList();

            foreach (DataRow dr in CategoryAll.Rows)
            {
                row.Add(dr["Sub-Category"].ToString());
            }


            dgvcmdCategory.Items.AddRange(row.ToArray());
            dgvItem.Columns.Add(dgvcmdCategory);
            dgvItem.Columns[9].Width = 177;


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int Icount = dgvItem.Rows.Count;
            if (Icount > 0)
            {
                    int Iloop = Icount - 1;

                    string pqty =  "'" + "0" + "'";
                    string pitem = "";
                    string pIsPurchase = "0";
                    string pPMS = "'" + "0" + "'";
                    string pRepair =  "'" + "0" + "'";
                    string pTire =  "'" + "0" + "'";
                    string pPartsNo =  "'" + "'";
                    string pSerialNo =  "'" + "'";
                    string pAllocationNo =  "'" + "'";
                    //string pCategory = "";
                    string CategoryL =  "'" + "'";
                    //Item


                    //  DriversName = "'" + dgvExpenses.Rows[i].Cells[7].FormattedValue.ToString().Replace(",", "") + "'";

                    for (int i = 0; i < Iloop; i++)
                    {

                        if (Convert.ToString(dgvItem.Rows[i].Cells[0].FormattedValue) != string.Empty)
                        {
                            pqty = "'" + dgvItem.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                        }
                        else
                        {
                            pqty = "'" + "0" + "'";
                        }

                        if (Convert.ToString(dgvItem.Rows[i].Cells[1].FormattedValue) != string.Empty)
                        {
                            pitem = "'" + dgvItem.Rows[i].Cells[1].FormattedValue.ToString()+ "'";
                        }
                        else
                        {
                            pitem = "'" + "'";
                        }


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


                    if (Convert.ToString(dgvItem.Rows[i].Cells[3].FormattedValue) != string.Empty)
                        {
                            pPMS = "'" + dgvItem.Rows[i].Cells[3].FormattedValue.ToString() + "'";
                        }
                        else
                        {
                            pPMS = "'" + "0" + "'";
                        }

                        if (Convert.ToString(dgvItem.Rows[i].Cells[4].FormattedValue) != string.Empty)
                        {
                            pRepair = "'" + dgvItem.Rows[i].Cells[4].FormattedValue.ToString() + "'";
                        }
                        else
                        {
                            pRepair = "'" + "0" + "'";
                        }

                        if (Convert.ToString(dgvItem.Rows[i].Cells[5].FormattedValue) != string.Empty)
                        {
                            pTire = "'" + dgvItem.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                        }
                        else
                        {
                            pTire = "'" + "0" + "'";
                        }



                        if (Convert.ToString(dgvItem.Rows[i].Cells[6].FormattedValue) != string.Empty)
                        {
                            pPartsNo = "'" + dgvItem.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                        }
                        else
                        {
                            pPartsNo = "'" + "'";
                        }


                        if (Convert.ToString(dgvItem.Rows[i].Cells[7].FormattedValue) != string.Empty)
                        {
                            pSerialNo = "'" + dgvItem.Rows[i].Cells[7].FormattedValue.ToString() + "'";
                        }
                        else
                        {
                            pSerialNo = "'" + "'";
                        }

                        if (Convert.ToString(dgvItem.Rows[i].Cells[8].FormattedValue) != string.Empty)
                        {
                            pAllocationNo = "'" + dgvItem.Rows[i].Cells[8].FormattedValue.ToString() + "'";
                        }
                        else
                        {
                            pAllocationNo = "'" + "0" + "'";
                        }

                        if (Convert.ToString(dgvItem.Rows[i].Cells[9].FormattedValue) != string.Empty)
                        {
                            CategoryL = "'" + dgvItem.Rows[i].Cells[9].FormattedValue.ToString() + "'";
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
                            string trim = Regex.Replace(pitem, @"s", "");
                            if (trim != "")
                            {

                                SqlDataReader reader;
                                string spName = "sp_Add_RepairItem";
                                string result = "";
                                string ExpID = "'" + SExpID + "'";
                                string Date = "'" + SDate + "'";
                                string ServiceID = "'" + SServiceID + "'";
                                string User = "'" + SUserID + "'";

                                try
                                {
                                    reader = monitoring.ExecuteReader(spName, ExpID, Date, ServiceID, pqty, pitem, pIsPurchase, pPMS, pRepair, pTire, pPartsNo, pSerialNo, pAllocationNo, CategoryL, User);


                                    DataTable Detail = new DataTable();
                                    Detail.Load(reader);
                                    result = Detail.Rows[0]["Result"].ToString();

                                    if (result == "1")
                                    {
                                        dgvItem.Rows.Remove(dgvItem.Rows[i]);
                                        i = i - 1;
                                        Iloop = Iloop - 1;

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


                    }

            }

        }
    }
}
