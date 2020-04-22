/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:20 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class ClientNationalityRef {
        
        public const string Africa = "AFA";
        
        public const string Americas = "AMA";
        
        public const string Asia = "ASA";
        
        public const string Europe = "EUA";
        
        public const string Oceania = "OCA";
    }
    
    //[Serializable()]
    public partial class CrudeClientNationalityRefData {
        
        public string ClientNationalityRcd { get; set; } //;
        
        public string ClientNationalityName { get; set; } //;
        
        public string ClientNationalityDescription { get; set; } //;
        
        public bool ActiveFlag { get; set; } //;
        
        public int SortOrder { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientNationalityRcd(string clientNationalityRcd) {
            string sql = @" select top 1 client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time
                            from [client_nationality_ref]
                            where client_nationality_rcd = @client_nationality_rcd
                            order by client_nationality_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = clientNationalityRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientNationalityRefData GetByClientNationalityRcd(string clientNationalityRcd) {
            string sql = @" select top 1 client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time
                            from [client_nationality_ref]
                            where client_nationality_rcd = @client_nationality_rcd
                            order by client_nationality_name";

            var ret = new CrudeClientNationalityRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = clientNationalityRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientNationalityRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientNationalityRefData>();

            string sql = @" select client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time
                            from [client_nationality_ref]
                            where user_id = @user_id
                              
                            order by client_nationality_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientNationalityRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByClientNationalityName(string clientNationalityName) {
            string sql = @" select top 1 client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time
                            from [client_nationality_ref]
                            where client_nationality_name like '%' + @clientNationalityName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@clientNationalityName",SqlDbType.NVarChar).Value = clientNationalityName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeClientNationalityRefData> FetchAll() {
            var dataList = new List<CrudeClientNationalityRefData>();

            string sql = @" select client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time
                            from [client_nationality_ref]
                            order by client_nationality_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientNationalityRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientNationalityRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientNationalityRefData>();

            string sql = @" select top " + limit.ToString() + @" client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time
                            from [client_nationality_ref]
                            order by client_nationality_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientNationalityRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientNationalityRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientNationalityRefData>();

            string sql = @" select client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time
                            from [client_nationality_ref]
                            order by client_nationality_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientNationalityRefData();
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
            string sql = @" select count(*) as count from [client_nationality_ref]";

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
        
        public static List<CrudeClientNationalityRefData> FetchWithFilter(string clientNationalityRcd, string clientNationalityName, string clientNationalityDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientNationalityRefData>();

            string sql = @" select client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time
                            from [client_nationality_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(clientNationalityRcd)) {
                        sql += "  and client_nationality_rcd like '%' + @client_nationality_rcd + '%'";
                        command.Parameters.Add("@client_nationality_rcd", SqlDbType.NVarChar).Value = clientNationalityRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientNationalityName)) {
                        sql += "  and client_nationality_name like '%' + @client_nationality_name + '%'";
                        command.Parameters.Add("@client_nationality_name", SqlDbType.NVarChar).Value = clientNationalityName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientNationalityDescription)) {
                        sql += "  and client_nationality_description like '%' + @client_nationality_description + '%'";
                        command.Parameters.Add("@client_nationality_description", SqlDbType.NVarChar).Value = clientNationalityDescription.Replace("'","''");
                    }
                    if (activeFlag != false) {
                        sql += "  and active_flag = @active_flag";
                        command.Parameters.Add("@active_flag", SqlDbType.Bit).Value = activeFlag;
                    }
                    if (sortOrder != 0) {
                        sql += "  and sort_order = @sort_order";
                        command.Parameters.Add("@sort_order", SqlDbType.Int).Value = sortOrder;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by client_nationality_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientNationalityRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_nationality_rcd"] != System.DBNull.Value) ClientNationalityRcd = (System.String) reader["client_nationality_rcd"];
            if (reader["client_nationality_name"] != System.DBNull.Value) ClientNationalityName = (System.String) reader["client_nationality_name"];
            if (reader["client_nationality_description"] != System.DBNull.Value) ClientNationalityDescription = (System.String) reader["client_nationality_description"];
            if (reader["active_flag"] != System.DBNull.Value) ActiveFlag = (System.Boolean) reader["active_flag"];
            if (reader["sort_order"] != System.DBNull.Value) SortOrder = (System.Int32) reader["sort_order"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [client_nationality_ref] (client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_nationality_rcd, @client_nationality_name, @client_nationality_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = (System.String)ClientNationalityRcd;
                    command.Parameters.Add("@client_nationality_name",SqlDbType.NVarChar).Value = (System.String)ClientNationalityName;
                    command.Parameters.Add("@client_nationality_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientNationalityDescription)) ? (object)DBNull.Value : (System.String)ClientNationalityDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [client_nationality_ref] (client_nationality_rcd, client_nationality_name, client_nationality_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_nationality_rcd, @client_nationality_name, @client_nationality_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = (System.String)ClientNationalityRcd;
                command.Parameters.Add("@client_nationality_name",SqlDbType.NVarChar).Value = (System.String)ClientNationalityName;
                command.Parameters.Add("@client_nationality_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientNationalityDescription)) ? (object)DBNull.Value : (System.String)ClientNationalityDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [client_nationality_ref] set
                 client_nationality_rcd = @client_nationality_rcd
                ,client_nationality_name = @client_nationality_name
                ,client_nationality_description = @client_nationality_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_nationality_rcd = @client_nationality_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = (System.String)ClientNationalityRcd;
                    command.Parameters.Add("@client_nationality_name",SqlDbType.NVarChar).Value = (System.String)ClientNationalityName;
                    command.Parameters.Add("@client_nationality_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientNationalityDescription)) ? (object)DBNull.Value : (System.String)ClientNationalityDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_nationality_ref] set
                 client_nationality_rcd = @client_nationality_rcd
                ,client_nationality_name = @client_nationality_name
                ,client_nationality_description = @client_nationality_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_nationality_rcd = @client_nationality_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = (System.String)ClientNationalityRcd;
                command.Parameters.Add("@client_nationality_name",SqlDbType.NVarChar).Value = (System.String)ClientNationalityName;
                command.Parameters.Add("@client_nationality_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientNationalityDescription)) ? (object)DBNull.Value : (System.String)ClientNationalityDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string clientNationalityRcd) {
            string sql = @" delete [client_nationality_ref] 
                where client_nationality_rcd = @client_nationality_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_nationality_rcd",SqlDbType.NVarChar).Value = clientNationalityRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
