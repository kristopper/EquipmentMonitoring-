namespace EquipmentMonitoring
{
    partial class FuelLogSheetMain
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBaseongauge = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTankTruck = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lnkViewAll = new System.Windows.Forms.LinkLabel();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblpullout = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblTankRefill = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTankLog = new System.Windows.Forms.DataGridView();
            this.cmbfueltype = new System.Windows.Forms.ComboBox();
            this.cmbTanktruck = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoLiters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankGauge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmhr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTankLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblBaseongauge);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblTankTruck);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lnkViewAll);
            this.panel3.Controls.Add(this.lblRemaining);
            this.panel3.Controls.Add(this.lblpullout);
            this.panel3.Controls.Add(this.lblPrevious);
            this.panel3.Controls.Add(this.lblTankRefill);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgvTankLog);
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1306, 606);
            this.panel3.TabIndex = 4;
            // 
            // lblBaseongauge
            // 
            this.lblBaseongauge.AutoSize = true;
            this.lblBaseongauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseongauge.Location = new System.Drawing.Point(867, 580);
            this.lblBaseongauge.Name = "lblBaseongauge";
            this.lblBaseongauge.Size = new System.Drawing.Size(48, 15);
            this.lblBaseongauge.TabIndex = 15;
            this.lblBaseongauge.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(571, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "LITER PULL OUT BASE ON TANKER GAUGE :";
            // 
            // lblTankTruck
            // 
            this.lblTankTruck.AutoSize = true;
            this.lblTankTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankTruck.Location = new System.Drawing.Point(311, 6);
            this.lblTankTruck.Name = "lblTankTruck";
            this.lblTankTruck.Size = new System.Drawing.Size(41, 15);
            this.lblTankTruck.TabIndex = 13;
            this.lblTankTruck.Text = "label9";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(68, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "label8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(225, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tank Truck :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "DATE :";
            // 
            // lnkViewAll
            // 
            this.lnkViewAll.AutoSize = true;
            this.lnkViewAll.Location = new System.Drawing.Point(1174, 8);
            this.lnkViewAll.Name = "lnkViewAll";
            this.lnkViewAll.Size = new System.Drawing.Size(119, 13);
            this.lnkViewAll.TabIndex = 7;
            this.lnkViewAll.TabStop = true;
            this.lnkViewAll.Text = "View All Fuel Log Sheet";
            this.lnkViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewAll_LinkClicked);
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(1145, 581);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(48, 15);
            this.lblRemaining.TabIndex = 9;
            this.lblRemaining.Text = "label11";
            // 
            // lblpullout
            // 
            this.lblpullout.AutoSize = true;
            this.lblpullout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpullout.Location = new System.Drawing.Point(459, 579);
            this.lblpullout.Name = "lblpullout";
            this.lblpullout.Size = new System.Drawing.Size(48, 15);
            this.lblpullout.TabIndex = 8;
            this.lblpullout.Text = "label10";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(962, 6);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(41, 15);
            this.lblPrevious.TabIndex = 7;
            this.lblPrevious.Text = "label9";
            // 
            // lblTankRefill
            // 
            this.lblTankRefill.AutoSize = true;
            this.lblTankRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankRefill.Location = new System.Drawing.Point(628, 6);
            this.lblTankRefill.Name = "lblTankRefill";
            this.lblTankRefill.Size = new System.Drawing.Size(41, 15);
            this.lblTankRefill.TabIndex = 6;
            this.lblTankRefill.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1009, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "TANK REMAINING :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "TOTAL LITERS PULL OUT BASE ON LITERS RECORDING SHEET :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(756, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "PREVIOUS TANK REMAINING :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "TANK REFILL :";
            // 
            // dgvTankLog
            // 
            this.dgvTankLog.AllowUserToAddRows = false;
            this.dgvTankLog.AllowUserToDeleteRows = false;
            this.dgvTankLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTankLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Drivers,
            this.EquipmentNo,
            this.NoLiters,
            this.Availability,
            this.TankGauge,
            this.site,
            this.Operation,
            this.PumpIncharge,
            this.kmhr,
            this.Status});
            this.dgvTankLog.Location = new System.Drawing.Point(3, 25);
            this.dgvTankLog.Name = "dgvTankLog";
            this.dgvTankLog.Size = new System.Drawing.Size(1294, 549);
            this.dgvTankLog.TabIndex = 1;
            // 
            // cmbfueltype
            // 
            this.cmbfueltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfueltype.FormattingEnabled = true;
            this.cmbfueltype.Location = new System.Drawing.Point(82, 17);
            this.cmbfueltype.Name = "cmbfueltype";
            this.cmbfueltype.Size = new System.Drawing.Size(162, 21);
            this.cmbfueltype.TabIndex = 6;
            this.cmbfueltype.SelectedIndexChanged += new System.EventHandler(this.cmbfueltype_SelectedIndexChanged);
            // 
            // cmbTanktruck
            // 
            this.cmbTanktruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTanktruck.FormattingEnabled = true;
            this.cmbTanktruck.Location = new System.Drawing.Point(322, 16);
            this.cmbTanktruck.Name = "cmbTanktruck";
            this.cmbTanktruck.Size = new System.Drawing.Size(162, 21);
            this.cmbTanktruck.TabIndex = 4;
            this.cmbTanktruck.SelectedIndexChanged += new System.EventHandler(this.cmbTanktruck_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tank Truck :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fuel Type :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lnkClose);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 55);
            this.panel1.TabIndex = 3;
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkColor = System.Drawing.Color.Red;
            this.lnkClose.Location = new System.Drawing.Point(1249, 5);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(47, 15);
            this.lnkClose.TabIndex = 6;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "CLOSE";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbfueltype);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbTanktruck);
            this.groupBox1.Controls.Add(this.cmbDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(208, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER DATE MAIN TANKER REFILL";
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(532, 16);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 21);
            this.cmbDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(659, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 55);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "FUEL LOG SHEET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MAIN TANKER";
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 30;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 90;
            // 
            // Drivers
            // 
            this.Drivers.HeaderText = "DRIVER\'S NAME";
            this.Drivers.Name = "Drivers";
            this.Drivers.ReadOnly = true;
            this.Drivers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Drivers.Width = 120;
            // 
            // EquipmentNo
            // 
            this.EquipmentNo.HeaderText = "EQUIPNO / MODEL / PLATENO";
            this.EquipmentNo.Name = "EquipmentNo";
            this.EquipmentNo.ReadOnly = true;
            this.EquipmentNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EquipmentNo.Width = 160;
            // 
            // NoLiters
            // 
            this.NoLiters.HeaderText = "NO. OF LITERS/REFILL";
            this.NoLiters.Name = "NoLiters";
            this.NoLiters.ReadOnly = true;
            this.NoLiters.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NoLiters.Width = 90;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "AVAILABILITY";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            this.Availability.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TankGauge
            // 
            this.TankGauge.HeaderText = "TANK GAUGE";
            this.TankGauge.Name = "TankGauge";
            this.TankGauge.ReadOnly = true;
            this.TankGauge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // site
            // 
            this.site.HeaderText = "SITE";
            this.site.Name = "site";
            this.site.ReadOnly = true;
            this.site.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.site.Width = 120;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "OPERATION";
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Operation.Width = 120;
            // 
            // PumpIncharge
            // 
            this.PumpIncharge.HeaderText = "PUMP INCHARGE";
            this.PumpIncharge.Name = "PumpIncharge";
            this.PumpIncharge.ReadOnly = true;
            this.PumpIncharge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PumpIncharge.Width = 120;
            // 
            // kmhr
            // 
            this.kmhr.HeaderText = "KM / HR";
            this.kmhr.Name = "kmhr";
            this.kmhr.ReadOnly = true;
            this.kmhr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kmhr.Width = 90;
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 130;
            // 
            // FuelLogSheetMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FuelLogSheetMain";
            this.Text = " ";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTankLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBaseongauge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTankTruck;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel lnkViewAll;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblpullout;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblTankRefill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTankLog;
        private System.Windows.Forms.ComboBox cmbfueltype;
        private System.Windows.Forms.ComboBox cmbTanktruck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoLiters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankGauge;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PumpIncharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmhr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}