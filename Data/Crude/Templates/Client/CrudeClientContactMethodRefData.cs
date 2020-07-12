﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:40:46 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    public partial class ClientContactMethodRef {
        
        public const string BusinessPhone = "BPE";
        
        public const string EMail = "EMA";
        
        public const string Fax = "FAX";
        
        public const string HomePhone = "HPE";
        
        public const string InternationalPhone = "IPE";
        
        public const string LocalPhone = "LPE";
        
        public const string MMSMobile = "MME";
        
        public const string Mobile = "MOA";
        
        public const string SMSMobile = "SME";
        
        public const string Telephone = "TEA";
    }
    
    [Serializable()]
    public partial class CrudeClientContactMethodRefData {
        
        public string ClientContactMethodRcd { get; set; }
        
        public string ClientContactMethodName { get; set; }
        
        public string ClientContactMethodDescription { get; set; }
        
        public bool ActiveFlag { get; set; }
        
        public int SortOrder { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public void FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            string sql = @" select top 1 client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            where client_contact_method_rcd = @client_contact_method_rcd
                            order by client_contact_method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = clientContactMethodRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeClientContactMethodRefData GetByClientContactMethodRcd(string clientContactMethodRcd) {
            string sql = @" select top 1 client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            where client_contact_method_rcd = @client_contact_method_rcd
                            order by client_contact_method_name";

            var ret = new CrudeClientContactMethodRefData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = clientContactMethodRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeClientContactMethodRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeClientContactMethodRefData>();

            string sql = @" select client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            where user_id = @user_id
                              
                            order by client_contact_method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByClientContactMethodName(string clientContactMethodName) {
            string sql = @" select top 1 client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            where client_contact_method_name like '%' + @clientContactMethodName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@clientContactMethodName",SqlDbType.NVarChar).Value = clientContactMethodName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeClientContactMethodRefData> FetchAll() {
            var dataList = new List<CrudeClientContactMethodRefData>();

            string sql = @" select client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            order by client_contact_method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientContactMethodRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeClientContactMethodRefData>();

            string sql = @" select top " + limit.ToString() + @" client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            order by client_contact_method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeClientContactMethodRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeClientContactMethodRefData>();

            string sql = @" select client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            order by client_contact_method_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeClientContactMethodRefData();
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
            string sql = @" select count(*) as count from [client_contact_method_ref]";

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
        
        public static List<CrudeClientContactMethodRefData> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeClientContactMethodRefData>();

            string sql = @" select client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(clientContactMethodRcd)) {
                        sql += "  and client_contact_method_rcd like '%' + @client_contact_method_rcd + '%'";
                        command.Parameters.Add("@client_contact_method_rcd", SqlDbType.NVarChar).Value = clientContactMethodRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientContactMethodName)) {
                        sql += "  and client_contact_method_name like '%' + @client_contact_method_name + '%'";
                        command.Parameters.Add("@client_contact_method_name", SqlDbType.NVarChar).Value = clientContactMethodName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(clientContactMethodDescription)) {
                        sql += "  and client_contact_method_description like '%' + @client_contact_method_description + '%'";
                        command.Parameters.Add("@client_contact_method_description", SqlDbType.NVarChar).Value = clientContactMethodDescription.Replace("'","''");
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
                    sql += " order by client_contact_method_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeClientContactMethodRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["client_contact_method_rcd"] != System.DBNull.Value) ClientContactMethodRcd = (System.String) reader["client_contact_method_rcd"];
            if (reader["client_contact_method_name"] != System.DBNull.Value) ClientContactMethodName = (System.String) reader["client_contact_method_name"];
            if (reader["client_contact_method_description"] != System.DBNull.Value) ClientContactMethodDescription = (System.String) reader["client_contact_method_description"];
            if (reader["active_flag"] != System.DBNull.Value) ActiveFlag = (System.Boolean) reader["active_flag"];
            if (reader["sort_order"] != System.DBNull.Value) SortOrder = (System.Int32) reader["sort_order"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [client_contact_method_ref] (client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_contact_method_rcd, @client_contact_method_name, @client_contact_method_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                    command.Parameters.Add("@client_contact_method_name",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodName;
                    command.Parameters.Add("@client_contact_method_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientContactMethodDescription)) ? (object)DBNull.Value : (System.String)ClientContactMethodDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [client_contact_method_ref] (client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_contact_method_rcd, @client_contact_method_name, @client_contact_method_description, @active_flag, @sort_order, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                command.Parameters.Add("@client_contact_method_name",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodName;
                command.Parameters.Add("@client_contact_method_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientContactMethodDescription)) ? (object)DBNull.Value : (System.String)ClientContactMethodDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [client_contact_method_ref] set
                 client_contact_method_rcd = @client_contact_method_rcd
                ,client_contact_method_name = @client_contact_method_name
                ,client_contact_method_description = @client_contact_method_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_contact_method_rcd = @client_contact_method_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                    command.Parameters.Add("@client_contact_method_name",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodName;
                    command.Parameters.Add("@client_contact_method_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientContactMethodDescription)) ? (object)DBNull.Value : (System.String)ClientContactMethodDescription;
                    command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                    command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [client_contact_method_ref] set
                 client_contact_method_rcd = @client_contact_method_rcd
                ,client_contact_method_name = @client_contact_method_name
                ,client_contact_method_description = @client_contact_method_description
                ,active_flag = @active_flag
                ,sort_order = @sort_order
                ,user_id = @user_id
                ,date_time = @date_time
            where client_contact_method_rcd = @client_contact_method_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodRcd;
                command.Parameters.Add("@client_contact_method_name",SqlDbType.NVarChar).Value = (System.String)ClientContactMethodName;
                command.Parameters.Add("@client_contact_method_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(ClientContactMethodDescription)) ? (object)DBNull.Value : (System.String)ClientContactMethodDescription;
                command.Parameters.Add("@active_flag",SqlDbType.Bit).Value = (System.Boolean)ActiveFlag;
                command.Parameters.Add("@sort_order",SqlDbType.Int).Value = (System.Int32)SortOrder;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string clientContactMethodRcd) {
            string sql = @" delete [client_contact_method_ref] 
                where client_contact_method_rcd = @client_contact_method_rcd";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = clientContactMethodRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
