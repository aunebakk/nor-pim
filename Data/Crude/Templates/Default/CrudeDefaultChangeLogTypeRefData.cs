/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:12:47 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    public partial class DefaultChangeLogTypeRef {
        
        public const string ChangedFeature = "Change";
        
        public const string Issue = "Issue";
        
        public const string NewFeature = "New";
        
        public const string RemovedFeature = "Removed";
    }
    
    [Serializable()]
    public partial class CrudeDefaultChangeLogTypeRefData {
        
        public string DefaultChangeLogTypeRcd { get; set; }
        
        public string DefaultChangeLogTypeName { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            string sql = @" select top 1 default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time
                            from [default_change_log_type_ref]
                            where default_change_log_type_rcd = @default_change_log_type_rcd
                            order by default_change_log_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = defaultChangeLogTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultChangeLogTypeRefData GetByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            string sql = @" select top 1 default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time
                            from [default_change_log_type_ref]
                            where default_change_log_type_rcd = @default_change_log_type_rcd
                            order by default_change_log_type_name";

            var ret = new CrudeDefaultChangeLogTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = defaultChangeLogTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultChangeLogTypeRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultChangeLogTypeRefData>();

            string sql = @" select default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time
                            from [default_change_log_type_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_change_log_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName) {
            string sql = @" select top 1 default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time
                            from [default_change_log_type_ref]
                            where default_change_log_type_name like '%' + @defaultChangeLogTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultChangeLogTypeName",SqlDbType.NVarChar).Value = defaultChangeLogTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultChangeLogTypeRefData> FetchAll() {
            var dataList = new List<CrudeDefaultChangeLogTypeRefData>();

            string sql = @" select default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time
                            from [default_change_log_type_ref]
                            order by default_change_log_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultChangeLogTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultChangeLogTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time
                            from [default_change_log_type_ref]
                            order by default_change_log_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultChangeLogTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultChangeLogTypeRefData>();

            string sql = @" select default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time
                            from [default_change_log_type_ref]
                            order by default_change_log_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultChangeLogTypeRefData();
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
            string sql = @" select count(*) as count from [default_change_log_type_ref]";

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
        
        public static List<CrudeDefaultChangeLogTypeRefData> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultChangeLogTypeRefData>();

            string sql = @" select default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time
                            from [default_change_log_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultChangeLogTypeRcd)) {
                        sql += "  and default_change_log_type_rcd like '%' + @default_change_log_type_rcd + '%'";
                        command.Parameters.Add("@default_change_log_type_rcd", SqlDbType.NVarChar).Value = defaultChangeLogTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultChangeLogTypeName)) {
                        sql += "  and default_change_log_type_name like '%' + @default_change_log_type_name + '%'";
                        command.Parameters.Add("@default_change_log_type_name", SqlDbType.NVarChar).Value = defaultChangeLogTypeName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_change_log_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultChangeLogTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_change_log_type_rcd"] != System.DBNull.Value) DefaultChangeLogTypeRcd = (System.String) reader["default_change_log_type_rcd"];
            if (reader["default_change_log_type_name"] != System.DBNull.Value) DefaultChangeLogTypeName = (System.String) reader["default_change_log_type_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_change_log_type_ref] (default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time)";
            sql += "            values (@default_change_log_type_rcd, @default_change_log_type_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                    command.Parameters.Add("@default_change_log_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_change_log_type_ref] (default_change_log_type_rcd, default_change_log_type_name, default_user_id, date_time)";
            sql += "            values (@default_change_log_type_rcd, @default_change_log_type_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                command.Parameters.Add("@default_change_log_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_change_log_type_ref] set
                 default_change_log_type_rcd = @default_change_log_type_rcd
                ,default_change_log_type_name = @default_change_log_type_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_change_log_type_rcd = @default_change_log_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                    command.Parameters.Add("@default_change_log_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_change_log_type_ref] set
                 default_change_log_type_rcd = @default_change_log_type_rcd
                ,default_change_log_type_name = @default_change_log_type_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_change_log_type_rcd = @default_change_log_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeRcd;
                command.Parameters.Add("@default_change_log_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultChangeLogTypeName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultChangeLogTypeRcd) {
            string sql = @" delete [default_change_log_type_ref] 
                where default_change_log_type_rcd = @default_change_log_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_change_log_type_rcd",SqlDbType.NVarChar).Value = defaultChangeLogTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
