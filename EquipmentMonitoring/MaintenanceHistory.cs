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
    public partial class MaintenanceHistory : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public MaintenanceHistory()
        {
            InitializeComponent();
            getMaintenance();
            cmbList.SelectedIndex = 0;
            lblresult.Visible = false;
        }

        public void getMaintenance()
        {
            SqlDataAdapter DATA = new SqlDataAdapter("select MaintenanceId, EquipmentNo, Model, PlateNo, Kms_Used, Hrs_Used," +
                       "CONVERT(VARCHAR(10), DateView, 101) as DateView, DateMaintenance, Remarks, Preventive from m_MaintenanceList with(nolock) where Remarks = '1' " +
                       "and Kms_Used >= '3' or Hrs_Used >= '450'", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            dgvMaintenance.DataSource = null;
            if (this.dgvMaintenance.DataSource != null)
            {
                this.dgvMaintenance.DataSource = null;
            }
            else
            {
                this.dgvMaintenance.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvMaintenance.Rows.Add(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            , row["Kms_Used"].ToString()
                            , row["Hrs_Used"].ToString()
                            , row["Preventive"].ToString()
                            );
                }
                lblresult.Visible = false;
            }
            else
            {
                lblresult.Visible = true;
            }

        }

        private void txtValue_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(btnSearch, EventArgs.Empty);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtValue.Text;

            if (value == "" || value == " " || value == null)
            {
                if (this.dgvMaintenance.DataSource != null)
                {
                    this.dgvMaintenance.DataSource = null;
                }
                else
                {
                    this.dgvMaintenance.Rows.Clear();
                }

            }
            else
            {
                SqlDataAdapter DATA = new SqlDataAdapter("select MaintenanceId, EquipmentNo, Model, PlateNo, Kms_Used, Hrs_Used," +
                    "CONVERT(VARCHAR(10), DateView, 101) as DateView, DateMaintenance, Remarks, Preventive from m_MaintenanceList with(nolock) where Remarks = '1' and "
                    + cmbList.SelectedItem.ToString().Replace(" ", "")
                     + "= '" + txtValue.Text + "'" + " and Kms_Used >= '3' or Hrs_Used >= '450'", Connection);
                DataTable dt = new DataTable();
                DATA.Fill(dt);

                dgvMaintenance.DataSource = null;
                if (this.dgvMaintenance.DataSource != null)
                {
                    this.dgvMaintenance.DataSource = null;
                }
                else
                {
                    this.dgvMaintenance.Rows.Clear();
                }

                int intRecord = dt.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvMaintenance.Rows.Add(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                                , row["EquipmentNo"].ToString()
                                , row["Model"].ToString()
                                , row["PlateNo"].ToString()
                                , row["Kms_Used"].ToString()
                                , row["Hrs_Used"].ToString()
                                , row["Preventive"].ToString()
                                );
                    }
                    lblresult.Visible = false;
                }
                else
                {
                    lblresult.Visible = true;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
