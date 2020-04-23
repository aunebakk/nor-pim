/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:50:18 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeDefaultTestRunData {
        
        public System.Guid DefaultTestRunId { get; set; } //;
        
        public System.Guid DefaultTestId { get; set; } //;
        
        public string DefaultTestRunResultRcd { get; set; } //;
        
        public string Result { get; set; } //;
        
        public System.DateTime StartDateTime { get; set; } //;
        
        public System.DateTime EndDateTime { get; set; } //;
        
        public int ElapsedMilliseconds { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultTestRunId(System.Guid defaultTestRunId) {
            string sql = @" select top 1 default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where default_test_run_id = @default_test_run_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = defaultTestRunId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultTestRunData GetByDefaultTestRunId(System.Guid defaultTestRunId) {
            string sql = @" select top 1 default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where default_test_run_id = @default_test_run_id";

            var ret = new CrudeDefaultTestRunData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = defaultTestRunId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultTestRunData> FetchByDefaultTestId(System.Guid defaultTestId) {
            var dataList = new List<CrudeDefaultTestRunData>();

            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where default_test_id = @default_test_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_test_id", SqlDbType.UniqueIdentifier).Value = defaultTestId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestRunData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeDefaultTestRunData>();

            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestRunData> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            var dataList = new List<CrudeDefaultTestRunData>();

            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where default_test_run_result_rcd = @default_test_run_result_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_test_run_result_rcd", SqlDbType.NVarChar).Value = defaultTestRunResultRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestRunData> FetchAll() {
            var dataList = new List<CrudeDefaultTestRunData>();

            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestRunData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultTestRunData>();

            string sql = @" select top " + limit.ToString() + @" default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestRunData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultTestRunData>();

            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultTestRunData();
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
            string sql = @" select count(*) as count from [default_test_run]";

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
        
        public static List<CrudeDefaultTestRunData> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultTestRunData>();

            string sql = @" select default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time
                            from [default_test_run]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultTestRunId != Guid.Empty) {
                        sql += "  and default_test_run_id = @default_test_run_id";
                        command.Parameters.Add("@default_test_run_id", SqlDbType.UniqueIdentifier).Value = defaultTestRunId;
                    }
                    if (defaultTestId != Guid.Empty) {
                        sql += "  and default_test_id = @default_test_id";
                        command.Parameters.Add("@default_test_id", SqlDbType.UniqueIdentifier).Value = defaultTestId;
                    }
                    if (!string.IsNullOrEmpty(defaultTestRunResultRcd)) {
                        sql += "  and default_test_run_result_rcd like '%' + @default_test_run_result_rcd + '%'";
                        command.Parameters.Add("@default_test_run_result_rcd", SqlDbType.NVarChar).Value = defaultTestRunResultRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(result)) {
                        sql += "  and result like '%' + @result + '%'";
                        command.Parameters.Add("@result", SqlDbType.NVarChar).Value = result.Replace("'","''");
                    }
                    if (startDateTime != DateTime.MinValue) {
                        sql += "  and start_date_time = @start_date_time";
                        command.Parameters.Add("@start_date_time", SqlDbType.DateTime).Value = startDateTime;
                    }
                    if (endDateTime != DateTime.MinValue) {
                        sql += "  and end_date_time = @end_date_time";
                        command.Parameters.Add("@end_date_time", SqlDbType.DateTime).Value = endDateTime;
                    }
                    if (elapsedMilliseconds != 0) {
                        sql += "  and elapsed_milliseconds = @elapsed_milliseconds";
                        command.Parameters.Add("@elapsed_milliseconds", SqlDbType.Int).Value = elapsedMilliseconds;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_test_run_id"] != System.DBNull.Value) DefaultTestRunId = (System.Guid) reader["default_test_run_id"];
            if (reader["default_test_id"] != System.DBNull.Value) DefaultTestId = (System.Guid) reader["default_test_id"];
            if (reader["default_test_run_result_rcd"] != System.DBNull.Value) DefaultTestRunResultRcd = (System.String) reader["default_test_run_result_rcd"];
            if (reader["result"] != System.DBNull.Value) Result = (System.String) reader["result"];
            if (reader["start_date_time"] != System.DBNull.Value) StartDateTime = (System.DateTime) reader["start_date_time"];
            if (reader["end_date_time"] != System.DBNull.Value) EndDateTime = (System.DateTime) reader["end_date_time"];
            if (reader["elapsed_milliseconds"] != System.DBNull.Value) ElapsedMilliseconds = (System.Int32) reader["elapsed_milliseconds"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultTestRunId == Guid.Empty)
                DefaultTestRunId = Guid.NewGuid();

            string sql = "insert into [default_test_run] (default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time)";
            sql += "            values (@default_test_run_id, @default_test_id, @default_test_run_result_rcd, @result, @start_date_time, @end_date_time, @elapsed_milliseconds, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestRunId;
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                    command.Parameters.Add("@result",SqlDbType.NVarChar).Value = (System.String)Result;
                    command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                    command.Parameters.Add("@end_date_time",SqlDbType.DateTime).Value = (System.DateTime)EndDateTime;
                    command.Parameters.Add("@elapsed_milliseconds",SqlDbType.Int).Value = (System.Int32)ElapsedMilliseconds;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultTestRunId == Guid.Empty)
                DefaultTestRunId = Guid.NewGuid();

            string sql = "insert into [default_test_run] (default_test_run_id, default_test_id, default_test_run_result_rcd, result, start_date_time, end_date_time, elapsed_milliseconds, user_id, date_time)";
            sql += "            values (@default_test_run_id, @default_test_id, @default_test_run_result_rcd, @result, @start_date_time, @end_date_time, @elapsed_milliseconds, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestRunId;
                command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                command.Parameters.Add("@result",SqlDbType.NVarChar).Value = (System.String)Result;
                command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                command.Parameters.Add("@end_date_time",SqlDbType.DateTime).Value = (System.DateTime)EndDateTime;
                command.Parameters.Add("@elapsed_milliseconds",SqlDbType.Int).Value = (System.Int32)ElapsedMilliseconds;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_test_run] set
                 default_test_run_id = @default_test_run_id
                ,default_test_id = @default_test_id
                ,default_test_run_result_rcd = @default_test_run_result_rcd
                ,result = @result
                ,start_date_time = @start_date_time
                ,end_date_time = @end_date_time
                ,elapsed_milliseconds = @elapsed_milliseconds
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_run_id = @default_test_run_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestRunId;
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                    command.Parameters.Add("@result",SqlDbType.NVarChar).Value = (System.String)Result;
                    command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                    command.Parameters.Add("@end_date_time",SqlDbType.DateTime).Value = (System.DateTime)EndDateTime;
                    command.Parameters.Add("@elapsed_milliseconds",SqlDbType.Int).Value = (System.Int32)ElapsedMilliseconds;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_test_run] set
                 default_test_run_id = @default_test_run_id
                ,default_test_id = @default_test_id
                ,default_test_run_result_rcd = @default_test_run_result_rcd
                ,result = @result
                ,start_date_time = @start_date_time
                ,end_date_time = @end_date_time
                ,elapsed_milliseconds = @elapsed_milliseconds
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_run_id = @default_test_run_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestRunId;
                command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                command.Parameters.Add("@result",SqlDbType.NVarChar).Value = (System.String)Result;
                command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                command.Parameters.Add("@end_date_time",SqlDbType.DateTime).Value = (System.DateTime)EndDateTime;
                command.Parameters.Add("@elapsed_milliseconds",SqlDbType.Int).Value = (System.Int32)ElapsedMilliseconds;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultTestRunId) {
            string sql = @" delete [default_test_run] 
                where default_test_run_id = @default_test_run_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_test_run_id",SqlDbType.UniqueIdentifier).Value = defaultTestRunId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
