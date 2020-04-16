/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:35:21 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeLocationCountryData {
        
        public System.Guid LocationCountryId { get; set; } //;
        
        public string LocationCountryCode { get; set; } //;
        
        public string LocationCountryName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByLocationCountryId(System.Guid locationCountryId) {
            string sql = @" select top 1 location_country_id, location_country_code, location_country_name, user_id, date_time
                            from [location_country]
                            where location_country_id = @location_country_id
                            order by location_country_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = locationCountryId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeLocationCountryData GetByLocationCountryId(System.Guid locationCountryId) {
            string sql = @" select top 1 location_country_id, location_country_code, location_country_name, user_id, date_time
                            from [location_country]
                            where location_country_id = @location_country_id
                            order by location_country_name";

            var ret = new CrudeLocationCountryData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = locationCountryId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeLocationCountryData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeLocationCountryData>();

            string sql = @" select location_country_id, location_country_code, location_country_name, user_id, date_time
                            from [location_country]
                            where user_id = @user_id
                              
                            order by location_country_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCountryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByLocationCountryName(string locationCountryName) {
            string sql = @" select top 1 location_country_id, location_country_code, location_country_name, user_id, date_time
                            from [location_country]
                            where location_country_name like '%' + @locationCountryName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@locationCountryName",SqlDbType.NVarChar).Value = locationCountryName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeLocationCountryData> FetchAll() {
            var dataList = new List<CrudeLocationCountryData>();

            string sql = @" select location_country_id, location_country_code, location_country_name, user_id, date_time
                            from [location_country]
                            order by location_country_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCountryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationCountryData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeLocationCountryData>();

            string sql = @" select top " + limit.ToString() + @" location_country_id, location_country_code, location_country_name, user_id, date_time
                            from [location_country]
                            order by location_country_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCountryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationCountryData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeLocationCountryData>();

            string sql = @" select location_country_id, location_country_code, location_country_name, user_id, date_time
                            from [location_country]
                            order by location_country_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeLocationCountryData();
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
            string sql = @" select count(*) as count from [location_country]";

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
        
        public static List<CrudeLocationCountryData> FetchWithFilter(System.Guid locationCountryId, string locationCountryCode, string locationCountryName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeLocationCountryData>();

            string sql = @" select location_country_id, location_country_code, location_country_name, user_id, date_time
                            from [location_country]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (locationCountryId != Guid.Empty) {
                        sql += "  and location_country_id = @location_country_id";
                        command.Parameters.Add("@location_country_id", SqlDbType.UniqueIdentifier).Value = locationCountryId;
                    }
                    if (!string.IsNullOrEmpty(locationCountryCode)) {
                        sql += "  and location_country_code like '%' + @location_country_code + '%'";
                        command.Parameters.Add("@location_country_code", SqlDbType.NVarChar).Value = locationCountryCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(locationCountryName)) {
                        sql += "  and location_country_name like '%' + @location_country_name + '%'";
                        command.Parameters.Add("@location_country_name", SqlDbType.NVarChar).Value = locationCountryName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by location_country_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationCountryData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["location_country_id"] != System.DBNull.Value) LocationCountryId = (System.Guid) reader["location_country_id"];
            if (reader["location_country_code"] != System.DBNull.Value) LocationCountryCode = (System.String) reader["location_country_code"];
            if (reader["location_country_name"] != System.DBNull.Value) LocationCountryName = (System.String) reader["location_country_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (LocationCountryId == Guid.Empty)
                LocationCountryId = Guid.NewGuid();

            string sql = "insert into [location_country] (location_country_id, location_country_code, location_country_name, user_id, date_time)";
            sql += "            values (@location_country_id, @location_country_code, @location_country_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                    command.Parameters.Add("@location_country_code",SqlDbType.NVarChar).Value = (System.String)LocationCountryCode;
                    command.Parameters.Add("@location_country_name",SqlDbType.NVarChar).Value = (System.String)LocationCountryName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (LocationCountryId == Guid.Empty)
                LocationCountryId = Guid.NewGuid();

            string sql = "insert into [location_country] (location_country_id, location_country_code, location_country_name, user_id, date_time)";
            sql += "            values (@location_country_id, @location_country_code, @location_country_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                command.Parameters.Add("@location_country_code",SqlDbType.NVarChar).Value = (System.String)LocationCountryCode;
                command.Parameters.Add("@location_country_name",SqlDbType.NVarChar).Value = (System.String)LocationCountryName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [location_country] set
                 location_country_id = @location_country_id
                ,location_country_code = @location_country_code
                ,location_country_name = @location_country_name
                ,user_id = @user_id
                ,date_time = @date_time
            where location_country_id = @location_country_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                    command.Parameters.Add("@location_country_code",SqlDbType.NVarChar).Value = (System.String)LocationCountryCode;
                    command.Parameters.Add("@location_country_name",SqlDbType.NVarChar).Value = (System.String)LocationCountryName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [location_country] set
                 location_country_id = @location_country_id
                ,location_country_code = @location_country_code
                ,location_country_name = @location_country_name
                ,user_id = @user_id
                ,date_time = @date_time
            where location_country_id = @location_country_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)LocationCountryId;
                command.Parameters.Add("@location_country_code",SqlDbType.NVarChar).Value = (System.String)LocationCountryCode;
                command.Parameters.Add("@location_country_name",SqlDbType.NVarChar).Value = (System.String)LocationCountryName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid locationCountryId) {
            string sql = @" delete [location_country] 
                where location_country_id = @location_country_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_country_id",SqlDbType.UniqueIdentifier).Value = locationCountryId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
