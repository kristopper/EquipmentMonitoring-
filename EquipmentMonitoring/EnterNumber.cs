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
    public partial class EnterNumber : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        GenericFunctions GenericFunc = new GenericFunctions();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public string formtype { get; set; }

        public EnterNumber()
        {
            InitializeComponent();
        }

        public void param(string form)
        {
            formtype = form;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string Value = "";
            string Number = " ";
            string NumberofTable = " ";
            string EquipmentNo = " ";
            string EquipmentName = " ";
            string NumberName = " ";
            string Truckid = " ";
            string IsMaintenance = " ";
            string TotalUsed = " ";
            string Trucktype = " ";
            string main = "";

            //Enter Equipment No Or Plate No./Model Name
            /*
            if (rdEqpNo.Checked)
            {
                Value = "EquipmentNo";
            }
            else
            {
                Value = "ModelName";
            }
            */
            Value = "EquipmentNo";

            Number = txtEnternumber.Text;
            if (Number == " " || Number == "" || Number == null)
            {
                MessageBox.Show("Please Enter Equipment No Or Plate No./Model Name");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Please Click Yes to Continue", "Search", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, ("exec sp_Get_InfoAndMonitoring '" + Value + "'," + "'" + Number + "'"));
                    DataTableReader drKey = dsKey.Tables[0].CreateDataReader();
                    if (drKey.Read())
                    {

                        NumberofTable = dsKey.Tables[0].Rows[0]["NumberofTable"].ToString();
                        main = dsKey.Tables[0].Rows[0]["maintable"].ToString();

                        if (NumberofTable == "0")
                        {
                            MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                        }
                        else
                        {
                            if (main != "0")
                            {
                                IsMaintenance = dsKey.Tables[1].Rows[0]["IsMaintenance"].ToString();
                                TotalUsed = dsKey.Tables[1].Rows[0]["TotalUsed"].ToString();

                                EquipmentNo = dsKey.Tables[2].Rows[0]["EquipmentNo"].ToString();
                                EquipmentName = dsKey.Tables[2].Rows[0]["Model"].ToString();
                                NumberName = dsKey.Tables[2].Rows[0]["PlateNo"].ToString();
                                Truckid = dsKey.Tables[2].Rows[0]["TruckId"].ToString();
                                Trucktype = dsKey.Tables[2].Rows[0]["Trucktype"].ToString();

                                AddMonitoring monitoring = new AddMonitoring();
                                monitoring.Param(EquipmentNo, EquipmentName, NumberName, Truckid, dsKey.Tables[3], NumberofTable, Value, TotalUsed, IsMaintenance, formtype, Trucktype);
                                this.Hide();
                                monitoring.ShowDialog(this);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Record Not Found. Please check Equipment No Or Plate No./Model Name.");
                            }
                        }
                    }
                    else
                    {

                    }

                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (formtype == "Main")
            {
                mainform main = new mainform();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                this.Close();
            }
        }

        private void txtEnternumber_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                //btnOK.PerformClick();
                btnOK_Click(btnOK, EventArgs.Empty);
            }
        }
    }
}
