/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:03:38 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateChildCrudeData.UsingDotNetFramework
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
//  data access layer: https://en.wikipedia.org/wiki/Data_access_layer
//  docLink: http://sql2x.org/documentationLink/e4965a5f-c9fd-4584-85f0-b4d308f48f29
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // this class start with an identical representation of client_address's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    // crud definition: https://en.wikipedia.org/wiki/Create,_read,_update_and_delete
    //  docLink: http://sql2x.org/documentationLink/e32ed6d4-57c7-43b1-8f2e-918c702e730a
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
        //  docLink: http://sql2x.org/documentationLink/71a3c70c-2d6d-4115-911c-a61f0383dbd5
        // parameters:
        //  clientAddressId: primary key of table client_address
        public void FetchByClientAddressId(System.Guid clientAddressId) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/34fb7e37-dc72-4674-b0b8-075b6f06e158
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_id = @client_address_id
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/47bd7ea7-2509-4557-a6da-cb80646dc104
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked
                //   as locked by another database transaction
                // links:
                // docLink: http://sql2x.org/documentationLink/887786de-45d6-4e41-bc7a-4ba7955de9b1
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/0dc14388-f77b-4958-9d3b-45ead576ba03
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;

                    // execute and read one row, close connection
                    // links:
                    // docLink: http://sql2x.org/documentationLink/35606d85-e730-4595-9321-d38f5afe5dd8
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    // links:
                    // docLink: http://sql2x.org/documentationLink/c197df6d-be93-499e-b4da-75d9993bd464
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        // links:
        //  docLink: http://sql2x.org/documentationLink/7a625d0a-3028-42ce-a543-72ea3673cef4
        // parameters:
        //  clientAddressId: primary key of table client_address
        public static CrudeClientAddressData GetByClientAddressId(System.Guid clientAddressId) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/72f5fc83-c460-40fe-bac9-73b7ee0c6b77
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_id = @client_address_id
                            order by address_line_one_name";

            var ret = new CrudeClientAddressData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/1ecca728-0c07-4dd7-b095-d10777b25b70
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/1ecca728-0c07-4dd7-b095-d10777b25b70
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/fd5c5faa-b400-4f29-b12b-9675c53a757f
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if a row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/13095cd7-f136-4532-8969-c50c62cc05ef
        public static List<CrudeClientAddressData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/86c78f05-a65f-4dfe-b048-d0cbece49f4e
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_id = @client_id
                              
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/6fd25822-459f-4796-803a-071a3a270aa0
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/8aec2e5c-4732-4662-badb-83b89d1c34a9
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/bb9abe5c-d2c1-455a-b597-a2af0a35de5a
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/5c413c03-5ddc-472a-a63d-53aecc7a2573
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/13095cd7-f136-4532-8969-c50c62cc05ef
        public static List<CrudeClientAddressData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/86c78f05-a65f-4dfe-b048-d0cbece49f4e
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where user_id = @user_id
                              
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/6fd25822-459f-4796-803a-071a3a270aa0
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/8aec2e5c-4732-4662-badb-83b89d1c34a9
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/bb9abe5c-d2c1-455a-b597-a2af0a35de5a
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/5c413c03-5ddc-472a-a63d-53aecc7a2573
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/13095cd7-f136-4532-8969-c50c62cc05ef
        public static List<CrudeClientAddressData> FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/86c78f05-a65f-4dfe-b048-d0cbece49f4e
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_type_rcd = @client_address_type_rcd
                              
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/6fd25822-459f-4796-803a-071a3a270aa0
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/8aec2e5c-4732-4662-badb-83b89d1c34a9
                    command.Parameters.Add("@client_address_type_rcd", SqlDbType.NVarChar).Value = clientAddressTypeRcd.Replace("'","''");

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/bb9abe5c-d2c1-455a-b597-a2af0a35de5a
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/5c413c03-5ddc-472a-a63d-53aecc7a2573
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/05fb7828-eb28-411a-9678-713bfd445d93
        public void FetchByAddressLineOneName(string addressLineOneName) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/33f6e139-6073-487f-9b0e-3b77604a0342
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where address_line_one_name like '%' + @addressLineOneName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/13c970bf-fda1-416f-b0d8-5cd13f273c96
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/9f9697ab-abd6-4568-a542-bdbbb250d2f7
                command.Parameters.Add("@addressLineOneName",SqlDbType.NVarChar).Value = addressLineOneName;

                // execute query against client_address
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                // links:
                // docLink: http://sql2x.org/documentationLink/bbb39851-fae8-4657-9f48-ddc0e8a84725
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all rows from table client_address into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/7ca0c014-527e-4a0a-bd1f-12f4d8ea4b43
        public static List<CrudeClientAddressData> FetchAll() {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/72f9f1bc-447c-4327-9d26-4b0790a07ff8
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/952b3f82-bc00-4e82-9430-6bc26ff8bc4d
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/ed55cc5b-d6be-4f5e-9385-ee726dfc2bf1
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/c1b8b800-b250-4822-a699-d93a35f4414d
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/dfaa482b-059b-4f17-a9a9-4885138dbb46
        public static List<CrudeClientAddressData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/41f82773-6d37-4ebe-840c-c60e06337f45
            string sql = @" select top " + limit.ToString() + @" client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/da228d98-b30e-4d79-89ae-98e813437753
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/c32ad724-8a03-4b4c-b6fb-a5abfb1d707e
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/9ba4395d-d8a4-4427-b80f-7b828e34da7a
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/12d2812e-e963-4f26-8014-48c4e9cfb3ae
        public static List<CrudeClientAddressData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientAddressData>();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/21eca289-4747-4a75-b0a2-1a58457be608
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/c3e624a4-8479-4c17-bec7-ec09f3abbe64
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/6507b543-adbc-4863-810b-8db439f40d5c
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/fcd15e2f-df3f-44d8-8a13-d2e93d97f685
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/58c70863-ab7a-49e1-a0f9-809a0528eb50
        public static int FetchAllCount() {
                        // create query against client_address
                        // this will be ansi sql and parameterized
                        // parameterized queries are a good way of preventing sql injection
                        //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/2d106245-afb6-427d-8547-3c3d19128f7a
            string sql = @" select count(*) as count from [client_address]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/4826152a-aec8-4417-b176-65b2a6d97f35
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against client_address
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/2294956f-872f-4f98-8677-c21f164b7892
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/a736bbfd-030d-492e-a86a-7a5e478eeb79
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
            // links:
            // docLink: http://sql2x.org/documentationLink/06da7a50-8760-48cd-b789-a41cac3edd13
            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
// links:
// docLink: http://sql2x.org/documentationLink/6ec2495f-3a49-4a94-ad59-0ce064fc8654
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/2193123a-3534-412b-8521-dac14bb3884d
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
                    // links:
                    // docLink: http://sql2x.org/documentationLink/9f9fcbf4-4764-4b2e-8dc6-41d0366c95c9
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of client_address
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    // links:
                    // docLink: http://sql2x.org/documentationLink/60181c7c-4a5e-41a3-9599-4e7a0aaf0cc8
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/8305cd6c-8739-45a7-b02b-d68ac4a1b704
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
        // links:
        //  docLink: http://sql2x.org/documentationLink/7bdedca5-6a3e-4862-9899-e1e6f0786a65
        public void Insert() {

            if (ClientAddressId == Guid.Empty)
                ClientAddressId = Guid.NewGuid();

                        // create query against client_address
                        // this will be ansi sql and parameterized
                        // parameterized queries are a good way of preventing sql injection
                        //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/9a2230f9-8b3d-4525-a9a9-a4c654647a8d
            string sql = "insert into [client_address] (client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time)";
            sql += "            values (@client_address_id, @client_id, @client_address_type_rcd, @address_line_one_name, @address_line_two_name, @address_line_three_name, @city_name, @street_name, @state_name, @district_name, @province_name, @zip_code, @po_box, @comment, @user_id, @date_time)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/56578739-efc5-4725-b597-1ef4c794c424
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/99823b37-69bd-4bf4-89c7-31c392e6a84a
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
                    // links:
                    // docLink: http://sql2x.org/documentationLink/f4d3ee95-4d8a-4b08-8485-cefdd78f365f
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/673b8de5-6a72-4992-954e-a06da52fb3d0
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientAddressId == Guid.Empty)
                ClientAddressId = Guid.NewGuid();

            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/27ed2199-e80d-4b2f-a4bc-ee150909bcfe
            string sql = "insert into [client_address] (client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time)";
            sql += "            values (@client_address_id, @client_id, @client_address_type_rcd, @address_line_one_name, @address_line_two_name, @address_line_three_name, @city_name, @street_name, @state_name, @district_name, @province_name, @zip_code, @po_box, @comment, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            // links:
            // docLink: http://sql2x.org/documentationLink/1b80c25f-8155-4b40-b2c8-4af98de6e364
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                // links:
                // docLink: http://sql2x.org/documentationLink/537f7277-d9ca-4a34-9067-3313f69dfbb5
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
                // links:
                // docLink: http://sql2x.org/documentationLink/9a5cd1ec-b72c-4f38-8fb0-5ab4a6891bf8
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/128da2b2-c713-4ca8-ab97-9497c39cd400
        public void Update() {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/003a6113-375a-4b77-9df9-53ef5a233b78
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
            // links:
            // docLink: http://sql2x.org/documentationLink/a35f7373-2e2b-4f34-aabb-d23549c39fc9
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/2abaaa29-3a36-487c-a096-b2e750cac04b
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
                    // links:
                    // docLink: http://sql2x.org/documentationLink/8205d701-9a29-4b76-ba08-dbad5f0a4f63
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/a5ace3c5-884e-46e2-97e0-05c0878ebfa2
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/1b17fa53-5cf9-4a38-8e7e-500586d09db3
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
            // links:
            // docLink: http://sql2x.org/documentationLink/4be826df-f0a1-424f-8926-99d948ab0736
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                // links:
                // docLink: http://sql2x.org/documentationLink/f0ab995c-ed68-46d9-9a2b-4ddf72bf94d8
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
                // links:
                // docLink: http://sql2x.org/documentationLink/80014a96-6231-456f-bdea-a466aa612e1c
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/92ea3c6c-f90b-4c76-a6a1-5f440075b3ba
        public static void Delete(System.Guid clientAddressId) {
            // create query against client_address
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            // links:
            // docLink: http://sql2x.org/documentationLink/f5378c5f-33b5-4709-9e9c-8cdfc9fd94f6
            string sql = @" delete [client_address] 
                where client_address_id = @client_address_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            // links:
            // docLink: http://sql2x.org/documentationLink/bcb94289-4fee-464c-bca6-2e10f633cd9d
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    // links:
                    // docLink: http://sql2x.org/documentationLink/32a0ab14-77a5-4b51-a523-9e946c84a4fb
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;
                    // execute query against client_address
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    // links:
                    // docLink: http://sql2x.org/documentationLink/d44130c8-51b4-4162-a9c8-24b6c7df0241
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
