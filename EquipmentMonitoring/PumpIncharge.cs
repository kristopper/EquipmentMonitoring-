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
    public partial class PumpIncharge : Form
    {
        string ID;

        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public PumpIncharge()
        {
            InitializeComponent();
            GetDriverList();
        }

        public void param(string IDs)
        {
            ID = IDs;

            this.dgvDriverList.DataSource = null;
            this.dgvDriverList.Rows.Clear();

            SqlDataAdapter DATA = new SqlDataAdapter("select * from m_PumpAttendant with(nolock) where Id = '" + ID + "'", Connection);
            DataTable dt = new DataTable();
            DATA.Fill(dt);

            dgvDriverList.DataSource = null;
            if (this.dgvDriverList.DataSource != null)
            {
                this.dgvDriverList.DataSource = null;
            }
            else
            {
                this.dgvDriverList.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgvDriverList.Rows.Add(row["Id"].ToString()
                            , row["Name"].ToString()
                            , row["Status"].ToString()
                            );
                }
            }
        }

        public void GetDriverList()
        {
            if (ID == "" | ID == " " | ID == null | ID is null)
            {
                SqlDataAdapter DATA = new SqlDataAdapter("select * from m_PumpAttendant with(nolock)", Connection);
                DataTable dt = new DataTable();
                DATA.Fill(dt);

                dgvDriverList.DataSource = null;
                if (this.dgvDriverList.DataSource != null)
                {
                    this.dgvDriverList.DataSource = null;
                }
                else
                {
                    this.dgvDriverList.Rows.Clear();
                }

                int intRecord = dt.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvDriverList.Rows.Add(row["Id"].ToString()
                                , row["Name"].ToString()
                                , row["Status"].ToString()
                                );
                    }
                }
            }
            else
            {

                SqlDataAdapter DATA = new SqlDataAdapter("select * from m_PumpAttendant with(nolock) where Id = '" + ID + "'", Connection);
                DataTable dt = new DataTable();
                DATA.Fill(dt);

                dgvDriverList.DataSource = null;
                if (this.dgvDriverList.DataSource != null)
                {
                    this.dgvDriverList.DataSource = null;
                }
                else
                {
                    this.dgvDriverList.Rows.Clear();
                }

                int intRecord = dt.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvDriverList.Rows.Add(row["Id"].ToString()
                                , row["Name"].ToString()
                                , row["Status"].ToString()
                                );
                    }
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtName.Text;

            if (value == "" || value == " " || value == null)
            {
                if (this.dgvDriverList.DataSource != null)
                {
                    this.dgvDriverList.DataSource = null;
                }
                else
                {
                    this.dgvDriverList.Rows.Clear();
                }

            }
            else
            {
                SqlDataAdapter DATA = new SqlDataAdapter("select * from m_PumpAttendant with(nolock) where Name Like '%"
                   + txtName.Text + "%'", Connection);
                DataTable dt = new DataTable();
                DATA.Fill(dt);

                dgvDriverList.DataSource = null;
                if (this.dgvDriverList.DataSource != null)
                {
                    this.dgvDriverList.DataSource = null;
                }
                else
                {
                    this.dgvDriverList.Rows.Clear();
                }

                int intRecord = dt.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvDriverList.Rows.Add(row["Id"].ToString()
                                , row["Name"].ToString()
                                , row["Status"].ToString()
                                );
                    }
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

        private void dgvDriverList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            string id = dgvDriverList[0, e.RowIndex].Value.ToString();
            string Name = dgvDriverList[1, e.RowIndex].Value.ToString();
            string Status = dgvDriverList[2, e.RowIndex].Value.ToString();
            string statusid;

            if (Status == "Active")
            {
                statusid = "0";
            }
            else
            {
                statusid = "1";
            }

            UpdatePump update = new UpdatePump();
            update.param(id, Name, statusid);
            update.ShowDialog();
            this.Close();
        }
    }
}
