/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 12:49:03 PM
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
        
        public void FetchByDefaultIssueId(System.Guid defaultIssueId) {
            string sql = @" select top 1 default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_issue_id = @default_issue_id
                            order by issue_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = defaultIssueId;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeDefaultIssueData GetByDefaultIssueId(System.Guid defaultIssueId) {
            string sql = @" select top 1 default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_issue_id = @default_issue_id
                            order by issue_name";

            var ret = new CrudeDefaultIssueData();
            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = defaultIssueId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeDefaultIssueData> FetchByDefaultErrorId(System.Guid defaultErrorId) {
            var dataList = new List<CrudeDefaultIssueData>();

            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_error_id = @default_error_id
                              
                            order by issue_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_error_id", SqlDbType.UniqueIdentifier).Value = defaultErrorId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultIssueData> FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataList = new List<CrudeDefaultIssueData>();

            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_user_id = @default_user_id
                              
                            order by issue_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultIssueData> FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            var dataList = new List<CrudeDefaultIssueData>();

            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_issue_type_rcd = @default_issue_type_rcd
                              
                            order by issue_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_type_rcd", SqlDbType.NVarChar).Value = defaultIssueTypeRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultIssueData> FetchByDefaultIssueStatusRcd(string defaultIssueStatusRcd) {
            var dataList = new List<CrudeDefaultIssueData>();

            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where default_issue_status_rcd = @default_issue_status_rcd
                              
                            order by issue_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_status_rcd", SqlDbType.NVarChar).Value = defaultIssueStatusRcd.Replace("'","''");

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByIssueName(string issueName) {
            string sql = @" select top 1 default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where issue_name like '%' + @issueName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@issueName",SqlDbType.NVarChar).Value = issueName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeDefaultIssueData> FetchAll() {
            var dataList = new List<CrudeDefaultIssueData>();

            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            order by issue_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultIssueData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeDefaultIssueData>();

            string sql = @" select top " + limit.ToString() + @" default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            order by issue_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeDefaultIssueData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeDefaultIssueData>();

            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            order by issue_name";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

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
        
        public static int FetchAllCount() {
            string sql = @" select count(*) as count from [default_issue]";

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
        
        public static List<CrudeDefaultIssueData> FetchWithFilter(System.Guid defaultIssueId, string defaultIssueTypeRcd, string defaultIssueStatusRcd, System.Guid defaultErrorId, string issueName, string issueDescription, string stepsToReproduce, string link, System.Guid defaultUserId, System.DateTime dateTime, string fixedNote) {
            var dataList = new List<CrudeDefaultIssueData>();

            string sql = @" select default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note
                            from [default_issue]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
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

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeDefaultIssueData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
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
        
        public void Insert() {

            if (DefaultIssueId == Guid.Empty)
                DefaultIssueId = Guid.NewGuid();

            string sql = "insert into [default_issue] (default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note)";
            sql += "            values (@default_issue_id, @default_issue_type_rcd, @default_issue_status_rcd, @default_error_id, @issue_name, @issue_description, @steps_to_reproduce, @link, @default_user_id, @date_time, @fixed_note)";

            // open standard connection
            using (var connection = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
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
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            if (DefaultIssueId == Guid.Empty)
                DefaultIssueId = Guid.NewGuid();

            string sql = "insert into [default_issue] (default_issue_id, default_issue_type_rcd, default_issue_status_rcd, default_error_id, issue_name, issue_description, steps_to_reproduce, link, default_user_id, date_time, fixed_note)";
            sql += "            values (@default_issue_id, @default_issue_type_rcd, @default_issue_status_rcd, @default_error_id, @issue_name, @issue_description, @steps_to_reproduce, @link, @default_user_id, @date_time, @fixed_note)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
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
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
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
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

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
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
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
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
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
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(System.Guid defaultIssueId) {
            string sql = @" delete [default_issue] 
                where default_issue_id = @default_issue_id";

            // open standard connection
            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@default_issue_id",SqlDbType.UniqueIdentifier).Value = defaultIssueId;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
