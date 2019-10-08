namespace EquipmentMonitoring.AllForm.Reports.OverAll
{
    partial class TruckOverallExpensesControl
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
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.chkUnit = new System.Windows.Forms.CheckBox();
            this.cmbUnitList = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbltire = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblexpenses = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblrepair = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblpms = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblfuelcost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblliters = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblhrs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblkm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTruckOverAllList = new System.Windows.Forms.DataGridView();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuelcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalExpenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnTruckOverallprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruckOverAllList)).BeginInit();
            this.SuspendLayout();
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.Checked = true;
            this.chkOthers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOthers.Location = new System.Drawing.Point(0, 595);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(57, 17);
            this.chkOthers.TabIndex = 125;
            this.chkOthers.Text = "Others";
            this.chkOthers.UseVisualStyleBackColor = true;
            this.chkOthers.Visible = false;
            // 
            // chkUnit
            // 
            this.chkUnit.AutoSize = true;
            this.chkUnit.Checked = true;
            this.chkUnit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnit.Location = new System.Drawing.Point(63, 594);
            this.chkUnit.Name = "chkUnit";
            this.chkUnit.Size = new System.Drawing.Size(50, 17);
            this.chkUnit.TabIndex = 124;
            this.chkUnit.Text = "Units";
            this.chkUnit.UseVisualStyleBackColor = true;
            this.chkUnit.Visible = false;
            // 
            // cmbUnitList
            // 
            this.cmbUnitList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitList.FormattingEnabled = true;
            this.cmbUnitList.Items.AddRange(new object[] {
            "Equipment No",
            "Model",
            "Plate No"});
            this.cmbUnitList.Location = new System.Drawing.Point(425, 6);
            this.cmbUnitList.Name = "cmbUnitList";
            this.cmbUnitList.Size = new System.Drawing.Size(128, 21);
            this.cmbUnitList.TabIndex = 123;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(559, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 20);
            this.txtSearch.TabIndex = 122;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(965, 580);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 121;
            this.label18.Text = "TIRE :";
            // 
            // lbltire
            // 
            this.lbltire.AutoSize = true;
            this.lbltire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltire.Location = new System.Drawing.Point(1000, 581);
            this.lbltire.Name = "lbltire";
            this.lbltire.Size = new System.Drawing.Size(13, 13);
            this.lbltire.TabIndex = 120;
            this.lbltire.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(933, 598);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 119;
            this.label16.Text = "EXPENSES :";
            // 
            // lblexpenses
            // 
            this.lblexpenses.AutoSize = true;
            this.lblexpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpenses.Location = new System.Drawing.Point(1000, 598);
            this.lblexpenses.Name = "lblexpenses";
            this.lblexpenses.Size = new System.Drawing.Size(13, 13);
            this.lblexpenses.TabIndex = 118;
            this.lblexpenses.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(648, 598);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 117;
            this.label14.Text = "REPAIR :";
            // 
            // lblrepair
            // 
            this.lblrepair.AutoSize = true;
            this.lblrepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepair.Location = new System.Drawing.Point(698, 599);
            this.lblrepair.Name = "lblrepair";
            this.lblrepair.Size = new System.Drawing.Size(13, 13);
            this.lblrepair.TabIndex = 116;
            this.lblrepair.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(665, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "PMS :";
            // 
            // lblpms
            // 
            this.lblpms.AutoSize = true;
            this.lblpms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpms.Location = new System.Drawing.Point(698, 581);
            this.lblpms.Name = "lblpms";
            this.lblpms.Size = new System.Drawing.Size(13, 13);
            this.lblpms.TabIndex = 114;
            this.lblpms.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 113;
            this.label10.Text = "FUEL COST :";
            // 
            // lblfuelcost
            // 
            this.lblfuelcost.AutoSize = true;
            this.lblfuelcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuelcost.Location = new System.Drawing.Point(398, 600);
            this.lblfuelcost.Name = "lblfuelcost";
            this.lblfuelcost.Size = new System.Drawing.Size(13, 13);
            this.lblfuelcost.TabIndex = 112;
            this.lblfuelcost.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 581);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "LITERS :";
            // 
            // lblliters
            // 
            this.lblliters.AutoSize = true;
            this.lblliters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliters.Location = new System.Drawing.Point(398, 582);
            this.lblliters.Name = "lblliters";
            this.lblliters.Size = new System.Drawing.Size(13, 13);
            this.lblliters.TabIndex = 110;
            this.lblliters.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "HRS :";
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrs.Location = new System.Drawing.Point(145, 599);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(13, 13);
            this.lblhrs.TabIndex = 108;
            this.lblhrs.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "KM :";
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkm.Location = new System.Drawing.Point(145, 581);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(13, 13);
            this.lblkm.TabIndex = 106;
            this.lblkm.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 105;
            this.label7.Text = "GRAND TOTAL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "TRUCK AND HEAVY EQUIPMENT OVERALL EXPENSES";
            // 
            // dgvTruckOverAllList
            // 
            this.dgvTruckOverAllList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruckOverAllList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentNo,
            this.Model,
            this.PlateNo,
            this.km,
            this.hrs,
            this.liters,
            this.Fuelcost,
            this.PMS,
            this.Repair,
            this.TIRE,
            this.TotalExpenses});
            this.dgvTruckOverAllList.Location = new System.Drawing.Point(3, 34);
            this.dgvTruckOverAllList.Name = "dgvTruckOverAllList";
            this.dgvTruckOverAllList.Size = new System.Drawing.Size(1162, 541);
            this.dgvTruckOverAllList.TabIndex = 103;
            // 
            // EquipmentNo
            // 
            this.EquipmentNo.HeaderText = "EQUIPMENT NO";
            this.EquipmentNo.Name = "EquipmentNo";
            this.EquipmentNo.ReadOnly = true;
            this.EquipmentNo.Width = 115;
            // 
            // Model
            // 
            this.Model.HeaderText = "MODEL";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 134;
            // 
            // PlateNo
            // 
            this.PlateNo.HeaderText = "PLATENO";
            this.PlateNo.Name = "PlateNo";
            this.PlateNo.ReadOnly = true;
            this.PlateNo.Width = 90;
            // 
            // km
            // 
            this.km.HeaderText = "KM";
            this.km.Name = "km";
            this.km.ReadOnly = true;
            this.km.Width = 95;
            // 
            // hrs
            // 
            this.hrs.HeaderText = "HRS";
            this.hrs.Name = "hrs";
            this.hrs.ReadOnly = true;
            this.hrs.Width = 80;
            // 
            // liters
            // 
            this.liters.HeaderText = "LITERS";
            this.liters.Name = "liters";
            this.liters.ReadOnly = true;
            // 
            // Fuelcost
            // 
            this.Fuelcost.HeaderText = "FUELCOST";
            this.Fuelcost.Name = "Fuelcost";
            this.Fuelcost.ReadOnly = true;
            // 
            // PMS
            // 
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            this.PMS.ReadOnly = true;
            // 
            // Repair
            // 
            this.Repair.HeaderText = "REPAIR";
            this.Repair.Name = "Repair";
            this.Repair.ReadOnly = true;
            // 
            // TIRE
            // 
            this.TIRE.HeaderText = "TIRE";
            this.TIRE.Name = "TIRE";
            this.TIRE.ReadOnly = true;
            // 
            // TotalExpenses
            // 
            this.TotalExpenses.HeaderText = "TOTAL EXPENSES";
            this.TotalExpenses.Name = "TotalExpenses";
            this.TotalExpenses.ReadOnly = true;
            this.TotalExpenses.Width = 105;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(783, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 102;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(858, 11);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(116, 13);
            this.lblMessage.TabIndex = 131;
            this.lblMessage.Text = "NO RECORD FOUND!";
            this.lblMessage.Visible = false;
            // 
            // btnTruckOverallprint
            // 
            this.btnTruckOverallprint.BackgroundImage = global::EquipmentMonitoring.Properties.Resources.Print_Button_printer_512;
            this.btnTruckOverallprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTruckOverallprint.Location = new System.Drawing.Point(1132, 4);
            this.btnTruckOverallprint.Name = "btnTruckOverallprint";
            this.btnTruckOverallprint.Size = new System.Drawing.Size(34, 28);
            this.btnTruckOverallprint.TabIndex = 132;
            this.btnTruckOverallprint.UseVisualStyleBackColor = true;
            // 
            // TruckOverallExpensesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTruckOverallprint);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.chkOthers);
            this.Controls.Add(this.chkUnit);
            this.Controls.Add(this.cmbUnitList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbltire);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblexpenses);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblrepair);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblpms);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblfuelcost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblliters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblhrs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTruckOverAllList);
            this.Controls.Add(this.btnSearch);
            this.Name = "TruckOverallExpensesControl";
            this.Size = new System.Drawing.Size(1167, 619);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruckOverAllList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cmbUnitList;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.CheckBox chkOthers;
        public System.Windows.Forms.CheckBox chkUnit;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lbltire;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label lblexpenses;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblrepair;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblpms;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblfuelcost;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblliters;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblhrs;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblkm;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvTruckOverAllList;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn liters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuelcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repair;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalExpenses;
        public System.Windows.Forms.Button btnTruckOverallprint;
    }
}
