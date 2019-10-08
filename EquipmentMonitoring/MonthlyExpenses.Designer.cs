namespace EquipmentMonitoring
{
    partial class MonthlyExpenses
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEquip = new System.Windows.Forms.TextBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblmonth = new System.Windows.Forms.Label();
            this.dgvMonthlyExpenses = new System.Windows.Forms.DataGridView();
            this.chkUnit = new System.Windows.Forms.CheckBox();
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalExpenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblhrs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblliters = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblfuelcost = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblpms = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblrepair = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblexpenses = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbltire = new System.Windows.Forms.Label();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyExpenses)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MONTHLY EXPENSES";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lnkClose);
            this.panel2.Location = new System.Drawing.Point(406, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 60);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbList);
            this.groupBox1.Controls.Add(this.chkOthers);
            this.groupBox1.Controls.Add(this.chkUnit);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtEquip);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(674, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEquip
            // 
            this.txtEquip.Location = new System.Drawing.Point(429, 23);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(155, 21);
            this.txtEquip.TabIndex = 4;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(192, 22);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(83, 23);
            this.cmbYear.TabIndex = 3;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.cmbMonth.Location = new System.Drawing.Point(16, 22);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(169, 23);
            this.cmbMonth.TabIndex = 2;
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.LinkColor = System.Drawing.Color.Red;
            this.lnkClose.Location = new System.Drawing.Point(846, 6);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(42, 13);
            this.lnkClose.TabIndex = 4;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "CLOSE";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblmonth);
            this.panel3.Controls.Add(this.dgvMonthlyExpenses);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(2, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1304, 616);
            this.panel3.TabIndex = 2;
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.Location = new System.Drawing.Point(5, 5);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(0, 18);
            this.lblmonth.TabIndex = 1;
            // 
            // dgvMonthlyExpenses
            // 
            this.dgvMonthlyExpenses.AllowUserToAddRows = false;
            this.dgvMonthlyExpenses.AllowUserToDeleteRows = false;
            this.dgvMonthlyExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentNo,
            this.Model,
            this.PlateNo,
            this.KM,
            this.Hrs,
            this.Liters,
            this.FuelCost,
            this.PMS,
            this.Repair,
            this.Tire,
            this.TotalExpenses});
            this.dgvMonthlyExpenses.Location = new System.Drawing.Point(5, 28);
            this.dgvMonthlyExpenses.Name = "dgvMonthlyExpenses";
            this.dgvMonthlyExpenses.Size = new System.Drawing.Size(1289, 519);
            this.dgvMonthlyExpenses.TabIndex = 0;
            // 
            // chkUnit
            // 
            this.chkUnit.AutoSize = true;
            this.chkUnit.Checked = true;
            this.chkUnit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnit.Location = new System.Drawing.Point(599, 34);
            this.chkUnit.Name = "chkUnit";
            this.chkUnit.Size = new System.Drawing.Size(54, 19);
            this.chkUnit.TabIndex = 7;
            this.chkUnit.Text = "Units";
            this.chkUnit.UseVisualStyleBackColor = true;
            this.chkUnit.CheckedChanged += new System.EventHandler(this.chkUnit_CheckedChanged);
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.Checked = true;
            this.chkOthers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOthers.Location = new System.Drawing.Point(599, 13);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(62, 19);
            this.chkOthers.TabIndex = 8;
            this.chkOthers.Text = "Others";
            this.chkOthers.UseVisualStyleBackColor = true;
            this.chkOthers.CheckedChanged += new System.EventHandler(this.chkOthers_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbltire);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblexpenses);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblrepair);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblpms);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblfuelcost);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblliters);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblhrs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblkm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(4, 545);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1290, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // EquipmentNo
            // 
            this.EquipmentNo.HeaderText = "EQUIPMENT NO";
            this.EquipmentNo.Name = "EquipmentNo";
            this.EquipmentNo.ReadOnly = true;
            this.EquipmentNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EquipmentNo.Width = 120;
            // 
            // Model
            // 
            this.Model.HeaderText = "MODEL";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Model.Width = 120;
            // 
            // PlateNo
            // 
            this.PlateNo.HeaderText = "PLATE NO";
            this.PlateNo.Name = "PlateNo";
            this.PlateNo.ReadOnly = true;
            this.PlateNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlateNo.Width = 120;
            // 
            // KM
            // 
            this.KM.HeaderText = "KM";
            this.KM.Name = "KM";
            this.KM.ReadOnly = true;
            this.KM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KM.Width = 110;
            // 
            // Hrs
            // 
            this.Hrs.HeaderText = "HRS";
            this.Hrs.Name = "Hrs";
            this.Hrs.ReadOnly = true;
            this.Hrs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hrs.Width = 110;
            // 
            // Liters
            // 
            this.Liters.HeaderText = "LITERS";
            this.Liters.Name = "Liters";
            this.Liters.ReadOnly = true;
            this.Liters.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Liters.Width = 110;
            // 
            // FuelCost
            // 
            this.FuelCost.HeaderText = "FUEL COST";
            this.FuelCost.Name = "FuelCost";
            this.FuelCost.ReadOnly = true;
            this.FuelCost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FuelCost.Width = 115;
            // 
            // PMS
            // 
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            this.PMS.ReadOnly = true;
            this.PMS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PMS.Width = 105;
            // 
            // Repair
            // 
            this.Repair.HeaderText = "REPAIR";
            this.Repair.Name = "Repair";
            this.Repair.ReadOnly = true;
            this.Repair.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Repair.Width = 105;
            // 
            // Tire
            // 
            this.Tire.HeaderText = "TIRE";
            this.Tire.Name = "Tire";
            this.Tire.ReadOnly = true;
            this.Tire.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tire.Width = 105;
            // 
            // TotalExpenses
            // 
            this.TotalExpenses.HeaderText = "TOTAL EXPENSES";
            this.TotalExpenses.Name = "TotalExpenses";
            this.TotalExpenses.ReadOnly = true;
            this.TotalExpenses.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalExpenses.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "GRAND TOTAL :";
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkm.Location = new System.Drawing.Point(161, 18);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(16, 17);
            this.lblkm.TabIndex = 4;
            this.lblkm.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "KM :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "HRS :";
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrs.Location = new System.Drawing.Point(161, 42);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(16, 17);
            this.lblhrs.TabIndex = 6;
            this.lblhrs.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "LITERS :";
            // 
            // lblliters
            // 
            this.lblliters.AutoSize = true;
            this.lblliters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliters.Location = new System.Drawing.Point(407, 16);
            this.lblliters.Name = "lblliters";
            this.lblliters.Size = new System.Drawing.Size(16, 17);
            this.lblliters.TabIndex = 8;
            this.lblliters.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(314, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "FUEL COST :";
            // 
            // lblfuelcost
            // 
            this.lblfuelcost.AutoSize = true;
            this.lblfuelcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuelcost.Location = new System.Drawing.Point(405, 43);
            this.lblfuelcost.Name = "lblfuelcost";
            this.lblfuelcost.Size = new System.Drawing.Size(16, 17);
            this.lblfuelcost.TabIndex = 10;
            this.lblfuelcost.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(623, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "PMS :";
            // 
            // lblpms
            // 
            this.lblpms.AutoSize = true;
            this.lblpms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpms.Location = new System.Drawing.Point(664, 18);
            this.lblpms.Name = "lblpms";
            this.lblpms.Size = new System.Drawing.Size(16, 17);
            this.lblpms.TabIndex = 12;
            this.lblpms.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(602, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "REPAIR :";
            // 
            // lblrepair
            // 
            this.lblrepair.AutoSize = true;
            this.lblrepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepair.Location = new System.Drawing.Point(664, 41);
            this.lblrepair.Name = "lblrepair";
            this.lblrepair.Size = new System.Drawing.Size(16, 17);
            this.lblrepair.TabIndex = 14;
            this.lblrepair.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1040, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "EXPENSES :";
            // 
            // lblexpenses
            // 
            this.lblexpenses.AutoSize = true;
            this.lblexpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpenses.Location = new System.Drawing.Point(1126, 17);
            this.lblexpenses.Name = "lblexpenses";
            this.lblexpenses.Size = new System.Drawing.Size(16, 17);
            this.lblexpenses.TabIndex = 16;
            this.lblexpenses.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(849, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "TIRE :";
            // 
            // lbltire
            // 
            this.lbltire.AutoSize = true;
            this.lbltire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltire.Location = new System.Drawing.Point(892, 18);
            this.lbltire.Name = "lbltire";
            this.lbltire.Size = new System.Drawing.Size(16, 17);
            this.lbltire.TabIndex = 18;
            this.lbltire.Text = "0";
            // 
            // cmbList
            // 
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Items.AddRange(new object[] {
            "Equipment No",
            "Model",
            "Plate No"});
            this.cmbList.Location = new System.Drawing.Point(302, 22);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(121, 23);
            this.cmbList.TabIndex = 9;
            // 
            // MonthlyExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1323, 699);
            this.Name = "MonthlyExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MonthlyExpenses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyExpenses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEquip;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMonthlyExpenses;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.CheckBox chkOthers;
        private System.Windows.Forms.CheckBox chkUnit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liters;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tire;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalExpenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblexpenses;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblrepair;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblpms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblfuelcost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblliters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblhrs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbltire;
        private System.Windows.Forms.ComboBox cmbList;
    }
}