namespace EquipmentMonitoring.AllForm.expenses
{
    partial class AddUnitExpenses
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
            this.txtmileage = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.chkRepairComplete = new System.Windows.Forms.CheckBox();
            this.chkRepairDate = new System.Windows.Forms.CheckBox();
            this.txtRepairComplete = new System.Windows.Forms.TextBox();
            this.txtStartRepair = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cmdDate = new System.Windows.Forms.DateTimePicker();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.txtProjectSite = new System.Windows.Forms.TextBox();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPMS = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBorrow = new System.Windows.Forms.CheckBox();
            this.dgvBorrowItem = new System.Windows.Forms.DataGridView();
            this.EQUIPNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPARTSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSERIALNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BNO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPAIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIALNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALLOCATIONNO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMechanic = new System.Windows.Forms.DataGridView();
            this.Mechanic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMechanic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmileage
            // 
            this.txtmileage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtmileage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtmileage.Location = new System.Drawing.Point(466, 28);
            this.txtmileage.Name = "txtmileage";
            this.txtmileage.Size = new System.Drawing.Size(124, 20);
            this.txtmileage.TabIndex = 5;
            this.txtmileage.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(403, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "MILEAGE :";
            // 
            // txtDriver
            // 
            this.txtDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDriver.Location = new System.Drawing.Point(170, 29);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(205, 20);
            this.txtDriver.TabIndex = 4;
            // 
            // chkRepairComplete
            // 
            this.chkRepairComplete.AutoSize = true;
            this.chkRepairComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepairComplete.Location = new System.Drawing.Point(144, 224);
            this.chkRepairComplete.Name = "chkRepairComplete";
            this.chkRepairComplete.Size = new System.Drawing.Size(172, 17);
            this.chkRepairComplete.TabIndex = 12;
            this.chkRepairComplete.Text = "Enable Repair Completed Date";
            this.chkRepairComplete.UseVisualStyleBackColor = true;
            this.chkRepairComplete.CheckedChanged += new System.EventHandler(this.chkRepairComplete_CheckedChanged);
            // 
            // chkRepairDate
            // 
            this.chkRepairDate.AutoSize = true;
            this.chkRepairDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepairDate.Location = new System.Drawing.Point(144, 183);
            this.chkRepairDate.Name = "chkRepairDate";
            this.chkRepairDate.Size = new System.Drawing.Size(158, 17);
            this.chkRepairDate.TabIndex = 10;
            this.chkRepairDate.Text = "Enable Start Of Repair Date";
            this.chkRepairDate.UseVisualStyleBackColor = true;
            this.chkRepairDate.CheckedChanged += new System.EventHandler(this.chkRepairDate_CheckedChanged);
            // 
            // txtRepairComplete
            // 
            this.txtRepairComplete.Location = new System.Drawing.Point(144, 239);
            this.txtRepairComplete.MaxLength = 10;
            this.txtRepairComplete.Name = "txtRepairComplete";
            this.txtRepairComplete.ReadOnly = true;
            this.txtRepairComplete.Size = new System.Drawing.Size(145, 20);
            this.txtRepairComplete.TabIndex = 13;
            // 
            // txtStartRepair
            // 
            this.txtStartRepair.Location = new System.Drawing.Point(145, 199);
            this.txtStartRepair.MaxLength = 10;
            this.txtStartRepair.Name = "txtStartRepair";
            this.txtStartRepair.ReadOnly = true;
            this.txtStartRepair.Size = new System.Drawing.Size(144, 20);
            this.txtStartRepair.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(966, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(320, 193);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(718, 70);
            this.txtRemarks.TabIndex = 8;
            // 
            // cmdDate
            // 
            this.cmdDate.CustomFormat = "MM/dd/yyyy";
            this.cmdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmdDate.Location = new System.Drawing.Point(728, 3);
            this.cmdDate.Name = "cmdDate";
            this.cmdDate.Size = new System.Drawing.Size(118, 20);
            this.cmdDate.TabIndex = 3;
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(320, 70);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProblem.Size = new System.Drawing.Size(270, 102);
            this.txtProblem.TabIndex = 6;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(598, 70);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnosis.Size = new System.Drawing.Size(440, 102);
            this.txtDiagnosis.TabIndex = 7;
            // 
            // txtProjectSite
            // 
            this.txtProjectSite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjectSite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjectSite.Location = new System.Drawing.Point(466, 3);
            this.txtProjectSite.Name = "txtProjectSite";
            this.txtProjectSite.Size = new System.Drawing.Size(210, 20);
            this.txtProjectSite.TabIndex = 2;
            // 
            // txtEquipment
            // 
            this.txtEquipment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEquipment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEquipment.Location = new System.Drawing.Point(170, 3);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(205, 20);
            this.txtEquipment.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(379, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "CONTRACT ID :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "START OF REPAIR DATE :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "REPAIR  COMPLETED :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "REMARKS :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "MECHANIC POSSIBLE CAUSE AND DIAGNOSIS / SOLUTION APPLIED / NEEDED:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "DRIVER / OPERATOR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "PROBLEM / ACTIVITY :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "DATE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "EQUIP NO/MODEL/PLATE NO :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.chkPMS);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtmileage);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtDriver);
            this.panel1.Controls.Add(this.chkRepairComplete);
            this.panel1.Controls.Add(this.chkRepairDate);
            this.panel1.Controls.Add(this.txtRepairComplete);
            this.panel1.Controls.Add(this.txtStartRepair);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.cmdDate);
            this.panel1.Controls.Add(this.txtProblem);
            this.panel1.Controls.Add(this.txtDiagnosis);
            this.panel1.Controls.Add(this.txtProjectSite);
            this.panel1.Controls.Add(this.txtEquipment);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 626);
            this.panel1.TabIndex = 1;
            // 
            // chkPMS
            // 
            this.chkPMS.AutoSize = true;
            this.chkPMS.Location = new System.Drawing.Point(601, 30);
            this.chkPMS.Name = "chkPMS";
            this.chkPMS.Size = new System.Drawing.Size(49, 17);
            this.chkPMS.TabIndex = 16;
            this.chkPMS.Text = "PMS";
            this.chkPMS.UseVisualStyleBackColor = true;
            this.chkPMS.CheckedChanged += new System.EventHandler(this.chkPMS_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(5, 598);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBorrow);
            this.groupBox3.Controls.Add(this.dgvBorrowItem);
            this.groupBox3.Location = new System.Drawing.Point(7, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1031, 148);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            // 
            // chkBorrow
            // 
            this.chkBorrow.AutoSize = true;
            this.chkBorrow.Location = new System.Drawing.Point(6, 9);
            this.chkBorrow.Name = "chkBorrow";
            this.chkBorrow.Size = new System.Drawing.Size(105, 17);
            this.chkBorrow.TabIndex = 16;
            this.chkBorrow.Text = "BORROW ITEM";
            this.chkBorrow.UseVisualStyleBackColor = true;
            this.chkBorrow.CheckedChanged += new System.EventHandler(this.chkBorrow_CheckedChanged);
            // 
            // dgvBorrowItem
            // 
            this.dgvBorrowItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EQUIPNO,
            this.BQTY,
            this.BITEM,
            this.BPARTSNO,
            this.BSERIALNO,
            this.BNO});
            this.dgvBorrowItem.Enabled = false;
            this.dgvBorrowItem.Location = new System.Drawing.Point(7, 26);
            this.dgvBorrowItem.Name = "dgvBorrowItem";
            this.dgvBorrowItem.Size = new System.Drawing.Size(1018, 116);
            this.dgvBorrowItem.TabIndex = 17;
            this.dgvBorrowItem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBorrowItem_EditingControlShowing);
            // 
            // EQUIPNO
            // 
            this.EQUIPNO.HeaderText = "EQUIPNO / MODEL / PLATENO";
            this.EQUIPNO.Name = "EQUIPNO";
            this.EQUIPNO.Width = 180;
            // 
            // BQTY
            // 
            this.BQTY.HeaderText = "QTY";
            this.BQTY.Name = "BQTY";
            this.BQTY.Width = 50;
            // 
            // BITEM
            // 
            this.BITEM.HeaderText = "ITEM";
            this.BITEM.Name = "BITEM";
            this.BITEM.Width = 200;
            // 
            // BPARTSNO
            // 
            this.BPARTSNO.HeaderText = "PARTS NO.";
            this.BPARTSNO.Name = "BPARTSNO";
            this.BPARTSNO.Width = 200;
            // 
            // BSERIALNO
            // 
            this.BSERIALNO.HeaderText = "SERIAL NO.";
            this.BSERIALNO.Name = "BSERIALNO";
            this.BSERIALNO.Width = 200;
            // 
            // BNO
            // 
            this.BNO.HeaderText = "NO.";
            this.BNO.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.BNO.Name = "BNO";
            this.BNO.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkItem);
            this.groupBox1.Controls.Add(this.dgvItem);
            this.groupBox1.Location = new System.Drawing.Point(7, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 185);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Location = new System.Drawing.Point(6, 10);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(52, 17);
            this.chkItem.TabIndex = 14;
            this.chkItem.Text = "ITEM";
            this.chkItem.UseVisualStyleBackColor = true;
            this.chkItem.CheckedChanged += new System.EventHandler(this.chkItem_CheckedChanged);
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QTY,
            this.Item,
            this.Purchase,
            this.PMS,
            this.REPAIR,
            this.TIRE,
            this.PARTSNO,
            this.SERIALNO,
            this.ALLOCATIONNO});
            this.dgvItem.Enabled = false;
            this.dgvItem.Location = new System.Drawing.Point(6, 29);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(1018, 149);
            this.dgvItem.TabIndex = 15;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.Width = 40;
            // 
            // Item
            // 
            this.Item.HeaderText = "ITEM";
            this.Item.Name = "Item";
            this.Item.Width = 180;
            // 
            // Purchase
            // 
            this.Purchase.HeaderText = "PURCHASE";
            this.Purchase.Name = "Purchase";
            this.Purchase.Visible = false;
            this.Purchase.Width = 70;
            // 
            // PMS
            // 
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            this.PMS.Width = 80;
            // 
            // REPAIR
            // 
            this.REPAIR.HeaderText = "REPAIR";
            this.REPAIR.Name = "REPAIR";
            this.REPAIR.Width = 80;
            // 
            // TIRE
            // 
            this.TIRE.HeaderText = "TIRE";
            this.TIRE.Name = "TIRE";
            this.TIRE.Width = 80;
            // 
            // PARTSNO
            // 
            this.PARTSNO.HeaderText = "PARTS NO.";
            this.PARTSNO.Name = "PARTSNO";
            this.PARTSNO.Width = 120;
            // 
            // SERIALNO
            // 
            this.SERIALNO.HeaderText = "SERIAL NO.";
            this.SERIALNO.Name = "SERIALNO";
            this.SERIALNO.Width = 120;
            // 
            // ALLOCATIONNO
            // 
            this.ALLOCATIONNO.HeaderText = "NO.";
            this.ALLOCATIONNO.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.ALLOCATIONNO.Name = "ALLOCATIONNO";
            this.ALLOCATIONNO.Width = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMechanic);
            this.groupBox2.Location = new System.Drawing.Point(9, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 124);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MECHANIC / ELECTRICIAN";
            // 
            // dgvMechanic
            // 
            this.dgvMechanic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMechanic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mechanic});
            this.dgvMechanic.Location = new System.Drawing.Point(4, 15);
            this.dgvMechanic.Name = "dgvMechanic";
            this.dgvMechanic.Size = new System.Drawing.Size(295, 102);
            this.dgvMechanic.TabIndex = 9;
            this.dgvMechanic.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMechanic_EditingControlShowing);
            // 
            // Mechanic
            // 
            this.Mechanic.HeaderText = "MECHANIC";
            this.Mechanic.Name = "Mechanic";
            this.Mechanic.Width = 250;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "PENDING",
            "FOR APPROVAL"});
            this.cmbStatus.Location = new System.Drawing.Point(727, 27);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 58;
            // 
            // AddUnitExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1056, 631);
            this.Controls.Add(this.panel1);
            this.Name = "AddUnitExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Unit Expenses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMechanic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmileage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.CheckBox chkRepairComplete;
        private System.Windows.Forms.CheckBox chkRepairDate;
        private System.Windows.Forms.TextBox txtRepairComplete;
        private System.Windows.Forms.TextBox txtStartRepair;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DateTimePicker cmdDate;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtProjectSite;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMechanic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mechanic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvBorrowItem;
        private System.Windows.Forms.CheckBox chkBorrow;
        private System.Windows.Forms.CheckBox chkItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkPMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EQUIPNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPARTSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSERIALNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn BNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPAIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIALNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn ALLOCATIONNO;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}