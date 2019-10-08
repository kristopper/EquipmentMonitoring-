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
    public partial class AddUnitTire : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        public string userlogin { get; set; }
        public string EquipmentNo { get; set; }
        public string Model { get; set; }
        public string PlateNo { get; set; }
        public string DateOfPurchase { get; set; }
        public string ServiceID { get; set; }
        public string IsSave { get; set; }
        public AddUnitTire()
        {
            InitializeComponent();
        }
        public void param(string puserid, string pEquipmentNo, string pModel, string pPlateNo, string pDateOfPurchase, string pServiceID)
        {
            userlogin = puserid;
            EquipmentNo = pEquipmentNo;
            Model = pModel;
            PlateNo = pPlateNo;
            DateOfPurchase = pDateOfPurchase;
            ServiceID = pServiceID;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string EquipmentNoTB = "'" + EquipmentNo + "'";
                    string ModelTB = "'" + Model + "'";
                    string PlateNumberTB = "'" + PlateNo + "'";
                    string DateofPurchaseTB = "'" + DateOfPurchase + "'";
                    string UserIdTB = "'" + userlogin + "'";
                    string ServiceIDTB = "'" + ServiceID + "'";
                    string AllocationNo = "";
                    string Brand = "";
                    string SerialNo = "";
                    string spName = "sp_Add_EquipmentTire";
                    string Partnumber = "";

                    int Tcount = dgvTire.Rows.Count;
                    int Tloop = Tcount - 1;

                    if (Tloop > 0)
                    {
                        for (int i = 0; i < Tloop; i++)
                        {
                            AllocationNo = "'" + dgvTire.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                            Brand = "'" + dgvTire.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                            SerialNo = "'" + dgvTire.Rows[i].Cells[2].FormattedValue.ToString() + "'";
                            Partnumber = "'" + dgvTire.Rows[i].Cells[3].FormattedValue.ToString() + "'";
                            reader = monitoring.ExecuteReader(spName, AllocationNo, Brand, SerialNo, ServiceIDTB, EquipmentNoTB, ModelTB, PlateNumberTB, DateofPurchaseTB, ServiceIDTB, Partnumber);
                            DataTable Detail = new DataTable();
                            Detail.Load(reader);
                            result = Detail.Rows[0]["Result"].ToString();

                            if (result == "1")
                            {
                                IsSave = "1";
                                dgvTire.Rows.Remove(dgvTire.Rows[i]);
                                i = i - 1;
                                Tloop = Tloop - 1;
                            }
                            else if (result == "2")
                            {
                                MessageBox.Show("Serial No : " + SerialNo + " Already Exist");
                                dgvTire.Rows[i].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Red };
                                //this.dgvTire.Rows[i].Cells[0].Style.ForeColor = Color.DarkRed;
                                //dgvTire.Rows[i].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Red };
                                //dgvTire.Rows[i].Cells[0].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                            else if (result == "3")
                            {
                                MessageBox.Show("Tire No : " + AllocationNo + " Already Exist");
                                //dgvTire.Rows[i].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Red };
                                //this.dgvTire.Rows[i].Cells[0].Style.ForeColor = Color.DarkRed;
                                //dgvTire.Rows[i].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Red };
                                //dgvTire.Rows[i].Cells[0].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                            else if (result == "4")
                            {
                                MessageBox.Show("Tire No : " + AllocationNo + " and Serial No :" + SerialNo + " Already Exist");
                                dgvTire.Rows[i].Cells[2].Style = new DataGridViewCellStyle { BackColor = Color.Red };
                                //this.dgvTire.Rows[i].Cells[0].Style.ForeColor = Color.DarkRed;
                                //dgvTire.Rows[i].Cells[0].Style = new DataGridViewCellStyle { BackColor = Color.Red };
                                //dgvTire.Rows[i].Cells[0].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                            else if (result == "5")
                            {
                                MessageBox.Show("Serial No : " + SerialNo + " Already Use on Other Unit");
                                dgvTire.Rows[i].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Tire Info");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
