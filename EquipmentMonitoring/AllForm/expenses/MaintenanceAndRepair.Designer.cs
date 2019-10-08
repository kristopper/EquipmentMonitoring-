namespace EquipmentMonitoring.AllForm.expenses
{
    partial class MaintenanceAndRepair
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMechanic = new System.Windows.Forms.TextBox();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MILEAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRIVER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contractid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaintenanceType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.lbladdExpenses = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.txtEquip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPMS = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAllExpensesPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Project ID:";
            // 
            // txtProjectId
            // 
            this.txtProjectId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjectId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjectId.Location = new System.Drawing.Point(128, 83);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(159, 20);
            this.txtProjectId.TabIndex = 4;
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(367, 34);
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(178, 20);
            this.txtProblem.TabIndex = 6;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(367, 8);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(178, 20);
            this.txtItem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mechanic / Electrician:";
            // 
            // txtMechanic
            // 
            this.txtMechanic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMechanic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMechanic.Location = new System.Drawing.Point(128, 59);
            this.txtMechanic.Name = "txtMechanic";
            this.txtMechanic.Size = new System.Drawing.Size(159, 20);
            this.txtMechanic.TabIndex = 3;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.EquipDetail,
            this.MILEAGE,
            this.DRIVER,
            this.Diagnosis,
            this.Remarks,
            this.RepairStatus,
            this.Contractid,
            this.Action});
            this.dgvExpenses.Location = new System.Drawing.Point(1, 146);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(1161, 493);
            this.dgvExpenses.TabIndex = 36;
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 90;
            // 
            // EquipDetail
            // 
            this.EquipDetail.Frozen = true;
            this.EquipDetail.HeaderText = "EQUIPNO / MODEL / PLATENO";
            this.EquipDetail.Name = "EquipDetail";
            this.EquipDetail.ReadOnly = true;
            this.EquipDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EquipDetail.Width = 120;
            // 
            // MILEAGE
            // 
            this.MILEAGE.Frozen = true;
            this.MILEAGE.HeaderText = "MILEAGE";
            this.MILEAGE.Name = "MILEAGE";
            this.MILEAGE.ReadOnly = true;
            this.MILEAGE.Width = 95;
            // 
            // DRIVER
            // 
            this.DRIVER.HeaderText = "DRIVER / OPERATOR";
            this.DRIVER.Name = "DRIVER";
            this.DRIVER.ReadOnly = true;
            this.DRIVER.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DRIVER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DRIVER.Width = 130;
            // 
            // Diagnosis
            // 
            this.Diagnosis.HeaderText = "MECHANIC POSSIBLE CAUSE AND DIAGNOSIS / SOLUTION APPLIED / NEEDED";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            this.Diagnosis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Diagnosis.Width = 190;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "REMARKS";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Remarks.Width = 150;
            // 
            // RepairStatus
            // 
            this.RepairStatus.HeaderText = "STATUS";
            this.RepairStatus.Name = "RepairStatus";
            this.RepairStatus.ReadOnly = true;
            this.RepairStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RepairStatus.Width = 120;
            // 
            // Contractid
            // 
            this.Contractid.HeaderText = "CONTRACT ID";
            this.Contractid.Name = "Contractid";
            this.Contractid.ReadOnly = true;
            this.Contractid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Contractid.Width = 122;
            // 
            // Action
            // 
            this.Action.HeaderText = "ACTION";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Problem :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Item :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 28);
            this.panel3.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAINTENANCE  AND REPAIR REQUEST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Driver / Operator:";
            // 
            // txtDriver
            // 
            this.txtDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDriver.Location = new System.Drawing.Point(128, 35);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(159, 20);
            this.txtDriver.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaintenanceType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(557, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 73);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CATEGORY";
            // 
            // cmbMaintenanceType
            // 
            this.cmbMaintenanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaintenanceType.FormattingEnabled = true;
            this.cmbMaintenanceType.Items.AddRange(new object[] {
            "ALL",
            "MINOR",
            "MAJOR"});
            this.cmbMaintenanceType.Location = new System.Drawing.Point(49, 45);
            this.cmbMaintenanceType.Name = "cmbMaintenanceType";
            this.cmbMaintenanceType.Size = new System.Drawing.Size(87, 21);
            this.cmbMaintenanceType.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Type :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(8, 16);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(222, 21);
            this.cmbCategory.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(155, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.dtfrom);
            this.groupDate.Controls.Add(this.label8);
            this.groupDate.Controls.Add(this.dtTo);
            this.groupDate.Controls.Add(this.label9);
            this.groupDate.Location = new System.Drawing.Point(3, 4);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(310, 42);
            this.groupDate.TabIndex = 27;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "DATE :";
            // 
            // dtfrom
            // 
            this.dtfrom.CustomFormat = "MM/dd/yyyy";
            this.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfrom.Location = new System.Drawing.Point(53, 15);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(106, 20);
            this.dtfrom.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "TO :";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MM/dd/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(198, 15);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(106, 20);
            this.dtTo.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "FROM :";
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(804, 84);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(118, 17);
            this.chkFilter.TabIndex = 28;
            this.chkFilter.Text = "Date of Breakdown";
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.Visible = false;
            // 
            // lbladdExpenses
            // 
            this.lbladdExpenses.AutoSize = true;
            this.lbladdExpenses.Location = new System.Drawing.Point(1069, 91);
            this.lbladdExpenses.Name = "lbladdExpenses";
            this.lbladdExpenses.Size = new System.Drawing.Size(90, 13);
            this.lbladdExpenses.TabIndex = 32;
            this.lbladdExpenses.TabStop = true;
            this.lbladdExpenses.Text = "ADD EXPENSES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Solution Applied :";
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(386, 60);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(159, 20);
            this.txtSolution.TabIndex = 7;
            // 
            // txtEquip
            // 
            this.txtEquip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEquip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEquip.Location = new System.Drawing.Point(128, 8);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(159, 20);
            this.txtEquip.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Status :";
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "All",
            "For Approval",
            "Approved",
            "For Purchase",
            "Purchase",
            "Repair",
            "For Acknowledge",
            "Acknowledged",
            "Pending"});
            this.cmbstatus.Location = new System.Drawing.Point(600, 7);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(193, 21);
            this.cmbstatus.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkPMS);
            this.panel1.Controls.Add(this.chkFilter);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtProjectId);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtProblem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtItem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMechanic);
            this.panel1.Controls.Add(this.btnAllExpensesPrint);
            this.panel1.Controls.Add(this.lbladdExpenses);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDriver);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtSolution);
            this.panel1.Controls.Add(this.txtEquip);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbstatus);
            this.panel1.Location = new System.Drawing.Point(-2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 110);
            this.panel1.TabIndex = 35;
            // 
            // chkPMS
            // 
            this.chkPMS.AutoSize = true;
            this.chkPMS.Location = new System.Drawing.Point(496, 85);
            this.chkPMS.Name = "chkPMS";
            this.chkPMS.Size = new System.Drawing.Size(49, 17);
            this.chkPMS.TabIndex = 8;
            this.chkPMS.Text = "PMS";
            this.chkPMS.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "EquipNo/Model/PlateNo:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupDate);
            this.panel2.Location = new System.Drawing.Point(799, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 52);
            this.panel2.TabIndex = 33;
            // 
            // btnAllExpensesPrint
            // 
            this.btnAllExpensesPrint.BackgroundImage = global::EquipmentMonitoring.Properties.Resources.Print_Button_printer_512;
            this.btnAllExpensesPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllExpensesPrint.Location = new System.Drawing.Point(1125, 5);
            this.btnAllExpensesPrint.Name = "btnAllExpensesPrint";
            this.btnAllExpensesPrint.Size = new System.Drawing.Size(34, 28);
            this.btnAllExpensesPrint.TabIndex = 52;
            this.btnAllExpensesPrint.UseVisualStyleBackColor = true;
            // 
            // MaintenanceAndRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MaintenanceAndRepair";
            this.Size = new System.Drawing.Size(1163, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtProjectId;
        public System.Windows.Forms.TextBox txtProblem;
        public System.Windows.Forms.TextBox txtItem;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMechanic;
        public System.Windows.Forms.DataGridView dgvExpenses;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnAllExpensesPrint;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDriver;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbMaintenanceType;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.GroupBox groupDate;
        public System.Windows.Forms.DateTimePicker dtfrom;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dtTo;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.CheckBox chkFilter;
        public System.Windows.Forms.LinkLabel lbladdExpenses;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSolution;
        public System.Windows.Forms.TextBox txtEquip;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbstatus;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.CheckBox chkPMS;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MILEAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRIVER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contractid;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}
