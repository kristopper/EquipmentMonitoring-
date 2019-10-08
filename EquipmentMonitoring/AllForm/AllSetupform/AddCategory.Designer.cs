namespace EquipmentMonitoring.AllForm.AllSetupform
{
    partial class AddCategory
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnMainFuelLog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RefillMainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subCategoryAdd1 = new EquipmentMonitoring.AllForm.AllSetupform.category.SubCategoryAdd();
            this.categoryAdd1 = new EquipmentMonitoring.AllForm.AllSetupform.category.CategoryAdd();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADD CATEGORY AND SUB-CATEGORY";
            // 
            // btnMainFuelLog
            // 
            this.btnMainFuelLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainFuelLog.FlatAppearance.BorderSize = 0;
            this.btnMainFuelLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainFuelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainFuelLog.ForeColor = System.Drawing.Color.Black;
            this.btnMainFuelLog.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMainFuelLog.Location = new System.Drawing.Point(295, 44);
            this.btnMainFuelLog.Name = "btnMainFuelLog";
            this.btnMainFuelLog.Size = new System.Drawing.Size(95, 23);
            this.btnMainFuelLog.TabIndex = 2;
            this.btnMainFuelLog.Text = "SUB-CATEGORY";
            this.btnMainFuelLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainFuelLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainFuelLog.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(169, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CATEGORY";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RefillMainPanel
            // 
            this.RefillMainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefillMainPanel.Location = new System.Drawing.Point(302, 63);
            this.RefillMainPanel.Name = "RefillMainPanel";
            this.RefillMainPanel.Size = new System.Drawing.Size(81, 4);
            this.RefillMainPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(175, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 4);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.subCategoryAdd1);
            this.panel2.Controls.Add(this.categoryAdd1);
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 501);
            this.panel2.TabIndex = 6;
            // 
            // subCategoryAdd1
            // 
            this.subCategoryAdd1.Location = new System.Drawing.Point(3, 0);
            this.subCategoryAdd1.Name = "subCategoryAdd1";
            this.subCategoryAdd1.Size = new System.Drawing.Size(560, 480);
            this.subCategoryAdd1.TabIndex = 0;
            // 
            // categoryAdd1
            // 
            this.categoryAdd1.Location = new System.Drawing.Point(3, -1);
            this.categoryAdd1.Name = "categoryAdd1";
            this.categoryAdd1.Size = new System.Drawing.Size(560, 480);
            this.categoryAdd1.TabIndex = 1;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RefillMainPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMainFuelLog);
            this.Controls.Add(this.label3);
            this.Name = "AddCategory";
            this.Size = new System.Drawing.Size(573, 577);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnMainFuelLog;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel RefillMainPanel;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private category.SubCategoryAdd subCategoryAdd1;
        private category.CategoryAdd categoryAdd1;
    }
}
