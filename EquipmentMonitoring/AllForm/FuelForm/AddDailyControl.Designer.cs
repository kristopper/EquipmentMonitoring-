namespace EquipmentMonitoring.AllForm.FuelForm
{
    partial class AddDailyControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDailySheet = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.Tank = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NolitersRefill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Others = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySheet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 28);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD DAILY SHEET ACTIVITY";
            // 
            // dgvDailySheet
            // 
            this.dgvDailySheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailySheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tank,
            this.Date,
            this.Equip,
            this.Drivers,
            this.NolitersRefill,
            this.KMS,
            this.HRS,
            this.ProjectSite,
            this.PumpIncharge,
            this.Others,
            this.Operation});
            this.dgvDailySheet.Location = new System.Drawing.Point(2, 34);
            this.dgvDailySheet.Name = "dgvDailySheet";
            this.dgvDailySheet.Size = new System.Drawing.Size(1162, 554);
            this.dgvDailySheet.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1089, 594);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Tank
            // 
            this.Tank.HeaderText = "";
            this.Tank.Name = "Tank";
            this.Tank.Width = 25;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 90;
            // 
            // Equip
            // 
            this.Equip.HeaderText = "Equip No / Model / Plate No";
            this.Equip.Name = "Equip";
            this.Equip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Equip.Width = 180;
            // 
            // Drivers
            // 
            this.Drivers.HeaderText = "DRIVER\'S NAME";
            this.Drivers.Name = "Drivers";
            this.Drivers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Drivers.Width = 180;
            // 
            // NolitersRefill
            // 
            this.NolitersRefill.HeaderText = "NO. OF LITERS / REFILLED";
            this.NolitersRefill.Name = "NolitersRefill";
            this.NolitersRefill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KMS
            // 
            this.KMS.HeaderText = "KMS";
            this.KMS.Name = "KMS";
            this.KMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HRS
            // 
            this.HRS.HeaderText = "HRS";
            this.HRS.Name = "HRS";
            this.HRS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProjectSite
            // 
            this.ProjectSite.HeaderText = "CONTRACT ID (PROJECT ID)";
            this.ProjectSite.Name = "ProjectSite";
            this.ProjectSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProjectSite.Width = 150;
            // 
            // PumpIncharge
            // 
            this.PumpIncharge.HeaderText = "PUMP-INCHARGE";
            this.PumpIncharge.Name = "PumpIncharge";
            this.PumpIncharge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PumpIncharge.Width = 180;
            // 
            // Others
            // 
            this.Others.HeaderText = "OTHERS";
            this.Others.Name = "Others";
            this.Others.Width = 60;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "OPERATION";
            this.Operation.Name = "Operation";
            this.Operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Operation.Width = 130;
            // 
            // AddDailyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDailySheet);
            this.Controls.Add(this.panel1);
            this.Name = "AddDailyControl";
            this.Size = new System.Drawing.Size(1167, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvDailySheet;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn NolitersRefill;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PumpIncharge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Others;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}
