using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentMonitoring.Repository
{
   
    public interface IMonitoringRepo
    {
        void ExecuteNonQ(string strSQL);
        /*
        void Add(ScannedModels scanned);
        void Add(List<ScannedModels> scanned);
        void Update(ScannedModels scanned);
        Task Delete(string strMICR);
        Task Delete(string[] strMICR);
        ErrCode ErrorCode { get; set; }
        string ErrorMessage { get; set; }

        Task<IEnumerable<ScannedModels>> GetAsync();
        Task<ScannedModels> GetByMicrUicAsync(string micr, string uic);
        */
    }
    /*
    public enum ErrCode
    {
        Success,
        Failed
    }

    public class MonitoringRepo : IMonitoringRepo
    {
        private string _strConn = "Data Source=Scanner.db;Version=3;New=False;Compress=True;";
        public ErrCode ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public string ErrMessage = "";
        ScannedRepository scanner = new ScannedRepository();

        public void ExecuteNonQ(string strSQL)
        {
            ErrorCode = ErrCode.Success;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(_strConn))
                {
                    SQLiteCommand cmd = new SQLiteCommand(strSQL, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Connection.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ErrorCode = ErrCode.Failed;
                ErrorMessage = ex.Message;
            }
        }

        private Task<DataTable> TableFromMSSQL(string strSQl)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(_strConn))
                {
                    SQLiteCommand cmd = new SQLiteCommand(strSQl, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;

                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
            }

            return Task.FromResult<DataTable>(dt);
        }


        public async Task<IEnumerable<ScannedModels>> GetAsync()
        {
            string strCommand = "select * from ImagesScanned";
            DataTable dt = await TableFromMSSQL(strCommand);

            return await TableToScannedModel(dt);
        }

        public async Task<ScannedModels> GetByMicrUicAsync(string micr, string uic)
        {
            string strCommand = $"select * from ImagesScanned where micr = '{micr}'";
            DataTable dt = await TableFromMSSQL(strCommand);
            IEnumerable<ScannedModels> lstScanned = await TableToScannedModel(dt);

            return lstScanned.FirstOrDefault(s => s.UIC == uic);
        }

        private Task<IEnumerable<ScannedModels>> TableToScannedModel(DataTable dt)
        {
            IEnumerable<ScannedModels> lstScanned = (from DataRow row in dt.Rows
                                                     select new ScannedModels()
                                                     {
                                                         MICRData = String.IsNullOrEmpty(row["MICRData"].ToString()) ? "" : row["MICRData"].ToString(),
                                                         UIC = String.IsNullOrEmpty(row["UIC"].ToString()) ? "" : row["UIC"].ToString(),
                                                         CheckNumber = String.IsNullOrEmpty(row["CheckNumber"].ToString()) ? "" : row["CheckNumber"].ToString(),
                                                         AccountNumber = String.IsNullOrEmpty(row["AccountNumber"].ToString()) ? "" : row["AccountNumber"].ToString(),
                                                         CheckDate = String.IsNullOrEmpty(row["CheckDate"].ToString()) ? "" : row["CheckDate"].ToString(),
                                                         Amount = String.IsNullOrEmpty(row["Amount"].ToString()) ? "" : row["Amount"].ToString(),
                                                         DepositAcct = String.IsNullOrEmpty(row["DepositAcct"].ToString()) ? "" : row["DepositAcct"].ToString(),
                                                         Presentation = String.IsNullOrEmpty(row["Presentation"].ToString()) ? "" : row["Presentation"].ToString(),
                                                         TranType = String.IsNullOrEmpty(row["TranType"].ToString()) ? "" : row["TranType"].ToString(),
                                                         ItemCode = String.IsNullOrEmpty(row["ItemCode"].ToString()) ? "" : row["ItemCode"].ToString(),
                                                         Crncy = String.IsNullOrEmpty(row["Crncy"].ToString()) ? "" : row["Crncy"].ToString(),
                                                         MICR = String.IsNullOrEmpty(row["MICR"].ToString()) ? "" : row["MICR"].ToString()
                                                     });

            return Task.FromResult<IEnumerable<ScannedModels>>(lstScanned);
        }



        public void Add(ScannedModels scanned)
        {
            ErrorCode = ErrCode.Success;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(_strConn))
                {
                    SQLiteCommand cmd = new SQLiteCommand(conn);
                    cmd.Connection.Open();

                    cmd.CommandText = "insert into ImagesScanned values (@MICR, @MICRData, @UIC, @CheckNumber, @AccountNumber, @CheckDate,@Payee, @CheckType," +
                        "@Amount, @Presentation, @TranType, @ItemCode, @Crncy, @IqaResult, @IqaData,@DepositAcct, @Casa, @BatchID, @ICLDate);";

                    cmd.Parameters.AddWithValue("@MICR", scanned.MICR);
                    cmd.Parameters.AddWithValue("@MICRData", scanned.MICRData);
                    cmd.Parameters.AddWithValue("@UIC", scanned.UIC);
                    cmd.Parameters.AddWithValue("@CheckNumber", scanned.CheckNumber);
                    cmd.Parameters.AddWithValue("@AccountNumber", scanned.AccountNumber);
                    cmd.Parameters.AddWithValue("@CheckDate", scanned.CheckDate);
                    cmd.Parameters.AddWithValue("@Payee", scanned.Payee);
                    cmd.Parameters.AddWithValue("@CheckType", scanned.CheckType);
                    cmd.Parameters.AddWithValue("@Amount", scanned.Amount);
                    cmd.Parameters.AddWithValue("@Presentation", scanned.Presentation);
                    cmd.Parameters.AddWithValue("@TranType", scanned.TranType);
                    cmd.Parameters.AddWithValue("@ItemCode", scanned.ItemCode);
                    cmd.Parameters.AddWithValue("@Crncy", scanned.Crncy);
                    cmd.Parameters.AddWithValue("@IqaResult", scanned.IqaResult);
                    cmd.Parameters.AddWithValue("@IqaData", scanned.IqaData);
                    cmd.Parameters.AddWithValue("@DepositAcct", scanned.DepositAcct);
                    cmd.Parameters.AddWithValue("@Casa", scanned.Casa);
                    cmd.Parameters.AddWithValue("@BatchID", scanned.BatchID);
                    cmd.Parameters.AddWithValue("@ICLDate", scanned.ICLDate);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ErrorCode = ErrCode.Failed;
                ErrorMessage = ex.Message;
            }
        }

        public async void Add(List<ScannedModels> scanned)
        {
            foreach (var item in scanned)
            {
                await Task.Run(() => Add(item));
            }
        }

        public async void Update(ScannedModels scanned)
        {
            string strCommand = "Update ImagesScanned set DepositAcct='" + scanned.DepositAcct
                                + "',CheckDate='" + scanned.CheckDate
                                + "', MICRData='" + scanned.MICRData
                                + "', Casa='" + scanned.Casa
                                + "', CheckNumber='" + scanned.CheckNumber
                                + "', AccountNumber='" + scanned.AccountNumber
                                + "', Payee='" + scanned.Payee
                                + "', CheckType='" + scanned.CheckType
                                + "', Amount=" + scanned.Amount
                                + " where MICR='" + scanned.MICR + "'";
            await Task.Run(() => ExecuteNonQ(strCommand));
        }

        public async Task Delete(string strMICR)
        {
            string strCommand = "Delete from ImagesScanned where MICR='" + strMICR + "'";
            await Task.Run(() => ExecuteNonQ(strCommand));
        }
        public async Task Delete(string[] strMICR)
        {
            foreach (var item in strMICR)
            {
                await Task.Run(() => Delete(item));
            }
        }
        }
    */
        #region helpers

        #endregion
    
}
