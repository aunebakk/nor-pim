/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:51 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class LocationAddressTypeRef {
        
        public const string Office = "Office";
        
        public const string Primary = "Primary";
        
        public const string Private = "Private";
    }
    
    //[Serializable()]
    public partial class CrudeLocationAddressTypeRefData {
        
        public string LocationAddressTypeRcd { get; set; } //;
        
        public string LocationAddressTypeName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            string sql = @" select top 1 location_address_type_rcd, location_address_type_name, user_id, date_time
                            from [location_address_type_ref]
                            where location_address_type_rcd = @location_address_type_rcd
                            order by location_address_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = locationAddressTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeLocationAddressTypeRefData GetByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            string sql = @" select top 1 location_address_type_rcd, location_address_type_name, user_id, date_time
                            from [location_address_type_ref]
                            where location_address_type_rcd = @location_address_type_rcd
                            order by location_address_type_name";

            var ret = new CrudeLocationAddressTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = locationAddressTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeLocationAddressTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeLocationAddressTypeRefData>();

            string sql = @" select location_address_type_rcd, location_address_type_name, user_id, date_time
                            from [location_address_type_ref]
                            where user_id = @user_id
                              
                            order by location_address_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByLocationAddressTypeName(string locationAddressTypeName) {
            string sql = @" select top 1 location_address_type_rcd, location_address_type_name, user_id, date_time
                            from [location_address_type_ref]
                            where location_address_type_name like '%' + @locationAddressTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@locationAddressTypeName",SqlDbType.NVarChar).Value = locationAddressTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeLocationAddressTypeRefData> FetchAll() {
            var dataList = new List<CrudeLocationAddressTypeRefData>();

            string sql = @" select location_address_type_rcd, location_address_type_name, user_id, date_time
                            from [location_address_type_ref]
                            order by location_address_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationAddressTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeLocationAddressTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" location_address_type_rcd, location_address_type_name, user_id, date_time
                            from [location_address_type_ref]
                            order by location_address_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeLocationAddressTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeLocationAddressTypeRefData>();

            string sql = @" select location_address_type_rcd, location_address_type_name, user_id, date_time
                            from [location_address_type_ref]
                            order by location_address_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeLocationAddressTypeRefData();
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
            string sql = @" select count(*) as count from [location_address_type_ref]";

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
        
        public static List<CrudeLocationAddressTypeRefData> FetchWithFilter(string locationAddressTypeRcd, string locationAddressTypeName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeLocationAddressTypeRefData>();

            string sql = @" select location_address_type_rcd, location_address_type_name, user_id, date_time
                            from [location_address_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(locationAddressTypeRcd)) {
                        sql += "  and location_address_type_rcd like '%' + @location_address_type_rcd + '%'";
                        command.Parameters.Add("@location_address_type_rcd", SqlDbType.NVarChar).Value = locationAddressTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(locationAddressTypeName)) {
                        sql += "  and location_address_type_name like '%' + @location_address_type_name + '%'";
                        command.Parameters.Add("@location_address_type_name", SqlDbType.NVarChar).Value = locationAddressTypeName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by location_address_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeLocationAddressTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["location_address_type_rcd"] != System.DBNull.Value) LocationAddressTypeRcd = (System.String) reader["location_address_type_rcd"];
            if (reader["location_address_type_name"] != System.DBNull.Value) LocationAddressTypeName = (System.String) reader["location_address_type_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [location_address_type_ref] (location_address_type_rcd, location_address_type_name, user_id, date_time)";
            sql += "            values (@location_address_type_rcd, @location_address_type_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = (System.String)LocationAddressTypeRcd;
                    command.Parameters.Add("@location_address_type_name",SqlDbType.NVarChar).Value = (System.String)LocationAddressTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [location_address_type_ref] (location_address_type_rcd, location_address_type_name, user_id, date_time)";
            sql += "            values (@location_address_type_rcd, @location_address_type_name, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = (System.String)LocationAddressTypeRcd;
                command.Parameters.Add("@location_address_type_name",SqlDbType.NVarChar).Value = (System.String)LocationAddressTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [location_address_type_ref] set
                 location_address_type_rcd = @location_address_type_rcd
                ,location_address_type_name = @location_address_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where location_address_type_rcd = @location_address_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = (System.String)LocationAddressTypeRcd;
                    command.Parameters.Add("@location_address_type_name",SqlDbType.NVarChar).Value = (System.String)LocationAddressTypeName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [location_address_type_ref] set
                 location_address_type_rcd = @location_address_type_rcd
                ,location_address_type_name = @location_address_type_name
                ,user_id = @user_id
                ,date_time = @date_time
            where location_address_type_rcd = @location_address_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = (System.String)LocationAddressTypeRcd;
                command.Parameters.Add("@location_address_type_name",SqlDbType.NVarChar).Value = (System.String)LocationAddressTypeName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string locationAddressTypeRcd) {
            string sql = @" delete [location_address_type_ref] 
                where location_address_type_rcd = @location_address_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@location_address_type_rcd",SqlDbType.NVarChar).Value = locationAddressTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
