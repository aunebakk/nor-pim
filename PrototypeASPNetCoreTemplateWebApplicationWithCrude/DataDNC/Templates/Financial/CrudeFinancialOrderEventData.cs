/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:45:22 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeFinancialOrderEventData {
        
        public System.Guid FiancialOrderEventId { get; set; } //;
        
        public System.Guid FinancialOrderId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string Comment { get; set; } //;
        
        public string FinancialOrderEventTypeRcd { get; set; } //;
        
        public void FetchByFiancialOrderEventId(System.Guid fiancialOrderEventId) {
            string sql = @" select top 1 fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]
                            where fiancial_order_event_id = @fiancial_order_event_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@fiancial_order_event_id",SqlDbType.UniqueIdentifier).Value = fiancialOrderEventId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialOrderEventData GetByFiancialOrderEventId(System.Guid fiancialOrderEventId) {
            string sql = @" select top 1 fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]
                            where fiancial_order_event_id = @fiancial_order_event_id";

            var ret = new CrudeFinancialOrderEventData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@fiancial_order_event_id",SqlDbType.UniqueIdentifier).Value = fiancialOrderEventId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialOrderEventData> FetchByFinancialOrderId(System.Guid financialOrderId) {
            var dataList = new List<CrudeFinancialOrderEventData>();

            string sql = @" select fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]
                            where financial_order_id = @financial_order_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderEventData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialOrderEventData>();

            string sql = @" select fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderEventData> FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd) {
            var dataList = new List<CrudeFinancialOrderEventData>();

            string sql = @" select fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]
                            where financial_order_event_type_rcd = @financial_order_event_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_event_type_rcd", SqlDbType.NVarChar).Value = financialOrderEventTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderEventData> FetchAll() {
            var dataList = new List<CrudeFinancialOrderEventData>();

            string sql = @" select fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderEventData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialOrderEventData>();

            string sql = @" select top " + limit.ToString() + @" fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderEventData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialOrderEventData>();

            string sql = @" select fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialOrderEventData();
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
            string sql = @" select count(*) as count from [financial_order_event]";

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
        
        public static List<CrudeFinancialOrderEventData> FetchWithFilter(System.Guid fiancialOrderEventId, System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, string financialOrderEventTypeRcd) {
            var dataList = new List<CrudeFinancialOrderEventData>();

            string sql = @" select fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd
                            from [financial_order_event]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (fiancialOrderEventId != Guid.Empty) {
                        sql += "  and fiancial_order_event_id = @fiancial_order_event_id";
                        command.Parameters.Add("@fiancial_order_event_id", SqlDbType.UniqueIdentifier).Value = fiancialOrderEventId;
                    }
                    if (financialOrderId != Guid.Empty) {
                        sql += "  and financial_order_id = @financial_order_id";
                        command.Parameters.Add("@financial_order_id", SqlDbType.UniqueIdentifier).Value = financialOrderId;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(comment)) {
                        sql += "  and comment like '%' + @comment + '%'";
                        command.Parameters.Add("@comment", SqlDbType.NVarChar).Value = comment.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialOrderEventTypeRcd)) {
                        sql += "  and financial_order_event_type_rcd like '%' + @financial_order_event_type_rcd + '%'";
                        command.Parameters.Add("@financial_order_event_type_rcd", SqlDbType.NVarChar).Value = financialOrderEventTypeRcd.Replace("'","''");
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderEventData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["fiancial_order_event_id"] != System.DBNull.Value) FiancialOrderEventId = (System.Guid) reader["fiancial_order_event_id"];
            if (reader["financial_order_id"] != System.DBNull.Value) FinancialOrderId = (System.Guid) reader["financial_order_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["comment"] != System.DBNull.Value) Comment = (System.String) reader["comment"];
            if (reader["financial_order_event_type_rcd"] != System.DBNull.Value) FinancialOrderEventTypeRcd = (System.String) reader["financial_order_event_type_rcd"];
        }
        
        public void Insert() {

            if (FiancialOrderEventId == Guid.Empty)
                FiancialOrderEventId = Guid.NewGuid();

            string sql = "insert into [financial_order_event] (fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd)";
            sql += "            values (@fiancial_order_event_id, @financial_order_id, @user_id, @date_time, @comment, @financial_order_event_type_rcd)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@fiancial_order_event_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FiancialOrderEventId;
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@financial_order_event_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderEventTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (FiancialOrderEventId == Guid.Empty)
                FiancialOrderEventId = Guid.NewGuid();

            string sql = "insert into [financial_order_event] (fiancial_order_event_id, financial_order_id, user_id, date_time, comment, financial_order_event_type_rcd)";
            sql += "            values (@fiancial_order_event_id, @financial_order_id, @user_id, @date_time, @comment, @financial_order_event_type_rcd)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@fiancial_order_event_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FiancialOrderEventId;
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@financial_order_event_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderEventTypeRcd;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_order_event] set
                 fiancial_order_event_id = @fiancial_order_event_id
                ,financial_order_id = @financial_order_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,comment = @comment
                ,financial_order_event_type_rcd = @financial_order_event_type_rcd
            where fiancial_order_event_id = @fiancial_order_event_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@fiancial_order_event_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FiancialOrderEventId;
                    command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@financial_order_event_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderEventTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_order_event] set
                 fiancial_order_event_id = @fiancial_order_event_id
                ,financial_order_id = @financial_order_id
                ,user_id = @user_id
                ,date_time = @date_time
                ,comment = @comment
                ,financial_order_event_type_rcd = @financial_order_event_type_rcd
            where fiancial_order_event_id = @fiancial_order_event_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@fiancial_order_event_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FiancialOrderEventId;
                command.Parameters.Add("@financial_order_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)FinancialOrderId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@financial_order_event_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderEventTypeRcd;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid fiancialOrderEventId) {
            string sql = @" delete [financial_order_event] 
                where fiancial_order_event_id = @fiancial_order_event_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@fiancial_order_event_id",SqlDbType.UniqueIdentifier).Value = fiancialOrderEventId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
