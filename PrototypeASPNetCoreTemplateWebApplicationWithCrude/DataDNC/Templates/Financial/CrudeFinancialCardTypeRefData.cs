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
    
    
    public partial class FinancialCardTypeRef {
        
        public const string AmericanExpress = "AmEx";
        
        public const string MasterCard = "Master";
        
        public const string Visa = "Visa";
    }
    
    //[Serializable()]
    public partial class CrudeFinancialCardTypeRefData {
        
        public string FinancialCardTypeRcd { get; set; } //;
        
        public string FinancialCardTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialCardTypeRcd(string financialCardTypeRcd) {
            string sql = @" select top 1 financial_card_type_rcd, financial_card_type_name, user_id, date_time
                            from [financial_card_type_ref]
                            where financial_card_type_rcd = @financial_card_type_rcd
                            order by financial_card_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = financialCardTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialCardTypeRefData GetByFinancialCardTypeRcd(string financialCardTypeRcd) {
            string sql = @" select top 1 financial_card_type_rcd, financial_card_type_name, user_id, date_time
                            from [financial_card_type_ref]
                            where financial_card_type_rcd = @financial_card_type_rcd
                            order by financial_card_type_name";

            var ret = new CrudeFinancialCardTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = financialCardTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialCardTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialCardTypeRefData>();

            string sql = @" select financial_card_type_rcd, financial_card_type_name, user_id, date_time
                            from [financial_card_type_ref]
                            where user_id = @user_id
                              
                            order by financial_card_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCardTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialCardTypeName(string financialCardTypeName) {
            string sql = @" select top 1 financial_card_type_rcd, financial_card_type_name, user_id, date_time
                            from [financial_card_type_ref]
                            where financial_card_type_name like '%' + @financialCardTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialCardTypeName",SqlDbType.NVarChar).Value = financialCardTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialCardTypeRefData> FetchAll() {
            var dataList = new List<CrudeFinancialCardTypeRefData>();

            string sql = @" select financial_card_type_rcd, financial_card_type_name, user_id, date_time
                            from [financial_card_type_ref]
                            order by financial_card_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCardTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCardTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialCardTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" financial_card_type_rcd, financial_card_type_name, user_id, date_time
                            from [financial_card_type_ref]
                            order by financial_card_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCardTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCardTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialCardTypeRefData>();

            string sql = @" select financial_card_type_rcd, financial_card_type_name, user_id, date_time
                            from [financial_card_type_ref]
                            order by financial_card_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialCardTypeRefData();
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
            string sql = @" select count(*) as count from [financial_card_type_ref]";

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
        
        public static List<CrudeFinancialCardTypeRefData> FetchWithFilter(string financialCardTypeRcd, string financialCardTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialCardTypeRefData>();

            string sql = @" select financial_card_type_rcd, financial_card_type_name, user_id, date_time
                            from [financial_card_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(financialCardTypeRcd)) {
                        sql += "  and financial_card_type_rcd like '%' + @financial_card_type_rcd + '%'";
                        command.Parameters.Add("@financial_card_type_rcd", SqlDbType.NVarChar).Value = financialCardTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialCardTypeName)) {
                        sql += "  and financial_card_type_name like '%' + @financial_card_type_name + '%'";
                        command.Parameters.Add("@financial_card_type_name", SqlDbType.NVarChar).Value = financialCardTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_card_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCardTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_card_type_rcd"] != System.DBNull.Value) FinancialCardTypeRcd = (System.String) reader["financial_card_type_rcd"];
            if (reader["financial_card_type_name"] != System.DBNull.Value) FinancialCardTypeName = (System.String) reader["financial_card_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [financial_card_type_ref] (financial_card_type_rcd, financial_card_type_name, user_id, date_time)";
            sql += "            values (@financial_card_type_rcd, @financial_card_type_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeRcd;
                    command.Parameters.Add("@financial_card_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [financial_card_type_ref] (financial_card_type_rcd, financial_card_type_name, user_id, date_time)";
            sql += "            values (@financial_card_type_rcd, @financial_card_type_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeRcd;
                command.Parameters.Add("@financial_card_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_card_type_ref] set
                 financial_card_type_rcd = @financial_card_type_rcd
                ,financial_card_type_name = @financial_card_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_card_type_rcd = @financial_card_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeRcd;
                    command.Parameters.Add("@financial_card_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_card_type_ref] set
                 financial_card_type_rcd = @financial_card_type_rcd
                ,financial_card_type_name = @financial_card_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_card_type_rcd = @financial_card_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeRcd;
                command.Parameters.Add("@financial_card_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCardTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string financialCardTypeRcd) {
            string sql = @" delete [financial_card_type_ref] 
                where financial_card_type_rcd = @financial_card_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_card_type_rcd",SqlDbType.NVarChar).Value = financialCardTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
