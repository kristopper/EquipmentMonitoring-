using EquipmentMonitoring.Libs;
using EquipmentMonitoring.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring.AllForm.expenses
{
    public partial class RepairMeRemarks : Form
    {
        GenericFunctions GenericFunc = new GenericFunctions();
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        string SExpID = "";
        string sUserID = "";
        string sMechanicName = "";
        string sMechanicID = "";

        public string Result { get; set; }

        public string IsCancel { get; set; }
        public RepairMeRemarks()
        {
            InitializeComponent();
        }


        public void GetRepairMERemark(string pMechanicID, string pExpID)
        {
            string strSQL = "exec sp_Get_RepairMERemark" + " '" + SExpID + "', '" + pMechanicID + "'";
            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, strSQL);

            int results = dsKey.Tables[0].Rows.Count;
     

            if (results > 0)
            {
                dgvRemark.DataSource = null;

                if (this.dgvRemark.DataSource != null)
                {
                    this.dgvRemark.DataSource = null;
                }
                else
                {
                    this.dgvRemark.Rows.Clear();
                }

                foreach (DataRow row in dsKey.Tables[0].Rows)
                {
                    dgvRemark.Rows.Add(row["RemarkID"].ToString()
                             , row["DateRemark"].ToString().Replace(" 12:00:00 AM", "")
                             , row["Remark"].ToString().Replace(" 12:00:00 AM", "")
                  );

                }
            }
        }

        public void Param(string pMechanicID, string pMechanicName, string pExpID, string pUserID)
        {
            SExpID = pExpID;
            sUserID = pUserID;
            sMechanicName = pMechanicName;
            sMechanicID = pMechanicID;
            IsCancel = "1";

            lblMechanic.Text = pMechanicName;
            GetRepairMERemark(pMechanicID, pExpID);


        }

        private void BtnAddRemark_Click(object sender, EventArgs e)
        {
            string Name = txtRemarks.Text;
            string date = dtDate.Text;

            if (Regex.Replace(Name, @"\s+", "") != "")
            {
                string strSQL = "exec sp_Add_RepairMERemark" + " '" + SExpID + "','" + sMechanicID + "','" + date + "','" + Name + "','" + sUserID +  "'";
                //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                DataTable data = new DataTable();
                DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);

                if (readesr.Read())
                {
                    Result = readesr["Result"].ToString();
                    //strUsrBranch = reader["Branch"].ToString();
                }

                if (Result == "1")
                {
                    MessageBox.Show("Successfully Save");
                    GetRepairMERemark(sMechanicID, SExpID);
                    txtRemarks.Text = "";
                }
                else
                {
                    MessageBox.Show("Fail to Save");
                }
            }
            else
            {
                MessageBox.Show("Remark Field Empty!");
            }
        }
    }
}
