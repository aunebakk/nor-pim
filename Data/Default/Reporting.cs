using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer {

    public partial class CrudeReportingRoundupData {

        public static void UpdateOrInsert(
            DateTime date,
            string reportingRoundupTypeRcd,
            string reportingReferenceCode,
            int count,
            Guid userId,
            SqlConnection connection,
            SqlTransaction transaction
            ) {

            string sql = string.Empty;
            sql += " update reporting_roundup set\r\n";
            sql += "     count_number = count_number + " + count.ToString() + @"
    ,user_id = @user_id
    ,date_time = @date_time
    where date = @date
    and reporting_roundup_type_rcd = @reporting_roundup_type_rcd
    and reporting_reference_code = @reporting_reference_code
    ";

            using (SqlCommand command = new SqlCommand(sql, connection, transaction)) {
                command.Parameters.Add("@date", SqlDbType.DateTime).Value = date.Date;
                command.Parameters.Add("@reporting_roundup_type_rcd", SqlDbType.NVarChar).Value = reportingRoundupTypeRcd;
                command.Parameters.Add("@reporting_reference_code", SqlDbType.NVarChar).Value = reportingReferenceCode;
                command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = DateTime.UtcNow;

                if (command.ExecuteNonQuery() == 0) {
                    command.Parameters.Add("@reporting_roundup_id", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                    command.Parameters.Add("@count_number", SqlDbType.Int).Value = 1;

                    sql = "insert into reporting_roundup ( reporting_roundup_id,  date,  reporting_roundup_type_rcd,  reporting_reference_code,  count_number,  user_id,  date_time)";
                    sql += "                      values (@reporting_roundup_id, @date, @reporting_roundup_type_rcd, @reporting_reference_code, @count_number, @user_id, @date_time)";

                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateOrInsert(
            DateTime date,
            string reportingRoundupTypeRcd,
            string reportingReferenceCode,
            int count,
            Guid userId
            ) {

            string sql = string.Empty;
            sql += " update reporting_roundup set\r\n";
            sql += "     count_number = count_number + " + count.ToString() + @"
    ,user_id = @user_id
    ,date_time = @date_time
    where date = @date
    and reporting_roundup_type_rcd = @reporting_roundup_type_rcd
    and reporting_reference_code = @reporting_reference_code
    ";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using (SqlCommand command = new SqlCommand(sql, conn)) {
                    command.Parameters.Add("@date", SqlDbType.DateTime).Value = date.Date;
                    command.Parameters.Add("@reporting_roundup_type_rcd", SqlDbType.NVarChar).Value = reportingRoundupTypeRcd;
                    command.Parameters.Add("@reporting_reference_code", SqlDbType.NVarChar).Value = reportingReferenceCode;
                    command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = userId;
                    command.Parameters.Add("@date_time", SqlDbType.DateTime).Value = DateTime.UtcNow;

                    if (command.ExecuteNonQuery() == 0) {
                        command.Parameters.Add("@reporting_roundup_id", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                        command.Parameters.Add("@count_number", SqlDbType.Int).Value = 1;

                        sql = "insert into reporting_roundup ( reporting_roundup_id,  date,  reporting_roundup_type_rcd,  reporting_reference_code,  count_number,  user_id,  date_time)";
                        sql += "                      values (@reporting_roundup_id, @date, @reporting_roundup_type_rcd, @reporting_reference_code, @count_number, @user_id, @date_time)";

                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
