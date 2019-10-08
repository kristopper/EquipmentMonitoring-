namespace EquipmentMonitoring.AllForm.AllSetupform.Trucktype
{
    partial class TruckTypeControl
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
            this.dgvTruckTypeList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRUCKTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIMITBASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIMITTOMAINTENANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adddisplayGroup = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.dgvAddTruckType = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDLIMITBASE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkAddTruck = new System.Windows.Forms.LinkLabel();
            this.edittruckgroup = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cmbLimitBase = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkmLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTrucktype = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTrucktype = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruckTypeList)).BeginInit();
            this.adddisplayGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTruckType)).BeginInit();
            this.edittruckgroup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 30);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRUCK TYPE";
            // 
            // dgvTruckTypeList
            // 
            this.dgvTruckTypeList.AllowUserToAddRows = false;
            this.dgvTruckTypeList.AllowUserToDeleteRows = false;
            this.dgvTruckTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruckTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TRUCKTYPE,
            this.DESCRIPTION,
            this.LIMITBASE,
            this.LIMITTOMAINTENANCE,
            this.KM,
            this.HRS});
            this.dgvTruckTypeList.Location = new System.Drawing.Point(3, 35);
            this.dgvTruckTypeList.Name = "dgvTruckTypeList";
            this.dgvTruckTypeList.Size = new System.Drawing.Size(803, 305);
            this.dgvTruckTypeList.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 5;
            // 
            // TRUCKTYPE
            // 
            this.TRUCKTYPE.HeaderText = "TRUCKTYPE";
            this.TRUCKTYPE.Name = "TRUCKTYPE";
            this.TRUCKTYPE.ReadOnly = true;
            this.TRUCKTYPE.Width = 180;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            this.DESCRIPTION.Width = 180;
            // 
            // LIMITBASE
            // 
            this.LIMITBASE.HeaderText = "LIMIT BASE";
            this.LIMITBASE.Name = "LIMITBASE";
            this.LIMITBASE.ReadOnly = true;
            this.LIMITBASE.Width = 95;
            // 
            // LIMITTOMAINTENANCE
            // 
            this.LIMITTOMAINTENANCE.HeaderText = "LIMIT TO MAINTENANCE";
            this.LIMITTOMAINTENANCE.Name = "LIMITTOMAINTENANCE";
            this.LIMITTOMAINTENANCE.ReadOnly = true;
            // 
            // KM
            // 
            this.KM.HeaderText = "KM";
            this.KM.Name = "KM";
            this.KM.ReadOnly = true;
            // 
            // HRS
            // 
            this.HRS.HeaderText = "HRS";
            this.HRS.Name = "HRS";
            this.HRS.ReadOnly = true;
            // 
            // adddisplayGroup
            // 
            this.adddisplayGroup.Controls.Add(this.panel2);
            this.adddisplayGroup.Location = new System.Drawing.Point(0, 364);
            this.adddisplayGroup.Margin = new System.Windows.Forms.Padding(0);
            this.adddisplayGroup.Name = "adddisplayGroup";
            this.adddisplayGroup.Padding = new System.Windows.Forms.Padding(0);
            this.adddisplayGroup.Size = new System.Drawing.Size(1167, 280);
            this.adddisplayGroup.TabIndex = 3;
            this.adddisplayGroup.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnAddCancel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnAddSave);
            this.panel2.Controls.Add(this.dgvAddTruckType);
            this.panel2.Location = new System.Drawing.Point(0, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 263);
            this.panel2.TabIndex = 0;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(823, 213);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 34;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1167, 30);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "ADD TRUCK TYPE";
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(904, 213);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddSave.TabIndex = 33;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = true;
            // 
            // dgvAddTruckType
            // 
            this.dgvAddTruckType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddTruckType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ADDLIMITBASE,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvAddTruckType.Location = new System.Drawing.Point(176, 48);
            this.dgvAddTruckType.Name = "dgvAddTruckType";
            this.dgvAddTruckType.Size = new System.Drawing.Size(803, 160);
            this.dgvAddTruckType.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TRUCKTYPE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // ADDLIMITBASE
            // 
            this.ADDLIMITBASE.HeaderText = "LIMIT BASE";
            this.ADDLIMITBASE.Items.AddRange(new object[] {
            "KM",
            "HR"});
            this.ADDLIMITBASE.Name = "ADDLIMITBASE";
            this.ADDLIMITBASE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ADDLIMITBASE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "LIMIT TO MAINTENANCE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "KM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "HRS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lnkAddTruck
            // 
            this.lnkAddTruck.AutoSize = true;
            this.lnkAddTruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddTruck.Location = new System.Drawing.Point(3, 347);
            this.lnkAddTruck.Name = "lnkAddTruck";
            this.lnkAddTruck.Size = new System.Drawing.Size(109, 15);
            this.lnkAddTruck.TabIndex = 4;
            this.lnkAddTruck.TabStop = true;
            this.lnkAddTruck.Text = "ADD TRUCK TYPE";
            // 
            // edittruckgroup
            // 
            this.edittruckgroup.Controls.Add(this.panel3);
            this.edittruckgroup.Location = new System.Drawing.Point(810, -7);
            this.edittruckgroup.Margin = new System.Windows.Forms.Padding(0);
            this.edittruckgroup.Name = "edittruckgroup";
            this.edittruckgroup.Padding = new System.Windows.Forms.Padding(0);
            this.edittruckgroup.Size = new System.Drawing.Size(357, 379);
            this.edittruckgroup.TabIndex = 5;
            this.edittruckgroup.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Controls.Add(this.lnkDelete);
            this.panel3.Controls.Add(this.txtLimit);
            this.panel3.Controls.Add(this.cmbLimitBase);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtHr);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtkmLimit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.lblTrucktype);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.lblDescription);
            this.panel3.Controls.Add(this.txtTrucktype);
            this.panel3.Location = new System.Drawing.Point(0, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 367);
            this.panel3.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "label7";
            this.lblId.Visible = false;
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(296, 13);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(49, 13);
            this.lnkDelete.TabIndex = 28;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "DELETE";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(206, 185);
            this.txtLimit.Multiline = true;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(92, 25);
            this.txtLimit.TabIndex = 19;
            // 
            // cmbLimitBase
            // 
            this.cmbLimitBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLimitBase.FormattingEnabled = true;
            this.cmbLimitBase.Items.AddRange(new object[] {
            "KM",
            "HR"});
            this.cmbLimitBase.Location = new System.Drawing.Point(146, 149);
            this.cmbLimitBase.Name = "cmbLimitBase";
            this.cmbLimitBase.Size = new System.Drawing.Size(152, 21);
            this.cmbLimitBase.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Limit Base :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "HR :";
            // 
            // txtHr
            // 
            this.txtHr.Location = new System.Drawing.Point(224, 222);
            this.txtHr.Multiline = true;
            this.txtHr.Name = "txtHr";
            this.txtHr.Size = new System.Drawing.Size(76, 25);
            this.txtHr.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "KM :";
            // 
            // txtkmLimit
            // 
            this.txtkmLimit.Location = new System.Drawing.Point(104, 222);
            this.txtkmLimit.Multiline = true;
            this.txtkmLimit.Name = "txtkmLimit";
            this.txtkmLimit.Size = new System.Drawing.Size(76, 25);
            this.txtkmLimit.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Limit to Maintanance :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(146, 111);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(152, 25);
            this.txtDescription.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblTrucktype
            // 
            this.lblTrucktype.AutoSize = true;
            this.lblTrucktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrucktype.Location = new System.Drawing.Point(62, 79);
            this.lblTrucktype.Name = "lblTrucktype";
            this.lblTrucktype.Size = new System.Drawing.Size(84, 15);
            this.lblTrucktype.TabIndex = 14;
            this.lblTrucktype.Text = "Truck Type :";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(170, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(62, 117);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 15);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description:";
            // 
            // txtTrucktype
            // 
            this.txtTrucktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrucktype.Location = new System.Drawing.Point(146, 72);
            this.txtTrucktype.Multiline = true;
            this.txtTrucktype.Name = "txtTrucktype";
            this.txtTrucktype.Size = new System.Drawing.Size(152, 25);
            this.txtTrucktype.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "EDIT AND DELETE TRUCK TYPE";
            // 
            // TruckTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edittruckgroup);
            this.Controls.Add(this.lnkAddTruck);
            this.Controls.Add(this.adddisplayGroup);
            this.Controls.Add(this.dgvTruckTypeList);
            this.Controls.Add(this.panel1);
            this.Name = "TruckTypeControl";
            this.Size = new System.Drawing.Size(1167, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruckTypeList)).EndInit();
            this.adddisplayGroup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTruckType)).EndInit();
            this.edittruckgroup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.LinkLabel lnkAddTruck;
        public System.Windows.Forms.GroupBox edittruckgroup;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtLimit;
        public System.Windows.Forms.ComboBox cmbLimitBase;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtHr;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtkmLimit;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblTrucktype;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.TextBox txtTrucktype;
        public System.Windows.Forms.LinkLabel lnkDelete;
        public System.Windows.Forms.Button btnAddSave;
        public System.Windows.Forms.DataGridView dgvAddTruckType;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnAddCancel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvTruckTypeList;
        public System.Windows.Forms.GroupBox adddisplayGroup;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRUCKTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIMITBASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIMITTOMAINTENANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn ADDLIMITBASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label label7;
    }
}
