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
    public partial class MaintenanceList : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public MaintenanceList()
        {
            InitializeComponent();
            getMaintenance();
            cmbList.SelectedIndex = 0;
            lblresult.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        public void getMaintenance()
        {
            SqlDataAdapter DATA = new SqlDataAdapter("select MaintenanceId, EquipmentNo, Model, PlateNo, Kms_Used, Hrs_Used," +
                       "CONVERT(VARCHAR(10), DateView, 101) as DateView, DateMaintenance, Remarks, Preventive from m_MaintenanceList with(nolock) where Remarks = '0' " +
                       "and Kms_Used >= ' 9900' or Hrs_Used >= '450'", Connection);
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
                    "CONVERT(VARCHAR(10), DateView, 101) as DateView, DateMaintenance, Remarks, Preventive from m_MaintenanceList with(nolock) where Remarks = '0' and " 
                    + cmbList.SelectedItem.ToString().Replace(" ","")
                     + "= '" + txtValue.Text + "'" + " and Kms_Used >= '9900' or Hrs_Used >= '450'", Connection);
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

        private void txtValue_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(btnSearch, EventArgs.Empty);
            }
        }

        private void dgvMaintenance_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            this.Hide();
            string Equipmentno = dgvMaintenance[1, e.RowIndex].Value.ToString();
            string Model = dgvMaintenance[2, e.RowIndex].Value.ToString();
            string Plateno = dgvMaintenance[3, e.RowIndex].Value.ToString();
            string Preventive;
            string Maintenanceid;

            string PEquipmentno = "'" + Equipmentno + "'";
            string PModel = "'" + Plateno + "'";
            string PPlateno = "'" + Plateno + "'";

            string spName = "sp_Get_Preventive";
            SqlDataReader reader;
  
                reader = monitoring.ExecuteReader(spName, PEquipmentno, PModel, PPlateno);
                DataTable result = new DataTable();
                result.Load(reader);
                 Preventive = result.Rows[0]["Result"].ToString();
                 Maintenanceid = result.Rows[0]["MaintenanceId"].ToString();


            ProcessMaintenance process = new ProcessMaintenance();
            process.param(Equipmentno, Model, Plateno, Preventive, Maintenanceid);
            process.ShowDialog();
            this.Close();
            */
            /*
            if (dgvScanned.CurrentCell.ColumnIndex == 0)
            {
                string[] strMicr = dgvScanned[e.ColumnIndex, e.RowIndex].Value.ToString().Split('_'); //dgvScanned.cell.Value.ToString();//strNewFlnm.Split('_');

                InputMicr Micr = new InputMicr();
                Micr.strChecknumber = strMicr[1];
                Micr.strbrstn1 = strMicr[2];
                Micr.strbrstn2 = strMicr[3];
                Micr.strAccountnumber = strMicr[4];
                Micr.ShowDialog(this);
                string x = Micr.strChecknumber;

                dgvScanned.Rows[e.RowIndex].Cells[2].Value = Micr.strChecknumber.ToString().PadLeft(10, '0');
                dgvScanned.Rows[e.RowIndex].Cells[3].Value = Micr.strAccountnumber.ToString().PadLeft(12, '0');
                dgvScanned.Rows[e.RowIndex].Cells[0].Value = "_" + Micr.strChecknumber.ToString().PadLeft(10, '0') + "_" + Micr.strbrstn1 + "_" + Micr.strbrstn2 + "_" + Micr.strAccountnumber.ToString().PadLeft(12, '0') + "_";

            }
            else
            {

            }
            */
        }

        private void dgvMaintenance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.Hide();
            string Equipmentno = dgvMaintenance[1, e.RowIndex].Value.ToString();
            string Model = dgvMaintenance[2, e.RowIndex].Value.ToString();
            string Plateno = dgvMaintenance[3, e.RowIndex].Value.ToString();
            string Preventive;
            string Maintenanceid;

            string PEquipmentno = "'" + Equipmentno + "'";
            string PModel = "'" + Plateno + "'";
            string PPlateno = "'" + Plateno + "'";

            string spName = "sp_Get_Preventive";
            SqlDataReader reader;

            reader = monitoring.ExecuteReader(spName, PEquipmentno, PModel, PPlateno);
            DataTable result = new DataTable();
            result.Load(reader);
            Preventive = result.Rows[0]["Result"].ToString();
            Maintenanceid = result.Rows[0]["MaintenanceId"].ToString();


            ProcessMaintenance process = new ProcessMaintenance();
            //process.param(Equipmentno, Model, Plateno, Preventive, Maintenanceid, userlogin);
            process.ShowDialog();
            this.Close();
        }
    }
}
