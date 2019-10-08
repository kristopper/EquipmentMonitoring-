namespace EquipmentMonitoring
{
    partial class AddExpenses
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
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MILEAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRIVER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MECHANIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.EquipDetail,
            this.MILEAGE,
            this.Problem,
            this.Diagnosis,
            this.ITEM,
            this.PCS,
            this.DRIVER,
            this.MECHANIC,
            this.ProjectSite,
            this.Remarks,
            this.Purchase,
            this.PMS,
            this.Repair,
            this.Tire});
            this.dgvExpenses.Location = new System.Drawing.Point(5, 26);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(1289, 443);
            this.dgvExpenses.TabIndex = 0;
            this.dgvExpenses.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvExpenses_EditingControlShowing);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lnkClose);
            this.panel1.Controls.Add(this.dgvExpenses);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 504);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1217, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkColor = System.Drawing.Color.Red;
            this.lnkClose.Location = new System.Drawing.Point(1249, 4);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(47, 15);
            this.lnkClose.TabIndex = 1;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "CLOSE";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 90;
            // 
            // EquipDetail
            // 
            this.EquipDetail.HeaderText = "EQUIPNO / MODEL / PLATENO";
            this.EquipDetail.Name = "EquipDetail";
            this.EquipDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EquipDetail.Width = 150;
            // 
            // MILEAGE
            // 
            this.MILEAGE.HeaderText = "MILEAGE";
            this.MILEAGE.Name = "MILEAGE";
            // 
            // Problem
            // 
            this.Problem.HeaderText = "PROBLEM / ACTIVITY";
            this.Problem.Name = "Problem";
            this.Problem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Problem.Width = 160;
            // 
            // Diagnosis
            // 
            this.Diagnosis.HeaderText = "MECHANIC POSSIBLE CAUSE AND DIAGNOSIS / SOLUTION APPLIED / NEEDED";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Diagnosis.Width = 200;
            // 
            // ITEM
            // 
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            this.ITEM.Width = 120;
            // 
            // PCS
            // 
            this.PCS.HeaderText = "PCS";
            this.PCS.Name = "PCS";
            this.PCS.Width = 60;
            // 
            // DRIVER
            // 
            this.DRIVER.HeaderText = "DRIVER / OPERATOR";
            this.DRIVER.Name = "DRIVER";
            this.DRIVER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DRIVER.Width = 160;
            // 
            // MECHANIC
            // 
            this.MECHANIC.HeaderText = "MECHANIC / ELECTRICIAN";
            this.MECHANIC.Name = "MECHANIC";
            this.MECHANIC.Width = 160;
            // 
            // ProjectSite
            // 
            this.ProjectSite.HeaderText = "CONTRACT ID(PROJECT ID)";
            this.ProjectSite.Name = "ProjectSite";
            this.ProjectSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProjectSite.Width = 150;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "REMARKS";
            this.Remarks.Name = "Remarks";
            this.Remarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Remarks.Width = 170;
            // 
            // Purchase
            // 
            this.Purchase.FalseValue = "";
            this.Purchase.HeaderText = "PURCHASE";
            this.Purchase.Name = "Purchase";
            this.Purchase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Purchase.TrueValue = "1";
            this.Purchase.Width = 70;
            // 
            // PMS
            // 
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            // 
            // Repair
            // 
            this.Repair.HeaderText = "REPAIR";
            this.Repair.Name = "Repair";
            // 
            // Tire
            // 
            this.Tire.HeaderText = "TIRE";
            this.Tire.Name = "Tire";
            // 
            // AddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 508);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1323, 547);
            this.MinimumSize = new System.Drawing.Size(1323, 547);
            this.Name = "AddExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance & Repair Request Form";
            this.Load += new System.EventHandler(this.AddExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MILEAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRIVER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MECHANIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tire;
    }
}