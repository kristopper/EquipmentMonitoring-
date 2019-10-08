namespace EquipmentMonitoring.AllForm.AllSetupform.FuelType
{
    partial class FuelTypeControl
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
            this.dgvFuelList = new System.Windows.Forms.DataGridView();
            this.lnkAddFuel = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Addpanel = new System.Windows.Forms.Panel();
            this.btnaddCancel = new System.Windows.Forms.Button();
            this.btnaddSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAddFuelList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddGroup = new System.Windows.Forms.GroupBox();
            this.EditGroup = new System.Windows.Forms.GroupBox();
            this.editpanel = new System.Windows.Forms.Panel();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.lblOldFuelType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTypeofFuel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUELTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuelList)).BeginInit();
            this.panel2.SuspendLayout();
            this.Addpanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddFuelList)).BeginInit();
            this.AddGroup.SuspendLayout();
            this.EditGroup.SuspendLayout();
            this.editpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 39);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "FUEL TYPE";
            // 
            // dgvFuelList
            // 
            this.dgvFuelList.AllowUserToAddRows = false;
            this.dgvFuelList.AllowUserToDeleteRows = false;
            this.dgvFuelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuelList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FUELTYPE});
            this.dgvFuelList.Location = new System.Drawing.Point(168, 66);
            this.dgvFuelList.Name = "dgvFuelList";
            this.dgvFuelList.Size = new System.Drawing.Size(248, 238);
            this.dgvFuelList.TabIndex = 3;
            // 
            // lnkAddFuel
            // 
            this.lnkAddFuel.AutoSize = true;
            this.lnkAddFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddFuel.Location = new System.Drawing.Point(313, 49);
            this.lnkAddFuel.Name = "lnkAddFuel";
            this.lnkAddFuel.Size = new System.Drawing.Size(104, 13);
            this.lnkAddFuel.TabIndex = 4;
            this.lnkAddFuel.TabStop = true;
            this.lnkAddFuel.Text = "ADD FUEL TYPE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lnkAddFuel);
            this.panel2.Controls.Add(this.dgvFuelList);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 343);
            this.panel2.TabIndex = 5;
            // 
            // Addpanel
            // 
            this.Addpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Addpanel.Controls.Add(this.btnaddCancel);
            this.Addpanel.Controls.Add(this.btnaddSave);
            this.Addpanel.Controls.Add(this.panel4);
            this.Addpanel.Controls.Add(this.dgvAddFuelList);
            this.Addpanel.Location = new System.Drawing.Point(-1, 7);
            this.Addpanel.Name = "Addpanel";
            this.Addpanel.Size = new System.Drawing.Size(583, 641);
            this.Addpanel.TabIndex = 6;
            // 
            // btnaddCancel
            // 
            this.btnaddCancel.Location = new System.Drawing.Point(257, 244);
            this.btnaddCancel.Name = "btnaddCancel";
            this.btnaddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnaddCancel.TabIndex = 10;
            this.btnaddCancel.Text = "Cancel";
            this.btnaddCancel.UseVisualStyleBackColor = true;
            // 
            // btnaddSave
            // 
            this.btnaddSave.Location = new System.Drawing.Point(338, 244);
            this.btnaddSave.Name = "btnaddSave";
            this.btnaddSave.Size = new System.Drawing.Size(75, 23);
            this.btnaddSave.TabIndex = 10;
            this.btnaddSave.Text = "Save";
            this.btnaddSave.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(583, 37);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADD FUEL TYPE";
            // 
            // dgvAddFuelList
            // 
            this.dgvAddFuelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddFuelList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvAddFuelList.Location = new System.Drawing.Point(170, 59);
            this.dgvAddFuelList.Name = "dgvAddFuelList";
            this.dgvAddFuelList.Size = new System.Drawing.Size(243, 169);
            this.dgvAddFuelList.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "FUEL TYPE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // AddGroup
            // 
            this.AddGroup.Controls.Add(this.Addpanel);
            this.AddGroup.Location = new System.Drawing.Point(585, -7);
            this.AddGroup.Margin = new System.Windows.Forms.Padding(0);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Padding = new System.Windows.Forms.Padding(0);
            this.AddGroup.Size = new System.Drawing.Size(582, 651);
            this.AddGroup.TabIndex = 7;
            this.AddGroup.TabStop = false;
            // 
            // EditGroup
            // 
            this.EditGroup.Controls.Add(this.editpanel);
            this.EditGroup.Location = new System.Drawing.Point(0, 345);
            this.EditGroup.Margin = new System.Windows.Forms.Padding(0);
            this.EditGroup.Name = "EditGroup";
            this.EditGroup.Padding = new System.Windows.Forms.Padding(0);
            this.EditGroup.Size = new System.Drawing.Size(583, 299);
            this.EditGroup.TabIndex = 8;
            this.EditGroup.TabStop = false;
            // 
            // editpanel
            // 
            this.editpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editpanel.Controls.Add(this.lnkDelete);
            this.editpanel.Controls.Add(this.lblOldFuelType);
            this.editpanel.Controls.Add(this.btnSave);
            this.editpanel.Controls.Add(this.btnCancel);
            this.editpanel.Controls.Add(this.txtTypeofFuel);
            this.editpanel.Controls.Add(this.label3);
            this.editpanel.Location = new System.Drawing.Point(65, 15);
            this.editpanel.Name = "editpanel";
            this.editpanel.Size = new System.Drawing.Size(448, 151);
            this.editpanel.TabIndex = 0;
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(392, 4);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(49, 13);
            this.lnkDelete.TabIndex = 9;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "DELETE";
            // 
            // lblOldFuelType
            // 
            this.lblOldFuelType.AutoSize = true;
            this.lblOldFuelType.Location = new System.Drawing.Point(24, 4);
            this.lblOldFuelType.Name = "lblOldFuelType";
            this.lblOldFuelType.Size = new System.Drawing.Size(35, 13);
            this.lblOldFuelType.TabIndex = 8;
            this.lblOldFuelType.Text = "label4";
            this.lblOldFuelType.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(280, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(199, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtTypeofFuel
            // 
            this.txtTypeofFuel.Location = new System.Drawing.Point(175, 41);
            this.txtTypeofFuel.Multiline = true;
            this.txtTypeofFuel.Name = "txtTypeofFuel";
            this.txtTypeofFuel.Size = new System.Drawing.Size(180, 21);
            this.txtTypeofFuel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "TYPE OF FUEL :";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 5;
            // 
            // FUELTYPE
            // 
            this.FUELTYPE.HeaderText = "FUEL TYPE";
            this.FUELTYPE.Name = "FUELTYPE";
            this.FUELTYPE.ReadOnly = true;
            this.FUELTYPE.Width = 200;
            // 
            // FuelTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditGroup);
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.panel2);
            this.Name = "FuelTypeControl";
            this.Size = new System.Drawing.Size(1167, 644);
            this.Load += new System.EventHandler(this.FuelTypeControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuelList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Addpanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddFuelList)).EndInit();
            this.AddGroup.ResumeLayout(false);
            this.EditGroup.ResumeLayout(false);
            this.editpanel.ResumeLayout(false);
            this.editpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel Addpanel;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvAddFuelList;
        public System.Windows.Forms.GroupBox AddGroup;
        public System.Windows.Forms.GroupBox EditGroup;
        public System.Windows.Forms.Panel editpanel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtTypeofFuel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblOldFuelType;
        public System.Windows.Forms.LinkLabel lnkDelete;
        public System.Windows.Forms.Button btnaddCancel;
        public System.Windows.Forms.Button btnaddSave;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvFuelList;
        public System.Windows.Forms.LinkLabel lnkAddFuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUELTYPE;
    }
}
