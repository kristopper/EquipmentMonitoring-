namespace EquipmentMonitoring.ForReportForm.Forms
{
    partial class RTankerTruckLogSheet
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.maintenanceDataSet = new EquipmentMonitoring.MaintenanceDataSet();
            this.mFuelMainLogSheetReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_FuelMainLogSheetReportTableAdapter = new EquipmentMonitoring.MaintenanceDataSetTableAdapters.m_FuelMainLogSheetReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFuelMainLogSheetReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mFuelMainLogSheetReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipmentMonitoring.ForReportForm.RdlcForm.TankerTruckLog.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 693);
            this.reportViewer1.TabIndex = 1;
            // 
            // maintenanceDataSet
            // 
            this.maintenanceDataSet.DataSetName = "MaintenanceDataSet";
            this.maintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mFuelMainLogSheetReportBindingSource
            // 
            this.mFuelMainLogSheetReportBindingSource.DataMember = "m_FuelMainLogSheetReport";
            this.mFuelMainLogSheetReportBindingSource.DataSource = this.maintenanceDataSet;
            // 
            // m_FuelMainLogSheetReportTableAdapter
            // 
            this.m_FuelMainLogSheetReportTableAdapter.ClearBeforeFill = true;
            // 
            // RTankerTruckLogSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 693);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RTankerTruckLogSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanker Truck Log Sheet";
            this.Load += new System.EventHandler(this.RTankerTruckLogSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mFuelMainLogSheetReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MaintenanceDataSet maintenanceDataSet;
        private System.Windows.Forms.BindingSource mFuelMainLogSheetReportBindingSource;
        private MaintenanceDataSetTableAdapters.m_FuelMainLogSheetReportTableAdapter m_FuelMainLogSheetReportTableAdapter;
    }
}