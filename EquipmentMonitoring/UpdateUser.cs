using EquipmentMonitoring.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class UpdateUser : Form
    {
        string userid = "";
        GenericFunctions GenericFunc = new GenericFunctions();
        string strConnection = "";
        public string Result { get; set; }
        public UpdateUser()
        {
            InitializeComponent();
            strConnection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
            chkIsAdmin.Visible = false;
        }

        public void Param(string user)
        {
            userid = user;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(cmdType.SelectedIndex != 0)
            {
                string User_id = txtUserid.Text;
                if (Regex.Replace(User_id, @"\s+", "") != "")
                {
                    if(User_id != userid)
                    {

                        string IsAdmin = "0";
                        string password = "";

                        object pIPAddress;
                        string str = "";
                        System.Net.Dns.GetHostName();
                        IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(str);
                        IPAddress[] addr = ipEntry.AddressList;
                        pIPAddress = addr[addr.Length - 1].ToString();
                        string UpdateType;

                        UpdateType = cmdType.SelectedItem.ToString();

                        if (cmdType.SelectedIndex == 1 | cmdType.SelectedIndex == 2)
                        {
                            IsAdmin = "0";
                        }
                        //else if (cmdType.SelectedIndex == 2)
                        //{
                        //    IsAdmin = "0";
                        //}
                        else if (cmdType.SelectedIndex == 3)
                        {
                            password = Encryptor.EnDe_crypt("12345", true);
                        }
                        else if (cmdType.SelectedIndex == 4)
                        {
                            if (chkIsAdmin.Checked == true)
                            {
                                IsAdmin = "1";
                            }
                            else
                            {
                                IsAdmin = "0";
                            }
                        }

                        string strSQL = "exec sp_UpdateAccount" + " '" + User_id + "','" + UpdateType + "','" + userid + "','" + password + "','" + IsAdmin + "','" + pIPAddress + "'";
                        //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                        DataTable data = new DataTable();
                        DataTableReader readesr = GenericFunc.MSsqlDataReader(strConnection, strSQL);

                        if (readesr.Read())
                        {
                            Result = readesr["Result"].ToString();
                            //strUsrBranch = reader["Branch"].ToString();
                        }

                        if (Result == "0")
                        {
                            MessageBox.Show("Successfully Updated");
                            this.Close();
                        }
                        else if (Result == "1")
                        {
                            MessageBox.Show("Failed to update");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed to update same userid");
                    }
                }

                else
                {
                    MessageBox.Show("UserID Empty");
                }
            }
            else
            {
                MessageBox.Show("Please Select Update Type");
            }
            
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdType.SelectedIndex == 0 | cmdType.SelectedIndex == 1 | cmdType.SelectedIndex == 2 | cmdType.SelectedIndex == 3)
            {
                chkIsAdmin.Visible = false;
            }
            else
            {
                chkIsAdmin.Visible = true;
            }
        }
    }
}
