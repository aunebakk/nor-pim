/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class FinancialCouponTypeRef {
        
        public const string LoungeCoupon = "LC";
        
        public const string MealCoupon = "MC";
    }
    
    //[Serializable()]
    public partial class CrudeFinancialCouponTypeRefData {
        
        public string FinancialCouponTypeRcd { get; set; } //;
        
        public string FinancialCouponTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            string sql = @" select top 1 financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time
                            from [financial_coupon_type_ref]
                            where financial_coupon_type_rcd = @financial_coupon_type_rcd
                            order by financial_coupon_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = financialCouponTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialCouponTypeRefData GetByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            string sql = @" select top 1 financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time
                            from [financial_coupon_type_ref]
                            where financial_coupon_type_rcd = @financial_coupon_type_rcd
                            order by financial_coupon_type_name";

            var ret = new CrudeFinancialCouponTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = financialCouponTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialCouponTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialCouponTypeRefData>();

            string sql = @" select financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time
                            from [financial_coupon_type_ref]
                            where user_id = @user_id
                              
                            order by financial_coupon_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialCouponTypeName(string financialCouponTypeName) {
            string sql = @" select top 1 financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time
                            from [financial_coupon_type_ref]
                            where financial_coupon_type_name like '%' + @financialCouponTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialCouponTypeName",SqlDbType.NVarChar).Value = financialCouponTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialCouponTypeRefData> FetchAll() {
            var dataList = new List<CrudeFinancialCouponTypeRefData>();

            string sql = @" select financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time
                            from [financial_coupon_type_ref]
                            order by financial_coupon_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCouponTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialCouponTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time
                            from [financial_coupon_type_ref]
                            order by financial_coupon_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialCouponTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialCouponTypeRefData>();

            string sql = @" select financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time
                            from [financial_coupon_type_ref]
                            order by financial_coupon_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialCouponTypeRefData();
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
            string sql = @" select count(*) as count from [financial_coupon_type_ref]";

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
        
        public static List<CrudeFinancialCouponTypeRefData> FetchWithFilter(string financialCouponTypeRcd, string financialCouponTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialCouponTypeRefData>();

            string sql = @" select financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time
                            from [financial_coupon_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(financialCouponTypeRcd)) {
                        sql += "  and financial_coupon_type_rcd like '%' + @financial_coupon_type_rcd + '%'";
                        command.Parameters.Add("@financial_coupon_type_rcd", SqlDbType.NVarChar).Value = financialCouponTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialCouponTypeName)) {
                        sql += "  and financial_coupon_type_name like '%' + @financial_coupon_type_name + '%'";
                        command.Parameters.Add("@financial_coupon_type_name", SqlDbType.NVarChar).Value = financialCouponTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_coupon_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialCouponTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_coupon_type_rcd"] != System.DBNull.Value) FinancialCouponTypeRcd = (System.String) reader["financial_coupon_type_rcd"];
            if (reader["financial_coupon_type_name"] != System.DBNull.Value) FinancialCouponTypeName = (System.String) reader["financial_coupon_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [financial_coupon_type_ref] (financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time)";
            sql += "            values (@financial_coupon_type_rcd, @financial_coupon_type_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeRcd;
                    command.Parameters.Add("@financial_coupon_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [financial_coupon_type_ref] (financial_coupon_type_rcd, financial_coupon_type_name, user_id, date_time)";
            sql += "            values (@financial_coupon_type_rcd, @financial_coupon_type_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeRcd;
                command.Parameters.Add("@financial_coupon_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_coupon_type_ref] set
                 financial_coupon_type_rcd = @financial_coupon_type_rcd
                ,financial_coupon_type_name = @financial_coupon_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_coupon_type_rcd = @financial_coupon_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeRcd;
                    command.Parameters.Add("@financial_coupon_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_coupon_type_ref] set
                 financial_coupon_type_rcd = @financial_coupon_type_rcd
                ,financial_coupon_type_name = @financial_coupon_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_coupon_type_rcd = @financial_coupon_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeRcd;
                command.Parameters.Add("@financial_coupon_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialCouponTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string financialCouponTypeRcd) {
            string sql = @" delete [financial_coupon_type_ref] 
                where financial_coupon_type_rcd = @financial_coupon_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_coupon_type_rcd",SqlDbType.NVarChar).Value = financialCouponTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
