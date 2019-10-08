namespace EquipmentMonitoring.AllForm
{
    partial class dashBoardControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBoardControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMaintenanceList = new System.Windows.Forms.DataGridView();
            this.Datecreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshMaintenancelist = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLtoRegister = new System.Windows.Forms.DataGridView();
            this.Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltoEquipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltoModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltoPlateno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDBLTO = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HdgvMaintankFuel = new System.Windows.Forms.DataGridView();
            this.TANKNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDFuelLimit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLtoRegister)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HdgvMaintankFuel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMaintenanceList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(146, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintenance List";
            // 
            // dgvMaintenanceList
            // 
            this.dgvMaintenanceList.AllowUserToAddRows = false;
            this.dgvMaintenanceList.AllowUserToDeleteRows = false;
            this.dgvMaintenanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datecreate,
            this.EquipNo,
            this.modelno,
            this.PlateNumber,
            this.totalKm,
            this.totalhr});
            this.dgvMaintenanceList.Location = new System.Drawing.Point(7, 20);
            this.dgvMaintenanceList.Name = "dgvMaintenanceList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenanceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkRed;
            this.dgvMaintenanceList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMaintenanceList.Size = new System.Drawing.Size(853, 304);
            this.dgvMaintenanceList.TabIndex = 0;
            // 
            // Datecreate
            // 
            this.Datecreate.HeaderText = "DATE";
            this.Datecreate.Name = "Datecreate";
            this.Datecreate.ReadOnly = true;
            // 
            // EquipNo
            // 
            this.EquipNo.HeaderText = "EQUIPMENT NO.";
            this.EquipNo.Name = "EquipNo";
            this.EquipNo.ReadOnly = true;
            this.EquipNo.Width = 150;
            // 
            // modelno
            // 
            this.modelno.HeaderText = "MODEL";
            this.modelno.Name = "modelno";
            this.modelno.ReadOnly = true;
            this.modelno.Width = 150;
            // 
            // PlateNumber
            // 
            this.PlateNumber.HeaderText = "PLATE NO.";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.ReadOnly = true;
            this.PlateNumber.Width = 150;
            // 
            // totalKm
            // 
            this.totalKm.HeaderText = "TOTAL KMS";
            this.totalKm.Name = "totalKm";
            this.totalKm.ReadOnly = true;
            this.totalKm.Width = 130;
            // 
            // totalhr
            // 
            this.totalhr.HeaderText = "TOTAL HRS";
            this.totalhr.Name = "totalhr";
            this.totalhr.ReadOnly = true;
            this.totalhr.Width = 130;
            // 
            // btnRefreshMaintenancelist
            // 
            this.btnRefreshMaintenancelist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshMaintenancelist.BackgroundImage")));
            this.btnRefreshMaintenancelist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshMaintenancelist.Location = new System.Drawing.Point(977, 14);
            this.btnRefreshMaintenancelist.Name = "btnRefreshMaintenancelist";
            this.btnRefreshMaintenancelist.Size = new System.Drawing.Size(30, 24);
            this.btnRefreshMaintenancelist.TabIndex = 9;
            this.btnRefreshMaintenancelist.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLtoRegister);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(370, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 271);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LTO Registration List";
            // 
            // dgvLtoRegister
            // 
            this.dgvLtoRegister.AllowUserToAddRows = false;
            this.dgvLtoRegister.AllowUserToDeleteRows = false;
            this.dgvLtoRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLtoRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registration,
            this.ltoEquipNo,
            this.ltoModel,
            this.ltoPlateno});
            this.dgvLtoRegister.Location = new System.Drawing.Point(6, 20);
            this.dgvLtoRegister.Name = "dgvLtoRegister";
            this.dgvLtoRegister.Size = new System.Drawing.Size(727, 246);
            this.dgvLtoRegister.TabIndex = 0;
            // 
            // Registration
            // 
            this.Registration.HeaderText = "EXPIRATION DATE";
            this.Registration.Name = "Registration";
            this.Registration.ReadOnly = true;
            this.Registration.Width = 200;
            // 
            // ltoEquipNo
            // 
            this.ltoEquipNo.HeaderText = "EQUIPMENT NO.";
            this.ltoEquipNo.Name = "ltoEquipNo";
            this.ltoEquipNo.ReadOnly = true;
            this.ltoEquipNo.Width = 180;
            // 
            // ltoModel
            // 
            this.ltoModel.HeaderText = "MODEL";
            this.ltoModel.Name = "ltoModel";
            this.ltoModel.ReadOnly = true;
            this.ltoModel.Width = 154;
            // 
            // ltoPlateno
            // 
            this.ltoPlateno.HeaderText = "PLATE NO.";
            this.ltoPlateno.Name = "ltoPlateno";
            this.ltoPlateno.ReadOnly = true;
            this.ltoPlateno.Width = 150;
            // 
            // btnDBLTO
            // 
            this.btnDBLTO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDBLTO.BackgroundImage")));
            this.btnDBLTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDBLTO.Location = new System.Drawing.Point(1074, 346);
            this.btnDBLTO.Name = "btnDBLTO";
            this.btnDBLTO.Size = new System.Drawing.Size(30, 24);
            this.btnDBLTO.TabIndex = 8;
            this.btnDBLTO.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDFuelLimit);
            this.groupBox3.Controls.Add(this.HdgvMaintankFuel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(44, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 271);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MAIN TANK FUEL ALERT";
            // 
            // HdgvMaintankFuel
            // 
            this.HdgvMaintankFuel.AllowUserToAddRows = false;
            this.HdgvMaintankFuel.AllowUserToDeleteRows = false;
            this.HdgvMaintankFuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HdgvMaintankFuel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TANKNAME,
            this.dataGridViewTextBoxColumn4});
            this.HdgvMaintankFuel.Location = new System.Drawing.Point(10, 30);
            this.HdgvMaintankFuel.Name = "HdgvMaintankFuel";
            this.HdgvMaintankFuel.Size = new System.Drawing.Size(296, 235);
            this.HdgvMaintankFuel.TabIndex = 0;
            // 
            // TANKNAME
            // 
            this.TANKNAME.HeaderText = "TANKNAME";
            this.TANKNAME.Name = "TANKNAME";
            this.TANKNAME.ReadOnly = true;
            this.TANKNAME.Width = 153;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "REMAINING FUEL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnDFuelLimit
            // 
            this.btnDFuelLimit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDFuelLimit.BackgroundImage")));
            this.btnDFuelLimit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDFuelLimit.Location = new System.Drawing.Point(278, 4);
            this.btnDFuelLimit.Name = "btnDFuelLimit";
            this.btnDFuelLimit.Size = new System.Drawing.Size(30, 24);
            this.btnDFuelLimit.TabIndex = 10;
            this.btnDFuelLimit.UseVisualStyleBackColor = true;
            // 
            // dashBoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnRefreshMaintenancelist);
            this.Controls.Add(this.btnDBLTO);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "dashBoardControl";
            this.Size = new System.Drawing.Size(1163, 665);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLtoRegister)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HdgvMaintankFuel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridViewTextBoxColumn Datecreate;
        public System.Windows.Forms.DataGridViewTextBoxColumn EquipNo;
        public System.Windows.Forms.DataGridViewTextBoxColumn modelno;
        public System.Windows.Forms.DataGridViewTextBoxColumn PlateNumber;
        public System.Windows.Forms.DataGridViewTextBoxColumn totalKm;
        public System.Windows.Forms.DataGridViewTextBoxColumn totalhr;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvMaintenanceList;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvLtoRegister;
        public System.Windows.Forms.Button btnDBLTO;
        public System.Windows.Forms.Button btnRefreshMaintenancelist;
        public System.Windows.Forms.DataGridViewTextBoxColumn Registration;
        public System.Windows.Forms.DataGridViewTextBoxColumn ltoEquipNo;
        public System.Windows.Forms.DataGridViewTextBoxColumn ltoModel;
        public System.Windows.Forms.DataGridViewTextBoxColumn ltoPlateno;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView HdgvMaintankFuel;
        public System.Windows.Forms.Button btnDFuelLimit;
        public System.Windows.Forms.DataGridViewTextBoxColumn TANKNAME;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
