/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:49:17 PM
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
    public partial class CrudeDefaultVersionData {
        
        public System.Guid DefaultVersionId { get; set; }
        
        public string FunVersion { get; set; }
        
        public string Number { get; set; }
        
        public int MajorNumber { get; set; }
        
        public int MinorNumber { get; set; }
        
        public int SequenceNumber { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByDefaultVersionId(System.Guid defaultVersionId) {
            string sql = @" select top 1 default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time
                            from [default_version]
                            where default_version_id = @default_version_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_version_id",SqlDbType.UniqueIdentifier).Value = defaultVersionId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultVersionData GetByDefaultVersionId(System.Guid defaultVersionId) {
            string sql = @" select top 1 default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time
                            from [default_version]
                            where default_version_id = @default_version_id";

            var ret = new CrudeDefaultVersionData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_version_id",SqlDbType.UniqueIdentifier).Value = defaultVersionId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultVersionData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultVersionData>();

            string sql = @" select default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time
                            from [default_version]
                            where default_user_id = @default_user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultVersionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultVersionData> FetchAll() {
            var dataList = new List<CrudeDefaultVersionData>();

            string sql = @" select default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time
                            from [default_version]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultVersionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultVersionData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultVersionData>();

            string sql = @" select top " + limit.ToString() + @" default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time
                            from [default_version]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultVersionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultVersionData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultVersionData>();

            string sql = @" select default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time
                            from [default_version]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultVersionData();
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
            string sql = @" select count(*) as count from [default_version]";

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
        
        public static List<CrudeDefaultVersionData> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultVersionData>();

            string sql = @" select default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time
                            from [default_version]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultVersionId != Guid.Empty) {
                        sql += "  and default_version_id = @default_version_id";
                        command.Parameters.Add("@default_version_id", SqlDbType.UniqueIdentifier).Value = defaultVersionId;
                    }
                    if (!string.IsNullOrEmpty(funVersion)) {
                        sql += "  and fun_version like '%' + @fun_version + '%'";
                        command.Parameters.Add("@fun_version", SqlDbType.NVarChar).Value = funVersion.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(number)) {
                        sql += "  and number like '%' + @number + '%'";
                        command.Parameters.Add("@number", SqlDbType.NVarChar).Value = number.Replace("'","''");
                    }
                    if (majorNumber != 0) {
                        sql += "  and major_number = @major_number";
                        command.Parameters.Add("@major_number", SqlDbType.Int).Value = majorNumber;
                    }
                    if (minorNumber != 0) {
                        sql += "  and minor_number = @minor_number";
                        command.Parameters.Add("@minor_number", SqlDbType.Int).Value = minorNumber;
                    }
                    if (sequenceNumber != 0) {
                        sql += "  and sequence_number = @sequence_number";
                        command.Parameters.Add("@sequence_number", SqlDbType.Int).Value = sequenceNumber;
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
                        var data = new CrudeDefaultVersionData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_version_id"] != System.DBNull.Value) DefaultVersionId = (System.Guid) reader["default_version_id"];
            if (reader["fun_version"] != System.DBNull.Value) FunVersion = (System.String) reader["fun_version"];
            if (reader["number"] != System.DBNull.Value) Number = (System.String) reader["number"];
            if (reader["major_number"] != System.DBNull.Value) MajorNumber = (System.Int32) reader["major_number"];
            if (reader["minor_number"] != System.DBNull.Value) MinorNumber = (System.Int32) reader["minor_number"];
            if (reader["sequence_number"] != System.DBNull.Value) SequenceNumber = (System.Int32) reader["sequence_number"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultVersionId == Guid.Empty)
                DefaultVersionId = Guid.NewGuid();

            string sql = "insert into [default_version] (default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time)";
            sql += "            values (@default_version_id, @fun_version, @number, @major_number, @minor_number, @sequence_number, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_version_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultVersionId;
                    command.Parameters.Add("@fun_version",SqlDbType.NVarChar).Value = (System.String)FunVersion;
                    command.Parameters.Add("@number",SqlDbType.NVarChar).Value = (System.String)Number;
                    command.Parameters.Add("@major_number",SqlDbType.Int).Value = (System.Int32)MajorNumber;
                    command.Parameters.Add("@minor_number",SqlDbType.Int).Value = (System.Int32)MinorNumber;
                    command.Parameters.Add("@sequence_number",SqlDbType.Int).Value = (System.Int32)SequenceNumber;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultVersionId == Guid.Empty)
                DefaultVersionId = Guid.NewGuid();

            string sql = "insert into [default_version] (default_version_id, fun_version, number, major_number, minor_number, sequence_number, default_user_id, date_time)";
            sql += "            values (@default_version_id, @fun_version, @number, @major_number, @minor_number, @sequence_number, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_version_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultVersionId;
                command.Parameters.Add("@fun_version",SqlDbType.NVarChar).Value = (System.String)FunVersion;
                command.Parameters.Add("@number",SqlDbType.NVarChar).Value = (System.String)Number;
                command.Parameters.Add("@major_number",SqlDbType.Int).Value = (System.Int32)MajorNumber;
                command.Parameters.Add("@minor_number",SqlDbType.Int).Value = (System.Int32)MinorNumber;
                command.Parameters.Add("@sequence_number",SqlDbType.Int).Value = (System.Int32)SequenceNumber;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_version] set
                 default_version_id = @default_version_id
                ,fun_version = @fun_version
                ,number = @number
                ,major_number = @major_number
                ,minor_number = @minor_number
                ,sequence_number = @sequence_number
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_version_id = @default_version_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_version_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultVersionId;
                    command.Parameters.Add("@fun_version",SqlDbType.NVarChar).Value = (System.String)FunVersion;
                    command.Parameters.Add("@number",SqlDbType.NVarChar).Value = (System.String)Number;
                    command.Parameters.Add("@major_number",SqlDbType.Int).Value = (System.Int32)MajorNumber;
                    command.Parameters.Add("@minor_number",SqlDbType.Int).Value = (System.Int32)MinorNumber;
                    command.Parameters.Add("@sequence_number",SqlDbType.Int).Value = (System.Int32)SequenceNumber;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_version] set
                 default_version_id = @default_version_id
                ,fun_version = @fun_version
                ,number = @number
                ,major_number = @major_number
                ,minor_number = @minor_number
                ,sequence_number = @sequence_number
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_version_id = @default_version_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_version_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultVersionId;
                command.Parameters.Add("@fun_version",SqlDbType.NVarChar).Value = (System.String)FunVersion;
                command.Parameters.Add("@number",SqlDbType.NVarChar).Value = (System.String)Number;
                command.Parameters.Add("@major_number",SqlDbType.Int).Value = (System.Int32)MajorNumber;
                command.Parameters.Add("@minor_number",SqlDbType.Int).Value = (System.Int32)MinorNumber;
                command.Parameters.Add("@sequence_number",SqlDbType.Int).Value = (System.Int32)SequenceNumber;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultVersionId) {
            string sql = @" delete [default_version] 
                where default_version_id = @default_version_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_version_id",SqlDbType.UniqueIdentifier).Value = defaultVersionId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
