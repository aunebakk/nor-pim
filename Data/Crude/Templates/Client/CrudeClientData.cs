/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:06:57 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//   https://en.wikipedia.org/wiki/Data_access_layer: data access layer
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of client's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeClientData {
        
        public System.Guid ClientId { get; set; }
        
        public string ClientTypeRcd { get; set; }
        
        public string ClientNationalityRcd { get; set; }
        
        public string ClientGenderRcd { get; set; }
        
        public string ClientTitleRcd { get; set; }
        
        public System.Guid ClientAddressId { get; set; }
        
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        public string LastName { get; set; }
        
        public byte[] Image { get; set; }
        
        public string ImageBlobFilename { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientId: primary key of table client
        public void FetchByClientId(System.Guid clientId) {
            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_id = @client_id
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked
                //   as locked by another database transaction
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = clientId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientId: primary key of table client
        public static CrudeClientData GetByClientId(System.Guid clientId) {
            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_id = @client_id
                            order by first_name";

            var ret = new CrudeClientData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = clientId;

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if a row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientData> FetchByClientAddressId(System.Guid clientAddressId) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_address_id = @client_address_id
                              
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_address_id", SqlDbType.UniqueIdentifier).Value = clientAddressId;

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where user_id = @user_id
                              
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientData> FetchByClientTypeRcd(string clientTypeRcd) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_type_rcd = @client_type_rcd
                              
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_type_rcd", SqlDbType.NVarChar).Value = clientTypeRcd.Replace("'","''");

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientData> FetchByClientNationalityRcd(string clientNationalityRcd) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_nationality_rcd = @client_nationality_rcd
                              
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_nationality_rcd", SqlDbType.NVarChar).Value = clientNationalityRcd.Replace("'","''");

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientData> FetchByClientGenderRcd(string clientGenderRcd) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_gender_rcd = @client_gender_rcd
                              
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_gender_rcd", SqlDbType.NVarChar).Value = clientGenderRcd.Replace("'","''");

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientData> FetchByClientTitleRcd(string clientTitleRcd) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where client_title_rcd = @client_title_rcd
                              
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_title_rcd", SqlDbType.NVarChar).Value = clientTitleRcd.Replace("'","''");

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByFirstName(string firstName) {
            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where first_name like '%' + @firstName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                command.Parameters.Add("@firstName",SqlDbType.NVarChar).Value = firstName;

                // execute query against client
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all rows from table client into new List of class instances
        public static List<CrudeClientData> FetchAll() {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeClientData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeClientData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            order by first_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
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
        
        // get a count of rows in table
        public static int FetchAllCount() {
            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [client]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public static List<CrudeClientData> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientData>();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time
                            from [client]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
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

                    // execute query against client
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
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
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ClientId == Guid.Empty)
                ClientId = Guid.NewGuid();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [client] (client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time)";
            sql += "            values (@client_id, @client_type_rcd, @client_nationality_rcd, @client_gender_rcd, @client_title_rcd, @client_address_id, @first_name, @middle_name, @last_name, @image, @image_blob_filename, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
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
                    // execute query against client
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientId == Guid.Empty)
                ClientId = Guid.NewGuid();

            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [client] (client_id, client_type_rcd, client_nationality_rcd, client_gender_rcd, client_title_rcd, client_address_id, first_name, middle_name, last_name, image, image_blob_filename, user_id, date_time)";
            sql += "            values (@client_id, @client_type_rcd, @client_nationality_rcd, @client_gender_rcd, @client_title_rcd, @client_address_id, @first_name, @middle_name, @last_name, @image, @image_blob_filename, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
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
                // execute query against client
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
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
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
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
                    // execute query against client
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
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
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
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
                // execute query against client
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid clientId) {
            // create query against client
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [client] 
                where client_id = @client_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = clientId;
                    // execute query against client
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
