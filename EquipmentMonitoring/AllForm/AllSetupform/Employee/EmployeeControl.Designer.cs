namespace EquipmentMonitoring.AllForm.AllSetupform.Employee
{
    partial class EmployeeControl
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
            this.panelmain = new System.Windows.Forms.Panel();
            this.cmbEmpSearchType = new System.Windows.Forms.ComboBox();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPERVISOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkAddemployee = new System.Windows.Forms.LinkLabel();
            this.EditEmployee = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPositionlist = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmployeeGroup = new System.Windows.Forms.GroupBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAddEmployee = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDSUPERVISOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneladd = new System.Windows.Forms.Panel();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.EditEmployee.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AddEmployeeGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddEmployee)).BeginInit();
            this.paneladd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.cmbEmpSearchType);
            this.panelmain.Controls.Add(this.dgvEmployeeList);
            this.panelmain.Controls.Add(this.lnkAddemployee);
            this.panelmain.Controls.Add(this.EditEmployee);
            this.panelmain.Controls.Add(this.btnSearch);
            this.panelmain.Controls.Add(this.txtSearch);
            this.panelmain.Controls.Add(this.panel1);
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(583, 643);
            this.panelmain.TabIndex = 1;
            // 
            // cmbEmpSearchType
            // 
            this.cmbEmpSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpSearchType.FormattingEnabled = true;
            this.cmbEmpSearchType.Items.AddRange(new object[] {
            "NAME",
            "POSITION",
            "SUPERVISOR"});
            this.cmbEmpSearchType.Location = new System.Drawing.Point(8, 37);
            this.cmbEmpSearchType.Name = "cmbEmpSearchType";
            this.cmbEmpSearchType.Size = new System.Drawing.Size(141, 21);
            this.cmbEmpSearchType.TabIndex = 12;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NAME,
            this.POSITION,
            this.SUPERVISOR});
            this.dgvEmployeeList.Location = new System.Drawing.Point(8, 63);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(565, 471);
            this.dgvEmployeeList.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 5;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 170;
            // 
            // POSITION
            // 
            this.POSITION.HeaderText = "POSITION";
            this.POSITION.Name = "POSITION";
            this.POSITION.ReadOnly = true;
            this.POSITION.Width = 177;
            // 
            // SUPERVISOR
            // 
            this.SUPERVISOR.HeaderText = "SUPERVISOR";
            this.SUPERVISOR.Name = "SUPERVISOR";
            this.SUPERVISOR.ReadOnly = true;
            this.SUPERVISOR.Width = 170;
            // 
            // lnkAddemployee
            // 
            this.lnkAddemployee.AutoSize = true;
            this.lnkAddemployee.Location = new System.Drawing.Point(484, 42);
            this.lnkAddemployee.Name = "lnkAddemployee";
            this.lnkAddemployee.Size = new System.Drawing.Size(91, 13);
            this.lnkAddemployee.TabIndex = 10;
            this.lnkAddemployee.TabStop = true;
            this.lnkAddemployee.Text = "ADD EMPLOYEE";
            // 
            // EditEmployee
            // 
            this.EditEmployee.Controls.Add(this.panel3);
            this.EditEmployee.Location = new System.Drawing.Point(6, 528);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(570, 113);
            this.EditEmployee.TabIndex = 9;
            this.EditEmployee.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmbPositionlist);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtSupervisor);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Controls.Add(this.lnkDelete);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Location = new System.Drawing.Point(2, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 101);
            this.panel3.TabIndex = 0;
            // 
            // cmbPositionlist
            // 
            this.cmbPositionlist.FormattingEnabled = true;
            this.cmbPositionlist.Location = new System.Drawing.Point(12, 62);
            this.cmbPositionlist.Name = "cmbPositionlist";
            this.cmbPositionlist.Size = new System.Drawing.Size(235, 21);
            this.cmbPositionlist.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "POSITION :";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSupervisor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSupervisor.Location = new System.Drawing.Point(259, 23);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(235, 20);
            this.txtSupervisor.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "SUPERVISOR :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(524, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "label5";
            this.lblId.Visible = false;
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.LinkColor = System.Drawing.Color.Red;
            this.lnkDelete.Location = new System.Drawing.Point(510, 5);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(49, 13);
            this.lnkDelete.TabIndex = 14;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "DELETE";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "NAME :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(338, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(155, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMPLOYEE LISTS";
            // 
            // AddEmployeeGroup
            // 
            this.AddEmployeeGroup.Controls.Add(this.btnAddCancel);
            this.AddEmployeeGroup.Controls.Add(this.btnAddSave);
            this.AddEmployeeGroup.Controls.Add(this.panel2);
            this.AddEmployeeGroup.Controls.Add(this.dgvAddEmployee);
            this.AddEmployeeGroup.Location = new System.Drawing.Point(4, 0);
            this.AddEmployeeGroup.Margin = new System.Windows.Forms.Padding(0);
            this.AddEmployeeGroup.Name = "AddEmployeeGroup";
            this.AddEmployeeGroup.Padding = new System.Windows.Forms.Padding(0);
            this.AddEmployeeGroup.Size = new System.Drawing.Size(570, 640);
            this.AddEmployeeGroup.TabIndex = 11;
            this.AddEmployeeGroup.TabStop = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(411, 582);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 8;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(492, 582);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddSave.TabIndex = 7;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 29);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "ADD EMPLOYEE";
            // 
            // dgvAddEmployee
            // 
            this.dgvAddEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ADDSUPERVISOR});
            this.dgvAddEmployee.Location = new System.Drawing.Point(3, 36);
            this.dgvAddEmployee.Name = "dgvAddEmployee";
            this.dgvAddEmployee.Size = new System.Drawing.Size(565, 538);
            this.dgvAddEmployee.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // ADDSUPERVISOR
            // 
            this.ADDSUPERVISOR.HeaderText = "SUPERVISOR";
            this.ADDSUPERVISOR.Name = "ADDSUPERVISOR";
            this.ADDSUPERVISOR.Width = 177;
            // 
            // paneladd
            // 
            this.paneladd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneladd.Controls.Add(this.AddEmployeeGroup);
            this.paneladd.Location = new System.Drawing.Point(582, 0);
            this.paneladd.Name = "paneladd";
            this.paneladd.Size = new System.Drawing.Size(583, 643);
            this.paneladd.TabIndex = 12;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.paneladd);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1167, 644);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.EditEmployee.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddEmployeeGroup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddEmployee)).EndInit();
            this.paneladd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelmain;
        public System.Windows.Forms.LinkLabel lnkAddemployee;
        public System.Windows.Forms.GroupBox EditEmployee;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.LinkLabel lnkDelete;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvEmployeeList;
        public System.Windows.Forms.GroupBox AddEmployeeGroup;
        public System.Windows.Forms.Button btnAddCancel;
        public System.Windows.Forms.Button btnAddSave;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvAddEmployee;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSupervisor;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbPositionlist;
        public System.Windows.Forms.Panel paneladd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDSUPERVISOR;
        public System.Windows.Forms.ComboBox cmbEmpSearchType;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPERVISOR;
    }
}
