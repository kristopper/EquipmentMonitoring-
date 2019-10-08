namespace EquipmentMonitoring.AllForm.expenses
{
    partial class FinalMechanic
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
            this.dgvMechanic = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.MechanicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Mechanic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMechanic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMechanic
            // 
            this.dgvMechanic.AllowUserToAddRows = false;
            this.dgvMechanic.AllowUserToDeleteRows = false;
            this.dgvMechanic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMechanic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MechanicID,
            this.I,
            this.Mechanic});
            this.dgvMechanic.Location = new System.Drawing.Point(5, 5);
            this.dgvMechanic.Name = "dgvMechanic";
            this.dgvMechanic.Size = new System.Drawing.Size(335, 102);
            this.dgvMechanic.TabIndex = 54;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MechanicID
            // 
            this.MechanicID.HeaderText = "MechanicID";
            this.MechanicID.Name = "MechanicID";
            this.MechanicID.ReadOnly = true;
            this.MechanicID.Visible = false;
            // 
            // I
            // 
            this.I.HeaderText = "I";
            this.I.Name = "I";
            this.I.Width = 40;
            // 
            // Mechanic
            // 
            this.Mechanic.HeaderText = "MECHANIC / ELECTRICIAN";
            this.Mechanic.Name = "Mechanic";
            this.Mechanic.ReadOnly = true;
            this.Mechanic.Width = 250;
            // 
            // FinalMechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 136);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvMechanic);
            this.Name = "FinalMechanic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinalMechanic";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMechanic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMechanic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn MechanicID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn I;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mechanic;
    }
}