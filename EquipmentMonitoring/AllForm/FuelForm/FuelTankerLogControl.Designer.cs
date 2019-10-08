namespace EquipmentMonitoring.AllForm.FuelForm
{
    partial class FuelTankerLogControl
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
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblBaseongauge = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblpullout = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTankLog = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoLiters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadingGauge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projectsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbfueltype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTanktruck = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lnkViewAll = new System.Windows.Forms.LinkLabel();
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
            this.lblTTankAvailability = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFuelTankerLogprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTankLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(882, 600);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(0, 15);
            this.lblRemaining.TabIndex = 47;
            // 
            // lblBaseongauge
            // 
            this.lblBaseongauge.AutoSize = true;
            this.lblBaseongauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseongauge.Location = new System.Drawing.Point(297, 619);
            this.lblBaseongauge.Name = "lblBaseongauge";
            this.lblBaseongauge.Size = new System.Drawing.Size(0, 15);
            this.lblBaseongauge.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 619);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "LITER PULL OUT BASE ON TANKER GAUGE :";
            // 
            // lblpullout
            // 
            this.lblpullout.AutoSize = true;
            this.lblpullout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpullout.Location = new System.Drawing.Point(437, 599);
            this.lblpullout.Name = "lblpullout";
            this.lblpullout.Size = new System.Drawing.Size(0, 15);
            this.lblpullout.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "TOTAL LITERS PULL OUT BASE ON LITERS RECORDING SHEET :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(746, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "TANK REMAINING :";
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
            this.ReadingGauge,
            this.Projectsite,
            this.Operation,
            this.PumpIncharge,
            this.PreviousUsage,
            this.EquipNo,
            this.Model,
            this.PlateNo});
            this.dgvTankLog.Location = new System.Drawing.Point(4, 77);
            this.dgvTankLog.Name = "dgvTankLog";
            this.dgvTankLog.Size = new System.Drawing.Size(1158, 519);
            this.dgvTankLog.TabIndex = 41;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 5;
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
            // ReadingGauge
            // 
            this.ReadingGauge.HeaderText = "READING GAUGE";
            this.ReadingGauge.Name = "ReadingGauge";
            this.ReadingGauge.ReadOnly = true;
            this.ReadingGauge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Projectsite
            // 
            this.Projectsite.HeaderText = "PROJECT SITE";
            this.Projectsite.Name = "Projectsite";
            this.Projectsite.ReadOnly = true;
            this.Projectsite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Projectsite.Width = 120;
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
            // PreviousUsage
            // 
            this.PreviousUsage.HeaderText = "PREVIOUS USAGE";
            this.PreviousUsage.Name = "PreviousUsage";
            this.PreviousUsage.ReadOnly = true;
            this.PreviousUsage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PreviousUsage.Width = 90;
            // 
            // EquipNo
            // 
            this.EquipNo.HeaderText = "EquipNo";
            this.EquipNo.Name = "EquipNo";
            this.EquipNo.ReadOnly = true;
            this.EquipNo.Visible = false;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Visible = false;
            // 
            // PlateNo
            // 
            this.PlateNo.HeaderText = "PlateNo";
            this.PlateNo.Name = "PlateNo";
            this.PlateNo.ReadOnly = true;
            this.PlateNo.Visible = false;
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
            this.groupBox1.Controls.Add(this.lnkViewAll);
            this.groupBox1.Location = new System.Drawing.Point(261, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 48);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER DATE TANKER REFILL";
            // 
            // cmbfueltype
            // 
            this.cmbfueltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfueltype.FormattingEnabled = true;
            this.cmbfueltype.Location = new System.Drawing.Point(82, 17);
            this.cmbfueltype.Name = "cmbfueltype";
            this.cmbfueltype.Size = new System.Drawing.Size(162, 21);
            this.cmbfueltype.TabIndex = 6;
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
            // cmbTanktruck
            // 
            this.cmbTanktruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTanktruck.FormattingEnabled = true;
            this.cmbTanktruck.Location = new System.Drawing.Point(322, 16);
            this.cmbTanktruck.Name = "cmbTanktruck";
            this.cmbTanktruck.Size = new System.Drawing.Size(162, 21);
            this.cmbTanktruck.TabIndex = 4;
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(537, 16);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 21);
            this.cmbDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(664, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lnkViewAll
            // 
            this.lnkViewAll.AutoSize = true;
            this.lnkViewAll.Location = new System.Drawing.Point(776, 22);
            this.lnkViewAll.Name = "lnkViewAll";
            this.lnkViewAll.Size = new System.Drawing.Size(119, 13);
            this.lnkViewAll.TabIndex = 40;
            this.lnkViewAll.TabStop = true;
            this.lnkViewAll.Text = "View All Fuel Log Sheet";
            this.lnkViewAll.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 53);
            this.panel2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "FUEL LOG SHEET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TANKER TRUCK";
            // 
            // lblTankTruck
            // 
            this.lblTankTruck.AutoSize = true;
            this.lblTankTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankTruck.Location = new System.Drawing.Point(213, 59);
            this.lblTankTruck.Name = "lblTankTruck";
            this.lblTankTruck.Size = new System.Drawing.Size(0, 15);
            this.lblTankTruck.TabIndex = 39;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(50, 59);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 15);
            this.lblDate.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "Tank Name :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "DATE :";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(780, 59);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(0, 15);
            this.lblPrevious.TabIndex = 35;
            // 
            // lblTankRefill
            // 
            this.lblTankRefill.AutoSize = true;
            this.lblTankRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankRefill.Location = new System.Drawing.Point(494, 59);
            this.lblTankRefill.Name = "lblTankRefill";
            this.lblTankRefill.Size = new System.Drawing.Size(0, 15);
            this.lblTankRefill.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "PREVIOUS TANK REMAINING :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "TANK REFILL :";
            // 
            // lblTTankAvailability
            // 
            this.lblTTankAvailability.AutoSize = true;
            this.lblTTankAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTankAvailability.Location = new System.Drawing.Point(1014, 59);
            this.lblTTankAvailability.Name = "lblTTankAvailability";
            this.lblTTankAvailability.Size = new System.Drawing.Size(0, 15);
            this.lblTTankAvailability.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(872, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "TANK AVAILABILITY :";
            // 
            // btnFuelTankerLogprint
            // 
            this.btnFuelTankerLogprint.BackgroundImage = global::EquipmentMonitoring.Properties.Resources.Print_Button_printer_512;
            this.btnFuelTankerLogprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFuelTankerLogprint.Location = new System.Drawing.Point(1129, 48);
            this.btnFuelTankerLogprint.Name = "btnFuelTankerLogprint";
            this.btnFuelTankerLogprint.Size = new System.Drawing.Size(34, 28);
            this.btnFuelTankerLogprint.TabIndex = 50;
            this.btnFuelTankerLogprint.UseVisualStyleBackColor = true;
            // 
            // FuelTankerLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFuelTankerLogprint);
            this.Controls.Add(this.lblTTankAvailability);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblBaseongauge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblpullout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvTankLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTankTruck);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.lblTankRefill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FuelTankerLogControl";
            this.Size = new System.Drawing.Size(1167, 644);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTankLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblRemaining;
        public System.Windows.Forms.Label lblBaseongauge;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblpullout;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgvTankLog;
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
        public System.Windows.Forms.LinkLabel lnkViewAll;
        public System.Windows.Forms.Label lblTankTruck;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblPrevious;
        public System.Windows.Forms.Label lblTankRefill;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoLiters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadingGauge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projectsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PumpIncharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        public System.Windows.Forms.Label lblTTankAvailability;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnFuelTankerLogprint;
    }
}
