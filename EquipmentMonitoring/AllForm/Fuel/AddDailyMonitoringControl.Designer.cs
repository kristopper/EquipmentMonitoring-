namespace EquipmentMonitoring.AllForm.Fuel
{
    partial class AddDailyMonitoringControl
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
            this.dgvDailySheet = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySheet)).BeginInit();
            this.SuspendLayout();
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
            this.dgvDailySheet.Location = new System.Drawing.Point(4, 44);
            this.dgvDailySheet.Name = "dgvDailySheet";
            this.dgvDailySheet.Size = new System.Drawing.Size(1145, 535);
            this.dgvDailySheet.TabIndex = 1;
            this.dgvDailySheet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDailySheet_EditingControlShowing);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1077, 583);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADD DAILY SHEET ACTIVITY";
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
            this.Equip.Width = 130;
            // 
            // Drivers
            // 
            this.Drivers.HeaderText = "DRIVER\'S NAME";
            this.Drivers.Name = "Drivers";
            this.Drivers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Drivers.Width = 109;
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
            this.ProjectSite.HeaderText = "PROJECT SITE";
            this.ProjectSite.Name = "ProjectSite";
            this.ProjectSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProjectSite.Width = 150;
            // 
            // PumpIncharge
            // 
            this.PumpIncharge.HeaderText = "PUMP-INCHARGE";
            this.PumpIncharge.Name = "PumpIncharge";
            this.PumpIncharge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PumpIncharge.Width = 120;
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
            // AddDailyMonitoringControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDailySheet);
            this.Name = "AddDailyMonitoringControl";
            this.Size = new System.Drawing.Size(1155, 618);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDailySheet;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label label1;
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
