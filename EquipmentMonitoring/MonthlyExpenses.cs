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
    public partial class MonthlyExpenses : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        string IsOther = "1";
        string IsUnits = "1";

        SqlDataAdapter dagrid;
        DataTable dtgrid = new DataTable();
        SqlDataAdapter daTotal;
        DataTable dtTotal = new DataTable();

        public MonthlyExpenses()
        {
            InitializeComponent();
            cmbList.SelectedIndex = 0;
            YearList();
        }


        private void YearList()
        {
            SqlDataAdapter da = new SqlDataAdapter("select distinct Year from m_MonthlyExpenses", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbYear.DataSource = dt;
            cmbYear.DisplayMember = "Year";
            cmbYear.ValueMember = "Year";

        }


        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbMonth.Text == "")
            {
                MessageBox.Show("Please Select Month");
            }
            else
            {
                dtgrid.Clear();
                dtTotal.Clear();

                if (IsOther == "1")
                {
                    if(IsUnits == "1")
                    {
                        daTotal = new SqlDataAdapter("select case when SUM(TotalFuelCost) is null then '0' else SUM(TotalFuelCost) end as FuelCost, case when SUM(TotalKm) is null then '0' else SUM(TotalKm) end as TotalKm, " +
                            "case when SUM(Totalhrs) is null then '0' else SUM(Totalhrs) end as Totalhrs, case when SUM(TotalLiters) is null then '0' else SUM(TotalLiters) end as TotalLiters, " +
                            "case when SUM(PMS) is null then '0' else SUM(PMS) end as PMS, case when SUM(Repair) is null then '0' else SUM(Repair) end as Repair, " +
                            "case when SUM(Tire) is null then '0' else SUM(Tire) end as Tire, case when SUM(Total) is null then '0' else SUM(Total) end as Total " +
                            " from m_MonthlyExpenses with(nolock) " +
                            "where Month = '" + cmbMonth.Text + "' and Year = '" + cmbYear.Text + "' and "
                           + cmbList.SelectedItem.ToString().Replace(" ", "") + " like '%" + txtEquip.Text + "%'", Connection);

                        dagrid = new SqlDataAdapter("Select * from m_MonthlyExpenses with(nolock) where Month = '" + cmbMonth.Text + "' and Year = '" + cmbYear.Text + "' and "
                           + cmbList.SelectedItem.ToString().Replace(" ", "") + " like '%" + txtEquip.Text + "%'", Connection);
                    }
                    else
                    {
                        daTotal = new SqlDataAdapter("select case when SUM(TotalFuelCost) is null then '0' else SUM(TotalFuelCost) end as FuelCost, case when SUM(TotalKm) is null then '0' else SUM(TotalKm) end as TotalKm, " +
                            "case when SUM(Totalhrs) is null then '0' else SUM(Totalhrs) end as Totalhrs, case when SUM(TotalLiters) is null then '0' else SUM(TotalLiters) end as TotalLiters, " +
                            "case when SUM(PMS) is null then '0' else SUM(PMS) end as PMS, case when SUM(Repair) is null then '0' else SUM(Repair) end as Repair, " +
                            "case when SUM(Tire) is null then '0' else SUM(Tire) end as Tire, case when SUM(Total) is null then '0' else SUM(Total) end as Total " +
                            " from m_MonthlyExpenses with(nolock) " +
                            "where Month = '" + cmbMonth.Text + "' and Year = '" + cmbYear.Text + "' and "
                           + cmbList.SelectedItem.ToString().Replace(" ", "") + " like '%" + txtEquip.Text + "%' and Type = 0", Connection);

                        dagrid = new SqlDataAdapter("Select * from m_MonthlyExpenses with(nolock) where Month = '" + cmbMonth.Text + "' and Year = '" + cmbYear.Text + "' and "
                           + cmbList.SelectedItem.ToString().Replace(" ", "") + " like '%" + txtEquip.Text + "%' and Type = 0", Connection);
                    }
                }
                else
                {
                    if (IsUnits == "1")
                    {
                        daTotal = new SqlDataAdapter("select case when SUM(TotalFuelCost) is null then '0' else SUM(TotalFuelCost) end as FuelCost, case when SUM(TotalKm) is null then '0' else SUM(TotalKm) end as TotalKm, " +
                            "case when SUM(Totalhrs) is null then '0' else SUM(Totalhrs) end as Totalhrs, case when SUM(TotalLiters) is null then '0' else SUM(TotalLiters) end as TotalLiters, " +
                            "case when SUM(PMS) is null then '0' else SUM(PMS) end as PMS, case when SUM(Repair) is null then '0' else SUM(Repair) end as Repair, " +
                            "case when SUM(Tire) is null then '0' else SUM(Tire) end as Tire, case when SUM(Total) is null then '0' else SUM(Total) end as Total " +
                            " from m_MonthlyExpenses with(nolock) " +
                            "where Month = '" + cmbMonth.Text + "' and Year = '" + cmbYear.Text + "' and "
                            + cmbList.SelectedItem.ToString().Replace(" ", "") + " like '%" + txtEquip.Text + "%' and Type = 1", Connection);

                        dagrid = new SqlDataAdapter("Select * from m_MonthlyExpenses with(nolock) where Month = '" + cmbMonth.Text + "' and Year = '" + cmbYear.Text + "' and "
                            + cmbList.SelectedItem.ToString().Replace(" ", "") + " like '%" + txtEquip.Text + "%' and Type = 1", Connection);
                    }
                    else
                    {
                        chkOthers.Checked = true;
                        chkUnit.Checked = true;

                        daTotal = new SqlDataAdapter("select case when SUM(TotalFuelCost) is null then '0' else SUM(TotalFuelCost) end as FuelCost, case when SUM(TotalKm) is null then '0' else SUM(TotalKm) end as TotalKm, " +
                            "case when SUM(Totalhrs) is null then '0' else SUM(Totalhrs) end as Totalhrs, case when SUM(TotalLiters) is null then '0' else SUM(TotalLiters) end as TotalLiters, " +
                            "case when SUM(PMS) is null then '0' else SUM(PMS) end as PMS, case when SUM(Repair) is null then '0' else SUM(Repair) end as Repair, " +
                            "case when SUM(Tire) is null then '0' else SUM(Tire) end as Tire, case when SUM(Total) is null then '0' else SUM(Total) end as Total " +
                            " from m_MonthlyExpenses with(nolock) " +
                            "where Month = '" + cmbMonth.Text + "' and Year = '" + cmbYear.Text + "' and "
                            + cmbList.SelectedItem.ToString().Replace(" ", "") + " like '%" + txtEquip.Text + "%'", Connection);

                        dagrid = new SqlDataAdapter("Select * from m_MonthlyExpenses with(nolock) where Month = '" + cmbMonth.Text + "' and Year = '" + cmbYear.Text + "' and "
                            + cmbList.SelectedItem.ToString().Replace(" ", "") + " like '%" + txtEquip.Text + "%'", Connection);
                    }
                }


                daTotal.Fill(dtTotal);

                dagrid.Fill(dtgrid);

                dgvMonthlyExpenses.DataSource = null;

                if (this.dgvMonthlyExpenses.DataSource != null)
                {
                    this.dgvMonthlyExpenses.DataSource = null;
                }
                else
                {
                    this.dgvMonthlyExpenses.Rows.Clear();
                }

                lblexpenses.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dtTotal.Rows[0]["Total"].ToString()));//dtTotal.Rows[0]["Total"].ToString();
                lblfuelcost.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dtTotal.Rows[0]["FuelCost"].ToString()));//dtTotal.Rows[0]["FuelCost"].ToString();
                lblhrs.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dtTotal.Rows[0]["Totalhrs"].ToString()));//dtTotal.Rows[0]["Totalhrs"].ToString();
                lblkm.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dtTotal.Rows[0]["TotalKm"].ToString()));//dtTotal.Rows[0]["TotalKm"].ToString();
                lblliters.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dtTotal.Rows[0]["TotalLiters"].ToString()));//dtTotal.Rows[0]["TotalLiters"].ToString();
                lblpms.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dtTotal.Rows[0]["PMS"].ToString()));//dtTotal.Rows[0]["PMS"].ToString();
                lblrepair.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dtTotal.Rows[0]["Repair"].ToString()));//dtTotal.Rows[0]["Repair"].ToString();
                lbltire.Text = String.Format("{0:#,###.00}", Convert.ToDecimal(dtTotal.Rows[0]["Tire"].ToString()));//dtTotal.Rows[0]["Tire"].ToString();

                int intRecord = dtgrid.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dtgrid.Rows)
                    {
                        dgvMonthlyExpenses.Rows.Add(row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal((row["TotalKm"].ToString() == "" ? "0" : row["TotalKm"])))// row["TotalKm"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal((row["Totalhrs"].ToString() == "" ? "0" : row["Totalhrs"])))//row["Totalhrs"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal((row["TotalLiters"].ToString() == "" ? "0" : row["TotalLiters"])))//row["TotalLiters"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal((row["TotalFuelCost"].ToString() == "" ? "0" : row["TotalFuelCost"])))//row["TotalFuelCost"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal((row["PMS"].ToString() == "" ? "0" : row["PMS"])))//row["PMS"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal((row["Repair"].ToString() == "" ? "0" : row["Repair"])))//row["Repair"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal((row["Tire"].ToString() == "" ? "0" : row["Tire"])))//row["Tire"].ToString()
                            , String.Format("{0:#,###.00}", Convert.ToDecimal((row["Total"].ToString() == "" ? "0" : row["Total"])))//row["Total"].ToString()
                            );
                    }
                }
                else
                {
                    MessageBox.Show("No Records Found");
                }


                lblmonth.Text = cmbMonth.Text + " " + cmbYear.Text;
            }
            /////////////////////////////////////here

        }

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOthers.Checked == true)
            {
                IsOther = "1";
            }
            else
            {
                IsOther = "0";
            }
        }

        private void chkUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnit.Checked == true)
            {
                IsUnits = "1";
            }
            else
            {
                IsUnits = "0";
            }
        }
    }
}
