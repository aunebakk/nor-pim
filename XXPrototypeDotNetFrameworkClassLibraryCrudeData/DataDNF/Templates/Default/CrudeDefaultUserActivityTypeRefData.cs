/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:43:04 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class DefaultUserActivityTypeRef {
        
        public const string BusinessLogicMethodInvoked = "blmi";
        
        public const string FormOpened = "fo";
        
        public const string Login = "li";
        
        public const string Logout = "lo";
        
        public const string ScheduledEvent = "se";
        
        public const string WebPageOpened = "wpo";
    }
    
    [Serializable()]
    public partial class CrudeDefaultUserActivityTypeRefData {
        
        public string DefaultUserActivityTypeRcd { get; set; } //;
        
        public string DefaultUserActivityTypeName { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            string sql = @" select top 1 default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time
                            from [default_user_activity_type_ref]
                            where default_user_activity_type_rcd = @default_user_activity_type_rcd
                            order by default_user_activity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = defaultUserActivityTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultUserActivityTypeRefData GetByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            string sql = @" select top 1 default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time
                            from [default_user_activity_type_ref]
                            where default_user_activity_type_rcd = @default_user_activity_type_rcd
                            order by default_user_activity_type_name";

            var ret = new CrudeDefaultUserActivityTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = defaultUserActivityTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultUserActivityTypeRefData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultUserActivityTypeRefData>();

            string sql = @" select default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time
                            from [default_user_activity_type_ref]
                            where default_user_id = @default_user_id
                              
                            order by default_user_activity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName) {
            string sql = @" select top 1 default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time
                            from [default_user_activity_type_ref]
                            where default_user_activity_type_name like '%' + @defaultUserActivityTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultUserActivityTypeName",SqlDbType.NVarChar).Value = defaultUserActivityTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultUserActivityTypeRefData> FetchAll() {
            var dataList = new List<CrudeDefaultUserActivityTypeRefData>();

            string sql = @" select default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time
                            from [default_user_activity_type_ref]
                            order by default_user_activity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserActivityTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultUserActivityTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time
                            from [default_user_activity_type_ref]
                            order by default_user_activity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserActivityTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultUserActivityTypeRefData>();

            string sql = @" select default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time
                            from [default_user_activity_type_ref]
                            order by default_user_activity_type_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultUserActivityTypeRefData();
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
            string sql = @" select count(*) as count from [default_user_activity_type_ref]";

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
        
        public static List<CrudeDefaultUserActivityTypeRefData> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultUserActivityTypeRefData>();

            string sql = @" select default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time
                            from [default_user_activity_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(defaultUserActivityTypeRcd)) {
                        sql += "  and default_user_activity_type_rcd like '%' + @default_user_activity_type_rcd + '%'";
                        command.Parameters.Add("@default_user_activity_type_rcd", SqlDbType.NVarChar).Value = defaultUserActivityTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultUserActivityTypeName)) {
                        sql += "  and default_user_activity_type_name like '%' + @default_user_activity_type_name + '%'";
                        command.Parameters.Add("@default_user_activity_type_name", SqlDbType.NVarChar).Value = defaultUserActivityTypeName.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by default_user_activity_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_user_activity_type_rcd"] != System.DBNull.Value) DefaultUserActivityTypeRcd = (System.String) reader["default_user_activity_type_rcd"];
            if (reader["default_user_activity_type_name"] != System.DBNull.Value) DefaultUserActivityTypeName = (System.String) reader["default_user_activity_type_name"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [default_user_activity_type_ref] (default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time)";
            sql += "            values (@default_user_activity_type_rcd, @default_user_activity_type_name, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                    command.Parameters.Add("@default_user_activity_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [default_user_activity_type_ref] (default_user_activity_type_rcd, default_user_activity_type_name, default_user_id, date_time)";
            sql += "            values (@default_user_activity_type_rcd, @default_user_activity_type_name, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                command.Parameters.Add("@default_user_activity_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_user_activity_type_ref] set
                 default_user_activity_type_rcd = @default_user_activity_type_rcd
                ,default_user_activity_type_name = @default_user_activity_type_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_user_activity_type_rcd = @default_user_activity_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                    command.Parameters.Add("@default_user_activity_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeName;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_user_activity_type_ref] set
                 default_user_activity_type_rcd = @default_user_activity_type_rcd
                ,default_user_activity_type_name = @default_user_activity_type_name
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_user_activity_type_rcd = @default_user_activity_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                command.Parameters.Add("@default_user_activity_type_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeName;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string defaultUserActivityTypeRcd) {
            string sql = @" delete [default_user_activity_type_ref] 
                where default_user_activity_type_rcd = @default_user_activity_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = defaultUserActivityTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
