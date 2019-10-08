namespace EquipmentMonitoring
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.lblReportMonthlyLastsub = new System.Windows.Forms.Label();
            this.lblReportOverAllLast = new System.Windows.Forms.Label();
            this.lblReportMonthlyLast = new System.Windows.Forms.Label();
            this.lblReportDailyLast = new System.Windows.Forms.Label();
            this.lblReportMainLast = new System.Windows.Forms.Label();
            this.lblsubunit = new System.Windows.Forms.Label();
            this.lblUnitMenu = new System.Windows.Forms.Label();
            this.lblFuelLast = new System.Windows.Forms.Label();
            this.lbMonitoringLast = new System.Windows.Forms.Label();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFuel = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOuttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateaccountToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateAccounttoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportsControl = new EquipmentMonitoring.AllForm.ReportsControl();
            this.unitMenuControl = new EquipmentMonitoring.AllForm.Unitfrom.UnitMenuControl();
            this.dashBoardMenuControl = new EquipmentMonitoring.AllForm.DashBoardMenuControl();
            this.allSetupControl = new EquipmentMonitoring.AllForm.AllSetupControl();
            this.fuelMenuControl = new EquipmentMonitoring.AllForm.FuelMenuControl();
            this.monthlyFormControl = new EquipmentMonitoring.AllForm.Reports.MonthlyFormControl();
            this.fuelMainLogControl = new EquipmentMonitoring.AllForm.FuelForm.FuelMainLogControl();
            this.fuelTankerLogControl = new EquipmentMonitoring.AllForm.FuelForm.FuelTankerLogControl();
            this.overallReportControl = new EquipmentMonitoring.AllForm.Reports.OverallReportControl();
            this.mainHistoryControl = new EquipmentMonitoring.AllForm.MaintenanceForm.MainHistoryControl();
            this.maintenanceListControl = new EquipmentMonitoring.AllForm.MaintenanceForm.MaintenanceListControl();
            this.unitListControl = new EquipmentMonitoring.AllForm.UnitListControl();
            this.allMaintenanceExpenses = new EquipmentMonitoring.AllForm.AllMaintenanceExpenses();
            this.dashBoardControl = new EquipmentMonitoring.AllForm.dashBoardControl();
            this.addDailyControl = new EquipmentMonitoring.AllForm.FuelForm.AddDailyControl();
            this.projectSiteControl = new EquipmentMonitoring.AllForm.AllSetupform.ProjectSite.ProjectSiteControl();
            this.mainRefillControl = new EquipmentMonitoring.AllForm.FuelForm.MainRefillControl();
            this.categoryControl = new EquipmentMonitoring.AllForm.AllSetupform.Category();
            this.tankTypeControl = new EquipmentMonitoring.AllForm.AllSetupform.TankType.TankTypeControl();
            this.fuelTypeControl = new EquipmentMonitoring.AllForm.AllSetupform.FuelType.FuelTypeControl();
            this.truckTypeControl = new EquipmentMonitoring.AllForm.AllSetupform.Trucktype.TruckTypeControl();
            this.employeeControl = new EquipmentMonitoring.AllForm.AllSetupform.Employee.EmployeeControl();
            this.positionControl = new EquipmentMonitoring.AllForm.AllSetupform.Position.PositionControl();
            this.unitListDetail = new EquipmentMonitoring.AllForm.addunits.UnitListDetail();
            this.maintenanceAndRepair = new EquipmentMonitoring.AllForm.expenses.MaintenanceAndRepair();
            this.MenuPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.DisplayPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuPanel.Controls.Add(this.lblReportMonthlyLastsub);
            this.MenuPanel.Controls.Add(this.lblReportOverAllLast);
            this.MenuPanel.Controls.Add(this.lblReportMonthlyLast);
            this.MenuPanel.Controls.Add(this.lblReportDailyLast);
            this.MenuPanel.Controls.Add(this.lblReportMainLast);
            this.MenuPanel.Controls.Add(this.lblsubunit);
            this.MenuPanel.Controls.Add(this.lblUnitMenu);
            this.MenuPanel.Controls.Add(this.lblFuelLast);
            this.MenuPanel.Controls.Add(this.lbMonitoringLast);
            this.MenuPanel.Controls.Add(this.btnUnits);
            this.MenuPanel.Controls.Add(this.btnReport);
            this.MenuPanel.Controls.Add(this.btnFuel);
            this.MenuPanel.Controls.Add(this.SidePanel);
            this.MenuPanel.Controls.Add(this.btnMonitoring);
            this.MenuPanel.Controls.Add(this.btnHome);
            this.MenuPanel.Location = new System.Drawing.Point(1, 141);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(155, 530);
            this.MenuPanel.TabIndex = 3;
            // 
            // lblReportMonthlyLastsub
            // 
            this.lblReportMonthlyLastsub.AutoSize = true;
            this.lblReportMonthlyLastsub.Location = new System.Drawing.Point(15, 463);
            this.lblReportMonthlyLastsub.Name = "lblReportMonthlyLastsub";
            this.lblReportMonthlyLastsub.Size = new System.Drawing.Size(80, 13);
            this.lblReportMonthlyLastsub.TabIndex = 18;
            this.lblReportMonthlyLastsub.Text = "reportmonthsub";
            this.lblReportMonthlyLastsub.Visible = false;
            // 
            // lblReportOverAllLast
            // 
            this.lblReportOverAllLast.AutoSize = true;
            this.lblReportOverAllLast.Location = new System.Drawing.Point(14, 438);
            this.lblReportOverAllLast.Name = "lblReportOverAllLast";
            this.lblReportOverAllLast.Size = new System.Drawing.Size(93, 13);
            this.lblReportOverAllLast.TabIndex = 16;
            this.lblReportOverAllLast.Text = "ReportOverAllLast";
            this.lblReportOverAllLast.Visible = false;
            // 
            // lblReportMonthlyLast
            // 
            this.lblReportMonthlyLast.AutoSize = true;
            this.lblReportMonthlyLast.Location = new System.Drawing.Point(14, 420);
            this.lblReportMonthlyLast.Name = "lblReportMonthlyLast";
            this.lblReportMonthlyLast.Size = new System.Drawing.Size(96, 13);
            this.lblReportMonthlyLast.TabIndex = 15;
            this.lblReportMonthlyLast.Text = "ReportMonthlyLast";
            this.lblReportMonthlyLast.Visible = false;
            // 
            // lblReportDailyLast
            // 
            this.lblReportDailyLast.AutoSize = true;
            this.lblReportDailyLast.Location = new System.Drawing.Point(14, 400);
            this.lblReportDailyLast.Name = "lblReportDailyLast";
            this.lblReportDailyLast.Size = new System.Drawing.Size(82, 13);
            this.lblReportDailyLast.TabIndex = 14;
            this.lblReportDailyLast.Text = "ReportDailyLast";
            this.lblReportDailyLast.Visible = false;
            // 
            // lblReportMainLast
            // 
            this.lblReportMainLast.AutoSize = true;
            this.lblReportMainLast.Location = new System.Drawing.Point(14, 352);
            this.lblReportMainLast.Name = "lblReportMainLast";
            this.lblReportMainLast.Size = new System.Drawing.Size(82, 13);
            this.lblReportMainLast.TabIndex = 13;
            this.lblReportMainLast.Text = "ReportMainLast";
            this.lblReportMainLast.Visible = false;
            // 
            // lblsubunit
            // 
            this.lblsubunit.AutoSize = true;
            this.lblsubunit.Location = new System.Drawing.Point(16, 309);
            this.lblsubunit.Name = "lblsubunit";
            this.lblsubunit.Size = new System.Drawing.Size(41, 13);
            this.lblsubunit.TabIndex = 12;
            this.lblsubunit.Text = "subunit";
            this.lblsubunit.Visible = false;
            // 
            // lblUnitMenu
            // 
            this.lblUnitMenu.AutoSize = true;
            this.lblUnitMenu.Location = new System.Drawing.Point(14, 290);
            this.lblUnitMenu.Name = "lblUnitMenu";
            this.lblUnitMenu.Size = new System.Drawing.Size(53, 13);
            this.lblUnitMenu.TabIndex = 11;
            this.lblUnitMenu.Text = "UnitMenu";
            this.lblUnitMenu.Visible = false;
            // 
            // lblFuelLast
            // 
            this.lblFuelLast.AutoSize = true;
            this.lblFuelLast.Location = new System.Drawing.Point(15, 267);
            this.lblFuelLast.Name = "lblFuelLast";
            this.lblFuelLast.Size = new System.Drawing.Size(47, 13);
            this.lblFuelLast.TabIndex = 10;
            this.lblFuelLast.Text = "FuelLast";
            this.lblFuelLast.Visible = false;
            // 
            // lbMonitoringLast
            // 
            this.lbMonitoringLast.AutoSize = true;
            this.lbMonitoringLast.Location = new System.Drawing.Point(15, 245);
            this.lbMonitoringLast.Name = "lbMonitoringLast";
            this.lbMonitoringLast.Size = new System.Drawing.Size(76, 13);
            this.lbMonitoringLast.TabIndex = 9;
            this.lbMonitoringLast.Text = "MonitoringLast";
            this.lbMonitoringLast.Visible = false;
            // 
            // btnUnits
            // 
            this.btnUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnits.FlatAppearance.BorderSize = 0;
            this.btnUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnits.ForeColor = System.Drawing.Color.Black;
            this.btnUnits.Image = global::EquipmentMonitoring.Properties.Resources.lorry_side;
            this.btnUnits.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUnits.Location = new System.Drawing.Point(13, 129);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(135, 36);
            this.btnUnits.TabIndex = 8;
            this.btnUnits.Text = "   UNIT LISTS";
            this.btnUnits.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnits.UseVisualStyleBackColor = true;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = global::EquipmentMonitoring.Properties.Resources.document;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(13, 171);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(135, 36);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "   REPORTS";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnFuel
            // 
            this.btnFuel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuel.FlatAppearance.BorderSize = 0;
            this.btnFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuel.ForeColor = System.Drawing.Color.Black;
            this.btnFuel.Image = global::EquipmentMonitoring.Properties.Resources.monitor;
            this.btnFuel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFuel.Location = new System.Drawing.Point(13, 87);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(135, 36);
            this.btnFuel.TabIndex = 6;
            this.btnFuel.Text = "   FUEL";
            this.btnFuel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuel.UseVisualStyleBackColor = true;
            this.btnFuel.Click += new System.EventHandler(this.btnFuel_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LimeGreen;
            this.SidePanel.Location = new System.Drawing.Point(5, 6);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(9, 37);
            this.SidePanel.TabIndex = 5;
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonitoring.FlatAppearance.BorderSize = 0;
            this.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoring.Image = global::EquipmentMonitoring.Properties.Resources.Process_Controller;
            this.btnMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitoring.Location = new System.Drawing.Point(12, 45);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(135, 36);
            this.btnMonitoring.TabIndex = 1;
            this.btnMonitoring.Text = "   SETTINGS";
            this.btnMonitoring.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonitoring.UseVisualStyleBackColor = true;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::EquipmentMonitoring.Properties.Resources.Home__1_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(135, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "   HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-4, 672);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(76, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOuttoolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.CreateaccountToolStrip,
            this.UpdateAccounttoolStrip});
            this.fileToolStripMenuItem.MergeIndex = 1;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fileToolStripMenuItem.Text = "Account";
            // 
            // LogOuttoolStripMenuItem
            // 
            this.LogOuttoolStripMenuItem.Name = "LogOuttoolStripMenuItem";
            this.LogOuttoolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.LogOuttoolStripMenuItem.Text = "LOG-OUT";
            this.LogOuttoolStripMenuItem.Click += new System.EventHandler(this.LogOuttoolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // CreateaccountToolStrip
            // 
            this.CreateaccountToolStrip.Name = "CreateaccountToolStrip";
            this.CreateaccountToolStrip.Size = new System.Drawing.Size(168, 22);
            this.CreateaccountToolStrip.Text = "Create Account";
            this.CreateaccountToolStrip.Click += new System.EventHandler(this.CreateaccountToolStrip_Click);
            // 
            // UpdateAccounttoolStrip
            // 
            this.UpdateAccounttoolStrip.Name = "UpdateAccounttoolStrip";
            this.UpdateAccounttoolStrip.Size = new System.Drawing.Size(168, 22);
            this.UpdateAccounttoolStrip.Text = "Update Account";
            this.UpdateAccounttoolStrip.Click += new System.EventHandler(this.UpdateAccounttoolStrip_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.AutoSize = true;
            this.logoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.logoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoPanel.Controls.Add(this.logo);
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(156, 141);
            this.logoPanel.TabIndex = 4;
            // 
            // logo
            // 
            this.logo.Image = global::EquipmentMonitoring.Properties.Resources.Q_CON_LOGO;
            this.logo.Location = new System.Drawing.Point(-1, 1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 133);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.DisplayPanel.Controls.Add(this.maintenanceAndRepair);
            this.DisplayPanel.Controls.Add(this.addDailyControl);
            this.DisplayPanel.Controls.Add(this.projectSiteControl);
            this.DisplayPanel.Controls.Add(this.mainRefillControl);
            this.DisplayPanel.Controls.Add(this.categoryControl);
            this.DisplayPanel.Controls.Add(this.tankTypeControl);
            this.DisplayPanel.Controls.Add(this.fuelTypeControl);
            this.DisplayPanel.Controls.Add(this.truckTypeControl);
            this.DisplayPanel.Controls.Add(this.employeeControl);
            this.DisplayPanel.Controls.Add(this.positionControl);
            this.DisplayPanel.Controls.Add(this.unitListDetail);
            this.DisplayPanel.Controls.Add(this.monthlyFormControl);
            this.DisplayPanel.Controls.Add(this.fuelMainLogControl);
            this.DisplayPanel.Controls.Add(this.fuelTankerLogControl);
            this.DisplayPanel.Controls.Add(this.overallReportControl);
            this.DisplayPanel.Controls.Add(this.mainHistoryControl);
            this.DisplayPanel.Controls.Add(this.maintenanceListControl);
            this.DisplayPanel.Controls.Add(this.unitListControl);
            this.DisplayPanel.Controls.Add(this.allMaintenanceExpenses);
            this.DisplayPanel.Controls.Add(this.dashBoardControl);
            this.DisplayPanel.Location = new System.Drawing.Point(157, 24);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(1167, 647);
            this.DisplayPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.reportsControl);
            this.panel1.Controls.Add(this.unitMenuControl);
            this.panel1.Controls.Add(this.dashBoardMenuControl);
            this.panel1.Controls.Add(this.allSetupControl);
            this.panel1.Controls.Add(this.fuelMenuControl);
            this.panel1.Location = new System.Drawing.Point(157, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 28);
            this.panel1.TabIndex = 5;
            // 
            // reportsControl
            // 
            this.reportsControl.BackColor = System.Drawing.Color.LightGray;
            this.reportsControl.Location = new System.Drawing.Point(0, 0);
            this.reportsControl.Name = "reportsControl";
            this.reportsControl.Size = new System.Drawing.Size(1167, 25);
            this.reportsControl.TabIndex = 4;
            // 
            // unitMenuControl
            // 
            this.unitMenuControl.BackColor = System.Drawing.Color.LightGray;
            this.unitMenuControl.Location = new System.Drawing.Point(0, 0);
            this.unitMenuControl.Name = "unitMenuControl";
            this.unitMenuControl.Size = new System.Drawing.Size(1167, 25);
            this.unitMenuControl.TabIndex = 3;
            // 
            // dashBoardMenuControl
            // 
            this.dashBoardMenuControl.Location = new System.Drawing.Point(0, 0);
            this.dashBoardMenuControl.Name = "dashBoardMenuControl";
            this.dashBoardMenuControl.Size = new System.Drawing.Size(1167, 25);
            this.dashBoardMenuControl.TabIndex = 2;
            // 
            // allSetupControl
            // 
            this.allSetupControl.BackColor = System.Drawing.Color.LightGray;
            this.allSetupControl.Location = new System.Drawing.Point(0, 0);
            this.allSetupControl.Name = "allSetupControl";
            this.allSetupControl.Size = new System.Drawing.Size(1167, 25);
            this.allSetupControl.TabIndex = 0;
            // 
            // fuelMenuControl
            // 
            this.fuelMenuControl.BackColor = System.Drawing.Color.LightGray;
            this.fuelMenuControl.Location = new System.Drawing.Point(0, 0);
            this.fuelMenuControl.Name = "fuelMenuControl";
            this.fuelMenuControl.Size = new System.Drawing.Size(1167, 25);
            this.fuelMenuControl.TabIndex = 1;
            // 
            // monthlyFormControl
            // 
            this.monthlyFormControl.Location = new System.Drawing.Point(0, 0);
            this.monthlyFormControl.Name = "monthlyFormControl";
            this.monthlyFormControl.Size = new System.Drawing.Size(1167, 644);
            this.monthlyFormControl.TabIndex = 22;
            // 
            // fuelMainLogControl
            // 
            this.fuelMainLogControl.Location = new System.Drawing.Point(0, 3);
            this.fuelMainLogControl.Name = "fuelMainLogControl";
            this.fuelMainLogControl.Size = new System.Drawing.Size(1167, 644);
            this.fuelMainLogControl.TabIndex = 24;
            // 
            // fuelTankerLogControl
            // 
            this.fuelTankerLogControl.Location = new System.Drawing.Point(0, 3);
            this.fuelTankerLogControl.Name = "fuelTankerLogControl";
            this.fuelTankerLogControl.Size = new System.Drawing.Size(1167, 644);
            this.fuelTankerLogControl.TabIndex = 0;
            // 
            // overallReportControl
            // 
            this.overallReportControl.Location = new System.Drawing.Point(0, 0);
            this.overallReportControl.Name = "overallReportControl";
            this.overallReportControl.Size = new System.Drawing.Size(1167, 660);
            this.overallReportControl.TabIndex = 23;
            // 
            // mainHistoryControl
            // 
            this.mainHistoryControl.Location = new System.Drawing.Point(0, 0);
            this.mainHistoryControl.Name = "mainHistoryControl";
            this.mainHistoryControl.Size = new System.Drawing.Size(1167, 644);
            this.mainHistoryControl.TabIndex = 21;
            // 
            // maintenanceListControl
            // 
            this.maintenanceListControl.Location = new System.Drawing.Point(0, 0);
            this.maintenanceListControl.Name = "maintenanceListControl";
            this.maintenanceListControl.Size = new System.Drawing.Size(1167, 644);
            this.maintenanceListControl.TabIndex = 20;
            // 
            // unitListControl
            // 
            this.unitListControl.Location = new System.Drawing.Point(0, 0);
            this.unitListControl.Name = "unitListControl";
            this.unitListControl.Size = new System.Drawing.Size(1167, 644);
            this.unitListControl.TabIndex = 18;
            // 
            // allMaintenanceExpenses
            // 
            this.allMaintenanceExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.allMaintenanceExpenses.Location = new System.Drawing.Point(0, 0);
            this.allMaintenanceExpenses.Name = "allMaintenanceExpenses";
            this.allMaintenanceExpenses.Size = new System.Drawing.Size(1163, 640);
            this.allMaintenanceExpenses.TabIndex = 17;
            // 
            // dashBoardControl
            // 
            this.dashBoardControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dashBoardControl.Location = new System.Drawing.Point(0, 0);
            this.dashBoardControl.Name = "dashBoardControl";
            this.dashBoardControl.Size = new System.Drawing.Size(1167, 644);
            this.dashBoardControl.TabIndex = 16;
            // 
            // addDailyControl
            // 
            this.addDailyControl.Location = new System.Drawing.Point(0, 0);
            this.addDailyControl.Name = "addDailyControl";
            this.addDailyControl.Size = new System.Drawing.Size(1167, 644);
            this.addDailyControl.TabIndex = 13;
            // 
            // projectSiteControl
            // 
            this.projectSiteControl.Location = new System.Drawing.Point(0, 0);
            this.projectSiteControl.Name = "projectSiteControl";
            this.projectSiteControl.Size = new System.Drawing.Size(1167, 644);
            this.projectSiteControl.TabIndex = 12;
            // 
            // mainRefillControl
            // 
            this.mainRefillControl.Location = new System.Drawing.Point(0, 0);
            this.mainRefillControl.Name = "mainRefillControl";
            this.mainRefillControl.Size = new System.Drawing.Size(1167, 644);
            this.mainRefillControl.TabIndex = 11;
            // 
            // categoryControl
            // 
            this.categoryControl.Location = new System.Drawing.Point(0, 0);
            this.categoryControl.Name = "categoryControl";
            this.categoryControl.Size = new System.Drawing.Size(1167, 644);
            this.categoryControl.TabIndex = 10;
            // 
            // tankTypeControl
            // 
            this.tankTypeControl.Location = new System.Drawing.Point(0, 1);
            this.tankTypeControl.Name = "tankTypeControl";
            this.tankTypeControl.Size = new System.Drawing.Size(1167, 644);
            this.tankTypeControl.TabIndex = 9;
            // 
            // fuelTypeControl
            // 
            this.fuelTypeControl.Location = new System.Drawing.Point(0, 0);
            this.fuelTypeControl.Name = "fuelTypeControl";
            this.fuelTypeControl.Size = new System.Drawing.Size(1167, 644);
            this.fuelTypeControl.TabIndex = 8;
            // 
            // truckTypeControl
            // 
            this.truckTypeControl.Location = new System.Drawing.Point(0, 0);
            this.truckTypeControl.Name = "truckTypeControl";
            this.truckTypeControl.Size = new System.Drawing.Size(1167, 644);
            this.truckTypeControl.TabIndex = 7;
            // 
            // employeeControl
            // 
            this.employeeControl.Location = new System.Drawing.Point(0, 0);
            this.employeeControl.Name = "employeeControl";
            this.employeeControl.Size = new System.Drawing.Size(1167, 644);
            this.employeeControl.TabIndex = 6;
            // 
            // positionControl
            // 
            this.positionControl.Location = new System.Drawing.Point(0, 0);
            this.positionControl.Name = "positionControl";
            this.positionControl.Size = new System.Drawing.Size(1167, 644);
            this.positionControl.TabIndex = 0;
            // 
            // unitListDetail
            // 
            this.unitListDetail.Location = new System.Drawing.Point(0, 3);
            this.unitListDetail.Name = "unitListDetail";
            this.unitListDetail.Size = new System.Drawing.Size(1167, 644);
            this.unitListDetail.TabIndex = 19;
            // 
            // maintenanceAndRepair
            // 
            this.maintenanceAndRepair.Location = new System.Drawing.Point(0, 0);
            this.maintenanceAndRepair.Name = "maintenanceAndRepair";
            this.maintenanceAndRepair.Size = new System.Drawing.Size(1163, 640);
            this.maintenanceAndRepair.TabIndex = 25;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 696);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.logoPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.DisplayPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMonitoring;
        public System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnFuel;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Button btnUnits;
        private System.Windows.Forms.Panel panel1;
        private AllForm.AllSetupControl allSetupControl;
        private AllForm.AllSetupform.Position.PositionControl positionControl;
        private AllForm.AllSetupform.Employee.EmployeeControl employeeControl;
        private AllForm.AllSetupform.Trucktype.TruckTypeControl truckTypeControl;
        private AllForm.AllSetupform.FuelType.FuelTypeControl fuelTypeControl;
        private AllForm.AllSetupform.TankType.TankTypeControl tankTypeControl;
        private AllForm.AllSetupform.Category categoryControl;
        private System.Windows.Forms.Label lblFuelLast;
        private System.Windows.Forms.Label lbMonitoringLast;
        private AllForm.FuelMenuControl fuelMenuControl;
        private AllForm.FuelForm.MainRefillControl mainRefillControl;
        private AllForm.AllSetupform.ProjectSite.ProjectSiteControl projectSiteControl;
        private AllForm.FuelForm.AddDailyControl addDailyControl;
        private AllForm.dashBoardControl dashBoardControl;
        private AllForm.DashBoardMenuControl dashBoardMenuControl;
        private AllForm.Unitfrom.UnitMenuControl unitMenuControl;
        private AllForm.AllMaintenanceExpenses allMaintenanceExpenses;
        private AllForm.UnitListControl unitListControl;
        private System.Windows.Forms.Label lblUnitMenu;
        private AllForm.addunits.UnitListDetail unitListDetail;
        private System.Windows.Forms.Label lblsubunit;
        private AllForm.MaintenanceForm.MaintenanceListControl maintenanceListControl;
        private AllForm.MaintenanceForm.MainHistoryControl mainHistoryControl;
        private AllForm.ReportsControl reportsControl;
        private System.Windows.Forms.Label lblReportMainLast;
        private System.Windows.Forms.Label lblReportMonthlyLast;
        private System.Windows.Forms.Label lblReportDailyLast;
        private System.Windows.Forms.Label lblReportOverAllLast;
        private AllForm.Reports.MonthlyFormControl monthlyFormControl;
        private AllForm.Reports.OverallReportControl overallReportControl;
        private AllForm.FuelForm.FuelTankerLogControl fuelTankerLogControl;
        private AllForm.FuelForm.FuelMainLogControl fuelMainLogControl;
        private System.Windows.Forms.Label lblReportMonthlyLastsub;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOuttoolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem CreateaccountToolStrip;
        public System.Windows.Forms.ToolStripMenuItem UpdateAccounttoolStrip;
        private AllForm.expenses.MaintenanceAndRepair maintenanceAndRepair;
    }
}

