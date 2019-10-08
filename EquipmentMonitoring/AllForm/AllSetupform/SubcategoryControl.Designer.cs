namespace EquipmentMonitoring.AllForm.AllSetupform
{
    partial class SubcategoryControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvSubCategory = new System.Windows.Forms.DataGridView();
            this.dSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dSubCategory});
            this.dgvSubCategory.Location = new System.Drawing.Point(3, 21);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.Size = new System.Drawing.Size(567, 401);
            this.dgvSubCategory.TabIndex = 4;
            // 
            // dSubCategory
            // 
            this.dSubCategory.HeaderText = "SUB-CATEGORY";
            this.dSubCategory.Name = "dSubCategory";
            this.dSubCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dSubCategory.Width = 257;
            // 
            // SubcategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvSubCategory);
            this.Name = "SubcategoryControl";
            this.Size = new System.Drawing.Size(573, 464);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSubCategory;
    }
}
