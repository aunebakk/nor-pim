/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:58 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeFinancialCostcentreData {
        
        public System.Guid FinancialCostcentreId { get; set; } //;
        
        public string FinancialCostcentreName { get; set; } //;
        
        public string FinancialCostcentreCode { get; set; } //;
        
        public System.Guid FinancialCompanyId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            string sql = @" select top 1 financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            where financial_costcentre_id = @financial_costcentre_id
                            order by financial_costcentre_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = financialCostcentreId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialCostcentreData GetByFinancialCostcentreId(System.Guid financialCostcentreId) {
            string sql = @" select top 1 financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            where financial_costcentre_id = @financial_costcentre_id
                            order by financial_costcentre_name";

            var ret = new CrudeFinancialCostcentreData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = financialCostcentreId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialCostcentreData> FetchByFinancialCompanyId(System.Guid financialCompanyId) {
            var dataList = new List<CrudeFinancialCostcentreData>();

            string sql = @" select financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            where financial_company_id = @financial_company_id
                              
                            order by financial_costcentre_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_company_id", SqlDbType.UniqueIdentifier).Value = financialCompanyId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCostcentreData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCostcentreData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialCostcentreData>();

            string sql = @" select financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            where user_id = @user_id
                              
                            order by financial_costcentre_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCostcentreData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialCostcentreName(string financialCostcentreName) {
            string sql = @" select top 1 financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            where financial_costcentre_name like '%' + @financialCostcentreName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialCostcentreName",SqlDbType.NVarChar).Value = financialCostcentreName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialCostcentreData> FetchAll() {
            var dataList = new List<CrudeFinancialCostcentreData>();

            string sql = @" select financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            order by financial_costcentre_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCostcentreData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCostcentreData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialCostcentreData>();

            string sql = @" select top " + limit.ToString() + @" financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            order by financial_costcentre_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCostcentreData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCostcentreData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialCostcentreData>();

            string sql = @" select financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            order by financial_costcentre_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialCostcentreData();
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
            string sql = @" select count(*) as count from [financial_costcentre]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
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
        
        public static List<CrudeFinancialCostcentreData> FetchWithFilter(System.Guid financialCostcentreId, string financialCostcentreName, string financialCostcentreCode, System.Guid financialCompanyId, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialCostcentreData>();

            string sql = @" select financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time
                            from [financial_costcentre]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (financialCostcentreId != Guid.Empty) {
                        sql += "  and financial_costcentre_id = @financial_costcentre_id";
                        command.Parameters.Add("@financial_costcentre_id", SqlDbType.UniqueIdentifier).Value = financialCostcentreId;
                    }
                    if (!string.IsNullOrEmpty(financialCostcentreName)) {
                        sql += "  and financial_costcentre_name like '%' + @financial_costcentre_name + '%'";
                        command.Parameters.Add("@financial_costcentre_name", SqlDbType.NVarChar).Value = financialCostcentreName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialCostcentreCode)) {
                        sql += "  and financial_costcentre_code like '%' + @financial_costcentre_code + '%'";
                        command.Parameters.Add("@financial_costcentre_code", SqlDbType.NVarChar).Value = financialCostcentreCode.Replace("'","''");
                    }
                    if (financialCompanyId != Guid.Empty) {
                        sql += "  and financial_company_id = @financial_company_id";
                        command.Parameters.Add("@financial_company_id", SqlDbType.UniqueIdentifier).Value = financialCompanyId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_costcentre_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCostcentreData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_costcentre_id"] != System.DBNull.Value) FinancialCostcentreId = (System.Guid) reader["financial_costcentre_id"];
            if (reader["financial_costcentre_name"] != System.DBNull.Value) FinancialCostcentreName = (System.String) reader["financial_costcentre_name"];
            if (reader["financial_costcentre_code"] != System.DBNull.Value) FinancialCostcentreCode = (System.String) reader["financial_costcentre_code"];
            if (reader["financial_company_id"] != System.DBNull.Value) FinancialCompanyId = (System.Guid) reader["financial_company_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (FinancialCostcentreId == Guid.Empty)
                FinancialCostcentreId = Guid.NewGuid();

            string sql = "insert into [financial_costcentre] (financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time)";
            sql += "            values (@financial_costcentre_id, @financial_costcentre_name, @financial_costcentre_code, @financial_company_id, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCostcentreId;
                    command.Parameters.Add("@financial_costcentre_name",SqlDbType.NVarChar).Value = (System.String)FinancialCostcentreName;
                    command.Parameters.Add("@financial_costcentre_code",SqlDbType.NVarChar).Value = (System.String)FinancialCostcentreCode;
                    command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCompanyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FinancialCostcentreId == Guid.Empty)
                FinancialCostcentreId = Guid.NewGuid();

            string sql = "insert into [financial_costcentre] (financial_costcentre_id, financial_costcentre_name, financial_costcentre_code, financial_company_id, user_id, date_time)";
            sql += "            values (@financial_costcentre_id, @financial_costcentre_name, @financial_costcentre_code, @financial_company_id, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCostcentreId;
                command.Parameters.Add("@financial_costcentre_name",SqlDbType.NVarChar).Value = (System.String)FinancialCostcentreName;
                command.Parameters.Add("@financial_costcentre_code",SqlDbType.NVarChar).Value = (System.String)FinancialCostcentreCode;
                command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCompanyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_costcentre] set
                 financial_costcentre_id = @financial_costcentre_id
                ,financial_costcentre_name = @financial_costcentre_name
                ,financial_costcentre_code = @financial_costcentre_code
                ,financial_company_id = @financial_company_id
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_costcentre_id = @financial_costcentre_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCostcentreId;
                    command.Parameters.Add("@financial_costcentre_name",SqlDbType.NVarChar).Value = (System.String)FinancialCostcentreName;
                    command.Parameters.Add("@financial_costcentre_code",SqlDbType.NVarChar).Value = (System.String)FinancialCostcentreCode;
                    command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCompanyId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_costcentre] set
                 financial_costcentre_id = @financial_costcentre_id
                ,financial_costcentre_name = @financial_costcentre_name
                ,financial_costcentre_code = @financial_costcentre_code
                ,financial_company_id = @financial_company_id
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_costcentre_id = @financial_costcentre_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCostcentreId;
                command.Parameters.Add("@financial_costcentre_name",SqlDbType.NVarChar).Value = (System.String)FinancialCostcentreName;
                command.Parameters.Add("@financial_costcentre_code",SqlDbType.NVarChar).Value = (System.String)FinancialCostcentreCode;
                command.Parameters.Add("@financial_company_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialCompanyId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid financialCostcentreId) {
            string sql = @" delete [financial_costcentre] 
                where financial_costcentre_id = @financial_costcentre_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_costcentre_id",SqlDbType.UniqueIdentifier).Value = financialCostcentreId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
