namespace EquipmentMonitoring.AllForm.AllSetupform.Position
{
    partial class PositionControl
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
            this.paneladd = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.EditPosition = new System.Windows.Forms.GroupBox();
            this.AddPositionGroup = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEditPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.lnkAddposition = new System.Windows.Forms.LinkLabel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbloldPosition = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddPosition = new System.Windows.Forms.DataGridView();
            this.panelmain.SuspendLayout();
            this.paneladd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.EditPosition.SuspendLayout();
            this.AddPositionGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.lnkAddposition);
            this.panelmain.Controls.Add(this.EditPosition);
            this.panelmain.Controls.Add(this.btnSearch);
            this.panelmain.Controls.Add(this.txtSearch);
            this.panelmain.Controls.Add(this.label2);
            this.panelmain.Controls.Add(this.dgvPosition);
            this.panelmain.Controls.Add(this.panel1);
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(583, 643);
            this.panelmain.TabIndex = 0;
            // 
            // paneladd
            // 
            this.paneladd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneladd.Controls.Add(this.AddPositionGroup);
            this.paneladd.Location = new System.Drawing.Point(584, 0);
            this.paneladd.Name = "paneladd";
            this.paneladd.Size = new System.Drawing.Size(583, 643);
            this.paneladd.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "POSITION LISTS";
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AllowUserToDeleteRows = false;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.POSITION});
            this.dgvPosition.Location = new System.Drawing.Point(61, 61);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.Size = new System.Drawing.Size(460, 481);
            this.dgvPosition.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "POSITION :";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(121, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(294, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // EditPosition
            // 
            this.EditPosition.Controls.Add(this.panel3);
            this.EditPosition.Location = new System.Drawing.Point(6, 540);
            this.EditPosition.Name = "EditPosition";
            this.EditPosition.Size = new System.Drawing.Size(570, 101);
            this.EditPosition.TabIndex = 9;
            this.EditPosition.TabStop = false;
            // 
            // AddPositionGroup
            // 
            this.AddPositionGroup.Controls.Add(this.btnAddCancel);
            this.AddPositionGroup.Controls.Add(this.dgvAddPosition);
            this.AddPositionGroup.Controls.Add(this.btnAddSave);
            this.AddPositionGroup.Controls.Add(this.panel2);
            this.AddPositionGroup.Location = new System.Drawing.Point(6, -6);
            this.AddPositionGroup.Margin = new System.Windows.Forms.Padding(0);
            this.AddPositionGroup.Name = "AddPositionGroup";
            this.AddPositionGroup.Padding = new System.Windows.Forms.Padding(0);
            this.AddPositionGroup.Size = new System.Drawing.Size(570, 633);
            this.AddPositionGroup.TabIndex = 10;
            this.AddPositionGroup.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(360, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtEditPosition
            // 
            this.txtEditPosition.Location = new System.Drawing.Point(113, 36);
            this.txtEditPosition.Name = "txtEditPosition";
            this.txtEditPosition.Size = new System.Drawing.Size(243, 20);
            this.txtEditPosition.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "POSITION :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(441, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 27);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "ADD POSITION";
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(447, 570);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddSave.TabIndex = 7;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = true;
            // 
            // lnkAddposition
            // 
            this.lnkAddposition.AutoSize = true;
            this.lnkAddposition.Location = new System.Drawing.Point(437, 41);
            this.lnkAddposition.Name = "lnkAddposition";
            this.lnkAddposition.Size = new System.Drawing.Size(84, 13);
            this.lnkAddposition.TabIndex = 10;
            this.lnkAddposition.TabStop = true;
            this.lnkAddposition.Text = "ADD POSITION";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(366, 570);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 8;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // POSITION
            // 
            this.POSITION.HeaderText = "POSITION";
            this.POSITION.Name = "POSITION";
            this.POSITION.ReadOnly = true;
            this.POSITION.Width = 416;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbloldPosition);
            this.panel3.Controls.Add(this.lnkDelete);
            this.panel3.Controls.Add(this.txtEditPosition);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Location = new System.Drawing.Point(2, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 88);
            this.panel3.TabIndex = 0;
            // 
            // lbloldPosition
            // 
            this.lbloldPosition.AutoSize = true;
            this.lbloldPosition.Location = new System.Drawing.Point(80, 5);
            this.lbloldPosition.Name = "lbloldPosition";
            this.lbloldPosition.Size = new System.Drawing.Size(35, 13);
            this.lbloldPosition.TabIndex = 15;
            this.lbloldPosition.Text = "label5";
            this.lbloldPosition.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "POSITION";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 416;
            // 
            // dgvAddPosition
            // 
            this.dgvAddPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvAddPosition.Location = new System.Drawing.Point(62, 57);
            this.dgvAddPosition.Name = "dgvAddPosition";
            this.dgvAddPosition.Size = new System.Drawing.Size(460, 502);
            this.dgvAddPosition.TabIndex = 6;
            // 
            // PositionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paneladd);
            this.Controls.Add(this.panelmain);
            this.Name = "PositionControl";
            this.Size = new System.Drawing.Size(1167, 644);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            this.paneladd.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.EditPosition.ResumeLayout(false);
            this.AddPositionGroup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvPosition;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnAddSave;
        public System.Windows.Forms.Panel panelmain;
        public System.Windows.Forms.Panel paneladd;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.GroupBox EditPosition;
        public System.Windows.Forms.GroupBox AddPositionGroup;
        public System.Windows.Forms.LinkLabel lnkDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtEditPosition;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.LinkLabel lnkAddposition;
        public System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lbloldPosition;
        public System.Windows.Forms.DataGridView dgvAddPosition;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
