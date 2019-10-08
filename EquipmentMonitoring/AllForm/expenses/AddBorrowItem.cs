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
    public partial class AddBorrowItem : Form
    {

        string SExpID;
        string UserRole;
        string SUserID;
        string SServiceID;
        string SDate;

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        GenericFunctions GenericFunc = new GenericFunctions();

        ArrayList EquipArray = new ArrayList();
        public string IsCancel { get; set; }

        public AddBorrowItem()
        {
            InitializeComponent();
        }
        public void Param(ArrayList unitAll, string pExpID, string pUserId, string pServiceID, string pDate)
        {

            EquipArray = unitAll;

            IsCancel = "1";
            SExpID = pExpID;
            SUserID = pUserId;
            SServiceID = pServiceID;
            SDate = pDate;


            AutoCompleteStringCollection UnitListAll = new AutoCompleteStringCollection();
            EquipList(UnitListAll);


        }

        private void EquipList(AutoCompleteStringCollection data)
        {
            foreach (var item in EquipArray)
                data.AddRange(new string[] { item.ToString() });
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

        private void BtnSave_Click(object sender, EventArgs e)
        {

            int Icount = dgvBorrowItem.Rows.Count;

            //int Icount = dgvBorrowItem.Rows.Count;
            if (Icount > 0)
            {
                int Iloop = Icount - 1;
                
                string Equipno = "'" + "'";
                string pqty = "'" + "0" + "'";
                string pitem = "";
                string pPartsNo = "'" + "'";
                string pSerialNo = "'" + "'";
                string pAllocationNo = "'" + "'";

                for (int i = 0; i < Iloop; i++)
                {

                    if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[0].FormattedValue) != string.Empty)
                    {
                        Equipno = "'" + dgvBorrowItem.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        Equipno = "'" + "0" + "'";
                    }

                    if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[1].FormattedValue) != string.Empty)
                    {
                        pqty = "'" + dgvBorrowItem.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pqty = "'" + "0" + "'";
                    }
                    

                    if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[2].FormattedValue) != string.Empty)
                    {
                        pitem = "'" + dgvBorrowItem.Rows[i].Cells[2].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pitem = "'" + "0" + "'"; 
                    }

                    if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[3].FormattedValue) != string.Empty)
                    {
                        pPartsNo = "'" + dgvBorrowItem.Rows[i].Cells[3].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pPartsNo = "'" + "'";
                    }

                    if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[4].FormattedValue) != string.Empty)
                    {
                        pSerialNo = "'" + dgvBorrowItem.Rows[i].Cells[4].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pSerialNo = "'"  + "'";
                    }

                    if (Convert.ToString(dgvBorrowItem.Rows[i].Cells[5].FormattedValue) != string.Empty)
                    {
                        pAllocationNo = "'" + dgvBorrowItem.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                    }
                    else
                    {
                        pAllocationNo = "'" + "0" + "'";
                    }

                    string trim = Regex.Replace(pitem, @"s", "");
                    if (trim != "")
                    {

                        SqlDataReader reader;
                        string spName = "sp_Request_RepairBorrow";
                        string result = "";
                        string ExpID = "'" + SExpID + "'";
                        string Date = "'" + SDate + "'";
                        string ServiceID = "'" + SServiceID + "'";
                        string User = "'" + SUserID + "'";

                        try
                        {
                            reader = monitoring.ExecuteReader(spName, ExpID, ServiceID, Equipno, pqty, pitem, pPartsNo, pSerialNo, pAllocationNo, User);

                            DataTable Detail = new DataTable();
                            Detail.Load(reader);
                            result = Detail.Rows[0]["Result"].ToString();

                            if (result == "1")
                            {
                                dgvBorrowItem.Rows.Remove(dgvBorrowItem.Rows[i]);
                                i = i - 1;
                                Iloop = Iloop - 1;

                                IsCancel = "0";
                            }
                            else
                            {

                                dgvBorrowItem.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                MessageBox.Show("Failed to Add Borrow item");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Failed to Add Borrow item");
                        }

                    }


                }

            }
        }
    }
}
