/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:35:24 AM
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
    public partial class CrudeClientIdentifierData {
        
        public System.Guid ClientIdentifierId { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public string ClientIdentifierTypeRcd { get; set; }
        
        public string ClientIdentifierCode { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // parameters:
        //   clientIdentifierId: primary key of table client_identifier
        public void FetchByClientIdentifierId(System.Guid clientIdentifierId) {
            // create query
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            where client_identifier_id = @client_identifier_id
                            order by client_identifier_code";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked as locked by another transaction
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_identifier_id",SqlDbType.UniqueIdentifier).Value = clientIdentifierId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        public static CrudeClientIdentifierData GetByClientIdentifierId(System.Guid clientIdentifierId) {
            string sql = @" select top 1 client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            where client_identifier_id = @client_identifier_id
                            order by client_identifier_code";

            var ret = new CrudeClientIdentifierData();

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_identifier_id",SqlDbType.UniqueIdentifier).Value = clientIdentifierId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientIdentifierData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientIdentifierData>();

            string sql = @" select client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            where client_id = @client_id
                              
                            order by client_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientIdentifierData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientIdentifierData>();

            string sql = @" select client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            where user_id = @user_id
                              
                            order by client_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientIdentifierData> FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            var dataList = new List<CrudeClientIdentifierData>();

            string sql = @" select client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            where client_identifier_type_rcd = @client_identifier_type_rcd
                              
                            order by client_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_identifier_type_rcd", SqlDbType.NVarChar).Value = clientIdentifierTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances
        public static List<CrudeClientIdentifierData> FetchAll() {
            var dataList = new List<CrudeClientIdentifierData>();

            string sql = @" select client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            order by client_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeClientIdentifierData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientIdentifierData>();

            string sql = @" select top " + limit.ToString() + @" client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            order by client_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns , with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeClientIdentifierData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientIdentifierData>();

            string sql = @" select client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            order by client_identifier_code";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientIdentifierData();
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
        
        // get a count of rows in table
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [client_identifier]";

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
        
        // fetch all from table into new List of class instances, filtered by any column
        public static List<CrudeClientIdentifierData> FetchWithFilter(System.Guid clientIdentifierId, System.Guid clientId, string clientIdentifierTypeRcd, string clientIdentifierCode, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientIdentifierData>();

            string sql = @" select client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time
                            from [client_identifier]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (clientIdentifierId != Guid.Empty) {
                        sql += "  and client_identifier_id = @client_identifier_id";
                        command.Parameters.Add("@client_identifier_id", SqlDbType.UniqueIdentifier).Value = clientIdentifierId;
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    if (!string.IsNullOrEmpty(clientIdentifierTypeRcd)) {
                        sql += "  and client_identifier_type_rcd like '%' + @client_identifier_type_rcd + '%'";
                        command.Parameters.Add("@client_identifier_type_rcd", SqlDbType.NVarChar).Value = clientIdentifierTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientIdentifierCode)) {
                        sql += "  and client_identifier_code like '%' + @client_identifier_code + '%'";
                        command.Parameters.Add("@client_identifier_code", SqlDbType.NVarChar).Value = clientIdentifierCode.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by client_identifier_code";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientIdentifierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["client_identifier_id"] != System.DBNull.Value) ClientIdentifierId = (System.Guid) reader["client_identifier_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_identifier_type_rcd"] != System.DBNull.Value) ClientIdentifierTypeRcd = (System.String) reader["client_identifier_type_rcd"];
            if (reader["client_identifier_code"] != System.DBNull.Value) ClientIdentifierCode = (System.String) reader["client_identifier_code"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ClientIdentifierId == Guid.Empty)
                ClientIdentifierId = Guid.NewGuid();

            string sql = "insert into [client_identifier] (client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time)";
            sql += "            values (@client_identifier_id, @client_id, @client_identifier_type_rcd, @client_identifier_code, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientIdentifierId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientIdentifierTypeRcd;
                    command.Parameters.Add("@client_identifier_code",SqlDbType.NVarChar).Value = (System.String)ClientIdentifierCode;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientIdentifierId == Guid.Empty)
                ClientIdentifierId = Guid.NewGuid();

            string sql = "insert into [client_identifier] (client_identifier_id, client_id, client_identifier_type_rcd, client_identifier_code, user_id, date_time)";
            sql += "            values (@client_identifier_id, @client_id, @client_identifier_type_rcd, @client_identifier_code, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientIdentifierId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientIdentifierTypeRcd;
                command.Parameters.Add("@client_identifier_code",SqlDbType.NVarChar).Value = (System.String)ClientIdentifierCode;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            string sql = @" update [client_identifier] set
                 client_identifier_id = @client_identifier_id
                ,client_id = @client_id
                ,client_identifier_type_rcd = @client_identifier_type_rcd
                ,client_identifier_code = @client_identifier_code
                ,user_id = @user_id
                ,date_time = @date_time
            where client_identifier_id = @client_identifier_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientIdentifierId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientIdentifierTypeRcd;
                    command.Parameters.Add("@client_identifier_code",SqlDbType.NVarChar).Value = (System.String)ClientIdentifierCode;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_identifier] set
                 client_identifier_id = @client_identifier_id
                ,client_id = @client_id
                ,client_identifier_type_rcd = @client_identifier_type_rcd
                ,client_identifier_code = @client_identifier_code
                ,user_id = @user_id
                ,date_time = @date_time
            where client_identifier_id = @client_identifier_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_identifier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientIdentifierId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientIdentifierTypeRcd;
                command.Parameters.Add("@client_identifier_code",SqlDbType.NVarChar).Value = (System.String)ClientIdentifierCode;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid clientIdentifierId) {
            string sql = @" delete [client_identifier] 
                where client_identifier_id = @client_identifier_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_identifier_id",SqlDbType.UniqueIdentifier).Value = clientIdentifierId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
