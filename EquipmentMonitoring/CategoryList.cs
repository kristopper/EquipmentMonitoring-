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
    public partial class CategoryList : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        public CategoryList()
        {
            InitializeComponent();
            CategoryParent();
            CategorysList();
        }

        private void CategorysList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category] from m_SubCategoryList with(nolock) where [Sub-Category] != 'All'" +
                    "and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All')", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvCategory.DataSource = null;

            if (this.dgvCategory.DataSource != null)
            {
                this.dgvCategory.DataSource = null;
            }
            else
            {
                this.dgvCategory.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                        dgvCategory.Rows.Add(row["Category"].ToString()
                            , row["Sub-Category"].ToString()
                            );
                }
            }
            else
            {
            }
        }

        private void CategoryParent()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_CategoryList with(nolock)", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "Category";

        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.SelectedValue.ToString().ToUpper();

            if (category == "ALL")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category] from m_SubCategoryList with(nolock) where [Sub-Category] != 'All'" +
                    "and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All')", Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCategory.DataSource = null;

                if (this.dgvCategory.DataSource != null)
                {
                    this.dgvCategory.DataSource = null;
                }
                else
                {
                    this.dgvCategory.Rows.Clear();
                }

                int intRecord = dt.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvCategory.Rows.Add(row["Category"].ToString()
                                , row["Sub-Category"].ToString()
                                );
                    }
                }
                else
                {
                }
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("Select Category, [Sub-Category] from m_SubCategoryList with(nolock) where [Sub-Category] != 'All' " +
                    "and [Sub-Category] not in (Select Category from m_CategoryList with(nolock) where Category != 'All') and Category = '" + category + "'", Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCategory.DataSource = null;

                if (this.dgvCategory.DataSource != null)
                {
                    this.dgvCategory.DataSource = null;
                }
                else
                {
                    this.dgvCategory.Rows.Clear();
                }

                int intRecord = dt.Rows.Count;
                if (intRecord > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvCategory.Rows.Add(row["Category"].ToString()
                                , row["Sub-Category"].ToString()
                                );
                    }
                }
                else
                {
                }
            }
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string pCategory = dgvCategory[0, e.RowIndex].Value.ToString();
            string pSubCategory = dgvCategory[1, e.RowIndex].Value.ToString();

            this.Hide();
            EditCategory category = new EditCategory();
            category.param(pCategory, pSubCategory);
            this.Close();
            category.ShowDialog();
        }

        private void lnkEditCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pCategory = cmbCategory.SelectedValue.ToString().ToUpper();
            
            if (pCategory == "ALL")
            {
                MessageBox.Show("Please Select Category");
            }
            else
            {
                this.Hide();
                RenameCategory rename = new RenameCategory();
                rename.param(pCategory);
                this.Close();
                rename.ShowDialog();
            }
        }
    }
}
