/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:23 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class ClientTitleRef {
        
        public const string Child = "CHA";
        
        public const string Infant = "INA";
        
        public const string Mr = "MR";
        
        public const string Mrs = "MRS";
    }
    
    //[Serializable()]
    public partial class CrudeClientTitleRefData {
        
        public string ClientTitleRcd { get; set; } //;
        
        public string ClientTitleName { get; set; } //;
        
        public string ClientTitleDescription { get; set; } //;
        
        public bool ActiveFlag { get; set; } //;
        
        public int SortOrder { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByClientTitleRcd(string clientTitleRcd) {
            string sql = @" select top 1 client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time
                            from [client_title_ref]
                            where client_title_rcd = @client_title_rcd
                            order by client_title_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = clientTitleRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientTitleRefData GetByClientTitleRcd(string clientTitleRcd) {
            string sql = @" select top 1 client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time
                            from [client_title_ref]
                            where client_title_rcd = @client_title_rcd
                            order by client_title_name";

            var ret = new CrudeClientTitleRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = clientTitleRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientTitleRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientTitleRefData>();

            string sql = @" select client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time
                            from [client_title_ref]
                            where user_id = @user_id
                              
                            order by client_title_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientTitleRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByClientTitleName(string clientTitleName) {
            string sql = @" select top 1 client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time
                            from [client_title_ref]
                            where client_title_name like '%' + @clientTitleName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@clientTitleName",SqlDbType.NVarChar).Value = clientTitleName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeClientTitleRefData> FetchAll() {
            var dataList = new List<CrudeClientTitleRefData>();

            string sql = @" select client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time
                            from [client_title_ref]
                            order by client_title_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientTitleRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientTitleRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientTitleRefData>();

            string sql = @" select top " + limit.ToString() + @" client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time
                            from [client_title_ref]
                            order by client_title_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientTitleRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientTitleRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientTitleRefData>();

            string sql = @" select client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time
                            from [client_title_ref]
                            order by client_title_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientTitleRefData();
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
            string sql = @" select count(*) as count from [client_title_ref]";

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
        
        public static List<CrudeClientTitleRefData> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientTitleRefData>();

            string sql = @" select client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time
                            from [client_title_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(clientTitleRcd)) {
                        sql += "  and client_title_rcd like '%' + @client_title_rcd + '%'";
                        command.Parameters.Add("@client_title_rcd", SqlDbType.NVarChar).Value = clientTitleRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientTitleName)) {
                        sql += "  and client_title_name like '%' + @client_title_name + '%'";
                        command.Parameters.Add("@client_title_name", SqlDbType.NVarChar).Value = clientTitleName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientTitleDescription)) {
                        sql += "  and client_title_description like '%' + @client_title_description + '%'";
                        command.Parameters.Add("@client_title_description", SqlDbType.NVarChar).Value = clientTitleDescription.Replace("'","''");
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
                    sql += " order by client_title_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientTitleRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_title_rcd"] != System.DBNull.Value) ClientTitleRcd = (System.String) reader["client_title_rcd"];
            if (reader["client_title_name"] != System.DBNull.Value) ClientTitleName = (System.String) reader["client_title_name"];
            if (reader["client_title_description"] != System.DBNull.Value) ClientTitleDescription = (System.String) reader["client_title_description"];
            if (reader["active_flag"] != System.DBNull.Value) ActiveFlag = (System.Boolean) reader["active_flag"];
            if (reader["sort_order"] != System.DBNull.Value) SortOrder = (System.Int32) reader["sort_order"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [client_title_ref] (client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_title_rcd, @client_title_name, @client_title_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = (System.String)ClientTitleRcd;
                    command.Parameters.Add("@client_title_name",SqlDbType.NVarChar).Value = (System.String)ClientTitleName;
                    command.Parameters.Add("@client_title_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientTitleDescription)) ? (object)DBNull.Value : (System.String)ClientTitleDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [client_title_ref] (client_title_rcd, client_title_name, client_title_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_title_rcd, @client_title_name, @client_title_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = (System.String)ClientTitleRcd;
                command.Parameters.Add("@client_title_name",SqlDbType.NVarChar).Value = (System.String)ClientTitleName;
                command.Parameters.Add("@client_title_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientTitleDescription)) ? (object)DBNull.Value : (System.String)ClientTitleDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [client_title_ref] set
                 client_title_rcd = @client_title_rcd
                ,client_title_name = @client_title_name
                ,client_title_description = @client_title_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_title_rcd = @client_title_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = (System.String)ClientTitleRcd;
                    command.Parameters.Add("@client_title_name",SqlDbType.NVarChar).Value = (System.String)ClientTitleName;
                    command.Parameters.Add("@client_title_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientTitleDescription)) ? (object)DBNull.Value : (System.String)ClientTitleDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_title_ref] set
                 client_title_rcd = @client_title_rcd
                ,client_title_name = @client_title_name
                ,client_title_description = @client_title_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_title_rcd = @client_title_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = (System.String)ClientTitleRcd;
                command.Parameters.Add("@client_title_name",SqlDbType.NVarChar).Value = (System.String)ClientTitleName;
                command.Parameters.Add("@client_title_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientTitleDescription)) ? (object)DBNull.Value : (System.String)ClientTitleDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string clientTitleRcd) {
            string sql = @" delete [client_title_ref] 
                where client_title_rcd = @client_title_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_title_rcd",SqlDbType.NVarChar).Value = clientTitleRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
