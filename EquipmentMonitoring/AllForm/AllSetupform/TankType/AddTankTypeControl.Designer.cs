namespace EquipmentMonitoring.AllForm.AllSetupform.TankType
{
    partial class AddTankTypeControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TYPEOFFUEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANKNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EQUIPMENTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANKCAPACITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLATENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TANKGAUGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAINTANK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADD TANK TYPE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TYPEOFFUEL,
            this.TANKNAME,
            this.EQUIPMENTNO,
            this.MODEL,
            this.TANKCAPACITY,
            this.PLATENO,
            this.TANKGAUGE,
            this.MAINTANK});
            this.dataGridView1.Location = new System.Drawing.Point(151, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 178);
            this.dataGridView1.TabIndex = 6;
            // 
            // TYPEOFFUEL
            // 
            this.TYPEOFFUEL.HeaderText = "TYPE OF FUEL";
            this.TYPEOFFUEL.Name = "TYPEOFFUEL";
            this.TYPEOFFUEL.ReadOnly = true;
            // 
            // TANKNAME
            // 
            this.TANKNAME.HeaderText = "TANK NAME";
            this.TANKNAME.Name = "TANKNAME";
            this.TANKNAME.ReadOnly = true;
            // 
            // EQUIPMENTNO
            // 
            this.EQUIPMENTNO.HeaderText = "EQUIPMENT NO";
            this.EQUIPMENTNO.Name = "EQUIPMENTNO";
            this.EQUIPMENTNO.ReadOnly = true;
            // 
            // MODEL
            // 
            this.MODEL.HeaderText = "MODEL";
            this.MODEL.Name = "MODEL";
            this.MODEL.ReadOnly = true;
            // 
            // TANKCAPACITY
            // 
            this.TANKCAPACITY.HeaderText = "TANK CAPACITY";
            this.TANKCAPACITY.Name = "TANKCAPACITY";
            this.TANKCAPACITY.ReadOnly = true;
            // 
            // PLATENO
            // 
            this.PLATENO.HeaderText = "PLATE NO";
            this.PLATENO.Name = "PLATENO";
            this.PLATENO.ReadOnly = true;
            // 
            // TANKGAUGE
            // 
            this.TANKGAUGE.HeaderText = "TANK GAUGE";
            this.TANKGAUGE.Name = "TANKGAUGE";
            this.TANKGAUGE.ReadOnly = true;
            // 
            // MAINTANK
            // 
            this.MAINTANK.HeaderText = "MAIN TANK";
            this.MAINTANK.Name = "MAINTANK";
            this.MAINTANK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MAINTANK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(922, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(841, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddTankTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddTankTypeControl";
            this.Size = new System.Drawing.Size(1152, 339);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridViewTextBoxColumn TYPEOFFUEL;
        public System.Windows.Forms.DataGridViewTextBoxColumn TANKNAME;
        public System.Windows.Forms.DataGridViewTextBoxColumn EQUIPMENTNO;
        public System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        public System.Windows.Forms.DataGridViewTextBoxColumn TANKCAPACITY;
        public System.Windows.Forms.DataGridViewTextBoxColumn PLATENO;
        public System.Windows.Forms.DataGridViewTextBoxColumn TANKGAUGE;
        public System.Windows.Forms.DataGridViewCheckBoxColumn MAINTANK;
    }
}
