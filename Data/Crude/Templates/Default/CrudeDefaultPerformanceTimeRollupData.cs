/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:25:25 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class CrudeDefaultPerformanceTimeRollupData {
        
        public System.Guid DefaultPerformanceTimeRollupId { get; set; }
        
        public string CommandName { get; set; }
        
        public long Milliseconds { get; set; }
        
        public long Hits { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId) {
            string sql = @" select top 1 default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time
                            from [default_performance_time_rollup]
                            where default_performance_time_rollup_id = @default_performance_time_rollup_id
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_performance_time_rollup_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceTimeRollupId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultPerformanceTimeRollupData GetByDefaultPerformanceTimeRollupId(System.Guid defaultPerformanceTimeRollupId) {
            string sql = @" select top 1 default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time
                            from [default_performance_time_rollup]
                            where default_performance_time_rollup_id = @default_performance_time_rollup_id
                            order by command_name";

            var ret = new CrudeDefaultPerformanceTimeRollupData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_performance_time_rollup_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceTimeRollupId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultPerformanceTimeRollupData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultPerformanceTimeRollupData>();

            string sql = @" select default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time
                            from [default_performance_time_rollup]
                            where default_user_id = @default_user_id
                              
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceTimeRollupData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByCommandName(string commandName) {
            string sql = @" select top 1 default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time
                            from [default_performance_time_rollup]
                            where command_name like '%' + @commandName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@commandName",SqlDbType.NVarChar).Value = commandName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultPerformanceTimeRollupData> FetchAll() {
            var dataList = new List<CrudeDefaultPerformanceTimeRollupData>();

            string sql = @" select default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time
                            from [default_performance_time_rollup]
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceTimeRollupData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultPerformanceTimeRollupData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultPerformanceTimeRollupData>();

            string sql = @" select top " + limit.ToString() + @" default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time
                            from [default_performance_time_rollup]
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceTimeRollupData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultPerformanceTimeRollupData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultPerformanceTimeRollupData>();

            string sql = @" select default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time
                            from [default_performance_time_rollup]
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultPerformanceTimeRollupData();
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
            string sql = @" select count(*) as count from [default_performance_time_rollup]";

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
        
        public static List<CrudeDefaultPerformanceTimeRollupData> FetchWithFilter(System.Guid defaultPerformanceTimeRollupId, string commandName, long milliseconds, long hits, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultPerformanceTimeRollupData>();

            string sql = @" select default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time
                            from [default_performance_time_rollup]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultPerformanceTimeRollupId != Guid.Empty) {
                        sql += "  and default_performance_time_rollup_id = @default_performance_time_rollup_id";
                        command.Parameters.Add("@default_performance_time_rollup_id", SqlDbType.UniqueIdentifier).Value = defaultPerformanceTimeRollupId;
                    }
                    if (!string.IsNullOrEmpty(commandName)) {
                        sql += "  and command_name like '%' + @command_name + '%'";
                        command.Parameters.Add("@command_name", SqlDbType.NVarChar).Value = commandName.Replace("'","''");
                    }
                    if (milliseconds != 0) {
                        sql += "  and milliseconds = @milliseconds";
                        command.Parameters.Add("@milliseconds", SqlDbType.BigInt).Value = milliseconds;
                    }
                    if (hits != 0) {
                        sql += "  and hits = @hits";
                        command.Parameters.Add("@hits", SqlDbType.BigInt).Value = hits;
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by command_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceTimeRollupData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_performance_time_rollup_id"] != System.DBNull.Value) DefaultPerformanceTimeRollupId = (System.Guid) reader["default_performance_time_rollup_id"];
            if (reader["command_name"] != System.DBNull.Value) CommandName = (System.String) reader["command_name"];
            if (reader["milliseconds"] != System.DBNull.Value) Milliseconds = (System.Int64) reader["milliseconds"];
            if (reader["hits"] != System.DBNull.Value) Hits = (System.Int64) reader["hits"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultPerformanceTimeRollupId == Guid.Empty)
                DefaultPerformanceTimeRollupId = Guid.NewGuid();

            string sql = "insert into [default_performance_time_rollup] (default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time)";
            sql += "            values (@default_performance_time_rollup_id, @command_name, @milliseconds, @hits, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_performance_time_rollup_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceTimeRollupId;
                    command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                    command.Parameters.Add("@milliseconds",SqlDbType.BigInt).Value = (System.Int64)Milliseconds;
                    command.Parameters.Add("@hits",SqlDbType.BigInt).Value = (System.Int64)Hits;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultPerformanceTimeRollupId == Guid.Empty)
                DefaultPerformanceTimeRollupId = Guid.NewGuid();

            string sql = "insert into [default_performance_time_rollup] (default_performance_time_rollup_id, command_name, milliseconds, hits, default_user_id, date_time)";
            sql += "            values (@default_performance_time_rollup_id, @command_name, @milliseconds, @hits, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_performance_time_rollup_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceTimeRollupId;
                command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                command.Parameters.Add("@milliseconds",SqlDbType.BigInt).Value = (System.Int64)Milliseconds;
                command.Parameters.Add("@hits",SqlDbType.BigInt).Value = (System.Int64)Hits;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_performance_time_rollup] set
                 default_performance_time_rollup_id = @default_performance_time_rollup_id
                ,command_name = @command_name
                ,milliseconds = @milliseconds
                ,hits = @hits
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_performance_time_rollup_id = @default_performance_time_rollup_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_performance_time_rollup_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceTimeRollupId;
                    command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                    command.Parameters.Add("@milliseconds",SqlDbType.BigInt).Value = (System.Int64)Milliseconds;
                    command.Parameters.Add("@hits",SqlDbType.BigInt).Value = (System.Int64)Hits;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_performance_time_rollup] set
                 default_performance_time_rollup_id = @default_performance_time_rollup_id
                ,command_name = @command_name
                ,milliseconds = @milliseconds
                ,hits = @hits
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_performance_time_rollup_id = @default_performance_time_rollup_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_performance_time_rollup_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceTimeRollupId;
                command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                command.Parameters.Add("@milliseconds",SqlDbType.BigInt).Value = (System.Int64)Milliseconds;
                command.Parameters.Add("@hits",SqlDbType.BigInt).Value = (System.Int64)Hits;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultPerformanceTimeRollupId) {
            string sql = @" delete [default_performance_time_rollup] 
                where default_performance_time_rollup_id = @default_performance_time_rollup_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_performance_time_rollup_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceTimeRollupId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
