/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:26:11 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeLocationCityData {
        
        public System.Guid LocationCityId { get; set; } //;
        
        public System.Guid LocationCountryId { get; set; } //;
        
        public string LocationCityCode { get; set; } //;
        
        public string LocationCityName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByLocationCityId(System.Guid locationCityId) {
            string sql = @" select top 1 location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            where location_city_id = @location_city_id
                            order by location_city_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@location_city_id",SqlDbType.UniqueIdentifier).Value = locationCityId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeLocationCityData GetByLocationCityId(System.Guid locationCityId) {
            string sql = @" select top 1 location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            where location_city_id = @location_city_id
                            order by location_city_name";

            var ret = new CrudeLocationCityData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_city_id",SqlDbType.UniqueIdentifier).Value = locationCityId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeLocationCityData> FetchByLocationCountryId(System.Guid locationCountryId) {
            var dataList = new List<CrudeLocationCityData>();

            string sql = @" select location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            where location_country_id = @location_country_id
                              
                            order by location_city_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_country_id", SqlDbType.UniqueIdentifier).Value = locationCountryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationCityData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeLocationCityData>();

            string sql = @" select location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            where user_id = @user_id
                              
                            order by location_city_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByLocationCityName(string locationCityName) {
            string sql = @" select top 1 location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            where location_city_name like '%' + @locationCityName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@locationCityName",SqlDbType.NVarChar).Value = locationCityName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeLocationCityData> FetchAll() {
            var dataList = new List<CrudeLocationCityData>();

            string sql = @" select location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            order by location_city_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationCityData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeLocationCityData>();

            string sql = @" select top " + limit.ToString() + @" location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            order by location_city_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationCityData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeLocationCityData>();

            string sql = @" select location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            order by location_city_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeLocationCityData();
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
            string sql = @" select count(*) as count from [location_city]";

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
        
        public static List<CrudeLocationCityData> FetchWithFilter(System.Guid locationCityId, System.Guid locationCountryId, string locationCityCode, string locationCityName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeLocationCityData>();

            string sql = @" select location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time
                            from [location_city]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (locationCityId != Guid.Empty) {
                        sql += "  and location_city_id = @location_city_id";
                        command.Parameters.Add("@location_city_id", SqlDbType.UniqueIdentifier).Value = locationCityId;
                    }
                    if (locationCountryId != Guid.Empty) {
                        sql += "  and location_country_id = @location_country_id";
                        command.Parameters.Add("@location_country_id", SqlDbType.UniqueIdentifier).Value = locationCountryId;
                    }
                    if (!string.IsNullOrEmpty(locationCityCode)) {
                        sql += "  and location_city_code like '%' + @location_city_code + '%'";
                        command.Parameters.Add("@location_city_code", SqlDbType.NVarChar).Value = locationCityCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(locationCityName)) {
                        sql += "  and location_city_name like '%' + @location_city_name + '%'";
                        command.Parameters.Add("@location_city_name", SqlDbType.NVarChar).Value = locationCityName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by location_city_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCityData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["location_city_id"] != System.DBNull.Value) LocationCityId = (System.Guid) reader["location_city_id"];
            if (reader["location_country_id"] != System.DBNull.Value) LocationCountryId = (System.Guid) reader["location_country_id"];
            if (reader["location_city_code"] != System.DBNull.Value) LocationCityCode = (System.String) reader["location_city_code"];
            if (reader["location_city_name"] != System.DBNull.Value) LocationCityName = (System.String) reader["location_city_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (LocationCityId == Guid.Empty)
                LocationCityId = Guid.NewGuid();

            string sql = "insert into [location_city] (location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time)";
            sql += "            values (@location_city_id, @location_country_id, @location_city_code, @location_city_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@location_city_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCityId;
                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                    command.Parameters.Add("@location_city_code",SqlDbType.NVarChar).Value = (System.String)LocationCityCode;
                    command.Parameters.Add("@location_city_name",SqlDbType.NVarChar).Value = (System.String)LocationCityName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (LocationCityId == Guid.Empty)
                LocationCityId = Guid.NewGuid();

            string sql = "insert into [location_city] (location_city_id, location_country_id, location_city_code, location_city_name, user_id, date_time)";
            sql += "            values (@location_city_id, @location_country_id, @location_city_code, @location_city_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@location_city_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCityId;
                command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                command.Parameters.Add("@location_city_code",SqlDbType.NVarChar).Value = (System.String)LocationCityCode;
                command.Parameters.Add("@location_city_name",SqlDbType.NVarChar).Value = (System.String)LocationCityName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [location_city] set
                 location_city_id = @location_city_id
                ,location_country_id = @location_country_id
                ,location_city_code = @location_city_code
                ,location_city_name = @location_city_name
                ,user_id = @user_id
                ,date_time = @date_time
            where location_city_id = @location_city_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@location_city_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCityId;
                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                    command.Parameters.Add("@location_city_code",SqlDbType.NVarChar).Value = (System.String)LocationCityCode;
                    command.Parameters.Add("@location_city_name",SqlDbType.NVarChar).Value = (System.String)LocationCityName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [location_city] set
                 location_city_id = @location_city_id
                ,location_country_id = @location_country_id
                ,location_city_code = @location_city_code
                ,location_city_name = @location_city_name
                ,user_id = @user_id
                ,date_time = @date_time
            where location_city_id = @location_city_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@location_city_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCityId;
                command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                command.Parameters.Add("@location_city_code",SqlDbType.NVarChar).Value = (System.String)LocationCityCode;
                command.Parameters.Add("@location_city_name",SqlDbType.NVarChar).Value = (System.String)LocationCityName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid locationCityId) {
            string sql = @" delete [location_city] 
                where location_city_id = @location_city_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_city_id",SqlDbType.UniqueIdentifier).Value = locationCityId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
