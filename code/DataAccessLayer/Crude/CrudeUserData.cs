using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeUserData {
        
        public System.Guid UserId { get; set; } //;
        
        public string UserCode { get; set; } //;
        
        public string UserName { get; set; } //;
        
        public string Email { get; set; } //;
        
        public string Password { get; set; } //;
        
        public string StateRcd { get; set; } //;
        
        public System.Guid CreatedByUserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByUserId(System.Guid userId) {
            string sql = @" select top 1 user_id, user_code, user_name, email, password, state_rcd, created_by_user_id, date_time
                            from [user]
                            where user_id = @user_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public void FetchByUserCode(string userCode) {
            string sql = @" select top 1 user_id, user_code, user_name, email, password, state_rcd, created_by_user_id, date_time
                            from [user]
                            where user_code like '%' + @userCode + '%'
                              ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@userCode",SqlDbType.NVarChar).Value = userCode;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public List<CrudeUserData> FetchAll() {
            var dataList = new List<CrudeUserData>();

            string sql = @" select user_id, user_code, user_name, email, password, state_rcd, created_by_user_id, date_time
                            from [user]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeUserData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeUserData>();

            string sql = @" select top " + limit.ToString() + @" user_id, user_code, user_name, email, password, state_rcd, created_by_user_id, date_time
                            from [user]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeUserData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeUserData>();

            string sql = @" select user_id, user_code, user_name, email, password, state_rcd, created_by_user_id, date_time
                            from [user]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeUserData();
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
        
        public int FetchAllCount() {
            string sql = @" select count(*) as count from [user]";

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
        
        public List<CrudeUserData> FetchWithFilter(System.Guid userId, string userCode, string userName, string email, string password, string stateRcd, System.DateTime dateTime) {
            var dataList = new List<CrudeUserData>();

            string sql = @" select user_id, user_code, user_name, email, password, state_rcd, created_by_user_id, date_time
                            from [user]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (userCode != "") {
                        sql += "  and user_code like '%' + @user_code + '%'";
                        command.Parameters.Add("@user_code", SqlDbType.NVarChar).Value = userCode.Replace("'","''");
                    }
                    if (userName != "") {
                        sql += "  and user_name like '%' + @user_name + '%'";
                        command.Parameters.Add("@user_name", SqlDbType.NVarChar).Value = userName.Replace("'","''");
                    }
                    if (email != "") {
                        sql += "  and email like '%' + @email + '%'";
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email.Replace("'","''");
                    }
                    if (password != "") {
                        sql += "  and password like '%' + @password + '%'";
                        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password.Replace("'","''");
                    }
                    if (stateRcd != "") {
                        sql += "  and state_rcd like '%' + @state_rcd + '%'";
                        command.Parameters.Add("@state_rcd", SqlDbType.NVarChar).Value = stateRcd.Replace("'","''");
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeUserData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["user_code"] != System.DBNull.Value) UserCode = (System.String) reader["user_code"];
            if (reader["user_name"] != System.DBNull.Value) UserName = (System.String) reader["user_name"];
            if (reader["email"] != System.DBNull.Value) Email = (System.String) reader["email"];
            if (reader["password"] != System.DBNull.Value) Password = (System.String) reader["password"];
            if (reader["state_rcd"] != System.DBNull.Value) StateRcd = (System.String) reader["state_rcd"];
            if (reader["created_by_user_id"] != System.DBNull.Value) CreatedByUserId = (System.Guid) reader["created_by_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (UserId == Guid.Empty)
                UserId = Guid.NewGuid();

            string sql = "insert into [user] (user_id, user_code, user_name, email, password, state_rcd, created_by_user_id, date_time)";
            sql += "            values (@user_id, @user_code, @user_name, @email, @password, @state_rcd, @created_by_user_id, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@user_code",SqlDbType.NVarChar).Value = (UserCode == null ? (object)DBNull.Value : (System.String)UserCode);
                    command.Parameters.Add("@user_name",SqlDbType.NVarChar).Value = (UserName == null ? (object)DBNull.Value : (System.String)UserName);
                    command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (Email == null ? (object)DBNull.Value : (System.String)Email);
                    command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (Password == null ? (object)DBNull.Value : (System.String)Password);
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (StateRcd == null ? (object)DBNull.Value : (System.String)StateRcd);
                    command.Parameters.Add("@created_by_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (UserId == Guid.Empty)
                UserId = Guid.NewGuid();

            string sql = "insert into [user] (user_id, user_code, user_name, email, password, state_rcd, created_by_user_id, date_time)";
            sql += "            values (@user_id, @user_code, @user_name, @email, @password, @state_rcd, @created_by_user_id, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@user_code",SqlDbType.NVarChar).Value = (UserCode == null ? (object)DBNull.Value : (System.String)UserCode);
                command.Parameters.Add("@user_name",SqlDbType.NVarChar).Value = (UserName == null ? (object)DBNull.Value : (System.String)UserName);
                command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (Email == null ? (object)DBNull.Value : (System.String)Email);
                command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (Password == null ? (object)DBNull.Value : (System.String)Password);
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (StateRcd == null ? (object)DBNull.Value : (System.String)StateRcd);
                command.Parameters.Add("@created_by_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [user] set
                 user_id = @user_id
                ,user_code = @user_code
                ,user_name = @user_name
                ,email = @email
                ,password = @password
                ,state_rcd = @state_rcd
                ,created_by_user_id = @created_by_user_id
                ,date_time = @date_time
            where user_id = @user_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                    command.Parameters.Add("@user_code",SqlDbType.NVarChar).Value = (UserCode == null ? (object)DBNull.Value : (System.String)UserCode);
                    command.Parameters.Add("@user_name",SqlDbType.NVarChar).Value = (UserName == null ? (object)DBNull.Value : (System.String)UserName);
                    command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (Email == null ? (object)DBNull.Value : (System.String)Email);
                    command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (Password == null ? (object)DBNull.Value : (System.String)Password);
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (StateRcd == null ? (object)DBNull.Value : (System.String)StateRcd);
                    command.Parameters.Add("@created_by_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [user] set
                 user_id = @user_id
                ,user_code = @user_code
                ,user_name = @user_name
                ,email = @email
                ,password = @password
                ,state_rcd = @state_rcd
                ,created_by_user_id = @created_by_user_id
                ,date_time = @date_time
            where user_id = @user_id";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (UserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)UserId);
                command.Parameters.Add("@user_code",SqlDbType.NVarChar).Value = (UserCode == null ? (object)DBNull.Value : (System.String)UserCode);
                command.Parameters.Add("@user_name",SqlDbType.NVarChar).Value = (UserName == null ? (object)DBNull.Value : (System.String)UserName);
                command.Parameters.Add("@email",SqlDbType.NVarChar).Value = (Email == null ? (object)DBNull.Value : (System.String)Email);
                command.Parameters.Add("@password",SqlDbType.NVarChar).Value = (Password == null ? (object)DBNull.Value : (System.String)Password);
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (StateRcd == null ? (object)DBNull.Value : (System.String)StateRcd);
                command.Parameters.Add("@created_by_user_id",SqlDbType.UniqueIdentifier).Value = (CreatedByUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)CreatedByUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [user] 
                where user_id = @user_id";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
