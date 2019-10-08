using EquipmentMonitoring.Repository;
using System;
using System.Collections;
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
    public partial class SubCategory : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        DataTable dt = new DataTable();

        DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

        public SubCategory()
        {
            InitializeComponent();
        }
        private void SubCategory_Load(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("select m_CategoryList.Category from m_CategoryList with (nolock) where Category != 'ALL'  order by id asc", Con);

                da.Fill(dt);

                combo.HeaderText = "CATEGORY";
                combo.Name = "Category";


                ///  combo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

                ArrayList row = new ArrayList();

                foreach (DataRow dr in dt.Rows)
                {
                    row.Add(dr["Category"].ToString());
                }


                combo.Items.AddRange(row.ToArray());
                
                dgvSubCategory.Columns.Add(combo);
                dgvSubCategory.Columns[1].Width = 257;
            }

        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = "";
                SqlDataReader reader;
                string Category = "";
                string SubCategory = "";
                string spName = "sp_Add_SubCategory";

                int count = 0;
                int numRows = dgvSubCategory.Rows.Count;
                int loop = numRows - 1;

                for (int i = 0; i < loop; i++)
                {

                    if (Convert.ToString(dgvSubCategory.Rows[i].Cells[0].FormattedValue) != string.Empty)
                    {
                        SubCategory = "'" + dgvSubCategory.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                    }

                    if (Convert.ToString(dgvSubCategory.Rows[i].Cells[1].FormattedValue) != string.Empty)
                    {
                        Category = "'" + dgvSubCategory.Rows[i].Cells[1].FormattedValue.ToString() + "'";
                    }

                    reader = monitoring.ExecuteReader(spName, Category, SubCategory);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        dgvSubCategory.Rows.Remove(dgvSubCategory.Rows[i]);
                        i = i - 1;
                        loop = loop - 1;
                    }
                    else if (result == "2")
                    {
                        MessageBox.Show("Sub-Category " +   SubCategory + " CATEGORY : " + Category + "  Already Exist");
                        dgvSubCategory.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                        //dgvDailySheet.RowsDefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgvSubCategory.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                    }

                    // ok = 0;
                }

            }
        }
    }
}
