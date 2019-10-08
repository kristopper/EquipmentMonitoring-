namespace EquipmentMonitoring
{
    partial class AddDailyActivity
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltoEquipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltoModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltoPlateno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMaintenanceList = new System.Windows.Forms.DataGridView();
            this.Datecreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvDailySheet = new System.Windows.Forms.DataGridView();
            this.tank = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driversname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfltrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Others = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySheet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.dgvDailySheet);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 678);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(503, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 145);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LTO Registration List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registration,
            this.ltoEquipNo,
            this.ltoModel,
            this.ltoPlateno});
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 123);
            this.dataGridView1.TabIndex = 0;
            // 
            // Registration
            // 
            this.Registration.HeaderText = "EXPIRATION DATE";
            this.Registration.Name = "Registration";
            // 
            // ltoEquipNo
            // 
            this.ltoEquipNo.HeaderText = "EQUIPMENT NO.";
            this.ltoEquipNo.Name = "ltoEquipNo";
            // 
            // ltoModel
            // 
            this.ltoModel.HeaderText = "MODEL";
            this.ltoModel.Name = "ltoModel";
            // 
            // ltoPlateno
            // 
            this.ltoPlateno.HeaderText = "PLATE NO.";
            this.ltoPlateno.Name = "ltoPlateno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EquipmentMonitoring.Properties.Resources._new;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(1129, 364);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(122, 25);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View Equipment";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMaintenanceList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(503, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 217);
            this.groupBox1.TabIndex = 3;
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
            this.dgvMaintenanceList.Location = new System.Drawing.Point(8, 21);
            this.dgvMaintenanceList.Name = "dgvMaintenanceList";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenanceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            this.dgvMaintenanceList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaintenanceList.Size = new System.Drawing.Size(733, 191);
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
            this.EquipNo.Width = 130;
            // 
            // modelno
            // 
            this.modelno.HeaderText = "MODEL";
            this.modelno.Name = "modelno";
            this.modelno.ReadOnly = true;
            this.modelno.Width = 130;
            // 
            // PlateNumber
            // 
            this.PlateNumber.HeaderText = "PLATE NO.";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.ReadOnly = true;
            this.PlateNumber.Width = 130;
            // 
            // totalKm
            // 
            this.totalKm.HeaderText = "TOTAL KMS";
            this.totalKm.Name = "totalKm";
            this.totalKm.ReadOnly = true;
            // 
            // totalhr
            // 
            this.totalhr.HeaderText = "TOTAL HRS";
            this.totalhr.Name = "totalhr";
            this.totalhr.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1170, 650);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1089, 650);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvDailySheet
            // 
            this.dgvDailySheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailySheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tank,
            this.Date,
            this.EquipmentNo,
            this.Driversname,
            this.NoOfltrs,
            this.kms,
            this.hrs,
            this.projectsite,
            this.PumpIncharge,
            this.Others,
            this.Operation});
            this.dgvDailySheet.Location = new System.Drawing.Point(8, 391);
            this.dgvDailySheet.Name = "dgvDailySheet";
            this.dgvDailySheet.Size = new System.Drawing.Size(1243, 257);
            this.dgvDailySheet.TabIndex = 0;
            this.dgvDailySheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailySheet_CellContentClick);
            this.dgvDailySheet.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDailySheet_CellFormatting);
            this.dgvDailySheet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailySheet_CellValueChanged);
            this.dgvDailySheet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDailySheet_DataError);
            this.dgvDailySheet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDailySheet_EditingControlShowing);
            this.dgvDailySheet.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDailySheet_RowsAdded);
            // 
            // tank
            // 
            this.tank.Frozen = true;
            this.tank.HeaderText = "";
            this.tank.Name = "tank";
            this.tank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tank.Width = 40;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 85;
            // 
            // EquipmentNo
            // 
            this.EquipmentNo.Frozen = true;
            this.EquipmentNo.HeaderText = "EquipNo/Model/PlateNo";
            this.EquipmentNo.Name = "EquipmentNo";
            this.EquipmentNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EquipmentNo.Width = 150;
            // 
            // Driversname
            // 
            this.Driversname.Frozen = true;
            this.Driversname.HeaderText = "DRIVER\'S NAME";
            this.Driversname.Name = "Driversname";
            this.Driversname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Driversname.Width = 120;
            // 
            // NoOfltrs
            // 
            this.NoOfltrs.Frozen = true;
            this.NoOfltrs.HeaderText = "NO. OF LITERS/REFILLED";
            this.NoOfltrs.Name = "NoOfltrs";
            this.NoOfltrs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NoOfltrs.Width = 110;
            // 
            // kms
            // 
            this.kms.HeaderText = "KMS";
            this.kms.Name = "kms";
            this.kms.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kms.Width = 70;
            // 
            // hrs
            // 
            this.hrs.HeaderText = "HRS";
            this.hrs.Name = "hrs";
            this.hrs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hrs.Width = 70;
            // 
            // projectsite
            // 
            this.projectsite.HeaderText = "PROJECT SITE";
            this.projectsite.Name = "projectsite";
            this.projectsite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.projectsite.Width = 130;
            // 
            // PumpIncharge
            // 
            this.PumpIncharge.HeaderText = "PUMP INCHARGE";
            this.PumpIncharge.Name = "PumpIncharge";
            this.PumpIncharge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Others
            // 
            this.Others.HeaderText = "OTHERS";
            this.Others.Name = "Others";
            this.Others.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "OPERATION";
            this.Operation.Name = "Operation";
            this.Operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddDailyActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1265, 682);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1281, 721);
            this.MinimumSize = new System.Drawing.Size(1281, 721);
            this.Name = "AddDailyActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddDailyActivity_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDailySheet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMaintenanceList;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datecreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelno;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltoEquipNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltoModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltoPlateno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driversname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfltrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn kms;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PumpIncharge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Others;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    }
}