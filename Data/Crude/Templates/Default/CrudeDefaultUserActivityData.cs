/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:40:46 AM
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
    public partial class CrudeDefaultUserActivityData {
        
        public System.Guid DefaultUserActivityId { get; set; }
        
        public string DefaultUserActivityTypeRcd { get; set; }
        
        public string UserActivityNote { get; set; }
        
        public string OriginatingAddress { get; set; }
        
        public string Referrer { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByDefaultUserActivityId(System.Guid defaultUserActivityId) {
            string sql = @" select top 1 default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where default_user_activity_id = @default_user_activity_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = defaultUserActivityId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultUserActivityData GetByDefaultUserActivityId(System.Guid defaultUserActivityId) {
            string sql = @" select top 1 default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where default_user_activity_id = @default_user_activity_id";

            var ret = new CrudeDefaultUserActivityData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = defaultUserActivityId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultUserActivityData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where default_user_id = @default_user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserActivityData> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where default_user_activity_type_rcd = @default_user_activity_type_rcd
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_activity_type_rcd", SqlDbType.NVarChar).Value = defaultUserActivityTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserActivityData> FetchAll() {
            var dataList = new List<CrudeDefaultUserActivityData>();

            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserActivityData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            string sql = @" select top " + limit.ToString() + @" default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserActivityData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultUserActivityData();
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
            string sql = @" select count(*) as count from [default_user_activity]";

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
        
        public static List<CrudeDefaultUserActivityData> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultUserActivityData>();

            string sql = @" select default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time
                            from [default_user_activity]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultUserActivityId != Guid.Empty) {
                        sql += "  and default_user_activity_id = @default_user_activity_id";
                        command.Parameters.Add("@default_user_activity_id", SqlDbType.UniqueIdentifier).Value = defaultUserActivityId;
                    }
                    if (!string.IsNullOrEmpty(defaultUserActivityTypeRcd)) {
                        sql += "  and default_user_activity_type_rcd like '%' + @default_user_activity_type_rcd + '%'";
                        command.Parameters.Add("@default_user_activity_type_rcd", SqlDbType.NVarChar).Value = defaultUserActivityTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(userActivityNote)) {
                        sql += "  and user_activity_note like '%' + @user_activity_note + '%'";
                        command.Parameters.Add("@user_activity_note", SqlDbType.NVarChar).Value = userActivityNote.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(originatingAddress)) {
                        sql += "  and originating_address like '%' + @originating_address + '%'";
                        command.Parameters.Add("@originating_address", SqlDbType.NVarChar).Value = originatingAddress.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(referrer)) {
                        sql += "  and referrer like '%' + @referrer + '%'";
                        command.Parameters.Add("@referrer", SqlDbType.NVarChar).Value = referrer.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserActivityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_user_activity_id"] != System.DBNull.Value) DefaultUserActivityId = (System.Guid) reader["default_user_activity_id"];
            if (reader["default_user_activity_type_rcd"] != System.DBNull.Value) DefaultUserActivityTypeRcd = (System.String) reader["default_user_activity_type_rcd"];
            if (reader["user_activity_note"] != System.DBNull.Value) UserActivityNote = (System.String) reader["user_activity_note"];
            if (reader["originating_address"] != System.DBNull.Value) OriginatingAddress = (System.String) reader["originating_address"];
            if (reader["referrer"] != System.DBNull.Value) Referrer = (System.String) reader["referrer"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultUserActivityId == Guid.Empty)
                DefaultUserActivityId = Guid.NewGuid();

            string sql = "insert into [default_user_activity] (default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time)";
            sql += "            values (@default_user_activity_id, @default_user_activity_type_rcd, @user_activity_note, @originating_address, @referrer, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserActivityId;
                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                    command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (System.String)UserActivityNote;
                    command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(OriginatingAddress)) ? (object)DBNull.Value : (System.String)OriginatingAddress;
                    command.Parameters.Add("@referrer",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Referrer)) ? (object)DBNull.Value : (System.String)Referrer;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultUserActivityId == Guid.Empty)
                DefaultUserActivityId = Guid.NewGuid();

            string sql = "insert into [default_user_activity] (default_user_activity_id, default_user_activity_type_rcd, user_activity_note, originating_address, referrer, default_user_id, date_time)";
            sql += "            values (@default_user_activity_id, @default_user_activity_type_rcd, @user_activity_note, @originating_address, @referrer, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserActivityId;
                command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (System.String)UserActivityNote;
                command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(OriginatingAddress)) ? (object)DBNull.Value : (System.String)OriginatingAddress;
                command.Parameters.Add("@referrer",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Referrer)) ? (object)DBNull.Value : (System.String)Referrer;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_user_activity] set
                 default_user_activity_id = @default_user_activity_id
                ,default_user_activity_type_rcd = @default_user_activity_type_rcd
                ,user_activity_note = @user_activity_note
                ,originating_address = @originating_address
                ,referrer = @referrer
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_user_activity_id = @default_user_activity_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserActivityId;
                    command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                    command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (System.String)UserActivityNote;
                    command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(OriginatingAddress)) ? (object)DBNull.Value : (System.String)OriginatingAddress;
                    command.Parameters.Add("@referrer",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Referrer)) ? (object)DBNull.Value : (System.String)Referrer;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_user_activity] set
                 default_user_activity_id = @default_user_activity_id
                ,default_user_activity_type_rcd = @default_user_activity_type_rcd
                ,user_activity_note = @user_activity_note
                ,originating_address = @originating_address
                ,referrer = @referrer
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_user_activity_id = @default_user_activity_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserActivityId;
                command.Parameters.Add("@default_user_activity_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultUserActivityTypeRcd;
                command.Parameters.Add("@user_activity_note",SqlDbType.NVarChar).Value = (System.String)UserActivityNote;
                command.Parameters.Add("@originating_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(OriginatingAddress)) ? (object)DBNull.Value : (System.String)OriginatingAddress;
                command.Parameters.Add("@referrer",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Referrer)) ? (object)DBNull.Value : (System.String)Referrer;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultUserActivityId) {
            string sql = @" delete [default_user_activity] 
                where default_user_activity_id = @default_user_activity_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_activity_id",SqlDbType.UniqueIdentifier).Value = defaultUserActivityId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
