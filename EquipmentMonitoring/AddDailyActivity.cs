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
    public partial class AddDailyActivity : Form
    {
        MonitoringRepository monitoring = new MonitoringRepository();
        string Connection = ConfigurationManager.ConnectionStrings["Maintenancedb"].ToString();
        DataTable dt = new DataTable();
        DataTable unit = new DataTable();

        ArrayList EquipArray = new ArrayList();
        ArrayList ModelArray = new ArrayList();
        ArrayList PlatenoArray = new ArrayList();
        ArrayList DriverArray = new ArrayList();
        ArrayList PumpArray = new ArrayList();

        DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

        public AddDailyActivity()
        {
            InitializeComponent();
            Param();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }



        public void Param()
        {
            //  dgvMaintenanceList.DefaultCellStyle.SelectionForeColor = Color.DarkRed;

            // Set the selection background color for all the cells.

            dgvMaintenanceList.DataSource = null;
            if (this.dgvMaintenanceList.DataSource != null)
            {
                this.dgvMaintenanceList.DataSource = null;
            }
            else
            {
                this.dgvMaintenanceList.Rows.Clear();
            }

            /*
            foreach (DataRow row in data.Rows)
            {
                dgvDailySheet.Rows.Add(row["Date"].ToString().Replace(" 12:00:00 AM", "")
                        , row["EquipmentNo"].ToString()
                        , row["Model"].ToString()
                        , row["PlateNumber"].ToString()
                        , row["totalKmhr"].ToString()
                        );
            }
            */

            SqlDataReader reader;
        

            string spName = "sp_Get_MaintenanceList";
            string param = "'" + "'";

            reader = monitoring.ExecuteReader(spName, param);
            DataTable Detail = new DataTable();
            Detail.Load(reader);


            foreach (DataRow row in Detail.Rows)
            {
                dgvMaintenanceList.Rows.Add(row["Date"].ToString()//.Replace(" 12:00:00 AM", "")
                            , row["EquipmentNo"].ToString()
                            , row["Model"].ToString()
                            , row["PlateNo"].ToString()
                            , row["Kms_Used"].ToString()
                            , row["Hrs_Used"].ToString()
                        );
            }

            /*
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_TankList.TankName from m_TankList with (nolock)", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDailySheet. = dt;

                cmbfuel.DisplayMember = "FuelType";
                cmbfuel.ValueMember = "FuelType";
            }
            */
            /*
             SqlDataReader fueltypereader;


             string spName = "sp_Get_FuelType";
             string param = "'" + "'";

             fueltypereader = monitoring.ExecuteReader(spName, param);
             DataTable Fueltable = new DataTable();
             Detail.Load(reader);
            */

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Please Click Yes To Continue SAVE", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string result = "";
                SqlDataReader reader;
                string Date = "'" + "'";
                string Equipmentno = "'" + "'";
                string Model = "'" + "'";
                string PlateNo = "'" + "'";
                string DriversName = "'" + "'";
                string noltrsrefilled = "'0" + "'";
                string kmhrStart = "'0" + "'";
                string kmhrStop = "'0" + "'";
                string kms = "'0" + "'";
                string Hrs = "'0" + "'";
                string ProjectSite = "'" + "'";
                string PumpIncharge = "'" + "'";
                string others = "'" + "'";
                string Source = "'" + "'";
                string Operation = "'" + "'";
                string spName = "sp_Add_DailySheet";
                string test = "'" + "'";
                string isTanker = "'" + "'";
                int ok;

                int count = 0;
                int numRows = dgvDailySheet.Rows.Count;
                int loop = numRows - 1;

                for (int i = 0; i < loop; i++)
                {

                    if (Convert.ToBoolean(dgvDailySheet.Rows[i].Cells["tank"].Value) == true)
                    {
                        isTanker = "1";
                    }
                    else
                    {
                        isTanker = "0";
                    }

                    if (Convert.ToBoolean(dgvDailySheet.Rows[i].Cells["Others"].Value) == true)
                    {
                        others = "1";
                    }
                    else
                    {
                        others = "0";
                    }


                    //  string DriversName = (row.Cells[1].Value.ToString()) == string.Empty ? "" : row.Cells["DriversName"].Value.ToString();
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[1].FormattedValue) != string.Empty)
                    {
                        Date = "'" + (dgvDailySheet.Rows[i].Cells[1].FormattedValue.ToString()) + "'";
                    }
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[2].FormattedValue) != string.Empty)
                    {
                        Equipmentno = "'" + dgvDailySheet.Rows[i].Cells[2].FormattedValue.ToString() + "'";
                    }


                    //if (Convert.ToString(row.Cells[3].FormattedValue) != string.Empty)
                    //{
                    //    Model = "'" + row.Cells[3].FormattedValue.ToString() + "'";
                    //}
                    //if (Convert.ToString(row.Cells[4].FormattedValue) != string.Empty)
                    //{
                    //    PlateNo = "'" + row.Cells[4].FormattedValue.ToString() + "'";
                    //}

                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[3].FormattedValue) != string.Empty)
                    {
                        DriversName = "'" + dgvDailySheet.Rows[i].Cells[3].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[4].FormattedValue) != string.Empty)
                    {
                        noltrsrefilled = "'" + dgvDailySheet.Rows[i].Cells[4].FormattedValue.ToString() + "'";
                    }
                    /*
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[5].FormattedValue) != string.Empty)
                    {
                        kmhrStart = "'" + dgvDailySheet.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[6].FormattedValue) != string.Empty)
                    {
                        kmhrStop = "'" + dgvDailySheet.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                    }
                    */
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[5].FormattedValue) != string.Empty)
                    {
                        kms = "'" + dgvDailySheet.Rows[i].Cells[5].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[6].FormattedValue) != string.Empty)
                    {
                        Hrs = "'" + dgvDailySheet.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[7].FormattedValue) != string.Empty)
                    {
                        ProjectSite = "'" + dgvDailySheet.Rows[i].Cells[7].FormattedValue.ToString() + "'";
                    }
                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[8].FormattedValue) != string.Empty)
                    {
                        PumpIncharge = "'" + dgvDailySheet.Rows[i].Cells[8].FormattedValue.ToString() + "'";
                    }

                    //if (Convert.ToString(row.Cells[11].FormattedValue) != string.Empty)
                    //{
                    //    others = "'" + row.Cells[11].FormattedValue.ToString() + "'";
                    //}

                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[10].FormattedValue) != string.Empty)
                    {
                        Operation = "'" + dgvDailySheet.Rows[i].Cells[10].FormattedValue.ToString() + "'";
                    }

                    if (Convert.ToString(dgvDailySheet.Rows[i].Cells[11].FormattedValue) != string.Empty)
                    {
                        Source = "'" + dgvDailySheet.Rows[i].Cells[11].FormattedValue.ToString() + "'";
                    }

                    //reader = monitoring.ExecuteReader(spName, isTanker, Date, Equipmentno, DriversName, noltrsrefilled, kmhrStart, kmhrStop, kms, Hrs, ProjectSite, PumpIncharge, others, Operation, Source);
                    reader = monitoring.ExecuteReader(spName, isTanker, Date, Equipmentno, DriversName, noltrsrefilled, kms, Hrs, ProjectSite, PumpIncharge, others, Operation, Source);
                    DataTable Detail = new DataTable();
                    Detail.Load(reader);
                    result = Detail.Rows[0]["Result"].ToString();

                    if (result == "1")
                    {
                        dgvDailySheet.Rows.Remove(dgvDailySheet.Rows[i]);
                        i = i - 1;
                        loop = loop - 1;
                    }
                    else
                    {
                        dgvDailySheet.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Red };
                        //dgvDailySheet.RowsDefaultCellStyle.ForeColor = Color.Red;
                    }

                    // ok = 0;
                }


                /*
                int count = 0;
                int numRows = dgvDailySheet.Rows.Count;
                int loop = numRows - 1;
                //    dgvRefill.ColumnHeadersVisible = false;
                dgvDailySheet.SelectAll();
                dgvDailySheet.SelectAll();
                //   dgvRefill.ColumnHeadersVisible = true;
                //int numRowCount = dgvRefill.RowCount;
                //     var lastRow = dt.Rows[dt.Rows.Count - 1];
                //     var newFirstRow = dgvRefill.NewRow();
                //     newFirstRow.ItemArray = lastRow.ItemArray;
                // dgvRefill.Rows.Remove(dgvRefill.Rows);

                // foreach (DataGridViewRow row in dgvDailySheet.SelectedRows)
                foreach (DataGridViewRow row in dgvDailySheet.SelectedRows)
                {
                    if (count <= loop)
                    {
                        if (count != 0)
                        {
                            string result = "";
                            SqlDataReader reader;
                           // string Blank = row.Cells[0].Value.ToString();
                            string Date = "'" + "'";
                            string Equipmentno = "'" + "'";
                            string Model = "'" + "'";
                            string PlateNo = "'" + "'";
                            string DriversName = "'" + "'";
                            string noltrsrefilled = "'0" + "'";
                            string kmhrStart = "'0" + "'";
                            string kmhrStop = "'0" + "'";
                            string kms = "'0" + "'";
                            string Hrs = "'0" + "'";
                            string ProjectSite = "'" + "'";
                            string PumpIncharge = "'" + "'";
                            string others = "'" + "'";
                            string Source = "'" + "'"; 
                            string Operation = "'" + "'";
                            string spName = "sp_Add_DailySheet";
                            string test = "'" + "'";

                            test = row.Cells[13].FormattedValue.ToString();

                            string isTanker;
                            
                            if (Convert.ToBoolean(row.Cells["tank"].Value) == true)
                            {
                                isTanker = "1";
                            }
                            else
                            {
                                isTanker = "0";
                            }

                            if (Convert.ToBoolean(row.Cells["Others"].Value) == true)
                            {
                                others = "1";
                            }
                            else
                            {
                                others = "0";
                            }


                            //  string DriversName = (row.Cells[1].Value.ToString()) == string.Empty ? "" : row.Cells["DriversName"].Value.ToString();
                            if (Convert.ToString(row.Cells[1].FormattedValue) != string.Empty)
                            {
                                Date = "'" + (row.Cells[1].FormattedValue.ToString()) + "'";
                            }
                            if (Convert.ToString(row.Cells[2].FormattedValue) != string.Empty)
                            {
                                Equipmentno = "'" + row.Cells[2].FormattedValue.ToString() + "'";
                            }

                           
                            //if (Convert.ToString(row.Cells[3].FormattedValue) != string.Empty)
                            //{
                            //    Model = "'" + row.Cells[3].FormattedValue.ToString() + "'";
                            //}
                            //if (Convert.ToString(row.Cells[4].FormattedValue) != string.Empty)
                            //{
                            //    PlateNo = "'" + row.Cells[4].FormattedValue.ToString() + "'";
                            //}
                          
                            if (Convert.ToString(row.Cells[3].FormattedValue) != string.Empty)
                            {
                                DriversName = "'" + row.Cells[3].FormattedValue.ToString() + "'";
                            }
                            if (Convert.ToString(row.Cells[4].FormattedValue) != string.Empty)
                            {
                                noltrsrefilled = "'" + row.Cells[4].FormattedValue.ToString() + "'";
                            }
                            if (Convert.ToString(row.Cells[5].FormattedValue) != string.Empty)
                            {
                                kmhrStart = "'" + row.Cells[5].FormattedValue.ToString() + "'";
                            }
                            if (Convert.ToString(row.Cells[6].FormattedValue) != string.Empty)
                            {
                                kmhrStop = "'" + row.Cells[6].FormattedValue.ToString() + "'";
                            }
                            if (Convert.ToString(row.Cells[7].FormattedValue) != string.Empty)
                            {
                                kms = "'" + row.Cells[7].FormattedValue.ToString() + "'";
                            }
                            if (Convert.ToString(row.Cells[8].FormattedValue) != string.Empty)
                            {
                                Hrs = "'" + row.Cells[8].FormattedValue.ToString() + "'";
                            }
                            if (Convert.ToString(row.Cells[9].FormattedValue) != string.Empty)
                            {
                                ProjectSite = "'" + row.Cells[9].FormattedValue.ToString() + "'";
                            }
                            if (Convert.ToString(row.Cells[10].FormattedValue) != string.Empty)
                            {
                                PumpIncharge = "'" + row.Cells[10].FormattedValue.ToString() + "'";
                            }
                            
                            //if (Convert.ToString(row.Cells[11].FormattedValue) != string.Empty)
                            //{
                            //    others = "'" + row.Cells[11].FormattedValue.ToString() + "'";
                            //}
                            

                            if (Convert.ToString(row.Cells[12].FormattedValue) != string.Empty)
                            {
                                Operation = "'" + row.Cells[12].FormattedValue.ToString() + "'";
                            }

                            if (Convert.ToString(row.Cells[14].FormattedValue) != string.Empty)
                            {
                                Source = "'" + row.Cells[14].FormattedValue.ToString() + "'";
                            }


                            // reader = monitoring.ExecuteReader(spName, isTanker, Date, Equipmentno, Model, PlateNo, DriversName, noltrsrefilled, kmhrStart, kmhrStop, kms, Hrs, ProjectSite, PumpIncharge, others, Source);
                            reader = monitoring.ExecuteReader(spName, isTanker, Date, Equipmentno, DriversName, noltrsrefilled, kmhrStart, kmhrStop, kms, Hrs, ProjectSite, PumpIncharge, others, Operation, Source);
                            DataTable Detail = new DataTable();
                            Detail.Load(reader);
                            result = Detail.Rows[0]["Result"].ToString();

                            if (result == "1")
                            {
                                dgvDailySheet.Rows.Remove(row);
                            }
                            else
                            {
                                dgvDailySheet.RowsDefaultCellStyle.ForeColor = Color.Red;
                            }
                          
                        }
                        count++;
                    }
                }

                dgvDailySheet.ClearSelection();
                Param();
            */
            }
            else
            {

            }
        }

        private void dgvDailySheet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.ColumnIndex == 1)
            {
                try
                {
                    dgvDailySheet.Rows[e.RowIndex].Cells[13].Value = dgvDailySheet.Rows[e.RowIndex].Cells[1].Value;
                }
                catch { }
            }
            */
        }
                /*
                string value = "";
                string value1 = "";

                if (e.ColumnIndex == 7)
                {
                    try
                    {
                        value = String.Format("{0:0,0.00}", Convert.ToDecimal(dgvDailySheet.Rows[e.RowIndex].Cells[7].Value));
                        dgvDailySheet.Rows[e.RowIndex].Cells[7].Value = value;
                        value1 = value;
                    }
                    catch { }
                }
                else if (e.ColumnIndex == 8)
                {

                    try
                    {
                        value = String.Format("{0:0,0.00}", Convert.ToDecimal(dgvDailySheet.Rows[e.RowIndex].Cells[7].Value));
                        dgvDailySheet.Rows[e.RowIndex].Cells[7].Value = value;
                        value1 = value;
                    }
                    catch { }
                }
                else if (e.ColumnIndex == 9)
                {
                    try
                    {
                        value = String.Format("{0:0,0.00}", Convert.ToDecimal(dgvDailySheet.Rows[e.RowIndex].Cells[7].Value));
                        dgvDailySheet.Rows[e.RowIndex].Cells[7].Value = value;
                        value1 = value;
                    }
                    catch { }
                }
                else if (e.ColumnIndex == 10)
                {
                    try
                    {
                        value = String.Format("{0:0,0.00}", Convert.ToDecimal(dgvDailySheet.Rows[e.RowIndex].Cells[7].Value));
                        dgvDailySheet.Rows[e.RowIndex].Cells[7].Value = value;
                        value1 = value;
                    }
                    catch { }
                }
                */

        private void btnView_Click(object sender, EventArgs e)
        {
            EnterNumber enter = new EnterNumber();
            enter.ShowDialog();
        }

        private void dgvDailySheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddDailyActivity_Load(object sender, EventArgs e)
        {
            //DataGridViewComboBoxCell combo = dgvDailySheet.Rows[0].Cells["Source"]);
            //DataGridViewComboBoxCell combo = 
            //   (DataGridViewComboBoxCell) (dgvDailySheet.Rows[0].Cells[13]);//.Rows[0].Cells["Source"]);
        
         using (SqlConnection Con = new SqlConnection(Connection))
         {
            SqlDataAdapter da = new SqlDataAdapter("Select m_TankList.TankName from m_TankList with (nolock)  order by id asc", Con);

            da.Fill(dt);

            combo.HeaderText = "SOURCE OF FUEL";
            combo.Name = "Source";
           

          ///  combo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            ArrayList row = new ArrayList();

            foreach (DataRow dr in dt.Rows)
            {
                row.Add(dr["TankName"].ToString());
            }


            combo.Items.AddRange(row.ToArray());
           
             //dgvDailySheet.Columns.Add(combo);
              //   dgvDailySheet.Columns[13].DataGridView.DataSource = dt;
               // dgvDailySheet.Columns[13].
                //  dgvDailySheet.Columns[12].DataGridView.DataSource = dt;

                //((DataGridViewComboBoxColumn)dgvDailySheet.Columns["Source"]).DataSource = dt;
                //dgvDailySheet.Columns.

                  dgvDailySheet.Columns.Add(combo);
                  dgvDailySheet.Columns[11].Width = 150;

                //dgvDailySheet.Rows[0].Cells[13].Value = combo.Items[0];
                //////////////////////////////////////////////

                //dgvDailySheet.Rows[e.RowIndex].Cells[13].Value = combo.Items[0];
                //addcombo();

                //cmbfuel.DisplayMember = "FuelType";
                //cmbfuel.ValueMember = "FuelType";
            }


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

            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_Drivelist with (nolock)", Con);

                da.Fill(unit);
                
                foreach (DataRow dr in unit.Rows)
                {
                    DriverArray.Add(dr["Name"].ToString());
                }
            }

            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from m_PumpAttendant with (nolock)", Con);

                da.Fill(unit);

                foreach (DataRow dr in unit.Rows)
                {
                    PumpArray.Add(dr["Name"].ToString());
                }
            }
        }
        public void addcombo()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "SOURCE OF FUEL";
            combo.Name = "Source";

            ArrayList row = new ArrayList();

            foreach(DataRow dr in dt.Rows)
            {
                row.Add(dr["TankName"].ToString());
            }


            combo.Items.AddRange(row.ToArray());
            combo.DropDownWidth = 500;
            // dgvDailySheet.Columns[4].Width = 75;
            dgvDailySheet.Columns.Add(combo);

        }

        private void dgvDailySheet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            /*
            ComboBox ocmb = e.Control as ComboBox;
            if (ocmb != null)
            {
                ocmb.SelectedIndex = 0;
            }
            */
            TextBox auto = e.Control as TextBox;

            if (dgvDailySheet.CurrentCell.ColumnIndex == 2)
            {
                try
                {
                    if (auto != null)
                    {
                        auto.AutoCompleteCustomSource.Clear();
                        auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                        auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        Equip(data);
                        auto.AutoCompleteCustomSource = data;
                    }
                }
                catch { }
            } 
            else if (dgvDailySheet.CurrentCell.ColumnIndex == 3)
            {
                try
                { 
                auto.AutoCompleteCustomSource.Clear();
                auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                FillDriver(data);
                auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            else if (dgvDailySheet.CurrentCell.ColumnIndex == 10)
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    FillPump(data);
                    auto.AutoCompleteCustomSource = data;
                }
                catch { }
            }
            else if (dgvDailySheet.CurrentCell.ColumnIndex == 13)
            {
            }
            else
            {
                try
                {
                    auto.AutoCompleteCustomSource.Clear();
                }
                catch { }
            }

                /*
                //AutoCompleteMode.None;
                string header = dgvDailySheet.Columns[2].HeaderText;

            if(header.Equals("EquipNo/Model/PlateNo"))
            {
                TextBox auto = e.Control as TextBox;

                if(auto != null)
                {
                    auto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                    fillitems(data);
                    auto.AutoCompleteCustomSource = data;

                }
            }
            */
        }

        private void Equip(AutoCompleteStringCollection data)
        {
            /*
            var autoComplete = new AutoCompleteStringCollection();
            foreach (var item in EquipArray) autoComplete.Add(item);
            */
            foreach (var item in EquipArray)
                data.AddRange(new string[] { item.ToString() });
        }

        private void FillDriver(AutoCompleteStringCollection data)
        {
            /*
            var autoComplete = new AutoCompleteStringCollection();
            foreach (var item in EquipArray) autoComplete.Add(item);
            */
            foreach (var item in DriverArray)
                data.AddRange(new string[] { item.ToString() });
        }

        private void FillPump(AutoCompleteStringCollection data)
        {
            /*
            var autoComplete = new AutoCompleteStringCollection();
            foreach (var item in EquipArray) autoComplete.Add(item);
            */
            foreach (var item in PumpArray)
                data.AddRange(new string[] { item.ToString() });
        }

        private void dgvDailySheet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
            try
            {

                if (e.ColumnIndex == 13) // your combo column index
                {
                    try
                    {
                        if (dgvDailySheet.Rows[e.RowIndex].Cells[13].Value.ToString() != "" | dgvDailySheet.Rows[e.RowIndex].Cells[13].Value.ToString() != null)
                        {
                            dgvDailySheet.Rows[e.RowIndex].Cells[13].Value = dgvDailySheet.Rows[e.RowIndex].Cells[13].Value.ToString();
                        }
                        else
                        {
                            dgvDailySheet.Rows[e.RowIndex].Cells[13].Value = combo.Items[0];
                        }
                        // dgvScanned.Rows[e.RowIndex].

                    }
                    catch
                    {
                        dgvDailySheet.Rows[e.RowIndex].Cells[13].Value = combo.Items[0];
                    }
                }
                
            }
            catch {
                if (e.ColumnIndex == 13) // your combo column index
                {
                    dgvDailySheet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = combo.Items[0];
                }
            }
            */
        }

        private void dgvDailySheet_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            /*
            // dgvDailySheet.Rows[e.RowIndex].Cells[13].Value = combo.Items[0];
            using (SqlConnection Con = new SqlConnection(Connection))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m_TankList.TankName from m_TankList with (nolock)  order by id asc", Con);

                da.Fill(dt);

                combo.HeaderText = "SOURCE OF FUEL";
                combo.Name = "Source";


                ///  combo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

                ArrayList row = new ArrayList();

                foreach (DataRow dr in dt.Rows)
                {
                    row.Add(dr["TankName"].ToString());
                }

                combo.Items.AddRange(row.ToArray());
                }
                */


            //((DataGridViewComboBoxColumn)dgvDailySheet.Columns["Source"]).DataSource = dt;
            //dgvDailySheet.Columns.

            //  dgvDailySheet.Columns.Add(13,combo);
            //  dgvDailySheet.Columns[13].Width = 150;

            //dgvDailySheet.Rows[0].Cells[13].Value = combo.Items[0];
            //////////////////////////////////////////////

            //dgvDailySheet.Rows[e.RowIndex].Cells[13].Value = combo.Items[0];
            //addcombo();

            //cmbfuel.DisplayMember = "FuelType";
            //cmbfuel.ValueMember = "FuelType";

        }

        private void dgvDailySheet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            /*
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dgvDailySheet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dgvDailySheet.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dgvDailySheet.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
            */
        }
    }
}
