/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:26 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeDefaultChangeLogData {
        
        public System.Guid DefaultChangeLogId { get; set; } //;
        
        public string DefaultChangeName { get; set; } //;
        
        public string DefaultChangeDescription { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string DefaultChangeLogTypeRcd { get; set; } //;
        
        public System.Guid DefaultIssueId { get; set; } //;
        
        public void FetchByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            string sql = @" select top 1 default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_change_log_id = @default_change_log_id
                            order by default_change_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = defaultChangeLogId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultChangeLogData GetByDefaultChangeLogId(System.Guid defaultChangeLogId) {
            string sql = @" select top 1 default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_change_log_id = @default_change_log_id
                            order by default_change_name";

            var ret = new CrudeDefaultChangeLogData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = defaultChangeLogId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultChangeLogData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_user_id = @default_user_id
                              
                            order by default_change_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultChangeLogData> FetchByDefaultIssueId(System.Guid defaultIssueId) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_issue_id = @default_issue_id
                              
                            order by default_change_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_id", SqlDbType.UniqueIdentifier).Value = defaultIssueId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultChangeLogData> FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_change_log_type_rcd = @default_change_log_type_rcd
                              
                            order by default_change_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_change_log_type_rcd", SqlDbType.NVarChar).Value = defaultChangeLogTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultChangeName(string defaultChangeName) {
            string sql = @" select top 1 default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where default_change_name like '%' + @defaultChangeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultChangeName",SqlDbType.NVarChar).Value = defaultChangeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultChangeLogData> FetchAll() {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            order by default_change_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultChangeLogData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select top " + limit.ToString() + @" default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            order by default_change_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultChangeLogData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            order by default_change_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultChangeLogData();
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
            string sql = @" select count(*) as count from [default_change_log]";

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
        
        public static List<CrudeDefaultChangeLogData> FetchWithFilter(System.Guid defaultChangeLogId, string defaultChangeName, string defaultChangeDescription, System.Guid defaultUserId, System.DateTime dateTime, string defaultChangeLogTypeRcd, System.Guid defaultIssueId) {
            var dataList = new List<CrudeDefaultChangeLogData>();

            string sql = @" select default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id
                            from [default_change_log]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultChangeLogId != Guid.Empty) {
                        sql += "  and default_change_log_id = @default_change_log_id";
                        command.Parameters.Add("@default_change_log_id", SqlDbType.UniqueIdentifier).Value = defaultChangeLogId;
                    }
                    if (!string.IsNullOrEmpty(defaultChangeName)) {
                        sql += "  and default_change_name like '%' + @default_change_name + '%'";
                        command.Parameters.Add("@default_change_name", SqlDbType.NVarChar).Value = defaultChangeName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultChangeDescription)) {
                        sql += "  and default_change_description like '%' + @default_change_description + '%'";
                        command.Parameters.Add("@default_change_description", SqlDbType.NVarChar).Value = defaultChangeDescription.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(defaultChangeLogTypeRcd)) {
                        sql += "  and default_change_log_type_rcd like '%' + @default_change_log_type_rcd + '%'";
                        command.Parameters.Add("@default_change_log_type_rcd", SqlDbType.NVarChar).Value = defaultChangeLogTypeRcd.Replace("'","''");
                    }
                    if (defaultIssueId != Guid.Empty) {
                        sql += "  and default_issue_id = @default_issue_id";
                        command.Parameters.Add("@default_issue_id", SqlDbType.UniqueIdentifier).Value = defaultIssueId;
                    }
                    sql += " order by default_change_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_change_log_id"] != System.DBNull.Value) DefaultChangeLogId = (System.Guid) reader["default_change_log_id"];
            if (reader["default_change_name"] != System.DBNull.Value) DefaultChangeName = (System.String) reader["default_change_name"];
            if (reader["default_change_description"] != System.DBNull.Value) DefaultChangeDescription = (System.String) reader["default_change_description"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["default_change_log_type_rcd"] != System.DBNull.Value) DefaultChangeLogTypeRcd = (System.String) reader["default_change_log_type_rcd"];
            if (reader["default_issue_id"] != System.DBNull.Value) DefaultIssueId = (System.Guid) reader["default_issue_id"];
        }
        
        public void Insert() {

            if (DefaultChangeLogId == Guid.Empty)
                DefaultChangeLogId = Guid.NewGuid();

            string sql = "insert into [default_change_log] (default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id)";
            sql += "            values (@default_change_log_id, @default_change_name, @default_change_description, @default_user_id, @date_time, @default_change_log_type_rcd, @default_issue_id)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultChangeLogId;
                    command.Parameters.Add("@default_change_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeName;
                    command.Parameters.Add("@default_change_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DefaultChangeDescription)) ? (object)DBNull.Value : (System.String)DefaultChangeDescription;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (DefaultIssueId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultIssueId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultChangeLogId == Guid.Empty)
                DefaultChangeLogId = Guid.NewGuid();

            string sql = "insert into [default_change_log] (default_change_log_id, default_change_name, default_change_description, default_user_id, date_time, default_change_log_type_rcd, default_issue_id)";
            sql += "            values (@default_change_log_id, @default_change_name, @default_change_description, @default_user_id, @date_time, @default_change_log_type_rcd, @default_issue_id)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultChangeLogId;
                command.Parameters.Add("@default_change_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeName;
                command.Parameters.Add("@default_change_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DefaultChangeDescription)) ? (object)DBNull.Value : (System.String)DefaultChangeDescription;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (DefaultIssueId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultIssueId);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_change_log] set
                 default_change_log_id = @default_change_log_id
                ,default_change_name = @default_change_name
                ,default_change_description = @default_change_description
                ,default_user_id = @default_user_id
                ,date_time = @date_time
                ,default_change_log_type_rcd = @default_change_log_type_rcd
                ,default_issue_id = @default_issue_id
            where default_change_log_id = @default_change_log_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultChangeLogId;
                    command.Parameters.Add("@default_change_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeName;
                    command.Parameters.Add("@default_change_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DefaultChangeDescription)) ? (object)DBNull.Value : (System.String)DefaultChangeDescription;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (DefaultIssueId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultIssueId);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_change_log] set
                 default_change_log_id = @default_change_log_id
                ,default_change_name = @default_change_name
                ,default_change_description = @default_change_description
                ,default_user_id = @default_user_id
                ,date_time = @date_time
                ,default_change_log_type_rcd = @default_change_log_type_rcd
                ,default_issue_id = @default_issue_id
            where default_change_log_id = @default_change_log_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultChangeLogId;
                command.Parameters.Add("@default_change_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeName;
                command.Parameters.Add("@default_change_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(DefaultChangeDescription)) ? (object)DBNull.Value : (System.String)DefaultChangeDescription;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (DefaultIssueId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultIssueId);
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultChangeLogId) {
            string sql = @" delete [default_change_log] 
                where default_change_log_id = @default_change_log_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_change_log_id",SqlDbType.UniqueIdentifier).Value = defaultChangeLogId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
