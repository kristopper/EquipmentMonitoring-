namespace EquipmentMonitoring.AllForm.Fuel
{
    partial class MainFuelLogControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnSve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1150, 525);
            this.dataGridView1.TabIndex = 0;
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
            this.Date.Width = 90;
            // 
            // Equip
            // 
            this.Equip.HeaderText = "Equip No / Model / Plate No";
            this.Equip.Name = "Equip";
            this.Equip.Width = 130;
            // 
            // Drivers
            // 
            this.Drivers.HeaderText = "DRIVER\'S NAME";
            this.Drivers.Name = "Drivers";
            this.Drivers.Width = 107;
            // 
            // NolitersRefill
            // 
            this.NolitersRefill.HeaderText = "NO. OF LITERS / REFILLED";
            this.NolitersRefill.Name = "NolitersRefill";
            // 
            // KMS
            // 
            this.KMS.HeaderText = "KMS";
            this.KMS.Name = "KMS";
            // 
            // HRS
            // 
            this.HRS.HeaderText = "HRS";
            this.HRS.Name = "HRS";
            // 
            // ProjectSite
            // 
            this.ProjectSite.HeaderText = "PROJECT SITE";
            this.ProjectSite.Name = "ProjectSite";
            this.ProjectSite.Width = 150;
            // 
            // PumpIncharge
            // 
            this.PumpIncharge.HeaderText = "PUMP-INCHARGE";
            this.PumpIncharge.Name = "PumpIncharge";
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
            this.Operation.Width = 130;
            // 
            // btnSve
            // 
            this.btnSve.Location = new System.Drawing.Point(1082, 573);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(75, 23);
            this.btnSve.TabIndex = 1;
            this.btnSve.Text = "SAVE";
            this.btnSve.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD DAILY SHEET ACTIVITY";
            // 
            // MainFuelLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainFuelLogControl";
            this.Size = new System.Drawing.Size(1163, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Label label1;
    }
}
