namespace EquipmentMonitoring
{
    partial class MaintenanceList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preventive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvMaintenance);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 499);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblresult);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.txtValue);
            this.panel2.Controls.Add(this.cmbList);
            this.panel2.Location = new System.Drawing.Point(6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 40);
            this.panel2.TabIndex = 2;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblresult.Location = new System.Drawing.Point(396, 12);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(107, 13);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "No Record Found";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(314, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(832, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(139, 4);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(169, 25);
            this.txtValue.TabIndex = 1;
            this.txtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue_keydown);
            // 
            // cmbList
            // 
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Items.AddRange(new object[] {
            "Equipment No",
            "Model",
            "Plate No"});
            this.cmbList.Location = new System.Drawing.Point(12, 5);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(115, 21);
            this.cmbList.TabIndex = 0;
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AllowUserToDeleteRows = false;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.EquipmentNo,
            this.Model,
            this.PlateNo,
            this.totalKm,
            this.TotalHrs,
            this.Preventive});
            this.dgvMaintenance.Location = new System.Drawing.Point(6, 47);
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.Size = new System.Drawing.Size(907, 445);
            this.dgvMaintenance.TabIndex = 0;
            this.dgvMaintenance.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaintenance_CellContentDoubleClick);
            this.dgvMaintenance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaintenance_CellDoubleClick);
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
            // totalKm
            // 
            this.totalKm.HeaderText = "TOTAL KMS USED";
            this.totalKm.Name = "totalKm";
            this.totalKm.ReadOnly = true;
            this.totalKm.Width = 112;
            // 
            // TotalHrs
            // 
            this.TotalHrs.HeaderText = "TOTAL HRS USED";
            this.TotalHrs.Name = "TotalHrs";
            this.TotalHrs.ReadOnly = true;
            this.TotalHrs.Width = 112;
            // 
            // Preventive
            // 
            this.Preventive.HeaderText = "PREVENTIVE MAINTENANCE";
            this.Preventive.Name = "Preventive";
            // 
            // MaintenanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 505);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(942, 544);
            this.MinimumSize = new System.Drawing.Size(845, 544);
            this.Name = "MaintenanceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance List";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preventive;
    }
}