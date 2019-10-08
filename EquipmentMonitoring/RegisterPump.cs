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
    public partial class RegisterPump : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public RegisterPump()
        {
            InitializeComponent();
        }

        private void txtFullName_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSave_Click(btnSave, EventArgs.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue To Save", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                */
            string spName = "sp_Add_PumpIncharge";
            string Name = "";
            string ParamName = "";
            SqlDataReader reader;

            Name = txtFullName.Text;

            if (Name == "" || Name == " " || Name == null || Name == "   ")
            {
                MessageBox.Show("Please Enter Name");
            }
            else
            {
                ParamName = "'" + Name + "'";
                DialogResult dialogResult1 = MessageBox.Show("Please Click Yes to Continue", "Save", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    reader = monitoring.ExecuteReader(spName, ParamName);
                    DataTable result = new DataTable();
                    result.Load(reader);
                    string Result = result.Rows[0]["Result"].ToString();
                    if (Result == "0")
                    {
                        MessageBox.Show("Failed To Save..");
                    }
                    else if (Result == "1")
                    {
                        MessageBox.Show("Successfully Saved..");
                        txtFullName.Text = "";

                    }
                    else if (Result == "3")
                    {
                        MessageBox.Show("Please Enter Name");
                    }
                    else
                    {
                        MessageBox.Show("Already Saved..");
                    }
                }
                else
                {

                }

                // }
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
