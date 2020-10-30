/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 4:37:34 AM
  From Machine: DESKTOP-9A2DH39
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
    // this class start with an identical representation of client_address's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeClientAddressData {
        
        public System.Guid ClientAddressId { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public string ClientAddressTypeRcd { get; set; }
        
        public string AddressLineOneName { get; set; }
        
        public string AddressLineTwoName { get; set; }
        
        public string AddressLineThreeName { get; set; }
        
        public string CityName { get; set; }
        
        public string StreetName { get; set; }
        
        public string StateName { get; set; }
        
        public string DistrictName { get; set; }
        
        public string ProvinceName { get; set; }
        
        public string ZipCode { get; set; }
        
        public string PoBox { get; set; }
        
        public string Comment { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientAddressId: primary key of table client_address
        public void FetchByClientAddressId(System.Guid clientAddressId) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_id = @client_address_id
                            order by address_line_one_name";

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
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;

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
        //   clientAddressId: primary key of table client_address
        public static CrudeClientAddressData GetByClientAddressId(System.Guid clientAddressId) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_id = @client_address_id
                            order by address_line_one_name";

            var ret = new CrudeClientAddressData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;

                    // execute query against client_address
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
        public static List<CrudeClientAddressData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_id = @client_id
                              
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientAddressData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where user_id = @user_id
                              
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeClientAddressData> FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_type_rcd = @client_address_type_rcd
                              
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_address_type_rcd", SqlDbType.NVarChar).Value = clientAddressTypeRcd.Replace("'","''");

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByAddressLineOneName(string addressLineOneName) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where address_line_one_name like '%' + @addressLineOneName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                command.Parameters.Add("@addressLineOneName",SqlDbType.NVarChar).Value = addressLineOneName;

                // execute query against client_address
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all rows from table client_address into new List of class instances
        public static List<CrudeClientAddressData> FetchAll() {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeClientAddressData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeClientAddressData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientAddressData();
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
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [client_address]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against client_address
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
        public static List<CrudeClientAddressData> FetchWithFilter(
                    System.Guid clientAddressId, 
                    System.Guid clientId, 
                    string clientAddressTypeRcd, 
                    string addressLineOneName, 
                    string addressLineTwoName, 
                    string addressLineThreeName, 
                    string cityName, 
                    string streetName, 
                    string stateName, 
                    string districtName, 
                    string provinceName, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (clientAddressId != Guid.Empty) {
                        sql += "  and client_address_id = @client_address_id";
                        command.Parameters.Add("@client_address_id", SqlDbType.UniqueIdentifier).Value = clientAddressId;
                    }
                    if (clientId != Guid.Empty) {
                        sql += "  and client_id = @client_id";
                        command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;
                    }
                    if (!string.IsNullOrEmpty(clientAddressTypeRcd)) {
                        sql += "  and client_address_type_rcd like '%' + @client_address_type_rcd + '%'";
                        command.Parameters.Add("@client_address_type_rcd", SqlDbType.NVarChar).Value = clientAddressTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(addressLineOneName)) {
                        sql += "  and address_line_one_name like '%' + @address_line_one_name + '%'";
                        command.Parameters.Add("@address_line_one_name", SqlDbType.NVarChar).Value = addressLineOneName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(addressLineTwoName)) {
                        sql += "  and address_line_two_name like '%' + @address_line_two_name + '%'";
                        command.Parameters.Add("@address_line_two_name", SqlDbType.NVarChar).Value = addressLineTwoName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(addressLineThreeName)) {
                        sql += "  and address_line_three_name like '%' + @address_line_three_name + '%'";
                        command.Parameters.Add("@address_line_three_name", SqlDbType.NVarChar).Value = addressLineThreeName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(cityName)) {
                        sql += "  and city_name like '%' + @city_name + '%'";
                        command.Parameters.Add("@city_name", SqlDbType.NVarChar).Value = cityName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(streetName)) {
                        sql += "  and street_name like '%' + @street_name + '%'";
                        command.Parameters.Add("@street_name", SqlDbType.NVarChar).Value = streetName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(stateName)) {
                        sql += "  and state_name like '%' + @state_name + '%'";
                        command.Parameters.Add("@state_name", SqlDbType.NVarChar).Value = stateName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(districtName)) {
                        sql += "  and district_name like '%' + @district_name + '%'";
                        command.Parameters.Add("@district_name", SqlDbType.NVarChar).Value = districtName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(provinceName)) {
                        sql += "  and province_name like '%' + @province_name + '%'";
                        command.Parameters.Add("@province_name", SqlDbType.NVarChar).Value = provinceName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(zipCode)) {
                        sql += "  and zip_code like '%' + @zip_code + '%'";
                        command.Parameters.Add("@zip_code", SqlDbType.NVarChar).Value = zipCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(poBox)) {
                        sql += "  and po_box like '%' + @po_box + '%'";
                        command.Parameters.Add("@po_box", SqlDbType.NVarChar).Value = poBox.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(comment)) {
                        sql += "  and comment like '%' + @comment + '%'";
                        command.Parameters.Add("@comment", SqlDbType.NVarChar).Value = comment.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by address_line_one_name";

                    command.CommandText = sql;

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["client_address_id"] != System.DBNull.Value) ClientAddressId = (System.Guid) reader["client_address_id"];
            if (reader["client_id"] != System.DBNull.Value) ClientId = (System.Guid) reader["client_id"];
            if (reader["client_address_type_rcd"] != System.DBNull.Value) ClientAddressTypeRcd = (System.String) reader["client_address_type_rcd"];
            if (reader["address_line_one_name"] != System.DBNull.Value) AddressLineOneName = (System.String) reader["address_line_one_name"];
            if (reader["address_line_two_name"] != System.DBNull.Value) AddressLineTwoName = (System.String) reader["address_line_two_name"];
            if (reader["address_line_three_name"] != System.DBNull.Value) AddressLineThreeName = (System.String) reader["address_line_three_name"];
            if (reader["city_name"] != System.DBNull.Value) CityName = (System.String) reader["city_name"];
            if (reader["street_name"] != System.DBNull.Value) StreetName = (System.String) reader["street_name"];
            if (reader["state_name"] != System.DBNull.Value) StateName = (System.String) reader["state_name"];
            if (reader["district_name"] != System.DBNull.Value) DistrictName = (System.String) reader["district_name"];
            if (reader["province_name"] != System.DBNull.Value) ProvinceName = (System.String) reader["province_name"];
            if (reader["zip_code"] != System.DBNull.Value) ZipCode = (System.String) reader["zip_code"];
            if (reader["po_box"] != System.DBNull.Value) PoBox = (System.String) reader["po_box"];
            if (reader["comment"] != System.DBNull.Value) Comment = (System.String) reader["comment"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ClientAddressId == Guid.Empty)
                ClientAddressId = Guid.NewGuid();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [client_address] (client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time)";
            sql += "            values (@client_address_id, @client_id, @client_address_type_rcd, @address_line_one_name, @address_line_two_name, @address_line_three_name, @city_name, @street_name, @state_name, @district_name, @province_name, @zip_code, @po_box, @comment, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientAddressId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (ClientId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientId);
                    command.Parameters.Add("@client_address_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientAddressTypeRcd;
                    command.Parameters.Add("@address_line_one_name",SqlDbType.NVarChar).Value = (System.String)AddressLineOneName;
                    command.Parameters.Add("@address_line_two_name",SqlDbType.NVarChar).Value = (System.String)AddressLineTwoName;
                    command.Parameters.Add("@address_line_three_name",SqlDbType.NVarChar).Value = (System.String)AddressLineThreeName;
                    command.Parameters.Add("@city_name",SqlDbType.NVarChar).Value = (System.String)CityName;
                    command.Parameters.Add("@street_name",SqlDbType.NVarChar).Value = (System.String)StreetName;
                    command.Parameters.Add("@state_name",SqlDbType.NVarChar).Value = (System.String)StateName;
                    command.Parameters.Add("@district_name",SqlDbType.NVarChar).Value = (System.String)DistrictName;
                    command.Parameters.Add("@province_name",SqlDbType.NVarChar).Value = (System.String)ProvinceName;
                    command.Parameters.Add("@zip_code",SqlDbType.NVarChar).Value = (System.String)ZipCode;
                    command.Parameters.Add("@po_box",SqlDbType.NVarChar).Value = (System.String)PoBox;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against client_address
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

            if (ClientAddressId == Guid.Empty)
                ClientAddressId = Guid.NewGuid();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [client_address] (client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time)";
            sql += "            values (@client_address_id, @client_id, @client_address_type_rcd, @address_line_one_name, @address_line_two_name, @address_line_three_name, @city_name, @street_name, @state_name, @district_name, @province_name, @zip_code, @po_box, @comment, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientAddressId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (ClientId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientId);
                command.Parameters.Add("@client_address_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientAddressTypeRcd;
                command.Parameters.Add("@address_line_one_name",SqlDbType.NVarChar).Value = (System.String)AddressLineOneName;
                command.Parameters.Add("@address_line_two_name",SqlDbType.NVarChar).Value = (System.String)AddressLineTwoName;
                command.Parameters.Add("@address_line_three_name",SqlDbType.NVarChar).Value = (System.String)AddressLineThreeName;
                command.Parameters.Add("@city_name",SqlDbType.NVarChar).Value = (System.String)CityName;
                command.Parameters.Add("@street_name",SqlDbType.NVarChar).Value = (System.String)StreetName;
                command.Parameters.Add("@state_name",SqlDbType.NVarChar).Value = (System.String)StateName;
                command.Parameters.Add("@district_name",SqlDbType.NVarChar).Value = (System.String)DistrictName;
                command.Parameters.Add("@province_name",SqlDbType.NVarChar).Value = (System.String)ProvinceName;
                command.Parameters.Add("@zip_code",SqlDbType.NVarChar).Value = (System.String)ZipCode;
                command.Parameters.Add("@po_box",SqlDbType.NVarChar).Value = (System.String)PoBox;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against client_address
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [client_address] set
                 client_address_id = @client_address_id
                ,client_id = @client_id
                ,client_address_type_rcd = @client_address_type_rcd
                ,address_line_one_name = @address_line_one_name
                ,address_line_two_name = @address_line_two_name
                ,address_line_three_name = @address_line_three_name
                ,city_name = @city_name
                ,street_name = @street_name
                ,state_name = @state_name
                ,district_name = @district_name
                ,province_name = @province_name
                ,zip_code = @zip_code
                ,po_box = @po_box
                ,comment = @comment
                ,user_id = @user_id
                ,date_time = @date_time
            where client_address_id = @client_address_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientAddressId;
                    command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (ClientId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientId);
                    command.Parameters.Add("@client_address_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientAddressTypeRcd;
                    command.Parameters.Add("@address_line_one_name",SqlDbType.NVarChar).Value = (System.String)AddressLineOneName;
                    command.Parameters.Add("@address_line_two_name",SqlDbType.NVarChar).Value = (System.String)AddressLineTwoName;
                    command.Parameters.Add("@address_line_three_name",SqlDbType.NVarChar).Value = (System.String)AddressLineThreeName;
                    command.Parameters.Add("@city_name",SqlDbType.NVarChar).Value = (System.String)CityName;
                    command.Parameters.Add("@street_name",SqlDbType.NVarChar).Value = (System.String)StreetName;
                    command.Parameters.Add("@state_name",SqlDbType.NVarChar).Value = (System.String)StateName;
                    command.Parameters.Add("@district_name",SqlDbType.NVarChar).Value = (System.String)DistrictName;
                    command.Parameters.Add("@province_name",SqlDbType.NVarChar).Value = (System.String)ProvinceName;
                    command.Parameters.Add("@zip_code",SqlDbType.NVarChar).Value = (System.String)ZipCode;
                    command.Parameters.Add("@po_box",SqlDbType.NVarChar).Value = (System.String)PoBox;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    // execute query against client_address
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [client_address] set
                 client_address_id = @client_address_id
                ,client_id = @client_id
                ,client_address_type_rcd = @client_address_type_rcd
                ,address_line_one_name = @address_line_one_name
                ,address_line_two_name = @address_line_two_name
                ,address_line_three_name = @address_line_three_name
                ,city_name = @city_name
                ,street_name = @street_name
                ,state_name = @state_name
                ,district_name = @district_name
                ,province_name = @province_name
                ,zip_code = @zip_code
                ,po_box = @po_box
                ,comment = @comment
                ,user_id = @user_id
                ,date_time = @date_time
            where client_address_id = @client_address_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ClientAddressId;
                command.Parameters.Add("@client_id",SqlDbType.UniqueIdentifier).Value = (ClientId == Guid.Empty ? (object)DBNull.Value : (System.Guid)ClientId);
                command.Parameters.Add("@client_address_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientAddressTypeRcd;
                command.Parameters.Add("@address_line_one_name",SqlDbType.NVarChar).Value = (System.String)AddressLineOneName;
                command.Parameters.Add("@address_line_two_name",SqlDbType.NVarChar).Value = (System.String)AddressLineTwoName;
                command.Parameters.Add("@address_line_three_name",SqlDbType.NVarChar).Value = (System.String)AddressLineThreeName;
                command.Parameters.Add("@city_name",SqlDbType.NVarChar).Value = (System.String)CityName;
                command.Parameters.Add("@street_name",SqlDbType.NVarChar).Value = (System.String)StreetName;
                command.Parameters.Add("@state_name",SqlDbType.NVarChar).Value = (System.String)StateName;
                command.Parameters.Add("@district_name",SqlDbType.NVarChar).Value = (System.String)DistrictName;
                command.Parameters.Add("@province_name",SqlDbType.NVarChar).Value = (System.String)ProvinceName;
                command.Parameters.Add("@zip_code",SqlDbType.NVarChar).Value = (System.String)ZipCode;
                command.Parameters.Add("@po_box",SqlDbType.NVarChar).Value = (System.String)PoBox;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (System.String)Comment;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                // execute query against client_address
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid clientAddressId) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [client_address] 
                where client_address_id = @client_address_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;
                    // execute query against client_address
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
