﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:28 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeDataAccessLayer
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class FinancialOrderIdentifierTypeRef {
        
        public const string InternalOrderNumber = "ION";
        
        public const string ExternalOrderNumber = "EON";
    }
    
    //[Serializable()]
    public partial class CrudeFinancialOrderIdentifierTypeRefData {
        
        public string FinancialOrderIdentifierTypeRcd { get; set; } //;
        
        public string FinancialOrderIdentifierTypeCode { get; set; } //;
        
        public string FinancialOrderIdentifierTypeName { get; set; } //;
        
        public int SortSequenceNumber { get; set; } //;
        
        public bool ChangeFlag { get; set; } //;
        
        public string StatusCode { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void FetchByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            string sql = @" select top 1 financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time
                            from [financial_order_identifier_type_ref]
                            where financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd
                            order by financial_order_identifier_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();
                // dirty read
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (var command = new SqlCommand(sql, conn)) {
                    // add all parameters
                    command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = financialOrderIdentifierTypeRcd;

                    // execute and read one row, close connection
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    // populate serializable class if row was found
                    if (reader.Read())
                        Populate(reader);
                }
            }
        }
        
        public static CrudeFinancialOrderIdentifierTypeRefData GetByFinancialOrderIdentifierTypeRcd(string financialOrderIdentifierTypeRcd) {
            string sql = @" select top 1 financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time
                            from [financial_order_identifier_type_ref]
                            where financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd
                            order by financial_order_identifier_type_name";

            var ret = new CrudeFinancialOrderIdentifierTypeRefData();
            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = financialOrderIdentifierTypeRcd;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                    if (reader.Read())
                        ret.Populate(reader);
                }
            }
            return ret;
        }
        
        public static List<CrudeFinancialOrderIdentifierTypeRefData> FetchByUserId(System.Guid userId) {
            var dataList = new List<CrudeFinancialOrderIdentifierTypeRefData>();

            string sql = @" select financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time
                            from [financial_order_identifier_type_ref]
                            where user_id = @user_id
                              
                            order by financial_order_identifier_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void FetchByFinancialOrderIdentifierTypeName(string financialOrderIdentifierTypeName) {
            string sql = @" select top 1 financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time
                            from [financial_order_identifier_type_ref]
                            where financial_order_identifier_type_name like '%' + @financialOrderIdentifierTypeName + '%'
                              ";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add("@financialOrderIdentifierTypeName",SqlDbType.NVarChar).Value = financialOrderIdentifierTypeName;

                IDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                    Populate(reader);
            }
        }
        
        public static List<CrudeFinancialOrderIdentifierTypeRefData> FetchAll() {
            var dataList = new List<CrudeFinancialOrderIdentifierTypeRefData>();

            string sql = @" select financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time
                            from [financial_order_identifier_type_ref]
                            order by financial_order_identifier_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderIdentifierTypeRefData> FetchAllWithLimit(int limit) {
            var dataList = new List<CrudeFinancialOrderIdentifierTypeRefData>();

            string sql = @" select top " + limit.ToString() + @" financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time
                            from [financial_order_identifier_type_ref]
                            order by financial_order_identifier_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public static List<CrudeFinancialOrderIdentifierTypeRefData> FetchAllWithLimitAndOffset(int limit, int offset) {
            var dataList = new List<CrudeFinancialOrderIdentifierTypeRefData>();

            string sql = @" select financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time
                            from [financial_order_identifier_type_ref]
                            order by financial_order_identifier_type_name";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    int count = 0;

                    while (reader.Read()) {
                        if ((count >= offset) && (count <= offset + limit)) {
                            var data = new CrudeFinancialOrderIdentifierTypeRefData();
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
            string sql = @" select count(*) as count from [financial_order_identifier_type_ref]";

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
        
        public static List<CrudeFinancialOrderIdentifierTypeRefData> FetchWithFilter(string financialOrderIdentifierTypeRcd, string financialOrderIdentifierTypeCode, string financialOrderIdentifierTypeName, int sortSequenceNumber, bool changeFlag, string statusCode, System.Guid userId, System.DateTime dateTime) {
            var dataList = new List<CrudeFinancialOrderIdentifierTypeRefData>();

            string sql = @" select financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time
                            from [financial_order_identifier_type_ref]
                            where 1 = 1";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    if (!string.IsNullOrEmpty(financialOrderIdentifierTypeRcd)) {
                        sql += "  and financial_order_identifier_type_rcd like '%' + @financial_order_identifier_type_rcd + '%'";
                        command.Parameters.Add("@financial_order_identifier_type_rcd", SqlDbType.NVarChar).Value = financialOrderIdentifierTypeRcd.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialOrderIdentifierTypeCode)) {
                        sql += "  and financial_order_identifier_type_code like '%' + @financial_order_identifier_type_code + '%'";
                        command.Parameters.Add("@financial_order_identifier_type_code", SqlDbType.NVarChar).Value = financialOrderIdentifierTypeCode.Replace("'","''");
                    }
                    if (!string.IsNullOrEmpty(financialOrderIdentifierTypeName)) {
                        sql += "  and financial_order_identifier_type_name like '%' + @financial_order_identifier_type_name + '%'";
                        command.Parameters.Add("@financial_order_identifier_type_name", SqlDbType.NVarChar).Value = financialOrderIdentifierTypeName.Replace("'","''");
                    }
                    if (sortSequenceNumber != 0) {
                        sql += "  and sort_sequence_number = @sort_sequence_number";
                        command.Parameters.Add("@sort_sequence_number", SqlDbType.Int).Value = sortSequenceNumber;
                    }
                    if (changeFlag != false) {
                        sql += "  and change_flag = @change_flag";
                        command.Parameters.Add("@change_flag", SqlDbType.Bit).Value = changeFlag;
                    }
                    if (!string.IsNullOrEmpty(statusCode)) {
                        sql += "  and status_code like '%' + @status_code + '%'";
                        command.Parameters.Add("@status_code", SqlDbType.NVarChar).Value = statusCode.Replace("'","''");
                    }
                    if (userId != Guid.Empty) {
                        sql += "  and user_id = @user_id";
                        command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    }
                    if (dateTime != DateTime.MinValue) {
                        sql += "  and date_time = @date_time";
                        command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = dateTime;
                    }
                    sql += " order by financial_order_identifier_type_name";

                    command.CommandText = sql;

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    while (reader.Read()) {
                        var data = new CrudeFinancialOrderIdentifierTypeRefData();
                        data.Populate(reader);
                        dataList.Add(data);
                    }
                }
                
                return dataList;
            }
        }
        
        public void Populate(IDataReader reader) {
            if (reader["financial_order_identifier_type_rcd"] != System.DBNull.Value) FinancialOrderIdentifierTypeRcd = (System.String) reader["financial_order_identifier_type_rcd"];
            if (reader["financial_order_identifier_type_code"] != System.DBNull.Value) FinancialOrderIdentifierTypeCode = (System.String) reader["financial_order_identifier_type_code"];
            if (reader["financial_order_identifier_type_name"] != System.DBNull.Value) FinancialOrderIdentifierTypeName = (System.String) reader["financial_order_identifier_type_name"];
            if (reader["sort_sequence_number"] != System.DBNull.Value) SortSequenceNumber = (System.Int32) reader["sort_sequence_number"];
            if (reader["change_flag"] != System.DBNull.Value) ChangeFlag = (System.Boolean) reader["change_flag"];
            if (reader["status_code"] != System.DBNull.Value) StatusCode = (System.String) reader["status_code"];
            if (reader["user_id"] != System.DBNull.Value) UserId = (System.Guid) reader["user_id"];
            if (reader["date_time"] != System.DBNull.Value) DateTime = (System.DateTime) reader["date_time"];
        }
        
        public void Insert() {

            string sql = "insert into [financial_order_identifier_type_ref] (financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time)";
            sql += "            values (@financial_order_identifier_type_rcd, @financial_order_identifier_type_code, @financial_order_identifier_type_name, @sort_sequence_number, @change_flag, @status_code, @user_id, @date_time)";

            // open standard connection
            using (var connection = new SqlConnection(Conn.ConnectionString)) {
                connection.Open();

                using (var command = new SqlCommand(sql, connection)) {
                    command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeRcd;
                    command.Parameters.Add("@financial_order_identifier_type_code",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeCode;
                    command.Parameters.Add("@financial_order_identifier_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeName;
                    command.Parameters.Add("@sort_sequence_number",SqlDbType.Int).Value = (System.Int32)SortSequenceNumber;
                    command.Parameters.Add("@change_flag",SqlDbType.Bit).Value = (System.Boolean)ChangeFlag;
                    command.Parameters.Add("@status_code",SqlDbType.NVarChar).Value = (System.String)StatusCode;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Insert(SqlConnection connection, SqlTransaction transaction) {

            string sql = "insert into [financial_order_identifier_type_ref] (financial_order_identifier_type_rcd, financial_order_identifier_type_code, financial_order_identifier_type_name, sort_sequence_number, change_flag, status_code, user_id, date_time)";
            sql += "            values (@financial_order_identifier_type_rcd, @financial_order_identifier_type_code, @financial_order_identifier_type_name, @sort_sequence_number, @change_flag, @status_code, @user_id, @date_time)";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeRcd;
                command.Parameters.Add("@financial_order_identifier_type_code",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeCode;
                command.Parameters.Add("@financial_order_identifier_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeName;
                command.Parameters.Add("@sort_sequence_number",SqlDbType.Int).Value = (System.Int32)SortSequenceNumber;
                command.Parameters.Add("@change_flag",SqlDbType.Bit).Value = (System.Boolean)ChangeFlag;
                command.Parameters.Add("@status_code",SqlDbType.NVarChar).Value = (System.String)StatusCode;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public void Update() {
            string sql = @" update [financial_order_identifier_type_ref] set
                 financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd
                ,financial_order_identifier_type_code = @financial_order_identifier_type_code
                ,financial_order_identifier_type_name = @financial_order_identifier_type_name
                ,sort_sequence_number = @sort_sequence_number
                ,change_flag = @change_flag
                ,status_code = @status_code
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeRcd;
                    command.Parameters.Add("@financial_order_identifier_type_code",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeCode;
                    command.Parameters.Add("@financial_order_identifier_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeName;
                    command.Parameters.Add("@sort_sequence_number",SqlDbType.Int).Value = (System.Int32)SortSequenceNumber;
                    command.Parameters.Add("@change_flag",SqlDbType.Bit).Value = (System.Boolean)ChangeFlag;
                    command.Parameters.Add("@status_code",SqlDbType.NVarChar).Value = (System.String)StatusCode;
                    command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                    command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void Update(SqlConnection connection, SqlTransaction transaction) {
            string sql = @" update [financial_order_identifier_type_ref] set
                 financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd
                ,financial_order_identifier_type_code = @financial_order_identifier_type_code
                ,financial_order_identifier_type_name = @financial_order_identifier_type_name
                ,sort_sequence_number = @sort_sequence_number
                ,change_flag = @change_flag
                ,status_code = @status_code
                ,user_id = @user_id
                ,date_time = @date_time
            where financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd";

            // open standard connection
            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeRcd;
                command.Parameters.Add("@financial_order_identifier_type_code",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeCode;
                command.Parameters.Add("@financial_order_identifier_type_name",SqlDbType.NVarChar).Value = (System.String)FinancialOrderIdentifierTypeName;
                command.Parameters.Add("@sort_sequence_number",SqlDbType.Int).Value = (System.Int32)SortSequenceNumber;
                command.Parameters.Add("@change_flag",SqlDbType.Bit).Value = (System.Boolean)ChangeFlag;
                command.Parameters.Add("@status_code",SqlDbType.NVarChar).Value = (System.String)StatusCode;
                command.Parameters.Add("@user_id",SqlDbType.UniqueIdentifier).Value = (System.Guid)UserId;
                command.Parameters.Add("@date_time",SqlDbType.DateTime).Value = (System.DateTime)DateTime;
                command.ExecuteNonQuery();
            }
        }
        
        public static void Delete(string financialOrderIdentifierTypeRcd) {
            string sql = @" delete [financial_order_identifier_type_ref] 
                where financial_order_identifier_type_rcd = @financial_order_identifier_type_rcd";

            // open standard connection
            using (var conn = new SqlConnection(Conn.ConnectionString)) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@financial_order_identifier_type_rcd",SqlDbType.NVarChar).Value = financialOrderIdentifierTypeRcd;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}