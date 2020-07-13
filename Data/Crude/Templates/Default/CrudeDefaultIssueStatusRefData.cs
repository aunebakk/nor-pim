/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:49:03 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    public partial class DefaultIssueStatusRef {
        
        public const string NotAnIssue = "NotAnIssue";
        
        public const string NotReproducible = "NotReproducible";
        
        public const string Resolved = "Resolved";
        
        public const string ToBeResolved = "ToBeResolved";
    }
    
    [Serializable()]
    public partial class CrudeDefaultIssueStatusRefData {
        
        public string DefaultIssueStatusRcd { get; set; }
        
        public string DefaultIssueStatusName { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            string sql = @" select top 1 default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where default_issue_status_rcd = @default_issue_status_rcd
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = defaultIssueStatusRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultIssueStatusRefData GetByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            string sql = @" select top 1 default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where default_issue_status_rcd = @default_issue_status_rcd
                            order by default_issue_status_name";

            var ret = new CrudeDefaultIssueStatusRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = defaultIssueStatusRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultIssueStatusRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueStatusRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultIssueStatusName(string defaultIssueStatusName) {
            string sql = @" select top 1 default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where default_issue_status_name like '%' + @defaultIssueStatusName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultIssueStatusName",SqlDbType.NVarChar).Value = defaultIssueStatusName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultIssueStatusRefData> FetchAll() {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueStatusRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultIssueStatusRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select top " + limit.ToString() + @" default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueStatusRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultIssueStatusRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            order by default_issue_status_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultIssueStatusRefData();
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
            string sql = @" select count(*) as count from [default_issue_status_ref]";

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
        
        public static List<CrudeDefaultIssueStatusRefData> FetchWithFilter(string defaultIssueStatusRcd, string defaultIssueStatusName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultIssueStatusRefData>();

            string sql = @" select default_issue_status_rcd, default_issue_status_name, default_user_id, date_time
                            from [default_issue_status_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultIssueStatusRcd)) {
                        sql += "  and default_issue_status_rcd like '%' + @default_issue_status_rcd + '%'";
                        command.Parameters.Add("@default_issue_status_rcd", SqlDbType.NVarChar).Value = defaultIssueStatusRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultIssueStatusName)) {
                        sql += "  and default_issue_status_name like '%' + @default_issue_status_name + '%'";
                        command.Parameters.Add("@default_issue_status_name", SqlDbType.NVarChar).Value = defaultIssueStatusName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_issue_status_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueStatusRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_issue_status_rcd"] != System.DBNull.Value) DefaultIssueStatusRcd = (System.String) reader["default_issue_status_rcd"];
            if (reader["default_issue_status_name"] != System.DBNull.Value) DefaultIssueStatusName = (System.String) reader["default_issue_status_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_issue_status_ref] (default_issue_status_rcd, default_issue_status_name, default_user_id, date_time)";
            sql += "            values (@default_issue_status_rcd, @default_issue_status_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                    command.Parameters.Add("@default_issue_status_name",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_issue_status_ref] (default_issue_status_rcd, default_issue_status_name, default_user_id, date_time)";
            sql += "            values (@default_issue_status_rcd, @default_issue_status_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                command.Parameters.Add("@default_issue_status_name",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_issue_status_ref] set
                 default_issue_status_rcd = @default_issue_status_rcd
                ,default_issue_status_name = @default_issue_status_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_issue_status_rcd = @default_issue_status_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                    command.Parameters.Add("@default_issue_status_name",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_issue_status_ref] set
                 default_issue_status_rcd = @default_issue_status_rcd
                ,default_issue_status_name = @default_issue_status_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_issue_status_rcd = @default_issue_status_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                command.Parameters.Add("@default_issue_status_name",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultIssueStatusRcd) {
            string sql = @" delete [default_issue_status_ref] 
                where default_issue_status_rcd = @default_issue_status_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = defaultIssueStatusRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
