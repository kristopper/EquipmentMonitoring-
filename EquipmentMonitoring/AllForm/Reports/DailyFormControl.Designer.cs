namespace EquipmentMonitoring.AllForm.Reports
{
    partial class DailyFormControl
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
            this.panelmainmenu = new System.Windows.Forms.Panel();
            this.panelTruckandHeavy = new System.Windows.Forms.Panel();
            this.btnTruckandHeavy = new System.Windows.Forms.Button();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.truckandHeavyDisplay1 = new EquipmentMonitoring.AllForm.Reports.Daily.TruckandHeavyDisplay();
            this.panelmainmenu.SuspendLayout();
            this.DisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmainmenu
            // 
            this.panelmainmenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelmainmenu.Controls.Add(this.panelTruckandHeavy);
            this.panelmainmenu.Controls.Add(this.btnTruckandHeavy);
            this.panelmainmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmainmenu.Name = "panelmainmenu";
            this.panelmainmenu.Size = new System.Drawing.Size(1167, 25);
            this.panelmainmenu.TabIndex = 28;
            // 
            // panelTruckandHeavy
            // 
            this.panelTruckandHeavy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTruckandHeavy.Location = new System.Drawing.Point(6, 19);
            this.panelTruckandHeavy.Name = "panelTruckandHeavy";
            this.panelTruckandHeavy.Size = new System.Drawing.Size(161, 4);
            this.panelTruckandHeavy.TabIndex = 29;
            // 
            // btnTruckandHeavy
            // 
            this.btnTruckandHeavy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruckandHeavy.FlatAppearance.BorderSize = 0;
            this.btnTruckandHeavy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruckandHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruckandHeavy.ForeColor = System.Drawing.Color.Black;
            this.btnTruckandHeavy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTruckandHeavy.Location = new System.Drawing.Point(0, 0);
            this.btnTruckandHeavy.Name = "btnTruckandHeavy";
            this.btnTruckandHeavy.Size = new System.Drawing.Size(174, 23);
            this.btnTruckandHeavy.TabIndex = 30;
            this.btnTruckandHeavy.Text = "TRUCK AND HEAVY EQUIPMENT";
            this.btnTruckandHeavy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTruckandHeavy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTruckandHeavy.UseVisualStyleBackColor = true;
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayPanel.Controls.Add(this.truckandHeavyDisplay1);
            this.DisplayPanel.Location = new System.Drawing.Point(0, 25);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(1167, 478);
            this.DisplayPanel.TabIndex = 29;
            // 
            // truckandHeavyDisplay1
            // 
            this.truckandHeavyDisplay1.Location = new System.Drawing.Point(0, 0);
            this.truckandHeavyDisplay1.Name = "truckandHeavyDisplay1";
            this.truckandHeavyDisplay1.Size = new System.Drawing.Size(1167, 478);
            this.truckandHeavyDisplay1.TabIndex = 0;
            // 
            // DailyFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.panelmainmenu);
            this.Name = "DailyFormControl";
            this.Size = new System.Drawing.Size(1167, 503);
            this.panelmainmenu.ResumeLayout(false);
            this.DisplayPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmainmenu;
        public System.Windows.Forms.Panel panelTruckandHeavy;
        public System.Windows.Forms.Button btnTruckandHeavy;
        private System.Windows.Forms.Panel DisplayPanel;
        private Daily.TruckandHeavyDisplay truckandHeavyDisplay1;
    }
}
