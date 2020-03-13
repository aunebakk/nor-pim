/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:40:47 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CrudeProductGatherData {
        
        public System.Guid ProductGatherId { get; set; } //;
        
        public System.DateTime StartDateTime { get; set; } //;
        
        public System.DateTime FinishDateTime { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductGatherId(System.Guid productGatherId) {
            string sql = @" select top 1 product_gather_id, start_date_time, finish_date_time, user_id, date_time
                            from [product_gather]
                            where product_gather_id = @product_gather_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = productGatherId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductGatherData GetByProductGatherId(System.Guid productGatherId) {
            string sql = @" select top 1 product_gather_id, start_date_time, finish_date_time, user_id, date_time
                            from [product_gather]
                            where product_gather_id = @product_gather_id";

            var ret = new CrudeProductGatherData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = productGatherId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductGatherData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductGatherData>();

            string sql = @" select product_gather_id, start_date_time, finish_date_time, user_id, date_time
                            from [product_gather]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductGatherData> FetchAll() {
            var dataList = new List<CrudeProductGatherData>();

            string sql = @" select product_gather_id, start_date_time, finish_date_time, user_id, date_time
                            from [product_gather]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductGatherData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductGatherData>();

            string sql = @" select top " + limit.ToString() + @" product_gather_id, start_date_time, finish_date_time, user_id, date_time
                            from [product_gather]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductGatherData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductGatherData>();

            string sql = @" select product_gather_id, start_date_time, finish_date_time, user_id, date_time
                            from [product_gather]";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductGatherData();
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
            string sql = @" select count(*) as count from [product_gather]";

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
        
        public static List<CrudeProductGatherData> FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductGatherData>();

            string sql = @" select product_gather_id, start_date_time, finish_date_time, user_id, date_time
                            from [product_gather]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productGatherId != Guid.Empty) {
                        sql += "  and product_gather_id = @product_gather_id";
                        command.Parameters.Add("@product_gather_id", SqlDbType.UniqueIdentifier).Value = productGatherId;
                    }
                    if (startDateTime != DateTime.MinValue) {
                        sql += "  and start_date_time = @start_date_time";
                        command.Parameters.Add("@start_date_time", SqlDbType.DateTime).Value = startDateTime;
                    }
                    if (finishDateTime != DateTime.MinValue) {
                        sql += "  and finish_date_time = @finish_date_time";
                        command.Parameters.Add("@finish_date_time", SqlDbType.DateTime).Value = finishDateTime;
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductGatherData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_gather_id"] != System.DBNull.Value) ProductGatherId = (System.Guid) reader["product_gather_id"];
            if (reader["start_date_time"] != System.DBNull.Value) StartDateTime = (System.DateTime) reader["start_date_time"];
            if (reader["finish_date_time"] != System.DBNull.Value) FinishDateTime = (System.DateTime) reader["finish_date_time"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductGatherId == Guid.Empty)
                ProductGatherId = Guid.NewGuid();

            string sql = "insert into [product_gather] (product_gather_id, start_date_time, finish_date_time, user_id, date_time)";
            sql += "            values (@product_gather_id, @start_date_time, @finish_date_time, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherId;
                    command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                    command.Parameters.Add("@finish_date_time",SqlDbType.DateTime).Value = (FinishDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)FinishDateTime);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductGatherId == Guid.Empty)
                ProductGatherId = Guid.NewGuid();

            string sql = "insert into [product_gather] (product_gather_id, start_date_time, finish_date_time, user_id, date_time)";
            sql += "            values (@product_gather_id, @start_date_time, @finish_date_time, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherId;
                command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                command.Parameters.Add("@finish_date_time",SqlDbType.DateTime).Value = (FinishDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)FinishDateTime);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_gather] set
                 product_gather_id = @product_gather_id
                ,start_date_time = @start_date_time
                ,finish_date_time = @finish_date_time
                ,user_id = @user_id
                ,date_time = @date_time
            where product_gather_id = @product_gather_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherId;
                    command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                    command.Parameters.Add("@finish_date_time",SqlDbType.DateTime).Value = (FinishDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)FinishDateTime);
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_gather] set
                 product_gather_id = @product_gather_id
                ,start_date_time = @start_date_time
                ,finish_date_time = @finish_date_time
                ,user_id = @user_id
                ,date_time = @date_time
            where product_gather_id = @product_gather_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductGatherId;
                command.Parameters.Add("@start_date_time",SqlDbType.DateTime).Value = (System.DateTime)StartDateTime;
                command.Parameters.Add("@finish_date_time",SqlDbType.DateTime).Value = (FinishDateTime == DateTime.MinValue ? (object)DBNull.Value : (System.DateTime)FinishDateTime);
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productGatherId) {
            string sql = @" delete [product_gather] 
                where product_gather_id = @product_gather_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_gather_id",SqlDbType.UniqueIdentifier).Value = productGatherId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
