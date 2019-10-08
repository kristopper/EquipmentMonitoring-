namespace EquipmentMonitoring
{
    partial class RefillEquipment_main
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnRefillEquipment = new System.Windows.Forms.Button();
            this.btnRefillMain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblLiters = new System.Windows.Forms.Label();
            this.Tankremaining = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.lblTankRefill = new System.Windows.Forms.Label();
            this.lblDieselCapacity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriversName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noltrrefilled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankGauge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmhr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(835, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back To MainForm";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Seach";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Refill Date";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(190, 19);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(95, 20);
            this.dtpTo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TO :";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(56, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(95, 20);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.Value = new System.DateTime(2018, 7, 16, 0, 0, 0, 0);
            // 
            // btnRefillEquipment
            // 
            this.btnRefillEquipment.Location = new System.Drawing.Point(755, 32);
            this.btnRefillEquipment.Name = "btnRefillEquipment";
            this.btnRefillEquipment.Size = new System.Drawing.Size(185, 22);
            this.btnRefillEquipment.TabIndex = 5;
            this.btnRefillEquipment.Text = "Refill Equipment and Tanker Truck Truck";
            this.btnRefillEquipment.UseVisualStyleBackColor = true;
            // 
            // btnRefillMain
            // 
            this.btnRefillMain.Location = new System.Drawing.Point(755, 3);
            this.btnRefillMain.Name = "btnRefillMain";
            this.btnRefillMain.Size = new System.Drawing.Size(75, 23);
            this.btnRefillMain.TabIndex = 6;
            this.btnRefillMain.Text = "Refill Main Tank";
            this.btnRefillMain.UseVisualStyleBackColor = true;
            this.btnRefillMain.Click += new System.EventHandler(this.btnRefillMain_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnRefillMain);
            this.panel2.Controls.Add(this.lblRemaining);
            this.panel2.Controls.Add(this.btnRefillEquipment);
            this.panel2.Controls.Add(this.lblLiters);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.Tankremaining);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvDetails);
            this.panel2.Controls.Add(this.lblTankRefill);
            this.panel2.Controls.Add(this.lblDieselCapacity);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 567);
            this.panel2.TabIndex = 6;
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(179, 540);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(41, 13);
            this.lblRemaining.TabIndex = 6;
            this.lblRemaining.Text = "label6";
            // 
            // lblLiters
            // 
            this.lblLiters.AutoSize = true;
            this.lblLiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiters.Location = new System.Drawing.Point(179, 515);
            this.lblLiters.Name = "lblLiters";
            this.lblLiters.Size = new System.Drawing.Size(41, 13);
            this.lblLiters.TabIndex = 5;
            this.lblLiters.Text = "label5";
            // 
            // Tankremaining
            // 
            this.Tankremaining.AutoSize = true;
            this.Tankremaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tankremaining.Location = new System.Drawing.Point(54, 540);
            this.Tankremaining.Name = "Tankremaining";
            this.Tankremaining.Size = new System.Drawing.Size(122, 13);
            this.Tankremaining.TabIndex = 4;
            this.Tankremaining.Text = "TANK REMAINING :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL LITERS PULL-OUT :";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.DriversName,
            this.PlateNo,
            this.noltrrefilled,
            this.Availability,
            this.TankGauge,
            this.PumpIncharge,
            //this.Site,
            this.Operation,
            this.kmhr});
            this.dgvDetails.Location = new System.Drawing.Point(3, 93);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(945, 411);
            this.dgvDetails.TabIndex = 2;
            // 
            // lblTankRefill
            // 
            this.lblTankRefill.AutoSize = true;
            this.lblTankRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTankRefill.Location = new System.Drawing.Point(550, 69);
            this.lblTankRefill.Name = "lblTankRefill";
            this.lblTankRefill.Size = new System.Drawing.Size(148, 13);
            this.lblTankRefill.TabIndex = 1;
            this.lblTankRefill.Text = "TANK REFILL - 14,000 L";
            // 
            // lblDieselCapacity
            // 
            this.lblDieselCapacity.AutoSize = true;
            this.lblDieselCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieselCapacity.Location = new System.Drawing.Point(96, 69);
            this.lblDieselCapacity.Name = "lblDieselCapacity";
            this.lblDieselCapacity.Size = new System.Drawing.Size(177, 13);
            this.lblDieselCapacity.TabIndex = 0;
            this.lblDieselCapacity.Text = "DIESEL CAPACITY - 16,000 L";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 503);
            this.panel1.TabIndex = 7;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.Width = 72;
            // 
            // DriversName
            // 
            this.DriversName.HeaderText = "DRIVER\'S NAME";
            this.DriversName.Name = "DriversName";
            // 
            // PlateNo
            // 
            this.PlateNo.HeaderText = "PLATE NO.";
            this.PlateNo.Name = "PlateNo";
            this.PlateNo.Width = 90;
            // 
            // noltrrefilled
            // 
            this.noltrrefilled.HeaderText = "NO. LITERS REFILLED";
            this.noltrrefilled.Name = "noltrrefilled";
            this.noltrrefilled.Width = 70;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "AVAILABILITY";
            this.Availability.Name = "Availability";
            this.Availability.Width = 80;
            // 
            // TankGauge
            // 
            this.TankGauge.HeaderText = "TANK GAUGE";
            this.TankGauge.Name = "TankGauge";
            this.TankGauge.Width = 90;
            // 
            // PumpIncharge
            // 
            this.PumpIncharge.HeaderText = "PUMP INCHARGE";
            this.PumpIncharge.Name = "PumpIncharge";
            // 
            // Site
            //// 
            //this.Site.HeaderText = "SITE";
            //this.Site.Name = "Site";
            //this.Site.Width = 120;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "OPERATION";
            this.Operation.Name = "Operation";
            // 
            // kmhr
            // 
            this.kmhr.HeaderText = "KM/HR";
            this.kmhr.Name = "kmhr";
            this.kmhr.Width = 80;
            // 
            // RefillEquipment_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 572);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Name = "RefillEquipment_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnRefillMain;
        private System.Windows.Forms.Button btnRefillEquipment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTankRefill;
        private System.Windows.Forms.Label lblDieselCapacity;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Label Tankremaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLiters;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriversName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn noltrrefilled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankGauge;
        private System.Windows.Forms.DataGridViewTextBoxColumn PumpIncharge;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmhr;
    }
}