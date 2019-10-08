namespace EquipmentMonitoring.AllForm.Reports.OverAll
{
    partial class ProjectSiteOverAllControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonthFilter = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblpms = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblfuelcost = new System.Windows.Forms.Label();
            this.dgvProjectMonthlyList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuelcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalExpenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltire = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblliters = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblexpenses = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblrepair = new System.Windows.Forms.Label();
            this.btnProjectSiteOverallreport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMonthlyList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 31);
            this.panel1.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 22);
            this.label3.TabIndex = 104;
            this.label3.Text = "PROJECT SITE OVERALL EXPENSES";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnProjectSiteOverallreport);
            this.panel2.Controls.Add(this.lblMonthFilter);
            this.panel2.Controls.Add(this.lblMessage);
            this.panel2.Controls.Add(this.cmbProject);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblpms);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblfuelcost);
            this.panel2.Controls.Add(this.dgvProjectMonthlyList);
            this.panel2.Controls.Add(this.lbltire);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblliters);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lblexpenses);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblrepair);
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 585);
            this.panel2.TabIndex = 125;
            // 
            // lblMonthFilter
            // 
            this.lblMonthFilter.AutoSize = true;
            this.lblMonthFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthFilter.Location = new System.Drawing.Point(5, 12);
            this.lblMonthFilter.Name = "lblMonthFilter";
            this.lblMonthFilter.Size = new System.Drawing.Size(0, 17);
            this.lblMonthFilter.TabIndex = 131;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(817, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(116, 13);
            this.lblMessage.TabIndex = 130;
            this.lblMessage.Text = "NO RECORD FOUND!";
            this.lblMessage.Visible = false;
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Items.AddRange(new object[] {
            "Project No",
            "Project Site",
            "Project Date"});
            this.cmbProject.Location = new System.Drawing.Point(379, 8);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(128, 21);
            this.cmbProject.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 113;
            this.label10.Text = "FUEL COST :";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(513, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 20);
            this.txtSearch.TabIndex = 128;
            // 
            // lblpms
            // 
            this.lblpms.AutoSize = true;
            this.lblpms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpms.Location = new System.Drawing.Point(480, 544);
            this.lblpms.Name = "lblpms";
            this.lblpms.Size = new System.Drawing.Size(13, 13);
            this.lblpms.TabIndex = 114;
            this.lblpms.Text = "0";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(736, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 127;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblfuelcost
            // 
            this.lblfuelcost.AutoSize = true;
            this.lblfuelcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuelcost.Location = new System.Drawing.Point(179, 562);
            this.lblfuelcost.Name = "lblfuelcost";
            this.lblfuelcost.Size = new System.Drawing.Size(13, 13);
            this.lblfuelcost.TabIndex = 112;
            this.lblfuelcost.Text = "0";
            // 
            // dgvProjectMonthlyList
            // 
            this.dgvProjectMonthlyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectMonthlyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProjectNo,
            this.ProjectID,
            this.ProjectDate,
            this.liters,
            this.Fuelcost,
            this.PMS,
            this.Repair,
            this.TIRE,
            this.TotalExpenses});
            this.dgvProjectMonthlyList.Location = new System.Drawing.Point(4, 35);
            this.dgvProjectMonthlyList.Name = "dgvProjectMonthlyList";
            this.dgvProjectMonthlyList.Size = new System.Drawing.Size(1156, 503);
            this.dgvProjectMonthlyList.TabIndex = 103;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 5;
            // 
            // ProjectNo
            // 
            this.ProjectNo.HeaderText = "PROJECT NO.";
            this.ProjectNo.Name = "ProjectNo";
            this.ProjectNo.ReadOnly = true;
            this.ProjectNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProjectNo.Width = 120;
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "PROJECT SITE";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProjectID.Width = 120;
            // 
            // ProjectDate
            // 
            this.ProjectDate.HeaderText = "PROJECT DATE";
            this.ProjectDate.Name = "ProjectDate";
            this.ProjectDate.ReadOnly = true;
            this.ProjectDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProjectDate.Width = 120;
            // 
            // liters
            // 
            this.liters.HeaderText = "LITERS";
            this.liters.Name = "liters";
            this.liters.ReadOnly = true;
            this.liters.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.liters.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.liters.Width = 120;
            // 
            // Fuelcost
            // 
            this.Fuelcost.HeaderText = "FUELCOST";
            this.Fuelcost.Name = "Fuelcost";
            this.Fuelcost.ReadOnly = true;
            this.Fuelcost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fuelcost.Width = 130;
            // 
            // PMS
            // 
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            this.PMS.ReadOnly = true;
            this.PMS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PMS.Width = 120;
            // 
            // Repair
            // 
            this.Repair.HeaderText = "REPAIR";
            this.Repair.Name = "Repair";
            this.Repair.ReadOnly = true;
            this.Repair.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Repair.Width = 120;
            // 
            // TIRE
            // 
            this.TIRE.HeaderText = "TIRE";
            this.TIRE.Name = "TIRE";
            this.TIRE.ReadOnly = true;
            this.TIRE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TIRE.Width = 120;
            // 
            // TotalExpenses
            // 
            this.TotalExpenses.HeaderText = "TOTAL EXPENSES";
            this.TotalExpenses.Name = "TotalExpenses";
            this.TotalExpenses.ReadOnly = true;
            this.TotalExpenses.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalExpenses.Width = 138;
            // 
            // lbltire
            // 
            this.lbltire.AutoSize = true;
            this.lbltire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltire.Location = new System.Drawing.Point(821, 545);
            this.lbltire.Name = "lbltire";
            this.lbltire.Size = new System.Drawing.Size(13, 13);
            this.lbltire.TabIndex = 120;
            this.lbltire.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 105;
            this.label7.Text = "GRAND TOTAL :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "LITERS :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(429, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 117;
            this.label14.Text = "REPAIR :";
            // 
            // lblliters
            // 
            this.lblliters.AutoSize = true;
            this.lblliters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliters.Location = new System.Drawing.Point(179, 544);
            this.lblliters.Name = "lblliters";
            this.lblliters.Size = new System.Drawing.Size(13, 13);
            this.lblliters.TabIndex = 110;
            this.lblliters.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(785, 545);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 121;
            this.label18.Text = "TIRE :";
            // 
            // lblexpenses
            // 
            this.lblexpenses.AutoSize = true;
            this.lblexpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpenses.Location = new System.Drawing.Point(821, 563);
            this.lblexpenses.Name = "lblexpenses";
            this.lblexpenses.Size = new System.Drawing.Size(13, 13);
            this.lblexpenses.TabIndex = 118;
            this.lblexpenses.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(715, 562);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 119;
            this.label16.Text = "TOTAL EXPENSES :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(446, 544);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "PMS :";
            // 
            // lblrepair
            // 
            this.lblrepair.AutoSize = true;
            this.lblrepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepair.Location = new System.Drawing.Point(480, 562);
            this.lblrepair.Name = "lblrepair";
            this.lblrepair.Size = new System.Drawing.Size(13, 13);
            this.lblrepair.TabIndex = 116;
            this.lblrepair.Text = "0";
            // 
            // btnProjectSiteOverallreport
            // 
            this.btnProjectSiteOverallreport.BackgroundImage = global::EquipmentMonitoring.Properties.Resources.Print_Button_printer_512;
            this.btnProjectSiteOverallreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProjectSiteOverallreport.Location = new System.Drawing.Point(1126, 5);
            this.btnProjectSiteOverallreport.Name = "btnProjectSiteOverallreport";
            this.btnProjectSiteOverallreport.Size = new System.Drawing.Size(34, 28);
            this.btnProjectSiteOverallreport.TabIndex = 132;
            this.btnProjectSiteOverallreport.UseVisualStyleBackColor = true;
            // 
            // ProjectSiteOverAllControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectSiteOverAllControl";
            this.Size = new System.Drawing.Size(1167, 619);
            this.Load += new System.EventHandler(this.ProjectSiteOverAllControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMonthlyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblMonthFilter;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.ComboBox cmbProject;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label lblpms;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Label lblfuelcost;
        public System.Windows.Forms.DataGridView dgvProjectMonthlyList;
        public System.Windows.Forms.Label lbltire;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblliters;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lblexpenses;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblrepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn liters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuelcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repair;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalExpenses;
        public System.Windows.Forms.Button btnProjectSiteOverallreport;
    }
}
