namespace EquipmentMonitoring.AllForm.expenses
{
    partial class AddBorrowItem
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
            this.dgvBorrowItem = new System.Windows.Forms.DataGridView();
            this.EQUIPNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPARTSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSERIALNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BNO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBorrowItem
            // 
            this.dgvBorrowItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EQUIPNO,
            this.BQTY,
            this.BITEM,
            this.BPARTSNO,
            this.BSERIALNO,
            this.BNO});
            this.dgvBorrowItem.Location = new System.Drawing.Point(8, 8);
            this.dgvBorrowItem.Name = "dgvBorrowItem";
            this.dgvBorrowItem.Size = new System.Drawing.Size(935, 180);
            this.dgvBorrowItem.TabIndex = 18;
            this.dgvBorrowItem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBorrowItem_EditingControlShowing);
            // 
            // EQUIPNO
            // 
            this.EQUIPNO.HeaderText = "EQUIPNO / MODEL / PLATENO";
            this.EQUIPNO.Name = "EQUIPNO";
            this.EQUIPNO.Width = 180;
            // 
            // BQTY
            // 
            this.BQTY.HeaderText = "QTY";
            this.BQTY.Name = "BQTY";
            this.BQTY.Width = 50;
            // 
            // BITEM
            // 
            this.BITEM.HeaderText = "ITEM";
            this.BITEM.Name = "BITEM";
            this.BITEM.Width = 200;
            // 
            // BPARTSNO
            // 
            this.BPARTSNO.HeaderText = "PARTS NO.";
            this.BPARTSNO.Name = "BPARTSNO";
            this.BPARTSNO.Width = 200;
            // 
            // BSERIALNO
            // 
            this.BSERIALNO.HeaderText = "SERIAL NO.";
            this.BSERIALNO.Name = "BSERIALNO";
            this.BSERIALNO.Width = 200;
            // 
            // BNO
            // 
            this.BNO.HeaderText = "NO.";
            this.BNO.Items.AddRange(new object[] {
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
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.BNO.Name = "BNO";
            this.BNO.Width = 60;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(869, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddBorrowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 221);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvBorrowItem);
            this.MaximizeBox = false;
            this.Name = "AddBorrowItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBorrowItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn EQUIPNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPARTSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSERIALNO;
        private System.Windows.Forms.DataGridViewComboBoxColumn BNO;
        private System.Windows.Forms.Button btnSave;
    }
}