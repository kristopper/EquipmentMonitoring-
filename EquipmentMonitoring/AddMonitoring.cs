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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class AddMonitoring : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public string MEquipmentNo { get; set; }
        public string MEquipmentname { get; set; }
        public string MName { get;  set; }
        public string Mid { get; set; }
        public string mvalue { get; set; }
        public string MTotalUsed { get; set; }
        public string misMaintenance { get; set; }
        public string MTrucktype { get; set; }

        public string formtype { get; set; }

        public AddMonitoring()
        {
            InitializeComponent();
        }
        public void Param(string EquipmentNo, string Equipmentname, string Name, string id, DataTable data, string numbertable, string value, string TotalUsed, string isMaintenance, string form, string Trucktype)
        {
            formtype = form;

            lblEqpNo.Text = EquipmentNo;
            lblEqpName.Text = Equipmentname;
            lblNoName.Text = Name;
            lblTotalUsed.Text = TotalUsed;

            MEquipmentNo = EquipmentNo;
            MEquipmentname = Equipmentname;
            MName = Name;
            mvalue = value;
            Mid = id;
            MTotalUsed = TotalUsed;
            misMaintenance = isMaintenance;
            MTrucktype = Trucktype;

            /*
            string pEquipno = "'" + EquipmentNo + "'";
            string pModel = "'" + Equipmentname + "'";
            string pPlateno = "'" + Name + "'";
            */

            string pEquipno;
            string pModel;
            string pPlateno;

            if (EquipmentNo != null | EquipmentNo != "")
            {
                pEquipno = "'" + EquipmentNo + "'";
            }
            else
            {
                pEquipno = "novalue";
            }

            if (Equipmentname != null | Equipmentname != "")
            {
                pModel = "'" + Equipmentname + "'";
            }
            else
            {
                pModel = "novalue";
            }
            if (Name != null | Name != "")
            {
                pPlateno = "'" + Name + "'";
            }
            else
            {
                pPlateno = "novalue";
            }

            SqlDataReader reader;
            string spName = "sp_Get_Information";

            reader = monitoring.ExecuteReader(spName, pEquipno, pPlateno, pModel);
            DataTable Detail = new DataTable();
            Detail.Load(reader);
            lblEngineNo.Text = Detail.Rows[0]["EngineNo"].ToString();
            lblChassisNo.Text = Detail.Rows[0]["ChassisNo"].ToString();
            lblPiston.Text = Detail.Rows[0]["PistonDisplacement"].ToString();
            lblCylinder.Text = Detail.Rows[0]["NoCylinder"].ToString();
            lblMake.Text = Detail.Rows[0]["Make"].ToString();
            lblSeries.Text = Detail.Rows[0]["Series"].ToString();
            lblBodyType.Text = Detail.Rows[0]["BodyType"].ToString();
            lblYearModel.Text = Detail.Rows[0]["YearModel"].ToString();
            lblGrossWT.Text = Detail.Rows[0]["GrossWT"].ToString();
            lblStatusPurchase.Text = Detail.Rows[0]["StatusOfPurchase"].ToString();
            lblDatePurchase.Text = Detail.Rows[0]["DateOfPurchase"].ToString().Replace(" 12:00:00 AM","");
            lblSupplier.Text = Detail.Rows[0]["Supplier"].ToString();
            lblCRNo.Text = Detail.Rows[0]["CR_No"].ToString();
            lblMVFile.Text = Detail.Rows[0]["MVFile_No"].ToString();
            lblExistingReading.Text = Detail.Rows[0]["ExistingReadingkm"].ToString();
            lblExpired.Text = Detail.Rows[0]["Month_R_Expired"].ToString() + " " + Detail.Rows[0]["Year_R_Expired"].ToString();
            lblFuelType.Text = Detail.Rows[0]["FuelType"].ToString();
          
            //  lblTotalUsed.Text = Detail.Rows[0]["TotalKM"].ToString();

            /*
              string id = "'" + row.Cells[0].Value.ToString() + "'";
                        string equipno = "'" + lblEqpNo.Text + "'";
                        string type = "'" + MTrucktype + "'";

                        string spName = "sp_Get_Information";

                        reader = monitoring.ExecuteReader(spName, id, equipno, type);
                        DataTable Detail = new DataTable();
                        Detail.Load(reader);
                        lblTotalUsed.Text = Detail.Rows[0]["TotalKM"].ToString();
             */

            if (misMaintenance == "0")
            {
               // MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
                lblTotalUsed.ForeColor = Color.Black;
            }
            else
            {
                lblTotalUsed.ForeColor = Color.DarkRed;
            }
            
            foreach (DataRow row in data.Rows)
            {
                dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                        , row["Date"].ToString().Replace(" 12:00:00 AM","")
                        , row["DriversName"].ToString()
                        , String.Format("{0:#,###.00}", Convert.ToDecimal(row["kmhrStart"]))//row["kmhrStart"].ToString()
                        , String.Format("{0:#,###.00}", Convert.ToDecimal(row["kmhrStop"]))//row["kmhrStop"].ToString()
                        , (MTrucktype == "TRUCK" ? row["kms"].ToString() : row["Hrs"].ToString())// row["kms"].ToString()
                        , String.Format("{0:#,###.00}", Convert.ToDecimal(row["noltrsrefilled"]))//row["noltrsrefilled"].ToString()
                        , String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"]))//row["FuelCost"].ToString()
                        , String.Format("{0:#,###.00}", Convert.ToDecimal(row["Ltr/kms"]))//row["Ltr/kms"].ToString()
                        , row["Preventive"].ToString()
                        , row["ProjectSite"].ToString()
                        , row["Deleteremark"].ToString()
                        );
            }
        }
        /*
        private void AddMonitoring_Load(object sender, System.EventArgs e)
        {
            //Thread.Sleep(1500);
            //MessageBox.Show("load");
        }
        */
        private void AddMonitoring_Load(object sender, System.EventArgs e)
        {
            //Register it to Start in Load 
            //Starting from the Next time.
            this.Activated += AfterLoading;
        }
        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;
            //Write your code here.            
            if (misMaintenance == "1")
            {
                MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
            }
            else
            {
            }
        }
        private void ClearGrid()
        {
            if (this.InvokeRequired) this.Invoke(new Action(this.ClearGrid));

            this.dgvDataMonitoring.DataSource = null;
            this.dgvDataMonitoring.Rows.Clear();
            this.dgvDataMonitoring.Refresh();
        }

        public void Saveparam(DataTable data)
        {
            dgvDataMonitoring.DataSource = null;
            if (this.dgvDataMonitoring.DataSource != null)
            {
                this.dgvDataMonitoring.DataSource = null;
            }
            else
            {
                this.dgvDataMonitoring.Rows.Clear();
            }
            //  dgvDataMonitoring.DataBindings();//.DataBind();
            // this.dgvDataMonitoring.Rows.Clear();
            /*
            dgvDataMonitoring.DataSource = null;
            dgvDataMonitoring.Rows.Clear();
            dgvDataMonitoring.Columns.Clear();
            dgvDataMonitoring.Refresh();
            ClearGrid();
            */
            //dgvDataMonitoring.Items.Clear();
            //dgvDataMonitoring.Items.Refresh();
            /*
            foreach (DataRow row in data.Rows)
            {
                dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                        , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                        , row["Drivers_OptName"].ToString()
                        , row["kmhrs_duringRefuel"].ToString()
                        , row["kmhrs_LastRefuel"].ToString()
                        , row["Kmhrs_Used"].ToString()
                        , row["NoLtrsRefill"].ToString()
                        , row["PreventiveId"].ToString()
                        , row["PLocation"].ToString()
                        );
            }
            */
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            MonitoringAdd monitoring = new MonitoringAdd();
            monitoring.Param(MEquipmentNo, MEquipmentname, MName, Mid, mvalue, formtype);
            this.Hide();
            monitoring.ShowDialog();
            this.Close();
            */

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (formtype == "Main")
            {
                mainform main = new mainform();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void dgvDataMonitoring_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /////here
            /*
            UpdateDeleteForm update = new UpdateDeleteForm();
            update.maintenance = misMaintenance;
            update.strTotalUsed = lblTotalUsed.Text;
            update.Trucktype = MTrucktype;
            update.strEquipNo = lblEqpNo.Text;
            update.strModel = lblEqpName.Text;
            update.strPlateNo = lblNoName.Text;
            update.strID = dgvDataMonitoring[0, e.RowIndex].Value.ToString();
            update.strDate = dgvDataMonitoring[1, e.RowIndex].Value.ToString();
            update.strDrivers = dgvDataMonitoring[2, e.RowIndex].Value.ToString();
            update.strLastRefuel = dgvDataMonitoring[3, e.RowIndex].Value.ToString();
            update.strDuringRefuel = dgvDataMonitoring[4, e.RowIndex].Value.ToString();
            update.strRefill = dgvDataMonitoring[6, e.RowIndex].Value.ToString();
            if (MTrucktype == "TRUCK")
            {
                update.strKmTravel = dgvDataMonitoring[5, e.RowIndex].Value.ToString();
                update.strHourUsed = "0";
            }
            else
            {
                update.strHourUsed = dgvDataMonitoring[5, e.RowIndex].Value.ToString();
                update.strKmTravel = "0";
            }
            update.strLocation = dgvDataMonitoring[10, e.RowIndex].Value.ToString();
            update.ShowDialog(this);
            lblTotalUsed.Text = update.strTotalUsed;
            misMaintenance = update.maintenance;

            dgvDataMonitoring[0, e.RowIndex].Value = update.strID;
            dgvDataMonitoring[1, e.RowIndex].Value = update.strDate;
            dgvDataMonitoring[2, e.RowIndex].Value = update.strDrivers;
            dgvDataMonitoring[3, e.RowIndex].Value = update.strLastRefuel;
            dgvDataMonitoring[4, e.RowIndex].Value = update.strDuringRefuel;
            dgvDataMonitoring[6, e.RowIndex].Value = update.strRefill;
            dgvDataMonitoring[10, e.RowIndex].Value = update.strLocation;
            if (MTrucktype == "TRUCK")
            {
                dgvDataMonitoring.Rows[e.RowIndex].Cells[5].Value = update.strKmTravel;
            }
            else
            {
                dgvDataMonitoring.Rows[e.RowIndex].Cells[5].Value = update.strTotalUsed;
            }
            if (misMaintenance == "1")
            {
                MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + lblTotalUsed.Text);
                lblTotalUsed.ForeColor = Color.DarkRed;
            }
            else
            {
                lblTotalUsed.ForeColor = Color.Black;
            }
            */

            /////////////////////////////////////
            /*
            this.Hide();
            string Equipmentno = dgvMaintenance[1, e.RowIndex].Value.ToString();
            string Model = dgvMaintenance[2, e.RowIndex].Value.ToString();
            string Plateno = dgvMaintenance[3, e.RowIndex].Value.ToString();
            string Preventive;
            string Maintenanceid;
            */
            /*
            lblID.Text = dgvDataMonitoring[0, e.RowIndex].Value.ToString();
            txtDrivers.Text = dgvDataMonitoring[2, e.RowIndex].Value.ToString();
            txtLastRefuel.Text = dgvDataMonitoring[3, e.RowIndex].Value.ToString();
            txtDuringRefuel.Text = dgvDataMonitoring[4, e.RowIndex].Value.ToString();
            txtHours_Used.Text = dgvDataMonitoring[5, e.RowIndex].Value.ToString();
            txtRefill.Text = dgvDataMonitoring[6, e.RowIndex].Value.ToString();
            txtLocation.Text = dgvDataMonitoring[8, e.RowIndex].Value.ToString();
            */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete", "Delete Validation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgvDataMonitoring.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvDataMonitoring.SelectedRows)
                    {
                        string isblank = row.Cells[9].Value.ToString();
                        string cann = row.Cells[11].Value.ToString();
                        if (cann == "Return To Tanker")
                        {
                            MessageBox.Show("Failed to Delete. Already Deleted");
                        }
                        else
                        {
                            if (isblank is null || isblank == "")
                            {
                                string result;
                                SqlDataReader reader;

                                string id = "'" + row.Cells[0].Value.ToString() + "'";
                                string equipno = "'" + lblEqpNo.Text + "'";
                                string type = "'" + MTrucktype + "'";

                                string spName = "sp_delete_DailySheet";

                                reader = monitoring.ExecuteReader(spName, id, equipno, type);
                                DataTable Detail = new DataTable();
                                Detail.Load(reader);
                                lblTotalUsed.Text = Detail.Rows[0]["TotalKM"].ToString();
                                //  MessageBox.Show(row.Cells[0].Value.ToString());
                                row.Cells[11].Value = "Return To Tanker";
                                //  dgvDataMonitoring.SelectedRows.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                //dgvDataMonitoring.Rows.Remove(row);
                            }
                            else
                            {
                                MessageBox.Show("Failed to Delete. Already Maintenance");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to Delete. Please Select Row");
                }

            }


            else if (dialogResult == DialogResult.No)
            {
                // MessageBox.Show("Succesfully Cancel");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MaintenanceExpenses maintenance = new MaintenanceExpenses();
            //this.Hide();
            maintenance.ShowDialog();
            //this.Close();
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formtype == "Main")
            {
                mainform main = new mainform();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void dgvDataMonitoring_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            ////here
           string isprocess = dgvDataMonitoring[11, e.RowIndex].Value.ToString();
            
            if (isprocess == "Return To Tanker")
            {
                MessageBox.Show("Failed to Open. Already Deleted");
            }
            else
            {
                UpdateDeleteForm update = new UpdateDeleteForm();
                update.maintenance = misMaintenance;
                update.strTotalUsed = lblTotalUsed.Text;
                update.Trucktype = MTrucktype;
                update.strEquipNo = lblEqpNo.Text;
                update.strModel = lblEqpName.Text;
                update.strPlateNo = lblNoName.Text;
                update.strID = dgvDataMonitoring[0, e.RowIndex].Value.ToString();
                update.strDate = dgvDataMonitoring[1, e.RowIndex].Value.ToString();
                update.strDrivers = dgvDataMonitoring[2, e.RowIndex].Value.ToString();
                update.strLastRefuel = dgvDataMonitoring[3, e.RowIndex].Value.ToString();
                update.strDuringRefuel = dgvDataMonitoring[4, e.RowIndex].Value.ToString();
                update.strRefill = dgvDataMonitoring[6, e.RowIndex].Value.ToString();
                if (MTrucktype == "TRUCK")
                {
                    update.strKmTravel = dgvDataMonitoring[5, e.RowIndex].Value.ToString();
                    update.strHourUsed = "0";
                }
                else
                {
                    update.strHourUsed = dgvDataMonitoring[5, e.RowIndex].Value.ToString();
                    update.strKmTravel = "0";
                }
                update.strLocation = dgvDataMonitoring[10, e.RowIndex].Value.ToString();
                update.ShowDialog(this);
                lblTotalUsed.Text = update.strTotalUsed;
                misMaintenance = update.maintenance;

                dgvDataMonitoring[0, e.RowIndex].Value = update.strID;
                dgvDataMonitoring[1, e.RowIndex].Value = update.strDate;
                dgvDataMonitoring[2, e.RowIndex].Value = update.strDrivers;
                dgvDataMonitoring[3, e.RowIndex].Value = update.strLastRefuel;
                dgvDataMonitoring[4, e.RowIndex].Value = update.strDuringRefuel;
                //   dgvDataMonitoring[6, e.RowIndex].Value = update.strRefill;
                dgvDataMonitoring[10, e.RowIndex].Value = update.strLocation;
                if (MTrucktype == "TRUCK")
                {
                    dgvDataMonitoring.Rows[e.RowIndex].Cells[5].Value = update.strKmTravel;
                }
                else
                {
                    dgvDataMonitoring.Rows[e.RowIndex].Cells[5].Value = update.strTotalUsed;
                }
                if (misMaintenance == "1")
                {
                    MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + lblTotalUsed.Text);
                    lblTotalUsed.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblTotalUsed.ForeColor = Color.Black;
                }

            }

            //////////////////////////////
            /*
            this.Hide();
            string Equipmentno = dgvMaintenance[1, e.RowIndex].Value.ToString();
            string Model = dgvMaintenance[2, e.RowIndex].Value.ToString();
            string Plateno = dgvMaintenance[3, e.RowIndex].Value.ToString();
            string Preventive;
            string Maintenanceid;
            */
            /*
            lblID.Text = dgvDataMonitoring[0, e.RowIndex].Value.ToString();
            txtDrivers.Text = dgvDataMonitoring[2, e.RowIndex].Value.ToString();
            txtLastRefuel.Text = dgvDataMonitoring[3, e.RowIndex].Value.ToString();
            txtDuringRefuel.Text = dgvDataMonitoring[4, e.RowIndex].Value.ToString();
            txtHours_Used.Text = dgvDataMonitoring[5, e.RowIndex].Value.ToString();
            txtRefill.Text = dgvDataMonitoring[6, e.RowIndex].Value.ToString();
            txtLocation.Text = dgvDataMonitoring[8, e.RowIndex].Value.ToString();
            */
        }
    }
}
