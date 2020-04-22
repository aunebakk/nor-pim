/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:31:42 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeFinancialCompanyData {
        
        public System.Guid FinancialCompanyId { get; set; } //;
        
        public string FinancialCompanyName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialCompanyId(System.Guid financialCompanyId) {
            string sql = @" select top 1 financial_company_id, financial_company_name, user_id, date_time
                            from [financial_company]
                            where financial_company_id = @financial_company_id
                            order by financial_company_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = financialCompanyId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialCompanyData GetByFinancialCompanyId(System.Guid financialCompanyId) {
            string sql = @" select top 1 financial_company_id, financial_company_name, user_id, date_time
                            from [financial_company]
                            where financial_company_id = @financial_company_id
                            order by financial_company_name";

            var ret = new CrudeFinancialCompanyData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = financialCompanyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialCompanyData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialCompanyData>();

            string sql = @" select financial_company_id, financial_company_name, user_id, date_time
                            from [financial_company]
                            where user_id = @user_id
                              
                            order by financial_company_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCompanyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialCompanyName(string financialCompanyName) {
            string sql = @" select top 1 financial_company_id, financial_company_name, user_id, date_time
                            from [financial_company]
                            where financial_company_name like '%' + @financialCompanyName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialCompanyName",SqlDbType.NVarChar).Value = financialCompanyName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialCompanyData> FetchAll() {
            var dataList = new List<CrudeFinancialCompanyData>();

            string sql = @" select financial_company_id, financial_company_name, user_id, date_time
                            from [financial_company]
                            order by financial_company_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCompanyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCompanyData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialCompanyData>();

            string sql = @" select top " + limit.ToString() + @" financial_company_id, financial_company_name, user_id, date_time
                            from [financial_company]
                            order by financial_company_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCompanyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCompanyData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialCompanyData>();

            string sql = @" select financial_company_id, financial_company_name, user_id, date_time
                            from [financial_company]
                            order by financial_company_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialCompanyData();
                            data.Populate(reader);
                            dataList.Add(data);
                        }
                        count++;
                        if (count > limit + offset) break;
                    }
                }
                
                return dataList;
            }
        }
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [financial_company]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        public static List<CrudeFinancialCompanyData> FetchWithFilter(System.Guid financialCompanyId, string financialCompanyName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialCompanyData>();

            string sql = @" select financial_company_id, financial_company_name, user_id, date_time
                            from [financial_company]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialCompanyId != Guid.Empty) {
                        sql += "  and financial_company_id = @financial_company_id";
                        command.Parameters.Add("@financial_company_id", SqlDbType.UniqueIdentifier).Value = financialCompanyId;
                    }
                    if (!string.IsNullOrEmpty(financialCompanyName)) {
                        sql += "  and financial_company_name like '%' + @financial_company_name + '%'";
                        command.Parameters.Add("@financial_company_name", SqlDbType.NVarChar).Value = financialCompanyName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_company_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCompanyData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_company_id"] != System.DBNull.Value) FinancialCompanyId = (System.Guid) reader["financial_company_id"];
            if (reader["financial_company_name"] != System.DBNull.Value) FinancialCompanyName = (System.String) reader["financial_company_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (FinancialCompanyId == Guid.Empty)
                FinancialCompanyId = Guid.NewGuid();

            string sql = "insert into [financial_company] (financial_company_id, financial_company_name, user_id, date_time)";
            sql += "            values (@financial_company_id, @financial_company_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCompanyId;
                    command.Parameters.Add("@financial_company_name",SqlDbType.NVarChar).Value = (System.String)FinancialCompanyName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialCompanyId == Guid.Empty)
                FinancialCompanyId = Guid.NewGuid();

            string sql = "insert into [financial_company] (financial_company_id, financial_company_name, user_id, date_time)";
            sql += "            values (@financial_company_id, @financial_company_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCompanyId;
                command.Parameters.Add("@financial_company_name",SqlDbType.NVarChar).Value = (System.String)FinancialCompanyName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_company] set
                 financial_company_id = @financial_company_id
                ,financial_company_name = @financial_company_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_company_id = @financial_company_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCompanyId;
                    command.Parameters.Add("@financial_company_name",SqlDbType.NVarChar).Value = (System.String)FinancialCompanyName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_company] set
                 financial_company_id = @financial_company_id
                ,financial_company_name = @financial_company_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_company_id = @financial_company_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCompanyId;
                command.Parameters.Add("@financial_company_name",SqlDbType.NVarChar).Value = (System.String)FinancialCompanyName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialCompanyId) {
            string sql = @" delete [financial_company] 
                where financial_company_id = @financial_company_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = financialCompanyId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
