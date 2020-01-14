/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:18:04 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeDefaultUserData {
        
        public System.Guid DefaultUserId { get; set; } //;
        
        public string DefaultUserCode { get; set; } //;
        
        public string DefaultUserName { get; set; } //;
        
        public string Email { get; set; } //;
        
        public string Password { get; set; } //;
        
        public string DefaultStateRcd { get; set; } //;
        
        public System.Guid CreatedByDefaultUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public System.DateTime LastActivityDateTime { get; set; } //;
        
        public void FetchByDefaultUserId(System.Guid defaultUserId) {
            string sql = @" select top 1 default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where default_user_id = @default_user_id
                            order by default_user_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultUserData GetByDefaultUserId(System.Guid defaultUserId) {
            string sql = @" select top 1 default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where default_user_id = @default_user_id
                            order by default_user_name";

            var ret = new CrudeDefaultUserData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultUserData> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId) {
            var dataList = new List<CrudeDefaultUserData>();

            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where created_by_default_user_id = @created_by_default_user_id
                              
                            order by default_user_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@created_by_default_user_id", SqlDbType.UniqueIdentifier).Value = createdByDefaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserData> FetchByDefaultStateRcd(string defaultStateRcd) {
            var dataList = new List<CrudeDefaultUserData>();

            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where default_state_rcd = @default_state_rcd
                              
                            order by default_user_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_state_rcd", SqlDbType.NVarChar).Value = defaultStateRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByDefaultUserName(string defaultUserName) {
            string sql = @" select top 1 default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where default_user_name like '%' + @defaultUserName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@defaultUserName",SqlDbType.NVarChar).Value = defaultUserName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultUserData> FetchAll() {
            var dataList = new List<CrudeDefaultUserData>();

            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            order by default_user_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultUserData>();

            string sql = @" select top " + limit.ToString() + @" default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            order by default_user_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultUserData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultUserData>();

            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            order by default_user_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultUserData();
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
            string sql = @" select count(*) as count from [default_user]";

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
        
        public static List<CrudeDefaultUserData> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime) {
            var dataList = new List<CrudeDefaultUserData>();

            string sql = @" select default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time
                            from [default_user]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (!string.IsNullOrEmpty(defaultUserCode)) {
                        sql += "  and default_user_code like '%' + @default_user_code + '%'";
                        command.Parameters.Add("@default_user_code", SqlDbType.NVarChar).Value = defaultUserCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultUserName)) {
                        sql += "  and default_user_name like '%' + @default_user_name + '%'";
                        command.Parameters.Add("@default_user_name", SqlDbType.NVarChar).Value = defaultUserName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(email)) {
                        sql += "  and email like '%' + @email + '%'";
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(password)) {
                        sql += "  and password like '%' + @password + '%'";
                        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultStateRcd)) {
                        sql += "  and default_state_rcd like '%' + @default_state_rcd + '%'";
                        command.Parameters.Add("@default_state_rcd", SqlDbType.NVarChar).Value = defaultStateRcd.Replace("'","''");
                    }
                    if (createdByDefaultUserId != Guid.Empty) {
                        sql += "  and created_by_default_user_id = @created_by_default_user_id";
                        command.Parameters.Add("@created_by_default_user_id", SqlDbType.UniqueIdentifier).Value = createdByDefaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (lastActivityDateTime != DateTime.MinValue) {
                        sql += "  and last_activity_date_time = @last_activity_date_time";
                        command.Parameters.Add("@last_activity_date_time", SqlDbType.DateTime).Value = lastActivityDateTime;
                    }
                    sql += " order by default_user_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["default_user_code"] != System.DBNull.Value) DefaultUserCode = (System.String) reader["default_user_code"];
            if (reader["default_user_name"] != System.DBNull.Value) DefaultUserName = (System.String) reader["default_user_name"];
            if (reader["email"] != System.DBNull.Value) Email = (System.String) reader["email"];
            if (reader["password"] != System.DBNull.Value) Password = (System.String) reader["password"];
            if (reader["default_state_rcd"] != System.DBNull.Value) DefaultStateRcd = (System.String) reader["default_state_rcd"];
            if (reader["created_by_default_user_id"] != System.DBNull.Value) CreatedByDefaultUserId = (System.Guid) reader["created_by_default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["last_activity_date_time"] != System.DBNull.Value) LastActivityDateTime = (System.DateTime) reader["last_activity_date_time"];
        }
        
        public void Insert() {

            if (DefaultUserId == Guid.Empty)
                DefaultUserId = Guid.NewGuid();

            string sql = "insert into [default_user] (default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time)";
            sql += "            values (@default_user_id, @default_user_code, @default_user_name, @email, @password, @default_state_rcd, @created_by_default_user_id, @date_time, @last_activity_date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@default_user_code",SqlDbType.NVarChar).Value = (System.String)DefaultUserCode;
                    command.Parameters.Add("@default_user_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserName;
                    command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Email)) ? (object)DBNull.Value : (System.String)Email;
                    command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Password)) ? (object)DBNull.Value : (System.String)Password;
                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                    command.Parameters.Add("@created_by_default_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByDefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByDefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@last_activity_date_time",SqlDbType.DateTime).Value = (LastActivityDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)LastActivityDateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultUserId == Guid.Empty)
                DefaultUserId = Guid.NewGuid();

            string sql = "insert into [default_user] (default_user_id, default_user_code, default_user_name, email, password, default_state_rcd, created_by_default_user_id, date_time, last_activity_date_time)";
            sql += "            values (@default_user_id, @default_user_code, @default_user_name, @email, @password, @default_state_rcd, @created_by_default_user_id, @date_time, @last_activity_date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@default_user_code",SqlDbType.NVarChar).Value = (System.String)DefaultUserCode;
                command.Parameters.Add("@default_user_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserName;
                command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Email)) ? (object)DBNull.Value : (System.String)Email;
                command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Password)) ? (object)DBNull.Value : (System.String)Password;
                command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                command.Parameters.Add("@created_by_default_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByDefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByDefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@last_activity_date_time",SqlDbType.DateTime).Value = (LastActivityDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)LastActivityDateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_user] set
                 default_user_id = @default_user_id
                ,default_user_code = @default_user_code
                ,default_user_name = @default_user_name
                ,email = @email
                ,password = @password
                ,default_state_rcd = @default_state_rcd
                ,created_by_default_user_id = @created_by_default_user_id
                ,date_time = @date_time
                ,last_activity_date_time = @last_activity_date_time
            where default_user_id = @default_user_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                    command.Parameters.Add("@default_user_code",SqlDbType.NVarChar).Value = (System.String)DefaultUserCode;
                    command.Parameters.Add("@default_user_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserName;
                    command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Email)) ? (object)DBNull.Value : (System.String)Email;
                    command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Password)) ? (object)DBNull.Value : (System.String)Password;
                    command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                    command.Parameters.Add("@created_by_default_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByDefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByDefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@last_activity_date_time",SqlDbType.DateTime).Value = (LastActivityDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)LastActivityDateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_user] set
                 default_user_id = @default_user_id
                ,default_user_code = @default_user_code
                ,default_user_name = @default_user_name
                ,email = @email
                ,password = @password
                ,default_state_rcd = @default_state_rcd
                ,created_by_default_user_id = @created_by_default_user_id
                ,date_time = @date_time
                ,last_activity_date_time = @last_activity_date_time
            where default_user_id = @default_user_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultUserId;
                command.Parameters.Add("@default_user_code",SqlDbType.NVarChar).Value = (System.String)DefaultUserCode;
                command.Parameters.Add("@default_user_name",SqlDbType.NVarChar).Value = (System.String)DefaultUserName;
                command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Email)) ? (object)DBNull.Value : (System.String)Email;
                command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Password)) ? (object)DBNull.Value : (System.String)Password;
                command.Parameters.Add("@default_state_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultStateRcd;
                command.Parameters.Add("@created_by_default_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByDefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByDefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@last_activity_date_time",SqlDbType.DateTime).Value = (LastActivityDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)LastActivityDateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultUserId) {
            string sql = @" delete [default_user] 
                where default_user_id = @default_user_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
