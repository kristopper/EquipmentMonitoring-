namespace EquipmentMonitoring
{
    partial class RegisterTruck
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.TruckFormControl = new EquipmentMonitoring.UserFormControl.TruckFormControl();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(528, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBack.LinkColor = System.Drawing.Color.Red;
            this.lnkBack.Location = new System.Drawing.Point(574, 5);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(39, 17);
            this.lnkBack.TabIndex = 2;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // TruckFormControl
            // 
            this.TruckFormControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TruckFormControl.Location = new System.Drawing.Point(2, -4);
            this.TruckFormControl.Name = "TruckFormControl";
            this.TruckFormControl.Size = new System.Drawing.Size(624, 432);
            this.TruckFormControl.TabIndex = 0;
            // 
            // RegisterTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 427);
            this.ControlBox = false;
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TruckFormControl);
            this.Name = "RegisterTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterTruck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserFormControl.TruckFormControl TruckFormControl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lnkBack;
    }
}