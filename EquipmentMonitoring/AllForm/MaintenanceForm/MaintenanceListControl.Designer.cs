﻿namespace EquipmentMonitoring.AllForm.MaintenanceForm
{
    partial class MaintenanceListControl
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
            this.lblresult = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUnitList = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preventive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblresult.Location = new System.Drawing.Point(777, 48);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(107, 13);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "No Record Found";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(699, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AllowUserToDeleteRows = false;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EquipmentNo,
            this.Model,
            this.PlateNo,
            this.totalKm,
            this.TotalHrs,
            this.STATUS,
            this.Preventive});
            this.dgvMaintenance.Location = new System.Drawing.Point(176, 73);
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.Size = new System.Drawing.Size(813, 550);
            this.dgvMaintenance.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 28);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAINTENANCE LISTS";
            // 
            // cmbUnitList
            // 
            this.cmbUnitList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitList.FormattingEnabled = true;
            this.cmbUnitList.Items.AddRange(new object[] {
            "Equipment No",
            "Model",
            "Plate No"});
            this.cmbUnitList.Location = new System.Drawing.Point(288, 43);
            this.cmbUnitList.Name = "cmbUnitList";
            this.cmbUnitList.Size = new System.Drawing.Size(128, 21);
            this.cmbUnitList.TabIndex = 35;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(423, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 5;
            // 
            // EquipmentNo
            // 
            this.EquipmentNo.HeaderText = "EQUIPMENT NO.";
            this.EquipmentNo.Name = "EquipmentNo";
            this.EquipmentNo.ReadOnly = true;
            this.EquipmentNo.Width = 110;
            // 
            // Model
            // 
            this.Model.HeaderText = "MODEL";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 140;
            // 
            // PlateNo
            // 
            this.PlateNo.HeaderText = "PLATE NO.";
            this.PlateNo.Name = "PlateNo";
            this.PlateNo.ReadOnly = true;
            this.PlateNo.Width = 110;
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
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // Preventive
            // 
            this.Preventive.HeaderText = "PREVENTIVE MAINTENANCE";
            this.Preventive.Name = "Preventive";
            this.Preventive.ReadOnly = true;
            // 
            // MaintenanceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbUnitList);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvMaintenance);
            this.Name = "MaintenanceListControl";
            this.Size = new System.Drawing.Size(1167, 644);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblresult;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.DataGridView dgvMaintenance;
        public System.Windows.Forms.ComboBox cmbUnitList;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preventive;
    }
}
