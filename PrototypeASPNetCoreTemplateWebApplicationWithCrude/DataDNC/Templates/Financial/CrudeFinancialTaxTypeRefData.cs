/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:44:08 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class FinancialTaxTypeRef {
        
        public const string OrderTax = "Order";
        
        public const string PaymentTax = "Payment";
    }
    
    //[Serializable()]
    public partial class CrudeFinancialTaxTypeRefData {
        
        public string FinancialTaxTypeName { get; set; } //;
        
        public string FinancialTaxTypeRcd { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            string sql = @" select top 1 financial_tax_type_name, financial_tax_type_rcd, user_id, date_time
                            from [financial_tax_type_ref]
                            where financial_tax_type_rcd = @financial_tax_type_rcd
                            order by financial_tax_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = financialTaxTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialTaxTypeRefData GetByFinancialTaxTypeRcd(string financialTaxTypeRcd) {
            string sql = @" select top 1 financial_tax_type_name, financial_tax_type_rcd, user_id, date_time
                            from [financial_tax_type_ref]
                            where financial_tax_type_rcd = @financial_tax_type_rcd
                            order by financial_tax_type_name";

            var ret = new CrudeFinancialTaxTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = financialTaxTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialTaxTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialTaxTypeRefData>();

            string sql = @" select financial_tax_type_name, financial_tax_type_rcd, user_id, date_time
                            from [financial_tax_type_ref]
                            where user_id = @user_id
                              
                            order by financial_tax_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialTaxTypeName(string financialTaxTypeName) {
            string sql = @" select top 1 financial_tax_type_name, financial_tax_type_rcd, user_id, date_time
                            from [financial_tax_type_ref]
                            where financial_tax_type_name like '%' + @financialTaxTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialTaxTypeName",SqlDbType.NVarChar).Value = financialTaxTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialTaxTypeRefData> FetchAll() {
            var dataList = new List<CrudeFinancialTaxTypeRefData>();

            string sql = @" select financial_tax_type_name, financial_tax_type_rcd, user_id, date_time
                            from [financial_tax_type_ref]
                            order by financial_tax_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialTaxTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialTaxTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" financial_tax_type_name, financial_tax_type_rcd, user_id, date_time
                            from [financial_tax_type_ref]
                            order by financial_tax_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialTaxTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialTaxTypeRefData>();

            string sql = @" select financial_tax_type_name, financial_tax_type_rcd, user_id, date_time
                            from [financial_tax_type_ref]
                            order by financial_tax_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialTaxTypeRefData();
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
            string sql = @" select count(*) as count from [financial_tax_type_ref]";

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
        
        public static List<CrudeFinancialTaxTypeRefData> FetchWithFilter(string financialTaxTypeName, string financialTaxTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialTaxTypeRefData>();

            string sql = @" select financial_tax_type_name, financial_tax_type_rcd, user_id, date_time
                            from [financial_tax_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(financialTaxTypeName)) {
                        sql += "  and financial_tax_type_name like '%' + @financial_tax_type_name + '%'";
                        command.Parameters.Add("@financial_tax_type_name", SqlDbType.NVarChar).Value = financialTaxTypeName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialTaxTypeRcd)) {
                        sql += "  and financial_tax_type_rcd like '%' + @financial_tax_type_rcd + '%'";
                        command.Parameters.Add("@financial_tax_type_rcd", SqlDbType.NVarChar).Value = financialTaxTypeRcd.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_tax_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialTaxTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_tax_type_name"] != System.DBNull.Value) FinancialTaxTypeName = (System.String) reader["financial_tax_type_name"];
            if (reader["financial_tax_type_rcd"] != System.DBNull.Value) FinancialTaxTypeRcd = (System.String) reader["financial_tax_type_rcd"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [financial_tax_type_ref] (financial_tax_type_name, financial_tax_type_rcd, user_id, date_time)";
            sql += "            values (@financial_tax_type_name, @financial_tax_type_rcd, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_tax_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeName;
                    command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [financial_tax_type_ref] (financial_tax_type_name, financial_tax_type_rcd, user_id, date_time)";
            sql += "            values (@financial_tax_type_name, @financial_tax_type_rcd, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_tax_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeName;
                command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_tax_type_ref] set
                 financial_tax_type_name = @financial_tax_type_name
                ,financial_tax_type_rcd = @financial_tax_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_tax_type_rcd = @financial_tax_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_tax_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeName;
                    command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeRcd;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_tax_type_ref] set
                 financial_tax_type_name = @financial_tax_type_name
                ,financial_tax_type_rcd = @financial_tax_type_rcd
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_tax_type_rcd = @financial_tax_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_tax_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeName;
                command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialTaxTypeRcd;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string financialTaxTypeRcd) {
            string sql = @" delete [financial_tax_type_ref] 
                where financial_tax_type_rcd = @financial_tax_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_tax_type_rcd",SqlDbType.NVarChar).Value = financialTaxTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
