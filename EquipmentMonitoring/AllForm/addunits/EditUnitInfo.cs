using EquipmentMonitoring.ForReportForm.Forms;
using EquipmentMonitoring.Libs;
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

namespace EquipmentMonitoring.AllForm.addunits
{
    public partial class EditUnitInfo : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        DataTable result = new DataTable();
        public string userlogin { get; set; }
        public string Price { get; set; }
        public string TruckType { get; set; }
        public string FuelType { get; set; }
        public string PlateNo { get; set; }
        public string EngineNo { get; set; }
        public string ChasisNo { get; set; }
        public string PistonDis { get; set; }
        public string NoCylinders { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Make { get; set; }
        public string Series { get; set; }
        public string BodyType { get; set; }
        public string YearModel { get; set; }
        public string GrossWt { get; set; }
        public string EquipmentNo { get; set; }
        public string StatusofPurchase { get; set; }
        public string DateOfPurchase { get; set; }
        public string CRNo { get; set; }
        public string Supplier { get; set; }
        public string ExistingRead { get; set; }
        public string MVFile { get; set; }
        public string Register { get; set; }
        public string CurrentReading { get; set; }
        public string HourlyRate { get; set; }
        public string kmsltr { get; set; }


        DataSet datavalue;

        DataTable dtTire = new DataTable();
        DataTable dtBattery = new DataTable();

        public EditUnitInfo()
        {
            InitializeComponent();
        }

        public void Param(string pEquipmentNo, string pModel, string pPlateNo, DataTable DtUnitDetail, string userid)
        {

            CategoryParent();
            FuelCategory();

            string SEquipmentno = "'" + pEquipmentNo + "'";
            string SModel = "'" + pModel + "'";
            string SPlateno = "'" + pPlateNo + "'";
            string spName = "sp_Get_TruckInfo";

            //SqlDataReader reader;

            //reader = monitoring.ExecuteReader(spName, SEquipmentno, SModel, SPlateno);

            //result = DtUnitDetail;

            //result.Load(reader);

            userlogin = userid;

            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_TruckInfo '" + pEquipmentNo + "'," + "'" + pModel + "'," + "'" + pPlateNo + "'"));
            datavalue = dsKey;
            //DataTableReader drKey = dsKey.Tables[0].CreateDataReader();

            ////  NumberofTable = result.Rows[0]["NumberofTable"].ToString();
            //lblServiceId.Text = result.Rows[0]["ServiceID"].ToString();
            //cmbfuel.Text = result.Rows[0]["FuelType"].ToString();
            //txtPNModelName.Text = result.Rows[0]["PlateNo"].ToString();
            //txtEngineNo.Text = result.Rows[0]["EngineNo"].ToString();
            //txtChassisNo.Text = result.Rows[0]["ChassisNo"].ToString();
            //txtPiston.Text = result.Rows[0]["PistonDisplacement"].ToString();
            //txtCylinder.Text = result.Rows[0]["NoCylinder"].ToString();
            //txtEqpName.Text = result.Rows[0]["Model"].ToString();
            //cmbType.Text = result.Rows[0]["TruckType"].ToString();
            //txtMake.Text = result.Rows[0]["Make"].ToString();
            //txtSeries.Text = result.Rows[0]["Series"].ToString();
            //txtBodyType.Text = result.Rows[0]["BodyType"].ToString();
            //txtYearModel.Text = result.Rows[0]["YearModel"].ToString();
            //txtGrossWT.Text = result.Rows[0]["GrossWt"].ToString();
            //txtEqpNo.Text = result.Rows[0]["EquipmentNo"].ToString(); ;
            //cmbPurchase.Text = result.Rows[0]["StatusOfPurchase"].ToString(); ;
            //dtpPurchase.Text = result.Rows[0]["DateOfPurchase"].ToString(); ;
            //txtCRNo.Text = result.Rows[0]["CR_No"].ToString(); ;
            //txtSupplier.Text = result.Rows[0]["Supplier"].ToString(); ;
            //txtExisting.Text = result.Rows[0]["ExistingReadingKm"].ToString(); ;
            //txtMVFile.Text = result.Rows[0]["MVFile_No"].ToString(); ;
            //cmbMonth.Text = result.Rows[0]["Month_R_Expired"].ToString();
            //txtYear.Text = result.Rows[0]["Year_R_Expired"].ToString();
            //txtUnitPrice.Text = result.Rows[0]["UnitPrice"].ToString();
            //cmbType.Text = result.Rows[0]["Trucktype"].ToString();
            //txtCurrentReading.Text = result.Rows[0]["CurrentReading"].ToString();
            ////string[] SRegiter = pRegister.Split(' ');

            //CurrentReading = result.Rows[0]["CurrentReading"].ToString();
            //Price = result.Rows[0]["UnitPrice"].ToString();
            //TruckType = result.Rows[0]["Trucktype"].ToString();
            //FuelType = result.Rows[0]["FuelType"].ToString();
            //PlateNo = result.Rows[0]["PlateNo"].ToString();
            //EngineNo = result.Rows[0]["EngineNo"].ToString();
            //ChasisNo = result.Rows[0]["ChassisNo"].ToString();
            //PistonDis = result.Rows[0]["PistonDisplacement"].ToString();
            //NoCylinders = result.Rows[0]["NoCylinder"].ToString();
            //Model = result.Rows[0]["Model"].ToString();
            //Type = result.Rows[0]["TruckType"].ToString();
            //Make = result.Rows[0]["Make"].ToString();
            //Series = result.Rows[0]["Series"].ToString();
            //BodyType = result.Rows[0]["BodyType"].ToString();
            //YearModel = result.Rows[0]["YearModel"].ToString();
            //GrossWt = result.Rows[0]["GrossWt"].ToString();
            //EquipmentNo = result.Rows[0]["EquipmentNo"].ToString();
            //StatusofPurchase = result.Rows[0]["StatusOfPurchase"].ToString();
            //DateOfPurchase = result.Rows[0]["DateOfPurchase"].ToString();
            //CRNo = result.Rows[0]["CR_No"].ToString();
            //Supplier = result.Rows[0]["Supplier"].ToString();
            //ExistingRead = result.Rows[0]["ExistingReadingKm"].ToString();
            //MVFile = result.Rows[0]["MVFile_No"].ToString();
            //Register = result.Rows[0]["Month_R_Expired"].ToString() + " " + result.Rows[0]["Year_R_Expired"].ToString();

            ////////////

            //  NumberofTable = dsKey.Tables[0].Rows[0]["NumberofTable"].ToString();
            lblServiceId.Text = dsKey.Tables[0].Rows[0]["ServiceID"].ToString();
            cmbfuel.Text = dsKey.Tables[0].Rows[0]["FuelType"].ToString();
            txtPNModelName.Text = dsKey.Tables[0].Rows[0]["PlateNo"].ToString();
            txtEngineNo.Text = dsKey.Tables[0].Rows[0]["EngineNo"].ToString();
            txtChassisNo.Text = dsKey.Tables[0].Rows[0]["ChassisNo"].ToString();
            txtPiston.Text = dsKey.Tables[0].Rows[0]["PistonDisplacement"].ToString();
            txtCylinder.Text = dsKey.Tables[0].Rows[0]["NoCylinder"].ToString();
            txtEqpName.Text = dsKey.Tables[0].Rows[0]["Model"].ToString();
            cmbType.Text = dsKey.Tables[0].Rows[0]["TruckType"].ToString();
            txtMake.Text = dsKey.Tables[0].Rows[0]["Make"].ToString();
            txtSeries.Text = dsKey.Tables[0].Rows[0]["Series"].ToString();
            txtBodyType.Text = dsKey.Tables[0].Rows[0]["BodyType"].ToString();
            txtYearModel.Text = dsKey.Tables[0].Rows[0]["YearModel"].ToString();
            txtGrossWT.Text = dsKey.Tables[0].Rows[0]["GrossWt"].ToString();
            txtEqpNo.Text = dsKey.Tables[0].Rows[0]["EquipmentNo"].ToString(); ;
            cmbPurchase.Text = dsKey.Tables[0].Rows[0]["StatusOfPurchase"].ToString(); ;
            dtpPurchase.Text = dsKey.Tables[0].Rows[0]["DateOfPurchase"].ToString(); ;
            txtCRNo.Text = dsKey.Tables[0].Rows[0]["CR_No"].ToString(); ;
            txtSupplier.Text = dsKey.Tables[0].Rows[0]["Supplier"].ToString(); ;
            txtExisting.Text = dsKey.Tables[0].Rows[0]["ExistingReadingKm"].ToString(); ;
            txtMVFile.Text = dsKey.Tables[0].Rows[0]["MVFile_No"].ToString(); ;
            cmbMonth.Text = dsKey.Tables[0].Rows[0]["Month_R_Expired"].ToString();
            txtYear.Text = dsKey.Tables[0].Rows[0]["Year_R_Expired"].ToString();
            txtUnitPrice.Text = dsKey.Tables[0].Rows[0]["UnitPrice"].ToString();
            cmbType.Text = dsKey.Tables[0].Rows[0]["Trucktype"].ToString();
            txtCurrentReading.Text = dsKey.Tables[0].Rows[0]["CurrentReading"].ToString();
            txtHourlyRate.Text = dsKey.Tables[0].Rows[0]["HourlyRates"].ToString();
            txtkmltr.Text = dsKey.Tables[0].Rows[0]["km_ltr"].ToString();
            //string[] SRegiter = pRegister.Split(' ');

            CurrentReading = dsKey.Tables[0].Rows[0]["CurrentReading"].ToString();
            Price = dsKey.Tables[0].Rows[0]["UnitPrice"].ToString();
            TruckType = dsKey.Tables[0].Rows[0]["Trucktype"].ToString();
            FuelType = dsKey.Tables[0].Rows[0]["FuelType"].ToString();
            PlateNo = dsKey.Tables[0].Rows[0]["PlateNo"].ToString();
            EngineNo = dsKey.Tables[0].Rows[0]["EngineNo"].ToString();
            ChasisNo = dsKey.Tables[0].Rows[0]["ChassisNo"].ToString();
            PistonDis = dsKey.Tables[0].Rows[0]["PistonDisplacement"].ToString();
            NoCylinders = dsKey.Tables[0].Rows[0]["NoCylinder"].ToString();
            Model = dsKey.Tables[0].Rows[0]["Model"].ToString();
            Type = dsKey.Tables[0].Rows[0]["TruckType"].ToString();
            Make = dsKey.Tables[0].Rows[0]["Make"].ToString();
            Series = dsKey.Tables[0].Rows[0]["Series"].ToString();
            BodyType = dsKey.Tables[0].Rows[0]["BodyType"].ToString();
            YearModel = dsKey.Tables[0].Rows[0]["YearModel"].ToString();
            GrossWt = dsKey.Tables[0].Rows[0]["GrossWt"].ToString();
            EquipmentNo = dsKey.Tables[0].Rows[0]["EquipmentNo"].ToString();
            StatusofPurchase = dsKey.Tables[0].Rows[0]["StatusOfPurchase"].ToString();
            DateOfPurchase = dsKey.Tables[0].Rows[0]["DateOfPurchase"].ToString();
            CRNo = dsKey.Tables[0].Rows[0]["CR_No"].ToString();
            Supplier = dsKey.Tables[0].Rows[0]["Supplier"].ToString();
            ExistingRead = dsKey.Tables[0].Rows[0]["ExistingReadingKm"].ToString();
            MVFile = dsKey.Tables[0].Rows[0]["MVFile_No"].ToString();
            HourlyRate = dsKey.Tables[0].Rows[0]["HourlyRates"].ToString();
            Register = dsKey.Tables[0].Rows[0]["Month_R_Expired"].ToString() + " " + dsKey.Tables[0].Rows[0]["Year_R_Expired"].ToString();
            kmsltr = dsKey.Tables[0].Rows[0]["km_ltr"].ToString();


            string CountTire = "";
            string CountBattery = "";

            CountTire = dsKey.Tables[1].Rows[0]["CountTire"].ToString();
            CountBattery = dsKey.Tables[1].Rows[0]["CountBattery"].ToString();

            dgvTire.DataSource = null;

            if (this.dgvTire.DataSource != null)
            {
                this.dgvTire.DataSource = null;
            }
            else
            {
                this.dgvTire.Rows.Clear();
            }


            dgvBattery.DataSource = null;

            if (this.dgvBattery.DataSource != null)
            {
                this.dgvBattery.DataSource = null;
            }
            else
            {
                this.dgvBattery.Rows.Clear();
            }
            if (CountBattery != "0")
            {
                foreach (DataRow row in dsKey.Tables[3].Rows)
                {
                    dgvBattery.Rows.Add(row["BatteryID"].ToString()
                            , row["AllocationNo"].ToString()
                            , row["Item"].ToString()
                            , row["SerialNo"].ToString()
                            , row["PartsNo"].ToString()
                            );
                }
            }
            if (CountTire != "0")
            {
                foreach (DataRow row in dsKey.Tables[2].Rows)
                {
                    dgvTire.Rows.Add(row["TireID"].ToString()
                            , row["AllocationNo"].ToString()
                            , row["Item"].ToString()
                            , row["SerialNo"].ToString()
                            , row["PartsNo"].ToString()
                            );
                }
            }


            ///////
            /*
            cmbfuel.Text = pFuelType;
            txtPNModelName.Text = pPlateNo;
            txtEngineNo.Text = pEngineNo;
            txtChassisNo.Text = pChasisNo;
            txtPiston.Text = pPistonDis;
            txtCylinder.Text = pNoCylinders;
            txtEqpName.Text = pModel;
            cmbType.Text = pType;
            txtMake.Text = pMake;
            txtSeries.Text = pSeries;
            txtBodyType.Text = pBodyType;
            txtYearModel.Text = pYearModel;
            txtGrossWT.Text = pGrossWt;
            txtEqpNo.Text = pEquipmentNo;
            cmbPurchase.Text = pStatusofPurchase;
            dtpPurchase.Text = pDateOfPurchase;
            txtCRNo.Text = pCRNo;
            txtSupplier.Text = pSupplier;
            txtExisting.Text = pExistingRead;
            txtMVFile.Text = pMVFile;
            cmbMonth.Text = SRegiter[0];
            txtYear.Text = SRegiter[1];
            //Year = pYear;
            ///
            FuelType = pFuelType;
            PlateNo = pPlateNo;
            EngineNo = pEngineNo;
            ChasisNo = pChasisNo;
            PistonDis = pPistonDis;
            NoCylinders = pNoCylinders;
            Model = pModel;
            Type = pType;
            Make = pMake;
            Series = pSeries;
            BodyType = pBodyType;
            YearModel = pYearModel;
            GrossWt = pGrossWt;
            EquipmentNo = pEquipmentNo;
            StatusofPurchase = pStatusofPurchase;
            DateOfPurchase = pDateOfPurchase;
            CRNo = pCRNo;
            Supplier = pSupplier;
            ExistingRead = pExistingRead;
            MVFile = pMVFile;
            Register = pRegister;
            */
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

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //MessageBox.Show(cmbType.SelectedValue.ToString());
                string ServiceID = lblServiceId.Text;
                string id = "'" + lblServiceId.Text + "'";
                string pTruckType = " ";
                string pEquipmentNo = " ";
                string pModel = " ";
                string pPlateNumber = " ";
                string pEngineNo = "'" + txtEngineNo.Text + "'";
                string pChassisNo = "'" + txtChassisNo.Text + "'";
                string pPiston = "'" + txtPiston.Text + "'";
                string pCylinder = "'" + txtCylinder.Text + "'";
                string pMake = "'" + txtMake.Text + "'";
                string pSeries = "'" + txtSeries.Text + "'";
                string pBodyType = "'" + txtBodyType.Text + "'";
                string pGrossWT = "'" + txtGrossWT.Text + "'";
                string pYearModel = "'" + txtYearModel.Text + "'";
                string pPurchaseType = "'" + cmbPurchase.SelectedItem.ToString() + "'";
                string pDateofPurchase = "'" + dtpPurchase.Text + "'";
                string pSupplier = "'" + txtSupplier.Text + "'";
                string pCRno = "'" + txtCRNo.Text + "'";
                string pMVFileno = "'" + txtMVFile.Text + "'";
                string pExistingKmR = "'" + txtExisting.Text + "'";
                string pMonthExpired = "'" + cmbMonth.SelectedItem.ToString() + "'";
                string pYearExpired = "'" + txtYear.Text + "'";
                string pHourlyRate = "'" + txtHourlyRate.Text + "'";
                string kmltr = "'" + txtkmltr.Text + "'";

                string unitprice = "'" + txtUnitPrice.Text + "'";

                string ptempEquipmentNo = " ";
                string ptempEquipmentName = " ";
                string ptempPN_MN = " ";
                string spName = "sp_Update_Equipment";
                SqlDataReader reader;
                pTruckType = "'" + cmbType.SelectedValue.ToString() + "'";
                string pfueltype = "'" + cmbfuel.SelectedValue.ToString() + "'";
                string userloginid = "'" + userlogin + "'";


                pEquipmentNo = "'" + txtEqpNo.Text + "'";
                pModel = "'" + txtEqpName.Text + "'";
                pPlateNumber = "'" + txtPNModelName.Text + "'";
                ptempEquipmentNo = txtEqpNo.Text;
                ptempEquipmentName = txtEqpName.Text;
                ptempPN_MN = txtPNModelName.Text;

                reader = monitoring.ExecuteReader(spName, id, pTruckType, pEquipmentNo, pModel, pPlateNumber, pfueltype, pEngineNo, pChassisNo, pPiston, pCylinder, pMake, pSeries, pBodyType, pGrossWT, pYearModel, pPurchaseType, pDateofPurchase, pSupplier, pCRno, pMVFileno, pExistingKmR, pMonthExpired, pYearExpired, unitprice, pHourlyRate, kmltr, userloginid);
                DataTable result = new DataTable();
                result.Load(reader);
                string Result = result.Rows[0]["Result"].ToString();
                if (Result == "0")
                {
                    MessageBox.Show("Failed To Save..");
                }
                else if (Result == "1")
                {

                    /*
                        string AllocationNo = "";
                        string Brand = "";
                        string SerialNo = "";
                        string Itemid = "";

                         int Tcount = dgvTire.Rows.Count;
                        int Tloop = Tcount - 1;

                        int Bcount = dgvBattery.Rows.Count;
                        int Bloop = Bcount - 1;

                    using (SqlConnection con = new SqlConnection(Connection))
                    {
                        con.Open();

                        //Tire
                        if (chkTire.Checked == true)
                        {
                            for (int i = 0; i < Tloop; i++)
                            {
                                Itemid = dgvTire.Rows[i].Cells[0].FormattedValue.ToString();
                                AllocationNo = dgvTire.Rows[i].Cells[1].FormattedValue.ToString(); // dgvTire.Rows[i].Cells[0].FormattedValue.ToString());
                                Brand = dgvTire.Rows[i].Cells[2].FormattedValue.ToString();
                                SerialNo = dgvTire.Rows[i].Cells[3].FormattedValue.ToString();

                                using (SqlCommand cmdTire = new SqlCommand("sp_Update_EquipmentTire", con))
                                {
                                    cmdTire.CommandType = CommandType.StoredProcedure;

                                    cmdTire.Parameters.Add("@TireId", SqlDbType.VarChar).Value = Itemid;
                                    cmdTire.Parameters.Add("@AllocationNo", SqlDbType.VarChar).Value = AllocationNo;
                                    cmdTire.Parameters.Add("@Brand", SqlDbType.VarChar).Value = Brand;
                                    cmdTire.Parameters.Add("@SerialNo", SqlDbType.VarChar).Value = SerialNo;
                                    cmdTire.Parameters.Add("@ServiceID", SqlDbType.VarChar).Value = ServiceID;
                                    cmdTire.Parameters.Add("@userid", SqlDbType.VarChar).Value = userlogin;
                                    cmdTire.ExecuteNonQuery();
                                }
                            }
                        }

                        //Battery
                        if (chkBattery.Checked == true)
                        {
                            for (int i = 0; i < Bloop; i++)
                            {
                                Itemid = dgvBattery.Rows[i].Cells[0].FormattedValue.ToString();
                                AllocationNo = dgvBattery.Rows[i].Cells[1].FormattedValue.ToString(); // dgvTire.Rows[i].Cells[0].FormattedValue.ToString());
                                Brand = dgvBattery.Rows[i].Cells[2].FormattedValue.ToString();
                                SerialNo = dgvBattery.Rows[i].Cells[3].FormattedValue.ToString();

                                using (SqlCommand cmdTire = new SqlCommand("sp_Update_EquipmentBattery", con))
                                {
                                    cmdTire.CommandType = CommandType.StoredProcedure;

                                    cmdTire.Parameters.Add("@BatteryId", SqlDbType.VarChar).Value = Itemid;
                                    cmdTire.Parameters.Add("@AllocationNo", SqlDbType.VarChar).Value = AllocationNo;
                                    cmdTire.Parameters.Add("@Brand", SqlDbType.VarChar).Value = Brand;
                                    cmdTire.Parameters.Add("@SerialNo", SqlDbType.VarChar).Value = SerialNo;
                                    cmdTire.Parameters.Add("@ServiceID", SqlDbType.VarChar).Value = ServiceID;
                                    cmdTire.Parameters.Add("@userid", SqlDbType.VarChar).Value = userlogin;
                                    cmdTire.ExecuteNonQuery();
                                }
                            }
                        }

                       
                    }
                    */

                    MessageBox.Show("Successfully Saved..");

                    if (CurrentReading.Replace(".00", "").Replace(".0", "") == ExistingRead.Replace(".00", "").Replace(".0", ""))
                    {
                        CurrentReading = ((Convert.ToDecimal(CurrentReading.Replace(".00", "").Replace(".0", "")) - Convert.ToDecimal(ExistingRead.Replace(".00", "").Replace(".0", ""))) + Convert.ToDecimal(txtExisting.Text)).ToString();
                    }


                    FuelType = cmbfuel.SelectedValue.ToString();
                    PlateNo = txtPNModelName.Text;
                    EngineNo = txtEngineNo.Text;
                    ChasisNo = txtChassisNo.Text;
                    PistonDis = txtPiston.Text;
                    NoCylinders = txtCylinder.Text;
                    Model = txtEqpName.Text;
                    Type = cmbType.SelectedValue.ToString();
                    Make = txtMake.Text;
                    Series = txtSeries.Text;
                    BodyType = txtBodyType.Text;
                    YearModel = txtYearModel.Text;
                    GrossWt = txtGrossWT.Text;
                    EquipmentNo = txtEqpNo.Text;
                    StatusofPurchase = cmbPurchase.SelectedItem.ToString();
                    DateOfPurchase = dtpPurchase.Text;
                    CRNo = txtCRNo.Text;
                    Supplier = txtSupplier.Text;
                    ExistingRead = txtExisting.Text;
                    MVFile = txtMVFile.Text;
                    Register = cmbMonth.SelectedItem.ToString() + " " + txtYear.Text;
                    Price = txtUnitPrice.Text;
                    TruckType = cmbType.Text;
                    HourlyRate = txtHourlyRate.Text;
                    kmsltr = txtkmltr.Text;

                    txtCurrentReading.Text = CurrentReading;
                    //Convert.ToDecimal(ExistingRead);

                }
                else
                {
                    MessageBox.Show("Already Saved..");
                }

            }
        }

        private void BtnUnitPrintDetail_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show("Please wait...");
                UnitPrint unitformprint = new EquipmentMonitoring.ForReportForm.Forms.UnitPrint();
                //rMaintank.ShowDialog();
                unitformprint.Param(datavalue);
                unitformprint.Show();
            }
            catch
            {

            }
        }

        //private void chkTire_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (chkTire.Checked == true)
        //    {
        //        dgvTire.ReadOnly = false;
        //        //isCheck = "1";
        //    }
        //    else
        //    {
        //        dgvTire.ReadOnly = true;
        //        //isCheck = "0";
        //    }
        //}

        //private void chkBattery_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (chkBattery.Checked == true)
        //    {
        //        dgvBattery.ReadOnly = false;
        //        //isCheck = "1";
        //    }
        //    else
        //    {
        //        dgvBattery.ReadOnly = true;
        //        //isCheck = "0";
        //    }
        //}

        private void LblAddTire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string save = "0";
            AddUnitTire addtire = new AddUnitTire();
            addtire.param(userlogin, EquipmentNo, Model, PlateNo, DateOfPurchase, lblServiceId.Text);
            addtire.ShowDialog();
            save = addtire.IsSave;
            if (save == "1")
            {
                RefreshTire();
            }

            //string puserid, string pEquipmentNo, string pModel, string pPlateNo, string pDateOfPurchase, string pServiceID
        }

        private void LblAddBattery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string save = "0";
            AddUnitBattery addBattery = new AddUnitBattery();
            addBattery.param(userlogin, EquipmentNo, Model, PlateNo, DateOfPurchase, lblServiceId.Text);
            addBattery.ShowDialog();
            save = addBattery.IsSave;
            if (save == "1")
            {
                RefreshBattery();
            }
        }

        private void RefreshTire()
        {
            dgvTire.DataSource = null;

            if (this.dgvTire.DataSource != null)
            {
                this.dgvTire.DataSource = null;
            }
            else
            {
                this.dgvTire.Rows.Clear();
            }

            SqlDataReader reader;
            string ServiceIDTB = "'" + lblServiceId.Text + "'";
            string TypeRequest = "'" + "active" + "'";
            string spName = "sp_GetUnitTire";
            reader = monitoring.ExecuteReader(spName, ServiceIDTB, TypeRequest);
            DataTable Detail = new DataTable();
            Detail.Load(reader);

            foreach (DataRow row in Detail.Rows)
            {
                dgvTire.Rows.Add(row["TireID"].ToString()
                         , row["AllocationNo"].ToString()
                         , row["Item"].ToString()
                         , row["SerialNo"].ToString()
                         , row["PartsNo"].ToString()
                         );
            }
        }
        private void RefreshBattery()
        {

            dgvBattery.DataSource = null;

            if (this.dgvBattery.DataSource != null)
            {
                this.dgvBattery.DataSource = null;
            }
            else
            {
                this.dgvBattery.Rows.Clear();
            }
            SqlDataReader reader;
            string ServiceIDTB = "'" + lblServiceId.Text + "'";
            string TypeRequest = "'" + "active" + "'";
            string spName = "sp_GetUnitBattery";
            reader = monitoring.ExecuteReader(spName, ServiceIDTB, TypeRequest);
            DataTable Detail = new DataTable();
            Detail.Load(reader);

            foreach (DataRow row in Detail.Rows)
            {
                dgvBattery.Rows.Add(row["BatteryID"].ToString()
                         , row["AllocationNo"].ToString()
                         , row["Item"].ToString()
                         , row["SerialNo"].ToString()
                         , row["PartsNo"].ToString()
                         );
            }
        }
        /*
        public void Param(string pFuelType, string pPlateNo, string pEngineNo, string pChasisNo, string pPistonDis, string pNoCylinders, string pModel, string pType
                    , string pMake, string pSeries, string pBodyType, string pYearModel, string pGrossWt, string pEquipmentNo, string pStatusofPurchase, string pDateOfPurchase
                    , string pCRNo, string pSupplier, string pExistingRead, string pMVFile, string pRegister)
        {
            string[] SRegiter = pRegister.Split(' ');

            cmbfuel.Text = pFuelType;
            txtPNModelName.Text = pPlateNo;
            txtEngineNo.Text = pEngineNo;
            txtChassisNo.Text = pChasisNo;
            txtPiston.Text = pPistonDis;
            txtCylinder.Text = pNoCylinders;
            txtEqpName.Text = pModel;
            cmbType.Text = pType;
            txtMake.Text = pMake;
            txtSeries.Text = pSeries;
            txtBodyType.Text = pBodyType;
            txtYearModel.Text = pYearModel;
            txtGrossWT.Text = pGrossWt;
            txtEqpNo.Text = pEquipmentNo;
            cmbPurchase.Text = pStatusofPurchase;
            dtpPurchase.Text = pDateOfPurchase;
            txtCRNo.Text = pCRNo;
            txtSupplier.Text = pSupplier;
            txtExisting.Text = pExistingRead;
            txtMVFile.Text = pMVFile;
            cmbMonth.Text = SRegiter[0];
            txtYear.Text = SRegiter[1];
            //Year = pYear;
            ///
            FuelType = pFuelType;
            PlateNo = pPlateNo;
            EngineNo = pEngineNo;
            ChasisNo = pChasisNo;
            PistonDis = pPistonDis;
            NoCylinders = pNoCylinders;
            Model = pModel;
            Type = pType;
            Make = pMake;
            Series = pSeries;
            BodyType = pBodyType;
            YearModel = pYearModel;
            GrossWt = pGrossWt;
            EquipmentNo = pEquipmentNo;
            StatusofPurchase = pStatusofPurchase;
            DateOfPurchase = pDateOfPurchase;
            CRNo = pCRNo;
            Supplier = pSupplier;
            ExistingRead = pExistingRead;
            MVFile = pMVFile;
            Register = pRegister;
        }
        */
    }
}
