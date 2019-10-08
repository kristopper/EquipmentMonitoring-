using EquipmentMonitoring.AllForm.FuelForm.FuelPriceList;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentMonitoring.Libs;
using EquipmentMonitoring.AllForm.addunits;
using EquipmentMonitoring.ForReportForm.Forms;
using EquipmentMonitoring.AllForm.expenses;

namespace EquipmentMonitoring
{
    public partial class mainform : Form
    {

        GenericFunctions GenericFunc = new GenericFunctions();
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        ///count click in monitoring

        /* 
            FuelTankTypeList();
            TypeOfFuelList1();
            TankTypeList();
        */

        #region for rdlc

           //MainTank Log Sheet
           DataTable dtMaintankLabel = new DataTable(); // dtforlable
           DataTable dtMaintankGrid = new DataTable(); // forgrid

            //Tanker truck Log Sheet
            DataTable dtTankerTruckLabel = new DataTable(); // dtforlable
            DataTable dtTankerTruckGrid = new DataTable(); // forgrid

            //Unit Detail
            DataTable DrUnitDetail;

            //Truck monthly report
            DataTable dtTruckMonthlyLabel = new DataTable();
            DataTable dtTruckMonthlyGrid = new DataTable();

            //UnitExpenses
            DataTable dtUnitExpenses = new DataTable();
            DataTable dtUnitFuel = new DataTable();

        //string isAllMaintenanceCheck;


        DataTable dtAllExpenses = new DataTable();
        //Project site detail
        string mprojectid;
        string mprojectno;
        string mprojectsite;
        string mprojectdate;
        string mmonth;
        string myear;

        #endregion

        #region all setup

        int ckEmployee = 0;
        int ckPosition = 0;
        int ckTruckType = 0;
        int ckFuelType = 0;
        int ckTankType = 0;
        int ckCategory = 0;
        int ckProjectsite = 0;
        int isSubClick = 0;

        string isCheck = "0";
        string IsPMS = "0";

        string RepairAndMaintenanceIsPMS = "0";
        string status = "All";
        string SearchType = "EquipmentNo";
        string UnitSearchType = "EquipmentNo";
        string MaintenanceSearchType = "EquipmentNo";
        string MaintenanceHistorySearchType = "EquipmentNo";


        string TMonthlySearchType = "EquipmentNo";
        string PMonthlySearchType = "ProjectNo";
        string ProjectSiteSearchType = "ProjectNo";


        string TOverAllSearchType = "EquipmentNo";
        string POverAllSearchType = "ProjectNo";


        int btnsearchclick = 0;
        int countlnkViewExpense = 0;

        DataGridViewComboBoxColumn EmployeePositioncombo = new DataGridViewComboBoxColumn();
        DataGridViewComboBoxColumn FuelListcombo = new DataGridViewComboBoxColumn();
        DataGridViewComboBoxColumn Categorycombo = new DataGridViewComboBoxColumn();
        DataGridViewComboBoxColumn Tankcombo = new DataGridViewComboBoxColumn();

        DataTable dtPositionList = new DataTable();
        DataTable dtFuelList = new DataTable();
        DataTable dtTankList = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtCategoryNoAll = new DataTable();
        DataTable dtSubCategory = new DataTable();
        DataTable dtProjectSite = new DataTable();
        DataTable dtdata = new DataTable();
        DataTable dtUnitList = new DataTable();
        DataTable dtEmployeeList = new DataTable();

        SqlDataAdapter daData;

        ArrayList SearchPositionArray = new ArrayList();
        ArrayList EmployeeList = new ArrayList();
        ArrayList EquipArray = new ArrayList();
        ArrayList ProjectSiteArray = new ArrayList();

        AutoCompleteStringCollection EquipmentNoCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ModelNoCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection PlateNoCollection = new AutoCompleteStringCollection();

        AutoCompleteStringCollection Allunit = new AutoCompleteStringCollection();

        AutoCompleteStringCollection EmployeeText = new AutoCompleteStringCollection();
        AutoCompleteStringCollection EmployeeTextAll = new AutoCompleteStringCollection();


        AutoCompleteStringCollection ProjectNoCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProjectSiteCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProjectDateCollection = new AutoCompleteStringCollection();


        ArrayList rowCategory = new ArrayList();


        #endregion end all set up

        Login frmLogin = new Login();
        #region Fuel

        int ckMainLog = 0;
        int ckTankLog = 0;
        int ckRefilMain = 0;
        int ckAddDaily = 0;
        int UnitClick = 0;

        #endregion end Fuel

        string userlogin = "";
        string UserRoles = "0";
        string Isadmin = "0";

        #region Unit List

        int MaintenanceListClick = 0;
        int MaintenanceHistoryClick = 0;

        #endregion

        #region reports
        DataTable dtYearExpenses = new DataTable();
        #endregion

        public mainform()
        {
            InitializeComponent();

            employeeControl.BringToFront();
            dashBoardControl.BringToFront();
            dashBoardMenuControl.BringToFront();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;

            #region All Set-up

            lbMonitoringLast.Text = "employee";
            lblFuelLast.Text = "MainLog";
            lblUnitMenu.Text = "UnitList";
            ///all set up Panel
            allSetupControl.categorypanel.Hide();
            allSetupControl.PositionPanel.Hide();
            allSetupControl.TrucktypePanel.Hide();
            allSetupControl.FueltypePanel.Hide();
            allSetupControl.Tanktypepanel.Hide();
            allSetupControl.ProjectSitepanel.Hide();
            allSetupControl.EmployeePanel.Show();

            //POSITION
            positionControl.AddPositionGroup.Hide();
            positionControl.EditPosition.Hide();

            //EMPLOYEE
            employeeControl.AddEmployeeGroup.Hide();
            employeeControl.EditEmployee.Hide();
            employeeControl.cmbEmpSearchType.SelectedIndex = 0;

            //ForNEw Maintenance and Repair
            allMaintenanceExpenses.cmbMaintenanceType.SelectedIndex = 0;
            maintenanceAndRepair.cmbMaintenanceType.SelectedIndex = 0;
            maintenanceAndRepair.cmbstatus.SelectedIndex = 0;

            SearchEmployeeList(employeeControl.txtSearch.Text);
            EmpPositionList();
            EmployeePosition();
            EmployeeListAutoCompleteSearch();

            //TruckType
            truckTypeControl.adddisplayGroup.Hide();
            truckTypeControl.edittruckgroup.Hide();

            //FuelType
            fuelTypeControl.AddGroup.Hide();
            fuelTypeControl.EditGroup.Hide();

            //TankType
            tankTypeControl.AddGroup.Hide();
            tankTypeControl.EditGroup.Hide();
            FuelTankTypeList();
            TypeOfFuelList1();
            TankTypeList();

            //Category
            categoryControl.EditCategoryGroup.Hide();
            categoryControl.AddSubCategoryGroup.Hide();
            categoryControl.AddCategoryGroup.Hide();
            CategorysList();

            //Project Site
            projectSiteControl.AddGroup.Hide();
            projectSiteControl.EditGroup.Hide();
            projectSiteControl.cmbProject.SelectedIndex = 0;
            ProjectSiteList(projectSiteControl.txtSearch.Text);

            #endregion end All Set-up



            unitListDetail.lnkFuel.LinkColor = Color.Red;
            // unitListDetail.lnkExpenses.ForeColor = Color.Black;
            unitListDetail.lnkExpenses.LinkColor = Color.Black;

            #region Fuel

            fuelMenuControl.MainFuelLogPanel.Show();
            fuelMenuControl.tankerfuellogpanel.Hide();
            fuelMenuControl.RefillMainPanel.Hide();
            fuelMenuControl.AddDailyPanel.Hide();
            fuelMenuControl.FuelPricePanel.Hide();

            mainRefillControl.dtpStart.Value = DateTime.Now.AddDays(-300);
            maintenanceAndRepair.dtfrom.Value = DateTime.Now.AddDays(-30);

            //Refill Main
            RefillFuelList();
            mainRefillControl.dgvRefillList.Columns[2].DefaultCellStyle.Format = "###,###,###,##0.00";
            mainRefillControl.dgvRefillList.Columns[3].DefaultCellStyle.Format = "###,###,###,##0.00";


            #endregion end Fuel


            #region UnitList

            //Unit List
            GetServiceUnit();
            unitMenuControl.maintenancehistorypanel.Hide();
            unitMenuControl.ExpensesPanel.Hide();
            unitMenuControl.MaintenanceListPanel.Hide();
            unitMenuControl.UnitListPanel.Show();
            unitListControl.cmbTruckType.SelectedIndex = 0;
            unitListControl.cmbUnitList.SelectedIndex = 0;

            unitListDetail.lnkFuel.ForeColor = Color.Red;

            unitListDetail.expensesViewControl.dgvEMaintenance.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dgvMaintenance.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            allMaintenanceExpenses.cmbstatus.SelectedIndex = 0;
            allMaintenanceExpenses.cmbSearchType.SelectedIndex = 0;


            maintenanceAndRepair.cmbstatus.SelectedIndex = 0;
            //maintenanceAndRepair.cmbSearchType.SelectedIndex = 0;

            unitListDetail.expensesViewControl.dtpEFromDate.Value = DateTime.Now.AddDays(-300);
            unitListDetail.fuelViewControl.dtpFFromDate.Value = DateTime.Now.AddDays(-45);

            //WRAP TEXT
            allMaintenanceExpenses.dgvExpenses.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            allMaintenanceExpenses.dgvExpenses.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            allMaintenanceExpenses.dgvExpenses.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            allMaintenanceExpenses.dgvExpenses.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            //WRAP TEXT
            maintenanceAndRepair.dgvExpenses.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            maintenanceAndRepair.dgvExpenses.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            maintenanceAndRepair.dgvExpenses.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            maintenanceAndRepair.dgvExpenses.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            maintenanceAndRepair.dgvExpenses.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            //MAintenance List

            maintenanceListControl.cmbUnitList.SelectedIndex = 0;
            mainHistoryControl.cmbUnitList.SelectedIndex = 0;

            #endregion

            #region DashBoard
            Param();
            GetFuelLimit();
            LtoRegistration();
            #endregion

            #region Reports

            YearList();
            reportsControl.panelMonthlyReport.Show();
            reportsControl.panelDailyReport.Hide();
            reportsControl.panelOverAllReport.Hide();
            lblReportMainLast.Text = "Monthly";
            lblReportMonthlyLast.Text = "Truck";
            lblReportOverAllLast.Text = "Truck";

            //Monthly
            #region Report Monthly

            //Truck
            monthlyFormControl.truckMonthlyControl.cmbFromMonth.SelectedIndex = 0;
            monthlyFormControl.truckMonthlyControl.cmbUnitList.SelectedIndex = 0;

            //Project
            monthlyFormControl.projectSiteMonthlyControl.cmbProject.SelectedIndex = 0;
            monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.SelectedIndex = 0;

            #endregion

            //Overall
            #region Overall Report

            //Truck
            overallReportControl.truckOverallExpensesControl.cmbUnitList.SelectedIndex = 0;

            //Project

            overallReportControl.projectSiteOverAllControl.cmbProject.SelectedIndex = 0;
            // overallReportControl.p.cmbProject.SelectedIndex = 0;


            #endregion

            #endregion
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
            /*
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
            */
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            frmLogin.ShowDialog(this);
            if (frmLogin.IsLogin == "0")
            {
                this.Close();
            }
            else
            {
                if (frmLogin.IsResetPassword.ToLower() == "true")
                {
                    ChangePassword changepass = new ChangePassword();
                    changepass.Param(frmLogin.strReturnUser);
                    changepass.ShowDialog(this);
                    string result = changepass.ChangeResult;

                    if (result != "0")
                    {
                        this.Close();
                    }
                    else
                    {
                        #region All Set-up


                        userlogin = frmLogin.strReturnUser;
                        Isadmin = frmLogin.IsAdmin;


                        UserRoles = frmLogin.UserRole;

                        if (UserRoles == "1" | UserRoles == "2")
                        {
                            UpdateAccounttoolStrip.Enabled = true;
                            changePasswordToolStripMenuItem.Enabled = true;
                            CreateaccountToolStrip.Enabled = true;
                            maintenanceAndRepair.dgvExpenses.Columns[9].Visible = true;

                        }
                        else
                        {
                            UpdateAccounttoolStrip.Enabled = false;
                            changePasswordToolStripMenuItem.Enabled = true;
                            CreateaccountToolStrip.Enabled = false;
                            maintenanceAndRepair.dgvExpenses.Columns[9].Visible = false;

                        }

                        //Menu Button
                        allSetupControl.btnCategory.Click += btnCategory;
                        allSetupControl.btnEmployeeList.Click += btnEmployeeList;
                        allSetupControl.btnPosition.Click += btnPosition;
                        allSetupControl.btnTruckType.Click += btnTruckType;
                        allSetupControl.btnFuelType.Click += btnFuelType;
                        allSetupControl.btnTankType.Click += btnTankType;
                        allSetupControl.btnProjectSite.Click += btnProjectSite;

                        //////Position
                        positionControl.btnSearch.Click += positionbtnSearch;
                        positionControl.btnSave.Click += positionbtnSave;
                        positionControl.btnCancel.Click += positionbtnCancel;
                        positionControl.btnAddSave.Click += positionbtnAddSave;
                        positionControl.lnkDelete.Click += positionlnkDelete;
                        positionControl.lnkAddposition.Click += positionlnkAddposition;
                        positionControl.btnAddCancel.Click += positionbtnAddCancel;
                        positionControl.dgvPosition.CellDoubleClick += dgvPosition_DoubleClick;
                        positionControl.txtSearch.KeyDown += PositiontxtSearch_KeyDown;
                        // positionControl.txtSearch.KeyPress += PositiontxtSearch_KeyPress;

                        /////Employee
                        employeeControl.btnSearch.Click += employeebtnSearch;
                        employeeControl.btnSave.Click += employeebtnSave;
                        employeeControl.btnAddSave.Click += EmployeebtnAddSave;
                        employeeControl.lnkAddemployee.Click += EmployeelnkEmployee;
                        employeeControl.btnAddCancel.Click += employeebtnAddCancel;
                        employeeControl.dgvEmployeeList.CellDoubleClick += dgvEmployeeList_DoubleClick;
                        employeeControl.btnCancel.Click += employeebtnCancel;
                        employeeControl.dgvAddEmployee.EditingControlShowing += dvgAddEmployee__EditingControlShowing;
                        employeeControl.lnkDelete.Click += employeelnkDelete;
                        employeeControl.txtSearch.KeyDown += employeetxtSearch_KeyDown;

                        //TruckType
                        truckTypeControl.lnkAddTruck.Click += TrucklnkAdd;
                        truckTypeControl.btnAddCancel.Click += truckTypebtnAddCancel;
                        truckTypeControl.btnAddSave.Click += trucktypeAddbtnSave;
                        truckTypeControl.dgvTruckTypeList.CellDoubleClick += dgvTruckTypeList_DoubleClick;
                        truckTypeControl.btnCancel.Click += truckTypebtnCancel;
                        truckTypeControl.btnSave.Click += truckTypebtnSave;
                        truckTypeControl.lnkDelete.Click += truckTypelnkDelete;

                        //FuelType
                        fuelTypeControl.lnkAddFuel.Click += fuelTypeAdd;
                        fuelTypeControl.btnaddCancel.Click += fuelTypebtnAddCancel;
                        fuelTypeControl.btnaddSave.Click += fuelTypeAddbtnSave;
                        fuelTypeControl.dgvFuelList.CellDoubleClick += dgvFuelList_DoubleClick;
                        fuelTypeControl.btnCancel.Click += fuelTypebtnCancel;
                        fuelTypeControl.btnSave.Click += FuelTypebtnSave;
                        fuelTypeControl.lnkDelete.Click += fuelTypelnkDelete;

                        //Tank Type
                        tankTypeControl.lnkAddTankType.Click += tankTypeAdd;
                        tankTypeControl.btnAddCancel.Click += tankTypebtnAddCancel;
                        tankTypeControl.btnAddSave.Click += tankTypeAddbtnSave;
                        tankTypeControl.dgvTankType.CellDoubleClick += dgvTankType_DoubleClick;
                        tankTypeControl.btnCancel.Click += tankTypebtnCancel;
                        tankTypeControl.btnSave.Click += tankTypebtnSave;
                        tankTypeControl.lnkDelete.Click += tankTypelnkDelete;

                        //Category
                        categoryControl.lnkAddCategory.Click += categoryTypeAdd;
                        categoryControl.lnkAddSubCategory.Click += SubcategoryTypeAdd;
                        categoryControl.btnAddCancel.Click += CategorybtnAddCancel;
                        categoryControl.btnSubCancel.Click += SubbtnSubCancel;
                        categoryControl.dgvCategory.CellDoubleClick += dgvCategory_DoubleClick;
                        categoryControl.btnEditCancel.Click += categorybtnCancel;
                        categoryControl.btnAddSave.Click += categoryddbtnSave;
                        categoryControl.btnSubSave.Click += categorySubaddbtnSave;
                        categoryControl.btnEditSave.Click += categorybtnSave;
                        categoryControl.lnkEditCategory.LinkClicked += lnkEditCategory_LinkClicked;
                        categoryControl.lnkDelete.Click += categorylnkDelete;
                        categoryControl.btnSearch.Click += categorySearch;


                        //Project Site
                        projectSiteControl.lnkAddProject.Click += ProjectAddLnk;
                        projectSiteControl.btnAddCancel.Click += ProjectbtnAddCancel;
                        projectSiteControl.btnAddSave.Click += ProjectbtnAddSave;
                        projectSiteControl.btnSearch.Click += ProjectbtnSearch;
                        projectSiteControl.txtSearch.KeyDown += ProjectSitetxtSearch_KeyDown;
                        projectSiteControl.dgvProjectList.CellDoubleClick += dgvProjectList_DoubleClick;
                        projectSiteControl.btnEditCancel.Click += projectSitebtnCancel;
                        projectSiteControl.btnEditSave.Click += projectSitebtnSave;
                        projectSiteControl.lnkDelete.Click += projectSitelnkDelete;

                        projectSiteControl.cmbProject.SelectedIndexChanged += cmbProjectSiteSearchType_SelectedIndexChanged;


                        #region dashboard
                        dashBoardControl.btnDBLTO.Click += refreshLToregister;

                        dashBoardControl.btnRefreshMaintenancelist.Click += refreshMaintenanceList;
                        dashBoardControl.btnDFuelLimit.Click += MaintankLimit;

                        dashBoardControl.dgvLtoRegister.CellDoubleClick += LtoRegister_CellDoubleClick;

                        dashBoardControl.dgvMaintenanceList.CellDoubleClick += DMaintenanceList_CellDoubleClick;


                        #endregion


                        #endregion end All Set-up


                        #region Fuel

                        //Menu Button
                        fuelMenuControl.btnMainFuelLog.Click += btnMainFuelLog;
                        fuelMenuControl.btnTankerFuellog.Click += btnTankerFuellog;
                        fuelMenuControl.btnRefillMain.Click += btnRefillMain;
                        fuelMenuControl.btnAddDaily.Click += btnAddDaily;


                        //Mainrefill
                        mainRefillControl.txtPrice.KeyPress += txtPrice_KeyPress;
                        mainRefillControl.txtLiters.KeyPress += txtLiters_KeyPress;
                        mainRefillControl.txtPrice.KeyDown += txtPrice_Keydown;
                        mainRefillControl.txtLiters.KeyDown += txtLiters_Keydown;
                        mainRefillControl.lnkdefault.LinkClicked += lnkdefault_LinkClicked;
                        mainRefillControl.btnSave.Click += btnSave_Click;


                        //Fuel Price List
                        mainRefillControl.btnSearch.Click += btnSearch_Click;
                        mainRefillControl.btnAll.Click += btnAll_Click;
                        mainRefillControl.dgvRefillList.CellValueChanged += dgvRefillList_CellValueChanged;
                        mainRefillControl.dgvRefillList.CellDoubleClick += dgvRefillList_DoubleClick;


                        ///Add Daily
                        addDailyControl.dgvDailySheet.EditingControlShowing += dgvDailySheet__EditingControlShowing;
                        addDailyControl.btnSave.Click += DailybtnSave_Click;


                        //Main Tank Log
                        fuelMainLogControl.btnSearch.Click += MainLogbtnSearchbtnSave_Click;
                        fuelMainLogControl.cmbfueltype.SelectedIndexChanged += fuelMainFuelChange;
                        fuelMainLogControl.cmbTanktruck.SelectedIndexChanged += fuelMainTanktruckChange;
                        fuelMainLogControl.btnRefresh.Click += btnRefresh;
                        fuelMainLogControl.btnFuelMainLogprint.Click += btnFuelMainLogprint;

                        fuelMainLogControl.dgvTankLog.CellDoubleClick += dgvTankLog_CellDoubleClick;


                        //Tanker truck Log
                        fuelTankerLogControl.btnSearch.Click += TankerLogbtnSearchbtnSave_Click;
                        fuelTankerLogControl.cmbfueltype.SelectedIndexChanged += fueltankerFuelChange;
                        fuelTankerLogControl.cmbfueltype.SelectedIndexChanged += fueltankerFuelChange;
                        fuelTankerLogControl.cmbTanktruck.SelectedIndexChanged += fueltankerTanktruckChange;
                        fuelTankerLogControl.dgvTankLog.CellDoubleClick += dgvTankerLog_CellDoubleClick;
                        fuelTankerLogControl.btnFuelTankerLogprint.Click += btnFuelTankerLogprint;




                        #endregion end Fuel


                        #region  Units

                        //Units Button
                        unitMenuControl.btnUnitList.Click += MenubtnMenuUnitList;
                        unitMenuControl.btnMaintenanceList.Click += btnMaintenanceList;
                        unitMenuControl.btnExpenses.Click += btnExpenses;
                        unitMenuControl.btnMaintenanceHistory.Click += btnMaintenanceHistory;

                        //ForAdd

                        //Expenses
                        allMaintenanceExpenses.btnSearch.Click += ExpensesbtnSearch_old_Click;
                        allMaintenanceExpenses.cmbstatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
                        allMaintenanceExpenses.cmbSearchType.SelectedIndexChanged += cmbSearchType_SelectedIndexChanged;
                        allMaintenanceExpenses.chkFilter.CheckedChanged += chkFilter_CheckedChanged;
                        allMaintenanceExpenses.dgvExpenses.CellDoubleClick += dgvExpenses_Old_CellDoubleClick;
                        allMaintenanceExpenses.dgvExpenses.CellClick += dgvExpenses_CellClick;
                        allMaintenanceExpenses.btnAllExpensesPrint.Click += btnAllExpensesPrint;
                        allMaintenanceExpenses.lbladdExpenses.LinkClicked += lbladdExpenses_LinkClicked;

                        //new REpair and Expenses



                        maintenanceAndRepair.chkPMS.CheckedChanged += chkPMS_CheckedChanged;

                        maintenanceAndRepair.dgvExpenses.CellDoubleClick += dgvExpenses_CellDoubleClick;
                        maintenanceAndRepair.btnSearch.Click += ExpensesbtnSearch_Click;
                        maintenanceAndRepair.cmbstatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
                        maintenanceAndRepair.chkFilter.CheckedChanged += chkFilter_CheckedChanged;
                        maintenanceAndRepair.lbladdExpenses.LinkClicked += lbladdExpenses_LinkClicked;


                        maintenanceAndRepair.dgvExpenses.CellClick += dgvExpenses_CellClick;

                        maintenanceAndRepair.chkPMS.CheckedChanged += chkPMS_CheckedChanged;


                        maintenanceAndRepair.btnAllExpensesPrint.Click += btnAllExpensesPrint;


                        allMaintenanceExpenses.btnAllExpensesPrint.Click += btnAllExpensesPrint;

                        //UNIts
                        unitListControl.lbladdsingleUnit.LinkClicked += lbladdsingleUnit_LinkClicked;

                        unitListControl.cmbUnitList.SelectedIndexChanged += cmbUnitList_SelectedIndexChanged;

                        //lnkFuel
                        unitListDetail.lnkFuel.LinkClicked += lnkFuelview_LinkClicked;
                        //lnkExpenses
                        unitListDetail.lnkExpenses.LinkClicked += lnkExpensesView_LinkClicked;
                        unitListControl.btnSearch.Click += UnitControlbtnSearch_Click;

                        unitListControl.txtSearch.KeyDown += UnitControltxtSearch_KeyDown;
                        unitListControl.dgvUnitListitem.CellDoubleClick += dgvUnitListitem_CellDoubleClick;


                        unitListDetail.lnkBack.LinkClicked += UnitlnkBack_LinkClicked;
                        unitListDetail.fuelViewControl.btnFSearch.Click += FuelViewbtnFSearch;
                        unitListDetail.fuelViewControl.dgvDataMonitoring.CellDoubleClick += dgvDataMonitoring_CellDoubleClick;
                        unitListDetail.fuelViewControl.btnUnitMaintenance.Click += btnUnitMaintenance_Click;
                        unitListDetail.fuelViewControl.btnUnitDetailRefresh.Click += btnUnitDetailRefresh_Click;
                        unitListDetail.fuelViewControl.btnFDelete.Click += btnUnitmonitoringDelete_Click;
                        unitListDetail.expensesViewControl.cmbECategory.SelectedIndexChanged += expensesViewControlcmbECategory_SelectedIndexChanged;
                        unitListDetail.lnkEditUnitInfo.LinkClicked += UnitEditClick_LinkClicked;

                        unitListDetail.fuelViewControl.btnUnitFuelPrint.Click += btnUnitFuelPrint;

                        unitListDetail.expensesViewControl.btnUnitExpensesPrint.Click += btnUnitExpensesPrint;
                        unitListDetail.expensesViewControl.btnEDelete.Click += btnexpensesunitDelete_Click;
                        unitListDetail.expensesViewControl.btnESearch.Click += ExpensesViewbtnFSearch_Click;


                        //dgvMaintenance_CellDoubleClick
                        maintenanceListControl.dgvMaintenance.CellDoubleClick += dgvMaintenance_CellDoubleClick;
                        maintenanceListControl.cmbUnitList.SelectedIndexChanged += cmbMaintenanceSearchType_SelectedIndexChanged;
                        maintenanceListControl.btnSearch.Click += MainteListbtnSearch_Click;
                        maintenanceListControl.txtSearch.KeyDown += MaintenancetxtSearch_KeyDown;
                        ////
                        ///
                        mainHistoryControl.dgvMaintenance.CellDoubleClick += dgvMaintenanceHistory_CellDoubleClick;
                        // unitListDetail.fuelViewControl.dgvDataMonitoring.CellDoubleClick += dgvDataMonitoring_CellDoubleClick;


                        //

                        ////////////////
                        #region maintenance History List

                        mainHistoryControl.cmbUnitList.SelectedIndexChanged += cmbMainHistorySearchType_SelectedIndexChanged;
                        mainHistoryControl.btnSearch.Click += MainteHistorybtnSearch_Click;
                        mainHistoryControl.txtSearch.KeyDown += MainHistorytxtSearch_KeyDown;
                        //    maintenanceListControl.cmbUnitList.SelectedIndexChanged += cmbMaintenanceList_SelectedIndexChanged;

                        #endregion


                        #endregion end Units





                        #region reports

                        //Main Menu Report
                        //  btnMonthlyReport
                        reportsControl.btnDailyReport.Click += btnDailyReport_Click;
                        reportsControl.btnMonthlyReport.Click += btnMonthlyReport_Click;
                        reportsControl.btnOverAllReport.Click += btnOverAllReport_Click;

                        //Truck Monthly 
                        monthlyFormControl.truckMonthlyControl.cmbUnitList.SelectedIndexChanged += cmbTMExpensesSearchType_SelectedIndexChanged;
                        monthlyFormControl.btnTruckandHeavy.Click += btnTruckMontlyExpenses_Click;
                        monthlyFormControl.truckMonthlyControl.btnSearch.Click += btnTruckMonthlySearch_Click;
                        monthlyFormControl.truckMonthlyControl.btnTruckMonthlyprint.Click += btnTruckMonthlyprint;

                        //ProjectSite Monthly
                        monthlyFormControl.projectSiteMonthlyControl.cmbProject.SelectedIndexChanged += cmbProExpensesSearchType_SelectedIndexChanged;
                        monthlyFormControl.btnProjectSiteMonthly.Click += btnProjectsiteMontlyExpenses_Click;
                        monthlyFormControl.projectSiteMonthlyControl.btnSearch.Click += btnProjectMonthlySearch_Click;
                        monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.CellDoubleClick += dgvProjectMonthlyList_CellDoubleClick;

                        monthlyFormControl.projectSiteMonthlyControl.btnProjectSiteMonthlyprint.Click += btnProjectSiteMonthlyprint;

                        monthlyFormControl.projectSiteEquipmentM.lnkBack.LinkClicked += ProjectDetail_lnkClick;


                        monthlyFormControl.projectSiteEquipmentM.btnProjectSiteDetail.Click += btnProjectSiteDetail;



                        //Truck Overall
                        overallReportControl.truckOverallExpensesControl.cmbUnitList.SelectedIndexChanged += cmbTOExpensesSearchType_SelectedIndexChanged;
                        overallReportControl.truckOverallExpensesControl.btnSearch.Click += btnTruckOverAllSearch_Click;
                        overallReportControl.btnTruckandHeavy.Click += btnTruckOverAllExpenses_Click;
                        overallReportControl.truckOverallExpensesControl.btnTruckOverallprint.Click += btnTruckOverallprint;



                        //Project OverAll
                        overallReportControl.projectSiteOverAllControl.cmbProject.SelectedIndexChanged += cmbProOverAllExpensesSearchType_SelectedIndexChanged;
                        overallReportControl.btnProjectsiteoverall.Click += btnProjectsiteOverAllExpenses_Click;
                        overallReportControl.projectSiteOverAllControl.btnSearch.Click += btnProjectOverAllSearch_Click;


                        overallReportControl.projectSiteOverAllControl.btnProjectSiteOverallreport.Click += btnProjectSiteOverallreport;


                        #endregion
                    }
                }
                else
                {

                    userlogin = frmLogin.strReturnUser;
                    Isadmin = frmLogin.IsAdmin;
                    UserRoles = frmLogin.UserRole;

                    if (UserRoles == "1" | UserRoles == "2")
                    {
                        UpdateAccounttoolStrip.Enabled = true;
                        changePasswordToolStripMenuItem.Enabled = true;
                        CreateaccountToolStrip.Enabled = true;
                        maintenanceAndRepair.dgvExpenses.Columns[9].Visible = true;
                    }
                    else
                    {
                        UpdateAccounttoolStrip.Enabled = false;
                        changePasswordToolStripMenuItem.Enabled = true;
                        CreateaccountToolStrip.Enabled = false;
                        maintenanceAndRepair.dgvExpenses.Columns[9].Visible = false;
                    }

                    #region All Set-up

                    //Menu Button
                    allSetupControl.btnCategory.Click += btnCategory;
                    allSetupControl.btnEmployeeList.Click += btnEmployeeList;
                    allSetupControl.btnPosition.Click += btnPosition;
                    allSetupControl.btnTruckType.Click += btnTruckType;
                    allSetupControl.btnFuelType.Click += btnFuelType;
                    allSetupControl.btnTankType.Click += btnTankType;
                    allSetupControl.btnProjectSite.Click += btnProjectSite;

                    //////Position
                    positionControl.btnSearch.Click += positionbtnSearch;
                    positionControl.btnSave.Click += positionbtnSave;
                    positionControl.btnCancel.Click += positionbtnCancel;
                    positionControl.btnAddSave.Click += positionbtnAddSave;
                    positionControl.lnkDelete.Click += positionlnkDelete;
                    positionControl.lnkAddposition.Click += positionlnkAddposition;
                    positionControl.btnAddCancel.Click += positionbtnAddCancel;
                    positionControl.dgvPosition.CellDoubleClick += dgvPosition_DoubleClick;
                    positionControl.txtSearch.KeyDown += PositiontxtSearch_KeyDown;
                    // positionControl.txtSearch.KeyPress += PositiontxtSearch_KeyPress;

                    /////Employee
                    employeeControl.btnSearch.Click += employeebtnSearch;
                    employeeControl.btnSave.Click += employeebtnSave;
                    employeeControl.btnAddSave.Click += EmployeebtnAddSave;
                    employeeControl.lnkAddemployee.Click += EmployeelnkEmployee;
                    employeeControl.btnAddCancel.Click += employeebtnAddCancel;
                    employeeControl.dgvEmployeeList.CellDoubleClick += dgvEmployeeList_DoubleClick;
                    employeeControl.btnCancel.Click += employeebtnCancel;
                    employeeControl.dgvAddEmployee.EditingControlShowing += dvgAddEmployee__EditingControlShowing;
                    employeeControl.lnkDelete.Click += employeelnkDelete;
                    employeeControl.txtSearch.KeyDown += employeetxtSearch_KeyDown;

                    //TruckType
                    truckTypeControl.lnkAddTruck.Click += TrucklnkAdd;
                    truckTypeControl.btnAddCancel.Click += truckTypebtnAddCancel;
                    truckTypeControl.btnAddSave.Click += trucktypeAddbtnSave;
                    truckTypeControl.dgvTruckTypeList.CellDoubleClick += dgvTruckTypeList_DoubleClick;
                    truckTypeControl.btnCancel.Click += truckTypebtnCancel;
                    truckTypeControl.btnSave.Click += truckTypebtnSave;
                    truckTypeControl.lnkDelete.Click += truckTypelnkDelete;

                    //FuelType
                    fuelTypeControl.lnkAddFuel.Click += fuelTypeAdd;
                    fuelTypeControl.btnaddCancel.Click += fuelTypebtnAddCancel;
                    fuelTypeControl.btnaddSave.Click += fuelTypeAddbtnSave;
                    fuelTypeControl.dgvFuelList.CellDoubleClick += dgvFuelList_DoubleClick;
                    fuelTypeControl.btnCancel.Click += fuelTypebtnCancel;
                    fuelTypeControl.btnSave.Click += FuelTypebtnSave;
                    fuelTypeControl.lnkDelete.Click += fuelTypelnkDelete;

                    //Tank Type
                    tankTypeControl.lnkAddTankType.Click += tankTypeAdd;
                    tankTypeControl.btnAddCancel.Click += tankTypebtnAddCancel;
                    tankTypeControl.btnAddSave.Click += tankTypeAddbtnSave;
                    tankTypeControl.dgvTankType.CellDoubleClick += dgvTankType_DoubleClick;
                    tankTypeControl.btnCancel.Click += tankTypebtnCancel;
                    tankTypeControl.btnSave.Click += tankTypebtnSave;
                    tankTypeControl.lnkDelete.Click += tankTypelnkDelete;

                    //Category
                    categoryControl.lnkAddCategory.Click += categoryTypeAdd;
                    categoryControl.lnkAddSubCategory.Click += SubcategoryTypeAdd;
                    categoryControl.btnAddCancel.Click += CategorybtnAddCancel;
                    categoryControl.btnSubCancel.Click += SubbtnSubCancel;
                    categoryControl.dgvCategory.CellDoubleClick += dgvCategory_DoubleClick;
                    categoryControl.btnEditCancel.Click += categorybtnCancel;
                    categoryControl.btnAddSave.Click += categoryddbtnSave;
                    categoryControl.btnSubSave.Click += categorySubaddbtnSave;
                    categoryControl.btnEditSave.Click += categorybtnSave;
                    categoryControl.lnkEditCategory.LinkClicked += lnkEditCategory_LinkClicked;
                    categoryControl.lnkDelete.Click += categorylnkDelete;
                    categoryControl.btnSearch.Click += categorySearch;


                    //Project Site
                    projectSiteControl.lnkAddProject.Click += ProjectAddLnk;
                    projectSiteControl.btnAddCancel.Click += ProjectbtnAddCancel;
                    projectSiteControl.btnAddSave.Click += ProjectbtnAddSave;
                    projectSiteControl.btnSearch.Click += ProjectbtnSearch;
                    projectSiteControl.txtSearch.KeyDown += ProjectSitetxtSearch_KeyDown;
                    projectSiteControl.dgvProjectList.CellDoubleClick += dgvProjectList_DoubleClick;
                    projectSiteControl.btnEditCancel.Click += projectSitebtnCancel;
                    projectSiteControl.btnEditSave.Click += projectSitebtnSave;
                    projectSiteControl.lnkDelete.Click += projectSitelnkDelete;

                    projectSiteControl.cmbProject.SelectedIndexChanged += cmbProjectSiteSearchType_SelectedIndexChanged;


                    #region dashboard
                    dashBoardControl.btnDBLTO.Click += refreshLToregister;

                    dashBoardControl.btnRefreshMaintenancelist.Click += refreshMaintenanceList;
                    dashBoardControl.btnDFuelLimit.Click += MaintankLimit;

                    dashBoardControl.dgvLtoRegister.CellDoubleClick += LtoRegister_CellDoubleClick;

                    dashBoardControl.dgvMaintenanceList.CellDoubleClick += DMaintenanceList_CellDoubleClick;


                    #endregion


                    #endregion end All Set-up


                    #region Fuel

                    //Menu Button
                    fuelMenuControl.btnMainFuelLog.Click += btnMainFuelLog;
                    fuelMenuControl.btnTankerFuellog.Click += btnTankerFuellog;
                    fuelMenuControl.btnRefillMain.Click += btnRefillMain;
                    fuelMenuControl.btnAddDaily.Click += btnAddDaily;


                    //Mainrefill
                    mainRefillControl.txtPrice.KeyPress += txtPrice_KeyPress;
                    mainRefillControl.txtLiters.KeyPress += txtLiters_KeyPress;
                    mainRefillControl.txtPrice.KeyDown += txtPrice_Keydown;
                    mainRefillControl.txtLiters.KeyDown += txtLiters_Keydown;
                    mainRefillControl.lnkdefault.LinkClicked += lnkdefault_LinkClicked;
                    mainRefillControl.btnSave.Click += btnSave_Click;


                    //Fuel Price List
                    mainRefillControl.btnSearch.Click += btnSearch_Click;
                    mainRefillControl.btnAll.Click += btnAll_Click;
                    mainRefillControl.dgvRefillList.CellValueChanged += dgvRefillList_CellValueChanged;
                    mainRefillControl.dgvRefillList.CellDoubleClick += dgvRefillList_DoubleClick;


                    ///Add Daily
                    addDailyControl.dgvDailySheet.EditingControlShowing += dgvDailySheet__EditingControlShowing;
                    addDailyControl.btnSave.Click += DailybtnSave_Click;


                    //Main Tank Log
                    fuelMainLogControl.btnSearch.Click += MainLogbtnSearchbtnSave_Click;
                    fuelMainLogControl.cmbfueltype.SelectedIndexChanged += fuelMainFuelChange;
                    fuelMainLogControl.cmbTanktruck.SelectedIndexChanged += fuelMainTanktruckChange;
                    fuelMainLogControl.btnRefresh.Click += btnRefresh;
                    fuelMainLogControl.btnFuelMainLogprint.Click += btnFuelMainLogprint;

                    fuelMainLogControl.dgvTankLog.CellDoubleClick += dgvTankLog_CellDoubleClick;


                    //Tanker truck Log
                    fuelTankerLogControl.btnSearch.Click += TankerLogbtnSearchbtnSave_Click;
                    fuelTankerLogControl.cmbfueltype.SelectedIndexChanged += fueltankerFuelChange;
                    fuelTankerLogControl.cmbTanktruck.SelectedIndexChanged += fueltankerTanktruckChange;
                    fuelTankerLogControl.dgvTankLog.CellDoubleClick += dgvTankerLog_CellDoubleClick;
                    fuelTankerLogControl.btnFuelTankerLogprint.Click += btnFuelTankerLogprint;



                    #endregion end Fuel


                    #region  Units

                    //Units Button
                    unitMenuControl.btnUnitList.Click += MenubtnMenuUnitList;
                    unitMenuControl.btnMaintenanceList.Click += btnMaintenanceList;
                    unitMenuControl.btnExpenses.Click += btnExpenses;
                    unitMenuControl.btnMaintenanceHistory.Click += btnMaintenanceHistory;


                    //Expenses
                    allMaintenanceExpenses.btnSearch.Click += ExpensesbtnSearch_old_Click;
                    allMaintenanceExpenses.cmbstatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
                    allMaintenanceExpenses.cmbSearchType.SelectedIndexChanged += cmbSearchType_SelectedIndexChanged;
                    allMaintenanceExpenses.chkFilter.CheckedChanged += chkFilter_CheckedChanged;
                    allMaintenanceExpenses.dgvExpenses.CellDoubleClick += dgvExpenses_Old_CellDoubleClick;
                    allMaintenanceExpenses.dgvExpenses.CellClick += dgvExpenses_CellClick;
                    allMaintenanceExpenses.lbladdExpenses.LinkClicked += lbladdExpenses_LinkClicked;


                    //new REpair and Expenses

                    maintenanceAndRepair.chkPMS.CheckedChanged += chkPMS_CheckedChanged;

                    maintenanceAndRepair.dgvExpenses.CellDoubleClick += dgvExpenses_CellDoubleClick;
                    maintenanceAndRepair.btnSearch.Click += ExpensesbtnSearch_Click;
                    maintenanceAndRepair.cmbstatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
                    maintenanceAndRepair.chkFilter.CheckedChanged += chkFilter_CheckedChanged;
                    maintenanceAndRepair.lbladdExpenses.LinkClicked += lbladdExpenses_LinkClicked;

                    maintenanceAndRepair.dgvExpenses.CellClick += dgvExpenses_CellClick;

                    maintenanceAndRepair.chkPMS.CheckedChanged += chkPMS_CheckedChanged;
                    maintenanceAndRepair.btnAllExpensesPrint.Click += btnAllExpensesPrint;


                    allMaintenanceExpenses.btnAllExpensesPrint.Click += btnAllExpensesPrint;

                    //UNIts
                    unitListControl.lbladdsingleUnit.LinkClicked += lbladdsingleUnit_LinkClicked;

                    unitListControl.cmbUnitList.SelectedIndexChanged += cmbUnitList_SelectedIndexChanged;

                    //lnkFuel
                    unitListDetail.lnkFuel.LinkClicked += lnkFuelview_LinkClicked;
                    //lnkExpenses
                    unitListDetail.lnkExpenses.LinkClicked += lnkExpensesView_LinkClicked;
                    unitListControl.btnSearch.Click += UnitControlbtnSearch_Click;

                    unitListControl.txtSearch.KeyDown += UnitControltxtSearch_KeyDown;
                    unitListControl.dgvUnitListitem.CellDoubleClick += dgvUnitListitem_CellDoubleClick;


                    unitListDetail.lnkBack.LinkClicked += UnitlnkBack_LinkClicked;
                    unitListDetail.fuelViewControl.btnFSearch.Click += FuelViewbtnFSearch;
                    unitListDetail.fuelViewControl.dgvDataMonitoring.CellDoubleClick += dgvDataMonitoring_CellDoubleClick;
                    unitListDetail.fuelViewControl.btnUnitMaintenance.Click += btnUnitMaintenance_Click;
                    unitListDetail.fuelViewControl.btnUnitDetailRefresh.Click += btnUnitDetailRefresh_Click;
                    unitListDetail.fuelViewControl.btnFDelete.Click += btnUnitmonitoringDelete_Click;
                    unitListDetail.expensesViewControl.cmbECategory.SelectedIndexChanged += expensesViewControlcmbECategory_SelectedIndexChanged;
                    unitListDetail.lnkEditUnitInfo.LinkClicked += UnitEditClick_LinkClicked;

                    unitListDetail.fuelViewControl.btnUnitFuelPrint.Click += btnUnitFuelPrint;
                    unitListDetail.expensesViewControl.btnUnitExpensesPrint.Click += btnUnitExpensesPrint;
                    unitListDetail.expensesViewControl.btnEDelete.Click += btnexpensesunitDelete_Click;
                    unitListDetail.expensesViewControl.btnESearch.Click += ExpensesViewbtnFSearch_Click;


                    //dgvMaintenance_CellDoubleClick
                    maintenanceListControl.dgvMaintenance.CellDoubleClick += dgvMaintenance_CellDoubleClick;
                    maintenanceListControl.cmbUnitList.SelectedIndexChanged += cmbMaintenanceSearchType_SelectedIndexChanged;
                    maintenanceListControl.btnSearch.Click += MainteListbtnSearch_Click;
                    maintenanceListControl.txtSearch.KeyDown += MaintenancetxtSearch_KeyDown;
                    ////
                    ///
                    mainHistoryControl.dgvMaintenance.CellDoubleClick += dgvMaintenanceHistory_CellDoubleClick;
                    // unitListDetail.fuelViewControl.dgvDataMonitoring.CellDoubleClick += dgvDataMonitoring_CellDoubleClick;


                    //

                    ////////////////
                    #region maintenance History List

                    mainHistoryControl.cmbUnitList.SelectedIndexChanged += cmbMainHistorySearchType_SelectedIndexChanged;
                    mainHistoryControl.btnSearch.Click += MainteHistorybtnSearch_Click;
                    mainHistoryControl.txtSearch.KeyDown += MainHistorytxtSearch_KeyDown;
                    //    maintenanceListControl.cmbUnitList.SelectedIndexChanged += cmbMaintenanceList_SelectedIndexChanged;

                    #endregion


                    #endregion end Units





                    #region reports

                    //Main Menu Report
                    //  btnMonthlyReport
                    reportsControl.btnDailyReport.Click += btnDailyReport_Click;
                    reportsControl.btnMonthlyReport.Click += btnMonthlyReport_Click;
                    reportsControl.btnOverAllReport.Click += btnOverAllReport_Click;

                    //Truck Monthly 
                    monthlyFormControl.truckMonthlyControl.cmbUnitList.SelectedIndexChanged += cmbTMExpensesSearchType_SelectedIndexChanged;
                    monthlyFormControl.btnTruckandHeavy.Click += btnTruckMontlyExpenses_Click;
                    monthlyFormControl.truckMonthlyControl.btnSearch.Click += btnTruckMonthlySearch_Click;
                    monthlyFormControl.truckMonthlyControl.btnTruckMonthlyprint.Click += btnTruckMonthlyprint;

                    //ProjectSite Monthly
                    monthlyFormControl.projectSiteMonthlyControl.cmbProject.SelectedIndexChanged += cmbProExpensesSearchType_SelectedIndexChanged;
                    monthlyFormControl.btnProjectSiteMonthly.Click += btnProjectsiteMontlyExpenses_Click;
                    monthlyFormControl.projectSiteMonthlyControl.btnSearch.Click += btnProjectMonthlySearch_Click;
                    monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.CellDoubleClick += dgvProjectMonthlyList_CellDoubleClick;
                    monthlyFormControl.projectSiteMonthlyControl.btnProjectSiteMonthlyprint.Click += btnProjectSiteMonthlyprint;

                    monthlyFormControl.projectSiteEquipmentM.lnkBack.LinkClicked += ProjectDetail_lnkClick;


                    monthlyFormControl.projectSiteEquipmentM.btnProjectSiteDetail.Click += btnProjectSiteDetail;

                    //Truck Overall
                    overallReportControl.truckOverallExpensesControl.cmbUnitList.SelectedIndexChanged += cmbTOExpensesSearchType_SelectedIndexChanged;
                    overallReportControl.truckOverallExpensesControl.btnSearch.Click += btnTruckOverAllSearch_Click;
                    overallReportControl.btnTruckandHeavy.Click += btnTruckOverAllExpenses_Click;
                    overallReportControl.truckOverallExpensesControl.btnTruckOverallprint.Click += btnTruckOverallprint;

                    //Project OverAll
                    overallReportControl.projectSiteOverAllControl.cmbProject.SelectedIndexChanged += cmbProOverAllExpensesSearchType_SelectedIndexChanged;
                    overallReportControl.btnProjectsiteoverall.Click += btnProjectsiteOverAllExpenses_Click;
                    overallReportControl.projectSiteOverAllControl.btnSearch.Click += btnProjectOverAllSearch_Click;

                    overallReportControl.projectSiteOverAllControl.btnProjectSiteOverallreport.Click += btnProjectSiteOverallreport;

                    #endregion
                }
            }

        }


        #region main form


        private void viewEquipmentMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterNumber enter = new EnterNumber();
            enter.param("Main");
            enter.ShowDialog();
        }

        private void addFuelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFuelType fuelType = new AddFuelType();
            fuelType.ShowDialog();
        }

        private void addTankTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTankList tanklist = new AddTankList();
            tanklist.ShowDialog();
        }

        private void refillEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectTank tank = new SelectTank();
            tank.ShowDialog();
        }

        private void addEquipmentMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDailyActivity daily = new AddDailyActivity();
            daily.ShowDialog();
        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //RegisterTruck truck = new RegisterTruck();
            TruckForm truck = new TruckForm();
            truck.ShowDialog();
        }

        private void addTruckTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipmentType addEquipment = new AddEquipmentType();
            this.Hide();
            addEquipment.ShowDialog();
        }

        private void listOfMaintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MaintenanceList maintenance = new MaintenanceList();
            this.Hide();
            maintenance.ShowDialog();
        }

        private void maintenanceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceHistory history = new MaintenanceHistory();
            this.Hide();
            history.ShowDialog();
        }

        private void maintenanceExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceExpenses maintenance = new MaintenanceExpenses();
            this.Hide();
            maintenance.ShowDialog();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory category = new AddCategory();
            this.Hide();
            category.ShowDialog();
        }

        private void addDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterDriver driver = new RegisterDriver();
            this.Hide();
            driver.ShowDialog();
        }

        private void driverListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverListForm driver = new DriverListForm();
            this.Hide();
            driver.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegisterPump pump = new RegisterPump();
            this.Hide();
            pump.ShowDialog();
        }

        private void driversListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverListForm driver = new DriverListForm();
            this.Hide();
            driver.ShowDialog();
        }

        private void pumpInChargeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PumpIncharge driver = new PumpIncharge();
            this.Hide();
            driver.ShowDialog();
        }

        private void refillMaintankUpdatePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefillMainTanker tanker = new RefillMainTanker();
            this.Hide();
            tanker.ShowDialog();
        }

        private void fuelPriceListAndRefillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuelPriceList fuel = new FuelPriceList();
            this.Hide();
            fuel.ShowDialog();
        }

        private void categoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryList list = new CategoryList();
            this.Hide();
            list.ShowDialog();
        }

        private void addExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExpenses expenses = new AddExpenses();
            this.Hide();
            expenses.ShowDialog();
        }

        private void viewExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendingRequest expenses = new PendingRequest();
            this.Hide();
            expenses.ShowDialog();
            /*
            UpdateExpenses update = new UpdateExpenses();
            update.ShowDialog();
            */
        }

        private void pendingExpensesRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PendingRequest expenses = new PendingRequest();
            this.Hide();
            expenses.ShowDialog();
        }

        private void tankerTruckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuelLogSheetTruck fuelLog = new FuelLogSheetTruck();
            this.Hide();
            fuelLog.ShowDialog();
        }

        private void mainTankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuelLogSheetMain fuelLog = new FuelLogSheetMain();
            this.Hide();
            fuelLog.ShowDialog();
        }

        private void viewOtherMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherDailySheetForm other = new OtherDailySheetForm();
            this.Hide();
            other.ShowDialog();
        }

        private void monthlyExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyExpenses expenses = new MonthlyExpenses();
            this.Hide();
            expenses.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            dashBoardMenuControl.BringToFront();
            dashBoardControl.BringToFront();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;

        }

        #region nav menu old

        #endregion end nav menu old


        #region Main Form Menu button

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            allSetupControl.BringToFront();

            if (lbMonitoringLast.Text == "employee")
            {
                employeeControl.BringToFront();
            }
            else if (lbMonitoringLast.Text == "Position")
            {
                positionControl.BringToFront();
            }
            else if (lbMonitoringLast.Text == "truckType")
            {
                truckTypeControl.BringToFront();
            }
            else if (lbMonitoringLast.Text == "fuelType")
            {
                fuelTypeControl.BringToFront();
            }
            else if (lbMonitoringLast.Text == "tankType")
            {
                tankTypeControl.BringToFront();
            }
            else if (lbMonitoringLast.Text == "category")
            {
                categoryControl.BringToFront();
            }
            else
            {
                projectSiteControl.BringToFront();
            }


            SidePanel.Height = btnMonitoring.Height;
            SidePanel.Top = btnMonitoring.Top;
            //allSetupControl.BringToFront();
        }

        private void btnFuel_Click(object sender, EventArgs e)
        {
            fuelMenuControl.BringToFront();

            if (lblFuelLast.Text == "MainLog")
            {
                fuelMainLogControl.BringToFront();
            }
            else if (lblFuelLast.Text == "RefillMain")
            {
                mainRefillControl.BringToFront();
            }
            else if (lblFuelLast.Text == "TankerLog")
            {
                fuelTankerLogControl.BringToFront();
            }
            else if (lblFuelLast.Text == "AddDaily")
            {
                addDailyControl.BringToFront();
            }
            else
            {
                projectSiteControl.BringToFront();
            }
            SidePanel.Height = btnFuel.Height;
            SidePanel.Top = btnFuel.Top;

            ////
            //ParamMainLogList(fuelMainLogControl.cmbDate.SelectedValue.ToString(), fuelMainLogControl.cmbTanktruck.SelectedValue.ToString(), fuelMainLogControl.cmbfueltype.SelectedValue.ToString());

        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            try
            {
                if (UnitClick == 0)
                {
                    //PositionList(positionControl.txtSearch.Text);
                    //PositionAutoCompleteSearch();
                    GetTruckType();
                    GetUnitList(unitListControl.txtSearch.Text, unitListControl.cmbTruckType.SelectedValue.ToString());
                    UnitClick++;
                }

                unitMenuControl.BringToFront();

                if (lblUnitMenu.Text == "UnitList")
                {
                    unitListControl.BringToFront();
                    if (lblsubunit.Text == "ViewFuel")
                    {
                        unitListDetail.BringToFront();
                        //unitListControl.BringToFront();
                        unitListDetail.fuelViewControl.BringToFront();
                        // positionControl.BringToFront();
                    }

                    else if (lblsubunit.Text == "ViewExpenses")
                    {
                        unitListDetail.BringToFront();
                        // unitListControl.BringToFront();
                        unitListDetail.expensesViewControl.BringToFront();
                    }
                }
                else if (lblUnitMenu.Text == "UnitDetail")
                {
                    unitListControl.BringToFront();
                    if (lblsubunit.Text == "ViewFuel")
                    {
                        unitListDetail.BringToFront();
                        //unitListControl.BringToFront();
                        unitListDetail.fuelViewControl.BringToFront();
                        // positionControl.BringToFront();
                    }

                    else if (lblsubunit.Text == "ViewExpenses")
                    {
                        unitListDetail.BringToFront();
                        // unitListControl.BringToFront();
                        unitListDetail.expensesViewControl.BringToFront();
                    }
                }
                else if (lblUnitMenu.Text == "Maintenance")
                {
                    unitListDetail.BringToFront();
                    // unitListControl.BringToFront();
                    maintenanceListControl.BringToFront();
                    // positionControl.BringToFront();
                }
                else if (lblUnitMenu.Text == "MaintenanceHistory")
                {
                    unitListDetail.BringToFront();
                    // unitListControl.BringToFront();
                    mainHistoryControl.BringToFront();
                }
                else if (lblUnitMenu.Text == "DoubleClick")
                {
                    unitListDetail.BringToFront();
                    // unitListControl.BringToFront();
                    unitListDetail.expensesViewControl.BringToFront();
                }
                else
                {
                    maintenanceAndRepair.BringToFront();
                    //allMaintenanceExpenses.BringToFront();
                }

                SidePanel.Height = btnUnits.Height;
                SidePanel.Top = btnUnits.Top;
            }
            catch
            {

            }
        }

        private void ProjectDetail_lnkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblReportMonthlyLastsub.Text = "Projectsite";
            monthlyFormControl.panelProjectSiteMonthly.Show();
            monthlyFormControl.panelTruckandHeavy.Hide();
            // monthlyFormControl.projectSiteEquipmentM.Hide();
            //monthlyFormControl.projectSiteEquipmentM.Hide();
            //monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.CellDoubleClick += dgvProjectMonthlyList_CellDoubleClick;
            //monthlyFormControl.projectSiteMonthlyControl.Show();
            monthlyFormControl.projectSiteMonthlyControl.BringToFront();
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                SidePanel.Height = btnReport.Height;
                SidePanel.Top = btnReport.Top;
                reportsControl.BringToFront();

                //////

                if (lblReportMainLast.Text == "Daily")
                {
                }
                else if (lblReportMainLast.Text == "Monthly")
                {
                    monthlyFormControl.BringToFront();
                    reportsControl.panelMonthlyReport.Show();
                    reportsControl.panelDailyReport.Hide();
                    reportsControl.panelOverAllReport.Hide();

                    if (lblReportMonthlyLast.Text == "Truck")
                    {
                        monthlyFormControl.panelTruckandHeavy.Show();
                        monthlyFormControl.panelProjectSiteMonthly.Hide();
                        //monthlyFormControl.projectSiteEquipmentM.Hide();

                        //monthlyFormControl.projectSiteEquipmentM.BringToFront();
                        monthlyFormControl.truckMonthlyControl.BringToFront();
                    }
                    else // if(lblReportMonthlyLast.Text == "Projectsite")
                    {
                        if(lblReportMonthlyLastsub.Text == "ProjectSiteDetail")
                        {
                            monthlyFormControl.panelProjectSiteMonthly.Show();
                            monthlyFormControl.panelTruckandHeavy.Hide();
                            monthlyFormControl.projectSiteEquipmentM.BringToFront();
                        }
                        else
                        {
                            lblReportMonthlyLastsub.Text = "Projectsite";
                            monthlyFormControl.panelProjectSiteMonthly.Show();
                            monthlyFormControl.panelTruckandHeavy.Hide();
                            // monthlyFormControl.projectSiteEquipmentM.Hide();
                            //monthlyFormControl.projectSiteEquipmentM.BringToFront();
                            monthlyFormControl.projectSiteMonthlyControl.BringToFront();
                        }
                        //monthlyFormControl.panelProjectSiteMonthly.Show();
                        //monthlyFormControl.panelTruckandHeavy.Hide();
                        //monthlyFormControl.projectSiteMonthlyControl.BringToFront();
                    }
                    //else //
                    //{
                    //    monthlyFormControl.panelProjectSiteMonthly.Show();
                    //    monthlyFormControl.panelTruckandHeavy.Hide();
                    //    monthlyFormControl.projectSiteEquipmentM1summary.BringToFront();
                    //        //.BringToFront();
                    //}

                }
                else
                {
                    overallReportControl.BringToFront();
                    reportsControl.panelOverAllReport.Show();
                    reportsControl.panelMonthlyReport.Hide();
                    reportsControl.panelDailyReport.Hide();

                    if (lblReportOverAllLast.Text == "Truck")
                    {
                        overallReportControl.panelTruckandHeavy.Show();
                        overallReportControl.panelProjectSiteOverall.Hide();
                        overallReportControl.truckOverallExpensesControl.BringToFront();
                    }
                    else
                    {
                        overallReportControl.panelProjectSiteOverall.Show();
                        overallReportControl.panelTruckandHeavy.Hide();
                        overallReportControl.projectSiteOverAllControl.BringToFront();
                    }
                }

            }
            catch
            {

            }

            /*
            try
            {
                if (UnitClick == 0)
                {
                    //PositionList(positionControl.txtSearch.Text);
                    //PositionAutoCompleteSearch();
                    GetTruckType();
                    GetUnitList(unitListControl.txtSearch.Text, unitListControl.cmbTruckType.SelectedValue.ToString());
                    UnitClick++;
                }

                unitMenuControl.BringToFront();

                if (lblUnitMenu.Text == "UnitList")
                {
                    unitListControl.BringToFront();
                    if (lblsubunit.Text == "ViewFuel")
                    {
                        unitListDetail.BringToFront();
                        //unitListControl.BringToFront();
                        unitListDetail.fuelViewControl.BringToFront();
                        // positionControl.BringToFront();
                    }

                    else if (lblsubunit.Text == "ViewExpenses")
                    {
                        unitListDetail.BringToFront();
                        // unitListControl.BringToFront();
                        unitListDetail.expensesViewControl.BringToFront();
                    }
                }
                else if (lblUnitMenu.Text == "Maintenance")
                {
                    unitListDetail.BringToFront();
                    // unitListControl.BringToFront();
                    maintenanceListControl.BringToFront();
                    // positionControl.BringToFront();
                }
                else if (lblUnitMenu.Text == "MaintenanceHistory")
                {
                    unitListDetail.BringToFront();
                    // unitListControl.BringToFront();
                    mainHistoryControl.BringToFront();
                }
                else if (lblUnitMenu.Text == "DoubleClick")
                {
                    unitListDetail.BringToFront();
                    // unitListControl.BringToFront();
                    unitListDetail.expensesViewControl.BringToFront();
                }
                else
                {
                    allMaintenanceExpenses.BringToFront();
                }

                SidePanel.Height = btnUnits.Height;
                SidePanel.Top = btnUnits.Top;
            }
            catch
            {

            }
             */
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }



        #endregion end Main Form Menu button

        #endregion


        //DashBoard
        #region DashBoard
        private void LtoRegistration()
        {
            // Set the selection background color for all the cells.

            dashBoardControl.dgvLtoRegister.DataSource = null;
            if (this.dashBoardControl.dgvLtoRegister.DataSource != null)
            {
                this.dashBoardControl.dgvLtoRegister.DataSource = null;
            }
            else
            {
                this.dashBoardControl.dgvLtoRegister.Rows.Clear();
            }

            SqlDataReader reader;


            string spName = "sp_GetLtOExpireRegister";
            string param = "'" + "'";

            reader = monitoring.ExecuteReader(spName, param);
            DataTable Detail = new DataTable();
            Detail.Load(reader);


            foreach (DataRow row in Detail.Rows)
            {
                dashBoardControl.dgvLtoRegister.Rows.Add(row["Month_R_Expired"].ToString() + " " + row["Year_R_Expired"].ToString()//.Replace(" 12:00:00 AM", "")
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                        );
            }

        }


        public void GetFuelLimit()
        {
            dashBoardControl.HdgvMaintankFuel.DefaultCellStyle.ForeColor = Color.DarkRed;

            // Set the selection background color for all the cells.

            dashBoardControl.HdgvMaintankFuel.DataSource = null;
            if (this.dashBoardControl.HdgvMaintankFuel.DataSource != null)
            {
                this.dashBoardControl.HdgvMaintankFuel.DataSource = null;
            }
            else
            {
                this.dashBoardControl.HdgvMaintankFuel.Rows.Clear();
            }


            SqlDataReader reader;


            string spName = "sp_Get_MainFuelLimit";
            string param = "'" + "'";

            reader = monitoring.ExecuteReader(spName, param);
            DataTable Detail = new DataTable();
            Detail.Load(reader);


            foreach (DataRow row in Detail.Rows)
            {
                dashBoardControl.HdgvMaintankFuel.Rows.Add(row["TankName"].ToString()//.Replace(" 12:00:00 AM", "")
                            , row["AvailableFuel"].ToString()
                        );
            }

            
        }

        public void Param()
        {
            //  dgvMaintenanceList.DefaultCellStyle.SelectionForeColor = Color.DarkRed;

            // Set the selection background color for all the cells.

            dashBoardControl.dgvMaintenanceList.DataSource = null;
            if (this.dashBoardControl.dgvMaintenanceList.DataSource != null)
            {
                this.dashBoardControl.dgvMaintenanceList.DataSource = null;
            }
            else
            {
                this.dashBoardControl.dgvMaintenanceList.Rows.Clear();
            }

            /*
            foreach (DataRow row in data.Rows)
            {
                dgvDailySheet.Rows.Add(row["Date"].ToString().Replace(" 12:00:00 AM", "")
                        , row["EquipmentNo"].ToString()
                        , row["Model"].ToString()
                        , row["PlateNumber"].ToString()
                        , row["totalKmhr"].ToString()
                        );
            }
            */

            SqlDataReader reader;


            string spName = "sp_Get_MaintenanceList";
            string param = "'" + "'";

            reader = monitoring.ExecuteReader(spName, param);
            DataTable Detail = new DataTable();
            Detail.Load(reader);


            foreach (DataRow row in Detail.Rows)
            {
                dashBoardControl.dgvMaintenanceList.Rows.Add(row["Date"].ToString()//.Replace(" 12:00:00 AM", "")
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            , row["Kms_Used"].ToString()
                            , row["Hrs_Used"].ToString()
                        );
            }

            /*
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_TankList.TankName from m_TankList with (nolock)", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDailySheet. = dt;

                cmbfuel.DisplayMember = "FuelType";
                cmbfuel.ValueMember = "FuelType";
            }
            */
            /*  
             SqlDataReader fueltypereader;


             string spName = "sp_Get_FuelType";
             string param = "'" + "'";

             fueltypereader = monitoring.ExecuteReader(spName, param);
             DataTable Fueltable = new DataTable();
             Detail.Load(reader);
            */

        }
        #endregion

        //////////////////////////////////////
        //////////////////////////////////////
        ////Monitoring////////////////////////
        //////AllSetup//////////////////

        #region  allsetup

        #region Position
        //////Position//////////////////
        private void PositionList(string position)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_Position with(nolock) where Position != 'All'" +
                " and Position like '%" + position + "%' and IsDelete = '1'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            positionControl.dgvPosition.DataSource = null;

            if (this.positionControl.dgvPosition.DataSource != null)
            {
                this.positionControl.dgvPosition.DataSource = null;
            }
            else
            {
                this.positionControl.dgvPosition.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    positionControl.dgvPosition.Rows.Add(row["Position"].ToString());
                }
            }
            else
            {
            }
        }

        private void btnPosition(object sender, EventArgs e)
        {
            try
            {
                if (ckPosition == 0)
                {
                    PositionList(positionControl.txtSearch.Text);
                    PositionAutoCompleteSearch();
                    ckPosition++;
                }
                allSetupControl.categorypanel.Hide();
                allSetupControl.TrucktypePanel.Hide();
                allSetupControl.FueltypePanel.Hide();
                allSetupControl.Tanktypepanel.Hide();
                allSetupControl.EmployeePanel.Hide();
                allSetupControl.ProjectSitepanel.Hide();
                allSetupControl.PositionPanel.Show();

                positionControl.BringToFront();
                lbMonitoringLast.Text = "Position";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //////////////////////////////////////
        /////////Position function////////////
        /////////////////////////////////////


        private void PositiontxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    positionbtnSearch(positionControl.btnSearch, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            //TextBox SearchPositionauto;// = e.ToString as TextBox;
            
            positionControl.txtSearch.AutoCompleteCustomSource.Clear();
            positionControl.txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            positionControl.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection Positiontxt = new AutoCompleteStringCollection();
            PositionAutoCompleteSearch();
           
            SearchPosition(Positiontxt);
            positionControl.txtSearch.AutoCompleteCustomSource = Positiontxt; 
            */
        }
        /*
        private void PositiontxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                AutoCompleteStringCollection Positiontxt = new AutoCompleteStringCollection();

                SqlDataAdapter da = new SqlDataAdapter("select * from m_Position with(nolock) where Position != 'All'" +
                    " and Position like '%" + positionControl.txtSearch.Text + "%'", Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Positiontxt.Add(dr["Position"].ToString());
                    //SearchPositionArray.Add(dr["Position"].ToString());
                }

                positionControl.txtSearch.AutoCompleteCustomSource = Positiontxt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */

        void PositionAutoCompleteSearch()
        {
            try
            {
                /*
                SqlDataAdapter da = new SqlDataAdapter("select * from m_Position with(nolock) where Position != 'All'" +
                    " and Position like '%" + positionControl.txtSearch.Text + "%'", Connection);
                */
                AutoCompleteStringCollection Positiontxt = new AutoCompleteStringCollection();
                //dtPositionList
                /*
                SqlDataAdapter da = new SqlDataAdapter("select * from m_Position with(nolock) where Position != 'All'", Connection);

                DataTable dt = new DataTable();
                da.Fill(dt);
                */
                foreach (DataRow dr in dtPositionList.Rows)
                {
                    Positiontxt.Add(dr["Position"].ToString());
                    //SearchPositionArray.Add(dr["Position"].ToString());
                }

                positionControl.txtSearch.AutoCompleteCustomSource = Positiontxt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*
             auto.AutoCompleteCustomSource.Clear();
             positionControl.txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
             positionControl.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void SearchPosition(AutoCompleteStringCollection data)
        {
            try
            {
                foreach (var item in SearchPositionArray)
                    data.AddRange(new string[] { item.ToString() });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void positionbtnSearch(object sender, EventArgs e)
        {
            try
            {
                PositionList(positionControl.txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void positionbtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string oldPosition = "'" + positionControl.lbloldPosition.Text + "'";
                    string newPosition = "'" + positionControl.txtEditPosition.Text + "'";
                    string spName = "sp_Update_Position";

                    if (oldPosition == newPosition)
                    {
                        MessageBox.Show("Position Is Equal to Previous position");
                    }
                    else
                    {
                        reader = monitoring.ExecuteReader(spName, oldPosition, newPosition);
                        DataTable Detail = new DataTable();
                        Detail.Load(reader);
                        result = Detail.Rows[0]["Result"].ToString();

                        if (result == "1")
                        {
                            MessageBox.Show("Successfully Saved..");
                            positionControl.txtEditPosition.Text = "";
                            positionControl.lbloldPosition.Text = "";
                            positionControl.EditPosition.Hide();
                            PositionList(positionControl.txtSearch.Text);
                            employeeControl.dgvAddEmployee.Columns.Remove("POSITION");
                            EmpPositionList();
                            EmployeePosition();
                            PositionAutoCompleteSearch();
                        }
                        else
                        {
                            MessageBox.Show("Position " + oldPosition + " Not Exist");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void positionbtnCancel(object sender, EventArgs e)
        {
            try
            {
                positionControl.txtEditPosition.Text = "";
                positionControl.lbloldPosition.Text = "";
                positionControl.EditPosition.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void positionbtnAddSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string Position = "";
                    string spName = "sp_Add_Position";

                    int numRows = positionControl.dgvAddPosition.Rows.Count;
                    int loop = numRows - 1;

                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {

                            if (Convert.ToString(positionControl.dgvAddPosition.Rows[i].Cells[0].FormattedValue) != string.Empty)
                            {
                                Position = "'" + positionControl.dgvAddPosition.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                            }

                            if (positionControl.dgvAddPosition.Rows[i].Cells[0].FormattedValue.ToString().Replace(" ", "") == "")
                            {
                                MessageBox.Show("Please Enter Position");
                            }
                            else
                            {

                                reader = monitoring.ExecuteReader(spName, Position);
                                DataTable Detail = new DataTable();
                                Detail.Load(reader);
                                result = Detail.Rows[0]["Result"].ToString();

                                if (result == "1")
                                {
                                    positionControl.dgvAddPosition.Rows.Remove(positionControl.dgvAddPosition.Rows[i]);
                                    i = i - 1;
                                    loop = loop - 1;
                                }
                                else if (result == "2")
                                {
                                    MessageBox.Show("Position " + Position + " Already Exist");
                                    positionControl.dgvAddPosition.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                }
                                else
                                {
                                    positionControl.dgvAddPosition.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                }
                            }
                        }
                        employeeControl.dgvAddEmployee.Columns.Remove("POSITION");
                        EmpPositionList();
                        EmployeePosition();
                        PositionList(positionControl.txtSearch.Text);
                        PositionAutoCompleteSearch();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Position");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void positionlnkDelete(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string Position = "'" + positionControl.lbloldPosition.Text + "'";
                    string spName = "sp_Delete_Position";

                    reader = monitoring.ExecuteReader(spName, Position);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Deleted..");
                        positionControl.txtEditPosition.Text = "";
                        positionControl.lbloldPosition.Text = "";
                        positionControl.EditPosition.Hide();
                        PositionList(positionControl.txtSearch.Text);
                        employeeControl.dgvAddEmployee.Columns.Remove("POSITION");
                        EmpPositionList();
                        EmployeePosition();
                        PositionAutoCompleteSearch();
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Position " + Position + " Not Exist");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete..");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void positionlnkAddposition(object sender, EventArgs e)
        {
            try
            {
                positionControl.AddPositionGroup.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void positionbtnAddCancel(object sender, EventArgs e)
        {
            try
            {
                positionControl.dgvAddPosition.Rows.Clear();
                positionControl.AddPositionGroup.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvPosition_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    positionControl.EditPosition.Show();
                    positionControl.txtEditPosition.Text = positionControl.dgvPosition[0, e.RowIndex].Value.ToString();
                    positionControl.lbloldPosition.Text = positionControl.dgvPosition[0, e.RowIndex].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ////////////////////
        ////////////////////
        #endregion  End  position


        #region  EmployeeList
        //////EmployeeList//////////////////

        private void btnEmployeeList(object sender, EventArgs e)
        {

            try
            {
                if (ckEmployee == 0)
                {
                    // PositionList(positionControl.txtSearch.Text);
                    // PositionAutoCompleteSearch();
                    // EmployeePosition();
                    // SearchEmployeeList(employeeControl.txtSearch.Text);
                    ckEmployee++;
                }
                allSetupControl.categorypanel.Hide();
                allSetupControl.PositionPanel.Hide();
                allSetupControl.TrucktypePanel.Hide();
                allSetupControl.FueltypePanel.Hide();
                allSetupControl.Tanktypepanel.Hide();
                allSetupControl.ProjectSitepanel.Hide();
                allSetupControl.EmployeePanel.Show();
                employeeControl.BringToFront();
                lbMonitoringLast.Text = "employee";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeetxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    employeebtnSearch(employeeControl.btnSearch, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpPositionList()
        {
            dtPositionList.Clear();
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from m_Position with(nolock) where Position != 'All' and IsDelete = '1'", Connection);

                da.Fill(dtPositionList);
                // CONVERT(VARCHAR(10), Date, 101)
                employeeControl.cmbPositionlist.DataSource = dtPositionList;
                employeeControl.cmbPositionlist.DisplayMember = "Position";
                employeeControl.cmbPositionlist.ValueMember = "Position";
            }
        }
        /*
        private void EmpList()
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from m_Employee with(nolock)", Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    PumpArray.Add(dr["Name"].ToString());
                }

            }
        }
        */
        /*
        private void employee_load(object sender, EventArgs e)
        {
            try
            {
                SearchEmployeeList(employeeControl.txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
        private void SearchEmployeeList(string Search)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_Employee with(nolock) where " + employeeControl.cmbEmpSearchType.SelectedItem.ToString() + " like '%" + Search + "%' and IsDelete = '1'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            employeeControl.dgvEmployeeList.DataSource = null;

            if (this.employeeControl.dgvEmployeeList.DataSource != null)
            {
                this.employeeControl.dgvEmployeeList.DataSource = null;
            }
            else
            {
                this.employeeControl.dgvEmployeeList.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    employeeControl.dgvEmployeeList.Rows.Add(row["Id"].ToString()
                                , row["Name"].ToString()
                                , row["Position"].ToString()
                                , row["Supervisor"].ToString()
                                );
                }
            }
            else
            {
            }
        }

        void EmployeeListAutoCompleteSearch()
        {
            try
            {
                /*
                 * 
        AutoCompleteStringCollection EmployeeText = new AutoCompleteStringCollection();
        AutoCompleteStringCollection EmployeeTextAll = new AutoCompleteStringCollection();

                 */
                //SqlDataAdapter da = new SqlDataAdapter("select * from m_Position with(nolock) where Position != 'All'", Connection);

                //EmployeeText.Clear();
                // EmployeeTextAll.Clear();

                SqlDataAdapter da = new SqlDataAdapter("select * from m_Employee with(nolock) where IsDelete = '1'", Connection);

                //  DataTable dt = new DataTable();
                da.Fill(dtEmployeeList);

                foreach (DataRow dr in dtEmployeeList.Rows)
                {
                    EmployeeTextAll.Add(dr["Name"].ToString());
                    EmployeeTextAll.Add(dr["Position"].ToString());
                    EmployeeText.Add(dr["Name"].ToString());
                    EmployeeList.Add(dr["Name"].ToString());
                }


                allMaintenanceExpenses.txtDriver.AutoCompleteCustomSource = EmployeeText;
                allMaintenanceExpenses.txtMechanic.AutoCompleteCustomSource = EmployeeText;


                maintenanceAndRepair.txtDriver.AutoCompleteCustomSource = EmployeeText;
                maintenanceAndRepair.txtMechanic.AutoCompleteCustomSource = EmployeeText;

                employeeControl.txtSupervisor.AutoCompleteCustomSource = EmployeeText;
                employeeControl.txtSearch.AutoCompleteCustomSource = EmployeeTextAll;
                //AutoEmployee
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void SearchEmployeeList(AutoCompleteStringCollection data)
        {
            try
            {
                foreach (var item in EmployeeList)
                    data.AddRange(new string[] { item.ToString() });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void EmployeePosition()
        {
            /*
            SqlDataAdapter da = new SqlDataAdapter("select * from m_Position with(nolock) where Position != 'All'", Connection);

            DataTable dt = new DataTable();
            da.Fill(dt);
            */
            EmployeePositioncombo.Items.Clear();
            EmployeePositioncombo.HeaderText = "POSITION";
            EmployeePositioncombo.Name = "POSITION";

            ArrayList row = new ArrayList();

            foreach (DataRow dr in dtPositionList.Rows)
            {
                row.Add(dr["Position"].ToString());
            }


            EmployeePositioncombo.Items.AddRange(row.ToArray());

            employeeControl.dgvAddEmployee.Columns.Add(EmployeePositioncombo);
            employeeControl.dgvAddEmployee.Columns[2].Width = 175;

        }



        private void EmployeelnkEmployee(object sender, EventArgs e)
        {
            try
            {
                employeeControl.AddEmployeeGroup.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void employeebtnAddCancel(object sender, EventArgs e)
        {
            try
            {
                employeeControl.dgvAddEmployee.Rows.Clear();
                employeeControl.AddEmployeeGroup.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dvgAddEmployee__EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox auto = e.Control as TextBox;
            //employeeControl.dgvAddEmployee.EditingControlShowing += dvgAddEmployee__EditingControlShowing;
            if (employeeControl.dgvAddEmployee.CurrentCell.ColumnIndex == 1)
            {
                try
                {
                    if (auto != null)
                    {
                        auto.AutoCompleteCustomSource.Clear();
                        auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                        auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        SearchEmployeeList(data);
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

        private void EmployeebtnAddSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string Name = "";
                    string Position = "";
                    string Supervisor = "";
                    string spName = "sp_Add_Employee";

                    int numRows = employeeControl.dgvAddEmployee.Rows.Count;
                    int loop = numRows - 1;

                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {

                            if (Convert.ToString(employeeControl.dgvAddEmployee.Rows[i].Cells[0].FormattedValue) != string.Empty)
                            {
                                Name = "'" + employeeControl.dgvAddEmployee.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                            }
                            else
                            {
                                Name = "''";
                            }
                            if (Convert.ToString(employeeControl.dgvAddEmployee.Rows[i].Cells[1].FormattedValue) != string.Empty)
                            {
                                Supervisor = "'" + employeeControl.dgvAddEmployee.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                            }
                            else
                            {
                                Supervisor = "''";
                            }
                            if (Convert.ToString(employeeControl.dgvAddEmployee.Rows[i].Cells[2].FormattedValue) != string.Empty)
                            {
                                Position = "'" + employeeControl.dgvAddEmployee.Rows[i].Cells[2].FormattedValue.ToString() + "'";
                            }

                            if (Position.Replace("'", "") == "GENERAL MANAGER")
                            {
                                if (employeeControl.dgvAddEmployee.Rows[i].Cells[0].FormattedValue.ToString().Replace(" ", "") == "")
                                {
                                    MessageBox.Show("Please Enter Name");
                                }
                                else
                                {

                                    reader = monitoring.ExecuteReader(spName, Name, Supervisor, Position);
                                    DataTable Detail = new DataTable();
                                    Detail.Load(reader);
                                    result = Detail.Rows[0]["Result"].ToString();

                                    if (result == "1")
                                    {
                                        employeeControl.dgvAddEmployee.Rows.Remove(employeeControl.dgvAddEmployee.Rows[i]);
                                        i = i - 1;
                                        loop = loop - 1;
                                    }
                                    else if (result == "2")
                                    {
                                        MessageBox.Show("Name " + Name + " Already Exist");
                                        employeeControl.dgvAddEmployee.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                    }
                                    else
                                    {
                                        employeeControl.dgvAddEmployee.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                    }
                                }
                            }
                            else
                            {
                                if (employeeControl.dgvAddEmployee.Rows[i].Cells[0].FormattedValue.ToString().Replace(" ", "").Replace("'", "") == "")
                                {
                                    MessageBox.Show("Please Enter Name");
                                }
                                else
                                {
                                    if (employeeControl.dgvAddEmployee.Rows[i].Cells[1].FormattedValue.ToString().Replace(" ", "").Replace("'", "") == "")
                                    {
                                        MessageBox.Show("Please Enter Supervisor");
                                    }
                                    else
                                    {

                                        reader = monitoring.ExecuteReader(spName, Name, Supervisor, Position);
                                        DataTable Detail = new DataTable();
                                        Detail.Load(reader);
                                        result = Detail.Rows[0]["Result"].ToString();

                                        if (result == "1")
                                        {
                                            employeeControl.dgvAddEmployee.Rows.Remove(employeeControl.dgvAddEmployee.Rows[i]);
                                            i = i - 1;
                                            loop = loop - 1;
                                        }
                                        else if (result == "2")
                                        {
                                            MessageBox.Show("Name " + Name + " Already Exist");
                                            employeeControl.dgvAddEmployee.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                        }
                                        else
                                        {
                                            employeeControl.dgvAddEmployee.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                        }
                                    }
                                }
                            }


                            /*
                            if (employeeControl.dgvAddEmployee.Rows[i].Cells[0].FormattedValue.ToString().Replace(" ", "") == "" || )
                            {
                                MessageBox.Show("Please Enter Position");
                            }
                            else
                            {

                                reader = monitoring.ExecuteReader(spName, Position);
                                DataTable Detail = new DataTable();
                                Detail.Load(reader);
                                result = Detail.Rows[0]["Result"].ToString();

                                if (result == "1")
                                {
                                    employeeControl.dgvAddEmployee.Rows.Remove(positionControl.dgvAddPosition.Rows[i]);
                                    i = i - 1;
                                    loop = loop - 1;
                                }
                                else if (result == "2")
                                {
                                    MessageBox.Show("Position " + Position + " Already Exist");
                                    employeeControl.dgvAddEmployee.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                }
                                else
                                {
                                    employeeControl.dgvAddEmployee.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                }
                            }
                            */
                        }

                        SearchEmployeeList(employeeControl.txtSearch.Text);
                        EmployeeListAutoCompleteSearch();
                        PositionAutoCompleteSearch();
                        // PositionList(positionControl.txtSearch.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Position");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployeeList_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    employeeControl.EditEmployee.Show();
                    employeeControl.lblId.Text = employeeControl.dgvEmployeeList[0, e.RowIndex].Value.ToString();
                    employeeControl.txtName.Text = employeeControl.dgvEmployeeList[1, e.RowIndex].Value.ToString();
                    employeeControl.txtSupervisor.Text = employeeControl.dgvEmployeeList[3, e.RowIndex].Value.ToString();
                    employeeControl.cmbPositionlist.Text = employeeControl.dgvEmployeeList[2, e.RowIndex].Value.ToString();
                    employeeControl.lblId.Text = employeeControl.dgvEmployeeList[0, e.RowIndex].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeebtnCancel(object sender, EventArgs e)
        {
            try
            {
                employeeControl.txtName.Text = "";
                employeeControl.txtSupervisor.Text = "";
                employeeControl.lblId.Text = "";
                employeeControl.EditEmployee.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeebtnSearch(object sender, EventArgs e)
        {
            try
            {
                SearchEmployeeList(employeeControl.txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeebtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + employeeControl.lblId.Text + "'";
                    string Name = "'" + employeeControl.txtName.Text + "'";
                    string Supervisor = "'" + employeeControl.txtSupervisor.Text + "'";
                    string Position = "'" + employeeControl.cmbPositionlist.Text + "'";
                    string spName = "sp_Update_Employee";

                    reader = monitoring.ExecuteReader(spName, id, Name, Supervisor, Position);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Saved..");
                        positionControl.txtEditPosition.Text = "";
                        positionControl.lbloldPosition.Text = "";
                        employeeControl.EditEmployee.Hide();
                        SearchEmployeeList(employeeControl.txtSearch.Text);
                        EmployeeListAutoCompleteSearch();
                        PositionAutoCompleteSearch();
                    }
                    else
                    {
                        MessageBox.Show("Employee " + Name + " Not Exist");
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeelnkDelete(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + employeeControl.lblId.Text + "'";
                    string spName = "sp_Delete_Employee";

                    reader = monitoring.ExecuteReader(spName, id);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Deleted..");
                        positionControl.txtEditPosition.Text = "";
                        positionControl.lbloldPosition.Text = "";
                        employeeControl.EditEmployee.Hide();
                        SearchEmployeeList(employeeControl.txtSearch.Text);
                        EmployeeListAutoCompleteSearch();
                        PositionAutoCompleteSearch();

                        /*
                        employeeControl.dgvAddEmployee.Columns.Remove("POSITION");
                        EmpPositionList();
                        EmployeePosition();
                        */
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Employee Not Exist");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete..");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        ////////////////////
        ////////////////////

        #endregion  End employee


        #region TruckType

        ////////////////////
        ////////////////////
        //TruckType
        ////////////////////
        ////////////////////

        private void btnTruckType(object sender, EventArgs e)
        {
            try
            {
                if (ckTruckType == 0)
                {
                    // PositionList(positionControl.txtSearch.Text);
                    // PositionAutoCompleteSearch();
                    // EmployeePosition();
                    // SearchEmployeeList(employeeControl.txtSearch.Text);
                    TruckList();
                    ckTruckType++;
                }

                allSetupControl.categorypanel.Hide();
                allSetupControl.PositionPanel.Hide();
                allSetupControl.FueltypePanel.Hide();
                allSetupControl.Tanktypepanel.Hide();
                allSetupControl.EmployeePanel.Hide();
                allSetupControl.ProjectSitepanel.Hide();
                allSetupControl.TrucktypePanel.Show();
                truckTypeControl.BringToFront();
                lbMonitoringLast.Text = "truckType";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /////
        private void TruckList()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_TruckType with (nolock) where IsDelete = '1'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            truckTypeControl.dgvTruckTypeList.DataSource = null;

            if (this.truckTypeControl.dgvTruckTypeList.DataSource != null)
            {
                this.truckTypeControl.dgvTruckTypeList.DataSource = null;
            }
            else
            {
                this.truckTypeControl.dgvTruckTypeList.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    truckTypeControl.dgvTruckTypeList.Rows.Add(row["TruckId"].ToString()
                           , row["TruckType"].ToString()
                           , row["Description"].ToString()
                           , row["Base"].ToString()
                           , row["Limit"].ToString()
                           , row["km"].ToString()
                           , row["hrs"].ToString()
                           );
                }
            }
            else
            {
            }
        }

        private void TrucklnkAdd(object sender, EventArgs e)
        {
            try
            {
                truckTypeControl.adddisplayGroup.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void truckTypebtnAddCancel(object sender, EventArgs e)
        {
            try
            {
                truckTypeControl.dgvAddTruckType.Rows.Clear();
                truckTypeControl.adddisplayGroup.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trucktypeAddbtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlDataReader reader;
                    string spName = "sp_Add_Trucktype";
                    int numRows = truckTypeControl.dgvAddTruckType.Rows.Count;
                    int loop = numRows - 1;

                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            if (Convert.ToString(truckTypeControl.dgvAddTruckType.Rows[i].Cells[0].FormattedValue).Replace(" ", "") == string.Empty)
                            {
                                MessageBox.Show("Please enter a value to TruckType!");
                                return;
                            }
                            else if (Convert.ToString(truckTypeControl.dgvAddTruckType.Rows[i].Cells[3].FormattedValue).Replace(" ", "") == string.Empty)
                            {
                                MessageBox.Show("Please select a value from Limit to Maintenance!");
                                return;
                            }
                            else if (Convert.ToString(truckTypeControl.dgvAddTruckType.Rows[i].Cells[4].FormattedValue).Replace(" ", "") == string.Empty)
                            {
                                MessageBox.Show("Please select a value from KM!");
                                return;
                            }
                            else if (Convert.ToString(truckTypeControl.dgvAddTruckType.Rows[i].Cells[5].FormattedValue).Replace(" ", "") == string.Empty)
                            {
                                MessageBox.Show("Please select a value from HR!");
                                return;
                            }
                            else if (Convert.ToString(truckTypeControl.dgvAddTruckType.Rows[i].Cells[2].FormattedValue).Replace(" ", "") == string.Empty)
                            {
                                MessageBox.Show("Please select a value from Limit Base!");
                                return;
                            }
                            else
                            {
                                string Trucktype = "'" + truckTypeControl.dgvAddTruckType.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                                string Description = "'" + truckTypeControl.dgvAddTruckType.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                                string Limit = "'" + truckTypeControl.dgvAddTruckType.Rows[i].Cells[3].FormattedValue.ToString() + "'";
                                string Km = "'" + truckTypeControl.dgvAddTruckType.Rows[i].Cells[4].FormattedValue.ToString() + "'";
                                string Hr = "'" + truckTypeControl.dgvAddTruckType.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                                string LimitBase = "'" + truckTypeControl.dgvAddTruckType.Rows[i].Cells[2].FormattedValue.ToString() + "'";

                                reader = monitoring.ExecuteReader(spName, Trucktype, Description, Km, Hr, LimitBase, Limit);
                                DataTable result = new DataTable();
                                result.Load(reader);
                                string Result = result.Rows[0]["Result"].ToString();

                                if (Result == "1")
                                {
                                    truckTypeControl.dgvAddTruckType.Rows.Remove(truckTypeControl.dgvAddTruckType.Rows[i]);
                                    i = i - 1;
                                    loop = loop - 1;
                                }
                                else if (Result == "2")
                                {
                                    MessageBox.Show("Truck Type:  " + Trucktype + " Already Exist");
                                    truckTypeControl.dgvAddTruckType.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                }
                                else
                                {
                                    truckTypeControl.dgvAddTruckType.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                }
                            }

                        }
                        TruckList();
                        FuelTankTypeList();
                        //TankList();
                    }
                    else
                    {
                        MessageBox.Show("The Gridview empty.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTruckTypeList_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    truckTypeControl.edittruckgroup.Show();
                    truckTypeControl.lblId.Text = truckTypeControl.dgvTruckTypeList[0, e.RowIndex].Value.ToString();
                    truckTypeControl.txtTrucktype.Text = truckTypeControl.dgvTruckTypeList[1, e.RowIndex].Value.ToString();
                    truckTypeControl.txtDescription.Text = truckTypeControl.dgvTruckTypeList[2, e.RowIndex].Value.ToString();
                    truckTypeControl.cmbLimitBase.Text = truckTypeControl.dgvTruckTypeList[3, e.RowIndex].Value.ToString();
                    truckTypeControl.txtLimit.Text = truckTypeControl.dgvTruckTypeList[4, e.RowIndex].Value.ToString();
                    truckTypeControl.txtkmLimit.Text = truckTypeControl.dgvTruckTypeList[5, e.RowIndex].Value.ToString();
                    truckTypeControl.txtHr.Text = truckTypeControl.dgvTruckTypeList[6, e.RowIndex].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void truckTypebtnCancel(object sender, EventArgs e)
        {
            try
            {
                truckTypeControl.edittruckgroup.Hide();
                truckTypeControl.lblId.Text = "";
                truckTypeControl.txtTrucktype.Text = "";
                truckTypeControl.txtDescription.Text = "";
                truckTypeControl.cmbLimitBase.Text = "";
                truckTypeControl.txtLimit.Text = "";
                truckTypeControl.txtkmLimit.Text = "";
                truckTypeControl.txtHr.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void truckTypebtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + truckTypeControl.lblId.Text + "'";
                    string trucktype = "'" + truckTypeControl.txtTrucktype.Text + "'";
                    string description = "'" + truckTypeControl.txtDescription.Text + "'";
                    string limitbase = "'" + truckTypeControl.cmbLimitBase.SelectedItem.ToString() + "'";
                    string limit = "'" + truckTypeControl.txtLimit.Text + "'";
                    string km = "'" + truckTypeControl.txtkmLimit.Text + "'";
                    string hr = "'" + truckTypeControl.txtHr.Text + "'";
                    string spName = "sp_Update_TruckType";

                    reader = monitoring.ExecuteReader(spName, id, trucktype, description, limitbase, limit, km, hr);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Saved..");
                        truckTypeControl.edittruckgroup.Hide();
                        truckTypeControl.lblId.Text = "";
                        truckTypeControl.txtTrucktype.Text = "";
                        truckTypeControl.txtDescription.Text = "";
                        truckTypeControl.cmbLimitBase.Text = "";
                        truckTypeControl.txtLimit.Text = "";
                        truckTypeControl.txtkmLimit.Text = "";
                        truckTypeControl.txtHr.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Employee " + Name + " Not Exist");
                    }

                    TruckList();
                    //TankList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void truckTypelnkDelete(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + truckTypeControl.lblId.Text + "'";
                    string spName = "sp_Delete_TruckType";

                    reader = monitoring.ExecuteReader(spName, id);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Deleted..");
                        truckTypeControl.edittruckgroup.Hide();
                        truckTypeControl.lblId.Text = "";
                        truckTypeControl.txtTrucktype.Text = "";
                        truckTypeControl.txtDescription.Text = "";
                        truckTypeControl.cmbLimitBase.Text = "";
                        truckTypeControl.txtLimit.Text = "";
                        truckTypeControl.txtkmLimit.Text = "";
                        truckTypeControl.txtHr.Text = "";
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Truck Type Not Exist");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete..");
                    }
                    TruckList();
                    //TankList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        ////////////////////
        ////////////////////

        #endregion   End truckType



        #region Fuel Type

        private void btnFuelType(object sender, EventArgs e)
        {
            try
            {
                if (ckFuelType == 0)
                {
                    FuelList();
                    ckFuelType++;
                }

                allSetupControl.categorypanel.Hide();
                allSetupControl.PositionPanel.Hide();
                allSetupControl.TrucktypePanel.Hide();
                allSetupControl.Tanktypepanel.Hide();
                allSetupControl.EmployeePanel.Hide();
                allSetupControl.ProjectSitepanel.Hide();
                allSetupControl.FueltypePanel.Show();
                fuelTypeControl.BringToFront();
                lbMonitoringLast.Text = "fuelType";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FuelList()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_FuelList with (nolock) where IsDelete = '1'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            fuelTypeControl.dgvFuelList.DataSource = null;

            if (this.fuelTypeControl.dgvFuelList.DataSource != null)
            {
                this.fuelTypeControl.dgvFuelList.DataSource = null;
            }
            else
            {
                this.fuelTypeControl.dgvFuelList.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    fuelTypeControl.dgvFuelList.Rows.Add(row["Id"].ToString()
                           , row["FuelType"].ToString()
                           );
                }
            }
            else
            {
            }
        }

        private void fuelTypeAdd(object sender, EventArgs e)
        {
            try
            {
                fuelTypeControl.AddGroup.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fuelTypebtnAddCancel(object sender, EventArgs e)
        {
            try
            {
                fuelTypeControl.dgvAddFuelList.Rows.Clear();
                fuelTypeControl.AddGroup.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fuelTypeAddbtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlDataReader reader;
                    string spName = "sp_Add_FuelType";
                    int numRows = fuelTypeControl.dgvAddFuelList.Rows.Count;
                    int loop = numRows - 1;

                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            string FuelType = "'" + fuelTypeControl.dgvAddFuelList.Rows[i].Cells[0].FormattedValue.ToString() + "'";

                            reader = monitoring.ExecuteReader(spName, FuelType);
                            DataTable result = new DataTable();
                            result.Load(reader);
                            string Result = result.Rows[0]["Result"].ToString();

                            if (Result == "1")
                            {
                                fuelTypeControl.dgvAddFuelList.Rows.Remove(fuelTypeControl.dgvAddFuelList.Rows[i]);
                                i = i - 1;
                                loop = loop - 1;
                            }
                            else if (Result == "2")
                            {
                                MessageBox.Show("Fuel Type:  " + FuelType + " Already Exist");
                                fuelTypeControl.dgvAddFuelList.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                            else
                            {
                                fuelTypeControl.dgvAddFuelList.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                        }

                        FuelList();
                        RefillFuelList();
                    }
                    else
                    {
                        MessageBox.Show("The Gridview empty.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFuelList_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    fuelTypeControl.EditGroup.Show();
                    fuelTypeControl.lblOldFuelType.Text = fuelTypeControl.dgvFuelList[0, e.RowIndex].Value.ToString();
                    fuelTypeControl.txtTypeofFuel.Text = fuelTypeControl.dgvFuelList[1, e.RowIndex].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fuelTypebtnCancel(object sender, EventArgs e)
        {
            try
            {
                fuelTypeControl.EditGroup.Hide();
                fuelTypeControl.lblOldFuelType.Text = "";
                fuelTypeControl.txtTypeofFuel.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FuelTypebtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + fuelTypeControl.lblOldFuelType.Text + "'";
                    string FuelType = "'" + fuelTypeControl.txtTypeofFuel.Text + "'";
                    string spName = "sp_Update_FuelType";

                    reader = monitoring.ExecuteReader(spName, id, FuelType);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Saved..");
                        fuelTypeControl.EditGroup.Hide();
                        fuelTypeControl.lblOldFuelType.Text = "";
                        fuelTypeControl.txtTypeofFuel.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Fuel " + FuelType + " Not Exist");
                    }

                    FuelList();
                    RefillFuelList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fuelTypelnkDelete(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + fuelTypeControl.lblOldFuelType.Text + "'";
                    string spName = "sp_Delete_Fuel";

                    reader = monitoring.ExecuteReader(spName, id);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Deleted..");
                        fuelTypeControl.EditGroup.Hide();
                        fuelTypeControl.lblOldFuelType.Text = "";
                        fuelTypeControl.txtTypeofFuel.Text = "";
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Fuel Type Not Exist");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete..");
                    }

                    FuelList();
                    RefillFuelList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        ////////////////////
        ////////////////////
        #endregion end Fuel

        #region Tank Type
        private void btnTankType(object sender, EventArgs e)
        {
            try
            {
                if (ckTankType == 0)
                {
                    ckTankType++;
                }

                allSetupControl.categorypanel.Hide();
                allSetupControl.PositionPanel.Hide();
                allSetupControl.TrucktypePanel.Hide();
                allSetupControl.FueltypePanel.Hide();
                allSetupControl.EmployeePanel.Hide();
                allSetupControl.ProjectSitepanel.Hide();
                allSetupControl.Tanktypepanel.Show();
                tankTypeControl.BringToFront();
                lbMonitoringLast.Text = "tankType";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void TankTypeList()
        {
            dtTankList.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select * from m_TankList with (nolock) where IsDelete = '1'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Fill(dtTankList);

            tankTypeControl.dgvTankType.DataSource = null;

            if (this.tankTypeControl.dgvTankType.DataSource != null)
            {
                this.tankTypeControl.dgvTankType.DataSource = null;
            }
            else
            {
                this.tankTypeControl.dgvTankType.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    tankTypeControl.dgvTankType.Rows.Add(row["Id"].ToString()
                           , row["TypeOfFuel"].ToString()
                           , row["TankName"].ToString()
                           , row["EquipmentNo"].ToString()
                           , row["Model"].ToString()
                           , row["PlateNo"].ToString()
                           , row["TankCapacity"].ToString()
                           , row["TankGuage"].ToString()
                           , row["IsMainTank"].ToString() == "1" ? "YES" : "NO"
                           , row["FuelLimit"].ToString()
                           );
                }
            }
            else
            {
            }

            Tankcombo.HeaderText = "SOURCE OF FUEL";
            Tankcombo.Name = "Source";
        
            //Tankcombo.Rows.Clear()
            //adddaily
            ArrayList rows = new ArrayList();

            foreach (DataRow dr in dt.Rows)
            {
                rows.Add(dr["TankName"].ToString());
            }

             Tankcombo.Items.Clear();
            
             Tankcombo.Items.AddRange(rows.ToArray());

            if (addDailyControl.dgvDailySheet.Columns.Contains(Tankcombo) == false)
            {
                addDailyControl.dgvDailySheet.Columns.Add(Tankcombo);
            }
            else
            {
                addDailyControl.dgvDailySheet.Columns.Remove(Tankcombo);
                addDailyControl.dgvDailySheet.Columns.Add(Tankcombo);
            }
            addDailyControl.dgvDailySheet.Columns[11].Width = 180;

        }

        private void tankTypeAdd(object sender, EventArgs e)
        {
            try
            {
                FuelTankTypeList();
                TypeOfFuelList();
                tankTypeControl.AddGroup.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tankTypebtnAddCancel(object sender, EventArgs e)
        {
            try
            {
                tankTypeControl.dgvAddTankType.Rows.Clear();
                tankTypeControl.AddGroup.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TypeOfFuelList()
        {
            FuelListcombo.Items.Clear();
            FuelListcombo.HeaderText = "TYPE OF FUEL";
            FuelListcombo.Name = "TYPEOFFUELADD";

            ArrayList row = new ArrayList();

            foreach (DataRow dr in dtFuelList.Rows)
            {
                row.Add(dr["FuelType"].ToString());
            }



            tankTypeControl.dgvAddTankType.Columns.Remove("TYPEOFFUELADD");
            FuelListcombo.Items.AddRange(row.ToArray());
            tankTypeControl.dgvAddTankType.Columns.Add(FuelListcombo);
            tankTypeControl.dgvAddTankType.Columns[8].Width = 155;

        }
        public void TypeOfFuelList1()
        {
            FuelListcombo.Items.Clear();
            FuelListcombo.HeaderText = "TYPE OF FUEL";
            FuelListcombo.Name = "TYPEOFFUELADD";

            ArrayList row = new ArrayList();

            foreach (DataRow dr in dtFuelList.Rows)
            {
                row.Add(dr["FuelType"].ToString());
            }



            FuelListcombo.Items.AddRange(row.ToArray());
            tankTypeControl.dgvAddTankType.Columns.Add(FuelListcombo);
            tankTypeControl.dgvAddTankType.Columns[8].Width = 155;

        }


        private void FuelTankTypeList()
        {
            dtFuelList.Clear();
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from m_FuelList with(nolock) where IsDelete = '1'", Connection);

                da.Fill(dtFuelList);
                // CONVERT(VARCHAR(10), Date, 101)
                tankTypeControl.cmbTypeofFuel.DataSource = dtFuelList;
                tankTypeControl.cmbTypeofFuel.DisplayMember = "FuelType";
                tankTypeControl.cmbTypeofFuel.ValueMember = "FuelType";

                //Fuel Main log Sheet
                fuelMainLogControl.cmbfueltype.DataSource = dtFuelList;
                fuelMainLogControl.cmbfueltype.DisplayMember = "FuelType";
                fuelMainLogControl.cmbfueltype.ValueMember = "FuelType";


                //Fuel Tanker truck log Sheet
                fuelTankerLogControl.cmbfueltype.DataSource = dtFuelList;
                fuelTankerLogControl.cmbfueltype.DisplayMember = "FuelType";
                fuelTankerLogControl.cmbfueltype.ValueMember = "FuelType";

               TankerMainList(fuelMainLogControl.cmbfueltype.SelectedValue.ToString());
               DateMainRefillParent(fuelMainLogControl.cmbTanktruck.SelectedValue.ToString());

                TankerTruckList(fuelTankerLogControl.cmbfueltype.SelectedValue.ToString());
                DateTankerTruckRefillParent(fuelTankerLogControl.cmbTanktruck.SelectedValue.ToString());



            }
        }

        private void tankTypeAddbtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string ismain;
                    SqlDataReader reader;
                    string spName = "sp_Add_Tanklist";
                    int numRows = tankTypeControl.dgvAddTankType.Rows.Count;
                    int loop = numRows - 1;

                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            string FuelType = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                            //if (Convert.ToBoolean(dgvDailySheet.Rows[i].Cells["tank"].Value) == true)
                            if (Convert.ToBoolean(tankTypeControl.dgvAddTankType.Rows[i].Cells["MAINTANK"].Value) == true)
                            {
                                ismain = "1";
                            }
                            else
                            {
                                ismain = "0";
                            }

                            string ParamTankName = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                            string ParamEquipmentNo = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                            string ParamModelName = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[2].FormattedValue.ToString() + "'";
                            string ParamPlateNo = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[3].FormattedValue.ToString() + "'";
                            string ParamTankCapacity = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[4].FormattedValue.ToString() + "'";
                            string paramTankGauge = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                            string ParamTypeOfType = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[8].FormattedValue.ToString() + "'";
                            string ParamFuelLimit = "'" + tankTypeControl.dgvAddTankType.Rows[i].Cells[7].FormattedValue.ToString() + "'";
                            string ischeckparam = "'" + ismain + "'";

                            reader = monitoring.ExecuteReader(spName, ParamTypeOfType, ParamTankName, ParamEquipmentNo, ParamPlateNo, ParamModelName, ParamTankCapacity, paramTankGauge, ischeckparam, ParamFuelLimit);
                            DataTable result = new DataTable();
                            result.Load(reader);
                            string Result = result.Rows[0]["Result"].ToString();

                            if (Result == "1")
                            {
                                tankTypeControl.dgvAddTankType.Rows.Remove(tankTypeControl.dgvAddTankType.Rows[i]);
                                i = i - 1;
                                loop = loop - 1;
                            }
                            else if (Result == "2")
                            {
                                MessageBox.Show("Tank Type:  " + FuelType + " Already Exist");
                                tankTypeControl.dgvAddTankType.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                            else
                            {
                                tankTypeControl.dgvAddTankType.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                        }

                        TankTypeList();
                        FuelTankTypeList();
                        addDailyControl.dgvDailySheet.Columns.Remove("TankName");
                    }
                    else
                    {
                        MessageBox.Show("The Gridview empty.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTankType_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string main;
                    tankTypeControl.EditGroup.Show();
                    tankTypeControl.lblId.Text = tankTypeControl.dgvTankType[0, e.RowIndex].Value.ToString();
                    tankTypeControl.cmbTypeofFuel.Text = tankTypeControl.dgvTankType[1, e.RowIndex].Value.ToString();
                    tankTypeControl.txtTankName.Text = tankTypeControl.dgvTankType[2, e.RowIndex].Value.ToString();
                    tankTypeControl.txtEquipmentNo.Text = tankTypeControl.dgvTankType[3, e.RowIndex].Value.ToString();
                    tankTypeControl.txtModelName.Text = tankTypeControl.dgvTankType[4, e.RowIndex].Value.ToString();
                    tankTypeControl.txtPlateNo.Text = tankTypeControl.dgvTankType[5, e.RowIndex].Value.ToString();
                    tankTypeControl.txtTankCapacity.Text = tankTypeControl.dgvTankType[6, e.RowIndex].Value.ToString();
                    tankTypeControl.txtGauge.Text = tankTypeControl.dgvTankType[7, e.RowIndex].Value.ToString();
                    tankTypeControl.txtfuelLimit.Text = tankTypeControl.dgvTankType[9, e.RowIndex].Value.ToString();
                    main = tankTypeControl.dgvTankType[8, e.RowIndex].Value.ToString();

                    if (main == "YES")
                    {
                        tankTypeControl.chkIsMain.Checked = true;
                    }
                    else
                    {
                        tankTypeControl.chkIsMain.Checked = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tankTypebtnCancel(object sender, EventArgs e)
        {
            try
            {
                tankTypeControl.EditGroup.Hide();
                tankTypeControl.cmbTypeofFuel.Text = "";
                tankTypeControl.txtTankName.Text = "";
                tankTypeControl.txtEquipmentNo.Text = "";
                tankTypeControl.txtModelName.Text = "";
                tankTypeControl.txtPlateNo.Text = "";
                tankTypeControl.txtTankCapacity.Text = "";
                tankTypeControl.txtGauge.Text = "";
                tankTypeControl.txtfuelLimit.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tankTypelnkDelete(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + tankTypeControl.lblId.Text + "'";
                    string spName = "sp_Delete_Tanklist";

                    reader = monitoring.ExecuteReader(spName, id);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Deleted..");
                        tankTypeControl.EditGroup.Hide();
                        tankTypeControl.cmbTypeofFuel.Text = "";
                        tankTypeControl.txtTankName.Text = "";
                        tankTypeControl.txtEquipmentNo.Text = "";
                        tankTypeControl.txtModelName.Text = "";
                        tankTypeControl.txtPlateNo.Text = "";
                        tankTypeControl.txtTankCapacity.Text = "";
                        tankTypeControl.txtGauge.Text = "";
                        tankTypeControl.txtfuelLimit.Text = "";
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Fuel Type Not Exist");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete..");
                    }

                    TankTypeList();
                    addDailyControl.dgvDailySheet.Columns.Remove("TankName");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tankTypebtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string spName = "sp_Update_Tanklist";

                    string ischeckparam;

                    if (tankTypeControl.chkIsMain.Checked == true)
                    {
                        ischeckparam = "'" + "1" + "'";
                    }
                    else
                    {
                        ischeckparam = "'" + "0" + "'";
                    }

                    string id = "'" + tankTypeControl.lblId.Text + "'";
                    string ParamTypeOfType = "'" + tankTypeControl.cmbTypeofFuel.SelectedValue.ToString() + "'";
                    string ParamTankName = "'" + tankTypeControl.txtTankName.Text + "'";
                    string ParamEquipmentNo = "'" + tankTypeControl.txtEquipmentNo.Text + "'";
                    string ParamModelName = "'" + tankTypeControl.txtModelName.Text + "'";
                    string ParamPlateNo = "'" + tankTypeControl.txtPlateNo.Text + "'";
                    string paramTankGauge = "'" + tankTypeControl.txtGauge.Text + "'";
                    string paramFuelLimit = "'" + tankTypeControl.txtfuelLimit.Text + "'";
                    string ParamTankCapacity = "'" + tankTypeControl.txtTankCapacity.Text.Replace(",", "").Replace(" ", "") + "'";

                    reader = monitoring.ExecuteReader(spName, id, ParamTypeOfType, ParamTankName, ParamEquipmentNo, ParamPlateNo, ParamModelName, ParamTankCapacity, paramTankGauge, ischeckparam, paramFuelLimit);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Saved..");
                        tankTypeControl.EditGroup.Hide();
                        tankTypeControl.cmbTypeofFuel.Text = "";
                        tankTypeControl.txtTankName.Text = "";
                        tankTypeControl.txtEquipmentNo.Text = "";
                        tankTypeControl.txtModelName.Text = "";
                        tankTypeControl.txtPlateNo.Text = "";
                        tankTypeControl.txtTankCapacity.Text = "";
                        tankTypeControl.txtGauge.Text = "";
                        tankTypeControl.txtfuelLimit.Text = "";

                        TankTypeList();
                        FuelTankTypeList();
                    }
                    else
                    {
                        MessageBox.Show("Tank Type " + ParamTankName + " Not Exist");
                    }

                    GetFuelLimit();
                    // addDailyControl.dgvDailySheet.Columns.Remove("TankName");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ////////////////////
        ////////////////////
        #endregion end TankType

        #region Category

        private void btnCategory(object sender, EventArgs e)
        {
            try
            {
                if (ckCategory == 0)
                {
                    ckCategory++;
                }

                allSetupControl.PositionPanel.Hide();
                allSetupControl.TrucktypePanel.Hide();
                allSetupControl.FueltypePanel.Hide();
                allSetupControl.Tanktypepanel.Hide();
                allSetupControl.EmployeePanel.Hide();
                allSetupControl.ProjectSitepanel.Hide();
                allSetupControl.categorypanel.Show();
                categoryControl.BringToFront();
                lbMonitoringLast.Text = "category";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategorysList()
        {
            dtCategoryNoAll.Clear();
            dtSubCategory.Clear();
            Categorycombo.Items.Clear();
            SqlDataAdapter das = new SqlDataAdapter("select m_CategoryList.Category, m_CategoryList.id from m_CategoryList with (nolock) where Category != 'ALL' and IsDelete = '1' order by id asc", Connection);
            das.Fill(dtSubCategory);
            SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category], id, RType from m_SubCategoryList with(nolock) where [Sub-Category] != 'All'" +
                    //  "and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All') " +
                    "and IsDelete = '1' order by Category asc, id asc", Connection);
            //  DataTable dt = new DataTable();
            da.Fill(dtCategoryNoAll);

            categoryControl.dgvCategory.DataSource = null;

            if (this.categoryControl.dgvCategory.DataSource != null)
            {
                this.categoryControl.dgvCategory.DataSource = null;
            }
            else
            {
                this.categoryControl.dgvCategory.Rows.Clear();
            }

            int intRecord = dtCategoryNoAll.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtCategoryNoAll.Rows)
                {
                    categoryControl.dgvCategory.Rows.Add(row["id"].ToString()
                        , row["Category"].ToString()
                        , row["Sub-Category"].ToString()
                        , row["RType"].ToString() == "NA" ? "N/A" : row["RType"].ToString()
                        ); ;
                }
            }
            else
            {
            }

            CategoryParent();
        }


        private void CategorysListsearch()
        {
            if (categoryControl.cmbCategory.Text != "ALL")
            {
                dtCategoryNoAll.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category], id, RType from m_SubCategoryList with(nolock) where [Sub-Category] != 'All'" +
                          "and Category = '" + categoryControl.cmbCategory.Text + "'" +
                        //  "and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All') " +
                        "and IsDelete = '1' order by Category asc, id asc", Connection);
                //  DataTable dt = new DataTable();
                da.Fill(dtCategoryNoAll);

                categoryControl.dgvCategory.DataSource = null;

                if (this.categoryControl.dgvCategory.DataSource != null)
                {
                    this.categoryControl.dgvCategory.DataSource = null;
                }
                else
                {
                    this.categoryControl.dgvCategory.Rows.Clear();
                }

                int intRecord = dtCategoryNoAll.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dtCategoryNoAll.Rows)
                    {
                        categoryControl.dgvCategory.Rows.Add(row["id"].ToString()
                            , row["Category"].ToString()
                            , row["Sub-Category"].ToString()
                            , row["RType"].ToString() == "NA" ? "N/A" : row["RType"].ToString()
                            );
                    }
                }
                else
                {
                }
            }
            else
            {

                dtCategoryNoAll.Clear();
                SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category], id, RType from m_SubCategoryList with(nolock) where [Sub-Category] != 'All'" +

                        //  "and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All') " +
                        "and IsDelete = '1' order by Category asc, id asc", Connection);
                //  DataTable dt = new DataTable();
                da.Fill(dtCategoryNoAll);

                categoryControl.dgvCategory.DataSource = null;

                if (this.categoryControl.dgvCategory.DataSource != null)
                {
                    this.categoryControl.dgvCategory.DataSource = null;
                }
                else
                {
                    this.categoryControl.dgvCategory.Rows.Clear();
                }

                int intRecord = dtCategoryNoAll.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dtCategoryNoAll.Rows)
                    {
                        categoryControl.dgvCategory.Rows.Add(row["id"].ToString()
                            , row["Category"].ToString()
                            , row["Sub-Category"].ToString()
                            , row["RType"].ToString() == "NA" ? "N/A" : row["RType"].ToString()
                            );
                    }
                }
                else
                {
                }
            }

            //CategoryParent1();
        }

        private void CategoryParent1()
        {
            dtCategory.Clear();

            SqlDataAdapter da = new SqlDataAdapter("select * from m_CategoryList with(nolock) where IsDelete = '1'", Connection);
            da.Fill(dtCategory);


            categoryControl.cmbCategoryList.DataSource = dtSubCategory;
            categoryControl.cmbCategoryList.DisplayMember = "Category";
            categoryControl.cmbCategoryList.ValueMember = "Category";



            maintenanceAndRepair.cmbCategory.DataSource = dtCategory;
            maintenanceAndRepair.cmbCategory.DisplayMember = "Category";
            maintenanceAndRepair.cmbCategory.ValueMember = "Category";


            allMaintenanceExpenses.cmbCategory.DataSource = dtCategory;
            allMaintenanceExpenses.cmbCategory.DisplayMember = "Category";
            allMaintenanceExpenses.cmbCategory.ValueMember = "Category";


            unitListDetail.expensesViewControl.cmbECategory.DataSource = dtCategory;
            unitListDetail.expensesViewControl.cmbECategory.DisplayMember = "Category";
            unitListDetail.expensesViewControl.cmbECategory.ValueMember = "Category";



            Categorycombo.HeaderText = "CATEGORY";
            Categorycombo.Name = "Categorys";


            ArrayList row = new ArrayList();
            //rowCategory.Clear();

            foreach (DataRow dr in dtSubCategory.Rows)
            {
                row.Add(dr["Category"].ToString());
            }


            categoryControl.dgvSubCategory.Columns.Remove("Categorys");


            Categorycombo.Items.AddRange(row.ToArray());

            categoryControl.dgvSubCategory.Columns.Add(Categorycombo);
            categoryControl.dgvSubCategory.Columns[2].Width = 257;

        }

        private void CategoryParent()
        {
            dtCategory.Clear();

            SqlDataAdapter da = new SqlDataAdapter("select * from m_CategoryList with(nolock) where IsDelete = '1'", Connection);
            da.Fill(dtCategory);

            categoryControl.cmbCategory.DataSource = dtCategory;
            categoryControl.cmbCategory.DisplayMember = "Category";
            categoryControl.cmbCategory.ValueMember = "Category";

            categoryControl.cmbCategoryList.DataSource = dtSubCategory;
            categoryControl.cmbCategoryList.DisplayMember = "Category";
            categoryControl.cmbCategoryList.ValueMember = "Category";


            allMaintenanceExpenses.cmbCategory.DataSource = dtCategory;
            allMaintenanceExpenses.cmbCategory.DisplayMember = "Category";
            allMaintenanceExpenses.cmbCategory.ValueMember = "Category";

            maintenanceAndRepair.cmbCategory.DataSource = dtCategory;
            maintenanceAndRepair.cmbCategory.DisplayMember = "Category";
            maintenanceAndRepair.cmbCategory.ValueMember = "Category";


            unitListDetail.expensesViewControl.cmbECategory.DataSource = dtCategory;
            unitListDetail.expensesViewControl.cmbECategory.DisplayMember = "Category";
            unitListDetail.expensesViewControl.cmbECategory.ValueMember = "Category";



            Categorycombo.HeaderText = "CATEGORY";
            Categorycombo.Name = "Categorys";


            ArrayList row = new ArrayList();
            //rowCategory.Clear();

            foreach (DataRow dr in dtSubCategory.Rows)
            {
                row.Add(dr["Category"].ToString());
            }


            categoryControl.dgvSubCategory.Columns.Remove("Categorys");


            Categorycombo.Items.AddRange(row.ToArray());

            categoryControl.dgvSubCategory.Columns.Add(Categorycombo);
            categoryControl.dgvSubCategory.Columns[2].Width = 257;

        }

        private void categoryTypeAdd(object sender, EventArgs e)
        {
            try
            {
                categoryControl.AddCategoryGroup.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubcategoryTypeAdd(object sender, EventArgs e)
        {
            try
            {
                isSubClick = 1;
                categoryControl.AddSubCategoryGroup.Show();
            }
            catch (Exception ex)
            {
                isSubClick = 0;
                MessageBox.Show(ex.Message);
            }
        }


        private void CategorybtnAddCancel(object sender, EventArgs e)
        {
            try
            {
                categoryControl.dgvCategoryAdd.Rows.Clear();
                categoryControl.AddCategoryGroup.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubbtnSubCancel(object sender, EventArgs e)
        {
            try
            {
                categoryControl.dgvSubCategory.Rows.Clear();
                categoryControl.AddSubCategoryGroup.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCategory_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if(categoryControl.dgvCategory[1, e.RowIndex].Value.ToString() == categoryControl.dgvCategory[2, e.RowIndex].Value.ToString())
                    {
                        MessageBox.Show("Cannot Edit Equal Category and Sub-Category");
                    }
                    else
                    {
                        categoryControl.EditCategoryGroup.Show();
                        categoryControl.lblCategoryid.Text = categoryControl.dgvCategory[0, e.RowIndex].Value.ToString();
                        categoryControl.lblCategory.Text = categoryControl.dgvCategory[1, e.RowIndex].Value.ToString();
                        categoryControl.cmbCategoryList.Text = categoryControl.dgvCategory[1, e.RowIndex].Value.ToString();
                        categoryControl.lblSubCategory.Text = categoryControl.dgvCategory[2, e.RowIndex].Value.ToString();
                        categoryControl.txtSubCategory.Text = categoryControl.dgvCategory[2, e.RowIndex].Value.ToString();
                        categoryControl.lblRType.Text = categoryControl.dgvCategory[3, e.RowIndex].Value.ToString();
                        categoryControl.cmdRepairType.Text = categoryControl.dgvCategory[3, e.RowIndex].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categorybtnCancel(object sender, EventArgs e)
        {
            try
            {
                categoryControl.EditCategoryGroup.Hide();
                categoryControl.lblCategoryid.Text = "";
                categoryControl.lblCategory.Text = "";
                categoryControl.lblSubCategory.Text = "";
                categoryControl.txtSubCategory.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categoryddbtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlDataReader reader;
                    string spName = "sp_Add_Category";
                    int numRows = categoryControl.dgvCategoryAdd.Rows.Count;
                    int loop = numRows - 1;


                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            string RType = categoryControl.dgvCategoryAdd.Rows[i].Cells[1].FormattedValue.ToString().Replace("/","");
                            string Category = "'" + categoryControl.dgvCategoryAdd.Rows[i].Cells[0].FormattedValue.ToString().ToUpper() + "'";


                            reader = monitoring.ExecuteReader(spName, Category, RType);
                            DataTable result = new DataTable();
                            result.Load(reader);
                            string Result = result.Rows[0]["Result"].ToString();

                            if (Result == "1")
                            {
                                categoryControl.dgvCategoryAdd.Rows.Remove(categoryControl.dgvCategoryAdd.Rows[i]);
                                i = i - 1;
                                loop = loop - 1;
                            }
                            else if (Result == "2")
                            {
                                MessageBox.Show("Category " + Category + " Already Exist");
                                categoryControl.dgvCategoryAdd.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                            else
                            {
                                categoryControl.dgvCategoryAdd.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                        }
                        if(isSubClick == 1)
                        {
                            categoryControl.dgvSubCategory.Columns.Remove("Category");
                        }
                        //CategorysList();
                        CategorysList();
                        CategoryParent1();
                        CategoryParent();
                        CategorysListsearch();
                    }
                    else
                    {
                        MessageBox.Show("The Gridview empty.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categorySubaddbtnSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlDataReader reader;
                    string spName = "sp_Add_SubCategory";
                    string Category = "";
                    string SubCategory = "";
                    int numRows = categoryControl.dgvSubCategory.Rows.Count;
                    int loop = numRows - 1;

                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            //Category = "'" + categoryControl.dgvCategoryAdd.Rows[i].Cells[0].FormattedValue.ToString().ToUpper() + "'";
                            if (Convert.ToString(categoryControl.dgvSubCategory.Rows[i].Cells[0].FormattedValue) != string.Empty)
                            {
                                SubCategory = "'" + categoryControl.dgvSubCategory.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                            }

                            if (Convert.ToString(categoryControl.dgvSubCategory.Rows[i].Cells[2].FormattedValue) != string.Empty)
                            {
                                Category = "'" + categoryControl.dgvSubCategory.Rows[i].Cells[2].FormattedValue.ToString() + "'";
                            }

                            string RType = categoryControl.dgvSubCategory.Rows[i].Cells[1].FormattedValue.ToString().Replace("/", "");

                            reader = monitoring.ExecuteReader(spName, Category, SubCategory, RType);

                            DataTable result = new DataTable();
                            result.Load(reader);
                            string Result = result.Rows[0]["Result"].ToString();

                            if (Result == "1")
                            {
                                categoryControl.dgvSubCategory.Rows.Remove(categoryControl.dgvSubCategory.Rows[i]);
                                i = i - 1;
                                loop = loop - 1;
                            }
                            else if (Result == "2")
                            {
                                MessageBox.Show("Sub-Category " + SubCategory + " CATEGORY : " + Category + "  Already Exist");
                                categoryControl.dgvSubCategory.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                            else
                            {
                                categoryControl.dgvCategoryAdd.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            }
                        }

                        if (isSubClick == 1)
                        {
                            categoryControl.dgvSubCategory.Columns.Remove("Category");
                        }
                        //CategorysList();
                        CategorysList();
                        CategoryParent1();
                        CategoryParent();
                        CategorysListsearch();
                    }
                    else
                    {
                        MessageBox.Show("The Gridview empty.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categorybtnSave(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue to Save", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string result = "";
                SqlDataReader reader;
                // "'" + Equipmentno + "'";
                string id = "'" + categoryControl.lblCategoryid.Text + "'";
                string OrigCategory = "'" + categoryControl.lblCategory.Text + "'";
                string NewCategory = "'" + categoryControl.cmbCategoryList.SelectedValue.ToString() + "'";
                string OrigSub = "'" + categoryControl.lblSubCategory.Text + "'";
                string NewSub = "'" + categoryControl.txtSubCategory.Text + "'";
                string RType = "'" + categoryControl.cmdRepairType.SelectedItem.ToString() + "'";

                string spName = "sp_Update_SubCategory";

                reader = monitoring.ExecuteReader(spName, id, OrigCategory, NewCategory, OrigSub, NewSub, RType);
                DataTable Detail = new DataTable();
                Detail.Load(reader);
                result = Detail.Rows[0]["Result"].ToString();

                if (result == "1")
                {
                    MessageBox.Show("Successfully Saved..");
                    categoryControl.EditCategoryGroup.Hide();
                    categoryControl.lblCategoryid.Text = "";
                    categoryControl.lblCategory.Text = "";
                    categoryControl.lblSubCategory.Text = "";
                    categoryControl.txtSubCategory.Text = "";

                    if (isSubClick == 1)
                    {
                        categoryControl.dgvSubCategory.Columns.Remove("Category");
                    }
                    //CategorysList();
                    CategorysList();
                    CategoryParent1();
                    CategoryParent();
                    CategorysListsearch();
                }
                else
                {
                    MessageBox.Show("Failed To Saved..");
                }
            }
        }

        private void lnkEditCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pCategory = categoryControl.cmbCategory.SelectedValue.ToString().ToUpper();

            if (pCategory == "ALL")
            {
                MessageBox.Show("Please Select Category");
            }
            else
            {
                RenameCategory rename = new RenameCategory();
                rename.param(pCategory);
                rename.ShowDialog();

                if (isSubClick == 1)
                {
                    categoryControl.dgvSubCategory.Columns.Remove("Category");
                }
                // categoryControl.dgvSubCategory.Columns.Remove("Category");
                CategorysList();
                CategorysList();
                CategoryParent1();
                CategoryParent();
                CategorysListsearch();
            }
        }

        private void categorySearch(object sender, EventArgs e)
        {
            string pCategory = categoryControl.cmbCategory.SelectedValue.ToString().ToUpper();
            CategorysListsearch();
        }

        // categoryControl.lnkDelete.Click += categorylnkDelete;
        private void categorylnkDelete(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + categoryControl.lblCategoryid.Text + "'";
                    string spName = "sp_Delete_SubCategory";

                    reader = monitoring.ExecuteReader(spName, id);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Deleted..");
                        categoryControl.EditCategoryGroup.Hide();
                        categoryControl.lblCategoryid.Text = "";
                        categoryControl.lblCategory.Text = "";
                        categoryControl.cmbCategoryList.Text = "";
                        categoryControl.lblSubCategory.Text = "";
                        categoryControl.txtSubCategory.Text = "";
                        //tankTypeControl.EditGroup.Hide();
                        //tankTypeControl.cmbTypeofFuel.Text = "";
                        //tankTypeControl.txtTankName.Text = "";
                        //tankTypeControl.txtEquipmentNo.Text = "";
                        //tankTypeControl.txtModelName.Text = "";
                        //tankTypeControl.txtPlateNo.Text = "";
                        //tankTypeControl.txtTankCapacity.Text = "";
                        //tankTypeControl.txtGauge.Text = "";
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Fuel Type Not Exist");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete..");
                    }

                    if (isSubClick == 1)
                    {
                        categoryControl.dgvSubCategory.Columns.Remove("Category");
                    }
                    CategorysList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        ////////////////////
        ////////////////////
        #endregion End category

        #region ProjectSite

        private void btnProjectSite(object sender, EventArgs e)
        {
            try
            {
                if (ckProjectsite == 0)
                {
                    //  ProjectSiteList(projectSiteControl.txtSearch.Text);
                    ckProjectsite++;
                }

                allSetupControl.PositionPanel.Hide();
                allSetupControl.TrucktypePanel.Hide();
                allSetupControl.FueltypePanel.Hide();
                allSetupControl.Tanktypepanel.Hide();
                allSetupControl.EmployeePanel.Hide();
                allSetupControl.categorypanel.Hide();
                allSetupControl.ProjectSitepanel.Show();
                projectSiteControl.BringToFront();
                lbMonitoringLast.Text = "projectsite";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmbProjectSiteSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  EquipmentNoCollection.Clear();
            if (projectSiteControl.cmbProject.SelectedIndex == 0)
            {
                ProjectSiteSearchType = "ProjectNo";
                projectSiteControl.txtSearch.AutoCompleteCustomSource = ProjectNoCollection;
            }
            else if (projectSiteControl.cmbProject.SelectedIndex == 1)
            {
                ProjectSiteSearchType = "ProjectSite";
                projectSiteControl.txtSearch.AutoCompleteCustomSource = ProjectSiteCollection;
            }
            else
            {
                ProjectSiteSearchType = "ProjectDate";
                projectSiteControl.txtSearch.AutoCompleteCustomSource = ProjectDateCollection;
            }
        }

        private void ProjectSitetxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    ProjectbtnSearch(projectSiteControl.btnSearch, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectSiteList(string value)
        {
            dtProjectSite.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select m_ProjectSite.id, m_ProjectSite.ProjectSite, m_ProjectSite.ProjectNo,CONVERT(varchar(20), m_ProjectSite.ProjectDate, 101) " +
                "as ProjectDate from m_ProjectSite with(nolock) where IsDelete = '1' and ProjectSite like '%" + value + "%' order by id desc", Connection);

            da.Fill(dtProjectSite);

            projectSiteControl.dgvProjectList.DataSource = null;

            if (this.projectSiteControl.dgvProjectList.DataSource != null)
            {
                this.projectSiteControl.dgvProjectList.DataSource = null;
            }
            else
            {
                this.projectSiteControl.dgvProjectList.Rows.Clear();
            }

            int intRecord = dtProjectSite.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtProjectSite.Rows)
                {
                    projectSiteControl.dgvProjectList.Rows.Add(row["id"].ToString()
                        , row["ProjectSite"].ToString()
                        , row["ProjectNo"].ToString()
                        , row["ProjectDate"].ToString()
                        );



                    ProjectSiteCollection.Add(row["ProjectSite"].ToString());
                    ProjectNoCollection.Add(row["ProjectNo"].ToString());
                    ProjectDateCollection.Add(row["ProjectDate"].ToString());

                    ProjectSiteArray.Add(row["ProjectNo"].ToString());

                }

                monthlyFormControl.projectSiteMonthlyControl.txtSearch.AutoCompleteCustomSource = ProjectNoCollection;
                projectSiteControl.txtSearch.AutoCompleteCustomSource = ProjectNoCollection;
                overallReportControl.projectSiteOverAllControl.txtSearch.AutoCompleteCustomSource = ProjectNoCollection;
                allMaintenanceExpenses.txtProjectId.AutoCompleteCustomSource = ProjectNoCollection;

                maintenanceAndRepair.txtProjectId.AutoCompleteCustomSource = ProjectNoCollection;
                //overallReportControl.truckOverallExpensesControl.txtSearch.AutoCompleteCustomSource = ProjectNoCollection;
            }

        }

        private void ProjectAddLnk(object sender, EventArgs e)
        {
            try
            {
                projectSiteControl.AddGroup.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectbtnAddCancel(object sender, EventArgs e)
        {
            try
            {
                projectSiteControl.dgvAddProjectList.Rows.Clear();
                projectSiteControl.AddGroup.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshLToregister(object sender, EventArgs e)
        {
            LtoRegistration();
        }

        private void refreshMaintenanceList(object sender, EventArgs e)
        {
            Param();
        }

        private void MaintankLimit(object sender, EventArgs e)
        {
            GetFuelLimit();
        }
        private void DMaintenanceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                unitMenuControl.UnitListPanel.Hide();
                unitMenuControl.ExpensesPanel.Hide();
                unitMenuControl.maintenancehistorypanel.Hide();
                unitMenuControl.MaintenanceListPanel.Show();
                unitMenuControl.BringToFront();
                maintenanceListControl.BringToFront();
                lblUnitMenu.Text = "Maintenance";

                maintenanceListControl.txtSearch.Text = dashBoardControl.dgvMaintenanceList.Rows[e.RowIndex].Cells[1].Value.ToString();
                maintenanceListControl.cmbUnitList.SelectedIndex = 0;


                SidePanel.Height = btnUnits.Height;
                SidePanel.Top = btnUnits.Top;

                MainteListbtnSearch_Click(maintenanceListControl.btnSearch, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void LtoRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    lblsubunit.Text = "ViewFuel";
                    lblUnitMenu.Text = "UnitDetail";
                    string NumberofTable = " ";
                    string main = "";
                    string maintenancelist = "";
                    string misMaintenance = "0";

                    String TEST = "exec sp_Get_InfoAndMonitoring '" + dashBoardControl.dgvLtoRegister.Rows[e.RowIndex].Cells[1].Value + "'," + "'" + dashBoardControl.dgvLtoRegister.Rows[e.RowIndex].Cells[2].Value + "'," + "'" + dashBoardControl.dgvLtoRegister.Rows[e.RowIndex].Cells[3].Value + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'";
                    DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_InfoAndMonitoring '" + dashBoardControl.dgvLtoRegister.Rows[e.RowIndex].Cells[1].Value + "'," + "'" + dashBoardControl.dgvLtoRegister.Rows[e.RowIndex].Cells[2].Value + "'," + "'" + dashBoardControl.dgvLtoRegister.Rows[e.RowIndex].Cells[3].Value + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'"));

                    unitListDetail.fuelViewControl.lblTotalFuelCost.Text = dsKey.Tables[4].Rows[0]["TotalFuelCost"].ToString();
                    unitListDetail.fuelViewControl.lblTotalRefill.Text = dsKey.Tables[4].Rows[0]["TotalRefill"].ToString();

                    DataTableReader drKey = dsKey.Tables[0].CreateDataReader();

                    if (drKey.Read())
                    {

                        NumberofTable = dsKey.Tables[0].Rows[0]["NumberofTable"].ToString();
                        main = dsKey.Tables[0].Rows[0]["maintable"].ToString();
                        maintenancelist = dsKey.Tables[0].Rows[0]["maintenance"].ToString();

                        if (NumberofTable == "0")
                        {
                            MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                        }
                        else
                        {
                            if (main != "0")
                            {
                                if (maintenancelist != "0")
                                {
                                    misMaintenance = dsKey.Tables[1].Rows[0]["IsMaintenance"].ToString();
                                }

                                unitListDetail.lblUnitPrice.Text = dsKey.Tables[2].Rows[0]["UnitPrice"].ToString();
                                unitListDetail.lblEngineNo.Text = dsKey.Tables[2].Rows[0]["EngineNo"].ToString();
                                unitListDetail.lblChassisNo.Text = dsKey.Tables[2].Rows[0]["ChassisNo"].ToString();
                                unitListDetail.lblPiston.Text = dsKey.Tables[2].Rows[0]["PistonDisplacement"].ToString();
                                unitListDetail.lblCylinder.Text = dsKey.Tables[2].Rows[0]["NoCylinder"].ToString();
                                unitListDetail.lblMake.Text = dsKey.Tables[2].Rows[0]["Make"].ToString();
                                unitListDetail.lblSeries.Text = dsKey.Tables[2].Rows[0]["Series"].ToString();
                                unitListDetail.lblBodyType.Text = dsKey.Tables[2].Rows[0]["BodyType"].ToString();
                                unitListDetail.lblYearModel.Text = dsKey.Tables[2].Rows[0]["YearModel"].ToString();
                                unitListDetail.lblGrossWT.Text = dsKey.Tables[2].Rows[0]["GrossWT"].ToString();
                                unitListDetail.lblStatusPurchase.Text = dsKey.Tables[2].Rows[0]["StatusOfPurchase"].ToString();
                                unitListDetail.lblDatePurchase.Text = dsKey.Tables[2].Rows[0]["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "");
                                unitListDetail.lblSupplier.Text = dsKey.Tables[2].Rows[0]["Supplier"].ToString();
                                unitListDetail.lblCRNo.Text = dsKey.Tables[2].Rows[0]["CR_No"].ToString();
                                unitListDetail.lblMVFile.Text = dsKey.Tables[2].Rows[0]["MVFile_No"].ToString();
                                unitListDetail.lblExistingReading.Text = dsKey.Tables[2].Rows[0]["ExistingReadingkm"].ToString();
                                unitListDetail.lblExpired.Text = dsKey.Tables[2].Rows[0]["Month_R_Expired"].ToString() + " " + dsKey.Tables[2].Rows[0]["Year_R_Expired"].ToString();
                                unitListDetail.lblFuelType.Text = dsKey.Tables[2].Rows[0]["FuelType"].ToString();
                                unitListDetail.lblEqpNo.Text = dsKey.Tables[2].Rows[0]["EquipmentNo"].ToString();
                                unitListDetail.lblNoName.Text = dsKey.Tables[2].Rows[0]["PlateNo"].ToString();
                                unitListDetail.lblEqpName.Text = dsKey.Tables[2].Rows[0]["Model"].ToString();
                                unitListDetail.lblkmltr.Text = dsKey.Tables[2].Rows[0]["km_ltr"].ToString();
                                
                                unitListDetail.lblHourlyRate.Text = dsKey.Tables[2].Rows[0]["HourlyRates"].ToString();



                                if (misMaintenance == "0")
                                {
                                    // MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
                                    unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.Black;
                                    unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.Black;
                                }
                                else
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.DarkRed;
                                    unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.DarkRed;
                                }

                                if (maintenancelist == "0")
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.Text = "0";
                                    unitListDetail.fuelViewControl.lblTotalHours.Text = "0";
                                }
                                else
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.Text = dsKey.Tables[1].Rows[0]["Kms_Used"].ToString();
                                    unitListDetail.fuelViewControl.lblTotalHours.Text = dsKey.Tables[1].Rows[0]["Hrs_Used"].ToString();
                                }
                                //
                                //employeeControl.dgvEmployeeList.DataSource = null;

                                unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;

                                if (this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource != null)
                                {
                                    this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;
                                }
                                else
                                {
                                    this.unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Clear();
                                }


                                foreach (DataRow row in dsKey.Tables[3].Rows)
                                {
                                    unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                                            , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                                            , row["DriversName"].ToString()
                                            , row["kmhrStart"].ToString()
                                            , row["kmhrStop"].ToString()
                                            , row["Kms"].ToString()
                                            , row["Hrs"].ToString()
                                            , row["noltrsrefilled"].ToString()
                                            , row["FuelCost"].ToString()
                                            , row["Ltr/kms"].ToString()
                                            , row["Preventive"].ToString()
                                            , row["PumpIncharge"].ToString()
                                            , row["ProjectNo"].ToString()
                                            , row["ProjectSite"].ToString()
                                            , row["SourceOfFuel"].ToString()
                                            );
                                }
                            }
                            else
                            {
                                MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                            }
                        }
                    }

                    if (UnitClick == 0)
                    {
                        //PositionList(positionControl.txtSearch.Text);
                        //PositionAutoCompleteSearch();
                        GetTruckType();
                        GetUnitList(unitListControl.txtSearch.Text, unitListControl.cmbTruckType.SelectedValue.ToString());
                        UnitClick++;
                    }

                    unitMenuControl.BringToFront();
                    SidePanel.Height = btnUnits.Height;
                    SidePanel.Top = btnUnits.Top;
                    unitListDetail.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void dgvTankLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                  if(fuelMainLogControl.dgvTankLog.Rows[e.RowIndex].Cells[1].Value.ToString() != "*")
                   { 
                    lblsubunit.Text = "ViewFuel";
                    lblUnitMenu.Text = "UnitDetail";
                    string NumberofTable = " ";
                    string main = "";
                    string maintenancelist = "";
                    string misMaintenance = "0";

                      var Date = fuelMainLogControl.dgvTankLog.Rows[e.RowIndex].Cells[2].Value;

                        //unitListDetail.fuelViewControl.dtpFFromDate.Value = DateTime.Now.AddDays(-45);

                        //unitListDetail.fuelViewControl.dtpFFromDate.Value = DateTime.Now.AddDays(-45);
                        unitListDetail.fuelViewControl.dtpFToDate.Value = Convert.ToDateTime(Date);



                        String TEST = "exec sp_Get_InfoAndMonitoring '" + fuelMainLogControl.dgvTankLog.Rows[e.RowIndex].Cells[12].Value + "'," + "'" + fuelMainLogControl.dgvTankLog.Rows[e.RowIndex].Cells[13].Value + "'," + "'" + fuelMainLogControl.dgvTankLog.Rows[e.RowIndex].Cells[14].Value + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'";
                        DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_InfoAndMonitoring '" + fuelMainLogControl.dgvTankLog.Rows[e.RowIndex].Cells[12].Value + "'," + "'" + fuelMainLogControl.dgvTankLog.Rows[e.RowIndex].Cells[13].Value + "'," + "'" + fuelMainLogControl.dgvTankLog.Rows[e.RowIndex].Cells[14].Value + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'"));

                        unitListDetail.fuelViewControl.lblTotalFuelCost.Text = dsKey.Tables[4].Rows[0]["TotalFuelCost"].ToString();
                        unitListDetail.fuelViewControl.lblTotalRefill.Text = dsKey.Tables[4].Rows[0]["TotalRefill"].ToString();

                        DataTableReader drKey = dsKey.Tables[0].CreateDataReader();
                    if (drKey.Read())
                    {

                        NumberofTable = dsKey.Tables[0].Rows[0]["NumberofTable"].ToString();
                        main = dsKey.Tables[0].Rows[0]["maintable"].ToString();
                        maintenancelist = dsKey.Tables[0].Rows[0]["maintenance"].ToString();

                        if (NumberofTable == "0")
                        {
                            MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                        }
                        else
                        {
                            if (main != "0")
                            {
                                if (maintenancelist != "0")
                                {
                                    misMaintenance = dsKey.Tables[1].Rows[0]["IsMaintenance"].ToString();
                                }

                                unitListDetail.lblEngineNo.Text = dsKey.Tables[2].Rows[0]["EngineNo"].ToString();
                                unitListDetail.lblChassisNo.Text = dsKey.Tables[2].Rows[0]["ChassisNo"].ToString();
                                unitListDetail.lblPiston.Text = dsKey.Tables[2].Rows[0]["PistonDisplacement"].ToString();
                                unitListDetail.lblCylinder.Text = dsKey.Tables[2].Rows[0]["NoCylinder"].ToString();
                                unitListDetail.lblMake.Text = dsKey.Tables[2].Rows[0]["Make"].ToString();
                                unitListDetail.lblSeries.Text = dsKey.Tables[2].Rows[0]["Series"].ToString();
                                unitListDetail.lblBodyType.Text = dsKey.Tables[2].Rows[0]["BodyType"].ToString();
                                unitListDetail.lblYearModel.Text = dsKey.Tables[2].Rows[0]["YearModel"].ToString();
                                unitListDetail.lblGrossWT.Text = dsKey.Tables[2].Rows[0]["GrossWT"].ToString();
                                unitListDetail.lblStatusPurchase.Text = dsKey.Tables[2].Rows[0]["StatusOfPurchase"].ToString();
                                unitListDetail.lblDatePurchase.Text = dsKey.Tables[2].Rows[0]["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "");
                                unitListDetail.lblSupplier.Text = dsKey.Tables[2].Rows[0]["Supplier"].ToString();
                                unitListDetail.lblCRNo.Text = dsKey.Tables[2].Rows[0]["CR_No"].ToString();
                                unitListDetail.lblMVFile.Text = dsKey.Tables[2].Rows[0]["MVFile_No"].ToString();
                                unitListDetail.lblExistingReading.Text = dsKey.Tables[2].Rows[0]["ExistingReadingkm"].ToString();
                                unitListDetail.lblExpired.Text = dsKey.Tables[2].Rows[0]["Month_R_Expired"].ToString() + " " + dsKey.Tables[2].Rows[0]["Year_R_Expired"].ToString();
                                unitListDetail.lblFuelType.Text = dsKey.Tables[2].Rows[0]["FuelType"].ToString();
                                unitListDetail.lblEqpNo.Text = dsKey.Tables[2].Rows[0]["EquipmentNo"].ToString();
                                unitListDetail.lblNoName.Text = dsKey.Tables[2].Rows[0]["PlateNo"].ToString();
                                unitListDetail.lblEqpName.Text = dsKey.Tables[2].Rows[0]["Model"].ToString();
                                unitListDetail.lblkmltr.Text = dsKey.Tables[2].Rows[0]["km_ltr"].ToString();

                                    unitListDetail.lblHourlyRate.Text = dsKey.Tables[2].Rows[0]["HourlyRates"].ToString();


                                    if (misMaintenance == "0")
                                {
                                    // MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
                                    unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.Black;
                                    unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.Black;
                                }
                                else
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.DarkRed;
                                    unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.DarkRed;
                                }

                                if (maintenancelist == "0")
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.Text = "0";
                                    unitListDetail.fuelViewControl.lblTotalHours.Text = "0";
                                }
                                else
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.Text = dsKey.Tables[1].Rows[0]["Kms_Used"].ToString();
                                    unitListDetail.fuelViewControl.lblTotalHours.Text = dsKey.Tables[1].Rows[0]["Hrs_Used"].ToString();
                                }
                                //
                                //employeeControl.dgvEmployeeList.DataSource = null;

                                unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;

                                if (this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource != null)
                                {
                                    this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;
                                }
                                else
                                {
                                    this.unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Clear();
                                }


                                foreach (DataRow row in dsKey.Tables[3].Rows)
                                {
                                    unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                                            , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                                            , row["DriversName"].ToString()
                                            , row["kmhrStart"].ToString()
                                            , row["kmhrStop"].ToString()
                                            , row["Kms"].ToString()
                                            , row["Hrs"].ToString()
                                            , row["noltrsrefilled"].ToString()
                                            , row["FuelCost"].ToString()
                                            , row["Ltr/kms"].ToString()
                                            , row["Preventive"].ToString()
                                            , row["PumpIncharge"].ToString()
                                            , row["ProjectNo"].ToString()
                                            , row["ProjectSite"].ToString()
                                            , row["SourceOfFuel"].ToString()
                                            );
                                }
                            }
                            else
                            {
                                MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                            }
                        }
                    }

                    if (UnitClick == 0)
                    {
                        //PositionList(positionControl.txtSearch.Text);
                        //PositionAutoCompleteSearch();
                        GetTruckType();
                        GetUnitList(unitListControl.txtSearch.Text, unitListControl.cmbTruckType.SelectedValue.ToString());
                        UnitClick++;
                    }

                    unitMenuControl.BringToFront();
                    SidePanel.Height = btnUnits.Height;
                    SidePanel.Top = btnUnits.Top;
                    unitListDetail.BringToFront();
                  }
                  else
                    {
                        MessageBox.Show("TANKER");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTankerLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    lblsubunit.Text = "ViewFuel";
                    lblUnitMenu.Text = "UnitDetail";
                    string NumberofTable = " ";
                    string main = "";
                    string maintenancelist = "";
                    string misMaintenance = "0";

                    var Date = fuelTankerLogControl.dgvTankLog.Rows[e.RowIndex].Cells[1].Value;

                    //unitListDetail.fuelViewControl.dtpFFromDate.Value = DateTime.Now.AddDays(-45);

                    //unitListDetail.fuelViewControl.dtpFFromDate.Value = DateTime.Now.AddDays(-45);
                    unitListDetail.fuelViewControl.dtpFToDate.Value = Convert.ToDateTime(Date);

                    String TEST = "exec sp_Get_InfoAndMonitoring '" + fuelTankerLogControl.dgvTankLog.Rows[e.RowIndex].Cells[11].Value + "'," + "'" + fuelTankerLogControl.dgvTankLog.Rows[e.RowIndex].Cells[12].Value + "'," + "'" + fuelTankerLogControl.dgvTankLog.Rows[e.RowIndex].Cells[13].Value + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'";
                    DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_InfoAndMonitoring '" + fuelTankerLogControl.dgvTankLog.Rows[e.RowIndex].Cells[11].Value + "'," + "'" + fuelTankerLogControl.dgvTankLog.Rows[e.RowIndex].Cells[12].Value + "'," + "'" + fuelTankerLogControl.dgvTankLog.Rows[e.RowIndex].Cells[13].Value + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'"));

                    unitListDetail.fuelViewControl.lblTotalFuelCost.Text = dsKey.Tables[4].Rows[0]["TotalFuelCost"].ToString();
                    unitListDetail.fuelViewControl.lblTotalRefill.Text = dsKey.Tables[4].Rows[0]["TotalRefill"].ToString();

                    DataTableReader drKey = dsKey.Tables[0].CreateDataReader();
                    if (drKey.Read())
                    {

                        NumberofTable = dsKey.Tables[0].Rows[0]["NumberofTable"].ToString();
                        main = dsKey.Tables[0].Rows[0]["maintable"].ToString();
                        maintenancelist = dsKey.Tables[0].Rows[0]["maintenance"].ToString();

                        if (NumberofTable == "0")
                        {
                            MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                        }
                        else
                        {
                            if (main != "0")
                            {
                                if (maintenancelist != "0")
                                {
                                    misMaintenance = dsKey.Tables[1].Rows[0]["IsMaintenance"].ToString();
                                }

                                unitListDetail.lblEngineNo.Text = dsKey.Tables[2].Rows[0]["EngineNo"].ToString();
                                unitListDetail.lblChassisNo.Text = dsKey.Tables[2].Rows[0]["ChassisNo"].ToString();
                                unitListDetail.lblPiston.Text = dsKey.Tables[2].Rows[0]["PistonDisplacement"].ToString();
                                unitListDetail.lblCylinder.Text = dsKey.Tables[2].Rows[0]["NoCylinder"].ToString();
                                unitListDetail.lblMake.Text = dsKey.Tables[2].Rows[0]["Make"].ToString();
                                unitListDetail.lblSeries.Text = dsKey.Tables[2].Rows[0]["Series"].ToString();
                                unitListDetail.lblBodyType.Text = dsKey.Tables[2].Rows[0]["BodyType"].ToString();
                                unitListDetail.lblYearModel.Text = dsKey.Tables[2].Rows[0]["YearModel"].ToString();
                                unitListDetail.lblGrossWT.Text = dsKey.Tables[2].Rows[0]["GrossWT"].ToString();
                                unitListDetail.lblStatusPurchase.Text = dsKey.Tables[2].Rows[0]["StatusOfPurchase"].ToString();
                                unitListDetail.lblDatePurchase.Text = dsKey.Tables[2].Rows[0]["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "");
                                unitListDetail.lblSupplier.Text = dsKey.Tables[2].Rows[0]["Supplier"].ToString();
                                unitListDetail.lblCRNo.Text = dsKey.Tables[2].Rows[0]["CR_No"].ToString();
                                unitListDetail.lblMVFile.Text = dsKey.Tables[2].Rows[0]["MVFile_No"].ToString();
                                unitListDetail.lblExistingReading.Text = dsKey.Tables[2].Rows[0]["ExistingReadingkm"].ToString();
                                unitListDetail.lblExpired.Text = dsKey.Tables[2].Rows[0]["Month_R_Expired"].ToString() + " " + dsKey.Tables[2].Rows[0]["Year_R_Expired"].ToString();
                                unitListDetail.lblFuelType.Text = dsKey.Tables[2].Rows[0]["FuelType"].ToString();
                                unitListDetail.lblEqpNo.Text = dsKey.Tables[2].Rows[0]["EquipmentNo"].ToString();
                                unitListDetail.lblNoName.Text = dsKey.Tables[2].Rows[0]["PlateNo"].ToString();
                                unitListDetail.lblEqpName.Text = dsKey.Tables[2].Rows[0]["Model"].ToString();
                                unitListDetail.lblHourlyRate.Text = dsKey.Tables[2].Rows[0]["HourlyRates"].ToString();
                                unitListDetail.lblkmltr.Text = dsKey.Tables[2].Rows[0]["km_ltr"].ToString();



                                if (misMaintenance == "0")
                                {
                                    // MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
                                    unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.Black;
                                    unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.Black;
                                }
                                else
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.DarkRed;
                                    unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.DarkRed;
                                }

                                if (maintenancelist == "0")
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.Text = "0";
                                    unitListDetail.fuelViewControl.lblTotalHours.Text = "0";
                                }
                                else
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.Text = dsKey.Tables[1].Rows[0]["Kms_Used"].ToString();
                                    unitListDetail.fuelViewControl.lblTotalHours.Text = dsKey.Tables[1].Rows[0]["Hrs_Used"].ToString();
                                }
                                //
                                //employeeControl.dgvEmployeeList.DataSource = null;

                                unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;

                                if (this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource != null)
                                {
                                    this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;
                                }
                                else
                                {
                                    this.unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Clear();
                                }


                                foreach (DataRow row in dsKey.Tables[3].Rows)
                                {
                                    unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                                            , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                                            , row["DriversName"].ToString()
                                            , row["kmhrStart"].ToString()
                                            , row["kmhrStop"].ToString()
                                            , row["Kms"].ToString()
                                            , row["Hrs"].ToString()
                                            , row["noltrsrefilled"].ToString()
                                            , row["FuelCost"].ToString()
                                            , row["Ltr/kms"].ToString()
                                            , row["Preventive"].ToString()
                                            , row["PumpIncharge"].ToString()
                                            , row["ProjectNo"].ToString()
                                            , row["ProjectSite"].ToString()
                                            , row["SourceOfFuel"].ToString()
                                            );
                                }
                            }
                            else
                            {
                                MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                            }
                        }
                    }

                    if (UnitClick == 0)
                    {
                        //PositionList(positionControl.txtSearch.Text);
                        //PositionAutoCompleteSearch();
                        GetTruckType();
                        GetUnitList(unitListControl.txtSearch.Text, unitListControl.cmbTruckType.SelectedValue.ToString());
                        UnitClick++;
                    }

                    unitMenuControl.BringToFront();
                    SidePanel.Height = btnUnits.Height;
                    SidePanel.Top = btnUnits.Top;
                    unitListDetail.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        ///
        private void ProjectbtnAddSave(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Save", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string Site = "";
                    string ProjectNo = "";
                    string ProjectDate = "";
                    string spName = "sp_Add_ProjectSite";

                    int numRows = projectSiteControl.dgvAddProjectList.Rows.Count;
                    int loop = numRows - 1;

                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {

                            if (projectSiteControl.dgvAddProjectList.Rows[i].Cells[0].FormattedValue.ToString().Replace(" ", "").Replace("'", "") == "")
                            {
                                MessageBox.Show("Please Enter Site");
                            }
                            else
                            {
                                if (projectSiteControl.dgvAddProjectList.Rows[i].Cells[1].FormattedValue.ToString().Replace(" ", "").Replace("'", "") == "")
                                {
                                    MessageBox.Show("Please Enter Project No");
                                }
                                else
                                {

                                    if (projectSiteControl.dgvAddProjectList.Rows[i].Cells[2].FormattedValue.ToString().Replace(" ", "").Replace("'", "") == "")
                                    {
                                        MessageBox.Show("Please Enter Project Date");
                                    }
                                    else
                                    {
                                        Site = "'" + projectSiteControl.dgvAddProjectList.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                                        ProjectNo = "'" + projectSiteControl.dgvAddProjectList.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                                        ProjectDate = "'" + projectSiteControl.dgvAddProjectList.Rows[i].Cells[2].FormattedValue.ToString() + "'";

                                        reader = monitoring.ExecuteReader(spName, Site, ProjectNo, ProjectDate);
                                        DataTable Detail = new DataTable();
                                        Detail.Load(reader);
                                        result = Detail.Rows[0]["Result"].ToString();

                                        if (result == "1")
                                        {
                                            MessageBox.Show("Successfully Saved..");
                                            projectSiteControl.dgvAddProjectList.Rows.Remove(projectSiteControl.dgvAddProjectList.Rows[i]);
                                            i = i - 1;
                                            loop = loop - 1;
                                        }
                                        else if (result == "2")
                                        {
                                            MessageBox.Show("Duplicate Project Site.. Please Check the Details");
                                            projectSiteControl.dgvAddProjectList.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                        }
                                        else
                                        {
                                            projectSiteControl.dgvAddProjectList.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                                        }

                                    }
                                }
                            }


                        }

                        ProjectSiteList(projectSiteControl.txtSearch.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Field");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectbtnSearch(object sender, EventArgs e)
        {
            try
            {
                ProjectSiteList(projectSiteControl.txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProjectList_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    projectSiteControl.EditGroup.Show();
                    projectSiteControl.lblid.Text = projectSiteControl.dgvProjectList[0, e.RowIndex].Value.ToString();
                    projectSiteControl.txtProjectSite.Text = projectSiteControl.dgvProjectList[1, e.RowIndex].Value.ToString();
                    projectSiteControl.txtProjectNo.Text = projectSiteControl.dgvProjectList[2, e.RowIndex].Value.ToString();
                    projectSiteControl.txtProjectDate.Text = projectSiteControl.dgvProjectList[3, e.RowIndex].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void projectSitebtnCancel(object sender, EventArgs e)
        {
            try
            {
                projectSiteControl.EditGroup.Hide();
                projectSiteControl.lblid.Text = "";
                projectSiteControl.txtProjectSite.Text = "";
                projectSiteControl.txtProjectNo.Text = "";
                projectSiteControl.txtProjectDate.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void projectSitebtnSave(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue to Save", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string result = "";
                SqlDataReader reader;
                // "'" + Equipmentno + "'";
                string id = "'" + projectSiteControl.lblid.Text + "'";
                string Site = "'" + projectSiteControl.txtProjectSite.Text + "'";
                string ProjNo = "'" + projectSiteControl.txtProjectNo.Text + "'";
                string ProjDate = "'" + projectSiteControl.txtProjectDate.Text + "'";
                string spName = "sp_Update_ProjectSite";

                reader = monitoring.ExecuteReader(spName, id, Site, ProjNo, ProjDate);
                DataTable Detail = new DataTable();
                Detail.Load(reader);
                result = Detail.Rows[0]["Result"].ToString();

                if (result == "1")
                {
                    MessageBox.Show("Successfully Saved..");
                    projectSiteControl.EditGroup.Hide();
                    projectSiteControl.lblid.Text = "";
                    projectSiteControl.txtProjectSite.Text = "";
                    projectSiteControl.txtProjectNo.Text = "";
                    projectSiteControl.txtProjectDate.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed To Saved..");
                }

                ProjectSiteList(projectSiteControl.txtSearch.Text);
            }
        }

        //projectSiteControl.lnkDelete.Click += projectSitelnkDelete;
        private void projectSitelnkDelete(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Delete", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = "";
                    SqlDataReader reader;
                    string id = "'" + projectSiteControl.lblid.Text + "'";
                    string spName = "sp_Delete_ProjectSite";

                    reader = monitoring.ExecuteReader(spName, id);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        MessageBox.Show("Successfully Deleted..");
                        projectSiteControl.EditGroup.Hide();
                        projectSiteControl.lblid.Text = "";
                        projectSiteControl.txtProjectSite.Text = "";
                        projectSiteControl.txtProjectNo.Text = "";
                        projectSiteControl.txtProjectDate.Text = "";
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Project Site Not Exist");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete..");
                    }

                    ProjectSiteList(projectSiteControl.txtSearch.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        #endregion End ProjectSite


        ////////////////////
        ////////////////////
        #endregion End AllSetup


        //////////////////////////////////////
        //////////////////////////////////////
        ////FUEL MAIN MENU Button ////////////////////////
        ////////////////////////

        #region Fuel



        //    fuelMenuControl.btnMainFuelLog.Click += btnMainFuelLog;
        //    fuelMenuControl.btnTankerFuellog.Click += btnTankerFuellog;
        //    fuelMenuControl.btnRefillMain.Click += btnRefillMain;
        //    fuelMenuControl.btnAddDaily.Click += btnAddDaily;
        private void RefillFuelList()
        {

            mainRefillControl.cmbFueltype.DataSource = dtFuelList;
            mainRefillControl.cmbFueltype.DisplayMember = "FuelType";
            mainRefillControl.cmbFueltype.ValueMember = "FuelType";


            mainRefillControl.cmbFueltype.DataSource = dtFuelList;
            mainRefillControl.cmbFueltype.DisplayMember = "FuelType";
            mainRefillControl.cmbFueltype.ValueMember = "FuelType";

        }


        private void btnMainFuelLog(object sender, EventArgs e)
        {
            try
            {
                if (ckMainLog == 0)
                {
                    //PositionList(positionControl.txtSearch.Text);
                    //PositionAutoCompleteSearch();
                    ckMainLog++;
                }

                fuelMenuControl.tankerfuellogpanel.Hide();
                fuelMenuControl.RefillMainPanel.Hide();
                fuelMenuControl.AddDailyPanel.Hide();
                fuelMenuControl.FuelPricePanel.Hide();
                fuelMenuControl.MainFuelLogPanel.Show();

                fuelMainLogControl.BringToFront();
                lblFuelLast.Text = "MainLog";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTankerFuellog(object sender, EventArgs e)
        {
            try
            {
                if (ckTankLog == 0)
                {
                    //PositionList(positionControl.txtSearch.Text);
                    //PositionAutoCompleteSearch();
                    ckTankLog++;
                }

                fuelMenuControl.MainFuelLogPanel.Hide();
                fuelMenuControl.RefillMainPanel.Hide();
                fuelMenuControl.AddDailyPanel.Hide();
                fuelMenuControl.FuelPricePanel.Hide();
                fuelMenuControl.tankerfuellogpanel.Show();
                fuelTankerLogControl.BringToFront();
                lblFuelLast.Text = "TankerLog";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddDaily(object sender, EventArgs e)
        {
            try
            {
                if (ckAddDaily == 0)
                {
                    //PositionList(positionControl.txtSearch.Text);
                    //PositionAutoCompleteSearch();
                    ckAddDaily++;
                }

                fuelMenuControl.MainFuelLogPanel.Hide();
                fuelMenuControl.tankerfuellogpanel.Hide();
                fuelMenuControl.FuelPricePanel.Hide();
                fuelMenuControl.RefillMainPanel.Hide();
                fuelMenuControl.AddDailyPanel.Show();

                // positionControl.BringToFront();
                addDailyControl.BringToFront();
                lblFuelLast.Text = "AddDaily";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Refill main tank

        private void btnRefillMain(object sender, EventArgs e)
        {
            try
            {
                if (ckRefilMain == 0)
                {

                    btnSearch_Click(mainRefillControl.btnSearch, EventArgs.Empty);
                    //PositionList(positionControl.txtSearch.Text);
                    //PositionAutoCompleteSearch();
                    ckRefilMain++;
                }

                fuelMenuControl.MainFuelLogPanel.Hide();
                fuelMenuControl.tankerfuellogpanel.Hide();
                fuelMenuControl.AddDailyPanel.Hide();
                fuelMenuControl.FuelPricePanel.Hide();
                fuelMenuControl.RefillMainPanel.Show();
                mainRefillControl.BringToFront();

                // positionControl.BringToFront();
                lblFuelLast.Text = "RefillMain";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //mainRefillControl.txtPrice.KeyPress += txtPrice_KeyPress;

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (mainRefillControl.txtPrice.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //mainRefillControl.txtPrice.KeyPress += txtLiters_KeyPress;
        private void txtLiters_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (mainRefillControl.txtLiters.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLiters_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void lnkdefault_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainRefillControl.txtLiters.Text = "14000";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string fueltype = "'" + mainRefillControl.cmbFueltype.SelectedValue.ToString() + "'";
                string Date = " ";
                string Price = " ";
                string Liters = " ";
                string supplier = "";
                string Driver = " ";
                string Plateno = " ";
                string PumpIncharge = "";
                string userid = "";


                string spName = "sp_Refill_Maintank";
                SqlDataReader reader;

                Date = "'" + mainRefillControl.dtpDate.Text + "'";
                Price = "'" + mainRefillControl.txtPrice.Text + "'";
                Liters = "'" + mainRefillControl.txtLiters.Text + "'";
                supplier = "'" + mainRefillControl.txtSupplier.Text + "'";
                Driver = "'" + mainRefillControl.txtDrivers.Text + "'";
                Plateno = "'" + mainRefillControl.txtPlate.Text + "'";
                PumpIncharge = "'" + mainRefillControl.txtPump.Text + "'";
                userid = "'" + userlogin + "'";

                if (mainRefillControl.txtPrice.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Price");
                }
                else if (mainRefillControl.txtLiters.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter No. Liters Refill");
                }
                else if (mainRefillControl.txtSupplier.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Supplier");
                }
                else if (mainRefillControl.txtDrivers.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Driver");
                }
                else if (mainRefillControl.txtPlate.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Plate No.");
                }
                else if (mainRefillControl.txtPump.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Please Enter Pump-Incharge");
                }
                else
                {
                    reader = monitoring.ExecuteReader(spName, fueltype, Date, Price, Liters, supplier, Driver, Plateno, PumpIncharge, userid);
                    DataTable result = new DataTable();
                    result.Load(reader);
                    string Result = result.Rows[0]["Result"].ToString();
                    if (Result == "0")
                    {
                        MessageBox.Show("Failed To Save. Please Enter Price per liter and No. of Liters..");
                    }
                    else if (Result == "1")
                    {
                        MessageBox.Show("Successfully Saved..");
                        mainRefillControl.txtPrice.Text = "";
                        mainRefillControl.txtLiters.Text = "";
                        mainRefillControl.txtLiters.Text = "";
                        mainRefillControl.txtSupplier.Text = "";
                        mainRefillControl.txtDrivers.Text = "";
                        mainRefillControl.txtPlate.Text = "";
                        mainRefillControl.txtPump.Text = "";

                        btnSearch_Click(mainRefillControl.btnSearch, EventArgs.Empty);
                        /*
                        txtEqpNo.Text = "";
                        txtEqpName.Text = "";
                        txtPNModelName.Text = "";
                        */

                    }
                    else
                    {
                        MessageBox.Show("Already Saved..");
                    }
                }

            }
            DateMainRefillParent(fuelMainLogControl.cmbTanktruck.SelectedValue.ToString());
        }
        ////////////////////
        ////////////////////

        #endregion end refill main tank

        ////////////////////
        ////////////////////

        #region Fuel Price List
        public void GetPriceList()
        {
            SqlDataAdapter DATA = new SqlDataAdapter("select id, Convert(varchar(10), Date, 101) as Date, FuelType, PricePerLiter, IsUse, NoLiters," +
                " AddFromPrev, DateCreated, TotalAmount, EquipmentNo, Model, PlateNo, MainFuelDate, TankName, Supplier, PrevId, IsDelete, DriverName, PumpIncharge" +
                ", IsMain, BaseOnGauge, AvailableFuel from m_FuelPriceList with(nolock) where IsMain = 1 and IsDelete = 1", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            mainRefillControl.dgvRefillList.DataSource = null;
            if (this.mainRefillControl.dgvRefillList.DataSource != null)
            {
                this.mainRefillControl.dgvRefillList.DataSource = null;
            }
            else
            {
                this.mainRefillControl.dgvRefillList.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    mainRefillControl.dgvRefillList.Rows.Add(row["id"].ToString()
                              , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , String.Format("{0:#,###.00}", Convert.ToDecimal(row["NoLiters"]))//row["NoLiters"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal(row["PricePerLiter"]))//row["PricePerLiter"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalAmount"]))//row["TotalAmount"].ToString()
                            , row["Supplier"].ToString()
                            , row["DriverName"].ToString()
                            , row["PumpIncharge"].ToString()
                            , row["PlateNo"].ToString()
                            , row["FuelType"].ToString()
                            );
                }
            }
        }

        private void dgvRefillList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    string value = String.Format("{0:0,0.00}", Convert.ToDecimal(mainRefillControl.dgvRefillList.Rows[e.RowIndex].Cells[2].Value));
                    mainRefillControl.dgvRefillList.Rows[e.RowIndex].Cells[2].Value = value;
                    // value1 = value;
                }
                catch { }
            }
            if (e.ColumnIndex == 3)
            {
                try
                {
                    string value = String.Format("{0:0,0.00}", Convert.ToDecimal(mainRefillControl.dgvRefillList.Rows[e.RowIndex].Cells[3].Value));
                    mainRefillControl.dgvRefillList.Rows[e.RowIndex].Cells[3].Value = value;
                    // value1 = value;
                }
                catch { }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlDataAdapter DATA = new SqlDataAdapter("select id, Convert(varchar(10), Date, 101) as Date, FuelType, PricePerLiter, IsUse, NoLiters," +
                " AddFromPrev, DateCreated, TotalAmount, EquipmentNo, Model, PlateNo, MainFuelDate, TankName, Supplier, PrevId, IsDelete, DriverName, PumpIncharge" +
                ", IsMain, BaseOnGauge, AvailableFuel from m_FuelPriceList with(nolock) where  IsMain = 1 and Date BETWEEN '"
                   + mainRefillControl.dtpStart.Text + "' AND '" + mainRefillControl.dtpEnd.Text + "'", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            mainRefillControl.dgvRefillList.DataSource = null;
            if (this.mainRefillControl.dgvRefillList.DataSource != null)
            {
                this.mainRefillControl.dgvRefillList.DataSource = null;
            }
            else
            {
                this.mainRefillControl.dgvRefillList.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    mainRefillControl.dgvRefillList.Rows.Add(row["id"].ToString()
                       , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                       , String.Format("{0:#,###.00}", Convert.ToDecimal(row["NoLiters"]))//row["NoLiters"].ToString()
                       , String.Format("{0:#,###.00}", Convert.ToDecimal(row["PricePerLiter"]))//row["PricePerLiter"].ToString()
                       , String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalAmount"]))//row["TotalAmount"].ToString()
                       , row["Supplier"].ToString()
                       , row["DriverName"].ToString()
                       , row["PumpIncharge"].ToString()
                       , row["PlateNo"].ToString()
                       , row["FuelType"].ToString()
                       );
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GetPriceList();
        }

        //mainRefillControl.dgvRefillList.CellDoubleClick += dgvRefillList_DoubleClick;
        private void dgvRefillList_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UpdateFuelPriceForm updateFuel = new UpdateFuelPriceForm();
                    //public void param(string id, string sdate, string sprice, string sliters, string sSupplier, string sDriver, string sPlateno, string sPumpIncharge, string sFuel)
                    updateFuel.param(mainRefillControl.dgvRefillList[0, e.RowIndex].Value.ToString(), mainRefillControl.dgvRefillList[1, e.RowIndex].Value.ToString(),
                        mainRefillControl.dgvRefillList[3, e.RowIndex].Value.ToString(), mainRefillControl.dgvRefillList[2, e.RowIndex].Value.ToString(), mainRefillControl.dgvRefillList[5, e.RowIndex].Value.ToString(),
                        mainRefillControl.dgvRefillList[6, e.RowIndex].Value.ToString(), mainRefillControl.dgvRefillList[8, e.RowIndex].Value.ToString(), mainRefillControl.dgvRefillList[7, e.RowIndex].Value.ToString(),
                        mainRefillControl.dgvRefillList[9, e.RowIndex].Value.ToString());
                    updateFuel.ShowDialog();

                    mainRefillControl.dgvRefillList[1, e.RowIndex].Value = updateFuel.pDate;
                    mainRefillControl.dgvRefillList[2, e.RowIndex].Value = updateFuel.pLiters;
                    mainRefillControl.dgvRefillList[3, e.RowIndex].Value = updateFuel.pPrice;
                    mainRefillControl.dgvRefillList[5, e.RowIndex].Value = updateFuel.psupplier;
                    mainRefillControl.dgvRefillList[6, e.RowIndex].Value = updateFuel.pDriver;
                    mainRefillControl.dgvRefillList[7, e.RowIndex].Value = updateFuel.pPumpIncharge;
                    mainRefillControl.dgvRefillList[8, e.RowIndex].Value = updateFuel.pPlateno;
                    mainRefillControl.dgvRefillList[9, e.RowIndex].Value = updateFuel.pfueltype;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDailySheet__EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox auto = e.Control as TextBox;

            if (addDailyControl.dgvDailySheet.CurrentCell.ColumnIndex == 2)
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
                        auto.AutoCompleteCustomSource = data;
                    }
                }
                catch { }
            }
            else if (addDailyControl.dgvDailySheet.CurrentCell.ColumnIndex == 3)
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    EmployeeNo(data);
                    auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            else if (addDailyControl.dgvDailySheet.CurrentCell.ColumnIndex == 8)
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    EmployeeNo(data);
                    auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            else if (addDailyControl.dgvDailySheet.CurrentCell.ColumnIndex == 7)
            {
                auto.AutoCompleteCustomSource.Clear();
                auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                ProjectArrayList(data);
                auto.AutoCompleteCustomSource = data;
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

        private void DailybtnSave_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue SAVE", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = "";
                SqlDataReader reader;
                string Date = "'" + "'";
                string Equipmentno = "'" + "'";
                string Model = "'" + "'";
                string PlateNo = "'" + "'";
                string DriversName = "'" + "'";
                string noltrsrefilled = "'0" + "'";
                string kmhrStart = "'0" + "'";
                string kmhrStop = "'0" + "'";
                string kms = "'0" + "'";
                string Hrs = "'0" + "'";
                string ProjectSite = "'" + "'";
                string PumpIncharge = "'" + "'";
                string others = "'" + "'";
                string Source = "'" + "'";
                string Operation = "'" + "'";
                string spName = "sp_Add_DailySheet";
                string test = "'" + "'";
                string isTanker = "'" + "'";
                string userid = "'" + userlogin +  "'";
                int ok;

                int count = 0;
                int numRows = addDailyControl.dgvDailySheet.Rows.Count;
                int loop = numRows - 1;

                for (int i = 0; i < loop; i++)
                {

                    if (Convert.ToBoolean(addDailyControl.dgvDailySheet.Rows[i].Cells["tank"].Value) == true)
                    {
                        isTanker = "1";
                    }
                    else
                    {
                        isTanker = "0";
                    }

                    if (Convert.ToBoolean(addDailyControl.dgvDailySheet.Rows[i].Cells["Others"].Value) == true)
                    {
                        others = "1";
                    }
                    else
                    {
                        others = "0";
                    }


                    //  string DriversName = (row.Cells[1].Value.ToString()) == string.Empty ? "" : row.Cells["DriversName"].Value.ToString();
                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[1].FormattedValue) != string.Empty)
                    {
                        Date = "'" + (addDailyControl.dgvDailySheet.Rows[i].Cells[1].FormattedValue.ToString()) + "'";
                    }
                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[2].FormattedValue) != string.Empty)
                    {
                        Equipmentno = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[2].FormattedValue.ToString() + "'";
                    }


                    //if (Convert.ToString(row.Cells[3].FormattedValue) != string.Empty)
                    //{
                    //    Model = "'" + row.Cells[3].FormattedValue.ToString() + "'";
                    //}
                    //if (Convert.ToString(row.Cells[4].FormattedValue) != string.Empty)
                    //{
                    //    PlateNo = "'" + row.Cells[4].FormattedValue.ToString() + "'";
                    //}

                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[3].FormattedValue) != string.Empty)
                    {
                        DriversName = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[3].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[4].FormattedValue) != string.Empty)
                    {
                        noltrsrefilled = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[4].FormattedValue.ToString() + "'";
                    }
                    /*
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[5].FormattedValue) != string.Empty)
                    {
                        kmhrStart = "'" + dgvDailySheet.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[6].FormattedValue) != string.Empty)
                    {
                        kmhrStop = "'" + dgvDailySheet.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                    }
                    */
                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[5].FormattedValue) != string.Empty)
                    {
                        kms = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[6].FormattedValue) != string.Empty)
                    {
                        Hrs = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[7].FormattedValue) != string.Empty)
                    {
                        ProjectSite = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[7].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[8].FormattedValue) != string.Empty)
                    {
                        PumpIncharge = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[8].FormattedValue.ToString() + "'";
                    }

                    //if (Convert.ToString(row.Cells[11].FormattedValue) != string.Empty)
                    //{
                    //    others = "'" + row.Cells[11].FormattedValue.ToString() + "'";
                    //}

                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[10].FormattedValue) != string.Empty)
                    {
                        Operation = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[10].FormattedValue.ToString() + "'";
                    }

                    if (Convert.ToString(addDailyControl.dgvDailySheet.Rows[i].Cells[11].FormattedValue) != string.Empty)
                    {
                        Source = "'" + addDailyControl.dgvDailySheet.Rows[i].Cells[11].FormattedValue.ToString() + "'";
                    }

                    if (addDailyControl.dgvDailySheet.Rows[i].Cells[11].FormattedValue.ToString() == "" | addDailyControl.dgvDailySheet.Rows[i].Cells[11].FormattedValue.ToString() == " ")
                    {
                        MessageBox.Show("Please Select Source of Fuel..");
                    }
                    else
                    {
                        //reader = monitoring.ExecuteReader(spName, isTanker, Date, Equipmentno, DriversName, noltrsrefilled, kmhrStart, kmhrStop, kms, Hrs, ProjectSite, PumpIncharge, others, Operation, Source);
                        reader = monitoring.ExecuteReader(spName, isTanker, Date, Equipmentno, DriversName, noltrsrefilled, kms, Hrs, ProjectSite, PumpIncharge, others, Operation, Source, userid);
                        DataTable Detail = new DataTable();
                        Detail.Load(reader);
                        result = Detail.Rows[0]["Result"].ToString();

                        if (result == "1")
                        {
                            addDailyControl.dgvDailySheet.Rows.Remove(addDailyControl.dgvDailySheet.Rows[i]);
                            i = i - 1;
                            loop = loop - 1;
                        }
                        else
                        {
                            addDailyControl.dgvDailySheet.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            //dgvDailySheet.RowsDefaultCellStyle.ForeColor = Color.Red;
                        }
                    }

                    // ok = 0;
                }
                DateTankerTruckRefillParent(fuelTankerLogControl.cmbTanktruck.SelectedValue.ToString());

                if(fuelTankerLogControl.cmbDate.Text.ToString() != string.Empty || fuelTankerLogControl.cmbDate.Text.ToString() != string.Empty)
                {
                    ParamTankerLogList(fuelTankerLogControl.cmbDate.Text.ToString(), fuelTankerLogControl.cmbTanktruck.SelectedValue.ToString(), fuelTankerLogControl.cmbfueltype.SelectedValue.ToString(), fuelTankerLogControl.cmbDate.SelectedValue.ToString());
                }
                if (fuelMainLogControl.cmbDate.Text.ToString() != string.Empty || fuelMainLogControl.cmbDate.Text.ToString() != string.Empty)
                {
                    ParamMainLogList(fuelMainLogControl.cmbDate.SelectedValue.ToString(), fuelMainLogControl.cmbTanktruck.SelectedValue.ToString(), fuelMainLogControl.cmbfueltype.SelectedValue.ToString());
                }
                

                GetUnitListbySearch();
                /*
                 * if (btnsearchclick == 0)
                {
                    GetUnitListbyAuto();
                }
                else
                {
                    GetUnitListbySearch();
                }
                */
            }
            else
            {

            }
        }


        #region FuelMainTankerLogControl



        private void TankerMainList(string Fuel)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_TankList with(nolock) where IsMainTank = 1 and TypeOfFuel = '" + Fuel + "' order by id asc", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                fuelMainLogControl.cmbTanktruck.DataSource = dt;
                fuelMainLogControl.cmbTanktruck.DisplayMember = "TankName";
                fuelMainLogControl.cmbTanktruck.ValueMember = "TankName";
            }
        }

        private void DateMainRefillParent(string pTankname)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select CONVERT(VARCHAR(10), Date, 101) as Datevalue from m_FuelPriceList with (nolock) where IsDelete = 1 and TankName = '" + pTankname + "'  order by id desc", Con);

                da.Fill(dt);
                // CONVERT(VARCHAR(10), Date, 101)
                fuelMainLogControl.cmbDate.DataSource = dt;
                fuelMainLogControl.cmbDate.DisplayMember = "Datevalue";
                fuelMainLogControl.cmbDate.ValueMember = "Datevalue";
            }
        }


        // TankerMainList(fuelMainLogControl.cmbfueltype.SelectedValue.ToString());
        // DateMainRefillParent(fuelMainLogControl.cmbTanktruck.SelectedValue.ToString());
        //    Param(cmbDate.SelectedValue.ToString(), cmbTanktruck.SelectedValue.ToString());

        public void ParamMainLogList(string Date, string pTankname, string fueltype)
        {

            dtMaintankLabel.Clear();
            dtMaintankGrid.Clear();

            SqlDataAdapter DATA1 = new SqlDataAdapter("select CONVERT(VARCHAR(10), Date, 101) as Date, NoLiters, AddFromPrev + NoLiters as TankAvailability, AvailableFuel, AddFromPrev" +
                " , ((NoLiters + AddFromPrev) - AvailableFuel) as TotalLitersPullOut, TankName, (select top(1) FuelLimit from m_TankList where IsMainTank = 1 and TypeOfFuel = 'Diesel' and isdelete = 1) as FuelLimit, FuelType from m_FuelPriceList with (nolock) where IsDelete = 1 and TankName = '" + pTankname + "' and Date = '" + Date + "' and FuelType = '" + fueltype + "'", Connection);

            //SqlDataAdapter DATA1 = new SqlDataAdapter("select CONVERT(VARCHAR(10), Date, 101) as Date, NoLiters, AddFromPrev + NoLiters as TankAvailability, AvailableFuel, AddFromPrev" +
            //    " , ((NoLiters + AddFromPrev) - AvailableFuel) as TotalLitersPullOut, TankName from m_FuelPriceList with (nolock) where IsDelete = 1 and TankName = '" + pTankname + "' and Date = '" + Date + "' and FuelType = '" + fueltype + "'", Connection);
            //DataTable dt1 = new DataTable();
            DATA1.Fill(dtMaintankLabel);


            fuelMainLogControl.lblDate.Text = "";
            fuelMainLogControl.lblTankTruck.Text = "";
            fuelMainLogControl.lblpullout.Text = "";
            fuelMainLogControl.lblRemaining.Text = "";
            fuelMainLogControl.lblTankRefill.Text = "";
            fuelMainLogControl.lblPrevious.Text = "";
            fuelMainLogControl.lblTankAvailability.Text = "";

            foreach (DataRow row in dtMaintankLabel.Rows)
            {
                decimal remaining = Convert.ToDecimal(row["AvailableFuel"]);
                decimal limit = Convert.ToDecimal(row["FuelLimit"]);

                if (remaining <= limit)
                {
                    fuelMainLogControl.lblRemaining.ForeColor = Color.DarkRed;
                }
                else
                {
                    fuelMainLogControl.lblRemaining.ForeColor = Color.Black;
                }

                fuelMainLogControl.lblDate.Text = row["Date"].ToString();
                fuelMainLogControl.lblTankTruck.Text = row["TankName"].ToString();
                fuelMainLogControl.lblpullout.Text = row["TotalLitersPullOut"].ToString();
                fuelMainLogControl.lblRemaining.Text = row["AvailableFuel"].ToString();
                fuelMainLogControl.lblTankRefill.Text = row["NoLiters"].ToString();
                fuelMainLogControl.lblPrevious.Text = row["AddFromPrev"].ToString();
                fuelMainLogControl.lblTankAvailability.Text = row["TankAvailability"].ToString();
            }


            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_FuelMainLogSheet with (nolock) where IsDelete = 1 and FuelPriceId = "
                  + "(select id from m_FuelPriceList with (nolock) where IsDelete = 1 and TankName = '" + pTankname +
                  "' and Date = '" + Date + "' and FuelType = '" + fueltype + "')" + " order by id asc", Connection);
            //"' and FuelPriceListDate = '" + Date + "' order by id asc", Connection);

            //SqlDataAdapter DATA = new SqlDataAdapter("select * from m_FuelMainLogSheet with (nolock) where IsDelete = 1 and  SourceOfFuel = '" + pTankname +
            //    "' and FuelPriceId = " + "(select id from m_FuelPriceList with (nolock) where IsDelete = 1 and TankName = '" + pTankname + "' and Date = '" + Date + "' and FuelType = '" + fueltype + "')" + " order by id asc", Connection);
            ////"' and FuelPriceListDate = '" + Date + "' order by id asc", Connection);
            //DataTable dt = new DataTable();
            DATA.Fill(dtMaintankGrid);

            fuelMainLogControl.dgvTankLog.DataSource = null;
            if (this.fuelMainLogControl.dgvTankLog.DataSource != null)
            {
                this.fuelMainLogControl.dgvTankLog.DataSource = null;
            }
            else
            {
                this.fuelMainLogControl.dgvTankLog.Rows.Clear();
            }

            int intRecord = dtMaintankGrid.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtMaintankGrid.Rows)
                {
                    fuelMainLogControl.dgvTankLog.Rows.Add(row["Id"].ToString()
                            , (row["IsTanker"].ToString() == "0" ? "" : "*")
                            , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , row["DriversName"].ToString()
                            , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["noltrsrefilled"]))//row["LitersRefill"].ToString()
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["Availability"]))//row["Availability"].ToString()
                            , row["TankGauge"].ToString()
                            , row["ProjectSite"].ToString()
                            , row["Operation"].ToString()
                            , row["PumpIncharge"].ToString()
                            , row["PrevUsage"].ToString()
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            );
                }
            }
            else
            {
            }

        }


        private void MainLogbtnSearchbtnSave_Click(object sender, EventArgs e)
        {
                ParamMainLogList(fuelMainLogControl.cmbDate.SelectedValue.ToString(), fuelMainLogControl.cmbTanktruck.SelectedValue.ToString(), fuelMainLogControl.cmbfueltype.SelectedValue.ToString());
            // TankerMainList(fuelMainLogControl.cmbfueltype.SelectedValue.ToString());
            // DateMainRefillParent(fuelMainLogControl.cmbTanktruck.SelectedValue.ToString());
            //    Param(fuelMainLogControl.cmbDate.SelectedValue.ToString(), fuelMainLogControl.cmbTanktruck.SelectedValue.ToString());

        }

        private void fuel(string Fuel)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_TankList with(nolock) where IsMainTank = 0 and TypeOfFuel = '" + Fuel + "'  order by id asc", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                fuelTankerLogControl.cmbTanktruck.DataSource = dt;
                fuelTankerLogControl.cmbTanktruck.DisplayMember = "TankName";
                fuelTankerLogControl.cmbTanktruck.ValueMember = "TankName";
            }
        }

        #endregion end FuelMainTankerLogControl


        #region FuelTruckTankerLogControl

        private void TankerTruckList(string Fuel)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_TankList with(nolock) where IsMainTank = 0 and TypeOfFuel = '" + Fuel + "'  order by id asc", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                fuelTankerLogControl.cmbTanktruck.DataSource = dt;
                fuelTankerLogControl.cmbTanktruck.DisplayMember = "TankName";
                fuelTankerLogControl.cmbTanktruck.ValueMember = "TankName";
            }
        }

        private void DateTankerTruckRefillParent(string pTankname)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select CONVERT(VARCHAR(10), Date, 101) as Datevalue, Id as DateID from m_FuelPriceList with (nolock) where IsDelete = 1 and TankName = '" + pTankname + "'  order by id desc", Con);

                da.Fill(dt);
                // CONVERT(VARCHAR(10), Date, 101)
                fuelTankerLogControl.cmbDate.DataSource = dt;
                fuelTankerLogControl.cmbDate.DisplayMember = "Datevalue";
                fuelTankerLogControl.cmbDate.ValueMember = "DateID";
                //fuelTankerLogControl.cmbDate.
            }
        }


        public void ParamTankerLogList(string Date, string pTankname, string fueltype, string id)
        {

            dtTankerTruckLabel.Clear();
            dtTankerTruckGrid.Clear();

            SqlDataAdapter DATA1 = new SqlDataAdapter("select CONVERT(VARCHAR(10), Date, 101) as Date, NoLiters, AddFromPrev + NoLiters as TankAvailability, AvailableFuel, AddFromPrev" +
                " , ((NoLiters + AddFromPrev) - AvailableFuel) as TotalLitersPullOut, TankName, ROUND((NoLiters + AddFromPrev) - AvailableFuel, 0) as BaseOnGauge, FuelType from m_FuelPriceList with (nolock) where IsDelete = 1 and TankName = '" + pTankname + "' and Id = '" + id + "' and FuelType = '" + fueltype + "'", Connection);
            //DataTable dt1 = new DataTable();
            DATA1.Fill(dtTankerTruckLabel);


            fuelTankerLogControl.lblDate.Text = "";
            fuelTankerLogControl.lblTankTruck.Text = "";
            fuelTankerLogControl.lblBaseongauge.Text = "";
            fuelTankerLogControl.lblpullout.Text = "";
            fuelTankerLogControl.lblRemaining.Text = "";
            fuelTankerLogControl.lblTankRefill.Text = "";
            fuelTankerLogControl.lblPrevious.Text = "";
            fuelTankerLogControl.lblTTankAvailability.Text = "";

            foreach (DataRow row in dtTankerTruckLabel.Rows)
            {
                fuelTankerLogControl.lblDate.Text = row["Date"].ToString();
                fuelTankerLogControl.lblTankTruck.Text = row["TankName"].ToString();
                fuelTankerLogControl.lblBaseongauge.Text = row["BaseOnGauge"].ToString();
                fuelTankerLogControl.lblpullout.Text = row["TotalLitersPullOut"].ToString();
                fuelTankerLogControl.lblRemaining.Text = row["AvailableFuel"].ToString();
                fuelTankerLogControl.lblTankRefill.Text = row["NoLiters"].ToString();
                fuelTankerLogControl.lblPrevious.Text = row["AddFromPrev"].ToString();
                fuelTankerLogControl.lblTTankAvailability.Text = row["TankAvailability"].ToString();
            }
            
            /*
            foreach (DataRow row in dt1.Rows)
            {
                fuelMainLogControl.lblDate.Text = row["Date"].ToString();
                fuelMainLogControl.lblTankTruck.Text = row["TankName"].ToString();
                fuelMainLogControl.lblpullout.Text = row["TotalLitersPullOut"].ToString();
                fuelMainLogControl.lblRemaining.Text = row["AvailableFuel"].ToString();
                fuelMainLogControl.lblTankRefill.Text = row["NoLiters"].ToString();
                fuelMainLogControl.lblPrevious.Text = row["AddFromPrev"].ToString();
            }

            */
            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_FuelMainLogSheet with (nolock) where IsDelete = 1 and  SourceOfFuel = '" + pTankname + "' and FuelPriceListDate = '" + Date + "' and FuelPriceId = '" + id + "' order by id asc", Connection);
            //DataTable dt = new DataTable();
            DATA.Fill(dtTankerTruckGrid);

            fuelTankerLogControl.dgvTankLog.DataSource = null;
            if (this.fuelTankerLogControl.dgvTankLog.DataSource != null)
            {
                this.fuelTankerLogControl.dgvTankLog.DataSource = null;
            }
            else
            {
                this.fuelTankerLogControl.dgvTankLog.Rows.Clear();
            }

            int intRecord = dtTankerTruckGrid.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtTankerTruckGrid.Rows)
                {
                    fuelTankerLogControl.dgvTankLog.Rows.Add(row["Id"].ToString()
                            , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , row["DriversName"].ToString()
                            , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["noltrsrefilled"]))//row["LitersRefill"].ToString()
                            , String.Format("{0:#,###.0}", Convert.ToDecimal(row["Availability"]))//row["Availability"].ToString()
                            , row["TankGauge"].ToString()
                            , row["ProjectSite"].ToString()
                            , row["Operation"].ToString()
                            , row["PumpIncharge"].ToString()
                            , row["PrevUsage"].ToString()
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            );
                }
            }
            else
            {
            }

        }

        private void TankerLogbtnSearchbtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fuelTankerLogControl.cmbDate.Text)
                | string.IsNullOrEmpty(fuelTankerLogControl.cmbTanktruck.Text)
                | string.IsNullOrEmpty(fuelTankerLogControl.cmbfueltype.Text))
            {
                MessageBox.Show("Cannot Search Date or Tank Truck or Fuel Type Empty");
            }
            else
            {
                ParamTankerLogList(fuelTankerLogControl.cmbDate.Text.ToString(), fuelTankerLogControl.cmbTanktruck.SelectedValue.ToString(), fuelTankerLogControl.cmbfueltype.SelectedValue.ToString(), fuelTankerLogControl.cmbDate.SelectedValue.ToString());

            }

         
        }

        #endregion end FuelTruckTankerLogControl


        ////////////////////
        ////////////////////

        #endregion Fuel Price List

        ////////////////////
        ////////////////////


        #endregion\


        ////////////////////
        ////////////////////


        #region Unit List


        public void GetServiceUnit()
        {

            AutoCompleteStringCollection UnitListTxt = new AutoCompleteStringCollection();
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_ServiceUnitList with (nolock) where IsDelete = 1", Con);
                da.Fill(dtUnitList);


                foreach (DataRow dr in dtUnitList.Rows)
                {
                    EquipArray.Add(dr["EquipmentNo"].ToString());
                    EquipArray.Add(dr["Model"].ToString());
                    EquipArray.Add(dr["PlateNo"].ToString());


                    EquipmentNoCollection.Add(dr["EquipmentNo"].ToString());
                    ModelNoCollection.Add(dr["Model"].ToString());
                    PlateNoCollection.Add(dr["PlateNo"].ToString());


                    Allunit.Add(dr["EquipmentNo"].ToString());
                    Allunit.Add(dr["Model"].ToString());
                    Allunit.Add(dr["PlateNo"].ToString());

                    UnitListTxt.Add(dr["EquipmentNo"].ToString());
                    UnitListTxt.Add(dr["Model"].ToString());
                    UnitListTxt.Add(dr["PlateNo"].ToString());
                }


                maintenanceAndRepair.txtEquip.AutoCompleteCustomSource = Allunit;

                // allMaintenanceExpenses.txtEquip.AutoCompleteCustomSource = UnitListTxt;
                allMaintenanceExpenses.txtEquip.AutoCompleteCustomSource = EquipmentNoCollection;
                unitListControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
                maintenanceListControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
                mainHistoryControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
                monthlyFormControl.truckMonthlyControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
                overallReportControl.truckOverallExpensesControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
                //  unitListControl.txtSearch.AutoCompleteCustomSource = UnitListTxt;
            }
        }
        //EmployeeText

        //Units Button
        // unitMenuControl.btnUnitList.Click += MenubtnMenuUnitList;
        // unitMenuControl.btnMaintenanceList.Click += btnMaintenanceList;
        // unitMenuControl.btnExpenses.Click += btnExpenses;
        //unit menu list
        private void MenubtnMenuUnitList(object sender, EventArgs e)
        {
            unitMenuControl.ExpensesPanel.Hide();
            unitMenuControl.MaintenanceListPanel.Hide();
            unitMenuControl.UnitListPanel.Show();
            unitMenuControl.MaintenanceListPanel.Hide();
            unitListControl.BringToFront();
            lblUnitMenu.Text = "UnitList";
            if (lblsubunit.Text == "ViewFuel")
            {
                unitListControl.BringToFront();
                lblsubunit.Text = "ViewFuel";
            }
            else if (lblsubunit.Text == "ViewExpenses")
            {
                unitListDetail.BringToFront();
                lblsubunit.Text = "ViewExpenses";
            }
            else
            {

            }


        }

        //Unit Maintenance List
        private void btnMaintenanceList(object sender, EventArgs e)
        {
            if (MaintenanceListClick == 0)
            {
                MaintenanceHistoryClick++;
                getMaintenance();
            }
            unitMenuControl.UnitListPanel.Hide();
            unitMenuControl.ExpensesPanel.Hide();
            unitMenuControl.maintenancehistorypanel.Hide();
            unitMenuControl.MaintenanceListPanel.Show();
            maintenanceListControl.BringToFront();
            lblUnitMenu.Text = "Maintenance";


        }

        private void btnExpenses(object sender, EventArgs e)
        {
            unitMenuControl.maintenancehistorypanel.Hide();
            unitMenuControl.UnitListPanel.Hide();
            unitMenuControl.MaintenanceListPanel.Hide();
            unitMenuControl.ExpensesPanel.Show();
            //allMaintenanceExpenses.BringToFront();
            maintenanceAndRepair.BringToFront();
            lblUnitMenu.Text = "Expenses";
        }
        private void btnMaintenanceHistory(object sender, EventArgs e)
        {
            if (MaintenanceHistoryClick == 0)
            {
                MaintenanceHistoryClick++;
                getMaintenanceHistory();
            }
            unitMenuControl.MaintenanceListPanel.Hide();
            unitMenuControl.UnitListPanel.Hide();
            unitMenuControl.ExpensesPanel.Hide();
            unitMenuControl.maintenancehistorypanel.Show();
            mainHistoryControl.BringToFront();
            lblUnitMenu.Text = "MaintenanceHistory";
        }
        #region Unit Menu
        //unitListControl.lbladdsingleUnit.LinkClicked += lbladdsingleUnit_LinkClicked;
        private void lbladdsingleUnit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TruckForm truck = new TruckForm();
            truck.ShowDialog();
            if (truck.resultparam == 1)
            {
                GetUnitList(unitListControl.txtSearch.Text, unitListControl.cmbTruckType.SelectedValue.ToString());
            }
        }

        private void UnitlnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            unitListControl.BringToFront();
            //lblsubunit.Text = "ViewFuel";
            lblsubunit.Text = "";
        }

        //here
        // unitListDetail.lnkFuel.LinkClicked += lnkFuelview_LinkClicked;
        //lnkExpenses
        //    unitListDetail.lnkExpenses.LinkClicked += lnkExpensesView_LinkClicked;
        private void lnkFuelview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          // unitListDetail.lnkFuel.ForeColor = Color.Red;
            unitListDetail.lnkFuel.LinkColor = Color.Red;
          // unitListDetail.lnkExpenses.ForeColor = Color.Black;
            unitListDetail.lnkExpenses.LinkColor = Color.Black;
            unitListDetail.fuelViewControl.BringToFront();
            lblsubunit.Text = "ViewFuel";
        }
        private void lnkExpensesView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //unitListDetail.lnkExpenses.ForeColor = Color.Red;
            unitListDetail.lnkExpenses.LinkColor = Color.Red;
           // unitListDetail.lnkExpenses.Font.Bold = true;
            //unitListDetail.lnkFuel.ForeColor = Color.Black;
            unitListDetail.lnkFuel.LinkColor = Color.Black;
            unitListDetail.expensesViewControl.BringToFront();
            lblsubunit.Text = "ViewExpenses";
            if (countlnkViewExpense == 0)
            {
                GetExpensesbyUnit();
                countlnkViewExpense++;
            }
        }

        private void GetTruckType()
        {
            //SqlDataAdapter da = new SqlDataAdapter("select * from m_TruckType with (nolock) where IsDelete = '1'", Connection);
            SqlDataAdapter da = new SqlDataAdapter("select 0,'ALL' as TruckType,'',0,0,'',0,1 from m_TruckType union  select * from m_TruckType with (nolock) where IsDelete = '1'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);


            int intRecord = dt.Rows.Count;
            
            if(intRecord > 0)
            {
                unitListControl.cmbTruckType.DataSource = dt;
                unitListControl.cmbTruckType.DisplayMember = "TruckType";
                unitListControl.cmbTruckType.ValueMember = "TruckType";
            }


        }


        private void FuelViewbtnFSearch(object sender, EventArgs e)
        {
            btnsearchclick++;
            GetUnitListbySearch();
        }

        private void ExpensesViewbtnFSearch_Click(object sender, EventArgs e)
        {
            GetExpensesbyUnit();
        }


        //here to edit
        private void GetUnitListbyAuto()
        {
            //SqlDataAdapter da = new SqlDataAdapter("select * from m_TruckType with (nolock) where IsDelete = '1'", Connection);
            SqlDataAdapter da = new SqlDataAdapter("select *, convert(varchar(50), Date,101) as ConvertDate from m_FuelMainLogSheet with(nolock) where EquipmentNo = '" + unitListDetail.lblEqpNo.Text + "' and Model = '" + unitListDetail.lblEqpName.Text + "' and PlateNo = '" + unitListDetail.lblNoName.Text + "' " +
               //   "and IsDelete = 1 and ISNULL(Preventive, '') = '' and IsTanker = 0 order by id desc", Connection);
               "and IsDelete = 1 and IsTanker = 0 order by id desc", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);


            unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;

            if (this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource != null)
            {
                this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;
            }
            else
            {
                this.unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                            //  , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                            , row["DriversName"].ToString()
                            , row["kmhrStart"].ToString()
                            , row["kmhrStop"].ToString()
                            , row["Kms"].ToString()
                            , row["Hrs"].ToString()
                            , row["noltrsrefilled"].ToString()
                            , row["FuelCost"].ToString()
                            , row["Ltr/kms"].ToString()
                            , row["Preventive"].ToString()
                            , row["PumpIncharge"].ToString()
                            , row["ProjectNo"].ToString()
                            , row["ProjectSite"].ToString()
                            , row["SourceOfFuel"].ToString()
                            );
                    /*
                    unitListControl.dgvUnitListitem.Rows.Add(row["Model"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["PlateNo"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["DateExpire"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["TotalKM"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["TotalHrs"].ToString());
                    */
                }
            }
            else
            {
            }

        }


        //To Edit GetUnitListbySearch()
        private void GetUnitListbySearch()
        {
            string NumberofTable = " ";
            string main = "";
            string maintenancelist = "";
            string misMaintenance = "0";
            /*
            string result;
            SqlDataReader reader;

            string Equipmentno = "'" + unitListDetail.lblEqpNo.Text + "'";
            string Model = "'" + unitListDetail.lblEqpName.Text + "'";
            string PlateNo = "'" + unitListDetail.lblNoName.Text + "'";
            string StartDate = "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'";
            string EndDate = "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'";

            string spName = "sp_Get_IsMaintenance";
            */

            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_IsMaintenance '" + unitListDetail.lblEqpNo.Text + "'," + "'" + unitListDetail.lblEqpName.Text + "'," + "'" + unitListDetail.lblNoName.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'"));
            DataTableReader drKey = dsKey.Tables[0].CreateDataReader();
            //DataTableReader TotalKey = dsKey.Tables[1].CreateDataReader();

            unitListDetail.fuelViewControl.lblTotalFuelCost.Text = dsKey.Tables[3].Rows[0]["TotalFuelCost"].ToString();
            unitListDetail.fuelViewControl.lblTotalRefill.Text = dsKey.Tables[3].Rows[0]["TotalRefill"].ToString();
            
            //txtTotalFuelCost.text = dsKey.Tables[1].Rows[0]["TotalFuelCost"].ToString();
            //txtTotalRefill.Text = dsKey.Tables[1].Rows[0]["TotalRefill"].ToString();

            //if(TotalKey.Read())
            //{
            //    txtTotalFuelCost.Text = TotalKey.Tables[1].Rows[0]["NumberofTable"].ToString();
            //    //txtTotalRefill
            //}

            if (drKey.Read())
            {
                NumberofTable = dsKey.Tables[0].Rows[0]["NumberofTable"].ToString();
                main = dsKey.Tables[0].Rows[0]["maintable"].ToString();
                maintenancelist = dsKey.Tables[0].Rows[0]["maintenance"].ToString(); if (NumberofTable == "0")
                {
                    MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                }
                else
                {
                    if (main != "0")
                    {
                        if (maintenancelist != "0")
                        {
                            misMaintenance = dsKey.Tables[1].Rows[0]["IsMaintenance"].ToString();
                        }


                        if (misMaintenance == "0")
                        {
                            // MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
                            unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.Black;
                            unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.Black;
                        }
                        else
                        {
                            unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.DarkRed;
                            unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.DarkRed;
                        }

                        if (maintenancelist == "0")
                        {
                            unitListDetail.fuelViewControl.lblTotalUsed.Text = "0";
                            unitListDetail.fuelViewControl.lblTotalHours.Text = "0";
                        }
                        else
                        {
                            unitListDetail.fuelViewControl.lblTotalUsed.Text = dsKey.Tables[1].Rows[0]["Kms_Used"].ToString();
                            unitListDetail.fuelViewControl.lblTotalHours.Text = dsKey.Tables[1].Rows[0]["Hrs_Used"].ToString();
                        }

                        //  unitListDetail.fuelViewControl.dgvDataMonitoring
                
                        if (this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource != null)
                        {
                            unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;
                        }
                        else
                        {
                            unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Clear();
                        }


                        foreach (DataRow row in dsKey.Tables[2].Rows)
                        {
                            unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                                    , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                                    , row["DriversName"].ToString()
                                    , row["kmhrStart"].ToString()
                                    , row["kmhrStop"].ToString()
                                    , row["Kms"].ToString()
                                    , row["Hrs"].ToString()
                                    , row["noltrsrefilled"].ToString()
                                    , row["FuelCost"].ToString()
                                    , row["Ltr/kms"].ToString()
                                    , row["Preventive"].ToString()
                                    , row["PumpIncharge"].ToString()
                                    , row["ProjectNo"].ToString()
                                    , row["ProjectSite"].ToString()
                                    , row["SourceOfFuel"].ToString()
                                    );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                    }
                }
            }

            /*
            //SqlDataAdapter da = new SqlDataAdapter("select * from m_TruckType with (nolock) where IsDelete = '1'", Connection);
            SqlDataAdapter da = new SqlDataAdapter("select *, convert(varchar(50), Date,101) as ConvertDate from m_FuelMainLogSheet with(nolock) where EquipmentNo = '" + unitListDetail.lblEqpNo.Text + "' and Model = '" + unitListDetail.lblEqpName.Text + "' and PlateNo = '" + unitListDetail.lblNoName.Text + "' " +
                 "and IsDelete = 1 and ISNULL(Preventive, '') = '' and IsTanker = 0 and Date Between '" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "' and '" + unitListDetail.fuelViewControl.dtpFToDate.Text + "' order by id asc", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            

            unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;

            if (this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource != null)
            {
                this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;
            }
            else
            {
                this.unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                            , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                            , row["DriversName"].ToString()
                            , row["kmhrStart"].ToString()
                            , row["kmhrStop"].ToString()
                            , row["Kms"].ToString()
                            , row["Hrs"].ToString()
                            , row["noltrsrefilled"].ToString()
                            , row["FuelCost"].ToString()
                            , row["Ltr/kms"].ToString()
                            , row["Preventive"].ToString()
                            , row["PumpIncharge"].ToString()
                            , row["ProjectSite"].ToString()
                            , row["ProjectNo"].ToString()
                            );
                    /*
                    unitListControl.dgvUnitListitem.Rows.Add(row["Model"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["PlateNo"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["DateExpire"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["TotalKM"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["TotalHrs"].ToString());
                    */

        }


        private void UnitEditClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditUnitInfo editunit = new EditUnitInfo();
            editunit.Param(unitListDetail.lblEqpNo.Text, unitListDetail.lblEqpName.Text, unitListDetail.lblNoName.Text, DrUnitDetail,userlogin);
            editunit.ShowDialog();
            unitListDetail.lblBodyType.Text = editunit.BodyType;
            unitListDetail.lblChassisNo.Text = editunit.ChasisNo;
            unitListDetail.lblCRNo.Text = editunit.CRNo;
            unitListDetail.lblCylinder.Text = editunit.NoCylinders;
            unitListDetail.lblDatePurchase.Text = editunit.DateOfPurchase;
            unitListDetail.lblEngineNo.Text = editunit.EngineNo;
            unitListDetail.lblEqpName.Text = editunit.Model;
            unitListDetail.lblEqpNo.Text = editunit.EquipmentNo;
            unitListDetail.lblExistingReading.Text = editunit.ExistingRead;
            unitListDetail.lblExpired.Text = editunit.Register;
            unitListDetail.lblFuelType.Text = editunit.FuelType;
            unitListDetail.lblGrossWT.Text = editunit.GrossWt;
            unitListDetail.lblMake.Text = editunit.Make;
            unitListDetail.lblMVFile.Text = editunit.MVFile;
            unitListDetail.lblNoName.Text = editunit.PlateNo;
            unitListDetail.lblPiston.Text = editunit.PistonDis;
            unitListDetail.lblSeries.Text = editunit.Series;
            unitListDetail.lblStatusPurchase.Text = editunit.StatusofPurchase;
            unitListDetail.lblSupplier.Text = editunit.Supplier;
            unitListDetail.lblYearModel.Text = editunit.YearModel;
            unitListDetail.lblTruckType.Text = editunit.TruckType;
            unitListDetail.lblUnitPrice.Text = string.Format("{0:#,###.00}", Convert.ToDecimal(editunit.Price));
            unitListDetail.lblCurrentReading.Text = editunit.CurrentReading;
            unitListDetail.lblHourlyRate.Text = string.Format("{0:#,###.00}", Convert.ToDecimal(editunit.HourlyRate));
            unitListDetail.lblkmltr.Text = editunit.kmsltr;

            LtoRegistration();
            // ExpensesbtnSearch_Click(allMaintenanceExpenses.btnSearch, EventArgs.Empty);
        }


        //here delete unit
        private void btnUnitmonitoringDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete", "Delete Validation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (unitListDetail.fuelViewControl.dgvDataMonitoring.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in unitListDetail.fuelViewControl.dgvDataMonitoring.SelectedRows)
                    {
                        string isblank = row.Cells[10].Value.ToString();

                        if (isblank is null || isblank == "")
                        {
                            string result;
                            SqlDataReader reader;

                            string id = "'" + row.Cells[0].Value.ToString() + "'";

                            string spName = "sp_delete_Unit1Monitoring";

                            reader = monitoring.ExecuteReader(spName, id);
                            DataTable Detail = new DataTable();
                            Detail.Load(reader);
                            result = Detail.Rows[0]["Result"].ToString();
                            if (result == "1")
                            {
                                MessageBox.Show("Successfully Delete");

                                GetUnitListbySearch();
                                /*
                                if (btnsearchclick == 0)
                                    {
                                        GetUnitListbyAuto();
                                    }
                                    else
                                    {
                                        GetUnitListbySearch();
                                    }
                                */
                            }
                            else
                            {
                                MessageBox.Show("Failed to Delete");
                            }

                            //  MessageBox.Show(row.Cells[0].Value.ToString());
                            //  dgvDataMonitoring.SelectedRows.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            //dgvDataMonitoring.Rows.Remove(row);
                        }
                        else
                        {
                            MessageBox.Show("Failed to Delete. Already Maintenance");
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


        //here delete unitexpenses
        private void btnexpensesunitDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Delete", "Delete Validation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (unitListDetail.expensesViewControl.dgvEMaintenance.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in unitListDetail.expensesViewControl.dgvEMaintenance.SelectedRows)
                    {
                        string isblank = row.Cells[10].Value.ToString();

                        if (isblank is null || isblank == "")
                        {
                            string result;
                            SqlDataReader reader;

                            string id = "'" + row.Cells[0].Value.ToString() + "'";

                            string spName = "sp_delete_Unit1expenses";

                            reader = monitoring.ExecuteReader(spName, id);
                            DataTable Detail = new DataTable();
                            Detail.Load(reader);
                            result = Detail.Rows[0]["Result"].ToString();
                            if (result == "1")
                            {
                                MessageBox.Show("Successfully Delete");

                                GetExpensesbyUnit();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Delete");
                            }

                            //  MessageBox.Show(row.Cells[0].Value.ToString());
                            //  dgvDataMonitoring.SelectedRows.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                            //dgvDataMonitoring.Rows.Remove(row);
                        }
                        else
                        {
                            MessageBox.Show("Failed to Delete. Already Maintenance");
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

        //open Data
        private void dgvUnitListitem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    lblsubunit.Text = "ViewFuel";
                    lblUnitMenu.Text = "UnitDetail";
                    string NumberofTable = " ";
                    string main = "";
                    string maintenancelist = "";
                    string misMaintenance = "0";

                    String TEST = "exec sp_Get_InfoAndMonitoring '" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[1].Value + "'," + "'" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[2].Value + "'," + "'" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[3].Value + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'";
                    DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_InfoAndMonitoring '" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[1].Value + "'," + "'" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[2].Value + "'," + "'" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[3].Value + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'"));
                    unitListDetail.fuelViewControl.lblTotalFuelCost.Text = dsKey.Tables[4].Rows[0]["TotalFuelCost"].ToString();
                    unitListDetail.fuelViewControl.lblTotalRefill.Text = dsKey.Tables[4].Rows[0]["TotalRefill"].ToString();
                    DataTableReader drKey = dsKey.Tables[0].CreateDataReader();


                   

                    if (drKey.Read())
                    {

                        NumberofTable = dsKey.Tables[0].Rows[0]["NumberofTable"].ToString();
                        main = dsKey.Tables[0].Rows[0]["maintable"].ToString();
                        maintenancelist = dsKey.Tables[0].Rows[0]["maintenance"].ToString();

                        if (NumberofTable == "0")
                        {
                            MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                        }
                        else
                        {
                            if (main != "0")
                            {
                                if (maintenancelist != "0")
                                {
                                    misMaintenance = dsKey.Tables[1].Rows[0]["IsMaintenance"].ToString();
                                }

                                unitListDetail.lblUnitPrice.Text = dsKey.Tables[2].Rows[0]["UnitPrice"].ToString();
                                unitListDetail.lblTruckType.Text = dsKey.Tables[2].Rows[0]["TruckType"].ToString();
                                unitListDetail.lblEngineNo.Text = dsKey.Tables[2].Rows[0]["EngineNo"].ToString();
                                unitListDetail.lblChassisNo.Text = dsKey.Tables[2].Rows[0]["ChassisNo"].ToString();
                                unitListDetail.lblPiston.Text = dsKey.Tables[2].Rows[0]["PistonDisplacement"].ToString();
                                unitListDetail.lblCylinder.Text = dsKey.Tables[2].Rows[0]["NoCylinder"].ToString();
                                unitListDetail.lblMake.Text = dsKey.Tables[2].Rows[0]["Make"].ToString();
                                unitListDetail.lblSeries.Text = dsKey.Tables[2].Rows[0]["Series"].ToString();
                                unitListDetail.lblBodyType.Text = dsKey.Tables[2].Rows[0]["BodyType"].ToString();
                                unitListDetail.lblYearModel.Text = dsKey.Tables[2].Rows[0]["YearModel"].ToString();
                                unitListDetail.lblGrossWT.Text = dsKey.Tables[2].Rows[0]["GrossWT"].ToString();
                                unitListDetail.lblStatusPurchase.Text = dsKey.Tables[2].Rows[0]["StatusOfPurchase"].ToString();
                                unitListDetail.lblDatePurchase.Text = dsKey.Tables[2].Rows[0]["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "");
                                unitListDetail.lblSupplier.Text = dsKey.Tables[2].Rows[0]["Supplier"].ToString();
                                unitListDetail.lblCRNo.Text = dsKey.Tables[2].Rows[0]["CR_No"].ToString();
                                unitListDetail.lblMVFile.Text = dsKey.Tables[2].Rows[0]["MVFile_No"].ToString();
                                unitListDetail.lblExistingReading.Text = dsKey.Tables[2].Rows[0]["ExistingReadingkm"].ToString();
                                unitListDetail.lblExpired.Text = dsKey.Tables[2].Rows[0]["Month_R_Expired"].ToString() + " " + dsKey.Tables[2].Rows[0]["Year_R_Expired"].ToString();
                                unitListDetail.lblFuelType.Text = dsKey.Tables[2].Rows[0]["FuelType"].ToString();
                                unitListDetail.lblEqpNo.Text = dsKey.Tables[2].Rows[0]["EquipmentNo"].ToString();
                                unitListDetail.lblNoName.Text = dsKey.Tables[2].Rows[0]["PlateNo"].ToString();
                                unitListDetail.lblEqpName.Text = dsKey.Tables[2].Rows[0]["Model"].ToString(); 
                                unitListDetail.lblCurrentReading.Text = dsKey.Tables[2].Rows[0]["CurrentReading"].ToString();
                                unitListDetail.lblHourlyRate.Text = dsKey.Tables[2].Rows[0]["HourlyRates"].ToString();
                                unitListDetail.lblkmltr.Text = dsKey.Tables[2].Rows[0]["km_ltr"].ToString();



                                if (misMaintenance == "0")
                                {
                                    // MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
                                    unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.Black;
                                    unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.Black;
                                }
                                else
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.DarkRed;
                                    unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.DarkRed;
                                }

                                if (maintenancelist == "0")
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.Text = "0";
                                    unitListDetail.fuelViewControl.lblTotalHours.Text = "0";
                                }
                                else
                                {
                                    unitListDetail.fuelViewControl.lblTotalUsed.Text = dsKey.Tables[1].Rows[0]["Kms_Used"].ToString();
                                    unitListDetail.fuelViewControl.lblTotalHours.Text = dsKey.Tables[1].Rows[0]["Hrs_Used"].ToString();
                                }
                                //
                                //employeeControl.dgvEmployeeList.DataSource = null;

                                unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;

                                if (this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource != null)
                                {
                                    this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;
                                }
                                else
                                {
                                    this.unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Clear();
                                }


                                foreach (DataRow row in dsKey.Tables[3].Rows)
                                {
                                    unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                                            , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                                            , row["DriversName"].ToString()
                                            , row["kmhrStart"].ToString()
                                            , row["kmhrStop"].ToString()
                                            , row["Kms"].ToString()
                                            , row["Hrs"].ToString()
                                            , row["noltrsrefilled"].ToString()
                                            , row["FuelCost"].ToString()
                                            , row["Ltr/kms"].ToString()
                                            , row["Preventive"].ToString()
                                            , row["PumpIncharge"].ToString()
                                            , row["ProjectNo"].ToString()
                                            , row["ProjectSite"].ToString()
                                            , row["SourceOfFuel"].ToString()
                                            );
                                }
                            }
                            else
                            {
                                MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                            }
                        }
                    }

                    unitListDetail.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // dgvExpenses[4, e.RowIndex].Value = update.strDuringRefuel;
        }


        private void GetSubCategorySelectedIndex()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category] from m_SubCategoryList with(nolock) where " +
                       " Category = '" + unitListDetail.expensesViewControl.cmbECategory.Text + "' and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All') and IsDelete = 1", Connection);

            /*
            SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category] from m_SubCategoryList with(nolock) where [Sub-Category] != 'All'" +
                    "and Category = '" + unitListDetail.expensesViewControl.cmbECategory.Text + "' and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All') and IsDelete = 1", Connection);
            */
            DataTable dt = new DataTable();
            da.Fill(dt);

            int intRecord = dt.Rows.Count;
            if(intRecord > 0)
            {
                unitListDetail.expensesViewControl.cmbESubCategory.DataSource = dt;
                unitListDetail.expensesViewControl.cmbESubCategory.DisplayMember = "Sub-Category";
                unitListDetail.expensesViewControl.cmbESubCategory.ValueMember = "Sub-Category";
            }

        }
        private void expensesViewControlcmbECategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSubCategorySelectedIndex();
        }


        //// Expenses View

        private void GetExpensesbyUnit()
        {
            dtUnitExpenses.Clear();
            SqlDataAdapter da;
            if (unitListDetail.expensesViewControl.cmbECategory.Text == "ALL")
            {
                if (unitListDetail.expensesViewControl.cmbESubCategory.Text == "ALL")
                {
                    da = new SqlDataAdapter("Select *,convert(varchar(50), Date,101) as ConvertDate from m_Expenses with(nolock) where EquipmentNo = '" + unitListDetail.lblEqpNo.Text + "' and Model = '" + unitListDetail.lblEqpName.Text + "' and PlateNo = '" + unitListDetail.lblNoName.Text + "' " +
                        "and IsDelete = 1 and Date Between '" + unitListDetail.expensesViewControl.dtpEFromDate.Text + "' and '" + unitListDetail.expensesViewControl.dtpEToDate.Text + "' order by id asc", Connection);
                }
                else
                {

                    da = new SqlDataAdapter("Select *,convert(varchar(50), Date,101) as ConvertDate from m_Expenses with(nolock) where EquipmentNo = '" + unitListDetail.lblEqpNo.Text + "' and Model = '" + unitListDetail.lblEqpName.Text + "' and PlateNo = '" + unitListDetail.lblNoName.Text + "' " +
                        "and IsDelete = 1 and Date Between '" + unitListDetail.expensesViewControl.dtpEFromDate.Text + "' and '" + unitListDetail.expensesViewControl.dtpEToDate.Text + "' order by id asc", Connection);
                }
            }
            else
            {
                if (unitListDetail.expensesViewControl.cmbESubCategory.Text == "ALL")
                {
                    da = new SqlDataAdapter("Select *,convert(varchar(50), Date,101) as ConvertDate from m_Expenses with(nolock) where EquipmentNo = '" + unitListDetail.lblEqpNo.Text + "' and Model = '" + unitListDetail.lblEqpName.Text + "' and PlateNo = '" + unitListDetail.lblNoName.Text + "' " +
                        "and IsDelete = 1 and Date Between '" + unitListDetail.expensesViewControl.dtpEFromDate.Text + "' and '" + unitListDetail.expensesViewControl.dtpEToDate.Text + "' and " +
                        " Category = '" + unitListDetail.expensesViewControl.cmbECategory.Text + "' order by id asc", Connection);
                }
                else
                {

                    da = new SqlDataAdapter("Select *,convert(varchar(50), Date,101) as ConvertDate from m_Expenses with(nolock) where EquipmentNo = '" + unitListDetail.lblEqpNo.Text + "' and Model = '" + unitListDetail.lblEqpName.Text + "' and PlateNo = '" + unitListDetail.lblNoName.Text + "' " +
                        "and IsDelete = 1 and Date Between '" + unitListDetail.expensesViewControl.dtpEFromDate.Text + "' and '" + unitListDetail.expensesViewControl.dtpEToDate.Text + "' and " +
                        " SubCategory = '" + unitListDetail.expensesViewControl.cmbESubCategory.Text + " and Category = '" + unitListDetail.expensesViewControl.cmbECategory.Text + "' order by id asc", Connection);
                }
            }

            /*
            SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category] from m_SubCategoryList with(nolock) where [Sub-Category] != 'All'" +
                    "and Category = '" + unitListDetail.expensesViewControl.cmbECategory.Text + "' and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All') and IsDelete = 1", Connection);
            */
            //DataTable dt = new DataTable();

            da.Fill(dtUnitExpenses);


            unitListDetail.expensesViewControl.dgvEMaintenance.DataSource = null;

            if (this.unitListDetail.expensesViewControl.dgvEMaintenance.DataSource != null)
            {
                this.unitListDetail.expensesViewControl.dgvEMaintenance.DataSource = null;
            }
            else
            {
                this.unitListDetail.expensesViewControl.dgvEMaintenance.Rows.Clear();
            }

            int intRecord = dtUnitExpenses.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtUnitExpenses.Rows)
                {
                    unitListDetail.expensesViewControl.dgvEMaintenance.Rows.Add(row["Id"].ToString()
                            , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                            , row["Mileage"].ToString() == "" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Mileage"]))
                            , row["Item"].ToString()
                            , row["Pcs"].ToString()
                            , row["Driver"].ToString()
                            , row["Mechanic"].ToString()
                            , row["Category"].ToString()
                            , row["SubCategory"].ToString()
                            , row["Problem"].ToString()
                            , row["Diagnosis"].ToString()
                            , row["PMS"].ToString() == "" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]))
                            //, row["PMS"].ToString()
                            , row["Repair"].ToString() == "" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]))
                            //, row["Repair"].ToString()
                            , row["Tire"].ToString() == "" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]))
                            //, row["Tire"].ToString()
                            , row["DateCompleted"].ToString().Replace(" 12:00:00 AM", "")
                            , row["Remarks"].ToString()
                            , row["ProjectSite"].ToString()
                            , row["ProjectNo"].ToString()
                            );
                    /*
                    unitListControl.dgvUnitListitem.Rows.Add(row["Model"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["PlateNo"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["DateExpire"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["TotalKM"].ToString());
                    unitListControl.dgvUnitListitem.Rows.Add(row["TotalHrs"].ToString());
                    */
                }
            }
            else
            {
            }


        }




        private void btnRefresh(object sender, EventArgs e)
        {
            try
            {
                DateMainRefillParent(fuelMainLogControl.cmbTanktruck.SelectedValue.ToString());
            }
            catch
            {

            }
        }

        private void UnitControlbtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GetUnitList(unitListControl.txtSearch.Text, unitListControl.cmbTruckType.SelectedValue.ToString());
            }
            catch
            {

            }
        }

        private void UnitControltxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    UnitControlbtnSearch_Click(unitListControl.btnSearch, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetUnitList(string Equip, string Type)
        {
            SqlDataAdapter da;
            if (Type == "ALL")
            {
                da = new SqlDataAdapter("select * from vw_GetUnitList with(nolock) where " +
                       UnitSearchType + " like '%" + unitListControl.txtSearch.Text + "%' and IsDelete = '1' and Month_R_Expired like '%" + unitListControl.cmbFromMonth.Text
                       + "%' and Year_R_Expired like '%" + unitListControl.txtYear.Text + "%'", Connection);
            }
            else
            {
                da = new SqlDataAdapter("select * from vw_GetUnitList with(nolock) where " +
                       UnitSearchType + " like '%" + unitListControl.txtSearch.Text + "%'" +
                       " and IsDelete = '1' and TruckID = (select TruckId from m_TruckType  with(nolock) where TruckType = '" + Type + "') and Month_R_Expired like '%"
                       + unitListControl.cmbFromMonth.Text
                       + "%' and Year_R_Expired like '%" + unitListControl.txtYear.Text + "%'", Connection);
            }
            DataTable dt = new DataTable();
            da.Fill(dt);

            unitListControl.dgvUnitListitem.DataSource = null;

            if (this.unitListControl.dgvUnitListitem.DataSource != null)
            {
                this.unitListControl.dgvUnitListitem.DataSource = null;
            }
            else
            {
                this.unitListControl.dgvUnitListitem.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    unitListControl.dgvUnitListitem.Rows.Add(row["ServiceID"].ToString()
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            , row["StatusOfPurchase"].ToString()
                            , row["Price"].ToString() == "" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Price"]))
                            , row["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "")
                            , row["Supplier"].ToString()
                            , row["DateExpire"].ToString()
                            , row["TotalKm"].ToString() == "" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalKm"]))
                            , row["TotalHrs"].ToString() == "" ? "" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalHrs"])));
                            //, (row["TotalKm"].ToString() == "" ? "0.00" : row["TotalKm"].ToString())
                            //, (row["TotalHrs"].ToString() == "" ? "0.00" : row["TotalHrs"].ToString()));
                            // , row["TotalKM"].ToString()
                            // , row["TotalHrs"].ToString());
                            /*
                            unitListControl.dgvUnitListitem.Rows.Add(row["Model"].ToString());
                            unitListControl.dgvUnitListitem.Rows.Add(row["PlateNo"].ToString());
                            unitListControl.dgvUnitListitem.Rows.Add(row["DateExpire"].ToString());
                            unitListControl.dgvUnitListitem.Rows.Add(row["TotalKM"].ToString());
                            unitListControl.dgvUnitListitem.Rows.Add(row["TotalHrs"].ToString());
                            */
                }
            }
            else
            {
            }
        }


        private void cmbUnitList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  EquipmentNoCollection.Clear();
            if (unitListControl.cmbUnitList.SelectedIndex == 0)
            {
                UnitSearchType = "EquipmentNo";
                unitListControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
            }
            else if (unitListControl.cmbUnitList.SelectedIndex == 1)
            {
                UnitSearchType = "Model";
                unitListControl.txtSearch.AutoCompleteCustomSource = ModelNoCollection;
            }
            else
            {
                UnitSearchType = "PlateNo";
                unitListControl.txtSearch.AutoCompleteCustomSource = PlateNoCollection;
            }
        }

        private void btnUnitMaintenance_Click(object sender, EventArgs e)
        {

            string Equipmentno = unitListDetail.lblEqpNo.Text;
            string Model = unitListDetail.lblEqpName.Text;
            string Plateno = unitListDetail.lblNoName.Text;
            string Maintenanceid;
            string PEquipmentno = "'" + Equipmentno + "'";
            string PModel = "'" + Model + "'";
            string PPlateno = "'" + Plateno + "'";
            string Preventive;
            string spName = "sp_Get_Preventive";
            SqlDataReader reader;

            reader = monitoring.ExecuteReader(spName, PEquipmentno, PModel, PPlateno);
            DataTable result = new DataTable();
            result.Load(reader);
            Preventive = result.Rows[0]["Result"].ToString();
            Maintenanceid = result.Rows[0]["MaintenanceId"].ToString();


            ProcessMaintenance process = new ProcessMaintenance();
            process.param(Equipmentno, Model, Plateno, Preventive, Maintenanceid, userlogin);
            process.ShowDialog();
        }

        private void btnUnitDetailRefresh_Click(object sender, EventArgs e)
        {
            lblsubunit.Text = "ViewFuel";
            lblUnitMenu.Text = "UnitDetail";
            string NumberofTable = " ";
            string main = "";
            string maintenancelist = "";
            string misMaintenance = "0";

            String TEST = "exec sp_Get_InfoAndMonitoring '" + unitListDetail.lblEqpNo.Text + "'," + "'" + unitListDetail.lblEqpName.Text + "'," + "'" + unitListDetail.lblNoName.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'";
            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_InfoAndMonitoring '" + unitListDetail.lblEqpNo.Text + "'," + "'" + unitListDetail.lblEqpName.Text + "'," + "'" + unitListDetail.lblNoName.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFFromDate.Text + "'," + "'" + unitListDetail.fuelViewControl.dtpFToDate.Text + "'"));
            unitListDetail.fuelViewControl.lblTotalFuelCost.Text = dsKey.Tables[4].Rows[0]["TotalFuelCost"].ToString();
            unitListDetail.fuelViewControl.lblTotalRefill.Text = dsKey.Tables[4].Rows[0]["TotalRefill"].ToString();
            DataTableReader drKey = dsKey.Tables[0].CreateDataReader();
            if (drKey.Read())
            {

                NumberofTable = dsKey.Tables[0].Rows[0]["NumberofTable"].ToString();
                main = dsKey.Tables[0].Rows[0]["maintable"].ToString();
                maintenancelist = dsKey.Tables[0].Rows[0]["maintenance"].ToString();

                if (NumberofTable == "0")
                {
                    MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                }
                else
                {
                    if (main != "0")
                    {
                        if (maintenancelist != "0")
                        {
                            misMaintenance = dsKey.Tables[1].Rows[0]["IsMaintenance"].ToString();
                        }
                        unitListDetail.lblUnitPrice.Text = dsKey.Tables[2].Rows[0]["UnitPrice"].ToString();
                        unitListDetail.lblEngineNo.Text = dsKey.Tables[2].Rows[0]["EngineNo"].ToString();
                        unitListDetail.lblChassisNo.Text = dsKey.Tables[2].Rows[0]["ChassisNo"].ToString();
                        unitListDetail.lblPiston.Text = dsKey.Tables[2].Rows[0]["PistonDisplacement"].ToString();
                        unitListDetail.lblCylinder.Text = dsKey.Tables[2].Rows[0]["NoCylinder"].ToString();
                        unitListDetail.lblMake.Text = dsKey.Tables[2].Rows[0]["Make"].ToString();
                        unitListDetail.lblSeries.Text = dsKey.Tables[2].Rows[0]["Series"].ToString();
                        unitListDetail.lblBodyType.Text = dsKey.Tables[2].Rows[0]["BodyType"].ToString();
                        unitListDetail.lblYearModel.Text = dsKey.Tables[2].Rows[0]["YearModel"].ToString();
                        unitListDetail.lblGrossWT.Text = dsKey.Tables[2].Rows[0]["GrossWT"].ToString();
                        unitListDetail.lblStatusPurchase.Text = dsKey.Tables[2].Rows[0]["StatusOfPurchase"].ToString();
                        unitListDetail.lblDatePurchase.Text = dsKey.Tables[2].Rows[0]["DateOfPurchase"].ToString().Replace(" 12:00:00 AM", "");
                        unitListDetail.lblSupplier.Text = dsKey.Tables[2].Rows[0]["Supplier"].ToString();
                        unitListDetail.lblCRNo.Text = dsKey.Tables[2].Rows[0]["CR_No"].ToString();
                        unitListDetail.lblMVFile.Text = dsKey.Tables[2].Rows[0]["MVFile_No"].ToString();
                        unitListDetail.lblExistingReading.Text = dsKey.Tables[2].Rows[0]["ExistingReadingkm"].ToString();
                        unitListDetail.lblExpired.Text = dsKey.Tables[2].Rows[0]["Month_R_Expired"].ToString() + " " + dsKey.Tables[2].Rows[0]["Year_R_Expired"].ToString();
                        unitListDetail.lblFuelType.Text = dsKey.Tables[2].Rows[0]["FuelType"].ToString();
                        unitListDetail.lblEqpNo.Text = dsKey.Tables[2].Rows[0]["EquipmentNo"].ToString();
                        unitListDetail.lblNoName.Text = dsKey.Tables[2].Rows[0]["PlateNo"].ToString();
                        unitListDetail.lblEqpName.Text = dsKey.Tables[2].Rows[0]["Model"].ToString();
                        unitListDetail.lblHourlyRate.Text = dsKey.Tables[2].Rows[0]["HourlyRates"].ToString();
                        unitListDetail.lblkmltr.Text = dsKey.Tables[2].Rows[0]["km_ltr"].ToString();



                        if (misMaintenance == "0")
                        {
                            // MessageBox.Show("WARNING!!! Total Km Travelled/Hour Used :" + MTotalUsed);
                            unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.Black;
                            unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.Black;
                        }
                        else
                        {
                            unitListDetail.fuelViewControl.lblTotalUsed.ForeColor = Color.DarkRed;
                            unitListDetail.fuelViewControl.lblTotalHours.ForeColor = Color.DarkRed;
                        }

                        if (maintenancelist == "0")
                        {
                            unitListDetail.fuelViewControl.lblTotalUsed.Text = "0";
                            unitListDetail.fuelViewControl.lblTotalHours.Text = "0";
                        }
                        else
                        {
                            unitListDetail.fuelViewControl.lblTotalUsed.Text = dsKey.Tables[1].Rows[0]["Kms_Used"].ToString();
                            unitListDetail.fuelViewControl.lblTotalHours.Text = dsKey.Tables[1].Rows[0]["Hrs_Used"].ToString();
                        }
                        //
                        //employeeControl.dgvEmployeeList.DataSource = null;

                        unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;

                        if (this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource != null)
                        {
                            this.unitListDetail.fuelViewControl.dgvDataMonitoring.DataSource = null;
                        }
                        else
                        {
                            this.unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Clear();
                        }


                        foreach (DataRow row in dsKey.Tables[3].Rows)
                        {
                            unitListDetail.fuelViewControl.dgvDataMonitoring.Rows.Add(row["Id"].ToString()
                                    , row["ConvertDate"].ToString().Replace(" 12:00:00 AM", "")
                                    , row["DriversName"].ToString()
                                    , row["kmhrStart"].ToString()
                                    , row["kmhrStop"].ToString()
                                    , row["Kms"].ToString()
                                    , row["Hrs"].ToString()
                                    , row["noltrsrefilled"].ToString()
                                    , row["FuelCost"].ToString()
                                    , row["Ltr/kms"].ToString()
                                    , row["Preventive"].ToString()
                                    , row["PumpIncharge"].ToString()
                                    , row["ProjectNo"].ToString()
                                    , row["ProjectSite"].ToString()
                                    , row["SourceOfFuel"].ToString()
                                    );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                    }
                }
            }

        }
    


        private void dgvDataMonitoring_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    EditFuelUnit update = new EditFuelUnit();
                    update.param(unitListDetail.fuelViewControl.dgvDataMonitoring[0, e.RowIndex].Value.ToString(), unitListDetail.fuelViewControl.dgvDataMonitoring[1, e.RowIndex].Value.ToString()
                        , unitListDetail.fuelViewControl.dgvDataMonitoring[2, e.RowIndex].Value.ToString(), unitListDetail.fuelViewControl.dgvDataMonitoring[7, e.RowIndex].Value.ToString()
                        , unitListDetail.fuelViewControl.dgvDataMonitoring[12, e.RowIndex].Value.ToString(), unitListDetail.fuelViewControl.dgvDataMonitoring[11, e.RowIndex].Value.ToString()
                        , unitListDetail.fuelViewControl.dgvDataMonitoring[4, e.RowIndex].Value.ToString(), unitListDetail.fuelViewControl.dgvDataMonitoring[6, e.RowIndex].Value.ToString(), EmployeeText, dtProjectSite);
                                            //, unitListDetail.fuelViewControl.dgvDataMonitoring[4, e.RowIndex].Value.ToString(), unitListDetail.fuelViewControl.dgvDataMonitoring[6, e.RowIndex].Value.ToString(), EmployeeText, dtProjectSite);
                    //  public void param(string id, string date, string driver, string refill, string contractid, string pumpincharge, string km, string hr, AutoCompleteStringCollection EmployeeTextAll, DataTable dtProjectSite)
                    update.ShowDialog();

                    GetUnitListbySearch();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            if(btnsearchclick == 0)
            {
                GetUnitListbyAuto();
            }
            else
            {
                GetUnitListbySearch();
            }
            */
            /*
            allMaintenanceExpenses.dgvExpenses[1, e.RowIndex].Value = update.strdate;
            allMaintenanceExpenses.dgvExpenses[2, e.RowIndex].Value = update.strEquipment;
            allMaintenanceExpenses.dgvExpenses[3, e.RowIndex].Value = update.strSolution;
            allMaintenanceExpenses.dgvExpenses[4, e.RowIndex].Value = update.strDriver;
            allMaintenanceExpenses.dgvExpenses[5, e.RowIndex].Value = update.strremark;
            allMaintenanceExpenses.dgvExpenses[6, e.RowIndex].Value = update.strCategory;
            allMaintenanceExpenses.dgvExpenses[7, e.RowIndex].Value = update.strPStatus;
            allMaintenanceExpenses.dgvExpenses[8, e.RowIndex].Value = update.strRStatus;
            allMaintenanceExpenses.dgvExpenses[9, e.RowIndex].Value = update.strSite;
            */
            // dgvExpenses[4, e.RowIndex].Value = update.strDuringRefuel;
        }

        #endregion End Unit menu


        #region Expenses
        /*
        private void dgvDailySheet__EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox auto = e.Control as TextBox;

            if (addDailyControl.dgvDailySheet.CurrentCell.ColumnIndex == 2)
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
                        auto.AutoCompleteCustomSource = data;
                    }
                }
                catch { }
            }
            else if (addDailyControl.dgvDailySheet.CurrentCell.ColumnIndex == 3)
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    EmployeeNo(data);
                    auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            else if (addDailyControl.dgvDailySheet.CurrentCell.ColumnIndex == 8)
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    EmployeeNo(data);
                    auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            else if (addDailyControl.dgvDailySheet.CurrentCell.ColumnIndex == 7)
            {
                auto.AutoCompleteCustomSource.Clear();
                auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                ProjectArrayList(data);
                auto.AutoCompleteCustomSource = data;
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
        */

        /// <summary>
        /// Not Use
        /// </summary>
        /// /
        /*
        private void PendingExpenses()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending' and IsDelete = 1", Connection);
            //DataTable dt = new DataTable();
            da.Fill(dtdata);

            allMaintenanceExpenses.dgvExpenses.DataSource = null;

            if (this.allMaintenanceExpenses.dgvExpenses.DataSource != null)
            {
                this.allMaintenanceExpenses.dgvExpenses.DataSource = null;
            }
            else
            {
                this.allMaintenanceExpenses.dgvExpenses.Rows.Clear();
            }

            int intRecord = dtdata.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtdata.Rows)
                {
                    //(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                    allMaintenanceExpenses.dgvExpenses.Rows.Add(row["Id"].ToString()
                        , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                        //, row["Category"].ToString()
                        // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                        , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                        , Convert.ToDecimal(row["Mileage"]) //"mileage"//
                        , row["Item"].ToString()
                        , row["PCS"].ToString()
                        , row["Driver"].ToString()
                        , row["Mechanic"].ToString()
                        , row["Diagnosis"].ToString()
                        , row["Remarks"].ToString()
                        , row["SubCategory"].ToString()
                        , row["PurChaseStatus"].ToString()
                        , row["RepairStatus"].ToString()
                        , row["ProjectSite"].ToString()
                        , row["ProjectNo"].ToString()
                        , row["Ap_Status"].ToString()
                        , "Approve"
                        );
                }
            }
            else
            {
            }
        }
        */


        #region ExpensesbtnSearch_Click
        private void ExpensesbtnSearch_Click(object sender, EventArgs e)
        {
            maintenanceAndRepair.dgvExpenses.DataSource = null;
            if (this.maintenanceAndRepair.dgvExpenses.DataSource != null)
            {
                this.maintenanceAndRepair.dgvExpenses.DataSource = null;
            }
            else
            {
                this.maintenanceAndRepair.dgvExpenses.Rows.Clear();
            }

            SqlDataReader reader;


            string spName = "sp_Get_RepairAndMaintenance";
            string RMEquipNo = "'" + maintenanceAndRepair.txtEquip.Text + "'";
            string RMDriver = "'" + maintenanceAndRepair.txtDriver.Text + "'";
            string RMMechanic = "'" + maintenanceAndRepair.txtMechanic.Text + "'";
            string RMProjectid = "'" + maintenanceAndRepair.txtProjectId.Text + "'";
            string RMItem = "'" + maintenanceAndRepair.txtItem.Text + "'";
            string RMProblem = "'" + maintenanceAndRepair.txtProblem.Text + "'";
            string RMSolution = "'" + maintenanceAndRepair.txtSolution.Text + "'";
            string RMStatus = "'" + maintenanceAndRepair.cmbstatus.SelectedItem.ToString() + "'";
            string RMCategory = "'" + maintenanceAndRepair.cmbCategory.SelectedValue.ToString() + "'";
            string RMForIsPMS = "'" + IsPMS + "'";
            string RMRType = "'" + maintenanceAndRepair.cmbMaintenanceType.SelectedItem.ToString() + "'";
            string RMFromDate = "'" + maintenanceAndRepair.dtfrom.Text + "'";
            string RMToDate = "'" + maintenanceAndRepair.dtTo.Text + "'";

            reader = monitoring.ExecuteReader(spName,RMEquipNo, RMDriver, RMMechanic, RMProjectid, RMItem, RMProblem, RMSolution, RMStatus,RMCategory, RMForIsPMS, RMRType, RMFromDate, RMToDate);
            DataTable Detail = new DataTable();
            Detail.Load(reader);


            foreach (DataRow row in Detail.Rows)
            {
                maintenanceAndRepair.dgvExpenses.Rows.Add(row["ExpID"].ToString() //+ " " + row["Year_R_Expired"].ToString()//.Replace(" 12:00:00 AM", "")
                            , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                            , row["Mileage"].ToString()
                            , row["Driver"].ToString()
                            , row["Diagnosis"].ToString()
                            , row["Remarks"].ToString()
                            , row["REStatus"].ToString()
                            , row["ProjectNo"].ToString()
                            , "ACKNOWLEDGE"
                            //, row["EquipmentNo"].ToString()
                            //, row["Model"].ToString()
                            //, row["PlateNo"].ToString()
                            //, row["ProjectSite"].ToString()
                            //, row["IsPMS"].ToString()
                            //, row["Problem"].ToString()
                            //, row["StartRepairDate"].ToString()
                            //, row["RepairCompleted"].ToString()
                            //, row["StatusCode"].ToString()
                 );
            }
        }
            #endregion

            #region ExpensesbtnSearch_old_Click

        private void ExpensesbtnSearch_old_Click(object sender, EventArgs e)
        {
            dtdata.Clear();
            if (allMaintenanceExpenses.txtEquip.Text == "")
            {
                if (allMaintenanceExpenses.cmbCategory.Text == "ALL")
                {
                    if (allMaintenanceExpenses.cmbstatus.Text == "All")
                    {
                        if(allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    "and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " + 
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%'  and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                       "and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        " and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    "and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%'  and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" + 
                                      (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                     "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                       "and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Pending Purchase")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%'  and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "'  and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {

                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                     "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Pending Repair")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%'  and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "'  and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                     "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "All Pending")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%'  and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "'  and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                     "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Parts Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                     "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Repair Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "% " +
                                        "' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                    }
                    else //if (cmbstatus.Text == "Repair Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }

                }
                else
                {
                    if (allMaintenanceExpenses.cmbstatus.Text == "All")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                      "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                      "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Pending Purchase")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Pending Repair")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "All Pending")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                       
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Parts Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Repair Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else //if (cmbstatus.Text == "Repair Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                }
            }
            else
            {
                if (allMaintenanceExpenses.cmbCategory.Text == "ALL")
                {
                    if (allMaintenanceExpenses.cmbstatus.Text == "All")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                /*
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                      "Diagnosis like '%" + txtSolution.Text +
                                      "%' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                     + "%' or Model like '%" + txtEquip.Text + "%'", Connection);
                                */
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                   SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                  SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                /*
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                      "Diagnosis like '%" + txtSolution.Text +
                                      "%' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                     + "%' or Model like '%" + txtEquip.Text + "%'", Connection);
                                */
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                   SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                  SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Pending Purchase")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where  ISNULL(PartsCompleted,'')='' and IsPurchase = 1 " +
                                      " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where  ISNULL(PartsCompleted,'')='' and IsPurchase = 1 " +
                                      " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                            
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Pending Repair")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "All Pending")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' " +
                                      " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' " +
                                      " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Parts Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Repair Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>''" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>''" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>''" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>''" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else //if (cmbstatus.Text == "Repair Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }

                }
                else
                {
                    if (allMaintenanceExpenses.cmbstatus.Text == "All")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                      "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                      "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Pending Purchase")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Pending Repair")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "All Pending")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%'  and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        ")  and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Parts Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "  Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                            
                    }
                    else if (allMaintenanceExpenses.cmbstatus.Text == "Repair Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + allMaintenanceExpenses.cmbCategory.Text + "' " +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     " Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                            
                    }
                    else //if (cmbstatus.Text == "Repair Completed")
                    {
                        if (allMaintenanceExpenses.cmbMaintenanceType.Text == "ALL")
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                        else
                        {
                            if (isCheck == "0")
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                     "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                            else
                            {
                                // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                                daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(DateCompleted,'')<>'' and Driver like '%" + allMaintenanceExpenses.txtDriver.Text + "%'" +
                                    " and " + SearchType + " like '%" + allMaintenanceExpenses.txtEquip.Text + "%' and " +
                                    "Mechanic like '%" + allMaintenanceExpenses.txtMechanic.Text + "%' and " +
                                    "Item like '%" + allMaintenanceExpenses.txtItem.Text + "%' and " +
                                    "ProjectNo like '%" + allMaintenanceExpenses.txtProjectId.Text + "%' and " +
                                    "Problem like '%" + allMaintenanceExpenses.txtProblem.Text + "%' and " +
                                        "Diagnosis like '%" + allMaintenanceExpenses.txtSolution.Text + "%' and Date Between '" + allMaintenanceExpenses.dtfrom.Text + "' and '" + allMaintenanceExpenses.dtTo.Text + "' " +
                                        "and SubCategory in (select [Sub-Category] from m_SubCategoryList with (nolock)  where RType = '" +
                                         (allMaintenanceExpenses.cmbMaintenanceType.Text == "N/A" ? "NA" : allMaintenanceExpenses.cmbMaintenanceType.Text) +
                                        "') and IsDelete = 1 order by id asc", Connection);
                            }
                        }
                            
                    }

                }
            }

            /////////////////////////////////////here
            daData.Fill(dtdata);

            allMaintenanceExpenses.dgvExpenses.DataSource = null;

            if (this.allMaintenanceExpenses.dgvExpenses.DataSource != null)
            {
                this.allMaintenanceExpenses.dgvExpenses.DataSource = null;
            }
            else
            {
                this.allMaintenanceExpenses.dgvExpenses.Rows.Clear();
            }

            int intRecord = dtdata.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtdata.Rows)
                {
                    allMaintenanceExpenses.dgvExpenses.Rows.Add(row["Id"].ToString()
                       , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                       //, row["Category"].ToString()
                       // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                       , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                        , Convert.ToDecimal(row["Mileage"]) //"mileage"//
                        , row["Item"].ToString()
                        , row["PCS"].ToString()
                        , row["Driver"].ToString()
                        , row["Mechanic"].ToString()
                        , row["Diagnosis"].ToString()
                        , row["Remarks"].ToString()
                        , row["SubCategory"].ToString()
                        , row["PurChaseStatus"].ToString()
                        , row["RepairStatus"].ToString()
                        , row["ProjectSite"].ToString()
                        , row["ProjectNo"].ToString()
                        , row["Ap_Status"].ToString()
                       , "Approve"
                       );

                    ////(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                    //allMaintenanceExpenses.dgvExpenses.Rows.Add(row["Id"].ToString()
                    //    , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                    //    //, row["Category"].ToString()
                    //    // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                    //    , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                    //    , row["Diagnosis"].ToString()
                    //    , row["Driver"].ToString()
                    //    , row["Remarks"].ToString()
                    //    , row["SubCategory"].ToString()
                    //    , row["PurChaseStatus"].ToString()
                    //    , row["RepairStatus"].ToString()
                    //    , row["ProjectSite"].ToString()
                    //    , row["ProjectNo"].ToString()
                    //    );
                }
            }
            else
            {
            }


        }

        #endregion

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (maintenanceAndRepair.chkFilter.Checked == true)
            {
                maintenanceAndRepair.groupDate.Visible = true;
                //allMaintenanceExpenses.groupDate.Visible = true;
                isCheck = "1";
            }
            else
            {
                maintenanceAndRepair.groupDate.Visible = false;
                //allMaintenanceExpenses.groupDate.Visible = false;
                isCheck = "0";
            }
        }

        private void chkPMS_CheckedChanged(object sender, EventArgs e)
        {
            if (maintenanceAndRepair.chkPMS.Checked == true)
            {
                IsPMS = "1";
            }
            else
            {
                IsPMS = "0";
            }
        }


        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allMaintenanceExpenses.cmbstatus.SelectedIndex == 0)
            {
                status = "All";
            }
        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (allMaintenanceExpenses.cmbSearchType.SelectedIndex == 0)
            {
                SearchType = "EquipmentNo";
                allMaintenanceExpenses.txtEquip.AutoCompleteCustomSource = EquipmentNoCollection;
            }
            else if (allMaintenanceExpenses.cmbSearchType.SelectedIndex == 1)
            {
                SearchType = "Model";
                allMaintenanceExpenses.txtEquip.AutoCompleteCustomSource = ModelNoCollection;
            }
            else
            {
                SearchType = "PlateNo";
                allMaintenanceExpenses.txtEquip.AutoCompleteCustomSource = PlateNoCollection;
            }
            /*
            if (allMaintenanceExpenses.cmbstatus.Text == "EQUIPMENT NO")
            {
                SearchType = "EquipmentNo";
            }
            else if(allMaintenanceExpenses.cmbstatus.Text == "MODEL")
            {
                SearchType = "Model";
            }
            else
            {
                SearchType = "PlateNo";
            }
            */
        }


        private void dgvExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == 9)
                    {
                        if (UserRoles == "0")
                        {
                            MessageBox.Show("You Dont have Permission to Acknowledge");
                        }
                        else
                        {
                            //APPROVED

                            string Ap_Status = maintenanceAndRepair.dgvExpenses.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();

                          if(Ap_Status.ToLower() == "for acknowledge")
                          {

                                DialogResult dialogResult = MessageBox.Show("Please Click Yes To Acknowledge", "Acknowledge", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    SqlDataReader reader;
                                    string Userid = "'" + userlogin + "'";
                                    string id = "'" + maintenanceAndRepair.dgvExpenses.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() + "'";
                                    string spName = "sp_Maintenance_Acknowledge";

                                    reader = monitoring.ExecuteReader(spName, id, Userid);
                                    DataTable result = new DataTable();
                                    result.Load(reader);
                                    string Result = result.Rows[0]["Result"].ToString();
                                    if (Result == "1")
                                    {
                                        MessageBox.Show("Successfully Updated..");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed Update.");
                                    }
                                    //MessageBox.Show(allMaintenanceExpenses.dgvExpenses.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                                }
                                //MessageBox.Show((e.RowIndex + 1).ToString() + " Row Clicked");
                           }
                           else if (Ap_Status.ToLower() == "acknowledged")
                            {
                                MessageBox.Show("Already Approved");
                            }
                            else 
                            {
                                MessageBox.Show("Cannot Acknowledge. Status not equal to For Acknowledge");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // dgvExpenses[4, e.RowIndex].Value = update.strDuringRefuel;
        }



        //expenses pending
        //  public void Param(string id, string Rstatus, string PStatus)

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex < 9)
                    {
                        /*
                            string pEquipno, string pModel, string pPlateno, string pMileage, string pDriver,
                            string pContractID, string pProjectSite, string pDate, string pIsPMS, string pProblem,
                            string pSolution, string pRemarks, string pRepairStart, string pRepairComplete, string pStatusCode
                        */

                        ExpensesRequest expenses = new EquipmentMonitoring.AllForm.expenses.ExpensesRequest();
                        expenses.Param(maintenanceAndRepair.dgvExpenses[0, e.RowIndex].Value.ToString(), UserRoles, dtProjectSite, EmployeeText, userlogin, dtCategoryNoAll, EquipArray);
                        //expenses.Param(allMaintenanceExpenses.dgvExpenses[0, e.RowIndex].Value.ToString(), allMaintenanceExpenses.dgvExpenses[12, e.RowIndex].Value.ToString(), allMaintenanceExpenses.dgvExpenses[11, e.RowIndex].Value.ToString()
                        //    , dtProjectSite, EmployeeTextAll, userlogin);
                        expenses.Show();
                        // (string id, string Rstatus, string PStatus, DataTable dtProjectSite, AutoCompleteStringCollection EmployeeTextAll)
                        //if (expenses.Cancel == 0)
                        //{
                        //    ExpensesbtnSearch_Click(allMaintenanceExpenses.btnSearch, EventArgs.Empty);
                        //}
                    }

                    /*
                    allMaintenanceExpenses.dgvExpenses[1, e.RowIndex].Value = update.strdate.Replace("'", "");
                    allMaintenanceExpenses.dgvExpenses[2, e.RowIndex].Value = update.strEquipment;
                    allMaintenanceExpenses.dgvExpenses[3, e.RowIndex].Value = update.strSolution;
                    allMaintenanceExpenses.dgvExpenses[4, e.RowIndex].Value = update.strDriver;
                    allMaintenanceExpenses.dgvExpenses[5, e.RowIndex].Value = update.strremark;
                    allMaintenanceExpenses.dgvExpenses[6, e.RowIndex].Value = update.strCategory;
                    allMaintenanceExpenses.dgvExpenses[7, e.RowIndex].Value = update.strPStatus;
                    allMaintenanceExpenses.dgvExpenses[8, e.RowIndex].Value = update.strRStatus;
                    allMaintenanceExpenses.dgvExpenses[9, e.RowIndex].Value = update.strSite;
                    */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // dgvExpenses[4, e.RowIndex].Value = update.strDuringRefuel;
        }



        private void dgvExpenses_Old_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex < 16)
                    {
                        UpdateExpenses update = new UpdateExpenses();
                        update.Param(allMaintenanceExpenses.dgvExpenses[0, e.RowIndex].Value.ToString(), allMaintenanceExpenses.dgvExpenses[12, e.RowIndex].Value.ToString(), allMaintenanceExpenses.dgvExpenses[11, e.RowIndex].Value.ToString()
                            , dtProjectSite, EmployeeText, userlogin);
                        update.ShowDialog();
                       // (string id, string Rstatus, string PStatus, DataTable dtProjectSite, AutoCompleteStringCollection EmployeeTextAll)
                        if (update.Cancel == 0)
                        {
                            ExpensesbtnSearch_old_Click(allMaintenanceExpenses.btnSearch, EventArgs.Empty);
                        }
                    }

                    /*
                    allMaintenanceExpenses.dgvExpenses[1, e.RowIndex].Value = update.strdate.Replace("'", "");
                    allMaintenanceExpenses.dgvExpenses[2, e.RowIndex].Value = update.strEquipment;
                    allMaintenanceExpenses.dgvExpenses[3, e.RowIndex].Value = update.strSolution;
                    allMaintenanceExpenses.dgvExpenses[4, e.RowIndex].Value = update.strDriver;
                    allMaintenanceExpenses.dgvExpenses[5, e.RowIndex].Value = update.strremark;
                    allMaintenanceExpenses.dgvExpenses[6, e.RowIndex].Value = update.strCategory;
                    allMaintenanceExpenses.dgvExpenses[7, e.RowIndex].Value = update.strPStatus;
                    allMaintenanceExpenses.dgvExpenses[8, e.RowIndex].Value = update.strRStatus;
                    allMaintenanceExpenses.dgvExpenses[9, e.RowIndex].Value = update.strSite;
                    */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // dgvExpenses[4, e.RowIndex].Value = update.strDuringRefuel;
        }


        private void lbladdExpenses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUnitExpenses expenses = new AddUnitExpenses();
            expenses.Param(EmployeeList, ProjectSiteArray, EquipArray, dtCategoryNoAll, userlogin);
            expenses.ShowDialog();


            ///old
            //AddUnitExpenses expenses = new AddUnitExpenses();
            // expenses.Param(EmployeeList, ProjectSiteArray, EquipArray, dtCategoryNoAll, userlogin);
            //expenses.ShowDialog();
            ///old


            //ExpensesbtnSearch_Click(allMaintenanceExpenses.btnSearch, EventArgs.Empty);
            //AddExpenses expenses = new AddExpenses();
            //expenses.param(userlogin);
            //expenses.ShowDialog();
            //ExpensesbtnSearch_Click(allMaintenanceExpenses.btnSearch, EventArgs.Empty);
        }


        //////
        /////
        /////
        /////


        #endregion end expenses

        #region MaintenanceListCode

        private void MaintenancetxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    MainteListbtnSearch_Click(maintenanceListControl.btnSearch, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmbMaintenanceSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  EquipmentNoCollection.Clear();
            if (maintenanceListControl.cmbUnitList.SelectedIndex == 0)
            {
                MaintenanceSearchType = "EquipmentNo";
                maintenanceListControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
            }
            else if (maintenanceListControl.cmbUnitList.SelectedIndex == 1)
            {
                MaintenanceSearchType = "Model";
                maintenanceListControl.txtSearch.AutoCompleteCustomSource = ModelNoCollection;
            }
            else
            {
                MaintenanceSearchType = "PlateNo";
                maintenanceListControl.txtSearch.AutoCompleteCustomSource = PlateNoCollection;
            }
        }

        
        public void getMaintenance()
        {
            SqlDataAdapter DATA = new SqlDataAdapter("select MaintenanceId, EquipmentNo, Model, PlateNo, Kms_Used, Hrs_Used," +
                       "CONVERT(VARCHAR(10), DateView, 101) as DateView, DateMaintenance, Remarks, Preventive, Status from m_MaintenanceList with(nolock) where Remarks = '0' and " + MaintenanceSearchType + " like '%" + maintenanceListControl.txtSearch.Text + "%' " +
                       "and Kms_Used >= (select top(1) km from m_TruckType with (nolock) where Base = 'KM' and IsDelete = '1') and DateMaintenance is null and DateMaintenance is null or Remarks = '0' and " + MaintenanceSearchType + " like '%" + maintenanceListControl.txtSearch.Text + "%' and" +
                       " Hrs_Used >= (select top(1) hrs from m_TruckType with (nolock) where Base = 'HR'  and IsDelete = '1') and DateMaintenance is null", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            maintenanceListControl.dgvMaintenance.DataSource = null;
            if (this.maintenanceListControl.dgvMaintenance.DataSource != null)
            {
                this.maintenanceListControl.dgvMaintenance.DataSource = null;
            }
            else
            {
                this.maintenanceListControl.dgvMaintenance.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    maintenanceListControl.dgvMaintenance.Rows.Add(row["MaintenanceId"].ToString()
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            , row["Kms_Used"].ToString()
                            , row["Hrs_Used"].ToString()
                            , row["Status"].ToString()
                            , row["Preventive"].ToString()
                            );
                }
                maintenanceListControl.lblresult.Visible = false;
            }
            else
            {
                maintenanceListControl.lblresult.Visible = true;
            }

        }

        private void MainteListbtnSearch_Click(object sender, EventArgs e)
        {
            getMaintenance();
        }

        private void dgvMaintenance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Equipmentno = maintenanceListControl.dgvMaintenance[1, e.RowIndex].Value.ToString();
            string Model = maintenanceListControl.dgvMaintenance[2, e.RowIndex].Value.ToString();
            string Plateno = maintenanceListControl.dgvMaintenance[3, e.RowIndex].Value.ToString();
            string Status = maintenanceListControl.dgvMaintenance[6, e.RowIndex].Value.ToString();
            string Preventive;
            string Maintenanceid = maintenanceListControl.dgvMaintenance[0, e.RowIndex].Value.ToString();

            if(Status.ToLower() == "approved")
            {
                string PEquipmentno = "'" + Equipmentno + "'";
                string PModel = "'" + Model + "'";
                string PPlateno = "'" + Plateno + "'";

                string spName = "sp_Get_Preventive";
                SqlDataReader reader;

                reader = monitoring.ExecuteReader(spName, PEquipmentno, PModel, PPlateno);
                DataTable result = new DataTable();
                result.Load(reader);
                Preventive = result.Rows[0]["Result"].ToString();
                //Maintenanceid = result.Rows[0]["MaintenanceId"].ToString();


                ProcessMaintenance process = new ProcessMaintenance();
                process.param(Equipmentno, Model, Plateno, Preventive, Maintenanceid, userlogin);
                process.ShowDialog();
            }
            else
            {
                MessageBox.Show("Unit is not yet Approved.");
            }


        }


        #endregion

        #region MaintenanceHistory List


        private void dgvMaintenanceHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Equipmentno = mainHistoryControl.dgvMaintenance[2, e.RowIndex].Value.ToString();
            string Model = mainHistoryControl.dgvMaintenance[3, e.RowIndex].Value.ToString();
            string Plateno = mainHistoryControl.dgvMaintenance[4, e.RowIndex].Value.ToString();
            string Preventive = mainHistoryControl.dgvMaintenance[7, e.RowIndex].Value.ToString();
            string Maintenanceid = mainHistoryControl.dgvMaintenance[0, e.RowIndex].Value.ToString();

            string Prevent;

            if(Preventive =="PM1")
            {
                Prevent = "0";
            }
            else if(Preventive == "PM2")
            {
                Prevent = "1";
            }
            else if(Preventive == "PM3")
            {
                Prevent = "2";
            }
            else
            {
                Prevent = "3";
            }


            UpdatePMS process = new UpdatePMS();
            process.param(Equipmentno, Model, Plateno, Prevent, Maintenanceid, userlogin);
            process.ShowDialog();
        }

        private void MainHistorytxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    MainteHistorybtnSearch_Click(mainHistoryControl.btnSearch, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmbMainHistorySearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  EquipmentNoCollection.Clear();
            if (mainHistoryControl.cmbUnitList.SelectedIndex == 0)
            {
                MaintenanceHistorySearchType = "EquipmentNo";
                mainHistoryControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
            }
            else if (maintenanceListControl.cmbUnitList.SelectedIndex == 1)
            {
                MaintenanceHistorySearchType = "Model";
                mainHistoryControl.txtSearch.AutoCompleteCustomSource = ModelNoCollection;
            }
            else
            {
                MaintenanceHistorySearchType = "PlateNo";
                mainHistoryControl.txtSearch.AutoCompleteCustomSource = PlateNoCollection;
            }
        }


        public void getMaintenanceHistory()
        {
            SqlDataAdapter DATA = new SqlDataAdapter("select MaintenanceId, EquipmentNo, Model, PlateNo, Kms_Used, Hrs_Used," +
                       "CONVERT(VARCHAR(10), DateView, 101) as DateView, DateMaintenance, Remarks, Preventive from m_MaintenanceList with(nolock) where Remarks = '1' and " + MaintenanceHistorySearchType + " like '%" + mainHistoryControl.txtSearch.Text + "%' " +
                       "and DateMaintenance is not null", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            mainHistoryControl.dgvMaintenance.DataSource = null;
            if (this.mainHistoryControl.dgvMaintenance.DataSource != null)
            {
                this.mainHistoryControl.dgvMaintenance.DataSource = null;
            }
            else
            {
                this.mainHistoryControl.dgvMaintenance.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    mainHistoryControl.dgvMaintenance.Rows.Add(row["MaintenanceId"].ToString()
                            , row["DateMaintenance"].ToString().Replace(" 12:00:00 AM", "")
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            , row["Kms_Used"].ToString()
                            , row["Hrs_Used"].ToString()
                            , row["Preventive"].ToString()
                            );
                }
                mainHistoryControl.lblresult.Visible = false;
            }
            else
            {
                mainHistoryControl.lblresult.Visible = true;
            }

        }

        private void MainteHistorybtnSearch_Click(object sender, EventArgs e)
        {
            getMaintenanceHistory();
        }


        #endregion

        #endregion

        #region Reports

        ////////////////////
        ////////////////////


        private void YearList()
        {
            SqlDataAdapter da = new SqlDataAdapter("select distinct Year from vw_MonthlyExpenses with(nolock) where Year is not null", Connection);

            da.Fill(dtYearExpenses);

            // CONVERT(VARCHAR(10), Date, 101)
            //Truck
            monthlyFormControl.truckMonthlyControl.cmbFromYear.DataSource = dtYearExpenses;
            monthlyFormControl.truckMonthlyControl.cmbFromYear.DisplayMember = "Year";
            monthlyFormControl.truckMonthlyControl.cmbFromYear.ValueMember = "Year";

            //project
            monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.DataSource = dtYearExpenses;
            monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.DisplayMember = "Year";
            monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.ValueMember = "Year";
            /*
            positionControl.dgvPosition.DataSource = null;

            if (this.positionControl.dgvPosition.DataSource != null)
            {
                this.positionControl.dgvPosition.DataSource = null;
            }
            else
            {
                this.positionControl.dgvPosition.Rows.Clear();
            }

            int intRecord = dtYearExpenses.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtYearExpenses.Rows)
                {
                    positionControl.dgvPosition.Rows.Add(row["Position"].ToString());
                }
            }
            else
            {
            }
            */
        }

        #region TruckMonthly

        /*
            reportsControl.btnDailyReport.Click += btnDailyReport_Click;
            reportsControl.btnMonthlyReport.Click += btnMonthlyReport_Click;
            reportsControl.btnOverAllReport.Click += btnOverAllReport_Click;
        */
        //Main menu
        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            lblReportMainLast.Text = "Daily";


            /*
                if (lblReportMainLast.Text == "Daily")
                {
                }
                else if (lblReportMainLast.Text == "Monthly")
            lblReportMonthlyLast.Text = "Truck";
            monthlyFormControl.panelTruckandHeavy.Show();
            monthlyFormControl.panelProjectSiteMonthly.Hide();
            */
        }
        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            lblReportMainLast.Text = "Monthly";
            monthlyFormControl.BringToFront();
            reportsControl.panelMonthlyReport.Show();
            reportsControl.panelOverAllReport.Hide();


            if (lblReportMonthlyLast.Text == "Truck")
            {
                monthlyFormControl.panelTruckandHeavy.Show();
                monthlyFormControl.panelProjectSiteMonthly.Hide();
            }
            else
            {
                monthlyFormControl.panelProjectSiteMonthly.Show();
                monthlyFormControl.panelTruckandHeavy.Hide();
            }

        }
        private void btnOverAllReport_Click(object sender, EventArgs e)
        {
            lblReportMainLast.Text = "OverAll";
            overallReportControl.BringToFront();
            reportsControl.panelOverAllReport.Show();
            reportsControl.panelMonthlyReport.Hide();


            if (lblReportOverAllLast.Text == "Truck")
            {
                overallReportControl.panelTruckandHeavy.Show();
                overallReportControl.panelProjectSiteOverall.Hide();
                overallReportControl.truckOverallExpensesControl.BringToFront();
            }
            else
            {
                overallReportControl.panelProjectSiteOverall.Show();
                overallReportControl.panelTruckandHeavy.Hide();
                overallReportControl.projectSiteOverAllControl.BringToFront();
            }
        }

        //Sub Menu
        private void btnTruckMontlyExpenses_Click(object sender, EventArgs e)
        {
            lblReportMonthlyLast.Text = "Truck";
            monthlyFormControl.panelTruckandHeavy.Show();
            monthlyFormControl.panelProjectSiteMonthly.Hide();
            monthlyFormControl.truckMonthlyControl.BringToFront();
        }
        //Sub Menu
        private void btnProjectsiteMontlyExpenses_Click(object sender, EventArgs e)
        {
            lblReportMonthlyLast.Text = "Projectsite";
            monthlyFormControl.panelProjectSiteMonthly.Show();
            monthlyFormControl.panelTruckandHeavy.Hide();
            monthlyFormControl.projectSiteMonthlyControl.BringToFront();
            //monthlyFormControl.projectSiteMonthlyControl.Hide();

            //monthlyFormControl.projectSiteEquipmentM.BringToFront();
        }


        //TruckMonth
        private void btnTruckMonthlySearch_Click(object sender, EventArgs e)
        {
            monthlyFormControl.truckMonthlyControl.lblMonthFilter.Text = "Report Month : " + monthlyFormControl.truckMonthlyControl.cmbFromMonth.Text + " " + monthlyFormControl.truckMonthlyControl.cmbFromYear.Text;
            TruckMonthlist();
        }
        private void cmbTMExpensesSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  EquipmentNoCollection.Clear();
            if (monthlyFormControl.truckMonthlyControl.cmbUnitList.SelectedIndex == 0)
            {
                TMonthlySearchType = "EquipmentNo";
                monthlyFormControl.truckMonthlyControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
            }
            else if (monthlyFormControl.truckMonthlyControl.cmbUnitList.SelectedIndex == 1)
            {
                TMonthlySearchType = "Model";
                monthlyFormControl.truckMonthlyControl.txtSearch.AutoCompleteCustomSource = ModelNoCollection;
            }
            else
            {
                TMonthlySearchType = "PlateNo";
                monthlyFormControl.truckMonthlyControl.txtSearch.AutoCompleteCustomSource = PlateNoCollection;
            }
        }

        private void TruckMonthlist()
        {
            dtTruckMonthlyGrid.Clear();
            dtTruckMonthlyLabel.Clear();
            monthlyFormControl.truckMonthlyControl.lblMessage.Visible = false;
            SqlDataAdapter da = new SqlDataAdapter("select * from vw_MonthlyExpenses with(nolock) where " + TMonthlySearchType + " like '%" + monthlyFormControl.truckMonthlyControl.txtSearch.Text + "%' " +
                " and Month = '" + monthlyFormControl.truckMonthlyControl.cmbFromMonth.Text + "' and Year= '" + monthlyFormControl.truckMonthlyControl.cmbFromYear.Text + "'", Connection);

            //SqlDataAdapter daGrandtotal = new SqlDataAdapter("select CONVERT([decimal](18,2),SUM(TotalKm)) as TotalKm,  CONVERT([decimal](18,2),SUM(Totalhrs)) as Totalhrs" +
            //    "   , CONVERT([decimal](18,2),SUM(TotalLiters)) as TotalLiters, CONVERT([decimal](18,2),SUM(TotalFuelCost)) as TotalFuelCost, CONVERT([decimal](18,2),SUM(PMS)) as PMS" +
            //    ", CONVERT([decimal](18,2),SUM(Repair)) as Repair, CONVERT([decimal](18,2),SUM(Tire)) as Tire,  CONVERT([decimal](18,2),SUM(TotalExpenses)) as TotalExpenses" +
            //    " from vw_MonthlyExpenses with(nolock) where " + TMonthlySearchType + " like '%" + monthlyFormControl.truckMonthlyControl.txtSearch.Text + "%' " +
            //    " and Month = '" + monthlyFormControl.truckMonthlyControl.cmbFromMonth.Text + "' and Year= '" + monthlyFormControl.truckMonthlyControl.cmbFromYear.Text + "'", Connection);

            SqlDataAdapter daGrandtotal = new SqlDataAdapter("select CONVERT([decimal](18,2),SUM(Km)) as TotalKm,  CONVERT([decimal](18,2),SUM(Hrs)) as Totalhrs" +
                "   , CONVERT([decimal](18,2),SUM(Liters)) as TotalLiters, CONVERT([decimal](18,2),SUM(FuelCost)) as TotalFuelCost, CONVERT([decimal](18,2),SUM(PMS)) as PMS" +
                ", CONVERT([decimal](18,2),SUM(Repair)) as Repair, CONVERT([decimal](18,2),SUM(Tire)) as Tire,  CONVERT([decimal](18,2),SUM(TotalExpenses)) as TotalExpenses" +
                " from vw_MonthlyExpenses with(nolock) where " + TMonthlySearchType + " like '%" + monthlyFormControl.truckMonthlyControl.txtSearch.Text + "%' " +
                " and Month = '" + monthlyFormControl.truckMonthlyControl.cmbFromMonth.Text + "' and Year= '" + monthlyFormControl.truckMonthlyControl.cmbFromYear.Text + "'", Connection);



            //DataTable dtGrandTotal = new DataTable();
            daGrandtotal.Fill(dtTruckMonthlyLabel);

            foreach (DataRow row in dtTruckMonthlyLabel.Rows)
            {
                monthlyFormControl.truckMonthlyControl.lblkm.Text = row["TotalKm"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalKm"]));
                monthlyFormControl.truckMonthlyControl.lblhrs.Text = row["Totalhrs"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Totalhrs"]));
                monthlyFormControl.truckMonthlyControl.lblliters.Text = row["TotalLiters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalLiters"]));
                monthlyFormControl.truckMonthlyControl.lblfuelcost.Text = row["TotalFuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalFuelCost"]));
                monthlyFormControl.truckMonthlyControl.lblpms.Text = row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]));
                monthlyFormControl.truckMonthlyControl.lblrepair.Text = row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]));
                monthlyFormControl.truckMonthlyControl.lbltire.Text = row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]));
                monthlyFormControl.truckMonthlyControl.lblexpenses.Text = row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]));
            }

            //DataTable dttruckmexpenses = new DataTable();

            da.Fill(dtTruckMonthlyGrid);

            monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.DataSource = null;

            if (this.monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.DataSource != null)
            {
                this.monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.DataSource = null;
            }
            else
            {
                this.monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.Rows.Clear();
            }

            int intRecord = dtTruckMonthlyGrid.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtTruckMonthlyGrid.Rows)
                {
                    //monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.Rows.Add(row["EquipmentNo"].ToString()
                    //     , row["Model"].ToString()
                    //     , row["PlateNo"].ToString()
                    //     , (row["TotalKm"].ToString() == "" ? "0.00" : row["TotalKm"].ToString())
                    //     , (row["Totalhrs"].ToString() == "" ? "0.00" : row["Totalhrs"].ToString())
                    //     , (row["TotalLiters"].ToString() == "" ? "0.00" : row["TotalLiters"].ToString())
                    //     //, (row["Ltrkm"].ToString() == "" ? "0.00" : row["Ltrkm"].ToString()) 
                    //     , (row["TotalFuelCost"].ToString() == "" ? "0.00" : row["TotalFuelCost"].ToString())
                    //     , (row["PMS"].ToString() == "" ? "0.00" : row["PMS"].ToString())
                    //     , (row["Repair"].ToString() == "" ? ".00" : row["Repair"].ToString())
                    //     , (row["Tire"].ToString() == "" ? ".00" : row["Tire"].ToString())
                    //     , (row["TotalExpenses"].ToString() == "" ? ".00" : row["TotalExpenses"].ToString()));

                    monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.Rows.Add(row["EquipmentNo"].ToString()
                                , row["Model"].ToString()
                                , row["PlateNo"].ToString()
                                , (row["Km"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Km"])))
                                , (row["Hrs"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["hrs"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                                , (row["Liters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Liters"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                                , (row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"])))// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalFuelCost"]))// row["TotalFuelCost"].ToString()
                                , (row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["PMS"]))// row["PMS"].ToString()
                                , (row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                                , (row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                                , (row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]))));// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalExpenses"])));//row["TotalExpenses"].ToString());



                    /*
                    , (row["TotalKm"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalKm"])))//row["TotalKm"].ToString())//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalKm"]))//row["TotalKm"].ToString()
                    , (row["Totalhrs"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Totalhrs"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Totalhrs"]))//row["Totalhrs"].ToString()
                    , (row["TotalLiters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalLiters"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                    , (row["Ltrkm"].ToString() == "" ? "0.00" : row["Ltrkm"].ToString())                                      // , (row["Ltrkm"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Ltrkm"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Ltrkm"]))// row["Ltrkm"].ToString()
                    , (row["TotalFuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalFuelCost"])))// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalFuelCost"]))// row["TotalFuelCost"].ToString()
                    , (row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["PMS"]))// row["PMS"].ToString()
                    , (row["Repair"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                    , (row["Tire"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                    , (row["TotalExpenses"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]))));// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalExpenses"])));//row["TotalExpenses"].ToString());
                   */
                    // String.Format("{0:#,###.0}", Convert.ToDecimal(row["Availability"]))//row["Availability"].ToString()
                }
            }
            else
            {
                monthlyFormControl.truckMonthlyControl.lblMessage.Visible = true;
            }
        }

        #endregion
        ////////////////////
        ////////////////////

        #region Monthly report projectsite

        private void GetProjectSiteMonthlyDetail(string ProjectNo, string ProjectSite, string ProjectDate, string Month, string Year)
        {
            try
            {
                DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_GetTruckOverAll '" + TOverAllSearchType + "'," + "'" + overallReportControl.truckOverallExpensesControl.txtSearch.Text + "'"));
                DataTableReader drKey = dsKey.Tables[1].CreateDataReader();
                //   Detail.Load(reader);

                overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.DataSource = null;

                if (this.overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.DataSource != null)
                {
                    this.overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.DataSource = null;
                }
                else
                {
                    this.overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.Rows.Clear();
                }

                int intRecord = dsKey.Tables[0].Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dsKey.Tables[0].Rows)
                    {
                        overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.Rows.Add(row["EquipmentNo"].ToString()
                                , row["Model"].ToString()
                                , row["PlateNo"].ToString()
                                , (row["Km"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Km"])))
                                , (row["Hrs"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Hrs"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                                , (row["Liters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Liters"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                                , (row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"])))// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalFuelCost"]))// row["TotalFuelCost"].ToString()
                                , (row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["PMS"]))// row["PMS"].ToString()
                                , (row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                                , (row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                                 , (row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]))));// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalExpenses"])));//row["TotalExpenses"].ToString());
                                //, ((row["TotalFuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalFuelCost"]))))
                                //   + (row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))
                                //  + (row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]))) + (row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))
                                //);
                    }
                }
                foreach (DataRow row in dsKey.Tables[1].Rows)
                {
                    overallReportControl.truckOverallExpensesControl.lblkm.Text = row["Km"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Km"]));
                    overallReportControl.truckOverallExpensesControl.lblhrs.Text = row["Hrs"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Hrs"]));
                    overallReportControl.truckOverallExpensesControl.lblliters.Text = row["Liters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Liters"]));
                    overallReportControl.truckOverallExpensesControl.lblfuelcost.Text = row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"]));
                    overallReportControl.truckOverallExpensesControl.lblpms.Text = row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]));
                    overallReportControl.truckOverallExpensesControl.lblrepair.Text = row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]));
                    overallReportControl.truckOverallExpensesControl.lbltire.Text = row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]));
                    overallReportControl.truckOverallExpensesControl.lblexpenses.Text = row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]));

                    //overallReportControl.truckOverallExpensesControl.lblexpenses.Text = (row["TotalFuelCost"].ToString() == "" ? 0 : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalFuelCost"]))
                    //      + row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])) + row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]))
                    //      + row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]))
                        //);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        ////////////////////
        ////////////////////

        #region ProjectSite
        /////
        /////

        private void cmbProExpensesSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  EquipmentNoCollection.Clear();
            if (monthlyFormControl.projectSiteMonthlyControl.cmbProject.SelectedIndex == 0)
            {
                PMonthlySearchType = "ProjectNo";
                monthlyFormControl.projectSiteMonthlyControl.txtSearch.AutoCompleteCustomSource = ProjectNoCollection;
            }
            else if (monthlyFormControl.projectSiteMonthlyControl.cmbProject.SelectedIndex == 1)
            {
                PMonthlySearchType = "ProjectSite";
                monthlyFormControl.projectSiteMonthlyControl.txtSearch.AutoCompleteCustomSource = ProjectSiteCollection;
            }
            else
            {
                PMonthlySearchType = "ProjectDate";
                monthlyFormControl.projectSiteMonthlyControl.txtSearch.AutoCompleteCustomSource = ProjectDateCollection;
            }
        }

        private void btnProjectMonthlySearch_Click(object sender, EventArgs e)
        {

            monthlyFormControl.projectSiteMonthlyControl.lblMonthFilter.Text = "Report Month : " + monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + " " + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text;
            ProjectMonthlist();
        }

        private void ProjectMonthlist()
        {

            try
            {
                //string SearchType = "'" + PMonthlySearchType + "'";
                //string Search = "'" + monthlyFormControl.projectSiteMonthlyControl.txtSearch.Text + "'";
                //string Month = "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + "'";
                //string Year = "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text + "'";
                //string spName = "sp_r_GetProjectSiteMonthly";

                DataTable test = new DataTable();

                DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_GetProjectSiteMonthly '" + PMonthlySearchType + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.txtSearch.Text + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text + "'"));
                DataTableReader drKey = dsKey.Tables[1].CreateDataReader();
                //   Detail.Load(reader);
                //test.Load(drKey);

                monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.DataSource = null;

                if (this.monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.DataSource != null)
                {
                    this.monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.DataSource = null;
                }
                else
                {
                    this.monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows.Clear();
                }

                int intRecord = dsKey.Tables[0].Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dsKey.Tables[0].Rows)
                    {
                        monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows.Add(row["id"].ToString()
                                , row["ProjectNo"].ToString()
                                , row["ProjectSite"].ToString()
                                , row["ProjectDate"].ToString().Replace(" 12:00:00 AM", "")
                                , (row["TotalLiters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalLiters"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                                , (row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"])))// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalFuelCost"]))// row["TotalFuelCost"].ToString()
                                , (row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["PMS"]))// row["PMS"].ToString()
                                , (row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                                , (row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                                , (row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]))));// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalExpenses"])));//row["TotalExpenses"].ToString());

                    }
                }
                else
                {
                    monthlyFormControl.projectSiteMonthlyControl.lblMessage.Visible = true;
                }

                foreach (DataRow row in dsKey.Tables[1].Rows)
                {
                    monthlyFormControl.projectSiteMonthlyControl.lblliters.Text = row["TotalLiters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalLiters"]));
                    monthlyFormControl.projectSiteMonthlyControl.lblfuelcost.Text = row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"]));
                    monthlyFormControl.projectSiteMonthlyControl.lblpms.Text = row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]));
                    monthlyFormControl.projectSiteMonthlyControl.lblrepair.Text = row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]));
                    monthlyFormControl.projectSiteMonthlyControl.lbltire.Text = row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]));
                    monthlyFormControl.projectSiteMonthlyControl.lblexpenses.Text = row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //monthlyFormControl.truckMonthlyControl.lblMessage.Visible = false;
            //SqlDataAdapter da = new SqlDataAdapter("select * from vw_MonthlyExpenses with(nolock) where " + TMonthlySearchType + " like '%" + monthlyFormControl.truckMonthlyControl.txtSearch.Text + "%' " +
            //    " and Month = '" + monthlyFormControl.truckMonthlyControl.cmbFromMonth.Text + "' and Year= '" + monthlyFormControl.truckMonthlyControl.cmbFromYear.Text + "'", Connection);

            //SqlDataAdapter daGrandtotal = new SqlDataAdapter("select CONVERT([decimal](18,2),SUM(TotalKm)) as TotalKm,  CONVERT([decimal](18,2),SUM(Totalhrs)) as Totalhrs" +
            //    "   , CONVERT([decimal](18,2),SUM(TotalLiters)) as TotalLiters, CONVERT([decimal](18,2),SUM(TotalFuelCost)) as TotalFuelCost, CONVERT([decimal](18,2),SUM(PMS)) as PMS" +
            //    ", CONVERT([decimal](18,2),SUM(Repair)) as Repair, CONVERT([decimal](18,2),SUM(Tire)) as Tire,  CONVERT([decimal](18,2),SUM(TotalExpenses)) as TotalExpenses" +
            //    " from vw_MonthlyExpenses with(nolock) where " + TMonthlySearchType + " like '%" + monthlyFormControl.truckMonthlyControl.txtSearch.Text + "%' " +
            //    " and Month = '" + monthlyFormControl.truckMonthlyControl.cmbFromMonth.Text + "' and Year= '" + monthlyFormControl.truckMonthlyControl.cmbFromYear.Text + "'", Connection);

            //DataTable dtGrandTotal = new DataTable();
            //daGrandtotal.Fill(dtGrandTotal);

            //foreach (DataRow row in dtGrandTotal.Rows)
            //{
            //    monthlyFormControl.truckMonthlyControl.lblkm.Text = row["TotalKm"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalKm"]));
            //    monthlyFormControl.truckMonthlyControl.lblhrs.Text = row["Totalhrs"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Totalhrs"]));
            //    monthlyFormControl.truckMonthlyControl.lblliters.Text = row["TotalLiters"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalLiters"]));
            //    monthlyFormControl.truckMonthlyControl.lblfuelcost.Text = row["TotalFuelCost"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalFuelCost"]));
            //    monthlyFormControl.truckMonthlyControl.lblpms.Text = row["PMS"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]));
            //    monthlyFormControl.truckMonthlyControl.lblrepair.Text = row["Repair"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]));
            //    monthlyFormControl.truckMonthlyControl.lbltire.Text = row["Tire"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]));
            //    monthlyFormControl.truckMonthlyControl.lblexpenses.Text = row["TotalExpenses"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]));
            //}

            //DataTable dttruckmexpenses = new DataTable();

            //da.Fill(dttruckmexpenses);

            //monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.DataSource = null;

            //if (this.monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.DataSource != null)
            //{
            //    this.monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.DataSource = null;
            //}
            //else
            //{
            //    this.monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.Rows.Clear();
            //}

            //int intRecord = dttruckmexpenses.Rows.Count;
            //if (intRecord > 0)
            //{
            //    foreach (DataRow row in dttruckmexpenses.Rows)
            //    {
            //        monthlyFormControl.truckMonthlyControl.dgvTruckMonthlyList.Rows.Add(row["EquipmentNo"].ToString()
            //             , row["Model"].ToString()
            //             , row["PlateNo"].ToString()
            //             , (row["TotalKm"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalKm"])))//row["TotalKm"].ToString())//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalKm"]))//row["TotalKm"].ToString()
            //             , (row["Totalhrs"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Totalhrs"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Totalhrs"]))//row["Totalhrs"].ToString()
            //             , (row["TotalLiters"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalLiters"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
            //             , (row["Ltrkm"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Ltrkm"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Ltrkm"]))// row["Ltrkm"].ToString()
            //             , (row["TotalFuelCost"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalFuelCost"])))// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalFuelCost"]))// row["TotalFuelCost"].ToString()
            //             , (row["PMS"].ToString() == "" ? "000" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["PMS"]))// row["PMS"].ToString()
            //             , (row["Repair"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
            //             , (row["Tire"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
            //             , (row["TotalExpenses"].ToString() == "" ? ".00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]))));// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalExpenses"])));//row["TotalExpenses"].ToString());
            //        String.Format("{0:#,###.0}", Convert.ToDecimal(row["Availability"]))//row["Availability"].ToString()
            //    }
            //}
            //else
            //{
            //    monthlyFormControl.truckMonthlyControl.lblMessage.Visible = true;
            //}
        }

        ////////////////////
        /////////////////

        #endregion

        #region Overall

        //Sub Menu
        private void btnTruckOverAllExpenses_Click(object sender, EventArgs e)
        {
            lblReportOverAllLast.Text = "Truck";
            overallReportControl.panelTruckandHeavy.Show();
            overallReportControl.panelProjectSiteOverall.Hide();
            overallReportControl.truckOverallExpensesControl.BringToFront();
        }
        //Sub Menu
        private void btnProjectsiteOverAllExpenses_Click(object sender, EventArgs e)
        {
            lblReportOverAllLast.Text = "Projectsite";
            overallReportControl.panelProjectSiteOverall.Show();
            overallReportControl.panelTruckandHeavy.Hide();
            overallReportControl.projectSiteOverAllControl.BringToFront();
        }

        private void fueltankerFuelChange(object sender, EventArgs e)
        {
            TankerTruckList(fuelTankerLogControl.cmbfueltype.SelectedValue.ToString());
            DateTankerTruckRefillParent(fuelTankerLogControl.cmbTanktruck.SelectedValue.ToString());
        }

        private void fueltankerTanktruckChange(object sender, EventArgs e)
        {
            DateTankerTruckRefillParent(fuelTankerLogControl.cmbTanktruck.SelectedValue.ToString());
        }

        private void fuelMainFuelChange(object sender, EventArgs e)
        {
            TankerMainList(fuelMainLogControl.cmbfueltype.SelectedValue.ToString());
            DateMainRefillParent(fuelMainLogControl.cmbTanktruck.SelectedValue.ToString());
        }

        private void fuelMainTanktruckChange(object sender, EventArgs e)
        {
            DateMainRefillParent(fuelMainLogControl.cmbTanktruck.SelectedValue.ToString());
        }


        private void cmbTOExpensesSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  EquipmentNoCollection.Clear();
            if (overallReportControl.truckOverallExpensesControl.cmbUnitList.SelectedIndex == 0)
            {
                TOverAllSearchType = "EquipmentNo";
                overallReportControl.truckOverallExpensesControl.txtSearch.AutoCompleteCustomSource = EquipmentNoCollection;
            }
            else if (overallReportControl.truckOverallExpensesControl.cmbUnitList.SelectedIndex == 1)
            {
                TOverAllSearchType = "Model";
                overallReportControl.truckOverallExpensesControl.txtSearch.AutoCompleteCustomSource = ModelNoCollection;
            }
            else
            {
                TOverAllSearchType = "PlateNo";
                overallReportControl.truckOverallExpensesControl.txtSearch.AutoCompleteCustomSource = PlateNoCollection;
            }
        }

        private void btnTruckOverAllSearch_Click(object sender, EventArgs e)
        {
            TruckOveralllist();
        }


        private void TruckOveralllist()
        {
            try
            {
                //string SearchType = "'" + PMonthlySearchType + "'";
                //string Search = "'" + monthlyFormControl.projectSiteMonthlyControl.txtSearch.Text + "'";
                //string Month = "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + "'";
                //string Year = "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text + "'";
                //string spName = "sp_r_GetProjectSiteMonthly";


                DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_GetTruckOverAll '" + TOverAllSearchType + "'," + "'" + overallReportControl.truckOverallExpensesControl.txtSearch.Text + "'"));
                DataTableReader drKey = dsKey.Tables[1].CreateDataReader();
                //   Detail.Load(reader);

                overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.DataSource = null;

                if (this.overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.DataSource != null)
                {
                    this.overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.DataSource = null;
                }
                else
                {
                    this.overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.Rows.Clear();
                }

                int intRecord = dsKey.Tables[0].Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dsKey.Tables[0].Rows)
                    {
                        overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.Rows.Add(row["EquipmentNo"].ToString()
                                , row["Model"].ToString()
                                , row["PlateNo"].ToString()
                                , (row["Km"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Km"])))
                                , (row["hrs"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["hrs"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                                , (row["Liters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Liters"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                                , (row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"])))// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalFuelCost"]))// row["TotalFuelCost"].ToString()
                                , (row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["PMS"]))// row["PMS"].ToString()
                                , (row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                                , (row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                                , (row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]))));// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalExpenses"])));//row["TotalExpenses"].ToString());
                                                                                                                                         //, (row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]))));// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalExpenses"])));//row["TotalExpenses"].ToString());
                                //, ((row["TotalFuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalFuelCost"]))))
                                //   + (row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))
                                //  + (row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]))) + (row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))
                                //);
                    }
                }
                foreach (DataRow row in dsKey.Tables[1].Rows)
                {
                    overallReportControl.truckOverallExpensesControl.lblkm.Text = row["Km"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Km"]));
                    overallReportControl.truckOverallExpensesControl.lblhrs.Text = row["Hrs"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Hrs"]));
                    overallReportControl.truckOverallExpensesControl.lblliters.Text = row["Liters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Liters"]));
                    overallReportControl.truckOverallExpensesControl.lblfuelcost.Text = row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"]));
                    overallReportControl.truckOverallExpensesControl.lblpms.Text = row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]));
                    overallReportControl.truckOverallExpensesControl.lblrepair.Text = row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]));
                    overallReportControl.truckOverallExpensesControl.lbltire.Text = row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]));
                    overallReportControl.truckOverallExpensesControl.lblexpenses.Text = row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]));

                    //overallReportControl.truckOverallExpensesControl.lblexpenses.Text = (row["TotalFuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalFuelCost"]))
                    //      + row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])) + row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]))
                    //      + row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]))
                        //);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        //Project OverAll
        #region Project OverAll


        private void btnProjectOverAllSearch_Click(object sender, EventArgs e)
        {
            ProjectOveralllist();
        }

        private void cmbProOverAllExpensesSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  EquipmentNoCollection.Clear();
            if (monthlyFormControl.projectSiteMonthlyControl.cmbProject.SelectedIndex == 0)
            {
                POverAllSearchType = "ProjectNo";
                overallReportControl.projectSiteOverAllControl.txtSearch.AutoCompleteCustomSource = ProjectNoCollection;
            }
            else if (monthlyFormControl.projectSiteMonthlyControl.cmbProject.SelectedIndex == 1)
            {
                POverAllSearchType = "ProjectSite";
                overallReportControl.projectSiteOverAllControl.txtSearch.AutoCompleteCustomSource = ProjectSiteCollection;
            }
            else
            {
                POverAllSearchType = "ProjectDate";
                overallReportControl.projectSiteOverAllControl.txtSearch.AutoCompleteCustomSource = ProjectDateCollection;
            }
        }

        private void ProjectOveralllist()
        {
            try
            {
                //string SearchType = "'" + PMonthlySearchType + "'";
                //string Search = "'" + monthlyFormControl.projectSiteMonthlyControl.txtSearch.Text + "'";
                //string Month = "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + "'";
                //string Year = "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text + "'";
                //string spName = "sp_r_GetProjectSiteMonthly";


                DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_GetProjectSiteOverAll '" + POverAllSearchType + "'," + "'" + overallReportControl.projectSiteOverAllControl.txtSearch.Text + "'"));
                DataTableReader drKey = dsKey.Tables[1].CreateDataReader();
                //   Detail.Load(reader);

                overallReportControl.truckOverallExpensesControl.dgvTruckOverAllList.DataSource = null;

                if (this.overallReportControl.projectSiteOverAllControl.dgvProjectMonthlyList.DataSource != null)
                {
                    this.overallReportControl.projectSiteOverAllControl.dgvProjectMonthlyList.DataSource = null;
                }
                else
                {
                    this.overallReportControl.projectSiteOverAllControl.dgvProjectMonthlyList.Rows.Clear();
                }

                int intRecord = dsKey.Tables[0].Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dsKey.Tables[0].Rows)
                    {
                        overallReportControl.projectSiteOverAllControl.dgvProjectMonthlyList.Rows.Add(row["id"].ToString()
                                , row["ProjectNo"].ToString()
                                , row["ProjectSite"].ToString()
                                , row["ProjectDate"].ToString().Replace(" 12:00:00 AM", "")
                                , (row["TotalLiters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalLiters"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalLiters"]))// row["TotalLiters"].ToString()
                                , (row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"])))// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalFuelCost"]))// row["TotalFuelCost"].ToString()
                                , (row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["PMS"]))// row["PMS"].ToString()
                                , (row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Repair"]))//row["Repair"].ToString()
                                , (row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"])))//String.Format("{0:#,###.0}", Convert.ToDecimal(row["Tire"]))//row["Tire"].ToString()
                                , (row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]))));// String.Format("{0:#,###.0}", Convert.ToDecimal(row["TotalExpenses"])));//row["TotalExpenses"].ToString());

                    }
                }
                foreach (DataRow row in dsKey.Tables[1].Rows)
                {
                    overallReportControl.projectSiteOverAllControl.lblliters.Text = row["TotalLiters"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalLiters"]));
                    overallReportControl.projectSiteOverAllControl.lblfuelcost.Text = row["FuelCost"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["FuelCost"]));
                    overallReportControl.projectSiteOverAllControl.lblpms.Text = row["PMS"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"]));
                    overallReportControl.projectSiteOverAllControl.lblrepair.Text = row["Repair"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"]));
                    overallReportControl.projectSiteOverAllControl.lbltire.Text = row["Tire"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]));
                    overallReportControl.projectSiteOverAllControl.lblexpenses.Text = row["TotalExpenses"].ToString() == "" ? "0.00" : String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalExpenses"]));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProjectMonthlyList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            monthlyFormControl.projectSiteEquipmentM.dgvProjectsitedetails.DataSource = null;
            if (this.monthlyFormControl.projectSiteEquipmentM.dgvProjectsitedetails.DataSource != null)
            {
                this.monthlyFormControl.projectSiteEquipmentM.dgvProjectsitedetails.DataSource = null;
            }
            else
            {
                this.monthlyFormControl.projectSiteEquipmentM.dgvProjectsitedetails.Rows.Clear();
            }

            lblReportMonthlyLastsub.Text = "ProjectSiteDetail";
            try
            {
                if (e.RowIndex >= 0)
                {

                    //String TEST = "exec sp_r_ProjectSiteM_Detail '" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[1].Value + "'," + "'" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[2].Value + "'," + "'" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[3].Value + "'";
                    // DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_ProjectSiteM_Detail '" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[1].Value + "'," + "'" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[2].Value + "'," + "'" + unitListControl.dgvUnitListitem.Rows[e.RowIndex].Cells[3].Value + "'"));
                    //DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_ProjectSiteM_Detail '10010','18-HE-0035','Sibonga','','May','2019'"));

                    DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_r_ProjectSiteM_Detail '" + monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[0].Value.ToString() + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[1].Value.ToString() + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[2].Value.ToString() + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[3].Value.ToString() + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text + "'"));
                    DataTableReader drKey = dsKey.Tables[0].CreateDataReader();
                    string test = "exec sp_r_ProjectSiteM_Detail '" + monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[0].Value.ToString() + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[1].Value.ToString() + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[2].Value.ToString() + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[3].Value.ToString() + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + "'," + "'" + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text + "'";

                    mprojectid = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    mprojectno = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[1].Value.ToString();
                    mprojectsite = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[2].Value.ToString();
                    mprojectdate = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[3].Value.ToString();
                    mmonth = monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text;
                    myear = monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text;

                    if (drKey.Read())
                    {
                        foreach (DataRow row in dsKey.Tables[0].Rows)
                        {
                            monthlyFormControl.projectSiteEquipmentM.dgvProjectsitedetails.Rows.Add(//row["RDate"].ToString(),
                                     row["EquipmentNo"].ToString()
                                    , row["Model"].ToString()
                                    , row["PlateNo"].ToString()
                                    , row["Km"].ToString()
                                    , row["Hrs"].ToString()
                                    , row["Liters"].ToString()
                                    //, row["ltrkms"].ToString()
                                    , row["FuelCost"].ToString()
                                    , row["PMS"].ToString()
                                    , row["Repair"].ToString()
                                    , row["Tire"].ToString()
                                    //, row["Fuelcost"].ToString() + row["PMS"].ToString() + row["Repair"].ToString() + row["Tire"].ToString()
                                    //, String.Format("{0:#,###.0000}", row["Fuelcost"].ToString() + row["PMS"].ToString() + row["Repair"].ToString() + row["Tire"].ToString())
                                    //, String.Format("{0:#,###.00}", Convert.ToDecimal(row["Fuelcost"])) + String.Format("{0:#,###.00}", Convert.ToDecimal(row["PMS"])) + String.Format("{0:#,###.00}", Convert.ToDecimal(row["Repair"])) + String.Format("{0:#,###.00}", Convert.ToDecimal(row["Tire"]))
                                    , String.Format("{0:#,###.0000}", Convert.ToDecimal(row["Fuelcost"]) + Convert.ToDecimal(row["PMS"]) + Convert.ToDecimal(row["Repair"]) +  Convert.ToDecimal(row["Tire"]))
                                    );

                            //string val = row["Fuelcost"].ToString() + row["PMS"].ToString() + row["Repair"].ToString() + row["Tire"].ToString();
                        }

                        monthlyFormControl.projectSiteEquipmentM.lblGenerateDate.Text = monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + " " + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text;
                        monthlyFormControl.projectSiteEquipmentM.lblProjectNo.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblProjectSite.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[2].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblProjectDate.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[3].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblPMS.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[6].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblRepair.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[7].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblLiters.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[4].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblFuelcost.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[5].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblTire.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[8].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblTExpenses.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[9].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblProjectID.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[0].Value.ToString();
                        //monthlyFormControl.projectSiteMonthlyControl.Hide();
                        monthlyFormControl.projectSiteEquipmentM.BringToFront();
                        
                    }
                    else
                    {
                        monthlyFormControl.projectSiteEquipmentM.lblGenerateDate.Text = monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text + " " + monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text;
                        monthlyFormControl.projectSiteEquipmentM.lblProjectNo.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblProjectSite.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[2].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblProjectDate.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[3].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblPMS.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[6].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblRepair.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[7].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblLiters.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[4].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblFuelcost.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[5].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblTire.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[8].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblTExpenses.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[9].Value.ToString();
                        monthlyFormControl.projectSiteEquipmentM.lblProjectID.Text = monthlyFormControl.projectSiteMonthlyControl.dgvProjectMonthlyList.Rows[e.RowIndex].Cells[0].Value.ToString();
                        //monthlyFormControl.projectSiteMonthlyControl.Hide();
                        monthlyFormControl.projectSiteEquipmentM.BringToFront();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           }
        #endregion

        #endregion

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changepass = new ChangePassword();
            changepass.Param(userlogin);
            changepass.ShowDialog(this);
        }

        private void CreateaccountToolStrip_Click(object sender, EventArgs e)
        {
            CreateUser create = new CreateUser();
            create.Param(userlogin);
            create.ShowDialog(this);
        }

        private void UpdateAccounttoolStrip_Click(object sender, EventArgs e)
        {
            UpdateUser update = new UpdateUser();
            update.Param(userlogin);
            update.ShowDialog(this);
        }

        private void LogOuttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EquipmentMonitoring.ForReportForm.Forms.ProjectSiteMonthlyReport();
            //Login login = new EquipmentMonitoring.Login();
            //login.Show();
            this.Close();

        }

       
        //private void Testreport_Click(object sender, EventArgs e)
        //{
        //    testreport test = new EquipmentMonitoring.testreport();
        //        test.Show();
        //    //}
        //    //else
        //    //{
        //    //    test.Activate();
        //    //}
        //}


        ////rdlc
        ///
        private void btnFuelMainLogprint(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                RMainTankLogSheet rMaintank = new EquipmentMonitoring.ForReportForm.Forms.RMainTankLogSheet();
                //rMaintank.ShowDialog();
                rMaintank.Param(dtMaintankGrid, dtMaintankLabel);
                rMaintank.Show();
            }
            catch
            {

            }
        }
        private void btnFuelTankerLogprint(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                RTankerTruckLogSheet rtanker = new EquipmentMonitoring.ForReportForm.Forms.RTankerTruckLogSheet();
                //rMaintank.ShowDialog();
                rtanker.Param(dtTankerTruckGrid, dtTankerTruckLabel);
                rtanker.Show();
            }
            catch
            {

            }
        }

        private void btnProjectSiteMonthlyprint(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                ProjectSiteMonthlyReport Projectsite = new EquipmentMonitoring.ForReportForm.Forms.ProjectSiteMonthlyReport();
                //rMaintank.ShowDialog();
                Projectsite.Param(PMonthlySearchType, monthlyFormControl.projectSiteMonthlyControl.txtSearch.Text, monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text, monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text);
                Projectsite.Show();
            }
            catch
            {

            }
        }

        private void btnTruckMonthlyprint(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                TruckMonthlyReport TruckReport = new EquipmentMonitoring.ForReportForm.Forms.TruckMonthlyReport();
                //rMaintank.ShowDialog();
                //TruckReport.Param(PMonthlySearchType, monthlyFormControl.projectSiteMonthlyControl.txtSearch.Text, monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text, monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text);
                TruckReport.Param(dtTruckMonthlyLabel, dtTruckMonthlyGrid, monthlyFormControl.truckMonthlyControl.cmbFromMonth.Text, monthlyFormControl.truckMonthlyControl.cmbFromYear.Text);

                TruckReport.Show();
            }
            catch
            {

            }
        }

        private void btnTruckOverallprint(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                TruckOverallReport Projectsite = new EquipmentMonitoring.ForReportForm.Forms.TruckOverallReport();
                //rMaintank.ShowDialog();
                Projectsite.Param(TOverAllSearchType, overallReportControl.truckOverallExpensesControl.txtSearch.Text);
                Projectsite.Show();
            }
            catch
            {

            }
        }

        private void btnProjectSiteOverallreport(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                ProjectSiteOverAllReport Projectsite = new EquipmentMonitoring.ForReportForm.Forms.ProjectSiteOverAllReport();
                //rMaintank.ShowDialog();
                Projectsite.Param(TOverAllSearchType, overallReportControl.projectSiteOverAllControl.txtSearch.Text);
                //POverAllSearchType + "'," + "'" + overallReportControl.projectSiteOverAllControl.txtSearch.Text + "'")
                Projectsite.Show();
            }
            catch
            {

            }
        }

        private void btnProjectSiteDetail(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                ProjectSiteDetail Projectsite = new EquipmentMonitoring.ForReportForm.Forms.ProjectSiteDetail();
                //rMaintank.ShowDialog();
                //Projectsite.Param(TOverAllSearchType, overallReportControl.projectSiteOverAllControl.txtSearch.Text);
                Projectsite.Param(mprojectid, mprojectno, mprojectsite, mprojectdate, monthlyFormControl.projectSiteMonthlyControl.cmbFromMonth.Text, monthlyFormControl.projectSiteMonthlyControl.cmbFromYear.Text);
                //POverAllSearchType + "'," + "'" + overallReportControl.projectSiteOverAllControl.txtSearch.Text + "'")
                Projectsite.Show();
            }
            catch
            {

            }
        }

        private void btnUnitExpensesPrint(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                UnitExpensesReport expenses = new EquipmentMonitoring.ForReportForm.Forms.UnitExpensesReport();
                //rMaintank.ShowDialog();
                //Projectsite.Param(TOverAllSearchType, overallReportControl.projectSiteOverAllControl.txtSearch.Text);
                expenses.Param(dtUnitExpenses, unitListDetail.lblEqpNo.Text, unitListDetail.lblEqpName.Text, unitListDetail.lblNoName.Text, unitListDetail.expensesViewControl.dtpEFromDate.Text, unitListDetail.expensesViewControl.dtpEToDate.Text);
                //POverAllSearchType + "'," + "'" + overallReportControl.projectSiteOverAllControl.txtSearch.Text + "'")
                expenses.Show();
            }
            catch
            {

            }
        }
        private void btnUnitFuelPrint(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");
                UnitFuelReport fuel = new EquipmentMonitoring.ForReportForm.Forms.UnitFuelReport();
                //rMaintank.ShowDialog();
                //Projectsite.Param(TOverAllSearchType, overallReportControl.projectSiteOverAllControl.txtSearch.Text);
                fuel.Param(unitListDetail.lblEqpNo.Text, unitListDetail.lblEqpName.Text, unitListDetail.lblNoName.Text, unitListDetail.expensesViewControl.dtpEFromDate.Text, unitListDetail.expensesViewControl.dtpEToDate.Text);
                //POverAllSearchType + "'," + "'" + overallReportControl.projectSiteOverAllControl.txtSearch.Text + "'")
                fuel.Show();
            }
            catch
            {

            }
        }

        private void btnAllExpensesPrint(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please wait...");

                AllMaintenanceExpensesReport maintenance = new EquipmentMonitoring.ForReportForm.Forms.AllMaintenanceExpensesReport();
                //rMaintank.ShowDialog();
                //Projectsite.Param(TOverAllSearchType, overallReportControl.projectSiteOverAllControl.txtSearch.Text);
                maintenance.Param(dtdata, allMaintenanceExpenses.cmbCategory.Text, allMaintenanceExpenses.cmbMaintenanceType.Text, allMaintenanceExpenses.txtProjectId.Text, allMaintenanceExpenses.dtfrom.Text, allMaintenanceExpenses.dtTo.Text, isCheck);
                //POverAllSearchType + "'," + "'" + overallReportControl.projectSiteOverAllControl.txtSearch.Text + "'")
                maintenance.Show();
            }
            catch
            {

            }
        }
    }
 }
