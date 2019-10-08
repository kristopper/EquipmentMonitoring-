namespace EquipmentMonitoring
{
    partial class ExpensesDetail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mechanic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Problem,
            this.Diagnosis,
            this.Solution,
            this.PMS,
            this.Repair,
            this.Tire,
            this.DateCompleted,
            this.Remarks,
            this.Mechanic,
            this.ProjectSite});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            // 
            // Problem
            // 
            this.Problem.HeaderText = "PROBLEM";
            this.Problem.Name = "Problem";
            // 
            // Diagnosis
            // 
            this.Diagnosis.HeaderText = "MECHANIC POSSIBLE CAUSE/DIAGNOSIS";
            this.Diagnosis.Name = "Diagnosis";
            // 
            // Solution
            // 
            this.Solution.HeaderText = "SOLUTION APPLIED";
            this.Solution.Name = "Solution";
            // 
            // PMS
            // 
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            // 
            // Repair
            // 
            this.Repair.HeaderText = "REPAIR";
            this.Repair.Name = "Repair";
            // 
            // Tire
            // 
            this.Tire.HeaderText = "TIRE";
            this.Tire.Name = "Tire";
            // 
            // DateCompleted
            // 
            this.DateCompleted.HeaderText = "DATE COMPLETED";
            this.DateCompleted.Name = "DateCompleted";
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "REMARKS";
            this.Remarks.Name = "Remarks";
            // 
            // Mechanic
            // 
            this.Mechanic.HeaderText = "MECHANIC";
            this.Mechanic.Name = "Mechanic";
            // 
            // ProjectSite
            // 
            this.ProjectSite.HeaderText = "PROJECT SITE";
            this.ProjectSite.Name = "ProjectSite";
            // 
            // ExpensesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExpensesDetail";
            this.Text = "ExpensesDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solution;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tire;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mechanic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectSite;
    }
}