namespace EquipmentMonitoring.ForReportForm.Forms
{
    partial class TruckMonthlyReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.maintenanceDataSet_08132019 = new EquipmentMonitoring.MaintenanceDataSet_08132019();
            this.maintenanceDataSet08132019BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet_08132019)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet08132019BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.maintenanceDataSet08132019BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipmentMonitoring.ForReportForm.RdlcForm.TruckMonthlyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 693);
            this.reportViewer1.TabIndex = 3;
            // 
            // maintenanceDataSet_08132019
            // 
            this.maintenanceDataSet_08132019.DataSetName = "MaintenanceDataSet_08132019";
            this.maintenanceDataSet_08132019.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintenanceDataSet08132019BindingSource
            // 
            this.maintenanceDataSet08132019BindingSource.DataSource = this.maintenanceDataSet_08132019;
            this.maintenanceDataSet08132019BindingSource.Position = 0;
            // 
            // TruckMonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 693);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TruckMonthlyReport";
            this.Text = "Truck and Heavy Equipment Monthly Report";
            this.Load += new System.EventHandler(this.TruckMonthlyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet_08132019)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet08132019BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource maintenanceDataSet08132019BindingSource;
        private MaintenanceDataSet_08132019 maintenanceDataSet_08132019;
    }
}