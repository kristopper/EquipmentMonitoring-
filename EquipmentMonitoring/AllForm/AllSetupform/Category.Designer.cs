namespace EquipmentMonitoring.AllForm.AllSetupform
{
    partial class Category
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkEditCategory = new System.Windows.Forms.LinkLabel();
            this.lnkAddSubCategory = new System.Windows.Forms.LinkLabel();
            this.lnkAddCategory = new System.Windows.Forms.LinkLabel();
            this.EditCategoryGroup = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCategoryid = new System.Windows.Forms.Label();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.txtSubCategory = new System.Windows.Forms.TextBox();
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.AddCategoryGroup = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.dgvCategoryAdd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMain = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.AddSubCategoryGroup = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSubCancel = new System.Windows.Forms.Button();
            this.btnSubSave = new System.Windows.Forms.Button();
            this.dgvSubCategory = new System.Windows.Forms.DataGridView();
            this.dSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typesub = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdRepairType = new System.Windows.Forms.ComboBox();
            this.lblRType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.EditCategoryGroup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.AddCategoryGroup.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryAdd)).BeginInit();
            this.AddSubCategoryGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 28);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORY";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(78, 7);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(221, 21);
            this.cmbCategory.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(305, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category :";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.SubCategory,
            this.Type});
            this.dgvCategory.Location = new System.Drawing.Point(7, 33);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(564, 423);
            this.dgvCategory.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CATEGORY";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 210;
            // 
            // SubCategory
            // 
            this.SubCategory.HeaderText = "SUB-CATEGORY";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            this.SubCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SubCategory.Width = 205;
            // 
            // Type
            // 
            this.Type.HeaderText = "TYPE";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lnkEditCategory);
            this.panel2.Controls.Add(this.lnkAddSubCategory);
            this.panel2.Controls.Add(this.lnkAddCategory);
            this.panel2.Controls.Add(this.EditCategoryGroup);
            this.panel2.Controls.Add(this.dgvCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(2, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 615);
            this.panel2.TabIndex = 8;
            // 
            // lnkEditCategory
            // 
            this.lnkEditCategory.AutoSize = true;
            this.lnkEditCategory.Location = new System.Drawing.Point(480, 15);
            this.lnkEditCategory.Name = "lnkEditCategory";
            this.lnkEditCategory.Size = new System.Drawing.Size(94, 13);
            this.lnkEditCategory.TabIndex = 11;
            this.lnkEditCategory.TabStop = true;
            this.lnkEditCategory.Text = "EDIT CATEGORY";
            // 
            // lnkAddSubCategory
            // 
            this.lnkAddSubCategory.AutoSize = true;
            this.lnkAddSubCategory.Location = new System.Drawing.Point(454, 481);
            this.lnkAddSubCategory.Name = "lnkAddSubCategory";
            this.lnkAddSubCategory.Size = new System.Drawing.Size(117, 13);
            this.lnkAddSubCategory.TabIndex = 10;
            this.lnkAddSubCategory.TabStop = true;
            this.lnkAddSubCategory.Text = "ADD SUB-CATEGORY";
            // 
            // lnkAddCategory
            // 
            this.lnkAddCategory.AutoSize = true;
            this.lnkAddCategory.Location = new System.Drawing.Point(479, 462);
            this.lnkAddCategory.Name = "lnkAddCategory";
            this.lnkAddCategory.Size = new System.Drawing.Size(92, 13);
            this.lnkAddCategory.TabIndex = 9;
            this.lnkAddCategory.TabStop = true;
            this.lnkAddCategory.Text = "ADD CATEGORY";
            // 
            // EditCategoryGroup
            // 
            this.EditCategoryGroup.Controls.Add(this.panel3);
            this.EditCategoryGroup.Location = new System.Drawing.Point(1, 498);
            this.EditCategoryGroup.Name = "EditCategoryGroup";
            this.EditCategoryGroup.Size = new System.Drawing.Size(580, 115);
            this.EditCategoryGroup.TabIndex = 8;
            this.EditCategoryGroup.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblRType);
            this.panel3.Controls.Add(this.cmdRepairType);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblCategoryid);
            this.panel3.Controls.Add(this.lnkDelete);
            this.panel3.Controls.Add(this.btnEditCancel);
            this.panel3.Controls.Add(this.lblCategory);
            this.panel3.Controls.Add(this.lblSubCategory);
            this.panel3.Controls.Add(this.btnEditSave);
            this.panel3.Controls.Add(this.txtSubCategory);
            this.panel3.Controls.Add(this.cmbCategoryList);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(-1, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 101);
            this.panel3.TabIndex = 0;
            // 
            // lblCategoryid
            // 
            this.lblCategoryid.AutoSize = true;
            this.lblCategoryid.Location = new System.Drawing.Point(127, 11);
            this.lblCategoryid.Name = "lblCategoryid";
            this.lblCategoryid.Size = new System.Drawing.Size(35, 13);
            this.lblCategoryid.TabIndex = 18;
            this.lblCategoryid.Text = "label7";
            this.lblCategoryid.Visible = false;
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(519, 10);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(49, 13);
            this.lnkDelete.TabIndex = 11;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "DELETE";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(414, 65);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 17;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(35, 13);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "label5";
            this.lblCategory.Visible = false;
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(61, 11);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(35, 13);
            this.lblSubCategory.TabIndex = 15;
            this.lblSubCategory.Text = "label4";
            this.lblSubCategory.Visible = false;
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(495, 65);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditSave.TabIndex = 14;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Location = new System.Drawing.Point(383, 30);
            this.txtSubCategory.Multiline = true;
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(185, 22);
            this.txtSubCategory.TabIndex = 13;
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(73, 31);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoryList.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sub-Category :";
            // 
            // AddCategoryGroup
            // 
            this.AddCategoryGroup.Controls.Add(this.panel5);
            this.AddCategoryGroup.Location = new System.Drawing.Point(583, -6);
            this.AddCategoryGroup.Name = "AddCategoryGroup";
            this.AddCategoryGroup.Size = new System.Drawing.Size(580, 308);
            this.AddCategoryGroup.TabIndex = 9;
            this.AddCategoryGroup.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnAddCancel);
            this.panel5.Controls.Add(this.btnAddSave);
            this.panel5.Controls.Add(this.dgvCategoryAdd);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 300);
            this.panel5.TabIndex = 1;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(474, 53);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(57, 25);
            this.btnAddCancel.TabIndex = 9;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(474, 22);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(57, 25);
            this.btnAddSave.TabIndex = 8;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = true;
            // 
            // dgvCategoryAdd
            // 
            this.dgvCategoryAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.TypeMain});
            this.dgvCategoryAdd.Location = new System.Drawing.Point(67, 22);
            this.dgvCategoryAdd.Name = "dgvCategoryAdd";
            this.dgvCategoryAdd.Size = new System.Drawing.Size(401, 273);
            this.dgvCategoryAdd.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CATEGORY";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 258;
            // 
            // TypeMain
            // 
            this.TypeMain.HeaderText = "TYPE";
            this.TypeMain.Items.AddRange(new object[] {
            "MINOR",
            "MAJOR",
            "N/A"});
            this.TypeMain.Name = "TypeMain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADD CATEGORY";
            // 
            // AddSubCategoryGroup
            // 
            this.AddSubCategoryGroup.Controls.Add(this.panel4);
            this.AddSubCategoryGroup.Location = new System.Drawing.Point(584, 300);
            this.AddSubCategoryGroup.Name = "AddSubCategoryGroup";
            this.AddSubCategoryGroup.Size = new System.Drawing.Size(580, 344);
            this.AddSubCategoryGroup.TabIndex = 9;
            this.AddSubCategoryGroup.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnSubCancel);
            this.panel4.Controls.Add(this.btnSubSave);
            this.panel4.Controls.Add(this.dgvSubCategory);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-1, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 337);
            this.panel4.TabIndex = 1;
            // 
            // btnSubCancel
            // 
            this.btnSubCancel.Location = new System.Drawing.Point(412, 306);
            this.btnSubCancel.Name = "btnSubCancel";
            this.btnSubCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSubCancel.TabIndex = 9;
            this.btnSubCancel.Text = "Cancel";
            this.btnSubCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubSave
            // 
            this.btnSubSave.Location = new System.Drawing.Point(493, 306);
            this.btnSubSave.Name = "btnSubSave";
            this.btnSubSave.Size = new System.Drawing.Size(75, 23);
            this.btnSubSave.TabIndex = 8;
            this.btnSubSave.Text = "Save";
            this.btnSubSave.UseVisualStyleBackColor = true;
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dSubCategory,
            this.Categorys,
            this.Typesub});
            this.dgvSubCategory.Location = new System.Drawing.Point(6, 33);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.Size = new System.Drawing.Size(565, 267);
            this.dgvSubCategory.TabIndex = 7;
            // 
            // dSubCategory
            // 
            this.dSubCategory.HeaderText = "SUB-CATEGORY";
            this.dSubCategory.Name = "dSubCategory";
            this.dSubCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dSubCategory.Width = 180;
            // 
            // Categorys
            // 
            this.Categorys.HeaderText = "Category";
            this.Categorys.Name = "Categorys";
            // 
            // Typesub
            // 
            this.Typesub.HeaderText = "TYPE";
            this.Typesub.Items.AddRange(new object[] {
            "MINOR",
            "MAJOR",
            "N/A"});
            this.Typesub.Name = "Typesub";
            this.Typesub.Width = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ADD SUB-CATEGORY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "TYPE :";
            // 
            // cmdRepairType
            // 
            this.cmdRepairType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdRepairType.FormattingEnabled = true;
            this.cmdRepairType.Items.AddRange(new object[] {
            "MINOR",
            "MAJOR",
            "N/A"});
            this.cmdRepairType.Location = new System.Drawing.Point(73, 62);
            this.cmdRepairType.Name = "cmdRepairType";
            this.cmdRepairType.Size = new System.Drawing.Size(200, 21);
            this.cmdRepairType.TabIndex = 20;
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Location = new System.Drawing.Point(191, 10);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(35, 13);
            this.lblRType.TabIndex = 21;
            this.lblRType.Text = "label7";
            this.lblRType.Visible = false;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddSubCategoryGroup);
            this.Controls.Add(this.AddCategoryGroup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(1167, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.EditCategoryGroup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.AddCategoryGroup.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryAdd)).EndInit();
            this.AddSubCategoryGroup.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox AddCategoryGroup;
        public System.Windows.Forms.GroupBox EditCategoryGroup;
        public System.Windows.Forms.GroupBox AddSubCategoryGroup;
        public System.Windows.Forms.LinkLabel lnkAddCategory;
        public System.Windows.Forms.LinkLabel lnkAddSubCategory;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnSubCancel;
        public System.Windows.Forms.Button btnSubSave;
        public System.Windows.Forms.DataGridView dgvSubCategory;
        public System.Windows.Forms.DataGridView dgvCategoryAdd;
        public System.Windows.Forms.Button btnAddCancel;
        public System.Windows.Forms.Button btnAddSave;
        public System.Windows.Forms.Button btnEditCancel;
        public System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.Label lblSubCategory;
        public System.Windows.Forms.Button btnEditSave;
        public System.Windows.Forms.TextBox txtSubCategory;
        public System.Windows.Forms.ComboBox cmbCategoryList;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.LinkLabel lnkDelete;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbCategory;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvCategory;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        public System.Windows.Forms.Label lblCategoryid;
        public System.Windows.Forms.LinkLabel lnkEditCategory;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmdRepairType;
        public System.Windows.Forms.DataGridViewTextBoxColumn id;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        public System.Windows.Forms.DataGridViewTextBoxColumn Type;
        public System.Windows.Forms.DataGridViewTextBoxColumn dSubCategory;
        public System.Windows.Forms.DataGridViewTextBoxColumn Categorys;
        public System.Windows.Forms.DataGridViewComboBoxColumn Typesub;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewComboBoxColumn TypeMain;
        public System.Windows.Forms.Label lblRType;
    }
}
