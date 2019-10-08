namespace EquipmentMonitoring.ForReportForm.Forms
{
    partial class RMainTankLogSheet
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.m_FuelMainLogSheetReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceDataSet = new EquipmentMonitoring.MaintenanceDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.maintenanceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_FuelMainLogSheetReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_FuelMainLogSheetReportBindingSource
            // 
            this.m_FuelMainLogSheetReportBindingSource.DataMember = "m_FuelMainLogSheetReport";
            this.m_FuelMainLogSheetReportBindingSource.DataSource = this.maintenanceDataSet;
            // 
            // maintenanceDataSet
            // 
            this.maintenanceDataSet.DataSetName = "MaintenanceDataSet";
            this.maintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.m_FuelMainLogSheetReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipmentMonitoring.ForReportForm.RdlcForm.MainTankLog.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 693);
            this.reportViewer1.TabIndex = 0;
            // 
            // maintenanceDataSetBindingSource
            // 
            this.maintenanceDataSetBindingSource.DataSource = this.maintenanceDataSet;
            this.maintenanceDataSetBindingSource.Position = 0;
            // 
            // RMainTankLogSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 693);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RMainTankLogSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainTankLogSheet";
            this.Load += new System.EventHandler(this.RMainTankLogSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_FuelMainLogSheetReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource maintenanceDataSetBindingSource;
        private MaintenanceDataSet maintenanceDataSet;
        private System.Windows.Forms.BindingSource m_FuelMainLogSheetReportBindingSource;
    }
}