/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:58 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    //[Serializable()]
    public partial class CrudeProductExposeData {
        
        public System.Guid ProductExposeId { get; set; } //;
        
        public System.Guid ExposeProductId { get; set; } //;
        
        public System.Guid ExposeBasedOnProductId { get; set; } //;
        
        public System.Guid ProductExposeSetId { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByProductExposeId(System.Guid productExposeId) {
            string sql = @" select top 1 product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]
                            where product_expose_id = @product_expose_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = productExposeId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeProductExposeData GetByProductExposeId(System.Guid productExposeId) {
            string sql = @" select top 1 product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]
                            where product_expose_id = @product_expose_id";

            var ret = new CrudeProductExposeData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = productExposeId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeProductExposeData> FetchByExposeProductId(System.Guid exposeProductId) {
            var dataList = new List<CrudeProductExposeData>();

            string sql = @" select product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]
                            where expose_product_id = @expose_product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@expose_product_id", SqlDbType.UniqueIdentifier).Value = exposeProductId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeData> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId) {
            var dataList = new List<CrudeProductExposeData>();

            string sql = @" select product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]
                            where expose_based_on_product_id = @expose_based_on_product_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@expose_based_on_product_id", SqlDbType.UniqueIdentifier).Value = exposeBasedOnProductId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeData> FetchByProductExposeSetId(System.Guid productExposeSetId) {
            var dataList = new List<CrudeProductExposeData>();

            string sql = @" select product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]
                            where product_expose_set_id = @product_expose_set_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_set_id", SqlDbType.UniqueIdentifier).Value = productExposeSetId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductExposeData>();

            string sql = @" select product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]
                            where user_id = @user_id
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeData> FetchAll() {
            var dataList = new List<CrudeProductExposeData>();

            string sql = @" select product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductExposeData>();

            string sql = @" select top " + limit.ToString() + @" product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductExposeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeProductExposeData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductExposeData>();

            string sql = @" select product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductExposeData();
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
            string sql = @" select count(*) as count from [product_expose]";

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
        
        public static List<CrudeProductExposeData> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductExposeData>();

            string sql = @" select product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time
                            from [product_expose]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productExposeId != Guid.Empty) {
                        sql += "  and product_expose_id = @product_expose_id";
                        command.Parameters.Add("@product_expose_id", SqlDbType.UniqueIdentifier).Value = productExposeId;
                    }
                    if (exposeProductId != Guid.Empty) {
                        sql += "  and expose_product_id = @expose_product_id";
                        command.Parameters.Add("@expose_product_id", SqlDbType.UniqueIdentifier).Value = exposeProductId;
                    }
                    if (exposeBasedOnProductId != Guid.Empty) {
                        sql += "  and expose_based_on_product_id = @expose_based_on_product_id";
                        command.Parameters.Add("@expose_based_on_product_id", SqlDbType.UniqueIdentifier).Value = exposeBasedOnProductId;
                    }
                    if (productExposeSetId != Guid.Empty) {
                        sql += "  and product_expose_set_id = @product_expose_set_id";
                        command.Parameters.Add("@product_expose_set_id", SqlDbType.UniqueIdentifier).Value = productExposeSetId;
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
                        var data = new CrudeProductExposeData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["product_expose_id"] != System.DBNull.Value) ProductExposeId = (System.Guid) reader["product_expose_id"];
            if (reader["expose_product_id"] != System.DBNull.Value) ExposeProductId = (System.Guid) reader["expose_product_id"];
            if (reader["expose_based_on_product_id"] != System.DBNull.Value) ExposeBasedOnProductId = (System.Guid) reader["expose_based_on_product_id"];
            if (reader["product_expose_set_id"] != System.DBNull.Value) ProductExposeSetId = (System.Guid) reader["product_expose_set_id"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            if (ProductExposeId == Guid.Empty)
                ProductExposeId = Guid.NewGuid();

            string sql = "insert into [product_expose] (product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time)";
            sql += "            values (@product_expose_id, @expose_product_id, @expose_based_on_product_id, @product_expose_set_id, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeId;
                    command.Parameters.Add("@expose_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ExposeProductId;
                    command.Parameters.Add("@expose_based_on_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ExposeBasedOnProductId;
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeSetId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (ProductExposeId == Guid.Empty)
                ProductExposeId = Guid.NewGuid();

            string sql = "insert into [product_expose] (product_expose_id, expose_product_id, expose_based_on_product_id, product_expose_set_id, user_id, date_time)";
            sql += "            values (@product_expose_id, @expose_product_id, @expose_based_on_product_id, @product_expose_set_id, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeId;
                command.Parameters.Add("@expose_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ExposeProductId;
                command.Parameters.Add("@expose_based_on_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ExposeBasedOnProductId;
                command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeSetId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [product_expose] set
                 product_expose_id = @product_expose_id
                ,expose_product_id = @expose_product_id
                ,expose_based_on_product_id = @expose_based_on_product_id
                ,product_expose_set_id = @product_expose_set_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_expose_id = @product_expose_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeId;
                    command.Parameters.Add("@expose_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ExposeProductId;
                    command.Parameters.Add("@expose_based_on_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ExposeBasedOnProductId;
                    command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeSetId;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_expose] set
                 product_expose_id = @product_expose_id
                ,expose_product_id = @expose_product_id
                ,expose_based_on_product_id = @expose_based_on_product_id
                ,product_expose_set_id = @product_expose_set_id
                ,user_id = @user_id
                ,date_time = @date_time
            where product_expose_id = @product_expose_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeId;
                command.Parameters.Add("@expose_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ExposeProductId;
                command.Parameters.Add("@expose_based_on_product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ExposeBasedOnProductId;
                command.Parameters.Add("@product_expose_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductExposeSetId;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid productExposeId) {
            string sql = @" delete [product_expose] 
                where product_expose_id = @product_expose_id";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_expose_id",SqlDbType.UniqueIdentifier).Value = productExposeId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
