/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:26 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeClientAddressData {
        
        public System.Guid ClientAddressId { get; set; } //;
        
        public System.Guid ClientId { get; set; } //;
        
        public string ClientAddressTypeRcd { get; set; } //;
        
        public string AddressLineOneName { get; set; } //;
        
        public string AddressLineTwoName { get; set; } //;
        
        public string AddressLineThreeName { get; set; } //;
        
        public string CityName { get; set; } //;
        
        public string StreetName { get; set; } //;
        
        public string StateName { get; set; } //;
        
        public string DistrictName { get; set; } //;
        
        public string ProvinceName { get; set; } //;
        
        public string ZipCode { get; set; } //;
        
        public string PoBox { get; set; } //;
        
        public string Comment { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientAddressId(System.Guid clientAddressId) {
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_id = @client_address_id
                            order by address_line_one_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientAddressData GetByClientAddressId(System.Guid clientAddressId) {
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_id = @client_address_id
                            order by address_line_one_name";

            var ret = new CrudeClientAddressData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientAddressData> FetchByClientId(System.Guid clientId) {
            var dataList = new List<CrudeClientAddressData>();

            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_id = @client_id
                              
                            order by address_line_one_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_id", SqlDbType.UniqueIdentifier).Value = clientId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientAddressData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientAddressData>();

            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where user_id = @user_id
                              
                            order by address_line_one_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientAddressData> FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            var dataList = new List<CrudeClientAddressData>();

            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where client_address_type_rcd = @client_address_type_rcd
                              
                            order by address_line_one_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_address_type_rcd", SqlDbType.NVarChar).Value = clientAddressTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByAddressLineOneName(string addressLineOneName) {
            string sql = @" select top 1 client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where address_line_one_name like '%' + @addressLineOneName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@addressLineOneName",SqlDbType.NVarChar).Value = addressLineOneName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeClientAddressData> FetchAll() {
            var dataList = new List<CrudeClientAddressData>();

            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientAddressData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientAddressData>();

            string sql = @" select top " + limit.ToString() + @" client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientAddressData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientAddressData>();

            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            order by address_line_one_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

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
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [client_address]";

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

            string sql = @" select client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time
                            from [client_address]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
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

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientAddressData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
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
        
        public void Insert() {

            if (ClientAddressId == Guid.Empty)
                ClientAddressId = Guid.NewGuid();

            string sql = "insert into [client_address] (client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time)";
            sql += "            values (@client_address_id, @client_id, @client_address_type_rcd, @address_line_one_name, @address_line_two_name, @address_line_three_name, @city_name, @street_name, @state_name, @district_name, @province_name, @zip_code, @po_box, @comment, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
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
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ClientAddressId == Guid.Empty)
                ClientAddressId = Guid.NewGuid();

            string sql = "insert into [client_address] (client_address_id, client_id, client_address_type_rcd, address_line_one_name, address_line_two_name, address_line_three_name, city_name, street_name, state_name, district_name, province_name, zip_code, po_box, comment, user_id, date_time)";
            sql += "            values (@client_address_id, @client_id, @client_address_type_rcd, @address_line_one_name, @address_line_two_name, @address_line_three_name, @city_name, @street_name, @state_name, @district_name, @province_name, @zip_code, @po_box, @comment, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
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
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
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
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

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
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
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
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
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
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid clientAddressId) {
            string sql = @" delete [client_address] 
                where client_address_id = @client_address_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_address_id",SqlDbType.UniqueIdentifier).Value = clientAddressId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
