namespace EquipmentMonitoring
{
    partial class AddMonitoring
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvDataMonitoring = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drivers_OptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmhrs_LastRefuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmhrs_duringRefuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kmhrs_Used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoLtrsRefill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ltr_kms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreventiveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalUsed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblYearModel = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblCRNo = new System.Windows.Forms.Label();
            this.lblMVFile = new System.Windows.Forms.Label();
            this.lblGrossWT = new System.Windows.Forms.Label();
            this.lblBodyType = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblCylinder = new System.Windows.Forms.Label();
            this.lblPiston = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblExistingReading = new System.Windows.Forms.Label();
            this.lblDatePurchase = new System.Windows.Forms.Label();
            this.lblStatusPurchase = new System.Windows.Forms.Label();
            this.lblChassisNo = new System.Windows.Forms.Label();
            this.lblEngineNo = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNoName = new System.Windows.Forms.Label();
            this.lblEqpName = new System.Windows.Forms.Label();
            this.lblEqpNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMonitoring)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 682);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblTotalHours);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.dgvDataMonitoring);
            this.panel5.Controls.Add(this.lblTotalUsed);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(2, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1182, 449);
            this.panel5.TabIndex = 3;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.Location = new System.Drawing.Point(441, 6);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(17, 18);
            this.lblTotalHours.TabIndex = 19;
            this.lblTotalHours.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1100, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvDataMonitoring
            // 
            this.dgvDataMonitoring.AllowUserToAddRows = false;
            this.dgvDataMonitoring.AllowUserToDeleteRows = false;
            this.dgvDataMonitoring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMonitoring.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Drivers_OptName,
            this.kmhrs_LastRefuel,
            this.kmhrs_duringRefuel,
            this.Kmhrs_Used,
            this.NoLtrsRefill,
            this.FuelCost,
            this.Ltr_kms,
            this.PreventiveId,
            this.PLocation,
            this.Status});
            this.dgvDataMonitoring.Location = new System.Drawing.Point(3, 27);
            this.dgvDataMonitoring.Name = "dgvDataMonitoring";
            this.dgvDataMonitoring.Size = new System.Drawing.Size(1172, 418);
            this.dgvDataMonitoring.TabIndex = 0;
            this.dgvDataMonitoring.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataMonitoring_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Drivers_OptName
            // 
            this.Drivers_OptName.HeaderText = "Driver\'s/Operator\'s";
            this.Drivers_OptName.Name = "Drivers_OptName";
            this.Drivers_OptName.ReadOnly = true;
            // 
            // kmhrs_LastRefuel
            // 
            this.kmhrs_LastRefuel.HeaderText = "Km/Hour Meter Reading Last Refuel";
            this.kmhrs_LastRefuel.Name = "kmhrs_LastRefuel";
            this.kmhrs_LastRefuel.ReadOnly = true;
            // 
            // kmhrs_duringRefuel
            // 
            this.kmhrs_duringRefuel.HeaderText = "Km/Hour Meter Reading During Refuel";
            this.kmhrs_duringRefuel.Name = "kmhrs_duringRefuel";
            this.kmhrs_duringRefuel.ReadOnly = true;
            // 
            // Kmhrs_Used
            // 
            this.Kmhrs_Used.HeaderText = "Km Travelled/Hour Used";
            this.Kmhrs_Used.Name = "Kmhrs_Used";
            this.Kmhrs_Used.ReadOnly = true;
            this.Kmhrs_Used.Width = 90;
            // 
            // NoLtrsRefill
            // 
            this.NoLtrsRefill.HeaderText = "No. Ltrs Refill";
            this.NoLtrsRefill.Name = "NoLtrsRefill";
            this.NoLtrsRefill.ReadOnly = true;
            this.NoLtrsRefill.Width = 64;
            // 
            // FuelCost
            // 
            this.FuelCost.HeaderText = "Fuel Cost";
            this.FuelCost.Name = "FuelCost";
            this.FuelCost.ReadOnly = true;
            this.FuelCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FuelCost.Width = 110;
            // 
            // Ltr_kms
            // 
            this.Ltr_kms.HeaderText = "Ltr/kms";
            this.Ltr_kms.Name = "Ltr_kms";
            this.Ltr_kms.ReadOnly = true;
            this.Ltr_kms.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ltr_kms.Width = 90;
            // 
            // PreventiveId
            // 
            this.PreventiveId.HeaderText = "Preventive Maintenance";
            this.PreventiveId.Name = "PreventiveId";
            this.PreventiveId.ReadOnly = true;
            this.PreventiveId.Width = 75;
            // 
            // PLocation
            // 
            this.PLocation.HeaderText = "Location";
            this.PLocation.Name = "PLocation";
            this.PLocation.ReadOnly = true;
            this.PLocation.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblTotalUsed
            // 
            this.lblTotalUsed.AutoSize = true;
            this.lblTotalUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsed.Location = new System.Drawing.Point(135, 5);
            this.lblTotalUsed.Name = "lblTotalUsed";
            this.lblTotalUsed.Size = new System.Drawing.Size(17, 18);
            this.lblTotalUsed.TabIndex = 8;
            this.lblTotalUsed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Km Travelled :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1019, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Hour Used :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(2, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 146);
            this.panel4.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lnkBack);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lblExpired);
            this.groupBox1.Controls.Add(this.lblYearModel);
            this.groupBox1.Controls.Add(this.lblSeries);
            this.groupBox1.Controls.Add(this.lblMake);
            this.groupBox1.Controls.Add(this.lblCRNo);
            this.groupBox1.Controls.Add(this.lblMVFile);
            this.groupBox1.Controls.Add(this.lblGrossWT);
            this.groupBox1.Controls.Add(this.lblBodyType);
            this.groupBox1.Controls.Add(this.lblFuelType);
            this.groupBox1.Controls.Add(this.lblCylinder);
            this.groupBox1.Controls.Add(this.lblPiston);
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Controls.Add(this.lblExistingReading);
            this.groupBox1.Controls.Add(this.lblDatePurchase);
            this.groupBox1.Controls.Add(this.lblStatusPurchase);
            this.groupBox1.Controls.Add(this.lblChassisNo);
            this.groupBox1.Controls.Add(this.lblEngineNo);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblNoName);
            this.groupBox1.Controls.Add(this.lblEqpName);
            this.groupBox1.Controls.Add(this.lblEqpNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION";
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBack.LinkColor = System.Drawing.Color.Red;
            this.lnkBack.Location = new System.Drawing.Point(1128, 9);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(39, 17);
            this.lnkBack.TabIndex = 45;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(998, 119);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 15);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Maintenance Expenses";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Location = new System.Drawing.Point(1005, 96);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(48, 15);
            this.lblExpired.TabIndex = 43;
            this.lblExpired.Text = "label41";
            // 
            // lblYearModel
            // 
            this.lblYearModel.AutoSize = true;
            this.lblYearModel.Location = new System.Drawing.Point(935, 78);
            this.lblYearModel.Name = "lblYearModel";
            this.lblYearModel.Size = new System.Drawing.Size(48, 15);
            this.lblYearModel.TabIndex = 42;
            this.lblYearModel.Text = "label40";
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(935, 59);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(48, 15);
            this.lblSeries.TabIndex = 41;
            this.lblSeries.Text = "label39";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(935, 41);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(48, 15);
            this.lblMake.TabIndex = 40;
            this.lblMake.Text = "label38";
            // 
            // lblCRNo
            // 
            this.lblCRNo.AutoSize = true;
            this.lblCRNo.Location = new System.Drawing.Point(426, 61);
            this.lblCRNo.Name = "lblCRNo";
            this.lblCRNo.Size = new System.Drawing.Size(48, 15);
            this.lblCRNo.TabIndex = 39;
            this.lblCRNo.Text = "label37";
            // 
            // lblMVFile
            // 
            this.lblMVFile.AutoSize = true;
            this.lblMVFile.Location = new System.Drawing.Point(426, 41);
            this.lblMVFile.Name = "lblMVFile";
            this.lblMVFile.Size = new System.Drawing.Size(48, 15);
            this.lblMVFile.TabIndex = 38;
            this.lblMVFile.Text = "label36";
            // 
            // lblGrossWT
            // 
            this.lblGrossWT.AutoSize = true;
            this.lblGrossWT.Location = new System.Drawing.Point(426, 20);
            this.lblGrossWT.Name = "lblGrossWT";
            this.lblGrossWT.Size = new System.Drawing.Size(48, 15);
            this.lblGrossWT.TabIndex = 37;
            this.lblGrossWT.Text = "label35";
            // 
            // lblBodyType
            // 
            this.lblBodyType.AutoSize = true;
            this.lblBodyType.Location = new System.Drawing.Point(699, 61);
            this.lblBodyType.Name = "lblBodyType";
            this.lblBodyType.Size = new System.Drawing.Size(48, 15);
            this.lblBodyType.TabIndex = 36;
            this.lblBodyType.Text = "label34";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(129, 96);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(48, 15);
            this.lblFuelType.TabIndex = 35;
            this.lblFuelType.Text = "label33";
            // 
            // lblCylinder
            // 
            this.lblCylinder.AutoSize = true;
            this.lblCylinder.Location = new System.Drawing.Point(699, 40);
            this.lblCylinder.Name = "lblCylinder";
            this.lblCylinder.Size = new System.Drawing.Size(48, 15);
            this.lblCylinder.TabIndex = 34;
            this.lblCylinder.Text = "label32";
            // 
            // lblPiston
            // 
            this.lblPiston.AutoSize = true;
            this.lblPiston.Location = new System.Drawing.Point(699, 21);
            this.lblPiston.Name = "lblPiston";
            this.lblPiston.Size = new System.Drawing.Size(48, 15);
            this.lblPiston.TabIndex = 33;
            this.lblPiston.Text = "label31";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(129, 116);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 15);
            this.lblSupplier.TabIndex = 32;
            this.lblSupplier.Text = "label30";
            // 
            // lblExistingReading
            // 
            this.lblExistingReading.AutoSize = true;
            this.lblExistingReading.Location = new System.Drawing.Point(699, 80);
            this.lblExistingReading.Name = "lblExistingReading";
            this.lblExistingReading.Size = new System.Drawing.Size(48, 15);
            this.lblExistingReading.TabIndex = 31;
            this.lblExistingReading.Text = "label29";
            // 
            // lblDatePurchase
            // 
            this.lblDatePurchase.AutoSize = true;
            this.lblDatePurchase.Location = new System.Drawing.Point(464, 98);
            this.lblDatePurchase.Name = "lblDatePurchase";
            this.lblDatePurchase.Size = new System.Drawing.Size(48, 15);
            this.lblDatePurchase.TabIndex = 30;
            this.lblDatePurchase.Text = "label28";
            // 
            // lblStatusPurchase
            // 
            this.lblStatusPurchase.AutoSize = true;
            this.lblStatusPurchase.Location = new System.Drawing.Point(464, 80);
            this.lblStatusPurchase.Name = "lblStatusPurchase";
            this.lblStatusPurchase.Size = new System.Drawing.Size(48, 15);
            this.lblStatusPurchase.TabIndex = 29;
            this.lblStatusPurchase.Text = "label27";
            // 
            // lblChassisNo
            // 
            this.lblChassisNo.AutoSize = true;
            this.lblChassisNo.Location = new System.Drawing.Point(130, 78);
            this.lblChassisNo.Name = "lblChassisNo";
            this.lblChassisNo.Size = new System.Drawing.Size(48, 15);
            this.lblChassisNo.TabIndex = 28;
            this.lblChassisNo.Text = "label26";
            // 
            // lblEngineNo
            // 
            this.lblEngineNo.AutoSize = true;
            this.lblEngineNo.Location = new System.Drawing.Point(130, 59);
            this.lblEngineNo.Name = "lblEngineNo";
            this.lblEngineNo.Size = new System.Drawing.Size(48, 15);
            this.lblEngineNo.TabIndex = 27;
            this.lblEngineNo.Text = "label25";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(341, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 15);
            this.label24.TabIndex = 26;
            this.label24.Text = "MV File No.  :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(344, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 15);
            this.label23.TabIndex = 25;
            this.label23.Text = "CR No.         :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 15);
            this.label22.TabIndex = 24;
            this.label22.Text = "Supplier                        :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(579, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 15);
            this.label21.TabIndex = 23;
            this.label21.Text = "Existing Reading       :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(864, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 15);
            this.label20.TabIndex = 22;
            this.label20.Text = "Register Expiration Date :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(342, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 15);
            this.label19.TabIndex = 21;
            this.label19.Text = "Date Of Purchase       :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(340, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "Status Of Purchase     :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(342, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 15);
            this.label17.TabIndex = 19;
            this.label17.Text = "Gross WT     :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(864, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "Year Model :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(578, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "Body Type                    :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(865, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Series          :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(866, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Make           :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Fuel Type                     :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(577, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Number of Cylinders  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(578, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Piston Displacement :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Chassis No.                  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Engine No.                   :";
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoName.Location = new System.Drawing.Point(130, 40);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(41, 15);
            this.lblNoName.TabIndex = 5;
            this.lblNoName.Text = "label8";
            // 
            // lblEqpName
            // 
            this.lblEqpName.AutoSize = true;
            this.lblEqpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqpName.Location = new System.Drawing.Point(934, 21);
            this.lblEqpName.Name = "lblEqpName";
            this.lblEqpName.Size = new System.Drawing.Size(41, 15);
            this.lblEqpName.TabIndex = 4;
            this.lblEqpName.Text = "label7";
            // 
            // lblEqpNo
            // 
            this.lblEqpNo.AutoSize = true;
            this.lblEqpNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqpNo.Location = new System.Drawing.Point(130, 20);
            this.lblEqpNo.Name = "lblEqpNo";
            this.lblEqpNo.Size = new System.Drawing.Size(41, 15);
            this.lblEqpNo.TabIndex = 3;
            this.lblEqpNo.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Plate No.                      :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(864, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model          :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Equipment No.            :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 61);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRUCK AND HEAVY EQUIPMENT FUEL MONITORING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUIRANTE CONSTRUCTION CORPORATION";
            // 
            // AddMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1194, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1210, 699);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1210, 699);
            this.Name = "AddMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddMonitoring_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMonitoring)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNoName;
        private System.Windows.Forms.Label lblEqpName;
        private System.Windows.Forms.Label lblEqpNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvDataMonitoring;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalUsed;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblYearModel;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblCRNo;
        private System.Windows.Forms.Label lblMVFile;
        private System.Windows.Forms.Label lblGrossWT;
        private System.Windows.Forms.Label lblBodyType;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblCylinder;
        private System.Windows.Forms.Label lblPiston;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblExistingReading;
        private System.Windows.Forms.Label lblDatePurchase;
        private System.Windows.Forms.Label lblStatusPurchase;
        private System.Windows.Forms.Label lblChassisNo;
        private System.Windows.Forms.Label lblEngineNo;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnkBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drivers_OptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmhrs_LastRefuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmhrs_duringRefuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kmhrs_Used;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoLtrsRefill;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ltr_kms;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreventiveId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}