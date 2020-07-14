/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:35:24 AM
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
        
        // fetch by Primary key into current object
        // parameters:
        //   clientContactMethodRcd: primary key of table client_contact_method_ref
        public void FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            // create query
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection and to make sure the query plan is pre-compiled
            string sql = @" select top 1 client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time
                            from [client_contact_method_ref]
                            where client_contact_method_rcd = @client_contact_method_rcd
                            order by client_contact_method_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked as locked by another transaction
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@client_contact_method_rcd",SqlDbType.NVarChar).Value = clientContactMethodRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
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

                    // populate serialized class if row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
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
        
        // fetch by Picker Member into new class instance
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
        
        // fetch all from table into new List of class instances
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
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
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
        
        // fetch all from table into new List of class instances, only populating specific columns , with a limit on number of returned rows and order by columns starting at a specific row
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
        
        // get a count of rows in table
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
        
        // fetch all from table into new List of class instances, filtered by any column
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
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["client_contact_method_rcd"] != System.DBNull.Value) ClientContactMethodRcd = (System.String) reader["client_contact_method_rcd"];
            if (reader["client_contact_method_name"] != System.DBNull.Value) ClientContactMethodName = (System.String) reader["client_contact_method_name"];
            if (reader["client_contact_method_description"] != System.DBNull.Value) ClientContactMethodDescription = (System.String) reader["client_contact_method_description"];
            if (reader["active_flag"] != System.DBNull.Value) ActiveFlag = (System.Boolean) reader["active_flag"];
            if (reader["sort_order"] != System.DBNull.Value) SortOrder = (System.Int32) reader["sort_order"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
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
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [client_contact_method_ref] (client_contact_method_rcd, client_contact_method_name, client_contact_method_description, active_flag, sort_order, user_id, date_time)";
            sql += "            values (@client_contact_method_rcd, @client_contact_method_name, @client_contact_method_description, @active_flag, @sort_order, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
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
        
        // update all object members on a row in table based on primary key
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
        
        // update all object members on a row in table based on primary key, on a transaction
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
        
        // delete a row in table based on primary key
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
