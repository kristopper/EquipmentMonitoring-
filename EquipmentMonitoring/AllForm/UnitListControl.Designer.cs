namespace EquipmentMonitoring.AllForm
{
    partial class UnitListControl
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvUnitListitem = new System.Windows.Forms.DataGridView();
            this.cmbTruckType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbladdsingleUnit = new System.Windows.Forms.LinkLabel();
            this.cmbUnitList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFromMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Register = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusOfPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitListitem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(142, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(966, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvUnitListitem
            // 
            this.dgvUnitListitem.AllowUserToAddRows = false;
            this.dgvUnitListitem.AllowUserToDeleteRows = false;
            this.dgvUnitListitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitListitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EquipmentNo,
            this.Model,
            this.PlateNo,
            this.StatusOfPurchase,
            this.UnitPrice,
            this.DateofPurchase,
            this.Supplier,
            this.Register,
            this.TotalKM,
            this.TotalHrs});
            this.dgvUnitListitem.Location = new System.Drawing.Point(6, 76);
            this.dgvUnitListitem.Name = "dgvUnitListitem";
            this.dgvUnitListitem.Size = new System.Drawing.Size(1155, 563);
            this.dgvUnitListitem.TabIndex = 3;
            // 
            // cmbTruckType
            // 
            this.cmbTruckType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTruckType.FormattingEnabled = true;
            this.cmbTruckType.Items.AddRange(new object[] {
            "ALL"});
            this.cmbTruckType.Location = new System.Drawing.Point(418, 50);
            this.cmbTruckType.Name = "cmbTruckType";
            this.cmbTruckType.Size = new System.Drawing.Size(270, 21);
            this.cmbTruckType.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 28);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNIT LISTS";
            // 
            // lbladdsingleUnit
            // 
            this.lbladdsingleUnit.AutoSize = true;
            this.lbladdsingleUnit.Location = new System.Drawing.Point(1102, 56);
            this.lbladdsingleUnit.Name = "lbladdsingleUnit";
            this.lbladdsingleUnit.Size = new System.Drawing.Size(59, 13);
            this.lbladdsingleUnit.TabIndex = 33;
            this.lbladdsingleUnit.TabStop = true;
            this.lbladdsingleUnit.Text = "ADD UNIT";
            // 
            // cmbUnitList
            // 
            this.cmbUnitList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitList.FormattingEnabled = true;
            this.cmbUnitList.Items.AddRange(new object[] {
            "Equipment No",
            "Model",
            "Plate No"});
            this.cmbUnitList.Location = new System.Drawing.Point(8, 50);
            this.cmbUnitList.Name = "cmbUnitList";
            this.cmbUnitList.Size = new System.Drawing.Size(128, 21);
            this.cmbUnitList.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Register Expiration:";
            // 
            // cmbFromMonth
            // 
            this.cmbFromMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromMonth.FormattingEnabled = true;
            this.cmbFromMonth.Items.AddRange(new object[] {
            "",
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.cmbFromMonth.Location = new System.Drawing.Point(797, 50);
            this.cmbFromMonth.Name = "cmbFromMonth";
            this.cmbFromMonth.Size = new System.Drawing.Size(100, 21);
            this.cmbFromMonth.TabIndex = 36;
            // 
            // txtYear
            // 
            this.txtYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtYear.Location = new System.Drawing.Point(903, 51);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(58, 20);
            this.txtYear.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "MONTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "YEAR";
            // 
            // TotalHrs
            // 
            this.TotalHrs.HeaderText = "TOTAL HRS";
            this.TotalHrs.Name = "TotalHrs";
            this.TotalHrs.ReadOnly = true;
            // 
            // TotalKM
            // 
            this.TotalKM.HeaderText = "TOTAL KM";
            this.TotalKM.Name = "TotalKM";
            this.TotalKM.ReadOnly = true;
            // 
            // Register
            // 
            this.Register.HeaderText = "REGISTER EXPIRATION DATE";
            this.Register.Name = "Register";
            this.Register.ReadOnly = true;
            this.Register.Width = 185;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "SUPPLIER";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Supplier.Width = 145;
            // 
            // DateofPurchase
            // 
            this.DateofPurchase.HeaderText = "DATE OF PURCHASE";
            this.DateofPurchase.Name = "DateofPurchase";
            this.DateofPurchase.ReadOnly = true;
            this.DateofPurchase.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateofPurchase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateofPurchase.Width = 122;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UNIT PRICE";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 120;
            // 
            // StatusOfPurchase
            // 
            this.StatusOfPurchase.HeaderText = "STATUS OF PURCHASE";
            this.StatusOfPurchase.Name = "StatusOfPurchase";
            this.StatusOfPurchase.ReadOnly = true;
            this.StatusOfPurchase.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatusOfPurchase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StatusOfPurchase.Width = 135;
            // 
            // PlateNo
            // 
            this.PlateNo.HeaderText = "PLATE NO";
            this.PlateNo.Name = "PlateNo";
            this.PlateNo.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.Frozen = true;
            this.Model.HeaderText = "MODEL";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // EquipmentNo
            // 
            this.EquipmentNo.Frozen = true;
            this.EquipmentNo.HeaderText = "EQUIPMENT NO";
            this.EquipmentNo.Name = "EquipmentNo";
            this.EquipmentNo.ReadOnly = true;
            this.EquipmentNo.Width = 120;
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 5;
            // 
            // UnitListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cmbFromMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUnitList);
            this.Controls.Add(this.lbladdsingleUnit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTruckType);
            this.Controls.Add(this.dgvUnitListitem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "UnitListControl";
            this.Size = new System.Drawing.Size(1167, 644);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitListitem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel lbladdsingleUnit;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.DataGridView dgvUnitListitem;
        public System.Windows.Forms.ComboBox cmbTruckType;
        public System.Windows.Forms.ComboBox cmbUnitList;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbFromMonth;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusOfPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHrs;
    }
}
