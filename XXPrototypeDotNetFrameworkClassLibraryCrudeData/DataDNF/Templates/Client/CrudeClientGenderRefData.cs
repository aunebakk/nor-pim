/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:19:43 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    public partial class ClientGenderRef {
        
        public const string Female = "FEA";
        
        public const string Male = "MAA";
        
        public const string Unknown = "UNA";
    }
    
    [Serializable()]
    public partial class CrudeClientGenderRefData {
        
        public string ClientGenderRcd { get; set; } //;
        
        public string ClientGenderName { get; set; } //;
        
        public string ClientGenderDescription { get; set; } //;
        
        public bool ActiveFlag { get; set; } //;
        
        public int SortOrder { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientGenderRcd(string clientGenderRcd) {
            string sql = @" select top 1 client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time
                            from [client_gender_ref]
                            where client_gender_rcd = @client_gender_rcd
                            order by client_gender_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = clientGenderRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientGenderRefData GetByClientGenderRcd(string clientGenderRcd) {
            string sql = @" select top 1 client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time
                            from [client_gender_ref]
                            where client_gender_rcd = @client_gender_rcd
                            order by client_gender_name";

            var ret = new CrudeClientGenderRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = clientGenderRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientGenderRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientGenderRefData>();

            string sql = @" select client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time
                            from [client_gender_ref]
                            where user_id = @user_id
                              
                            order by client_gender_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientGenderRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByClientGenderName(string clientGenderName) {
            string sql = @" select top 1 client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time
                            from [client_gender_ref]
                            where client_gender_name like '%' + @clientGenderName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@clientGenderName",SqlDbType.NVarChar).Value = clientGenderName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeClientGenderRefData> FetchAll() {
            var dataList = new List<CrudeClientGenderRefData>();

            string sql = @" select client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time
                            from [client_gender_ref]
                            order by client_gender_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientGenderRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientGenderRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientGenderRefData>();

            string sql = @" select top " + limit.ToString() + @" client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time
                            from [client_gender_ref]
                            order by client_gender_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientGenderRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientGenderRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientGenderRefData>();

            string sql = @" select client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time
                            from [client_gender_ref]
                            order by client_gender_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientGenderRefData();
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
            string sql = @" select count(*) as count from [client_gender_ref]";

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
        
        public static List<CrudeClientGenderRefData> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientGenderRefData>();

            string sql = @" select client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time
                            from [client_gender_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(clientGenderRcd)) {
                        sql += "  and client_gender_rcd like '%' + @client_gender_rcd + '%'";
                        command.Parameters.Add("@client_gender_rcd", SqlDbType.NVarChar).Value = clientGenderRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientGenderName)) {
                        sql += "  and client_gender_name like '%' + @client_gender_name + '%'";
                        command.Parameters.Add("@client_gender_name", SqlDbType.NVarChar).Value = clientGenderName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientGenderDescription)) {
                        sql += "  and client_gender_description like '%' + @client_gender_description + '%'";
                        command.Parameters.Add("@client_gender_description", SqlDbType.NVarChar).Value = clientGenderDescription.Replace("'","''");
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
                    sql += " order by client_gender_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientGenderRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_gender_rcd"] != System.DBNull.Value) ClientGenderRcd = (System.String) reader["client_gender_rcd"];
            if (reader["client_gender_name"] != System.DBNull.Value) ClientGenderName = (System.String) reader["client_gender_name"];
            if (reader["client_gender_description"] != System.DBNull.Value) ClientGenderDescription = (System.String) reader["client_gender_description"];
            if (reader["active_flag"] != System.DBNull.Value) ActiveFlag = (System.Boolean) reader["active_flag"];
            if (reader["sort_order"] != System.DBNull.Value) SortOrder = (System.Int32) reader["sort_order"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [client_gender_ref] (client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_gender_rcd, @client_gender_name, @client_gender_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = (System.String)ClientGenderRcd;
                    command.Parameters.Add("@client_gender_name",SqlDbType.NVarChar).Value = (System.String)ClientGenderName;
                    command.Parameters.Add("@client_gender_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientGenderDescription)) ? (object)DBNull.Value : (System.String)ClientGenderDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [client_gender_ref] (client_gender_rcd, client_gender_name, client_gender_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_gender_rcd, @client_gender_name, @client_gender_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = (System.String)ClientGenderRcd;
                command.Parameters.Add("@client_gender_name",SqlDbType.NVarChar).Value = (System.String)ClientGenderName;
                command.Parameters.Add("@client_gender_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientGenderDescription)) ? (object)DBNull.Value : (System.String)ClientGenderDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [client_gender_ref] set
                 client_gender_rcd = @client_gender_rcd
                ,client_gender_name = @client_gender_name
                ,client_gender_description = @client_gender_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_gender_rcd = @client_gender_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = (System.String)ClientGenderRcd;
                    command.Parameters.Add("@client_gender_name",SqlDbType.NVarChar).Value = (System.String)ClientGenderName;
                    command.Parameters.Add("@client_gender_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientGenderDescription)) ? (object)DBNull.Value : (System.String)ClientGenderDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_gender_ref] set
                 client_gender_rcd = @client_gender_rcd
                ,client_gender_name = @client_gender_name
                ,client_gender_description = @client_gender_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_gender_rcd = @client_gender_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = (System.String)ClientGenderRcd;
                command.Parameters.Add("@client_gender_name",SqlDbType.NVarChar).Value = (System.String)ClientGenderName;
                command.Parameters.Add("@client_gender_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientGenderDescription)) ? (object)DBNull.Value : (System.String)ClientGenderDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string clientGenderRcd) {
            string sql = @" delete [client_gender_ref] 
                where client_gender_rcd = @client_gender_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_gender_rcd",SqlDbType.NVarChar).Value = clientGenderRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
