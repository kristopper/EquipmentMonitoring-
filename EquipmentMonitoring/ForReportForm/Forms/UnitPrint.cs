using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring.ForReportForm.Forms
{
    public partial class UnitPrint : Form
    {
        public string FuelType { get; set; }
        public string EquipmentNo { get; set; }
        public string Model { get; set; }
        public string PlateNo { get; set; }
        public string EngineNo { get; set; }
        public string ChassisNo { get; set; }
        public string Piston { get; set; }
        public string Cylinders { get; set; }
        public string TruckType { get; set; }
        public string Make { get; set; }
        public string Series { get; set; }
        public string BodyType { get; set; }
        public string YearModel { get; set; }
        public string GrossWT { get; set; }
        public string ExistingReading { get; set; }
        public string CurrentReading { get; set; }
        public string StatusOFPurchase { get; set; }
        public string DateOfPurchase { get; set; }
        public string UnitPrice { get; set; }
        public string CRNo { get; set; }
        public string Supplier { get; set; }
        public string MVFileNo { get; set; }
        public string Register { get; set; }
        
        //DataTable DataGridl = new DataTable();
        public UnitPrint()
        {
            InitializeComponent();
        }

        public void Param(DataSet dsKey)
        {
            FuelType = dsKey.Tables[0].Rows[0]["FuelType"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["FuelType"].ToString();
            EquipmentNo = dsKey.Tables[0].Rows[0]["EquipmentNo"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["EquipmentNo"].ToString(); 
            Model = dsKey.Tables[0].Rows[0]["Model"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["Model"].ToString();
            PlateNo = dsKey.Tables[0].Rows[0]["PlateNo"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["PlateNo"].ToString();
            EngineNo = dsKey.Tables[0].Rows[0]["EngineNo"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["EngineNo"].ToString();
            ChassisNo = dsKey.Tables[0].Rows[0]["ChassisNo"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["ChassisNo"].ToString();
            Piston = dsKey.Tables[0].Rows[0]["PistonDisplacement"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["PistonDisplacement"].ToString();
            Cylinders = dsKey.Tables[0].Rows[0]["NoCylinder"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["NoCylinder"].ToString();
            TruckType = dsKey.Tables[0].Rows[0]["TruckType"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["TruckType"].ToString();
            Make = dsKey.Tables[0].Rows[0]["Make"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["Make"].ToString();
            Series = dsKey.Tables[0].Rows[0]["Series"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["Series"].ToString();
            BodyType = dsKey.Tables[0].Rows[0]["BodyType"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["BodyType"].ToString();
            YearModel = dsKey.Tables[0].Rows[0]["YearModel"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["YearModel"].ToString();
            GrossWT = dsKey.Tables[0].Rows[0]["GrossWT"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["GrossWT"].ToString();
            ExistingReading = dsKey.Tables[0].Rows[0]["ExistingReadingkm"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["ExistingReadingkm"].ToString();
            CurrentReading = dsKey.Tables[0].Rows[0]["CurrentReading"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["CurrentReading"].ToString();
            StatusOFPurchase = dsKey.Tables[0].Rows[0]["StatusOfPurchase"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["StatusOfPurchase"].ToString();
            DateOfPurchase = dsKey.Tables[0].Rows[0]["DateOfPurchase"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["DateOfPurchase"].ToString();
            UnitPrice = dsKey.Tables[0].Rows[0]["Price"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["Price"].ToString();
            CRNo = dsKey.Tables[0].Rows[0]["CR_No"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["CR_No"].ToString();
            Supplier = dsKey.Tables[0].Rows[0]["Supplier"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["Supplier"].ToString();
            MVFileNo =  dsKey.Tables[0].Rows[0]["MVFile_No"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["MVFile_No"].ToString();
            Register = dsKey.Tables[0].Rows[0]["Month_R_Expired"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["Month_R_Expired"].ToString() + " " + dsKey.Tables[0].Rows[0]["Year_R_Expired"].ToString() == string.Empty ? " " : dsKey.Tables[0].Rows[0]["Year_R_Expired"].ToString();

            /*
            FuelType = dsKey.Tables[0].Rows[0]["FuelType"].ToString();
            EquipmentNo = dsKey.Tables[0].Rows[0]["EquipmentNo"].ToString();
            Model = dsKey.Tables[0].Rows[0]["Model"].ToString();
            PlateNo = dsKey.Tables[0].Rows[0]["PlateNo"].ToString();
            EngineNo = dsKey.Tables[0].Rows[0]["EngineNo"].ToString();
            ChassisNo = dsKey.Tables[0].Rows[0]["ChassisNo"].ToString();
            Piston = dsKey.Tables[0].Rows[0]["PistonDisplacement"].ToString();
            Cylinders = dsKey.Tables[0].Rows[0]["NoCylinder"].ToString();
            TruckType = dsKey.Tables[0].Rows[0]["TruckType"].ToString();
            Make = dsKey.Tables[0].Rows[0]["Make"].ToString();
            Series = dsKey.Tables[0].Rows[0]["Series"].ToString();
            BodyType = dsKey.Tables[0].Rows[0]["BodyType"].ToString();
            YearModel = dsKey.Tables[0].Rows[0]["YearModel"].ToString();
            GrossWT = dsKey.Tables[0].Rows[0]["GrossWT"].ToString();
            ExistingReading = dsKey.Tables[0].Rows[0]["ExistingReadingkm"].ToString();
            CurrentReading = dsKey.Tables[0].Rows[0]["CurrentReading"].ToString();
            StatusOFPurchase = dsKey.Tables[0].Rows[0]["StatusOFPurchase"].ToString();
            DateOfPurchase = dsKey.Tables[0].Rows[0]["DateOfPurchase"].ToString();
            UnitPrice = dsKey.Tables[0].Rows[0]["Price"].ToString();
            CRNo = dsKey.Tables[0].Rows[0]["CR_No"].ToString();
            Supplier = dsKey.Tables[0].Rows[0]["Supplier"].ToString();
            MVFileNo = dsKey.Tables[0].Rows[0]["MVFile_No"].ToString();
            Register = dsKey.Tables[0].Rows[0]["Month_R_Expired"].ToString() + " " + dsKey.Tables[0].Rows[0]["Year_R_Expired"].ToString();
            
            */
            /*
            foreach (DataRow row in dtlabel.Rows)
            {
     
                FuelType = row["FuelType"].ToString();
                EquipmentNo = row["EquipmentNo"].ToString();
                Model = row["Model"].ToString();
                PlateNo = row["PlateNo"].ToString();
                EngineNo = row["EngineNo"].ToString();
                ChassisNo = row["ChassisNo"].ToString();
                Piston = row["PistonDisplacement"].ToString();
                Cylinders = row["NoCylinder"].ToString();
                TruckType = row["TruckType"].ToString();
                Make = row["Make"].ToString();
                Series = row["Series"].ToString();
                BodyType = row["BodyType"].ToString();
                YearModel = row["YearModel"].ToString();
                GrossWT = row["GrossWT"].ToString();
                ExistingReading = row["ExistingReadingkm"].ToString();
                CurrentReading = row["CurrentReading"].ToString();
                StatusOFPurchase = row["StatusOFPurchase"].ToString();
                DateOfPurchase = row["DateOfPurchase"].ToString();
                UnitPrice = row["Price"].ToString();
                CRNo = row["CR_No"].ToString();
                Supplier = row["Supplier"].ToString();
                MVFileNo = row["MVFile_No"].ToString();
                Register = row["Month_R_Expired"].ToString() + " " + row["Year_R_Expired"].ToString();
                
            }
            */
            //DataGridl = dtgrid;

        }
        private void UnitPrint_Load(object sender, EventArgs e)
        {

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            ReportParameter[] rptParams = new ReportParameter[(23)];
            rptParams[0] = new ReportParameter("FuelType", FuelType);
            rptParams[1] = new ReportParameter("EquipmentNo", EquipmentNo);
            rptParams[2] = new ReportParameter("Model", Model);
            rptParams[3] = new ReportParameter("PlateNo", PlateNo);
            rptParams[4] = new ReportParameter("EngineNo", EngineNo);
            rptParams[5] = new ReportParameter("ChassisNo", ChassisNo);
            rptParams[6] = new ReportParameter("Piston", Piston);
            rptParams[7] = new ReportParameter("Cylinders", Cylinders);
            rptParams[8] = new ReportParameter("TruckType", TruckType);
            rptParams[9] = new ReportParameter("Make", Make);
            rptParams[10] = new ReportParameter("BodyType", BodyType);
            rptParams[11] = new ReportParameter("YearModel", YearModel);
            rptParams[12] = new ReportParameter("GrossWT", GrossWT);
            rptParams[13] = new ReportParameter("ExistingReading", ExistingReading);
            rptParams[14] = new ReportParameter("CurrentReading", CurrentReading);
            rptParams[15] = new ReportParameter("StatusOfPurchase", StatusOFPurchase);
            rptParams[16] = new ReportParameter("DateOfPurchase",  DateOfPurchase.Replace(" 12:00:00 AM",""));
            rptParams[17] = new ReportParameter("UnitPrice", UnitPrice);
            rptParams[18] = new ReportParameter("CRNo", CRNo);
            rptParams[19] = new ReportParameter("Supplier", Supplier);
            rptParams[20] = new ReportParameter("MVFileNo", MVFileNo);
            rptParams[21] = new ReportParameter("Register", Register);
            rptParams[22] = new ReportParameter("Series", Series);

            reportViewer1.LocalReport.SetParameters(rptParams);

            var setup = reportViewer1.GetPageSettings();
            //setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            pg.Margins.Top = 0; //Convert.ToInt32(0.2);
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;

            pg.Landscape = false;


            reportViewer1.SetPageSettings(pg);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            //this.reportviewer1.loca= datagridl;
            //this.m_FuelMainLogSheetReportBindingSource.DataSource = DataGridl;

            //string exportOption = "Excel";

            //string exportOption1 = "Excel";
            //RenderingExtension extension1 = reportViewer1.LocalReport.ListRenderingExtensions().ToList().Find(x => x.Name.Equals(exportOption1, StringComparison.CurrentCultureIgnoreCase));
            //if (extension1 != null)
            //{
            //    System.Reflection.FieldInfo fieldInfo = extension1.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            //    fieldInfo.SetValue(extension1, false);
            //}


            string exportOption = "EXCELOPENXML";
            //string exportOption = "PDF";
            RenderingExtension extension = reportViewer1.LocalReport.ListRenderingExtensions().ToList().Find(x => x.Name.Equals(exportOption, StringComparison.CurrentCultureIgnoreCase));
            if (extension != null)
            {
                System.Reflection.FieldInfo fieldInfo = extension.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                fieldInfo.SetValue(extension, false);
            }


            string exportOption1 = "WORDOPENXML";
            //string exportOption = "PDF";
            RenderingExtension extension1 = reportViewer1.LocalReport.ListRenderingExtensions().ToList().Find(x => x.Name.Equals(exportOption1, StringComparison.CurrentCultureIgnoreCase));
            if (extension1 != null)
            {
                System.Reflection.FieldInfo fieldInfo = extension1.GetType().GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                fieldInfo.SetValue(extension1, false);
            }

            this.reportViewer1.RefreshReport();



            //this.reportViewer1.RefreshReport();
        }
    }
}
