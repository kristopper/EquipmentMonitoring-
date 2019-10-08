namespace EquipmentMonitoring.AllForm.addunits
{
    partial class ExpensesViewControl
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
            this.dgvEMaintenance = new System.Windows.Forms.DataGridView();
            this.cmbESubCategory = new System.Windows.Forms.ComboBox();
            this.cmbECategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnESearch = new System.Windows.Forms.Button();
            this.dtpEToDate = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpEFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnEDelete = new System.Windows.Forms.Button();
            this.btnUnitExpensesPrint = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MILEAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRIVER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MECHANIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPAIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRACTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEMaintenance
            // 
            this.dgvEMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Date,
            this.MILEAGE,
            this.ITEM,
            this.PCS,
            this.DRIVER,
            this.MECHANIC,
            this.Category,
            this.SubCategory,
            this.Problem,
            this.Diagnosis,
            this.PMS,
            this.REPAIR,
            this.TIRE,
            this.DateCompleted,
            this.Remarks,
            this.ProjectSite,
            this.CONTRACTID});
            this.dgvEMaintenance.Location = new System.Drawing.Point(3, 29);
            this.dgvEMaintenance.Name = "dgvEMaintenance";
            this.dgvEMaintenance.Size = new System.Drawing.Size(1156, 459);
            this.dgvEMaintenance.TabIndex = 35;
            // 
            // cmbESubCategory
            // 
            this.cmbESubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbESubCategory.FormattingEnabled = true;
            this.cmbESubCategory.Location = new System.Drawing.Point(640, 4);
            this.cmbESubCategory.Name = "cmbESubCategory";
            this.cmbESubCategory.Size = new System.Drawing.Size(169, 21);
            this.cmbESubCategory.TabIndex = 34;
            // 
            // cmbECategory
            // 
            this.cmbECategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbECategory.FormattingEnabled = true;
            this.cmbECategory.Location = new System.Drawing.Point(388, 4);
            this.cmbECategory.Name = "cmbECategory";
            this.cmbECategory.Size = new System.Drawing.Size(163, 21);
            this.cmbECategory.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Sub-Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Category :";
            // 
            // btnESearch
            // 
            this.btnESearch.Location = new System.Drawing.Point(815, 2);
            this.btnESearch.Name = "btnESearch";
            this.btnESearch.Size = new System.Drawing.Size(75, 24);
            this.btnESearch.TabIndex = 30;
            this.btnESearch.Text = "Search";
            this.btnESearch.UseVisualStyleBackColor = true;
            // 
            // dtpEToDate
            // 
            this.dtpEToDate.CustomFormat = "MM/dd/yyyy";
            this.dtpEToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEToDate.Location = new System.Drawing.Point(217, 4);
            this.dtpEToDate.Name = "dtpEToDate";
            this.dtpEToDate.Size = new System.Drawing.Size(95, 20);
            this.dtpEToDate.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(188, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 27;
            this.label25.Text = "TO :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(44, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "FROM :";
            // 
            // dtpEFromDate
            // 
            this.dtpEFromDate.CustomFormat = "MM/dd/yyyy";
            this.dtpEFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEFromDate.Location = new System.Drawing.Point(88, 4);
            this.dtpEFromDate.Name = "dtpEFromDate";
            this.dtpEFromDate.Size = new System.Drawing.Size(95, 20);
            this.dtpEFromDate.TabIndex = 28;
            // 
            // btnEDelete
            // 
            this.btnEDelete.Location = new System.Drawing.Point(1084, 1);
            this.btnEDelete.Name = "btnEDelete";
            this.btnEDelete.Size = new System.Drawing.Size(75, 23);
            this.btnEDelete.TabIndex = 23;
            this.btnEDelete.Text = "DELETE";
            this.btnEDelete.UseVisualStyleBackColor = true;
            // 
            // btnUnitExpensesPrint
            // 
            this.btnUnitExpensesPrint.BackgroundImage = global::EquipmentMonitoring.Properties.Resources.Print_Button_printer_512;
            this.btnUnitExpensesPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnitExpensesPrint.Location = new System.Drawing.Point(2, 0);
            this.btnUnitExpensesPrint.Name = "btnUnitExpensesPrint";
            this.btnUnitExpensesPrint.Size = new System.Drawing.Size(34, 28);
            this.btnUnitExpensesPrint.TabIndex = 54;
            this.btnUnitExpensesPrint.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 5;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 90;
            // 
            // MILEAGE
            // 
            this.MILEAGE.Frozen = true;
            this.MILEAGE.HeaderText = "MILEAGE";
            this.MILEAGE.Name = "MILEAGE";
            this.MILEAGE.ReadOnly = true;
            // 
            // ITEM
            // 
            this.ITEM.Frozen = true;
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            // 
            // PCS
            // 
            this.PCS.Frozen = true;
            this.PCS.HeaderText = "PCS";
            this.PCS.Name = "PCS";
            this.PCS.ReadOnly = true;
            // 
            // DRIVER
            // 
            this.DRIVER.Frozen = true;
            this.DRIVER.HeaderText = "DRIVER / OPERATOR";
            this.DRIVER.Name = "DRIVER";
            this.DRIVER.ReadOnly = true;
            // 
            // MECHANIC
            // 
            this.MECHANIC.Frozen = true;
            this.MECHANIC.HeaderText = "MECHANIC / ELECTRICIAN";
            this.MECHANIC.Name = "MECHANIC";
            this.MECHANIC.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "CATEGORY";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SubCategory
            // 
            this.SubCategory.HeaderText = "SUBCATEGORY";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            this.SubCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Problem
            // 
            this.Problem.HeaderText = "PROBLEM";
            this.Problem.Name = "Problem";
            this.Problem.ReadOnly = true;
            this.Problem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Problem.Width = 200;
            // 
            // Diagnosis
            // 
            this.Diagnosis.HeaderText = "MECHANIC POSSIBLE CAUSE/DIAGNOSIS";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            this.Diagnosis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Diagnosis.Width = 200;
            // 
            // PMS
            // 
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            this.PMS.ReadOnly = true;
            this.PMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // REPAIR
            // 
            this.REPAIR.HeaderText = "REPAIR";
            this.REPAIR.Name = "REPAIR";
            this.REPAIR.ReadOnly = true;
            this.REPAIR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TIRE
            // 
            this.TIRE.HeaderText = "TIRE";
            this.TIRE.Name = "TIRE";
            this.TIRE.ReadOnly = true;
            this.TIRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateCompleted
            // 
            this.DateCompleted.HeaderText = "DATE COMPLETED";
            this.DateCompleted.Name = "DateCompleted";
            this.DateCompleted.ReadOnly = true;
            this.DateCompleted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "REMARKS";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProjectSite
            // 
            this.ProjectSite.HeaderText = "PROJECT SITE";
            this.ProjectSite.Name = "ProjectSite";
            this.ProjectSite.ReadOnly = true;
            this.ProjectSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CONTRACTID
            // 
            this.CONTRACTID.HeaderText = "CONTRACT ID";
            this.CONTRACTID.Name = "CONTRACTID";
            this.CONTRACTID.ReadOnly = true;
            this.CONTRACTID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CONTRACTID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExpensesViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnUnitExpensesPrint);
            this.Controls.Add(this.dgvEMaintenance);
            this.Controls.Add(this.cmbESubCategory);
            this.Controls.Add(this.dtpEFromDate);
            this.Controls.Add(this.cmbECategory);
            this.Controls.Add(this.btnEDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnESearch);
            this.Controls.Add(this.dtpEToDate);
            this.Name = "ExpensesViewControl";
            this.Size = new System.Drawing.Size(1166, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMaintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnESearch;
        public System.Windows.Forms.DateTimePicker dtpEToDate;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.DateTimePicker dtpEFromDate;
        public System.Windows.Forms.Button btnEDelete;
        public System.Windows.Forms.ComboBox cmbESubCategory;
        public System.Windows.Forms.ComboBox cmbECategory;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgvEMaintenance;
        public System.Windows.Forms.Button btnUnitExpensesPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MILEAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRIVER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MECHANIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPAIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRACTID;
    }
}
