namespace EquipmentMonitoring.AllForm.expenses
{
    partial class UpdateItemExpenses
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
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPAIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIALNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALLOCATIONNO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DateOfPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsCompete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.QTY,
            this.Item,
            this.Purchase,
            this.PMS,
            this.REPAIR,
            this.TIRE,
            this.PARTSNO,
            this.SERIALNO,
            this.ReferenceNo,
            this.ALLOCATIONNO,
            this.DateOfPurchase,
            this.PartsCompete,
            this.Source});
            this.dgvItem.Location = new System.Drawing.Point(4, 6);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(1202, 286);
            this.dgvItem.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1132, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ItemID
            // 
            this.ItemID.Frozen = true;
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // QTY
            // 
            this.QTY.Frozen = true;
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 40;
            // 
            // Item
            // 
            this.Item.Frozen = true;
            this.Item.HeaderText = "ITEM";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 180;
            // 
            // Purchase
            // 
            this.Purchase.Frozen = true;
            this.Purchase.HeaderText = "PURCHASE";
            this.Purchase.Name = "Purchase";
            this.Purchase.Visible = false;
            this.Purchase.Width = 70;
            // 
            // PMS
            // 
            this.PMS.Frozen = true;
            this.PMS.HeaderText = "PMS";
            this.PMS.Name = "PMS";
            this.PMS.Width = 80;
            // 
            // REPAIR
            // 
            this.REPAIR.Frozen = true;
            this.REPAIR.HeaderText = "REPAIR";
            this.REPAIR.Name = "REPAIR";
            this.REPAIR.Width = 80;
            // 
            // TIRE
            // 
            this.TIRE.Frozen = true;
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
            // ReferenceNo
            // 
            this.ReferenceNo.HeaderText = "REFERENCE NO";
            this.ReferenceNo.Name = "ReferenceNo";
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
            // DateOfPurchase
            // 
            this.DateOfPurchase.HeaderText = "DATE OF PURCHASE";
            this.DateOfPurchase.Name = "DateOfPurchase";
            // 
            // PartsCompete
            // 
            this.PartsCompete.HeaderText = "PART COMPLETE";
            this.PartsCompete.Name = "PartsCompete";
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.Visible = false;
            // 
            // UpdateItemExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 324);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvItem);
            this.Name = "UpdateItemExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateItemExpenses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPAIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIALNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ALLOCATIONNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsCompete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
    }
}