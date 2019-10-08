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

namespace EquipmentMonitoring.AllForm.expenses
{
    public partial class FinalMechanic : Form
    {

        GenericFunctions GenericFunc = new GenericFunctions();
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        string SExpID = "";
        string sUserID = "";

        public void Param(string pExpID, string pUserID)
        {
            SExpID = pExpID;
            sUserID = pUserID;
            GetRepairME();

        }

        public FinalMechanic()
        {
            InitializeComponent();
        }

        public void GetRepairME()
        {
            string result;
            string strSQL = "exec sp_Get_RepairME" + " '" + SExpID + "'";
            //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
            //DataTable data = new DataTable();
            //DataTableReader readesr = GenericFunc.MSsqlDataReader(Connection, strSQL);
            DataSet dsKey = GenericFunc.DataSetFromMSSQL(Connection, strSQL);

            int results = dsKey.Tables[0].Rows.Count;
            //if (readesr.Read())
            //{
            //    result = readesr["Name"].ToString();
            //    //strUsrBranch = reader["Branch"].ToString();
            //}

            if (results > 0)
            {

                dgvMechanic.DataSource = null;

                if (this.dgvMechanic.DataSource != null)
                {
                    this.dgvMechanic.DataSource = null;
                }
                else
                {
                    this.dgvMechanic.Rows.Clear();
                }


                foreach (DataRow row in dsKey.Tables[0].Rows)
                {
                    dgvMechanic.Rows.Add(row["MechanicID"].ToString()
                             , row["IsComplete"].ToString()
                             , row["Name"].ToString()
                  );

                }
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            int numRows = dgvMechanic.Rows.Count;
            int loop = numRows;

            using (SqlConnection con = new SqlConnection(Connection))
            {
                con.Open();

                for (int i = 0; i < loop; i++)
                {
                    using (SqlCommand cmd = new SqlCommand("[sp_FinalRepairMechanic]", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        string IsComplete = "";
                        string Id = dgvMechanic.Rows[i].Cells[0].FormattedValue.ToString();
                        //string IsComplete = dgvMechanic.Rows[i].Cells[1].FormattedValue.ToString();

                        if (Convert.ToBoolean(dgvMechanic.Rows[i].Cells["I"].Value) == true)
                        {
                            IsComplete = "1";
                        }
                        else
                        {
                            IsComplete = "0";
                        }

                        string UserID = sUserID;

                        cmd.Parameters.Add("@MechanicId", SqlDbType.VarChar).Value = Id;
                        cmd.Parameters.Add("@IsComplete", SqlDbType.VarChar).Value = IsComplete;
                        cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;

                        cmd.ExecuteNonQuery();
                    }
                }

            }

            this.Close();
        }
    }
}
