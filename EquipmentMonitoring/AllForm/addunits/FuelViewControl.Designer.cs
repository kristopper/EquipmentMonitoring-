namespace EquipmentMonitoring.AllForm.addunits
{
    partial class FuelViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelViewControl));
            this.btnFSearch = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpFFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.btnFDelete = new System.Windows.Forms.Button();
            this.lblTotalUsed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDataMonitoring = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drivers_OptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmhrs_LastRefuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmhrs_duringRefuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kmhrs_Used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrskm_used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoLtrsRefill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ltr_kms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreventiveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pumpincharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalFuelCost = new System.Windows.Forms.Label();
            this.lblTotalRefill = new System.Windows.Forms.Label();
            this.btnUnitMaintenance = new System.Windows.Forms.Button();
            this.btnUnitDetailRefresh = new System.Windows.Forms.Button();
            this.btnUnitFuelPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMonitoring)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFSearch
            // 
            this.btnFSearch.Location = new System.Drawing.Point(326, 3);
            this.btnFSearch.Name = "btnFSearch";
            this.btnFSearch.Size = new System.Drawing.Size(75, 23);
            this.btnFSearch.TabIndex = 30;
            this.btnFSearch.Text = "Search";
            this.btnFSearch.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(190, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 27;
            this.label25.Text = "TO :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(45, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "FROM :";
            // 
            // dtpFFromDate
            // 
            this.dtpFFromDate.CustomFormat = "MM/dd/yyyy";
            this.dtpFFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFFromDate.Location = new System.Drawing.Point(89, 5);
            this.dtpFFromDate.Name = "dtpFFromDate";
            this.dtpFFromDate.Size = new System.Drawing.Size(95, 20);
            this.dtpFFromDate.TabIndex = 28;
            this.dtpFFromDate.Value = new System.DateTime(2019, 4, 3, 12, 25, 18, 0);
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.Location = new System.Drawing.Point(803, 7);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(17, 18);
            this.lblTotalHours.TabIndex = 24;
            this.lblTotalHours.Text = "0";
            // 
            // btnFDelete
            // 
            this.btnFDelete.Location = new System.Drawing.Point(1085, 2);
            this.btnFDelete.Name = "btnFDelete";
            this.btnFDelete.Size = new System.Drawing.Size(75, 23);
            this.btnFDelete.TabIndex = 23;
            this.btnFDelete.Text = "DELETE";
            this.btnFDelete.UseVisualStyleBackColor = true;
            // 
            // lblTotalUsed
            // 
            this.lblTotalUsed.AutoSize = true;
            this.lblTotalUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsed.Location = new System.Drawing.Point(543, 6);
            this.lblTotalUsed.Name = "lblTotalUsed";
            this.lblTotalUsed.Size = new System.Drawing.Size(17, 18);
            this.lblTotalUsed.TabIndex = 21;
            this.lblTotalUsed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Km Travelled :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(685, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Hour Used :";
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
            this.hrskm_used,
            this.NoLtrsRefill,
            this.FuelCost,
            this.Ltr_kms,
            this.PreventiveId,
            this.Pumpincharge,
            this.ContractId,
            this.PLocation,
            this.Source});
            this.dgvDataMonitoring.Location = new System.Drawing.Point(5, 31);
            this.dgvDataMonitoring.Name = "dgvDataMonitoring";
            this.dgvDataMonitoring.Size = new System.Drawing.Size(1155, 442);
            this.dgvDataMonitoring.TabIndex = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 5;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // Drivers_OptName
            // 
            this.Drivers_OptName.HeaderText = "Driver\'s/Operator\'s";
            this.Drivers_OptName.Name = "Drivers_OptName";
            this.Drivers_OptName.ReadOnly = true;
            this.Drivers_OptName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kmhrs_LastRefuel
            // 
            this.kmhrs_LastRefuel.HeaderText = "Km/Hour Meter Reading Last Refuel";
            this.kmhrs_LastRefuel.Name = "kmhrs_LastRefuel";
            this.kmhrs_LastRefuel.ReadOnly = true;
            this.kmhrs_LastRefuel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kmhrs_duringRefuel
            // 
            this.kmhrs_duringRefuel.HeaderText = "Km/Hour Meter Reading During Refuel";
            this.kmhrs_duringRefuel.Name = "kmhrs_duringRefuel";
            this.kmhrs_duringRefuel.ReadOnly = true;
            this.kmhrs_duringRefuel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Kmhrs_Used
            // 
            this.Kmhrs_Used.HeaderText = "Km Travelled";
            this.Kmhrs_Used.Name = "Kmhrs_Used";
            this.Kmhrs_Used.ReadOnly = true;
            this.Kmhrs_Used.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Kmhrs_Used.Width = 80;
            // 
            // hrskm_used
            // 
            this.hrskm_used.HeaderText = "Hour Used";
            this.hrskm_used.Name = "hrskm_used";
            this.hrskm_used.ReadOnly = true;
            this.hrskm_used.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hrskm_used.Width = 80;
            // 
            // NoLtrsRefill
            // 
            this.NoLtrsRefill.HeaderText = "No. Ltrs Refill";
            this.NoLtrsRefill.Name = "NoLtrsRefill";
            this.NoLtrsRefill.ReadOnly = true;
            this.NoLtrsRefill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NoLtrsRefill.Width = 64;
            // 
            // FuelCost
            // 
            this.FuelCost.HeaderText = "Fuel Cost";
            this.FuelCost.Name = "FuelCost";
            this.FuelCost.ReadOnly = true;
            this.FuelCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ltr_kms
            // 
            this.Ltr_kms.HeaderText = "Kms / Ltr";
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
            this.PreventiveId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PreventiveId.Width = 75;
            // 
            // Pumpincharge
            // 
            this.Pumpincharge.HeaderText = "Pump-Incharge";
            this.Pumpincharge.Name = "Pumpincharge";
            this.Pumpincharge.ReadOnly = true;
            this.Pumpincharge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContractId
            // 
            this.ContractId.HeaderText = "Contract ID";
            this.ContractId.Name = "ContractId";
            this.ContractId.ReadOnly = true;
            this.ContractId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PLocation
            // 
            this.PLocation.HeaderText = "Location";
            this.PLocation.Name = "PLocation";
            this.PLocation.ReadOnly = true;
            this.PLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PLocation.Width = 150;
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Width = 200;
            // 
            // dtpFToDate
            // 
            this.dtpFToDate.CustomFormat = "MM/dd/yyyy";
            this.dtpFToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFToDate.Location = new System.Drawing.Point(219, 5);
            this.dtpFToDate.Name = "dtpFToDate";
            this.dtpFToDate.Size = new System.Drawing.Size(95, 20);
            this.dtpFToDate.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Total Fuel Cost :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total Liters Refill :";
            // 
            // lblTotalFuelCost
            // 
            this.lblTotalFuelCost.AutoSize = true;
            this.lblTotalFuelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFuelCost.Location = new System.Drawing.Point(443, 476);
            this.lblTotalFuelCost.Name = "lblTotalFuelCost";
            this.lblTotalFuelCost.Size = new System.Drawing.Size(17, 18);
            this.lblTotalFuelCost.TabIndex = 35;
            this.lblTotalFuelCost.Text = "0";
            // 
            // lblTotalRefill
            // 
            this.lblTotalRefill.AutoSize = true;
            this.lblTotalRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRefill.Location = new System.Drawing.Point(122, 475);
            this.lblTotalRefill.Name = "lblTotalRefill";
            this.lblTotalRefill.Size = new System.Drawing.Size(17, 18);
            this.lblTotalRefill.TabIndex = 33;
            this.lblTotalRefill.Text = "0";
            // 
            // btnUnitMaintenance
            // 
            this.btnUnitMaintenance.Location = new System.Drawing.Point(949, 2);
            this.btnUnitMaintenance.Name = "btnUnitMaintenance";
            this.btnUnitMaintenance.Size = new System.Drawing.Size(85, 23);
            this.btnUnitMaintenance.TabIndex = 36;
            this.btnUnitMaintenance.Text = "Maintenance";
            this.btnUnitMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnUnitDetailRefresh
            // 
            this.btnUnitDetailRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnitDetailRefresh.BackgroundImage")));
            this.btnUnitDetailRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnitDetailRefresh.Location = new System.Drawing.Point(913, 2);
            this.btnUnitDetailRefresh.Name = "btnUnitDetailRefresh";
            this.btnUnitDetailRefresh.Size = new System.Drawing.Size(30, 24);
            this.btnUnitDetailRefresh.TabIndex = 45;
            this.btnUnitDetailRefresh.UseVisualStyleBackColor = true;
            // 
            // btnUnitFuelPrint
            // 
            this.btnUnitFuelPrint.BackgroundImage = global::EquipmentMonitoring.Properties.Resources.Print_Button_printer_512;
            this.btnUnitFuelPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnitFuelPrint.Location = new System.Drawing.Point(4, 1);
            this.btnUnitFuelPrint.Name = "btnUnitFuelPrint";
            this.btnUnitFuelPrint.Size = new System.Drawing.Size(34, 28);
            this.btnUnitFuelPrint.TabIndex = 53;
            this.btnUnitFuelPrint.UseVisualStyleBackColor = true;
            // 
            // FuelViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnUnitFuelPrint);
            this.Controls.Add(this.btnUnitDetailRefresh);
            this.Controls.Add(this.btnUnitMaintenance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalFuelCost);
            this.Controls.Add(this.lblTotalRefill);
            this.Controls.Add(this.dtpFToDate);
            this.Controls.Add(this.btnFSearch);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dgvDataMonitoring);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFFromDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.lblTotalUsed);
            this.Controls.Add(this.btnFDelete);
            this.Name = "FuelViewControl";
            this.Size = new System.Drawing.Size(1166, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMonitoring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnFSearch;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.DateTimePicker dtpFFromDate;
        public System.Windows.Forms.Label lblTotalHours;
        public System.Windows.Forms.Button btnFDelete;
        public System.Windows.Forms.Label lblTotalUsed;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgvDataMonitoring;
        public System.Windows.Forms.DateTimePicker dtpFToDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTotalFuelCost;
        public System.Windows.Forms.Label lblTotalRefill;
        public System.Windows.Forms.DataGridViewTextBoxColumn ID;
        public System.Windows.Forms.DataGridViewTextBoxColumn Date;
        public System.Windows.Forms.DataGridViewTextBoxColumn Drivers_OptName;
        public System.Windows.Forms.DataGridViewTextBoxColumn kmhrs_LastRefuel;
        public System.Windows.Forms.DataGridViewTextBoxColumn kmhrs_duringRefuel;
        public System.Windows.Forms.DataGridViewTextBoxColumn Kmhrs_Used;
        public System.Windows.Forms.DataGridViewTextBoxColumn hrskm_used;
        public System.Windows.Forms.DataGridViewTextBoxColumn NoLtrsRefill;
        public System.Windows.Forms.DataGridViewTextBoxColumn FuelCost;
        public System.Windows.Forms.DataGridViewTextBoxColumn Ltr_kms;
        public System.Windows.Forms.DataGridViewTextBoxColumn PreventiveId;
        public System.Windows.Forms.DataGridViewTextBoxColumn Pumpincharge;
        public System.Windows.Forms.DataGridViewTextBoxColumn ContractId;
        public System.Windows.Forms.DataGridViewTextBoxColumn PLocation;
        public System.Windows.Forms.DataGridViewTextBoxColumn Source;
        public System.Windows.Forms.Button btnUnitMaintenance;
        public System.Windows.Forms.Button btnUnitDetailRefresh;
        public System.Windows.Forms.Button btnUnitFuelPrint;
    }
}
