/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:19:17 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeDefaultResourceMeasurementData {
        
        public System.Guid DefaultResourceMeasurementId { get; set; } //;
        
        public int ClientWorkingsetBytes { get; set; } //;
        
        public int BusinessWorkingsetBytes { get; set; } //;
        
        public int DatabaseSizeBytes { get; set; } //;
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultResourceMeasurementId(System.Guid defaultResourceMeasurementId) {
            string sql = @" select top 1 default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time
                            from [default_resource_measurement]
                            where default_resource_measurement_id = @default_resource_measurement_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_resource_measurement_id",SqlDbType.UniqueIdentifier).Value = defaultResourceMeasurementId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultResourceMeasurementData GetByDefaultResourceMeasurementId(System.Guid defaultResourceMeasurementId) {
            string sql = @" select top 1 default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time
                            from [default_resource_measurement]
                            where default_resource_measurement_id = @default_resource_measurement_id";

            var ret = new CrudeDefaultResourceMeasurementData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_resource_measurement_id",SqlDbType.UniqueIdentifier).Value = defaultResourceMeasurementId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultResourceMeasurementData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultResourceMeasurementData>();

            string sql = @" select default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time
                            from [default_resource_measurement]
                            where default_user_id = @default_user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultResourceMeasurementData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultResourceMeasurementData> FetchAll() {
            var dataList = new List<CrudeDefaultResourceMeasurementData>();

            string sql = @" select default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time
                            from [default_resource_measurement]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultResourceMeasurementData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultResourceMeasurementData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultResourceMeasurementData>();

            string sql = @" select top " + limit.ToString() + @" default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time
                            from [default_resource_measurement]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultResourceMeasurementData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultResourceMeasurementData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultResourceMeasurementData>();

            string sql = @" select default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time
                            from [default_resource_measurement]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultResourceMeasurementData();
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
            string sql = @" select count(*) as count from [default_resource_measurement]";

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
        
        public static List<CrudeDefaultResourceMeasurementData> FetchWithFilter(System.Guid defaultResourceMeasurementId, int clientWorkingsetBytes, int businessWorkingsetBytes, int databaseSizeBytes, System.Guid defaultUserId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultResourceMeasurementData>();

            string sql = @" select default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time
                            from [default_resource_measurement]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultResourceMeasurementId != Guid.Empty) {
                        sql += "  and default_resource_measurement_id = @default_resource_measurement_id";
                        command.Parameters.Add("@default_resource_measurement_id", SqlDbType.UniqueIdentifier).Value = defaultResourceMeasurementId;
                    }
                    if (clientWorkingsetBytes != 0) {
                        sql += "  and client_workingset_bytes = @client_workingset_bytes";
                        command.Parameters.Add("@client_workingset_bytes", SqlDbType.Int).Value = clientWorkingsetBytes;
                    }
                    if (businessWorkingsetBytes != 0) {
                        sql += "  and business_workingset_bytes = @business_workingset_bytes";
                        command.Parameters.Add("@business_workingset_bytes", SqlDbType.Int).Value = businessWorkingsetBytes;
                    }
                    if (databaseSizeBytes != 0) {
                        sql += "  and database_size_bytes = @database_size_bytes";
                        command.Parameters.Add("@database_size_bytes", SqlDbType.Int).Value = databaseSizeBytes;
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
                        var data = new CrudeDefaultResourceMeasurementData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_resource_measurement_id"] != System.DBNull.Value) DefaultResourceMeasurementId = (System.Guid) reader["default_resource_measurement_id"];
            if (reader["client_workingset_bytes"] != System.DBNull.Value) ClientWorkingsetBytes = (System.Int32) reader["client_workingset_bytes"];
            if (reader["business_workingset_bytes"] != System.DBNull.Value) BusinessWorkingsetBytes = (System.Int32) reader["business_workingset_bytes"];
            if (reader["database_size_bytes"] != System.DBNull.Value) DatabaseSizeBytes = (System.Int32) reader["database_size_bytes"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultResourceMeasurementId == Guid.Empty)
                DefaultResourceMeasurementId = Guid.NewGuid();

            string sql = "insert into [default_resource_measurement] (default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time)";
            sql += "            values (@default_resource_measurement_id, @client_workingset_bytes, @business_workingset_bytes, @database_size_bytes, @default_user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_resource_measurement_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultResourceMeasurementId;
                    command.Parameters.Add("@client_workingset_bytes",SqlDbType.Int).Value = (ClientWorkingsetBytes == 0 ? (object)DBNull.Value : (System.Int32)ClientWorkingsetBytes);
                    command.Parameters.Add("@business_workingset_bytes",SqlDbType.Int).Value = (BusinessWorkingsetBytes == 0 ? (object)DBNull.Value : (System.Int32)BusinessWorkingsetBytes);
                    command.Parameters.Add("@database_size_bytes",SqlDbType.Int).Value = (DatabaseSizeBytes == 0 ? (object)DBNull.Value : (System.Int32)DatabaseSizeBytes);
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultResourceMeasurementId == Guid.Empty)
                DefaultResourceMeasurementId = Guid.NewGuid();

            string sql = "insert into [default_resource_measurement] (default_resource_measurement_id, client_workingset_bytes, business_workingset_bytes, database_size_bytes, default_user_id, date_time)";
            sql += "            values (@default_resource_measurement_id, @client_workingset_bytes, @business_workingset_bytes, @database_size_bytes, @default_user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_resource_measurement_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultResourceMeasurementId;
                command.Parameters.Add("@client_workingset_bytes",SqlDbType.Int).Value = (ClientWorkingsetBytes == 0 ? (object)DBNull.Value : (System.Int32)ClientWorkingsetBytes);
                command.Parameters.Add("@business_workingset_bytes",SqlDbType.Int).Value = (BusinessWorkingsetBytes == 0 ? (object)DBNull.Value : (System.Int32)BusinessWorkingsetBytes);
                command.Parameters.Add("@database_size_bytes",SqlDbType.Int).Value = (DatabaseSizeBytes == 0 ? (object)DBNull.Value : (System.Int32)DatabaseSizeBytes);
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_resource_measurement] set
                 default_resource_measurement_id = @default_resource_measurement_id
                ,client_workingset_bytes = @client_workingset_bytes
                ,business_workingset_bytes = @business_workingset_bytes
                ,database_size_bytes = @database_size_bytes
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_resource_measurement_id = @default_resource_measurement_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_resource_measurement_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultResourceMeasurementId;
                    command.Parameters.Add("@client_workingset_bytes",SqlDbType.Int).Value = (ClientWorkingsetBytes == 0 ? (object)DBNull.Value : (System.Int32)ClientWorkingsetBytes);
                    command.Parameters.Add("@business_workingset_bytes",SqlDbType.Int).Value = (BusinessWorkingsetBytes == 0 ? (object)DBNull.Value : (System.Int32)BusinessWorkingsetBytes);
                    command.Parameters.Add("@database_size_bytes",SqlDbType.Int).Value = (DatabaseSizeBytes == 0 ? (object)DBNull.Value : (System.Int32)DatabaseSizeBytes);
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_resource_measurement] set
                 default_resource_measurement_id = @default_resource_measurement_id
                ,client_workingset_bytes = @client_workingset_bytes
                ,business_workingset_bytes = @business_workingset_bytes
                ,database_size_bytes = @database_size_bytes
                ,default_user_id = @default_user_id
                ,date_time = @date_time
            where default_resource_measurement_id = @default_resource_measurement_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_resource_measurement_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultResourceMeasurementId;
                command.Parameters.Add("@client_workingset_bytes",SqlDbType.Int).Value = (ClientWorkingsetBytes == 0 ? (object)DBNull.Value : (System.Int32)ClientWorkingsetBytes);
                command.Parameters.Add("@business_workingset_bytes",SqlDbType.Int).Value = (BusinessWorkingsetBytes == 0 ? (object)DBNull.Value : (System.Int32)BusinessWorkingsetBytes);
                command.Parameters.Add("@database_size_bytes",SqlDbType.Int).Value = (DatabaseSizeBytes == 0 ? (object)DBNull.Value : (System.Int32)DatabaseSizeBytes);
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultResourceMeasurementId) {
            string sql = @" delete [default_resource_measurement] 
                where default_resource_measurement_id = @default_resource_measurement_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_resource_measurement_id",SqlDbType.UniqueIdentifier).Value = defaultResourceMeasurementId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
