/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:24 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeClientData {
        
        public System.Guid ClientId { get; set; } //;
        
        public string ClientTypeRcd { get; set; } //;
        
        public string ClientNationalityRcd { get; set; } //;
        
        public string ClientGenderRcd { get; set; } //;
        
        public string ClientTitleRcd { get; set; } //;
        
        public System.Guid ClientAddressId { get; set; } //;
        
        public string FirstName { get; set; } //;
        
        public string MiddleName { get; set; } //;
        
        public string LastName { get; set; } //;
        
        public byte[] Image { get; set; } //;
        
        public string ImageBlobFilename { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientId(System.Guid clientId) {
            string sql = @" select top 1 client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_id = @client_id
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = clientId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientData GetByClientId(System.Guid clientId) {
            string sql = @" select top 1 client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_id = @client_id
                            order by first_name";

            var ret = new CrudeClientData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientData> FetchByClientAddressId(System.Guid clientAddressId) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_address_id = @client_address_id
                              
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_address_id", SqlDbType.UniqueIdentifier).Value = clientAddressId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where user_id = @user_id
                              
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientData> FetchByClientTypeRcd(string clientTypeRcd) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_type_rcd = @client_type_rcd
                              
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_type_rcd", SqlDbType.NVarChar).Value = clientTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientData> FetchByClientNationalityRcd(string clientNationalityRcd) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_nationality_rcd = @client_nationality_rcd
                              
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_nationality_rcd", SqlDbType.NVarChar).Value = clientNationalityRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientData> FetchByClientGenderRcd(string clientGenderRcd) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_gender_rcd = @client_gender_rcd
                              
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_gender_rcd", SqlDbType.NVarChar).Value = clientGenderRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientData> FetchByClientTitleRcd(string clientTitleRcd) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_title_rcd = @client_title_rcd
                              
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_title_rcd", SqlDbType.NVarChar).Value = clientTitleRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFirstName(string firstName) {
            string sql = @" select top 1 client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where first_name like '%' + @firstName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@firstName",SqlDbType.NVarChar).Value = firstName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeClientData> FetchAll() {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select top " + limit.ToString() + @" client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            order by first_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientData();
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
            string sql = @" select count(*) as count from [client]";

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
        
        public static List<CrudeClientData> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientData>();

            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    if (!string.IsNullOrEmpty(clientTypeRcd)) {
                        sql += "  and client_type_rcd like '%' + @client_type_rcd + '%'";
                        command.Parameters.Add("@client_type_rcd", SqlDbType.NVarChar).Value = clientTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientNationalityRcd)) {
                        sql += "  and client_nationality_rcd like '%' + @client_nationality_rcd + '%'";
                        command.Parameters.Add("@client_nationality_rcd", SqlDbType.NVarChar).Value = clientNationalityRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientGenderRcd)) {
                        sql += "  and client_gender_rcd like '%' + @client_gender_rcd + '%'";
                        command.Parameters.Add("@client_gender_rcd", SqlDbType.NVarChar).Value = clientGenderRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientTitleRcd)) {
                        sql += "  and client_title_rcd like '%' + @client_title_rcd + '%'";
                        command.Parameters.Add("@client_title_rcd", SqlDbType.NVarChar).Value = clientTitleRcd.Replace("'","''");
                    }
                    if (clientAddressId != Guid.Empty) {
                        sql += "  and client_address_id = @client_address_id";
                        command.Parameters.Add("@client_address_id", SqlDbType.UniqueIdentifier).Value = clientAddressId;
                    }
                    if (!string.IsNullOrEmpty(firstName)) {
                        sql += "  and first_name like '%' + @first_name + '%'";
                        command.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = firstName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(middleName)) {
                        sql += "  and middle_name like '%' + @middle_name + '%'";
                        command.Parameters.Add("@middle_name", SqlDbType.NVarChar).Value = middleName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(lastName)) {
                        sql += "  and last_name like '%' + @last_name + '%'";
                        command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = lastName.Replace("'","''");
                    }
                    if (image != null) {
                        sql += "  and image = @image";
                        command.Parameters.Add("@image", SqlDbType.VarBinary).Value = image;
                    }
                    if (!string.IsNullOrEmpty(imageBlobFilename)) {
                        sql += "  and image_blob_filename like '%' + @image_blob_filename + '%'";
                        command.Parameters.Add("@image_blob_filename", SqlDbType.NVarChar).Value = imageBlobFilename.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by first_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_type_rcd"] != System.DBNull.Value) ClientTypeRcd = (System.String) reader["client_type_rcd"];
            if (reader["client_nationality_rcd"] != System.DBNull.Value) ClientNationalityRcd = (System.String) reader["client_nationality_rcd"];
            if (reader["client_gender_rcd"] != System.DBNull.Value) ClientGenderRcd = (System.String) reader["client_gender_rcd"];
            if (reader["client_title_rcd"] != System.DBNull.Value) ClientTitleRcd = (System.String) reader["client_title_rcd"];
            if (reader["client_address_id"] != System.DBNull.Value) ClientAddressId = (System.Guid) reader["client_address_id"];
            if (reader["first_name"] != System.DBNull.Value) FirstName = (System.String) reader["first_name"];
            if (reader["middle_name"] != System.DBNull.Value) MiddleName = (System.String) reader["middle_name"];
            if (reader["last_name"] != System.DBNull.Value) LastName = (System.String) reader["last_name"];
            if (reader["image"] != System.DBNull.Value) Image = (System.Byte[]) reader["image"];
            if (reader["image_blob_filename"] != System.DBNull.Value) ImageBlobFilename = (System.String) reader["image_blob_filename"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ClientId == Guid.Empty)
                ClientId = Guid.NewGuid();

            string sql = "insert into [client] (client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time)";
            sql += "            values (@client_id, @client_type_rcd, @client_nationality_rcd, @client_gender_rcd, @client_title_rcd, @client_address_id, @first_name, @middle_name, @last_name, @image, @image_blob_filename, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientTypeRcd;
                    command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientNationalityRcd)) ? (object)DBNull.Value : (System.String)ClientNationalityRcd;
                    command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientGenderRcd)) ? (object)DBNull.Value : (System.String)ClientGenderRcd;
                    command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientTitleRcd)) ? (object)DBNull.Value : (System.String)ClientTitleRcd;
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = (ClientAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientAddressId);
                    command.Parameters.Add("@first_name",SqlDbType.NVarChar).Value = (System.String)FirstName;
                    command.Parameters.Add("@middle_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(MiddleName)) ? (object)DBNull.Value : (System.String)MiddleName;
                    command.Parameters.Add("@last_name",SqlDbType.NVarChar).Value = (System.String)LastName;
                    command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                    command.Parameters.Add("@image_blob_filename",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ImageBlobFilename)) ? (object)DBNull.Value : (System.String)ImageBlobFilename;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientId == Guid.Empty)
                ClientId = Guid.NewGuid();

            string sql = "insert into [client] (client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time)";
            sql += "            values (@client_id, @client_type_rcd, @client_nationality_rcd, @client_gender_rcd, @client_title_rcd, @client_address_id, @first_name, @middle_name, @last_name, @image, @image_blob_filename, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientTypeRcd;
                command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientNationalityRcd)) ? (object)DBNull.Value : (System.String)ClientNationalityRcd;
                command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientGenderRcd)) ? (object)DBNull.Value : (System.String)ClientGenderRcd;
                command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientTitleRcd)) ? (object)DBNull.Value : (System.String)ClientTitleRcd;
                command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = (ClientAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientAddressId);
                command.Parameters.Add("@first_name",SqlDbType.NVarChar).Value = (System.String)FirstName;
                command.Parameters.Add("@middle_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(MiddleName)) ? (object)DBNull.Value : (System.String)MiddleName;
                command.Parameters.Add("@last_name",SqlDbType.NVarChar).Value = (System.String)LastName;
                command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                command.Parameters.Add("@image_blob_filename",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ImageBlobFilename)) ? (object)DBNull.Value : (System.String)ImageBlobFilename;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [client] set
                 client_id = @client_id
                ,client_type_rcd = @client_type_rcd
                ,client_nationality_rcd = @client_nationality_rcd
                ,client_gender_rcd = @client_gender_rcd
                ,client_title_rcd = @client_title_rcd
                ,client_address_id = @client_address_id
                ,first_name = @first_name
                ,middle_name = @middle_name
                ,last_name = @last_name
                ,image = @image
                ,image_blob_filename = @image_blob_filename
                ,user_id = @user_id
                ,date_time = @date_time
            where client_id = @client_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                    command.Parameters.Add("@client_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientTypeRcd;
                    command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientNationalityRcd)) ? (object)DBNull.Value : (System.String)ClientNationalityRcd;
                    command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientGenderRcd)) ? (object)DBNull.Value : (System.String)ClientGenderRcd;
                    command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientTitleRcd)) ? (object)DBNull.Value : (System.String)ClientTitleRcd;
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = (ClientAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientAddressId);
                    command.Parameters.Add("@first_name",SqlDbType.NVarChar).Value = (System.String)FirstName;
                    command.Parameters.Add("@middle_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(MiddleName)) ? (object)DBNull.Value : (System.String)MiddleName;
                    command.Parameters.Add("@last_name",SqlDbType.NVarChar).Value = (System.String)LastName;
                    command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                    command.Parameters.Add("@image_blob_filename",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ImageBlobFilename)) ? (object)DBNull.Value : (System.String)ImageBlobFilename;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client] set
                 client_id = @client_id
                ,client_type_rcd = @client_type_rcd
                ,client_nationality_rcd = @client_nationality_rcd
                ,client_gender_rcd = @client_gender_rcd
                ,client_title_rcd = @client_title_rcd
                ,client_address_id = @client_address_id
                ,first_name = @first_name
                ,middle_name = @middle_name
                ,last_name = @last_name
                ,image = @image
                ,image_blob_filename = @image_blob_filename
                ,user_id = @user_id
                ,date_time = @date_time
            where client_id = @client_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientId;
                command.Parameters.Add("@client_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientTypeRcd;
                command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientNationalityRcd)) ? (object)DBNull.Value : (System.String)ClientNationalityRcd;
                command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientGenderRcd)) ? (object)DBNull.Value : (System.String)ClientGenderRcd;
                command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientTitleRcd)) ? (object)DBNull.Value : (System.String)ClientTitleRcd;
                command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = (ClientAddressId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientAddressId);
                command.Parameters.Add("@first_name",SqlDbType.NVarChar).Value = (System.String)FirstName;
                command.Parameters.Add("@middle_name",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(MiddleName)) ? (object)DBNull.Value : (System.String)MiddleName;
                command.Parameters.Add("@last_name",SqlDbType.NVarChar).Value = (System.String)LastName;
                command.Parameters.Add("@image",SqlDbType.VarBinary).Value = (Image == null ? (object)DBNull.Value : (System.Byte[])Image);
                command.Parameters.Add("@image_blob_filename",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ImageBlobFilename)) ? (object)DBNull.Value : (System.String)ImageBlobFilename;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid clientId) {
            string sql = @" delete [client] 
                where client_id = @client_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = clientId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
