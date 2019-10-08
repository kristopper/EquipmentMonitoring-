namespace EquipmentMonitoring
{
    partial class ChangePassword
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
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblNewpassword = new System.Windows.Forms.Label();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtcurrentpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.ForeColor = System.Drawing.Color.DarkRed;
            this.lblConfirmPass.Location = new System.Drawing.Point(163, 99);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(163, 13);
            this.lblConfirmPass.TabIndex = 17;
            this.lblConfirmPass.Text = "Cannot be less than 8 characters";
            this.lblConfirmPass.Visible = false;
            // 
            // lblNewpassword
            // 
            this.lblNewpassword.AutoSize = true;
            this.lblNewpassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNewpassword.Location = new System.Drawing.Point(108, 54);
            this.lblNewpassword.Name = "lblNewpassword";
            this.lblNewpassword.Size = new System.Drawing.Size(163, 13);
            this.lblNewpassword.TabIndex = 16;
            this.lblNewpassword.Text = "Cannot be less than 8 characters";
            this.lblNewpassword.Visible = false;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirm.Location = new System.Drawing.Point(8, 115);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.Size = new System.Drawing.Size(318, 21);
            this.txtconfirm.TabIndex = 13;
            this.txtconfirm.TextChanged += new System.EventHandler(this.txtconfirm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirm New Password :";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Location = new System.Drawing.Point(242, 142);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 28);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(7, 70);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '*';
            this.txtnewpass.Size = new System.Drawing.Size(319, 21);
            this.txtnewpass.TabIndex = 12;
            this.txtnewpass.TextChanged += new System.EventHandler(this.txtnewpass_TextChanged);
            // 
            // txtcurrentpass
            // 
            this.txtcurrentpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrentpass.Location = new System.Drawing.Point(7, 24);
            this.txtcurrentpass.Name = "txtcurrentpass";
            this.txtcurrentpass.PasswordChar = '*';
            this.txtcurrentpass.Size = new System.Drawing.Size(319, 21);
            this.txtcurrentpass.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Password :";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 176);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblNewpassword);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtcurrentpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(348, 215);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblNewpassword;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtcurrentpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}