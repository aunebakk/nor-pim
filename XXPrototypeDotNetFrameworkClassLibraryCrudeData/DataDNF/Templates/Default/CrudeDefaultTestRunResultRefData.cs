/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:33:45 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class DefaultTestRunResultRef {
    }
    
    [Serializable()]
    public partial class CrudeDefaultTestRunResultRefData {
        
        public string DefaultTestRunResultRcd { get; set; } //;
        
        public string DefaultTestRunResultName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            string sql = @" select top 1 default_test_run_result_rcd, default_test_run_result_name, user_id, date_time
                            from [default_test_run_result_ref]
                            where default_test_run_result_rcd = @default_test_run_result_rcd
                            order by default_test_run_result_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = defaultTestRunResultRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultTestRunResultRefData GetByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            string sql = @" select top 1 default_test_run_result_rcd, default_test_run_result_name, user_id, date_time
                            from [default_test_run_result_ref]
                            where default_test_run_result_rcd = @default_test_run_result_rcd
                            order by default_test_run_result_name";

            var ret = new CrudeDefaultTestRunResultRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = defaultTestRunResultRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultTestRunResultRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeDefaultTestRunResultRefData>();

            string sql = @" select default_test_run_result_rcd, default_test_run_result_name, user_id, date_time
                            from [default_test_run_result_ref]
                            where user_id = @user_id
                              
                            order by default_test_run_result_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunResultRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultTestRunResultName(string defaultTestRunResultName) {
            string sql = @" select top 1 default_test_run_result_rcd, default_test_run_result_name, user_id, date_time
                            from [default_test_run_result_ref]
                            where default_test_run_result_name like '%' + @defaultTestRunResultName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultTestRunResultName",SqlDbType.NVarChar).Value = defaultTestRunResultName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultTestRunResultRefData> FetchAll() {
            var dataList = new List<CrudeDefaultTestRunResultRefData>();

            string sql = @" select default_test_run_result_rcd, default_test_run_result_name, user_id, date_time
                            from [default_test_run_result_ref]
                            order by default_test_run_result_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunResultRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestRunResultRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultTestRunResultRefData>();

            string sql = @" select top " + limit.ToString() + @" default_test_run_result_rcd, default_test_run_result_name, user_id, date_time
                            from [default_test_run_result_ref]
                            order by default_test_run_result_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunResultRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestRunResultRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultTestRunResultRefData>();

            string sql = @" select default_test_run_result_rcd, default_test_run_result_name, user_id, date_time
                            from [default_test_run_result_ref]
                            order by default_test_run_result_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultTestRunResultRefData();
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
            string sql = @" select count(*) as count from [default_test_run_result_ref]";

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
        
        public static List<CrudeDefaultTestRunResultRefData> FetchWithFilter(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultTestRunResultRefData>();

            string sql = @" select default_test_run_result_rcd, default_test_run_result_name, user_id, date_time
                            from [default_test_run_result_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultTestRunResultRcd)) {
                        sql += "  and default_test_run_result_rcd like '%' + @default_test_run_result_rcd + '%'";
                        command.Parameters.Add("@default_test_run_result_rcd", SqlDbType.NVarChar).Value = defaultTestRunResultRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultTestRunResultName)) {
                        sql += "  and default_test_run_result_name like '%' + @default_test_run_result_name + '%'";
                        command.Parameters.Add("@default_test_run_result_name", SqlDbType.NVarChar).Value = defaultTestRunResultName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_test_run_result_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestRunResultRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_test_run_result_rcd"] != System.DBNull.Value) DefaultTestRunResultRcd = (System.String) reader["default_test_run_result_rcd"];
            if (reader["default_test_run_result_name"] != System.DBNull.Value) DefaultTestRunResultName = (System.String) reader["default_test_run_result_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_test_run_result_ref] (default_test_run_result_rcd, default_test_run_result_name, user_id, date_time)";
            sql += "            values (@default_test_run_result_rcd, @default_test_run_result_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                    command.Parameters.Add("@default_test_run_result_name",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_test_run_result_ref] (default_test_run_result_rcd, default_test_run_result_name, user_id, date_time)";
            sql += "            values (@default_test_run_result_rcd, @default_test_run_result_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                command.Parameters.Add("@default_test_run_result_name",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_test_run_result_ref] set
                 default_test_run_result_rcd = @default_test_run_result_rcd
                ,default_test_run_result_name = @default_test_run_result_name
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_run_result_rcd = @default_test_run_result_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                    command.Parameters.Add("@default_test_run_result_name",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_test_run_result_ref] set
                 default_test_run_result_rcd = @default_test_run_result_rcd
                ,default_test_run_result_name = @default_test_run_result_name
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_run_result_rcd = @default_test_run_result_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultRcd;
                command.Parameters.Add("@default_test_run_result_name",SqlDbType.NVarChar).Value = (System.String)DefaultTestRunResultName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultTestRunResultRcd) {
            string sql = @" delete [default_test_run_result_ref] 
                where default_test_run_result_rcd = @default_test_run_result_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_test_run_result_rcd",SqlDbType.NVarChar).Value = defaultTestRunResultRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
