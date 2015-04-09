using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    public partial class StateRef {
        
        public static string Created = "C";
        
        public static string Invalidated = "I";
        
        public static string Updated = "U";
    }
    
    [Serializable()]
    public partial class CrudeStateRefData {
        
        public string StateRcd { get; set; } //;
        
        public string StateName { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByStateRcd(string stateRcd) {
            string sql = @" select top 1 state_rcd, state_name, date_time
                            from [state_ref]
                            where state_rcd = @state_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = stateRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public List<CrudeStateRefData> FetchAll() {
            var dataList = new List<CrudeStateRefData>();

            string sql = @" select state_rcd, state_name, date_time
                            from [state_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeStateRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeStateRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeStateRefData>();

            string sql = @" select top " + limit.ToString() + @" state_rcd, state_name, date_time
                            from [state_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeStateRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public List<CrudeStateRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeStateRefData>();

            string sql = @" select state_rcd, state_name, date_time
                            from [state_ref]";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeStateRefData();
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
            string sql = @" select count(*) as count from [state_ref]";

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
        
        public List<CrudeStateRefData> FetchWithFilter(string stateRcd, string stateName, System.DateTime dateTime) {
            var dataList = new List<CrudeStateRefData>();

            string sql = @" select state_rcd, state_name, date_time
                            from [state_ref]
                            where 1 = 1";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (stateRcd != "") {
                        sql += "  and state_rcd like '%' + @state_rcd + '%'";
                        command.Parameters.Add("@state_rcd", SqlDbType.NVarChar).Value = stateRcd.Replace("'","''");
                    }
                    if (stateName != "") {
                        sql += "  and state_name like '%' + @state_name + '%'";
                        command.Parameters.Add("@state_name", SqlDbType.NVarChar).Value = stateName.Replace("'","''");
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeStateRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["state_rcd"] != System.DBNull.Value) StateRcd = (System.String) reader["state_rcd"];
            if (reader["state_name"] != System.DBNull.Value) StateName = (System.String) reader["state_name"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [state_ref] (state_rcd, state_name, date_time)";
            sql += "            values (@state_rcd, @state_name, @date_time)";

            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (StateRcd == null ? (object)DBNull.Value : (System.String)StateRcd);
                    command.Parameters.Add("@state_name",SqlDbType.NVarChar).Value = (StateName == null ? (object)DBNull.Value : (System.String)StateName);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [state_ref] (state_rcd, state_name, date_time)";
            sql += "            values (@state_rcd, @state_name, @date_time)";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (StateRcd == null ? (object)DBNull.Value : (System.String)StateRcd);
                command.Parameters.Add("@state_name",SqlDbType.NVarChar).Value = (StateName == null ? (object)DBNull.Value : (System.String)StateName);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [state_ref] set
                 state_rcd = @state_rcd
                ,state_name = @state_name
                ,date_time = @date_time
            where state_rcd = @state_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (StateRcd == null ? (object)DBNull.Value : (System.String)StateRcd);
                    command.Parameters.Add("@state_name",SqlDbType.NVarChar).Value = (StateName == null ? (object)DBNull.Value : (System.String)StateName);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [state_ref] set
                 state_rcd = @state_rcd
                ,state_name = @state_name
                ,date_time = @date_time
            where state_rcd = @state_rcd";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = (StateRcd == null ? (object)DBNull.Value : (System.String)StateRcd);
                command.Parameters.Add("@state_name",SqlDbType.NVarChar).Value = (StateName == null ? (object)DBNull.Value : (System.String)StateName);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (DateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)DateTime);
                command.ExecuteNonQuery();
            }
        }
        
        public void Delete(System.Guid id) {
            string sql = @" delete [state_ref] 
                where state_rcd = @state_rcd";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@state_rcd",SqlDbType.NVarChar).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
