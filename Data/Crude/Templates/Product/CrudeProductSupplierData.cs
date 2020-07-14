/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 1:11:19 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from sql server after being streamed over a net or internal process
// links:
//   https://en.wikipedia.org/wiki/Data_access_layer: data access layer
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of [the table]'s columns formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeProductSupplierData {
        
        public System.Guid ProductSupplierId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string SupplierName { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productSupplierId: primary key of table product_supplier
        public void FetchByProductSupplierId(System.Guid productSupplierId) {
            // create query
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection and to make sure the query plan is pre-compiled
            string sql = @" select top 1 product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where product_supplier_id = @product_supplier_id
                            order by supplier_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked as locked by another database transaction
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = productSupplierId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        public static CrudeProductSupplierData GetByProductSupplierId(System.Guid productSupplierId) {
            string sql = @" select top 1 product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where product_supplier_id = @product_supplier_id
                            order by supplier_name";

            var ret = new CrudeProductSupplierData();

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = productSupplierId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductSupplierData> FetchByProductId(System.Guid productId) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where product_id = @product_id
                              
                            order by supplier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeProductSupplierData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where user_id = @user_id
                              
                            order by supplier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchBySupplierName(string supplierName) {
            string sql = @" select top 1 product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where supplier_name like '%' + @supplierName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@supplierName",SqlDbType.NVarChar).Value = supplierName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all from table into new List of class instances
        public static List<CrudeProductSupplierData> FetchAll() {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            order by supplier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeProductSupplierData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select top " + limit.ToString() + @" product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            order by supplier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns , with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeProductSupplierData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            order by supplier_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeProductSupplierData();
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
            string sql = @" select count(*) as count from [product_supplier]";

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
        public static List<CrudeProductSupplierData> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeProductSupplierData>();

            string sql = @" select product_supplier_id, product_id, supplier_name, user_id, date_time
                            from [product_supplier]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (productSupplierId != Guid.Empty) {
                        sql += "  and product_supplier_id = @product_supplier_id";
                        command.Parameters.Add("@product_supplier_id", SqlDbType.UniqueIdentifier).Value = productSupplierId;
                    }
                    if (productId != Guid.Empty) {
                        sql += "  and product_id = @product_id";
                        command.Parameters.Add("@product_id", SqlDbType.UniqueIdentifier).Value = productId;
                    }
                    if (!string.IsNullOrEmpty(supplierName)) {
                        sql += "  and supplier_name like '%' + @supplier_name + '%'";
                        command.Parameters.Add("@supplier_name", SqlDbType.NVarChar).Value = supplierName.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by supplier_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeProductSupplierData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["product_supplier_id"] != System.DBNull.Value) ProductSupplierId = (System.Guid) reader["product_supplier_id"];
            if (reader["product_id"] != System.DBNull.Value) ProductId = (System.Guid) reader["product_id"];
            if (reader["supplier_name"] != System.DBNull.Value) SupplierName = (System.String) reader["supplier_name"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (ProductSupplierId == Guid.Empty)
                ProductSupplierId = Guid.NewGuid();

            string sql = "insert into [product_supplier] (product_supplier_id, product_id, supplier_name, user_id, date_time)";
            sql += "            values (@product_supplier_id, @product_id, @supplier_name, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductSupplierId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@supplier_name",SqlDbType.NVarChar).Value = (System.String)SupplierName;
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

            if (ProductSupplierId == Guid.Empty)
                ProductSupplierId = Guid.NewGuid();

            string sql = "insert into [product_supplier] (product_supplier_id, product_id, supplier_name, user_id, date_time)";
            sql += "            values (@product_supplier_id, @product_id, @supplier_name, @user_id, @date_time)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductSupplierId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@supplier_name",SqlDbType.NVarChar).Value = (System.String)SupplierName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            string sql = @" update [product_supplier] set
                 product_supplier_id = @product_supplier_id
                ,product_id = @product_id
                ,supplier_name = @supplier_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_supplier_id = @product_supplier_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductSupplierId;
                    command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                    command.Parameters.Add("@supplier_name",SqlDbType.NVarChar).Value = (System.String)SupplierName;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [product_supplier] set
                 product_supplier_id = @product_supplier_id
                ,product_id = @product_id
                ,supplier_name = @supplier_name
                ,user_id = @user_id
                ,date_time = @date_time
            where product_supplier_id = @product_supplier_id";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductSupplierId;
                command.Parameters.Add("@product_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)ProductId;
                command.Parameters.Add("@supplier_name",SqlDbType.NVarChar).Value = (System.String)SupplierName;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid productSupplierId) {
            string sql = @" delete [product_supplier] 
                where product_supplier_id = @product_supplier_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@product_supplier_id",SqlDbType.UniqueIdentifier).Value = productSupplierId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
