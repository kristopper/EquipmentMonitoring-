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
    public partial class UpdatePump : Form
    {

        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        string ID;
        string DriverName;
        string Status;

        public UpdatePump()
        {
            InitializeComponent();
        }

        public void param(string pId, string pName, string pStatus)
        {
            ID = pId;
            DriverName = pName;
            Status = pStatus;
            lblId.Text = pId;
            txtName.Text = pName;
            cmbStatus.SelectedIndex = Int32.Parse(pStatus);
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PumpIncharge driver = new PumpIncharge();
            driver.param(ID);
            driver.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue To DELETE", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string id = "'" + lblId.Text + "'";
                string IsSave;

                string spName = "sp_Delete_Pump";
                SqlDataReader reader;


                reader = monitoring.ExecuteReader(spName, id);
                DataTable result = new DataTable();
                result.Load(reader);
                IsSave = result.Rows[0]["Result"].ToString();

                if (IsSave == "0")
                {
                    MessageBox.Show("Failed To Delete..");
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Successfully Deleted..");
                    PumpIncharge driver = new PumpIncharge();
                    driver.ShowDialog();
                    this.Close();

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue To SAVE", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string id = "'" + lblId.Text + "'";
                string DriverName = "'" + txtName.Text + "'";
                string Status = "'" + cmbStatus.SelectedItem.ToString() + "'";
                string IsSave;

                string spName = "sp_Update_Pump";
                SqlDataReader reader;


                reader = monitoring.ExecuteReader(spName, id, DriverName, Status);
                DataTable result = new DataTable();
                result.Load(reader);
                IsSave = result.Rows[0]["Result"].ToString();

                if (IsSave == "0")
                {
                    MessageBox.Show("Failed To Save..");
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Successfully Saved..");
                    PumpIncharge driver = new PumpIncharge();
                    driver.param(ID);
                    driver.ShowDialog();
                    this.Close();

                }
            }
        }
    }
}
