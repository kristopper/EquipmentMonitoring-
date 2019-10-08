namespace EquipmentMonitoring.AllForm.AllSetupform.ProjectSite
{
    partial class ProjectSiteControl
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.EditGroup = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProjectDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjectSite = new System.Windows.Forms.TextBox();
            this.lnkAddProject = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProjectList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddGroup = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.dgvAddProjectList = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.EditGroup.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.AddGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProjectList)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cmbProject);
            this.panel1.Controls.Add(this.EditGroup);
            this.panel1.Controls.Add(this.lnkAddProject);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgvProjectList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 644);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(143, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 20);
            this.txtSearch.TabIndex = 131;
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Items.AddRange(new object[] {
            "Project No",
            "Project Site",
            "Project Date"});
            this.cmbProject.Location = new System.Drawing.Point(11, 32);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(128, 21);
            this.cmbProject.TabIndex = 130;
            // 
            // EditGroup
            // 
            this.EditGroup.Controls.Add(this.panel6);
            this.EditGroup.Location = new System.Drawing.Point(2, 532);
            this.EditGroup.Name = "EditGroup";
            this.EditGroup.Size = new System.Drawing.Size(581, 113);
            this.EditGroup.TabIndex = 9;
            this.EditGroup.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblid);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.lnkDelete);
            this.panel6.Controls.Add(this.btnEditCancel);
            this.panel6.Controls.Add(this.btnEditSave);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtProjectDate);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtProjectNo);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtProjectSite);
            this.panel6.Location = new System.Drawing.Point(0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(585, 101);
            this.panel6.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(7, 6);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 16;
            this.lblid.Text = "label8";
            this.lblid.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "EDIT AND DELETE PROJECT SITE";
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(527, 4);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(49, 13);
            this.lnkDelete.TabIndex = 10;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "DELETE";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(417, 63);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 10;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(498, 63);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditSave.TabIndex = 9;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "PROJECT DATE :";
            // 
            // txtProjectDate
            // 
            this.txtProjectDate.Location = new System.Drawing.Point(417, 38);
            this.txtProjectDate.Name = "txtProjectDate";
            this.txtProjectDate.Size = new System.Drawing.Size(157, 20);
            this.txtProjectDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CONTRACT ID (PROJECT SITE) :";
            // 
            // txtProjectNo
            // 
            this.txtProjectNo.Location = new System.Drawing.Point(174, 67);
            this.txtProjectNo.Name = "txtProjectNo";
            this.txtProjectNo.Size = new System.Drawing.Size(215, 20);
            this.txtProjectNo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PROJECT SITE :";
            // 
            // txtProjectSite
            // 
            this.txtProjectSite.Location = new System.Drawing.Point(97, 40);
            this.txtProjectSite.Name = "txtProjectSite";
            this.txtProjectSite.Size = new System.Drawing.Size(215, 20);
            this.txtProjectSite.TabIndex = 10;
            // 
            // lnkAddProject
            // 
            this.lnkAddProject.AutoSize = true;
            this.lnkAddProject.Location = new System.Drawing.Point(468, 39);
            this.lnkAddProject.Name = "lnkAddProject";
            this.lnkAddProject.Size = new System.Drawing.Size(109, 13);
            this.lnkAddProject.TabIndex = 8;
            this.lnkAddProject.TabStop = true;
            this.lnkAddProject.Text = "ADD PROJECT SITE";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(364, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvProjectList
            // 
            this.dgvProjectList.AllowUserToAddRows = false;
            this.dgvProjectList.AllowUserToDeleteRows = false;
            this.dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Site,
            this.ProjectNo,
            this.ProjectDate});
            this.dgvProjectList.Location = new System.Drawing.Point(9, 56);
            this.dgvProjectList.Name = "dgvProjectList";
            this.dgvProjectList.Size = new System.Drawing.Size(571, 481);
            this.dgvProjectList.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 28);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROJECT SITE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddGroup);
            this.panel2.Location = new System.Drawing.Point(584, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 644);
            this.panel2.TabIndex = 1;
            // 
            // AddGroup
            // 
            this.AddGroup.Controls.Add(this.panel4);
            this.AddGroup.Location = new System.Drawing.Point(1, -9);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(579, 649);
            this.AddGroup.TabIndex = 0;
            this.AddGroup.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnAddCancel);
            this.panel4.Controls.Add(this.btnAddSave);
            this.panel4.Controls.Add(this.dgvAddProjectList);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(1, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 642);
            this.panel4.TabIndex = 0;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(414, 604);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 8;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(495, 604);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddSave.TabIndex = 7;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = true;
            // 
            // dgvAddProjectList
            // 
            this.dgvAddProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAddProjectList.Location = new System.Drawing.Point(5, 38);
            this.dgvAddProjectList.Name = "dgvAddProjectList";
            this.dgvAddProjectList.Size = new System.Drawing.Size(566, 556);
            this.dgvAddProjectList.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(-4, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(583, 28);
            this.panel5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADD PROJECT SITE";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PROJECT SITE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "CONTRACT ID (PROJECT ID)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "PROJECT DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 123;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 5;
            // 
            // Site
            // 
            this.Site.HeaderText = "PROJECT SITE";
            this.Site.Name = "Site";
            this.Site.ReadOnly = true;
            this.Site.Width = 200;
            // 
            // ProjectNo
            // 
            this.ProjectNo.HeaderText = "CONTRACT ID (PROJECT ID)";
            this.ProjectNo.Name = "ProjectNo";
            this.ProjectNo.ReadOnly = true;
            this.ProjectNo.Width = 200;
            // 
            // ProjectDate
            // 
            this.ProjectDate.HeaderText = "PROJECT DATE";
            this.ProjectDate.Name = "ProjectDate";
            this.ProjectDate.ReadOnly = true;
            this.ProjectDate.Width = 123;
            // 
            // ProjectSiteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectSiteControl";
            this.Size = new System.Drawing.Size(1167, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EditGroup.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.AddGroup.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProjectList)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.LinkLabel lnkDelete;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvProjectList;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.LinkLabel lnkAddProject;
        public System.Windows.Forms.GroupBox AddGroup;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dgvAddProjectList;
        public System.Windows.Forms.Button btnAddSave;
        public System.Windows.Forms.Button btnAddCancel;
        public System.Windows.Forms.GroupBox EditGroup;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtProjectDate;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtProjectNo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtProjectSite;
        public System.Windows.Forms.Button btnEditCancel;
        public System.Windows.Forms.Button btnEditSave;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.ComboBox cmbProject;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDate;
    }
}
