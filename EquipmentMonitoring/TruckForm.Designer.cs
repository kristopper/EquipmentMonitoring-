namespace EquipmentMonitoring
{
    partial class TruckForm
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
            this.lblEqpNo = new System.Windows.Forms.Label();
            this.EqpName = new System.Windows.Forms.Label();
            this.PNModelName = new System.Windows.Forms.Label();
            this.txtEqpNo = new System.Windows.Forms.TextBox();
            this.txtEqpName = new System.Windows.Forms.TextBox();
            this.txtPNModelName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtGrossWT = new System.Windows.Forms.TextBox();
            this.txtYearModel = new System.Windows.Forms.TextBox();
            this.txtBodyType = new System.Windows.Forms.TextBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtCylinder = new System.Windows.Forms.TextBox();
            this.txtPiston = new System.Windows.Forms.TextBox();
            this.txtChassisNo = new System.Windows.Forms.TextBox();
            this.txtEngineNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMVFile = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCRNo = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtExisting = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblexisting = new System.Windows.Forms.Label();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            this.cmbPurchase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfuel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkmsltr = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEqpNo
            // 
            this.lblEqpNo.AutoSize = true;
            this.lblEqpNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqpNo.Location = new System.Drawing.Point(298, 129);
            this.lblEqpNo.Name = "lblEqpNo";
            this.lblEqpNo.Size = new System.Drawing.Size(98, 13);
            this.lblEqpNo.TabIndex = 0;
            this.lblEqpNo.Text = "Equipment No. :";
            // 
            // EqpName
            // 
            this.EqpName.AutoSize = true;
            this.EqpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqpName.Location = new System.Drawing.Point(35, 176);
            this.EqpName.Name = "EqpName";
            this.EqpName.Size = new System.Drawing.Size(49, 13);
            this.EqpName.TabIndex = 1;
            this.EqpName.Text = "Model :";
            // 
            // PNModelName
            // 
            this.PNModelName.AutoSize = true;
            this.PNModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNModelName.Location = new System.Drawing.Point(21, 58);
            this.PNModelName.Name = "PNModelName";
            this.PNModelName.Size = new System.Drawing.Size(68, 13);
            this.PNModelName.TabIndex = 2;
            this.PNModelName.Text = "Plate No. :";
            // 
            // txtEqpNo
            // 
            this.txtEqpNo.Location = new System.Drawing.Point(396, 125);
            this.txtEqpNo.MaxLength = 100;
            this.txtEqpNo.Multiline = true;
            this.txtEqpNo.Name = "txtEqpNo";
            this.txtEqpNo.Size = new System.Drawing.Size(205, 20);
            this.txtEqpNo.TabIndex = 12;
            this.txtEqpNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEqpNo_keydown);
            // 
            // txtEqpName
            // 
            this.txtEqpName.Location = new System.Drawing.Point(85, 171);
            this.txtEqpName.MaxLength = 350;
            this.txtEqpName.Multiline = true;
            this.txtEqpName.Name = "txtEqpName";
            this.txtEqpName.Size = new System.Drawing.Size(207, 20);
            this.txtEqpName.TabIndex = 7;
            this.txtEqpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEqpName_keydown);
            // 
            // txtPNModelName
            // 
            this.txtPNModelName.Location = new System.Drawing.Point(87, 54);
            this.txtPNModelName.MaxLength = 350;
            this.txtPNModelName.Multiline = true;
            this.txtPNModelName.Name = "txtPNModelName";
            this.txtPNModelName.Size = new System.Drawing.Size(205, 20);
            this.txtPNModelName.TabIndex = 2;
            this.txtPNModelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPNModelName_keydown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(535, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtkmsltr);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtHourlyRate);
            this.panel1.Controls.Add(this.txtGrossWT);
            this.panel1.Controls.Add(this.txtYearModel);
            this.panel1.Controls.Add(this.txtBodyType);
            this.panel1.Controls.Add(this.txtSeries);
            this.panel1.Controls.Add(this.txtMake);
            this.panel1.Controls.Add(this.txtCylinder);
            this.panel1.Controls.Add(this.txtPiston);
            this.panel1.Controls.Add(this.txtChassisNo);
            this.panel1.Controls.Add(this.txtEngineNo);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmbfuel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPNModelName);
            this.panel1.Controls.Add(this.lblEqpNo);
            this.panel1.Controls.Add(this.EqpName);
            this.panel1.Controls.Add(this.PNModelName);
            this.panel1.Controls.Add(this.txtEqpName);
            this.panel1.Controls.Add(this.txtEqpNo);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 371);
            this.panel1.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(55, 196);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Hourly Rate :";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(137, 192);
            this.txtHourlyRate.MaxLength = 350;
            this.txtHourlyRate.Multiline = true;
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(155, 20);
            this.txtHourlyRate.TabIndex = 29;
            this.txtHourlyRate.Text = "0";
            // 
            // txtGrossWT
            // 
            this.txtGrossWT.Location = new System.Drawing.Point(396, 148);
            this.txtGrossWT.MaxLength = 100;
            this.txtGrossWT.Multiline = true;
            this.txtGrossWT.Name = "txtGrossWT";
            this.txtGrossWT.Size = new System.Drawing.Size(205, 20);
            this.txtGrossWT.TabIndex = 13;
            this.txtGrossWT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGrossWT_keydown);
            // 
            // txtYearModel
            // 
            this.txtYearModel.Location = new System.Drawing.Point(396, 171);
            this.txtYearModel.MaxLength = 50;
            this.txtYearModel.Multiline = true;
            this.txtYearModel.Name = "txtYearModel";
            this.txtYearModel.Size = new System.Drawing.Size(205, 20);
            this.txtYearModel.TabIndex = 14;
            this.txtYearModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYearModel_keydown);
            // 
            // txtBodyType
            // 
            this.txtBodyType.Location = new System.Drawing.Point(396, 102);
            this.txtBodyType.MaxLength = 350;
            this.txtBodyType.Multiline = true;
            this.txtBodyType.Name = "txtBodyType";
            this.txtBodyType.Size = new System.Drawing.Size(205, 20);
            this.txtBodyType.TabIndex = 11;
            this.txtBodyType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBodyType_keydown);
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(396, 78);
            this.txtSeries.MaxLength = 350;
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(205, 20);
            this.txtSeries.TabIndex = 10;
            this.txtSeries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSeries_keydown);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(396, 54);
            this.txtMake.MaxLength = 350;
            this.txtMake.Multiline = true;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(205, 20);
            this.txtMake.TabIndex = 9;
            this.txtMake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMake_keydown);
            // 
            // txtCylinder
            // 
            this.txtCylinder.Location = new System.Drawing.Point(137, 148);
            this.txtCylinder.MaxLength = 350;
            this.txtCylinder.Multiline = true;
            this.txtCylinder.Name = "txtCylinder";
            this.txtCylinder.Size = new System.Drawing.Size(155, 20);
            this.txtCylinder.TabIndex = 6;
            this.txtCylinder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCylinder_keydown);
            // 
            // txtPiston
            // 
            this.txtPiston.Location = new System.Drawing.Point(137, 124);
            this.txtPiston.MaxLength = 350;
            this.txtPiston.Multiline = true;
            this.txtPiston.Name = "txtPiston";
            this.txtPiston.Size = new System.Drawing.Size(155, 20);
            this.txtPiston.TabIndex = 5;
            this.txtPiston.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPiston_keydown);
            // 
            // txtChassisNo
            // 
            this.txtChassisNo.Location = new System.Drawing.Point(87, 101);
            this.txtChassisNo.MaxLength = 350;
            this.txtChassisNo.Multiline = true;
            this.txtChassisNo.Name = "txtChassisNo";
            this.txtChassisNo.Size = new System.Drawing.Size(205, 20);
            this.txtChassisNo.TabIndex = 4;
            this.txtChassisNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChassisNo_keydown);
            // 
            // txtEngineNo
            // 
            this.txtEngineNo.Location = new System.Drawing.Point(87, 78);
            this.txtEngineNo.MaxLength = 350;
            this.txtEngineNo.Multiline = true;
            this.txtEngineNo.Name = "txtEngineNo";
            this.txtEngineNo.Size = new System.Drawing.Size(205, 20);
            this.txtEngineNo.TabIndex = 3;
            this.txtEngineNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEngineNo_keydown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(318, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Year Model :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(346, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Series :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(350, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Make :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "No. of Cylinders :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Chassis No. :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(325, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Gross WT :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Piston Displacement :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Engine No. :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMVFile);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtCRNo);
            this.groupBox1.Controls.Add(this.txtSupplier);
            this.groupBox1.Controls.Add(this.txtExisting);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblexisting);
            this.groupBox1.Controls.Add(this.dtpPurchase);
            this.groupBox1.Controls.Add(this.cmbPurchase);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 151);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Type";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(260, 124);
            this.txtYear.MaxLength = 10;
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(77, 20);
            this.txtYear.TabIndex = 23;
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_keydown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Unit Price :";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(393, 37);
            this.txtUnitPrice.MaxLength = 100;
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(194, 20);
            this.txtUnitPrice.TabIndex = 21;
            this.txtUnitPrice.Text = "0";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "",
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.cmbMonth.Location = new System.Drawing.Point(155, 124);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(100, 21);
            this.cmbMonth.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "MV File No. :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(278, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "YEAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "CR No. :";
            // 
            // txtMVFile
            // 
            this.txtMVFile.Location = new System.Drawing.Point(86, 62);
            this.txtMVFile.MaxLength = 150;
            this.txtMVFile.Multiline = true;
            this.txtMVFile.Name = "txtMVFile";
            this.txtMVFile.Size = new System.Drawing.Size(221, 20);
            this.txtMVFile.TabIndex = 17;
            this.txtMVFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMVFile_keydown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(182, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "MONTH";
            // 
            // txtCRNo
            // 
            this.txtCRNo.Location = new System.Drawing.Point(393, 62);
            this.txtCRNo.MaxLength = 100;
            this.txtCRNo.Multiline = true;
            this.txtCRNo.Name = "txtCRNo";
            this.txtCRNo.Size = new System.Drawing.Size(205, 20);
            this.txtCRNo.TabIndex = 18;
            this.txtCRNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCRNo_keydown);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(86, 88);
            this.txtSupplier.MaxLength = 350;
            this.txtSupplier.Multiline = true;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(221, 20);
            this.txtSupplier.TabIndex = 19;
            this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_keydown);
            // 
            // txtExisting
            // 
            this.txtExisting.Location = new System.Drawing.Point(393, 11);
            this.txtExisting.MaxLength = 150;
            this.txtExisting.Multiline = true;
            this.txtExisting.Name = "txtExisting";
            this.txtExisting.Size = new System.Drawing.Size(194, 20);
            this.txtExisting.TabIndex = 20;
            this.txtExisting.Text = "0";
            this.txtExisting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExisting_keydown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Supplier :";
            // 
            // lblexisting
            // 
            this.lblexisting.AutoSize = true;
            this.lblexisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexisting.Location = new System.Drawing.Point(284, 15);
            this.lblexisting.Name = "lblexisting";
            this.lblexisting.Size = new System.Drawing.Size(110, 13);
            this.lblexisting.TabIndex = 19;
            this.lblexisting.Text = "Existing Reading :";
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.CustomFormat = "MM/dd/yyyy";
            this.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchase.Location = new System.Drawing.Point(131, 38);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.Size = new System.Drawing.Size(114, 20);
            this.dtpPurchase.TabIndex = 16;
            // 
            // cmbPurchase
            // 
            this.cmbPurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchase.FormattingEnabled = true;
            this.cmbPurchase.Items.AddRange(new object[] {
            "Brand New",
            "Second Hand"});
            this.cmbPurchase.Location = new System.Drawing.Point(131, 13);
            this.cmbPurchase.Name = "cmbPurchase";
            this.cmbPurchase.Size = new System.Drawing.Size(114, 21);
            this.cmbPurchase.TabIndex = 15;
            this.cmbPurchase.SelectedIndexChanged += new System.EventHandler(this.cmbPurchase_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date Of Purchase :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Register Expiration Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Status of Purchase ;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Body Type :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lnkClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 27);
            this.panel2.TabIndex = 14;
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkColor = System.Drawing.Color.Red;
            this.lnkClose.Location = new System.Drawing.Point(557, 3);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(43, 17);
            this.lnkClose.TabIndex = 27;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "Close";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ADD UNIT FORM";
            // 
            // cmbfuel
            // 
            this.cmbfuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfuel.FormattingEnabled = true;
            this.cmbfuel.Location = new System.Drawing.Point(87, 30);
            this.cmbfuel.Name = "cmbfuel";
            this.cmbfuel.Size = new System.Drawing.Size(142, 21);
            this.cmbfuel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fuel Type :";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(396, 30);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(142, 21);
            this.cmbType.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type :";
            // 
            // txtkmsltr
            // 
            this.txtkmsltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkmsltr.Location = new System.Drawing.Point(396, 195);
            this.txtkmsltr.MaxLength = 50;
            this.txtkmsltr.Multiline = true;
            this.txtkmsltr.Name = "txtkmsltr";
            this.txtkmsltr.Size = new System.Drawing.Size(205, 20);
            this.txtkmsltr.TabIndex = 30;
            this.txtkmsltr.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(329, 200);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Kms / Ltr :";
            // 
            // TruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 376);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TruckForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEqpNo;
        private System.Windows.Forms.Label EqpName;
        private System.Windows.Forms.Label PNModelName;
        private System.Windows.Forms.TextBox txtEqpNo;
        private System.Windows.Forms.TextBox txtEqpName;
        private System.Windows.Forms.TextBox txtPNModelName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbfuel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPurchase;
        private System.Windows.Forms.DateTimePicker dtpPurchase;
        private System.Windows.Forms.Label lblexisting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEngineNo;
        private System.Windows.Forms.TextBox txtChassisNo;
        private System.Windows.Forms.TextBox txtCylinder;
        private System.Windows.Forms.TextBox txtPiston;
        private System.Windows.Forms.TextBox txtYearModel;
        private System.Windows.Forms.TextBox txtBodyType;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtGrossWT;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtExisting;
        private System.Windows.Forms.TextBox txtMVFile;
        private System.Windows.Forms.TextBox txtCRNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtkmsltr;
        private System.Windows.Forms.Label label23;
    }
}