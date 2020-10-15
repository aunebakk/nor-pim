/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 12:15:03 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//   https://en.wikipedia.org/wiki/Data_access_layer: data access layer
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of default_issue's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/: serialization
    [Serializable()]
    public partial class CrudeDefaultIssueData {
        
        public System.Guid DefaultIssueId { get; set; }
        
        public string DefaultIssueTypeRcd { get; set; }
        
        public string DefaultIssueStatusRcd { get; set; }
        
        public System.Guid DefaultErrorId { get; set; }
        
        public string IssueName { get; set; }
        
        public string IssueDescription { get; set; }
        
        public string StepsToReproduce { get; set; }
        
        public string Link { get; set; }
        
        public System.Guid DefaultUserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string FixedNote { get; set; }
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultIssueId: primary key of table default_issue
        public void FetchByDefaultIssueId(System.Guid defaultIssueId) {
            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_issue_id = @default_issue_id
                            order by issue_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                // dirty read
                // starting a transaction seems to be the only way of doing a dirty read
                // a dirty read means a row is read even if it is marked
                //   as locked by another database transaction
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = defaultIssueId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        // fetch by Primary key into new class instance
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultIssueId: primary key of table default_issue
        public static CrudeDefaultIssueData GetByDefaultIssueId(System.Guid defaultIssueId) {
            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_issue_id = @default_issue_id
                            order by issue_name";

            var ret = new CrudeDefaultIssueData();

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = defaultIssueId;

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serialized class if a row was found
                    if (reader.Read())
                        ret.Populate(reader);
                }
            }

            return ret;
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultIssueData> FetchByDefaultErrorId(System.Guid defaultErrorId) {
            var dataList = new List<CrudeDefaultIssueData>();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_error_id = @default_error_id
                              
                            order by issue_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_error_id", SqlDbType.UniqueIdentifier).Value = defaultErrorId;

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultIssueData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultIssueData>();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_user_id = @default_user_id
                              
                            order by issue_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultIssueData> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            var dataList = new List<CrudeDefaultIssueData>();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_issue_type_rcd = @default_issue_type_rcd
                              
                            order by issue_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_type_rcd", SqlDbType.NVarChar).Value = defaultIssueTypeRcd.Replace("'","''");

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Foreign key into new List of class instances
        public static List<CrudeDefaultIssueData> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            var dataList = new List<CrudeDefaultIssueData>();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_issue_status_rcd = @default_issue_status_rcd
                              
                            order by issue_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add foreign key column
                    // this foreign key column will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_status_rcd", SqlDbType.NVarChar).Value = defaultIssueStatusRcd.Replace("'","''");

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch by Picker Member into new class instance
        public void FetchByIssueName(string issueName) {
            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top 1 default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where issue_name like '%' + @issueName + '%'
                              ";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                    // add search column
                    // this search column will be used together with the prepared ansi sql statement
                command.Parameters.Add("@issueName",SqlDbType.NVarChar).Value = issueName;

                // execute query against default_issue
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        // fetch all rows from table default_issue into new List of class instances
        public static List<CrudeDefaultIssueData> FetchAll() {
            var dataList = new List<CrudeDefaultIssueData>();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            order by issue_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public static List<CrudeDefaultIssueData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultIssueData>();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select top " + limit.ToString() + @" default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            order by issue_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public static List<CrudeDefaultIssueData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultIssueData>();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            order by issue_name";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    // read all rows returned from the query of default_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeDefaultIssueData();
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
            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select count(*) as count from [default_issue]";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                int count = 0;

                using (var command = new SqlCommand(sql, conn)) {
                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    reader.Read();
                    count = (System.Int32) reader["count"];
                }

                return count;
            }
        }
        
        // fetch all from table into new List of class instances, filtered by any column
        public static List<CrudeDefaultIssueData> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote) {
            var dataList = new List<CrudeDefaultIssueData>();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where 1 = 1";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add search column(s) if they are not null or empty
                    // this search column(s) will be used together with the prepared ansi sql statement
                    if (defaultIssueId != Guid.Empty) {
                        sql += "  and default_issue_id = @default_issue_id";
                        command.Parameters.Add("@default_issue_id", SqlDbType.UniqueIdentifier).Value = defaultIssueId;
                    }
                    if (!string.IsNullOrEmpty(defaultIssueTypeRcd)) {
                        sql += "  and default_issue_type_rcd like '%' + @default_issue_type_rcd + '%'";
                        command.Parameters.Add("@default_issue_type_rcd", SqlDbType.NVarChar).Value = defaultIssueTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(defaultIssueStatusRcd)) {
                        sql += "  and default_issue_status_rcd like '%' + @default_issue_status_rcd + '%'";
                        command.Parameters.Add("@default_issue_status_rcd", SqlDbType.NVarChar).Value = defaultIssueStatusRcd.Replace("'","''");
                    }
                    if (defaultErrorId != Guid.Empty) {
                        sql += "  and default_error_id = @default_error_id";
                        command.Parameters.Add("@default_error_id", SqlDbType.UniqueIdentifier).Value = defaultErrorId;
                    }
                    if (!string.IsNullOrEmpty(issueName)) {
                        sql += "  and issue_name like '%' + @issue_name + '%'";
                        command.Parameters.Add("@issue_name", SqlDbType.NVarChar).Value = issueName.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(issueDescription)) {
                        sql += "  and issue_description like '%' + @issue_description + '%'";
                        command.Parameters.Add("@issue_description", SqlDbType.NVarChar).Value = issueDescription.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(stepsToReproduce)) {
                        sql += "  and steps_to_reproduce like '%' + @steps_to_reproduce + '%'";
                        command.Parameters.Add("@steps_to_reproduce", SqlDbType.NVarChar).Value = stepsToReproduce.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(link)) {
                        sql += "  and link like '%' + @link + '%'";
                        command.Parameters.Add("@link", SqlDbType.NVarChar).Value = link.Replace("'","''");
                    }
                    if (defaultUserId != Guid.Empty) {
                        sql += "  and default_user_id = @default_user_id";
                        command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    if (!string.IsNullOrEmpty(fixedNote)) {
                        sql += "  and fixed_note like '%' + @fixed_note + '%'";
                        command.Parameters.Add("@fixed_note", SqlDbType.NVarChar).Value = fixedNote.Replace("'","''");
                    }
                    sql += " order by issue_name";

                    command.CommandText = sql;

                    // execute query against default_issue
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    // read all rows returned from the query of default_issue
                    // read all columns from the datareader and 
                    //   populate the List of C# objects with them
                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        // read all columns out and populate object members
        public void Populate(IDataReader reader) {
            if (reader["default_issue_id"] != System.DBNull.Value) DefaultIssueId = (System.Guid) reader["default_issue_id"];
            if (reader["default_issue_type_rcd"] != System.DBNull.Value) DefaultIssueTypeRcd = (System.String) reader["default_issue_type_rcd"];
            if (reader["default_issue_status_rcd"] != System.DBNull.Value) DefaultIssueStatusRcd = (System.String) reader["default_issue_status_rcd"];
            if (reader["default_error_id"] != System.DBNull.Value) DefaultErrorId = (System.Guid) reader["default_error_id"];
            if (reader["issue_name"] != System.DBNull.Value) IssueName = (System.String) reader["issue_name"];
            if (reader["issue_description"] != System.DBNull.Value) IssueDescription = (System.String) reader["issue_description"];
            if (reader["steps_to_reproduce"] != System.DBNull.Value) StepsToReproduce = (System.String) reader["steps_to_reproduce"];
            if (reader["link"] != System.DBNull.Value) Link = (System.String) reader["link"];
            if (reader["default_user_id"] != System.DBNull.Value) DefaultUserId = (System.Guid) reader["default_user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
            if (reader["fixed_note"] != System.DBNull.Value) FixedNote = (System.String) reader["fixed_note"];
        }
        
        // insert all object members as a new row in table
        public void Insert() {

            if (DefaultIssueId == Guid.Empty)
                DefaultIssueId = Guid.NewGuid();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_issue] (default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note)";
            sql += "            values (@default_issue_id, @default_issue_type_rcd, @default_issue_status_rcd, @default_error_id, @issue_name, @issue_description, @steps_to_reproduce, @link, @default_user_id, @date_time, @fixed_note)";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    // add column(s) to insert as parameter
                    // the insert column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultIssueId;
                    command.Parameters.Add("@default_issue_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueTypeRcd;
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                    command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = (DefaultErrorId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultErrorId);
                    command.Parameters.Add("@issue_name",SqlDbType.NVarChar).Value = (System.String)IssueName;
                    command.Parameters.Add("@issue_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(IssueDescription)) ? (object)DBNull.Value : (System.String)IssueDescription;
                    command.Parameters.Add("@steps_to_reproduce",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(StepsToReproduce)) ? (object)DBNull.Value : (System.String)StepsToReproduce;
                    command.Parameters.Add("@link",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Link)) ? (object)DBNull.Value : (System.String)Link;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@fixed_note",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(FixedNote)) ? (object)DBNull.Value : (System.String)FixedNote;
                    // execute query against default_issue
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultIssueId == Guid.Empty)
                DefaultIssueId = Guid.NewGuid();

            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = "insert into [default_issue] (default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note)";
            sql += "            values (@default_issue_id, @default_issue_type_rcd, @default_issue_status_rcd, @default_error_id, @issue_name, @issue_description, @steps_to_reproduce, @link, @default_user_id, @date_time, @fixed_note)";

            // use passed in connection
            // transaction scope etc is determined by caller
            // there are no result from this action, SqlClient will raise an exception in case
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to insert as parameter(s)
                // the insert column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultIssueId;
                command.Parameters.Add("@default_issue_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueTypeRcd;
                command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = (DefaultErrorId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultErrorId);
                command.Parameters.Add("@issue_name",SqlDbType.NVarChar).Value = (System.String)IssueName;
                command.Parameters.Add("@issue_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(IssueDescription)) ? (object)DBNull.Value : (System.String)IssueDescription;
                command.Parameters.Add("@steps_to_reproduce",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(StepsToReproduce)) ? (object)DBNull.Value : (System.String)StepsToReproduce;
                command.Parameters.Add("@link",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Link)) ? (object)DBNull.Value : (System.String)Link;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@fixed_note",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(FixedNote)) ? (object)DBNull.Value : (System.String)FixedNote;
                // execute query against default_issue
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // update all object members on a row in table based on primary key
        public void Update() {
            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_issue] set
                 default_issue_id = @default_issue_id
                ,default_issue_type_rcd = @default_issue_type_rcd
                ,default_issue_status_rcd = @default_issue_status_rcd
                ,default_error_id = @default_error_id
                ,issue_name = @issue_name
                ,issue_description = @issue_description
                ,steps_to_reproduce = @steps_to_reproduce
                ,link = @link
                ,default_user_id = @default_user_id
                ,date_time = @date_time
                ,fixed_note = @fixed_note
            where default_issue_id = @default_issue_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    // add column(s) to update as parameter(s)
                    // the update column(s) will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultIssueId;
                    command.Parameters.Add("@default_issue_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueTypeRcd;
                    command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                    command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = (DefaultErrorId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultErrorId);
                    command.Parameters.Add("@issue_name",SqlDbType.NVarChar).Value = (System.String)IssueName;
                    command.Parameters.Add("@issue_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(IssueDescription)) ? (object)DBNull.Value : (System.String)IssueDescription;
                    command.Parameters.Add("@steps_to_reproduce",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(StepsToReproduce)) ? (object)DBNull.Value : (System.String)StepsToReproduce;
                    command.Parameters.Add("@link",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Link)) ? (object)DBNull.Value : (System.String)Link;
                    command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.Parameters.Add("@fixed_note",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(FixedNote)) ? (object)DBNull.Value : (System.String)FixedNote;
                    // execute query against default_issue
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" update [default_issue] set
                 default_issue_id = @default_issue_id
                ,default_issue_type_rcd = @default_issue_type_rcd
                ,default_issue_status_rcd = @default_issue_status_rcd
                ,default_error_id = @default_error_id
                ,issue_name = @issue_name
                ,issue_description = @issue_description
                ,steps_to_reproduce = @steps_to_reproduce
                ,link = @link
                ,default_user_id = @default_user_id
                ,date_time = @date_time
                ,fixed_note = @fixed_note
            where default_issue_id = @default_issue_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                // add column(s) to update as parameter
                // the update column(s) will be used together with the prepared ansi sql statement
                command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)DefaultIssueId;
                command.Parameters.Add("@default_issue_type_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueTypeRcd;
                command.Parameters.Add("@default_issue_status_rcd",SqlDbType.NVarChar).Value = (System.String)DefaultIssueStatusRcd;
                command.Parameters.Add("@default_error_id",SqlDbType.UniqueIdentifier).Value = (DefaultErrorId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultErrorId);
                command.Parameters.Add("@issue_name",SqlDbType.NVarChar).Value = (System.String)IssueName;
                command.Parameters.Add("@issue_description",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(IssueDescription)) ? (object)DBNull.Value : (System.String)IssueDescription;
                command.Parameters.Add("@steps_to_reproduce",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(StepsToReproduce)) ? (object)DBNull.Value : (System.String)StepsToReproduce;
                command.Parameters.Add("@link",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(Link)) ? (object)DBNull.Value : (System.String)Link;
                command.Parameters.Add("@default_user_id",SqlDbType.UniqueIdentifier).Value = (DefaultUserId == Guid.Empty ? (object)DBNull.Value : (System.Guid)DefaultUserId);
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.Parameters.Add("@fixed_note",SqlDbType.NVarChar).Value = (String.IsNullOrEmpty(FixedNote)) ? (object)DBNull.Value : (System.String)FixedNote;
                // execute query against default_issue
                // there is nothing returned from this action
                // if the query fails in the preprocessor of sql server
                //   an exception will be raised
                command.ExecuteNonQuery();
            }
        }
        
        // delete a row in table based on primary key
        public static void Delete(System.Guid defaultIssueId) {
            // create query against default_issue
            // this will be ansi sql and parameterized
            // parameterized queries are a good way of preventing sql injection
            //   and to make sure the query plan is pre-compiled
            string sql = @" delete [default_issue] 
                where default_issue_id = @default_issue_id";

            // open standard connection
            // the connection is found in web.config
            // the connection is closed upon completion of the reader
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    // add primary key
                    // this primary key will be used together with the prepared ansi sql statement
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = defaultIssueId;
                    // execute query against default_issue
                    // there is nothing returned from this action
                    // if the query fails in the preprocessor of sql server
                    //   an exception will be raised
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
