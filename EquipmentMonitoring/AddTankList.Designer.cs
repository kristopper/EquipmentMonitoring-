namespace EquipmentMonitoring
{
    partial class AddTankList
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkIsMain);
            this.panel1.Controls.Add(this.txtGauge);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTankCapacity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtModelName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtPlateNo);
            this.panel1.Controls.Add(this.txtEquipmentNo);
            this.panel1.Controls.Add(this.txtTankName);
            this.panel1.Controls.Add(this.cmbTypeofFuel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 263);
            this.panel1.TabIndex = 0;
            // 
            // chkIsMain
            // 
            this.chkIsMain.AutoSize = true;
            this.chkIsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsMain.Location = new System.Drawing.Point(117, 211);
            this.chkIsMain.Name = "chkIsMain";
            this.chkIsMain.Size = new System.Drawing.Size(84, 19);
            this.chkIsMain.TabIndex = 8;
            this.chkIsMain.Text = "Main Tank";
            this.chkIsMain.UseVisualStyleBackColor = true;
            this.chkIsMain.CheckedChanged += new System.EventHandler(this.chkIsMain_ChekedChanged);
            // 
            // txtGauge
            // 
            this.txtGauge.Location = new System.Drawing.Point(118, 185);
            this.txtGauge.Multiline = true;
            this.txtGauge.Name = "txtGauge";
            this.txtGauge.Size = new System.Drawing.Size(165, 22);
            this.txtGauge.TabIndex = 7;
            this.txtGauge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGauge_keydown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tank Gauge :";
            // 
            // txtTankCapacity
            // 
            this.txtTankCapacity.Location = new System.Drawing.Point(118, 126);
            this.txtTankCapacity.Multiline = true;
            this.txtTankCapacity.Name = "txtTankCapacity";
            this.txtTankCapacity.Size = new System.Drawing.Size(165, 22);
            this.txtTankCapacity.TabIndex = 5;
            this.txtTankCapacity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankCapacity_keydown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tank Capacity :";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(118, 96);
            this.txtModelName.Multiline = true;
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(165, 22);
            this.txtModelName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Model :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Location = new System.Drawing.Point(118, 154);
            this.txtPlateNo.Multiline = true;
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(165, 22);
            this.txtPlateNo.TabIndex = 6;
            this.txtPlateNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoName_keydown);
            // 
            // txtEquipmentNo
            // 
            this.txtEquipmentNo.Location = new System.Drawing.Point(118, 65);
            this.txtEquipmentNo.Multiline = true;
            this.txtEquipmentNo.Name = "txtEquipmentNo";
            this.txtEquipmentNo.Size = new System.Drawing.Size(165, 22);
            this.txtEquipmentNo.TabIndex = 3;
            this.txtEquipmentNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEquipmentNo_keydown);
            // 
            // txtTankName
            // 
            this.txtTankName.Location = new System.Drawing.Point(118, 34);
            this.txtTankName.Multiline = true;
            this.txtTankName.Name = "txtTankName";
            this.txtTankName.Size = new System.Drawing.Size(165, 22);
            this.txtTankName.TabIndex = 2;
            this.txtTankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankName_keydown);
            // 
            // cmbTypeofFuel
            // 
            this.cmbTypeofFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeofFuel.FormattingEnabled = true;
            this.cmbTypeofFuel.Location = new System.Drawing.Point(119, 5);
            this.cmbTypeofFuel.Name = "cmbTypeofFuel";
            this.cmbTypeofFuel.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeofFuel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipment No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plate No. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tank Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Fuel :";
            // 
            // AddTankList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(305, 273);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(321, 312);
            this.MinimumSize = new System.Drawing.Size(321, 312);
            this.Name = "AddTankList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Tank List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTypeofFuel;
        private System.Windows.Forms.TextBox txtPlateNo;
        private System.Windows.Forms.TextBox txtEquipmentNo;
        private System.Windows.Forms.TextBox txtTankName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTankCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGauge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkIsMain;
    }
}