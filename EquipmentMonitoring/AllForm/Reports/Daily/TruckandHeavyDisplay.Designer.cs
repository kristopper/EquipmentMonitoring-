namespace EquipmentMonitoring.AllForm.Reports.Daily
{
    partial class TruckandHeavyDisplay
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbUnitList = new System.Windows.Forms.ComboBox();
            this.dgvDailyList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMSTART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMEND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMRUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRUSED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOREFILL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUELCOST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTRKMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblfuelcost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblliters = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblhrs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblkm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(261, 6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDate.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(772, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(496, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 37;
            // 
            // cmbUnitList
            // 
            this.cmbUnitList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitList.FormattingEnabled = true;
            this.cmbUnitList.Items.AddRange(new object[] {
            "Equipment No",
            "Model",
            "Plate No"});
            this.cmbUnitList.Location = new System.Drawing.Point(362, 5);
            this.cmbUnitList.Name = "cmbUnitList";
            this.cmbUnitList.Size = new System.Drawing.Size(128, 21);
            this.cmbUnitList.TabIndex = 38;
            // 
            // dgvDailyList
            // 
            this.dgvDailyList.AllowUserToAddRows = false;
            this.dgvDailyList.AllowUserToDeleteRows = false;
            this.dgvDailyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.EquipmentNo,
            this.Model,
            this.PlateNo,
            this.KMSTART,
            this.KMEND,
            this.KMRUN,
            this.HRUSED,
            this.NOREFILL,
            this.FUELCOST,
            this.LTRKMS});
            this.dgvDailyList.Location = new System.Drawing.Point(2, 28);
            this.dgvDailyList.Name = "dgvDailyList";
            this.dgvDailyList.Size = new System.Drawing.Size(1162, 429);
            this.dgvDailyList.TabIndex = 39;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 5;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // EquipmentNo
            // 
            this.EquipmentNo.HeaderText = "EQUIPMENT NO.";
            this.EquipmentNo.Name = "EquipmentNo";
            this.EquipmentNo.ReadOnly = true;
            this.EquipmentNo.Width = 130;
            // 
            // Model
            // 
            this.Model.HeaderText = "MODEL";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 150;
            // 
            // PlateNo
            // 
            this.PlateNo.HeaderText = "PLATE NO.";
            this.PlateNo.Name = "PlateNo";
            this.PlateNo.ReadOnly = true;
            this.PlateNo.Width = 160;
            // 
            // KMSTART
            // 
            this.KMSTART.HeaderText = "KM START";
            this.KMSTART.Name = "KMSTART";
            this.KMSTART.ReadOnly = true;
            // 
            // KMEND
            // 
            this.KMEND.HeaderText = "KM END";
            this.KMEND.Name = "KMEND";
            this.KMEND.ReadOnly = true;
            // 
            // KMRUN
            // 
            this.KMRUN.HeaderText = "KM TRAVELLED";
            this.KMRUN.Name = "KMRUN";
            this.KMRUN.ReadOnly = true;
            // 
            // HRUSED
            // 
            this.HRUSED.HeaderText = "HOUR USED";
            this.HRUSED.Name = "HRUSED";
            this.HRUSED.ReadOnly = true;
            // 
            // NOREFILL
            // 
            this.NOREFILL.HeaderText = "NO. LTRS REFILL";
            this.NOREFILL.Name = "NOREFILL";
            this.NOREFILL.ReadOnly = true;
            // 
            // FUELCOST
            // 
            this.FUELCOST.HeaderText = "FUEL COST";
            this.FUELCOST.Name = "FUELCOST";
            this.FUELCOST.ReadOnly = true;
            // 
            // LTRKMS
            // 
            this.LTRKMS.HeaderText = "LTR/KMS";
            this.LTRKMS.Name = "LTRKMS";
            this.LTRKMS.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "TRUCK AND HEAVY EQUIPMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(1099, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "DAILY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(698, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "FUEL COST :";
            // 
            // lblfuelcost
            // 
            this.lblfuelcost.AutoSize = true;
            this.lblfuelcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuelcost.Location = new System.Drawing.Point(769, 462);
            this.lblfuelcost.Name = "lblfuelcost";
            this.lblfuelcost.Size = new System.Drawing.Size(13, 13);
            this.lblfuelcost.TabIndex = 103;
            this.lblfuelcost.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(489, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "LITERS :";
            // 
            // lblliters
            // 
            this.lblliters.AutoSize = true;
            this.lblliters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliters.Location = new System.Drawing.Point(539, 462);
            this.lblliters.Name = "lblliters";
            this.lblliters.Size = new System.Drawing.Size(13, 13);
            this.lblliters.TabIndex = 101;
            this.lblliters.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "HRS :";
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrs.Location = new System.Drawing.Point(327, 463);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(13, 13);
            this.lblhrs.TabIndex = 99;
            this.lblhrs.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "KM :";
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkm.Location = new System.Drawing.Point(142, 462);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(13, 13);
            this.lblkm.TabIndex = 97;
            this.lblkm.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 96;
            this.label7.Text = "GRAND TOTAL :";
            // 
            // TruckandHeavyDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblfuelcost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblliters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblhrs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDailyList);
            this.Controls.Add(this.cmbUnitList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpDate);
            this.Name = "TruckandHeavyDisplay";
            this.Size = new System.Drawing.Size(1167, 478);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.ComboBox cmbUnitList;
        public System.Windows.Forms.DataGridView dgvDailyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMSTART;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMEND;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMRUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRUSED;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOREFILL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUELCOST;
        private System.Windows.Forms.DataGridViewTextBoxColumn LTRKMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblfuelcost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblliters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblhrs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.Label label7;
    }
}
