/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:22:53 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class ClientLinkTypeRef {
        
        public const string WebPage = "WPE";
    }
    
    //[Serializable()]
    public partial class CrudeClientLinkTypeRefData {
        
        public string ClientLinkTypeRcd { get; set; } //;
        
        public string ClientLinkTypeName { get; set; } //;
        
        public string ClientLinkTypeDescription { get; set; } //;
        
        public bool ActiveFlag { get; set; } //;
        
        public int SortOrder { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            string sql = @" select top 1 client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time
                            from [client_link_type_ref]
                            where client_link_type_rcd = @client_link_type_rcd
                            order by client_link_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = clientLinkTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientLinkTypeRefData GetByClientLinkTypeRcd(string clientLinkTypeRcd) {
            string sql = @" select top 1 client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time
                            from [client_link_type_ref]
                            where client_link_type_rcd = @client_link_type_rcd
                            order by client_link_type_name";

            var ret = new CrudeClientLinkTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = clientLinkTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientLinkTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientLinkTypeRefData>();

            string sql = @" select client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time
                            from [client_link_type_ref]
                            where user_id = @user_id
                              
                            order by client_link_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByClientLinkTypeName(string clientLinkTypeName) {
            string sql = @" select top 1 client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time
                            from [client_link_type_ref]
                            where client_link_type_name like '%' + @clientLinkTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@clientLinkTypeName",SqlDbType.NVarChar).Value = clientLinkTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeClientLinkTypeRefData> FetchAll() {
            var dataList = new List<CrudeClientLinkTypeRefData>();

            string sql = @" select client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time
                            from [client_link_type_ref]
                            order by client_link_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientLinkTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientLinkTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time
                            from [client_link_type_ref]
                            order by client_link_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientLinkTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientLinkTypeRefData>();

            string sql = @" select client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time
                            from [client_link_type_ref]
                            order by client_link_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientLinkTypeRefData();
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
            string sql = @" select count(*) as count from [client_link_type_ref]";

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
        
        public static List<CrudeClientLinkTypeRefData> FetchWithFilter(string clientLinkTypeRcd, string clientLinkTypeName, string clientLinkTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientLinkTypeRefData>();

            string sql = @" select client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time
                            from [client_link_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(clientLinkTypeRcd)) {
                        sql += "  and client_link_type_rcd like '%' + @client_link_type_rcd + '%'";
                        command.Parameters.Add("@client_link_type_rcd", SqlDbType.NVarChar).Value = clientLinkTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientLinkTypeName)) {
                        sql += "  and client_link_type_name like '%' + @client_link_type_name + '%'";
                        command.Parameters.Add("@client_link_type_name", SqlDbType.NVarChar).Value = clientLinkTypeName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientLinkTypeDescription)) {
                        sql += "  and client_link_type_description like '%' + @client_link_type_description + '%'";
                        command.Parameters.Add("@client_link_type_description", SqlDbType.NVarChar).Value = clientLinkTypeDescription.Replace("'","''");
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
                    sql += " order by client_link_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientLinkTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_link_type_rcd"] != System.DBNull.Value) ClientLinkTypeRcd = (System.String) reader["client_link_type_rcd"];
            if (reader["client_link_type_name"] != System.DBNull.Value) ClientLinkTypeName = (System.String) reader["client_link_type_name"];
            if (reader["client_link_type_description"] != System.DBNull.Value) ClientLinkTypeDescription = (System.String) reader["client_link_type_description"];
            if (reader["active_flag"] != System.DBNull.Value) ActiveFlag = (System.Boolean) reader["active_flag"];
            if (reader["sort_order"] != System.DBNull.Value) SortOrder = (System.Int32) reader["sort_order"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [client_link_type_ref] (client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_link_type_rcd, @client_link_type_name, @client_link_type_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeRcd;
                    command.Parameters.Add("@client_link_type_name",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeName;
                    command.Parameters.Add("@client_link_type_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientLinkTypeDescription)) ? (object)DBNull.Value : (System.String)ClientLinkTypeDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [client_link_type_ref] (client_link_type_rcd, client_link_type_name, client_link_type_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_link_type_rcd, @client_link_type_name, @client_link_type_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeRcd;
                command.Parameters.Add("@client_link_type_name",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeName;
                command.Parameters.Add("@client_link_type_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientLinkTypeDescription)) ? (object)DBNull.Value : (System.String)ClientLinkTypeDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [client_link_type_ref] set
                 client_link_type_rcd = @client_link_type_rcd
                ,client_link_type_name = @client_link_type_name
                ,client_link_type_description = @client_link_type_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_link_type_rcd = @client_link_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeRcd;
                    command.Parameters.Add("@client_link_type_name",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeName;
                    command.Parameters.Add("@client_link_type_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientLinkTypeDescription)) ? (object)DBNull.Value : (System.String)ClientLinkTypeDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_link_type_ref] set
                 client_link_type_rcd = @client_link_type_rcd
                ,client_link_type_name = @client_link_type_name
                ,client_link_type_description = @client_link_type_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_link_type_rcd = @client_link_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeRcd;
                command.Parameters.Add("@client_link_type_name",SqlDbType.NVarChar).Value = (System.String)ClientLinkTypeName;
                command.Parameters.Add("@client_link_type_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientLinkTypeDescription)) ? (object)DBNull.Value : (System.String)ClientLinkTypeDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string clientLinkTypeRcd) {
            string sql = @" delete [client_link_type_ref] 
                where client_link_type_rcd = @client_link_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_link_type_rcd",SqlDbType.NVarChar).Value = clientLinkTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
