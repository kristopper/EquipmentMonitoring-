namespace EquipmentMonitoring
{
    partial class AddEquipmentType
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
            this.lblTrucktype = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTrucktype = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cmbLimitBase = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkmLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrucktype
            // 
            this.lblTrucktype.AutoSize = true;
            this.lblTrucktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrucktype.Location = new System.Drawing.Point(7, 46);
            this.lblTrucktype.Name = "lblTrucktype";
            this.lblTrucktype.Size = new System.Drawing.Size(84, 15);
            this.lblTrucktype.TabIndex = 0;
            this.lblTrucktype.Text = "Truck Type :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // txtTrucktype
            // 
            this.txtTrucktype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrucktype.Location = new System.Drawing.Point(91, 39);
            this.txtTrucktype.Multiline = true;
            this.txtTrucktype.Name = "txtTrucktype";
            this.txtTrucktype.Size = new System.Drawing.Size(152, 25);
            this.txtTrucktype.TabIndex = 2;
            this.txtTrucktype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTruckType_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(91, 69);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(152, 25);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.test);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(182, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(114, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtLimit);
            this.panel1.Controls.Add(this.cmbLimitBase);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtkmLimit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblTrucktype);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.txtTrucktype);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 227);
            this.panel1.TabIndex = 6;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(152, 128);
            this.txtLimit.Multiline = true;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(92, 25);
            this.txtLimit.TabIndex = 5;
            this.txtLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLimit_keydown);
            // 
            // cmbLimitBase
            // 
            this.cmbLimitBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLimitBase.FormattingEnabled = true;
            this.cmbLimitBase.Items.AddRange(new object[] {
            "KM",
            "HR"});
            this.cmbLimitBase.Location = new System.Drawing.Point(93, 104);
            this.cmbLimitBase.Name = "cmbLimitBase";
            this.cmbLimitBase.Size = new System.Drawing.Size(149, 21);
            this.cmbLimitBase.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Limit Base :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "HR :";
            // 
            // txtHr
            // 
            this.txtHr.Location = new System.Drawing.Point(168, 159);
            this.txtHr.Multiline = true;
            this.txtHr.Name = "txtHr";
            this.txtHr.Size = new System.Drawing.Size(76, 25);
            this.txtHr.TabIndex = 7;
            this.txtHr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHr_Keydown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "KM :";
            // 
            // txtkmLimit
            // 
            this.txtkmLimit.Location = new System.Drawing.Point(48, 159);
            this.txtkmLimit.Multiline = true;
            this.txtkmLimit.Name = "txtkmLimit";
            this.txtkmLimit.Size = new System.Drawing.Size(76, 25);
            this.txtkmLimit.TabIndex = 6;
            this.txtkmLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkmLimit_Keydown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Limit to Maintanance :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADD TRUCK TYPE";
            // 
            // AddEquipmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(259, 232);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 271);
            this.Name = "AddEquipmentType";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Truck Type";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrucktype;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTrucktype;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkmLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLimitBase;
        private System.Windows.Forms.TextBox txtLimit;
    }
}