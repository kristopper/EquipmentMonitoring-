namespace EquipmentMonitoring
{
    partial class UpdateDeleteForm
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
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtHourUsed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtKmTravel = new System.Windows.Forms.TextBox();
            this.txtLastRefuel = new System.Windows.Forms.TextBox();
            this.txtDuringRefuel = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtrefill = new System.Windows.Forms.TextBox();
            this.txtDrivers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.txtHourUsed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtKmTravel);
            this.panel1.Controls.Add(this.txtLastRefuel);
            this.panel1.Controls.Add(this.txtDuringRefuel);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.txtrefill);
            this.panel1.Controls.Add(this.txtDrivers);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labell);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 160);
            this.panel1.TabIndex = 0;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(372, 116);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 13);
            this.lbltotal.TabIndex = 18;
            this.lbltotal.Text = "label8";
            this.lbltotal.Visible = false;
            // 
            // txtHourUsed
            // 
            this.txtHourUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourUsed.Location = new System.Drawing.Point(618, 97);
            this.txtHourUsed.Multiline = true;
            this.txtHourUsed.Name = "txtHourUsed";
            this.txtHourUsed.Size = new System.Drawing.Size(205, 25);
            this.txtHourUsed.TabIndex = 17;
            this.txtHourUsed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHourUsed_keydown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "HOUR USED :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(752, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(670, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtKmTravel
            // 
            this.txtKmTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmTravel.Location = new System.Drawing.Point(618, 66);
            this.txtKmTravel.Multiline = true;
            this.txtKmTravel.Name = "txtKmTravel";
            this.txtKmTravel.Size = new System.Drawing.Size(205, 25);
            this.txtKmTravel.TabIndex = 13;
            this.txtKmTravel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKmTravel_keydown);
            // 
            // txtLastRefuel
            // 
            this.txtLastRefuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastRefuel.Location = new System.Drawing.Point(618, 3);
            this.txtLastRefuel.Multiline = true;
            this.txtLastRefuel.Name = "txtLastRefuel";
            this.txtLastRefuel.Size = new System.Drawing.Size(205, 25);
            this.txtLastRefuel.TabIndex = 11;
            this.txtLastRefuel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastRefuel_keydown);
            // 
            // txtDuringRefuel
            // 
            this.txtDuringRefuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuringRefuel.Location = new System.Drawing.Point(618, 35);
            this.txtDuringRefuel.Multiline = true;
            this.txtDuringRefuel.Name = "txtDuringRefuel";
            this.txtDuringRefuel.Size = new System.Drawing.Size(205, 25);
            this.txtDuringRefuel.TabIndex = 12;
            this.txtDuringRefuel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDuringRefuel_keydown);
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(121, 97);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(205, 25);
            this.txtLocation.TabIndex = 10;
            this.txtLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocation_keydown);
            // 
            // txtrefill
            // 
            this.txtrefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefill.Location = new System.Drawing.Point(121, 66);
            this.txtrefill.Multiline = true;
            this.txtrefill.Name = "txtrefill";
            this.txtrefill.Size = new System.Drawing.Size(205, 25);
            this.txtrefill.TabIndex = 9;
            this.txtrefill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrefill_keydown);
            // 
            // txtDrivers
            // 
            this.txtDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrivers.Location = new System.Drawing.Point(121, 34);
            this.txtDrivers.Multiline = true;
            this.txtDrivers.Name = "txtDrivers";
            this.txtDrivers.Size = new System.Drawing.Size(205, 25);
            this.txtDrivers.TabIndex = 8;
            this.txtDrivers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDrivers_keydown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "KM TRAVELLED :";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell.Location = new System.Drawing.Point(329, 44);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(287, 13);
            this.labell.TabIndex = 5;
            this.labell.Text = "KM/HOUR METER READING DURING REFUEL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "KM/HOUR METER READING LAST REFUEL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LOCATION :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NO. LTRS REFILL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DRIVER\'S NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATE :";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(121, 6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDate.TabIndex = 19;
            // 
            // UpdateDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 163);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(856, 202);
            this.MinimumSize = new System.Drawing.Size(856, 202);
            this.Name = "UpdateDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Daily Sheet Form";
            this.Load += new System.EventHandler(this.UpdateDeleteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labell;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtKmTravel;
        public System.Windows.Forms.TextBox txtLastRefuel;
        public System.Windows.Forms.TextBox txtDuringRefuel;
        public System.Windows.Forms.TextBox txtLocation;
        public System.Windows.Forms.TextBox txtrefill;
        public System.Windows.Forms.TextBox txtDrivers;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtHourUsed;
        public System.Windows.Forms.Label lbltotal;
        public System.Windows.Forms.DateTimePicker dtpDate;
    }
}