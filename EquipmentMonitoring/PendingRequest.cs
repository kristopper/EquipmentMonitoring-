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
    public partial class PendingRequest : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();

        string isCheck = "0";
        string status = "All";
        DataTable dtdata = new DataTable();
        DataTable dt = new DataTable();
        DataTable unit = new DataTable();

        SqlDataAdapter da;
        SqlDataAdapter daData;
        ArrayList EquipArray = new ArrayList();

        public PendingRequest()
        {
            InitializeComponent();
            dgvExpenses.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExpenses.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExpenses.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvExpenses.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_ServiceUnitList with (nolock)", Con);

                da.Fill(unit);


                foreach (DataRow dr in unit.Rows)
                {
                    EquipArray.Add(dr["EquipmentNo"].ToString());
                    EquipArray.Add(dr["Model"].ToString());
                    EquipArray.Add(dr["PlateNo"].ToString());
                }
            }

            CategoryParent();
           // PendingExpenses();
            cmbstatus.SelectedIndex = 0;
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

        private void PendingExpenses()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvExpenses.DataSource = null;

            if (this.dgvExpenses.DataSource != null)
            {
                this.dgvExpenses.DataSource = null;
            }
            else
            {
                this.dgvExpenses.Rows.Clear();
            }

            int intRecord = dt.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    //(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                    dgvExpenses.Rows.Add(row["Id"].ToString()
                        , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                   //, row["Category"].ToString()
                   // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                        , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                        , row["Diagnosis"].ToString()   
                        , row["Driver"].ToString()
                        , row["ProjectSite"].ToString()
                        , row["Remarks"].ToString()
                        , row["SubCategory"].ToString()
                        , row["RepairStatus"].ToString()
                        , row["PurChaseStatus"].ToString()
                        );
                }
            }
            else
            {
            }
        }

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateExpenses update = new UpdateExpenses();
          //dtProjectSite  update.Param(dgvExpenses[0, e.RowIndex].Value.ToString(), dgvExpenses[8, e.RowIndex].Value.ToString(), dgvExpenses[9, e.RowIndex].Value.ToString(), dt);
            update.ShowDialog();

            dgvExpenses[1, e.RowIndex].Value = update.strdate;
            dgvExpenses[2, e.RowIndex].Value = update.strEquipment;
            dgvExpenses[3, e.RowIndex].Value = update.strSolution;
            dgvExpenses[4, e.RowIndex].Value = update.strDriver;
            dgvExpenses[5, e.RowIndex].Value = update.strSite;
            dgvExpenses[6, e.RowIndex].Value = update.strremark;
            dgvExpenses[7, e.RowIndex].Value = update.strCategory;
            dgvExpenses[8, e.RowIndex].Value = update.strRStatus;
            dgvExpenses[9, e.RowIndex].Value = update.strPStatus;

            // dgvExpenses[4, e.RowIndex].Value = update.strDuringRefuel;
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            PendingExpenses();
        }

        private void Equip(AutoCompleteStringCollection data)
        {
            foreach (var item in EquipArray)
                data.AddRange(new string[] { item.ToString() });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtdata.Clear();
            if (txtEquip.Text == "")
            {
                if (cmbCategory.Text == "ALL")
                {
                    if (cmbstatus.Text == "All")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if(cmbstatus.Text == "Pending Purchase")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Pending Repair")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "All Pending")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and  " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Parts Completed")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else //if (cmbstatus.Text == "Repair Completed")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
 
                }
                else
                {
                    if (cmbstatus.Text == "All")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + cmbCategory.Text + "' and " + 
                                  "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + cmbCategory.Text + "' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Pending Purchase")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + cmbCategory.Text + "' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + cmbCategory.Text + "' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Pending Repair")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + cmbCategory.Text + "' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + cmbCategory.Text + "' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "All Pending")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + cmbCategory.Text + "' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + cmbCategory.Text + "' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Parts Completed")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + cmbCategory.Text + "' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + cmbCategory.Text + "' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else //if (cmbstatus.Text == "Repair Completed")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + cmbCategory.Text + "' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + cmbCategory.Text + "' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                }
            }
            else
            {
                if (cmbCategory.Text == "ALL")
                {
                    if (cmbstatus.Text == "All")
                    {
                        if (isCheck == "0")
                        {
                            /*
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                                  "Diagnosis like '%" + txtSolution.Text +
                                  "%' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%'", Connection);
                            */
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Pending Purchase")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where  ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and  EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and  EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Pending Repair")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and  EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and  EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "All Pending")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and  EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and   EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Parts Completed")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else //if (cmbstatus.Text == "Repair Completed")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }

                }
                else
                {
                    if (cmbstatus.Text == "All")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                  "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Pending Purchase")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and IsPurchase = 1 and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Pending Repair")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')='' and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "All Pending")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')='' and ISNULL(RepairCompleted,'')='' and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else if (cmbstatus.Text == "Parts Completed")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(PartsCompleted,'')<>'' and IsPurchase = 1 and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    else //if (cmbstatus.Text == "Repair Completed")
                    {
                        if (isCheck == "0")
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                 "Diagnosis like '%" + txtSolution.Text + "%' order by id asc", Connection);
                        }
                        else
                        {
                            // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                            daData = new SqlDataAdapter("select * from m_Expenses with (nolock) where ISNULL(RepairCompleted,'')<>'' and Category = '" + cmbCategory.Text + "' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                                 + "%' or Model like '%" + txtEquip.Text + "%' and " +
                                    "Diagnosis like '%" + txtSolution.Text + "%' and Date Between '" + dtfrom.Text + "' and '" + dtTo.Text + "' order by id asc", Connection);
                        }
                    }
                    
                }
            }

            /////////////////////////////////////here
            daData.Fill(dtdata);

            dgvExpenses.DataSource = null;

            if (this.dgvExpenses.DataSource != null)
            {
                this.dgvExpenses.DataSource = null;
            }
            else
            {
                this.dgvExpenses.Rows.Clear();
            }

            int intRecord = dtdata.Rows.Count;
            if (intRecord > 0)
            {
                foreach (DataRow row in dtdata.Rows)
                {
                    //(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                    dgvExpenses.Rows.Add(row["Id"].ToString()
                        , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                        //, row["Category"].ToString()
                        // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                        , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                        , row["Diagnosis"].ToString()
                        , row["Driver"].ToString()
                        , row["ProjectSite"].ToString()
                        , row["Remarks"].ToString()
                        , row["SubCategory"].ToString()
                        , row["RepairStatus"].ToString()
                        , row["PurChaseStatus"].ToString()
                        );
                }
            }
            else
            {
            }


        }



        /*
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtEquip.Text == "")
            {
                if (cmbCategory.Text == "ALL")
                {
                    if (cmbstatus.Text == "All")
                    {
                        SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                             // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                             "Diagnosis like '%" + txtSolution.Text + "%'", Connection);
                    }
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvExpenses.DataSource = null;

                    if (this.dgvExpenses.DataSource != null)
                    {
                        this.dgvExpenses.DataSource = null;
                    }
                    else
                    {
                        this.dgvExpenses.Rows.Clear();
                    }

                    int intRecord = dt.Rows.Count;
                    if (intRecord > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            //(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                            dgvExpenses.Rows.Add(row["Id"].ToString()
                                , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                                //, row["Category"].ToString()
                                // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                                , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                                , row["Diagnosis"].ToString()
                                , row["Driver"].ToString()
                                , row["ProjectSite"].ToString()
                                , row["Remarks"].ToString()
                                , row["Category"].ToString()
                                , row["RepairStatus"].ToString()
                                , row["PurChaseStatus"].ToString()
                                );
                        }
                    }
                    else
                    {
                    }
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                    //SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                        "Category = '" + cmbCategory.Text + "' and Diagnosis like '%" + txtSolution.Text + "%'", Connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvExpenses.DataSource = null;

                    if (this.dgvExpenses.DataSource != null)
                    {
                        this.dgvExpenses.DataSource = null;
                    }
                    else
                    {
                        this.dgvExpenses.Rows.Clear();
                    }

                    int intRecord = dt.Rows.Count;
                    if (intRecord > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            //(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                            dgvExpenses.Rows.Add(row["Id"].ToString()
                                , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                                //, row["Category"].ToString()
                                // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                                , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                                , row["Diagnosis"].ToString()
                                , row["Driver"].ToString()
                                , row["ProjectSite"].ToString()
                                , row["Remarks"].ToString()
                                , row["Category"].ToString()
                                , row["RepairStatus"].ToString()
                                , row["PurChaseStatus"].ToString()
                                );
                        }
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                if (cmbCategory.Text == "ALL")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                    //SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                         "Diagnosis like '%" + txtSolution.Text +
                         "%' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                        + "%' or Model like '%" + txtEquip.Text + "%'", Connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvExpenses.DataSource = null;

                    if (this.dgvExpenses.DataSource != null)
                    {
                        this.dgvExpenses.DataSource = null;
                    }
                    else
                    {
                        this.dgvExpenses.Rows.Clear();
                    }

                    int intRecord = dt.Rows.Count;
                    if (intRecord > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            //(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                            dgvExpenses.Rows.Add(row["Id"].ToString()
                               , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                               //, row["Category"].ToString()
                               // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                               , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                               , row["Diagnosis"].ToString()
                               , row["Driver"].ToString()
                               , row["ProjectSite"].ToString()
                               , row["Remarks"].ToString()
                               , row["Category"].ToString()
                               , row["RepairStatus"].ToString()
                               , row["PurChaseStatus"].ToString()
                               );
                        }
                    }
                    else
                    {
                    }
                }
                else
                {
                   // SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where Status = 'Pending'" +
                    SqlDataAdapter da = new SqlDataAdapter("select * from m_Expenses with (nolock) where " +
                        "Category = '" + cmbCategory.Text + "' and Diagnosis like '%" + txtSolution.Text +
                         "%' and EquipmentNo like '%" + txtEquip.Text + "%' or PlateNo like '%" + txtEquip.Text
                        + "%' or Model like '%" + txtEquip.Text + "%'", Connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvExpenses.DataSource = null;

                    if (this.dgvExpenses.DataSource != null)
                    {
                        this.dgvExpenses.DataSource = null;
                    }
                    else
                    {
                        this.dgvExpenses.Rows.Clear();
                    }

                    int intRecord = dt.Rows.Count;
                    if (intRecord > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            //(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                            dgvExpenses.Rows.Add(row["Id"].ToString()
                                , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                                //, row["Category"].ToString()
                                // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                                , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                                , row["Diagnosis"].ToString()
                                , row["Driver"].ToString()
                                , row["ProjectSite"].ToString()
                                , row["Remarks"].ToString()
                                , row["Category"].ToString()
                                , row["RepairStatus"].ToString()
                                , row["PurChaseStatus"].ToString()
                                );
                        }
                    }
                    else
                    {
                    }
                }
            }
        }
        */
        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
           if (chkFilter.Checked == true)
            {
                groupDate.Visible = true;
                isCheck = "1";
            }
           else
            {
                groupDate.Visible = false;
                isCheck = "0";
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmbstatus.SelectedIndex == 0)
           {
                status = "All";
           }
        }

        ////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////
        /*
        da.Fill(dtdata);

        dgvExpenses.DataSource = null;

        if (this.dgvExpenses.DataSource != null)
        {
            this.dgvExpenses.DataSource = null;
        }
        else
        {
            this.dgvExpenses.Rows.Clear();
        }

        int intRecord = dt.Rows.Count;
        if (intRecord > 0)
        {
            foreach (DataRow row in dtdata.Rows)
            {
                //(row["DateView"].ToString().Replace(" 12:00:00 AM", "")
                dgvExpenses.Rows.Add(row["Id"].ToString()
                    , row["Date"].ToString().Replace(" 12:00:00 AM", "")
                    //, row["Category"].ToString()
                    // , (row["EquipmentNo"].ToString() == "" ? row["EquipmentNo"].ToString() : (row["PlateNo"].ToString() == "" ? row["PlateNo"].ToString() : row["Model"].ToString())
                    , (row["EquipmentNo"].ToString() == "" ? (row["PlateNo"].ToString() == "" ? row["Model"].ToString() : row["PlateNo"].ToString()) : row["EquipmentNo"].ToString())
                    , row["Diagnosis"].ToString()
                    , row["Driver"].ToString()
                    , row["ProjectSite"].ToString()
                    , row["Remarks"].ToString()
                    , row["Category"].ToString()
                    , row["RepairStatus"].ToString()
                    , row["PurChaseStatus"].ToString()
                    );
            }
        }
        else
        {
        }
        */
        ////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////
    }
}
