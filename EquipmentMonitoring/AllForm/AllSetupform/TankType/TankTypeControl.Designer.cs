namespace EquipmentMonitoring.AllForm.AllSetupform.TankType
{
    partial class TankTypeControl
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
            this.dgvTankType = new System.Windows.Forms.DataGridView();
            this.lnkAddTankType = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditGroup = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.chkIsMain = new System.Windows.Forms.CheckBox();
            this.txtGauge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTankCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.txtEquipmentNo = new System.Windows.Forms.TextBox();
            this.txtTankName = new System.Windows.Forms.TextBox();
            this.cmbTypeofFuel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddGroup = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.dgvAddTankType = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfuelLimit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPEOFFUEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANKNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EQUIPMENTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLATENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANKCAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANKGAUGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMaintank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAINTANK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FuelLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTankType)).BeginInit();
            this.panel2.SuspendLayout();
            this.EditGroup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.AddGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTankType)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 35);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "TANK TYPE";
            // 
            // dgvTankType
            // 
            this.dgvTankType.AllowUserToAddRows = false;
            this.dgvTankType.AllowUserToDeleteRows = false;
            this.dgvTankType.AllowUserToOrderColumns = true;
            this.dgvTankType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTankType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TYPEOFFUEL,
            this.TANKNAME,
            this.EQUIPMENTNO,
            this.MODEL,
            this.PLATENO,
            this.TANKCAPACITY,
            this.TANKGAUGE,
            this.isMaintank,
            this.TankLimit});
            this.dgvTankType.Location = new System.Drawing.Point(9, 48);
            this.dgvTankType.Name = "dgvTankType";
            this.dgvTankType.Size = new System.Drawing.Size(835, 223);
            this.dgvTankType.TabIndex = 4;
            // 
            // lnkAddTankType
            // 
            this.lnkAddTankType.AutoSize = true;
            this.lnkAddTankType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddTankType.Location = new System.Drawing.Point(9, 284);
            this.lnkAddTankType.Name = "lnkAddTankType";
            this.lnkAddTankType.Size = new System.Drawing.Size(106, 13);
            this.lnkAddTankType.TabIndex = 6;
            this.lnkAddTankType.TabStop = true;
            this.lnkAddTankType.Text = "ADD TANK TYPE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lnkAddTankType);
            this.panel2.Controls.Add(this.dgvTankType);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 333);
            this.panel2.TabIndex = 7;
            // 
            // EditGroup
            // 
            this.EditGroup.Controls.Add(this.panel3);
            this.EditGroup.Location = new System.Drawing.Point(850, -8);
            this.EditGroup.Name = "EditGroup";
            this.EditGroup.Size = new System.Drawing.Size(314, 341);
            this.EditGroup.TabIndex = 8;
            this.EditGroup.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtfuelLimit);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Controls.Add(this.lnkDelete);
            this.panel3.Controls.Add(this.chkIsMain);
            this.panel3.Controls.Add(this.txtGauge);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTankCapacity);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtModelName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.txtPlateNo);
            this.panel3.Controls.Add(this.txtEquipmentNo);
            this.panel3.Controls.Add(this.txtTankName);
            this.panel3.Controls.Add(this.cmbTypeofFuel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(6, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 328);
            this.panel3.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(41, 13);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "label10";
            this.lblId.Visible = false;
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(246, 6);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(49, 13);
            this.lnkDelete.TabIndex = 13;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "DELETE";
            // 
            // chkIsMain
            // 
            this.chkIsMain.AutoSize = true;
            this.chkIsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsMain.Location = new System.Drawing.Point(120, 277);
            this.chkIsMain.Name = "chkIsMain";
            this.chkIsMain.Size = new System.Drawing.Size(84, 19);
            this.chkIsMain.TabIndex = 8;
            this.chkIsMain.Text = "Main Tank";
            this.chkIsMain.UseVisualStyleBackColor = true;
            // 
            // txtGauge
            // 
            this.txtGauge.Location = new System.Drawing.Point(121, 223);
            this.txtGauge.Multiline = true;
            this.txtGauge.Name = "txtGauge";
            this.txtGauge.Size = new System.Drawing.Size(165, 22);
            this.txtGauge.TabIndex = 7;
            this.txtGauge.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tank Gauge :";
            // 
            // txtTankCapacity
            // 
            this.txtTankCapacity.Location = new System.Drawing.Point(121, 164);
            this.txtTankCapacity.Multiline = true;
            this.txtTankCapacity.Name = "txtTankCapacity";
            this.txtTankCapacity.Size = new System.Drawing.Size(165, 22);
            this.txtTankCapacity.TabIndex = 5;
            this.txtTankCapacity.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tank Capacity :";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(121, 134);
            this.txtModelName.Multiline = true;
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(165, 22);
            this.txtModelName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Model :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(211, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Location = new System.Drawing.Point(121, 192);
            this.txtPlateNo.Multiline = true;
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(165, 22);
            this.txtPlateNo.TabIndex = 6;
            // 
            // txtEquipmentNo
            // 
            this.txtEquipmentNo.Location = new System.Drawing.Point(121, 103);
            this.txtEquipmentNo.Multiline = true;
            this.txtEquipmentNo.Name = "txtEquipmentNo";
            this.txtEquipmentNo.Size = new System.Drawing.Size(165, 22);
            this.txtEquipmentNo.TabIndex = 3;
            // 
            // txtTankName
            // 
            this.txtTankName.Location = new System.Drawing.Point(121, 72);
            this.txtTankName.Multiline = true;
            this.txtTankName.Name = "txtTankName";
            this.txtTankName.Size = new System.Drawing.Size(165, 22);
            this.txtTankName.TabIndex = 2;
            // 
            // cmbTypeofFuel
            // 
            this.cmbTypeofFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeofFuel.FormattingEnabled = true;
            this.cmbTypeofFuel.Location = new System.Drawing.Point(122, 43);
            this.cmbTypeofFuel.Name = "cmbTypeofFuel";
            this.cmbTypeofFuel.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeofFuel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipment No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plate No. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tank Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type of Fuel :";
            // 
            // AddGroup
            // 
            this.AddGroup.Controls.Add(this.panel4);
            this.AddGroup.Location = new System.Drawing.Point(3, 339);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(1161, 303);
            this.AddGroup.TabIndex = 9;
            this.AddGroup.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnAddSave);
            this.panel4.Controls.Add(this.btnAddCancel);
            this.panel4.Controls.Add(this.dgvAddTankType);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1161, 288);
            this.panel4.TabIndex = 0;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(926, 234);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddSave.TabIndex = 14;
            this.btnAddSave.Text = "Save";
            this.btnAddSave.UseVisualStyleBackColor = true;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(845, 234);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 15;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // dgvAddTankType
            // 
            this.dgvAddTankType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddTankType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.MAINTANK,
            this.FuelLimit});
            this.dgvAddTankType.Location = new System.Drawing.Point(143, 45);
            this.dgvAddTankType.Name = "dgvAddTankType";
            this.dgvAddTankType.Size = new System.Drawing.Size(875, 178);
            this.dgvAddTankType.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(-2, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1161, 35);
            this.panel5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "ADD TANK TYPE";
            // 
            // txtfuelLimit
            // 
            this.txtfuelLimit.Location = new System.Drawing.Point(121, 251);
            this.txtfuelLimit.Multiline = true;
            this.txtfuelLimit.Name = "txtfuelLimit";
            this.txtfuelLimit.Size = new System.Drawing.Size(166, 22);
            this.txtfuelLimit.TabIndex = 15;
            this.txtfuelLimit.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Fuel Limit :";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 5;
            // 
            // TYPEOFFUEL
            // 
            this.TYPEOFFUEL.HeaderText = "TYPE OF FUEL";
            this.TYPEOFFUEL.Name = "TYPEOFFUEL";
            this.TYPEOFFUEL.ReadOnly = true;
            // 
            // TANKNAME
            // 
            this.TANKNAME.HeaderText = "TANK NAME";
            this.TANKNAME.Name = "TANKNAME";
            this.TANKNAME.ReadOnly = true;
            // 
            // EQUIPMENTNO
            // 
            this.EQUIPMENTNO.HeaderText = "EQUIPMENT NO";
            this.EQUIPMENTNO.Name = "EQUIPMENTNO";
            this.EQUIPMENTNO.ReadOnly = true;
            this.EQUIPMENTNO.Width = 107;
            // 
            // MODEL
            // 
            this.MODEL.HeaderText = "MODEL";
            this.MODEL.Name = "MODEL";
            this.MODEL.ReadOnly = true;
            // 
            // PLATENO
            // 
            this.PLATENO.HeaderText = "PLATE NO";
            this.PLATENO.Name = "PLATENO";
            this.PLATENO.ReadOnly = true;
            // 
            // TANKCAPACITY
            // 
            this.TANKCAPACITY.HeaderText = "TANK CAPACITY";
            this.TANKCAPACITY.Name = "TANKCAPACITY";
            this.TANKCAPACITY.ReadOnly = true;
            // 
            // TANKGAUGE
            // 
            this.TANKGAUGE.HeaderText = "TANK GAUGE";
            this.TANKGAUGE.Name = "TANKGAUGE";
            this.TANKGAUGE.ReadOnly = true;
            // 
            // isMaintank
            // 
            this.isMaintank.HeaderText = "MAIN";
            this.isMaintank.Name = "isMaintank";
            this.isMaintank.ReadOnly = true;
            this.isMaintank.Width = 80;
            // 
            // TankLimit
            // 
            this.TankLimit.HeaderText = "TANK LIMIT";
            this.TankLimit.Name = "TankLimit";
            this.TankLimit.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TANK NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "EQUIPMENT NO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "MODEL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "PLATE NO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "TANK CAPACITY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "TANK GAUGE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // MAINTANK
            // 
            this.MAINTANK.HeaderText = "MAIN";
            this.MAINTANK.Name = "MAINTANK";
            this.MAINTANK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MAINTANK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MAINTANK.Width = 45;
            // 
            // FuelLimit
            // 
            this.FuelLimit.HeaderText = "FUEL LIMIT";
            this.FuelLimit.Name = "FuelLimit";
            // 
            // TankTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.EditGroup);
            this.Controls.Add(this.panel2);
            this.Name = "TankTypeControl";
            this.Size = new System.Drawing.Size(1167, 644);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTankType)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.EditGroup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.AddGroup.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTankType)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.CheckBox chkIsMain;
        public System.Windows.Forms.TextBox txtGauge;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTankCapacity;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtModelName;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtPlateNo;
        public System.Windows.Forms.TextBox txtEquipmentNo;
        public System.Windows.Forms.TextBox txtTankName;
        public System.Windows.Forms.ComboBox cmbTypeofFuel;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnAddSave;
        public System.Windows.Forms.Button btnAddCancel;
        public System.Windows.Forms.DataGridView dgvAddTankType;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.GroupBox EditGroup;
        public System.Windows.Forms.GroupBox AddGroup;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.LinkLabel lnkDelete;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvTankType;
        public System.Windows.Forms.LinkLabel lnkAddTankType;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtfuelLimit;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridViewTextBoxColumn id;
        public System.Windows.Forms.DataGridViewTextBoxColumn TYPEOFFUEL;
        public System.Windows.Forms.DataGridViewTextBoxColumn TANKNAME;
        public System.Windows.Forms.DataGridViewTextBoxColumn EQUIPMENTNO;
        public System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        public System.Windows.Forms.DataGridViewTextBoxColumn PLATENO;
        public System.Windows.Forms.DataGridViewTextBoxColumn TANKCAPACITY;
        public System.Windows.Forms.DataGridViewTextBoxColumn TANKGAUGE;
        public System.Windows.Forms.DataGridViewTextBoxColumn isMaintank;
        public System.Windows.Forms.DataGridViewTextBoxColumn TankLimit;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public System.Windows.Forms.DataGridViewCheckBoxColumn MAINTANK;
        public System.Windows.Forms.DataGridViewTextBoxColumn FuelLimit;
    }
}
