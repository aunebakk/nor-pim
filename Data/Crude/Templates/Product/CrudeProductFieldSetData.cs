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

    [Serializable()]
    public partial class CrudeProductFieldSetData {
        
        public System.Guid ProductFieldSetId { get; set; }
        
        public string ProductFieldSetName { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // parameters:
        //   productFieldSetId: primary key of table product_field_set
        public void FetchByProductFieldSetId(System.Guid productFieldSetId) {
            // create query
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            where product_field_set_id = @product_field_set_id
                            order by product_field_set_name";

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
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = productFieldSetId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        public static CrudeProductFieldSetData GetByProductFieldSetId(System.Guid productFieldSetId) {
            string sql = @" select top 1 product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            where product_field_set_id = @product_field_set_id
                            order by product_field_set_name";

            var ret = new CrudeProductFieldSetData();

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = productFieldSetId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductFieldSetData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            where user_id = @user_id
                              
                            order by product_field_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByProductFieldSetName(string productFieldSetName) {
            string sql = @" select top 1 product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            where product_field_set_name like '%' + @productFieldSetName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@productFieldSetName",SqlDbType.NVarChar).Value = productFieldSetName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all from table into new List of class instances
        public static List<CrudeProductFieldSetData> FetchAll() {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            order by product_field_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeProductFieldSetData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select top " + limit.ToString() + @" product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            order by product_field_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns , with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeProductFieldSetData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            order by product_field_set_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductFieldSetData();
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
            string sql = @" select count(*) as count from [product_field_set]";

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
        public static List<CrudeProductFieldSetData> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductFieldSetData>();

            string sql = @" select product_field_set_id, product_field_set_name, user_id, date_time
                            from [product_field_set]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productFieldSetId != Guid.Empty) {
                        sql += "  and product_field_set_id = @product_field_set_id";
                        command.Parameters.Add("@product_field_set_id", SqlDbType.UniqueIdentifier).Value = productFieldSetId;
                    }
                    if (!string.IsNullOrEmpty(productFieldSetName)) {
                        sql += "  and product_field_set_name like '%' + @product_field_set_name + '%'";
                        command.Parameters.Add("@product_field_set_name", SqlDbType.NVarChar).Value = productFieldSetName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by product_field_set_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductFieldSetData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["product_field_set_id"] != System.DBNull.Value) ProductFieldSetId = (System.Guid) reader["product_field_set_id"];
            if (reader["product_field_set_name"] != System.DBNull.Value) ProductFieldSetName = (System.String) reader["product_field_set_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ProductFieldSetId == Guid.Empty)
                ProductFieldSetId = Guid.NewGuid();

            string sql = "insert into [product_field_set] (product_field_set_id, product_field_set_name, user_id, date_time)";
            sql += "            values (@product_field_set_id, @product_field_set_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                    command.Parameters.Add("@product_field_set_name",SqlDbType.NVarChar).Value = (System.String)ProductFieldSetName;
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

            if (ProductFieldSetId == Guid.Empty)
                ProductFieldSetId = Guid.NewGuid();

            string sql = "insert into [product_field_set] (product_field_set_id, product_field_set_name, user_id, date_time)";
            sql += "            values (@product_field_set_id, @product_field_set_name, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                command.Parameters.Add("@product_field_set_name",SqlDbType.NVarChar).Value = (System.String)ProductFieldSetName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            string sql = @" update [product_field_set] set
                 product_field_set_id = @product_field_set_id
                ,product_field_set_name = @product_field_set_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_field_set_id = @product_field_set_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                    command.Parameters.Add("@product_field_set_name",SqlDbType.NVarChar).Value = (System.String)ProductFieldSetName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_field_set] set
                 product_field_set_id = @product_field_set_id
                ,product_field_set_name = @product_field_set_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_field_set_id = @product_field_set_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductFieldSetId;
                command.Parameters.Add("@product_field_set_name",SqlDbType.NVarChar).Value = (System.String)ProductFieldSetName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid productFieldSetId) {
            string sql = @" delete [product_field_set] 
                where product_field_set_id = @product_field_set_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_field_set_id",SqlDbType.UniqueIdentifier).Value = productFieldSetId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
