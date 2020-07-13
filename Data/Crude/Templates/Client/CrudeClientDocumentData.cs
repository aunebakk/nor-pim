/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 9:06:14 AM
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
    public partial class CrudeClientDocumentData {
        
        public System.Guid ClientDocumentId { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public string ClientDocumentTypeRcd { get; set; }
        
        public string DocumentName { get; set; }
        
        public System.DateTime DocumentDateTime { get; set; }
        
        public System.DateTime ExpiryDateTime { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByClientDocumentId(System.Guid clientDocumentId) {
            string sql = @" select top 1 client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            where client_document_id = @client_document_id
                            order by document_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_document_id",SqlDbType.UniqueIdentifier).Value = clientDocumentId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientDocumentData GetByClientDocumentId(System.Guid clientDocumentId) {
            string sql = @" select top 1 client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            where client_document_id = @client_document_id
                            order by document_name";

            var ret = new CrudeClientDocumentData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_document_id",SqlDbType.UniqueIdentifier).Value = clientDocumentId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientDocumentData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientDocumentData>();

            string sql = @" select client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            where client_id = @client_id
                              
                            order by document_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientDocumentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientDocumentData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientDocumentData>();

            string sql = @" select client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            where user_id = @user_id
                              
                            order by document_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientDocumentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientDocumentData> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            var dataList = new List<CrudeClientDocumentData>();

            string sql = @" select client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            where client_document_type_rcd = @client_document_type_rcd
                              
                            order by document_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_document_type_rcd", SqlDbType.NVarChar).Value = clientDocumentTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientDocumentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDocumentName(string documentName) {
            string sql = @" select top 1 client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            where document_name like '%' + @documentName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@documentName",SqlDbType.NVarChar).Value = documentName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeClientDocumentData> FetchAll() {
            var dataList = new List<CrudeClientDocumentData>();

            string sql = @" select client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            order by document_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientDocumentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientDocumentData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientDocumentData>();

            string sql = @" select top " + limit.ToString() + @" client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            order by document_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientDocumentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientDocumentData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientDocumentData>();

            string sql = @" select client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            order by document_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientDocumentData();
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
            string sql = @" select count(*) as count from [client_document]";

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
        
        public static List<CrudeClientDocumentData> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientDocumentData>();

            string sql = @" select client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time
                            from [client_document]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (clientDocumentId != Guid.Empty) {
                        sql += "  and client_document_id = @client_document_id";
                        command.Parameters.Add("@client_document_id", SqlDbType.UniqueIdentifier).Value = clientDocumentId;
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    if (!string.IsNullOrEmpty(clientDocumentTypeRcd)) {
                        sql += "  and client_document_type_rcd like '%' + @client_document_type_rcd + '%'";
                        command.Parameters.Add("@client_document_type_rcd", SqlDbType.NVarChar).Value = clientDocumentTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(documentName)) {
                        sql += "  and document_name like '%' + @document_name + '%'";
                        command.Parameters.Add("@document_name", SqlDbType.NVarChar).Value = documentName.Replace("'","''");
                    }
                    if (documentDateTime != DateTime.MinValue) {
                        sql += "  and document_date_time = @document_date_time";
                        command.Parameters.Add("@document_date_time", SqlDbType.DateTime).Value = documentDateTime;
                    }
                    if (expiryDateTime != DateTime.MinValue) {
                        sql += "  and expiry_date_time = @expiry_date_time";
                        command.Parameters.Add("@expiry_date_time", SqlDbType.DateTime).Value = expiryDateTime;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by document_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientDocumentData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_document_id"] != System.DBNull.Value) ClientDocumentId = (System.Guid) reader["client_document_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_document_type_rcd"] != System.DBNull.Value) ClientDocumentTypeRcd = (System.String) reader["client_document_type_rcd"];
            if (reader["document_name"] != System.DBNull.Value) DocumentName = (System.String) reader["document_name"];
            if (reader["document_date_time"] != System.DBNull.Value) DocumentDateTime = (System.DateTime) reader["document_date_time"];
            if (reader["expiry_date_time"] != System.DBNull.Value) ExpiryDateTime = (System.DateTime) reader["expiry_date_time"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ClientDocumentId == Guid.Empty)
                ClientDocumentId = Guid.NewGuid();

            string sql = "insert into [client_document] (client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time)";
            sql += "            values (@client_document_id, @client_id, @client_document_type_rcd, @document_name, @document_date_time, @expiry_date_time, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_document_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientDocumentId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_document_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientDocumentTypeRcd;
                    command.Parameters.Add("@document_name",SqlDbType.NVarChar).Value = (System.String)DocumentName;
                    command.Parameters.Add("@document_date_time",SqlDbType.DateTime).Value = (System.DateTime)DocumentDateTime;
                    command.Parameters.Add("@expiry_date_time",SqlDbType.DateTime).Value = (System.DateTime)ExpiryDateTime;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientDocumentId == Guid.Empty)
                ClientDocumentId = Guid.NewGuid();

            string sql = "insert into [client_document] (client_document_id, client_id, client_document_type_rcd, document_name, document_date_time, expiry_date_time, user_id, date_time)";
            sql += "            values (@client_document_id, @client_id, @client_document_type_rcd, @document_name, @document_date_time, @expiry_date_time, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_document_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientDocumentId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_document_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientDocumentTypeRcd;
                command.Parameters.Add("@document_name",SqlDbType.NVarChar).Value = (System.String)DocumentName;
                command.Parameters.Add("@document_date_time",SqlDbType.DateTime).Value = (System.DateTime)DocumentDateTime;
                command.Parameters.Add("@expiry_date_time",SqlDbType.DateTime).Value = (System.DateTime)ExpiryDateTime;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [client_document] set
                 client_document_id = @client_document_id
                ,client_id = @client_id
                ,client_document_type_rcd = @client_document_type_rcd
                ,document_name = @document_name
                ,document_date_time = @document_date_time
                ,expiry_date_time = @expiry_date_time
                ,user_id = @user_id
                ,date_time = @date_time
            where client_document_id = @client_document_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_document_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientDocumentId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_document_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientDocumentTypeRcd;
                    command.Parameters.Add("@document_name",SqlDbType.NVarChar).Value = (System.String)DocumentName;
                    command.Parameters.Add("@document_date_time",SqlDbType.DateTime).Value = (System.DateTime)DocumentDateTime;
                    command.Parameters.Add("@expiry_date_time",SqlDbType.DateTime).Value = (System.DateTime)ExpiryDateTime;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_document] set
                 client_document_id = @client_document_id
                ,client_id = @client_id
                ,client_document_type_rcd = @client_document_type_rcd
                ,document_name = @document_name
                ,document_date_time = @document_date_time
                ,expiry_date_time = @expiry_date_time
                ,user_id = @user_id
                ,date_time = @date_time
            where client_document_id = @client_document_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_document_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientDocumentId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_document_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientDocumentTypeRcd;
                command.Parameters.Add("@document_name",SqlDbType.NVarChar).Value = (System.String)DocumentName;
                command.Parameters.Add("@document_date_time",SqlDbType.DateTime).Value = (System.DateTime)DocumentDateTime;
                command.Parameters.Add("@expiry_date_time",SqlDbType.DateTime).Value = (System.DateTime)ExpiryDateTime;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid clientDocumentId) {
            string sql = @" delete [client_document] 
                where client_document_id = @client_document_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_document_id",SqlDbType.UniqueIdentifier).Value = clientDocumentId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
