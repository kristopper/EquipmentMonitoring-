namespace EquipmentMonitoring.AllForm.Fuel
{
    partial class FuelLogMainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelLogMainControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbfueltype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTanktruck = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTankTruck = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblTankRefill = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkViewAll = new System.Windows.Forms.LinkLabel();
            this.dgvTankLog = new System.Windows.Forms.DataGridView();
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
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblpullout = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefreshMaintenancelist = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTankLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshMaintenancelist);
            this.groupBox1.Controls.Add(this.cmbfueltype);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbTanktruck);
            this.groupBox1.Controls.Add(this.cmbDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(288, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER DATE MAIN TANKER REFILL";
            // 
            // cmbfueltype
            // 
            this.cmbfueltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfueltype.FormattingEnabled = true;
            this.cmbfueltype.Location = new System.Drawing.Point(82, 18);
            this.cmbfueltype.Name = "cmbfueltype";
            this.cmbfueltype.Size = new System.Drawing.Size(162, 21);
            this.cmbfueltype.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fuel Type :";
            // 
            // cmbTanktruck
            // 
            this.cmbTanktruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTanktruck.FormattingEnabled = true;
            this.cmbTanktruck.Location = new System.Drawing.Point(322, 17);
            this.cmbTanktruck.Name = "cmbTanktruck";
            this.cmbTanktruck.Size = new System.Drawing.Size(162, 21);
            this.cmbTanktruck.TabIndex = 4;
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(532, 17);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 21);
            this.cmbDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tank Truck :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(659, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 51);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "FUEL LOG SHEET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MAIN TANKER";
            // 
            // lblTankTruck
            // 
            this.lblTankTruck.AutoSize = true;
            this.lblTankTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankTruck.Location = new System.Drawing.Point(247, 66);
            this.lblTankTruck.Name = "lblTankTruck";
            this.lblTankTruck.Size = new System.Drawing.Size(41, 15);
            this.lblTankTruck.TabIndex = 21;
            this.lblTankTruck.Text = "label9";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(53, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "label8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(161, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tank Truck :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "DATE :";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(880, 66);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(41, 15);
            this.lblPrevious.TabIndex = 17;
            this.lblPrevious.Text = "label9";
            // 
            // lblTankRefill
            // 
            this.lblTankRefill.AutoSize = true;
            this.lblTankRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankRefill.Location = new System.Drawing.Point(546, 66);
            this.lblTankRefill.Name = "lblTankRefill";
            this.lblTankRefill.Size = new System.Drawing.Size(41, 15);
            this.lblTankRefill.TabIndex = 16;
            this.lblTankRefill.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "PREVIOUS TANK REMAINING :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "TANK REFILL :";
            // 
            // lnkViewAll
            // 
            this.lnkViewAll.AutoSize = true;
            this.lnkViewAll.Location = new System.Drawing.Point(1037, 68);
            this.lnkViewAll.Name = "lnkViewAll";
            this.lnkViewAll.Size = new System.Drawing.Size(119, 13);
            this.lnkViewAll.TabIndex = 22;
            this.lnkViewAll.TabStop = true;
            this.lnkViewAll.Text = "View All Fuel Log Sheet";
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
            this.dgvTankLog.Location = new System.Drawing.Point(3, 84);
            this.dgvTankLog.Name = "dgvTankLog";
            this.dgvTankLog.Size = new System.Drawing.Size(1149, 509);
            this.dgvTankLog.TabIndex = 23;
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
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(989, 596);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(48, 15);
            this.lblRemaining.TabIndex = 27;
            this.lblRemaining.Text = "label11";
            // 
            // lblpullout
            // 
            this.lblpullout.AutoSize = true;
            this.lblpullout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpullout.Location = new System.Drawing.Point(367, 596);
            this.lblpullout.Name = "lblpullout";
            this.lblpullout.Size = new System.Drawing.Size(48, 15);
            this.lblpullout.TabIndex = 26;
            this.lblpullout.Text = "label10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(853, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "TANK REMAINING :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "TOTAL LITERS PULL OUT BASE ON LITERS PULL-OUT :";
            // 
            // btnRefreshMaintenancelist
            // 
            this.btnRefreshMaintenancelist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshMaintenancelist.BackgroundImage")));
            this.btnRefreshMaintenancelist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshMaintenancelist.Location = new System.Drawing.Point(746, 15);
            this.btnRefreshMaintenancelist.Name = "btnRefreshMaintenancelist";
            this.btnRefreshMaintenancelist.Size = new System.Drawing.Size(30, 24);
            this.btnRefreshMaintenancelist.TabIndex = 10;
            this.btnRefreshMaintenancelist.UseVisualStyleBackColor = true;
            // 
            // FuelLogMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblpullout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTankLog);
            this.Controls.Add(this.lnkViewAll);
            this.Controls.Add(this.lblTankTruck);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.lblTankRefill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "FuelLogMainControl";
            this.Size = new System.Drawing.Size(1155, 618);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTankLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbfueltype;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cmbTanktruck;
        public System.Windows.Forms.ComboBox cmbDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTankTruck;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblPrevious;
        public System.Windows.Forms.Label lblTankRefill;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.LinkLabel lnkViewAll;
        public System.Windows.Forms.DataGridView dgvTankLog;
        public System.Windows.Forms.Label lblRemaining;
        public System.Windows.Forms.Label lblpullout;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridViewTextBoxColumn Id;
        public System.Windows.Forms.DataGridViewTextBoxColumn Date;
        public System.Windows.Forms.DataGridViewTextBoxColumn Drivers;
        public System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        public System.Windows.Forms.DataGridViewTextBoxColumn NoLiters;
        public System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        public System.Windows.Forms.DataGridViewTextBoxColumn TankGauge;
        public System.Windows.Forms.DataGridViewTextBoxColumn site;
        public System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        public System.Windows.Forms.DataGridViewTextBoxColumn PumpIncharge;
        public System.Windows.Forms.DataGridViewTextBoxColumn kmhr;
        public System.Windows.Forms.DataGridViewTextBoxColumn Status;
        public System.Windows.Forms.Button btnRefreshMaintenancelist;
    }
}
