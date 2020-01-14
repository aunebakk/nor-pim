/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:59 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeLocationAddressData {
        
        public System.Guid LocationAddressId { get; set; } //;
        
        public string LocationAddressTypeRcd { get; set; } //;
        
        public System.Guid LocationCountryId { get; set; } //;
        
        public string AddressOne { get; set; } //;
        
        public string AddressTwo { get; set; } //;
        
        public string AddressThree { get; set; } //;
        
        public string City { get; set; } //;
        
        public string Street { get; set; } //;
        
        public string State { get; set; } //;
        
        public string District { get; set; } //;
        
        public string Province { get; set; } //;
        
        public string ZipCode { get; set; } //;
        
        public string PoBox { get; set; } //;
        
        public string Comment { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByLocationAddressId(System.Guid locationAddressId) {
            string sql = @" select top 1 location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            where location_address_id = @location_address_id
                            order by zip_code";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = locationAddressId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeLocationAddressData GetByLocationAddressId(System.Guid locationAddressId) {
            string sql = @" select top 1 location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            where location_address_id = @location_address_id
                            order by zip_code";

            var ret = new CrudeLocationAddressData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = locationAddressId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeLocationAddressData> FetchByLocationCountryId(System.Guid locationCountryId) {
            var dataList = new List<CrudeLocationAddressData>();

            string sql = @" select location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            where location_country_id = @location_country_id
                              
                            order by zip_code";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_country_id", SqlDbType.UniqueIdentifier).Value = locationCountryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationAddressData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeLocationAddressData>();

            string sql = @" select location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            where user_id = @user_id
                              
                            order by zip_code";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationAddressData> FetchByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            var dataList = new List<CrudeLocationAddressData>();

            string sql = @" select location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            where location_address_type_rcd = @location_address_type_rcd
                              
                            order by zip_code";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_address_type_rcd", SqlDbType.NVarChar).Value = locationAddressTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationAddressData> FetchAll() {
            var dataList = new List<CrudeLocationAddressData>();

            string sql = @" select location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            order by zip_code";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationAddressData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeLocationAddressData>();

            string sql = @" select top " + limit.ToString() + @" location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            order by zip_code";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationAddressData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeLocationAddressData>();

            string sql = @" select location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            order by zip_code";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeLocationAddressData();
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
            string sql = @" select count(*) as count from [location_address]";

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
        
        public static List<CrudeLocationAddressData> FetchWithFilter(
                    System.Guid locationAddressId, 
                    string locationAddressTypeRcd, 
                    System.Guid locationCountryId, 
                    string addressOne, 
                    string addressTwo, 
                    string addressThree, 
                    string city, 
                    string street, 
                    string state, 
                    string district, 
                    string province, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime) {
            var dataList = new List<CrudeLocationAddressData>();

            string sql = @" select location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time
                            from [location_address]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (locationAddressId != Guid.Empty) {
                        sql += "  and location_address_id = @location_address_id";
                        command.Parameters.Add("@location_address_id", SqlDbType.UniqueIdentifier).Value = locationAddressId;
                    }
                    if (!string.IsNullOrEmpty(locationAddressTypeRcd)) {
                        sql += "  and location_address_type_rcd like '%' + @location_address_type_rcd + '%'";
                        command.Parameters.Add("@location_address_type_rcd", SqlDbType.NVarChar).Value = locationAddressTypeRcd.Replace("'","''");
                    }
                    if (locationCountryId != Guid.Empty) {
                        sql += "  and location_country_id = @location_country_id";
                        command.Parameters.Add("@location_country_id", SqlDbType.UniqueIdentifier).Value = locationCountryId;
                    }
                    if (!string.IsNullOrEmpty(addressOne)) {
                        sql += "  and address_one like '%' + @address_one + '%'";
                        command.Parameters.Add("@address_one", SqlDbType.NVarChar).Value = addressOne.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(addressTwo)) {
                        sql += "  and address_two like '%' + @address_two + '%'";
                        command.Parameters.Add("@address_two", SqlDbType.NVarChar).Value = addressTwo.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(addressThree)) {
                        sql += "  and address_three like '%' + @address_three + '%'";
                        command.Parameters.Add("@address_three", SqlDbType.NVarChar).Value = addressThree.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(city)) {
                        sql += "  and city like '%' + @city + '%'";
                        command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(street)) {
                        sql += "  and street like '%' + @street + '%'";
                        command.Parameters.Add("@street", SqlDbType.NVarChar).Value = street.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(state)) {
                        sql += "  and state like '%' + @state + '%'";
                        command.Parameters.Add("@state", SqlDbType.NVarChar).Value = state.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(district)) {
                        sql += "  and district like '%' + @district + '%'";
                        command.Parameters.Add("@district", SqlDbType.NVarChar).Value = district.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(province)) {
                        sql += "  and province like '%' + @province + '%'";
                        command.Parameters.Add("@province", SqlDbType.NVarChar).Value = province.Replace("'","''");
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
                    sql += " order by zip_code";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["location_address_id"] != System.DBNull.Value) LocationAddressId = (System.Guid) reader["location_address_id"];
            if (reader["location_address_type_rcd"] != System.DBNull.Value) LocationAddressTypeRcd = (System.String) reader["location_address_type_rcd"];
            if (reader["location_country_id"] != System.DBNull.Value) LocationCountryId = (System.Guid) reader["location_country_id"];
            if (reader["address_one"] != System.DBNull.Value) AddressOne = (System.String) reader["address_one"];
            if (reader["address_two"] != System.DBNull.Value) AddressTwo = (System.String) reader["address_two"];
            if (reader["address_three"] != System.DBNull.Value) AddressThree = (System.String) reader["address_three"];
            if (reader["city"] != System.DBNull.Value) City = (System.String) reader["city"];
            if (reader["street"] != System.DBNull.Value) Street = (System.String) reader["street"];
            if (reader["state"] != System.DBNull.Value) State = (System.String) reader["state"];
            if (reader["district"] != System.DBNull.Value) District = (System.String) reader["district"];
            if (reader["province"] != System.DBNull.Value) Province = (System.String) reader["province"];
            if (reader["zip_code"] != System.DBNull.Value) ZipCode = (System.String) reader["zip_code"];
            if (reader["po_box"] != System.DBNull.Value) PoBox = (System.String) reader["po_box"];
            if (reader["comment"] != System.DBNull.Value) Comment = (System.String) reader["comment"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (LocationAddressId == Guid.Empty)
                LocationAddressId = Guid.NewGuid();

            string sql = "insert into [location_address] (location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time)";
            sql += "            values (@location_address_id, @location_address_type_rcd, @location_country_id, @address_one, @address_two, @address_three, @city, @street, @state, @district, @province, @zip_code, @po_box, @comment, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationAddressId;
                    command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LocationAddressTypeRcd)) ? (object)DBNull.Value : (System.String)LocationAddressTypeRcd;
                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                    command.Parameters.Add("@address_one",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressOne)) ? (object)DBNull.Value : (System.String)AddressOne;
                    command.Parameters.Add("@address_two",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressTwo)) ? (object)DBNull.Value : (System.String)AddressTwo;
                    command.Parameters.Add("@address_three",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressThree)) ? (object)DBNull.Value : (System.String)AddressThree;
                    command.Parameters.Add("@city",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(City)) ? (object)DBNull.Value : (System.String)City;
                    command.Parameters.Add("@street",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Street)) ? (object)DBNull.Value : (System.String)Street;
                    command.Parameters.Add("@state",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(State)) ? (object)DBNull.Value : (System.String)State;
                    command.Parameters.Add("@district",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(District)) ? (object)DBNull.Value : (System.String)District;
                    command.Parameters.Add("@province",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Province)) ? (object)DBNull.Value : (System.String)Province;
                    command.Parameters.Add("@zip_code",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ZipCode)) ? (object)DBNull.Value : (System.String)ZipCode;
                    command.Parameters.Add("@po_box",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(PoBox)) ? (object)DBNull.Value : (System.String)PoBox;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (LocationAddressId == Guid.Empty)
                LocationAddressId = Guid.NewGuid();

            string sql = "insert into [location_address] (location_address_id, location_address_type_rcd, location_country_id, address_one, address_two, address_three, city, street, state, district, province, zip_code, po_box, comment, user_id, date_time)";
            sql += "            values (@location_address_id, @location_address_type_rcd, @location_country_id, @address_one, @address_two, @address_three, @city, @street, @state, @district, @province, @zip_code, @po_box, @comment, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationAddressId;
                command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LocationAddressTypeRcd)) ? (object)DBNull.Value : (System.String)LocationAddressTypeRcd;
                command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                command.Parameters.Add("@address_one",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressOne)) ? (object)DBNull.Value : (System.String)AddressOne;
                command.Parameters.Add("@address_two",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressTwo)) ? (object)DBNull.Value : (System.String)AddressTwo;
                command.Parameters.Add("@address_three",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressThree)) ? (object)DBNull.Value : (System.String)AddressThree;
                command.Parameters.Add("@city",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(City)) ? (object)DBNull.Value : (System.String)City;
                command.Parameters.Add("@street",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Street)) ? (object)DBNull.Value : (System.String)Street;
                command.Parameters.Add("@state",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(State)) ? (object)DBNull.Value : (System.String)State;
                command.Parameters.Add("@district",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(District)) ? (object)DBNull.Value : (System.String)District;
                command.Parameters.Add("@province",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Province)) ? (object)DBNull.Value : (System.String)Province;
                command.Parameters.Add("@zip_code",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ZipCode)) ? (object)DBNull.Value : (System.String)ZipCode;
                command.Parameters.Add("@po_box",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(PoBox)) ? (object)DBNull.Value : (System.String)PoBox;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [location_address] set
                 location_address_id = @location_address_id
                ,location_address_type_rcd = @location_address_type_rcd
                ,location_country_id = @location_country_id
                ,address_one = @address_one
                ,address_two = @address_two
                ,address_three = @address_three
                ,city = @city
                ,street = @street
                ,state = @state
                ,district = @district
                ,province = @province
                ,zip_code = @zip_code
                ,po_box = @po_box
                ,comment = @comment
                ,user_id = @user_id
                ,date_time = @date_time
            where location_address_id = @location_address_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationAddressId;
                    command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LocationAddressTypeRcd)) ? (object)DBNull.Value : (System.String)LocationAddressTypeRcd;
                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                    command.Parameters.Add("@address_one",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressOne)) ? (object)DBNull.Value : (System.String)AddressOne;
                    command.Parameters.Add("@address_two",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressTwo)) ? (object)DBNull.Value : (System.String)AddressTwo;
                    command.Parameters.Add("@address_three",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressThree)) ? (object)DBNull.Value : (System.String)AddressThree;
                    command.Parameters.Add("@city",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(City)) ? (object)DBNull.Value : (System.String)City;
                    command.Parameters.Add("@street",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Street)) ? (object)DBNull.Value : (System.String)Street;
                    command.Parameters.Add("@state",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(State)) ? (object)DBNull.Value : (System.String)State;
                    command.Parameters.Add("@district",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(District)) ? (object)DBNull.Value : (System.String)District;
                    command.Parameters.Add("@province",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Province)) ? (object)DBNull.Value : (System.String)Province;
                    command.Parameters.Add("@zip_code",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ZipCode)) ? (object)DBNull.Value : (System.String)ZipCode;
                    command.Parameters.Add("@po_box",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(PoBox)) ? (object)DBNull.Value : (System.String)PoBox;
                    command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [location_address] set
                 location_address_id = @location_address_id
                ,location_address_type_rcd = @location_address_type_rcd
                ,location_country_id = @location_country_id
                ,address_one = @address_one
                ,address_two = @address_two
                ,address_three = @address_three
                ,city = @city
                ,street = @street
                ,state = @state
                ,district = @district
                ,province = @province
                ,zip_code = @zip_code
                ,po_box = @po_box
                ,comment = @comment
                ,user_id = @user_id
                ,date_time = @date_time
            where location_address_id = @location_address_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationAddressId;
                command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(LocationAddressTypeRcd)) ? (object)DBNull.Value : (System.String)LocationAddressTypeRcd;
                command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                command.Parameters.Add("@address_one",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressOne)) ? (object)DBNull.Value : (System.String)AddressOne;
                command.Parameters.Add("@address_two",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressTwo)) ? (object)DBNull.Value : (System.String)AddressTwo;
                command.Parameters.Add("@address_three",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(AddressThree)) ? (object)DBNull.Value : (System.String)AddressThree;
                command.Parameters.Add("@city",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(City)) ? (object)DBNull.Value : (System.String)City;
                command.Parameters.Add("@street",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Street)) ? (object)DBNull.Value : (System.String)Street;
                command.Parameters.Add("@state",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(State)) ? (object)DBNull.Value : (System.String)State;
                command.Parameters.Add("@district",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(District)) ? (object)DBNull.Value : (System.String)District;
                command.Parameters.Add("@province",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Province)) ? (object)DBNull.Value : (System.String)Province;
                command.Parameters.Add("@zip_code",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ZipCode)) ? (object)DBNull.Value : (System.String)ZipCode;
                command.Parameters.Add("@po_box",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(PoBox)) ? (object)DBNull.Value : (System.String)PoBox;
                command.Parameters.Add("@comment",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Comment)) ? (object)DBNull.Value : (System.String)Comment;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid locationAddressId) {
            string sql = @" delete [location_address] 
                where location_address_id = @location_address_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_address_id",SqlDbType.UniqueIdentifier).Value = locationAddressId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
