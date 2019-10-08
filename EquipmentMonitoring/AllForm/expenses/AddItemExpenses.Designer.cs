namespace EquipmentMonitoring.AllForm.expenses
{
    partial class AddItemExpenses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPAIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIALNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALLOCATIONNO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dgvItem);
            this.groupBox1.Location = new System.Drawing.Point(2, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 232);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(962, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QTY,
            this.Item,
            this.Purchase,
            this.PMS,
            this.REPAIR,
            this.TIRE,
            this.PARTSNO,
            this.SERIALNO,
            this.ALLOCATIONNO});
            this.dgvItem.Location = new System.Drawing.Point(6, 12);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(1032, 188);
            this.dgvItem.TabIndex = 15;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.Width = 40;
            // 
            // Item
            // 
            this.Item.HeaderText = "ITEM";
            this.Item.Name = "Item";
            this.Item.Width = 180;
            // 
            // Purchase
            // 
            this.Purchase.HeaderText = "PURCHASE";
            this.Purchase.Name = "Purchase";
            this.Purchase.Visible = false;
            this.Purchase.Width = 70;
            // 
            // PMS
            // 
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            this.PMS.Width = 80;
            // 
            // REPAIR
            // 
            this.REPAIR.HeaderText = "REPAIR";
            this.REPAIR.Name = "REPAIR";
            this.REPAIR.Width = 80;
            // 
            // TIRE
            // 
            this.TIRE.HeaderText = "TIRE";
            this.TIRE.Name = "TIRE";
            this.TIRE.Width = 80;
            // 
            // PARTSNO
            // 
            this.PARTSNO.HeaderText = "PARTS NO.";
            this.PARTSNO.Name = "PARTSNO";
            this.PARTSNO.Width = 110;
            // 
            // SERIALNO
            // 
            this.SERIALNO.HeaderText = "SERIAL NO.";
            this.SERIALNO.Name = "SERIALNO";
            this.SERIALNO.Width = 110;
            // 
            // ALLOCATIONNO
            // 
            this.ALLOCATIONNO.HeaderText = "NO.";
            this.ALLOCATIONNO.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.ALLOCATIONNO.Name = "ALLOCATIONNO";
            this.ALLOCATIONNO.Width = 60;
            // 
            // AddItemExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 228);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddItemExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddItemExpenses";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPAIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIALNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn ALLOCATIONNO;
    }
}