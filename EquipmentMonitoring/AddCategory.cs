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
    public partial class AddCategory : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public AddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void lnkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SubCategory sub = new SubCategory();
            sub.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = "";
                SqlDataReader reader;
                string Category = "";
                string spName = "sp_Add_Category";

                int count = 0;
                int numRows = dgvCategory.Rows.Count;
                int loop = numRows - 1;

                for (int i = 0; i < loop; i++)
                {
                    
                    if (Convert.ToString(dgvCategory.Rows[i].Cells[0].FormattedValue) != string.Empty)
                    {
                        Category = "'" + dgvCategory.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                    }

                    reader = monitoring.ExecuteReader(spName, Category);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        dgvCategory.Rows.Remove(dgvCategory.Rows[i]);
                        i = i - 1;
                        loop = loop - 1;
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Category " + Category + " Already Exist");
                        dgvCategory.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                        //dgvDailySheet.RowsDefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgvCategory.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                    }

                    // ok = 0;
                }

            }
        }
    }
}
