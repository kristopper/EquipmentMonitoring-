using EquipmentMonitoring.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    public partial class ChangePassword : Form
    {

        /*DataTableReader reader;*/
        GenericFunctions GenericFunc = new GenericFunctions();

        string userid = "";
        public string ChangeResult { get; set; }
        string strConnection = "";

        public string Result { get; set; }

        public ChangePassword()
        {
            InitializeComponent();
            strConnection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        }

        public void Param(string user)
        {
            userid = user;
        }
        private void txtnewpass_TextChanged(object sender, EventArgs e)
        {
            bool isValid = txtnewpass.Text.Length < 8;
            bool Isconfirm = txtconfirm.Text.Length < 8;


            lblNewpassword.Visible = isValid;
            if (isValid == false)
            {
                if (isValid == Isconfirm)
                {
                    btnsave.Visible = true;
                }
                else
                {
                    btnsave.Visible = false;
                }
            }
            else
            {
                btnsave.Visible = false;
            }
        }

        private void txtconfirm_TextChanged(object sender, EventArgs e)
        {
            bool isValid = txtnewpass.Text.Length < 8;
            bool Isconfirm = txtconfirm.Text.Length < 8;


            lblConfirmPass.Visible = Isconfirm;
            if (Isconfirm == false)
            {
                if (isValid == Isconfirm)
                {
                    btnsave.Visible = true;
                }
                else
                {
                    btnsave.Visible = false;
                }
            }
            else
            {
                btnsave.Visible = false;
            }
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            object pIPAddress;
            string str = "";
            System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(str);
            IPAddress[] addr = ipEntry.AddressList;
            pIPAddress = addr[addr.Length - 1].ToString();



            string currentpass = Encryptor.EnDe_crypt(txtcurrentpass.Text, true);
            string newpass = Encryptor.EnDe_crypt(txtnewpass.Text, true);
            string confirmpass = Encryptor.EnDe_crypt(txtconfirm.Text, true);


            string spName = "exec sp_Changepass";
            string Userid = "'" + userid + "'";
            string parmcurrentpass = "'" + currentpass + "'";
            string parmnewpass = "'" + newpass + "'";
            string parmpIPAddress = "'" + pIPAddress + "'";

            //string strSQL = "exec sp_ScannerChangepass" + " '" + userid + "','" + currentpass + "','" + newpass + "','" + pIPAddress + "'";




            if (currentpass != "v8x/nZtWOrw=")
            {
                if (currentpass != newpass)
                {
                    if (newpass == confirmpass)
                    {
                        string strSQL = "exec sp_Changepass" + " '" + userid + "','" + currentpass + "','" + newpass + "','" + pIPAddress + "'";
                        //reader = GenericFunc.ExecuteReader(spName, Userid, parmcurrentpass, parmnewpass, parmpIPAddress);
                        DataTable data = new DataTable();
                        DataTableReader readesr = GenericFunc.MSsqlDataReader(strConnection, strSQL);
                        //data.Load(reader);

                        //Result = data.Rows[0]["Result"].ToString();
                        //Result = data.Rows[0]["Result"].ToString();
                        if (readesr.Read())
                        {
                            Result = readesr["Result"].ToString();
                            //strUsrBranch = reader["Branch"].ToString();
                        }

                        ChangeResult = Result;

                        if (Result == "0")
                        {
                            MessageBox.Show("Successfully Changed");
                            this.Close();
                        }
                        else if (Result == "1")
                        {
                            MessageBox.Show("Incorrect Current Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password and Confirm password not Matched");
                    }


                }
                else
                {
                    MessageBox.Show("Current password and New password Matched");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Current password, New Password and Confirm Password");
            }
        }
    }
}
