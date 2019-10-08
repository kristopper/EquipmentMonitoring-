namespace EquipmentMonitoring
{
    partial class AddUnitBattery
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
            this.dgvBattery = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.AllocationNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBattery)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBattery
            // 
            this.dgvBattery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllocationNo,
            this.Brand,
            this.SerialNo,
            this.PartsNo});
            this.dgvBattery.Location = new System.Drawing.Point(5, 24);
            this.dgvBattery.Name = "dgvBattery";
            this.dgvBattery.Size = new System.Drawing.Size(600, 210);
            this.dgvBattery.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkColor = System.Drawing.Color.Red;
            this.lnkClose.Location = new System.Drawing.Point(566, 1);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(43, 17);
            this.lnkClose.TabIndex = 29;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "Close";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkClose_LinkClicked);
            // 
            // AllocationNo
            // 
            this.AllocationNo.HeaderText = "No";
            this.AllocationNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.AllocationNo.Name = "AllocationNo";
            this.AllocationNo.Width = 60;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Item";
            this.Brand.Name = "Brand";
            this.Brand.Width = 150;
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "Serial No.";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.Width = 160;
            // 
            // PartsNo
            // 
            this.PartsNo.HeaderText = "Parts No.";
            this.PartsNo.Name = "PartsNo";
            this.PartsNo.Width = 185;
            // 
            // AddUnitBattery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 263);
            this.Controls.Add(this.dgvBattery);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lnkClose);
            this.Name = "AddUnitBattery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Unit Battery";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBattery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBattery;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.DataGridViewComboBoxColumn AllocationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsNo;
    }
}