using EquipmentMonitoring.Libs;
using EquipmentMonitoring.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class FuelPriceList : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public FuelPriceList()
        {
            InitializeComponent();
            dgvRefillList.Columns[2].DefaultCellStyle.Format = "###,###,###,##0.00";
            dgvRefillList.Columns[3].DefaultCellStyle.Format = "###,###,###,##0.00";
            GetPriceList();
        }

        public void GetPriceList()
        {
            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_FuelPriceList with(nolock) where TankName = (select TankName from m_TankList where IsMainTank = 1)", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            dgvRefillList.DataSource = null;
            if (this.dgvRefillList.DataSource != null)
            {
                this.dgvRefillList.DataSource = null;
            }
            else
            {
                this.dgvRefillList.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvRefillList.Rows.Add(row["Date"].ToString().Replace(" 12:00:00 AM", "")
                            , String.Format("{0:#,###.00}", Convert.ToDecimal(row["NoLiters"]))//row["NoLiters"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal(row["PricePerLiter"]))//row["PricePerLiter"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalAmount"]))//row["TotalAmount"].ToString()
                            , row["Supplier"].ToString()
                            );
                }
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void dgvRefillList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    string value = String.Format("{0:0,0.00}", Convert.ToDecimal(dgvRefillList.Rows[e.RowIndex].Cells[2].Value));
                    dgvRefillList.Rows[e.RowIndex].Cells[2].Value = value;
                   // value1 = value;
                }
                catch { }
            }
            if (e.ColumnIndex == 3)
            {
                try
                {
                    string value = String.Format("{0:0,0.00}", Convert.ToDecimal(dgvRefillList.Rows[e.RowIndex].Cells[3].Value));
                    dgvRefillList.Rows[e.RowIndex].Cells[3].Value = value;
                    // value1 = value;
                }
                catch { }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_FuelPriceList with(nolock) where  TankName = 'MAIN TANKER TRUCK' and Date BETWEEN '"
                   + dtpStart.Text + "' AND '" + dtpEnd.Text + "'", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            dgvRefillList.DataSource = null;
            if (this.dgvRefillList.DataSource != null)
            {
                this.dgvRefillList.DataSource = null;
            }
            else
            {
                this.dgvRefillList.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvRefillList.Rows.Add(row["Date"].ToString().Replace(" 12:00:00 AM", "")
                       , String.Format("{0:#,###.00}", Convert.ToDecimal(row["NoLiters"]))//row["NoLiters"].ToString()
                       , String.Format("{0:#,###.00}", Convert.ToDecimal(row["PricePerLiter"]))//row["PricePerLiter"].ToString()
                       , String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalAmount"]))//row["TotalAmount"].ToString()
                       , row["Supplier"].ToString()
                       );
                    /*
                    dgvRefillList.Rows.Add(row["Date"].ToString().Replace(" 12:00:00 AM", "")
                             , row["NoLiters"].ToString()
                             , String.Format("{0:#,###.00}", Convert.ToDecimal(row["PricePerLiter"]))//row["PricePerLiter"].ToString()
                             , String.Format("{0:#,###.00}", Convert.ToDecimal(row["TotalAmount"]))//row["TotalAmount"].ToString()
                             );
                    */
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GetPriceList();
        }
    }
}
