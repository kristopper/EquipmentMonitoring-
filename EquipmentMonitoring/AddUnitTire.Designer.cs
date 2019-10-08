namespace EquipmentMonitoring
{
    partial class AddUnitTire
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
            this.dgvTire = new System.Windows.Forms.DataGridView();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.AllocationNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTire
            // 
            this.dgvTire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AllocationNo,
            this.Brand,
            this.SerialNo,
            this.Partsno});
            this.dgvTire.Location = new System.Drawing.Point(5, 24);
            this.dgvTire.Name = "dgvTire";
            this.dgvTire.Size = new System.Drawing.Size(600, 210);
            this.dgvTire.TabIndex = 25;
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkColor = System.Drawing.Color.Red;
            this.lnkClose.Location = new System.Drawing.Point(566, 1);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(43, 17);
            this.lnkClose.TabIndex = 26;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "Close";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkClose_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // Partsno
            // 
            this.Partsno.HeaderText = "Parts No.";
            this.Partsno.Name = "Partsno";
            this.Partsno.Width = 185;
            // 
            // AddUnitTire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 263);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.dgvTire);
            this.MaximizeBox = false;
            this.Name = "AddUnitTire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Unit Tire";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTire;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn AllocationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partsno;
    }
}