/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:27 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeDefaultTestData {
        
        public System.Guid DefaultTestId { get; set; } //;
        
        public string SystemName { get; set; } //;
        
        public string TestArea { get; set; } //;
        
        public string TestSubArea { get; set; } //;
        
        public string TestAddress { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByDefaultTestId(System.Guid defaultTestId) {
            string sql = @" select top 1 default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where default_test_id = @default_test_id
                            order by system_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = defaultTestId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultTestData GetByDefaultTestId(System.Guid defaultTestId) {
            string sql = @" select top 1 default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where default_test_id = @default_test_id
                            order by system_name";

            var ret = new CrudeDefaultTestData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = defaultTestId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultTestData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeDefaultTestData>();

            string sql = @" select default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where user_id = @user_id
                              
                            order by system_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchBySystemName(string systemName) {
            string sql = @" select top 1 default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where system_name like '%' + @systemName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@systemName",SqlDbType.NVarChar).Value = systemName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultTestData> FetchAll() {
            var dataList = new List<CrudeDefaultTestData>();

            string sql = @" select default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            order by system_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultTestData>();

            string sql = @" select top " + limit.ToString() + @" default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            order by system_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultTestData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultTestData>();

            string sql = @" select default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            order by system_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultTestData();
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
            string sql = @" select count(*) as count from [default_test]";

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
        
        public static List<CrudeDefaultTestData> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeDefaultTestData>();

            string sql = @" select default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time
                            from [default_test]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (defaultTestId != Guid.Empty) {
                        sql += "  and default_test_id = @default_test_id";
                        command.Parameters.Add("@default_test_id", SqlDbType.UniqueIdentifier).Value = defaultTestId;
                    }
                    if (!string.IsNullOrEmpty(systemName)) {
                        sql += "  and system_name like '%' + @system_name + '%'";
                        command.Parameters.Add("@system_name", SqlDbType.NVarChar).Value = systemName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(testArea)) {
                        sql += "  and test_area like '%' + @test_area + '%'";
                        command.Parameters.Add("@test_area", SqlDbType.NVarChar).Value = testArea.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(testSubArea)) {
                        sql += "  and test_sub_area like '%' + @test_sub_area + '%'";
                        command.Parameters.Add("@test_sub_area", SqlDbType.NVarChar).Value = testSubArea.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(testAddress)) {
                        sql += "  and test_address like '%' + @test_address + '%'";
                        command.Parameters.Add("@test_address", SqlDbType.NVarChar).Value = testAddress.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by system_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultTestData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["default_test_id"] != System.DBNull.Value) DefaultTestId = (System.Guid) reader["default_test_id"];
            if (reader["system_name"] != System.DBNull.Value) SystemName = (System.String) reader["system_name"];
            if (reader["test_area"] != System.DBNull.Value) TestArea = (System.String) reader["test_area"];
            if (reader["test_sub_area"] != System.DBNull.Value) TestSubArea = (System.String) reader["test_sub_area"];
            if (reader["test_address"] != System.DBNull.Value) TestAddress = (System.String) reader["test_address"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (DefaultTestId == Guid.Empty)
                DefaultTestId = Guid.NewGuid();

            string sql = "insert into [default_test] (default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time)";
            sql += "            values (@default_test_id, @system_name, @test_area, @test_sub_area, @test_address, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                    command.Parameters.Add("@system_name",SqlDbType.NVarChar).Value = (System.String)SystemName;
                    command.Parameters.Add("@test_area",SqlDbType.NVarChar).Value = (System.String)TestArea;
                    command.Parameters.Add("@test_sub_area",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestSubArea)) ? (object)DBNull.Value : (System.String)TestSubArea;
                    command.Parameters.Add("@test_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestAddress)) ? (object)DBNull.Value : (System.String)TestAddress;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultTestId == Guid.Empty)
                DefaultTestId = Guid.NewGuid();

            string sql = "insert into [default_test] (default_test_id, system_name, test_area, test_sub_area, test_address, user_id, date_time)";
            sql += "            values (@default_test_id, @system_name, @test_area, @test_sub_area, @test_address, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                command.Parameters.Add("@system_name",SqlDbType.NVarChar).Value = (System.String)SystemName;
                command.Parameters.Add("@test_area",SqlDbType.NVarChar).Value = (System.String)TestArea;
                command.Parameters.Add("@test_sub_area",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestSubArea)) ? (object)DBNull.Value : (System.String)TestSubArea;
                command.Parameters.Add("@test_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestAddress)) ? (object)DBNull.Value : (System.String)TestAddress;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [default_test] set
                 default_test_id = @default_test_id
                ,system_name = @system_name
                ,test_area = @test_area
                ,test_sub_area = @test_sub_area
                ,test_address = @test_address
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_id = @default_test_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                    command.Parameters.Add("@system_name",SqlDbType.NVarChar).Value = (System.String)SystemName;
                    command.Parameters.Add("@test_area",SqlDbType.NVarChar).Value = (System.String)TestArea;
                    command.Parameters.Add("@test_sub_area",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestSubArea)) ? (object)DBNull.Value : (System.String)TestSubArea;
                    command.Parameters.Add("@test_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestAddress)) ? (object)DBNull.Value : (System.String)TestAddress;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [default_test] set
                 default_test_id = @default_test_id
                ,system_name = @system_name
                ,test_area = @test_area
                ,test_sub_area = @test_sub_area
                ,test_address = @test_address
                ,user_id = @user_id
                ,date_time = @date_time
            where default_test_id = @default_test_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultTestId;
                command.Parameters.Add("@system_name",SqlDbType.NVarChar).Value = (System.String)SystemName;
                command.Parameters.Add("@test_area",SqlDbType.NVarChar).Value = (System.String)TestArea;
                command.Parameters.Add("@test_sub_area",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestSubArea)) ? (object)DBNull.Value : (System.String)TestSubArea;
                command.Parameters.Add("@test_address",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(TestAddress)) ? (object)DBNull.Value : (System.String)TestAddress;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultTestId) {
            string sql = @" delete [default_test] 
                where default_test_id = @default_test_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_test_id",SqlDbType.UniqueIdentifier).Value = defaultTestId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
