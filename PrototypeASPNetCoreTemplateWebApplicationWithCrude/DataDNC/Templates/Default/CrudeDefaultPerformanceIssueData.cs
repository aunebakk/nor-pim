/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:36 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeDefaultPerformanceIssueData {
        
        public System.Guid DefaultPerformanceIssueId { get; set; } //;
        
        public string CommandName { get; set; } //;
        
        public string CommandText { get; set; } //;
        
        public int Milliseconds { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            string sql = @" select top 1 default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where default_performance_issue_id = @default_performance_issue_id
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceIssueId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultPerformanceIssueData GetByDefaultPerformanceIssueId(System.Guid defaultPerformanceIssueId) {
            string sql = @" select top 1 default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where default_performance_issue_id = @default_performance_issue_id
                            order by command_name";

            var ret = new CrudeDefaultPerformanceIssueData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceIssueId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultPerformanceIssueData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            string sql = @" select default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where default_user_id = @default_user_id
                              
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByCommandName(string commandName) {
            string sql = @" select top 1 default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where command_name like '%' + @commandName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@commandName",SqlDbType.NVarChar).Value = commandName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultPerformanceIssueData> FetchAll() {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            string sql = @" select default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultPerformanceIssueData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            string sql = @" select top " + limit.ToString() + @" default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultPerformanceIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultPerformanceIssueData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            string sql = @" select default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            order by command_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultPerformanceIssueData();
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
            string sql = @" select count(*) as count from [default_performance_issue]";

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
        
        public static List<CrudeDefaultPerformanceIssueData> FetchWithFilter(System.Guid defaultPerformanceIssueId, string commandName, string commandText, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultPerformanceIssueData>();

            string sql = @" select default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time
                            from [default_performance_issue]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultPerformanceIssueId != Guid.Empty) {
                        sql += "  and default_performance_issue_id = @default_performance_issue_id";
                        command.Parameters.Add("@default_performance_issue_id", SqlDbType.UniqueIdentifier).Value = defaultPerformanceIssueId;
                    }
                    if (!string.IsNullOrEmpty(commandName)) {
                        sql += "  and command_name like '%' + @command_name + '%'";
                        command.Parameters.Add("@command_name", SqlDbType.NVarChar).Value = commandName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(commandText)) {
                        sql += "  and command_text like '%' + @command_text + '%'";
                        command.Parameters.Add("@command_text", SqlDbType.NVarChar).Value = commandText.Replace("'","''");
                    }
                    if (milliseconds != 0) {
                        sql += "  and milliseconds = @milliseconds";
                        command.Parameters.Add("@milliseconds", SqlDbType.Int).Value = milliseconds;
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
                        var data = new CrudeDefaultPerformanceIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_performance_issue_id"] != System.DBNull.Value) DefaultPerformanceIssueId = (System.Guid) reader["default_performance_issue_id"];
            if (reader["command_name"] != System.DBNull.Value) CommandName = (System.String) reader["command_name"];
            if (reader["command_text"] != System.DBNull.Value) CommandText = (System.String) reader["command_text"];
            if (reader["milliseconds"] != System.DBNull.Value) Milliseconds = (System.Int32) reader["milliseconds"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultPerformanceIssueId == Guid.Empty)
                DefaultPerformanceIssueId = Guid.NewGuid();

            string sql = "insert into [default_performance_issue] (default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time)";
            sql += "            values (@default_performance_issue_id, @command_name, @command_text, @milliseconds, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceIssueId;
                    command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                    command.Parameters.Add("@command_text",SqlDbType.NVarChar).Value = (System.String)CommandText;
                    command.Parameters.Add("@milliseconds",SqlDbType.Int).Value = (System.Int32)Milliseconds;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultPerformanceIssueId == Guid.Empty)
                DefaultPerformanceIssueId = Guid.NewGuid();

            string sql = "insert into [default_performance_issue] (default_performance_issue_id, command_name, command_text, milliseconds, default_user_id, date_time)";
            sql += "            values (@default_performance_issue_id, @command_name, @command_text, @milliseconds, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceIssueId;
                command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                command.Parameters.Add("@command_text",SqlDbType.NVarChar).Value = (System.String)CommandText;
                command.Parameters.Add("@milliseconds",SqlDbType.Int).Value = (System.Int32)Milliseconds;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_performance_issue] set
                 default_performance_issue_id = @default_performance_issue_id
                ,command_name = @command_name
                ,command_text = @command_text
                ,milliseconds = @milliseconds
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_performance_issue_id = @default_performance_issue_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceIssueId;
                    command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                    command.Parameters.Add("@command_text",SqlDbType.NVarChar).Value = (System.String)CommandText;
                    command.Parameters.Add("@milliseconds",SqlDbType.Int).Value = (System.Int32)Milliseconds;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_performance_issue] set
                 default_performance_issue_id = @default_performance_issue_id
                ,command_name = @command_name
                ,command_text = @command_text
                ,milliseconds = @milliseconds
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_performance_issue_id = @default_performance_issue_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultPerformanceIssueId;
                command.Parameters.Add("@command_name",SqlDbType.NVarChar).Value = (System.String)CommandName;
                command.Parameters.Add("@command_text",SqlDbType.NVarChar).Value = (System.String)CommandText;
                command.Parameters.Add("@milliseconds",SqlDbType.Int).Value = (System.Int32)Milliseconds;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultPerformanceIssueId) {
            string sql = @" delete [default_performance_issue] 
                where default_performance_issue_id = @default_performance_issue_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_performance_issue_id",SqlDbType.UniqueIdentifier).Value = defaultPerformanceIssueId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
