using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SolutionNorSolutionPim.DataAccessLayer {
    public class Logging {
        public Stopwatch StopWatch;
        private Guid UserId;
        private string _sql;

        public string DomainName { get; set; }
        public string LayerName { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }

        public DateTime StartUTC { get; set; }
        public DateTime StopUTC { get; set; }

        public static Logging PerformanceTimeStart(
            string commandName
            ) {

            Logging log = new Logging {
                MethodName = commandName,
                StopWatch = new Stopwatch(),
                StartUTC = DateTime.UtcNow
            };
            log.StopWatch.Start();

            return log;
        }

        public static Logging PerformanceTimeStart(
            string domainName,
            string layerName,
            string className,
            string methodName,
            Guid? userId = null
            ) {

            Logging log = new Logging {
                DomainName = domainName,
                LayerName = layerName,
                ClassName = className,
                MethodName = methodName
            };

            if (userId != null) {
                log.UserId = (Guid)userId;
            }

            log.StopWatch = new Stopwatch();
            log.StopWatch.Start();
            log.StartUTC = DateTime.UtcNow;

            return log;
        }

        public void PerformanceTimeStop(
            ) {
            PerformanceTimeStop(logIfMoreThanMilliseconds: 100);
        }

        public void PerformanceTimeStop(
            int logIfMoreThanMilliseconds
            ) {
            StopWatch.Stop();
            StopUTC = DateTime.UtcNow;

            if (StopWatch.ElapsedMilliseconds > logIfMoreThanMilliseconds) {
                CrudeDefaultPerformanceTimeData performance = new CrudeDefaultPerformanceTimeData {
                    CommandName = MethodName,
                    Milliseconds = (int)StopWatch.ElapsedMilliseconds,
                    DefaultUserId = UserId,
                    DateTime = DateTime.UtcNow
                };
                performance.Insert();

                // update rollup
                int hits = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(@" 
                                update [default_performance_time_rollup] set
                                        milliseconds = milliseconds + @milliseconds
                                    ,hits = hits + 1
                                where command_name = @command_name
                                ",
                            conn
                            )) {

                        command.Parameters.Add("@command_name", SqlDbType.NVarChar).Value = MethodName;
                        command.Parameters.Add("@milliseconds", SqlDbType.BigInt).Value = (int)StopWatch.ElapsedMilliseconds;

                        hits = command.ExecuteNonQuery();
                    }
                }

                if (hits == 0) {
                    // no hits, insert instead
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                        conn.Open();
                        using (SqlCommand command = new SqlCommand(@"
                                insert into [default_performance_time_rollup] (default_performance_time_rollup_id, command_name, milliseconds, hits, date_time, default_user_id)
                                        values (newid(), @command_name, @milliseconds, 1, getutcdate(), @user_id)
                                ",
                               conn
                               )) {
                            command.Parameters.Add("@command_name", SqlDbType.NVarChar).Value = MethodName;
                            command.Parameters.Add("@milliseconds", SqlDbType.BigInt).Value = (int)StopWatch.ElapsedMilliseconds;
                            command.Parameters.Add("@user_id", SqlDbType.UniqueIdentifier).Value = UserId;
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public void PerformanceTimePrepare(
            string sql,
            SqlCommand command
            ) {
            // replace parameters in sql
            foreach (SqlParameter parameter in command.Parameters) {
                try {
                    sql = sql.Replace(parameter.ParameterName, "'" + parameter.Value.ToString() + "'");
                } catch { }
            }
            _sql = sql;
        }

        public void PerformanceTimePrepare(
            SqlCommand command
            ) {
            PerformanceTimePrepare(
                command.CommandText,
                command
                );
        }

        public void PerformanceTimeCheck(
            ) {
            StopWatch.Stop();
            if (StopWatch.ElapsedMilliseconds > 500) {
                CrudeDefaultPerformanceTimeData performance = new CrudeDefaultPerformanceTimeData {
                    CommandName = MethodName,
                    Milliseconds = (int)StopWatch.ElapsedMilliseconds,
                    DefaultUserId = UserId,
                    DateTime = DateTime.UtcNow
                };
                performance.Insert();
            }

            if (StopWatch.ElapsedMilliseconds > 500) {
                CrudeDefaultPerformanceIssueData performance = new CrudeDefaultPerformanceIssueData {
                    CommandName = MethodName,
                    CommandText = _sql,
                    Milliseconds = (int)StopWatch.ElapsedMilliseconds,
                    DefaultUserId = UserId,
                    DateTime = DateTime.UtcNow
                };
                performance.Insert();
            }
        }

        public void PerformanceTimeStop(
            string sql,
            SqlCommand command
            ) {
            StopWatch.Stop();
            PerformanceTimePrepare(sql, command);
            PerformanceTimeCheck();
        }

        public void LogRun(
            string eventName
            ) {

        }

        public void Error(
            Exception ex
            ) {

            if (!string.IsNullOrEmpty(_sql)) {
                PerformanceTimeCheck();
            }

            Logging.ErrorLog(
                DomainName,
                ClassName,
                MethodName,
                ex.Message,
                ex.StackTrace,
                UserId
                );
        }

        public static void ActionLog(
            string message,
            Guid userId
            ) {

            try {
                CrudeDefaultUserActivityData contract = new CrudeDefaultUserActivityData {
                    DefaultUserActivityId = Guid.NewGuid(),
                    DefaultUserActivityTypeRcd = DefaultUserActivityTypeRef.BusinessLogicMethodInvoked,
                    OriginatingAddress = System.Environment.MachineName,
                    UserActivityNote = message,

                    DefaultUserId = userId,
                    DateTime = DateTime.UtcNow
                };

                contract.Insert();
            } catch { };
        }

        public static void ErrorLog(
            string domainName,
            string className,
            string methodName,
            string errorMessage,
            string stackTrace,
            Guid userId
            ) {

            try {
                CrudeDefaultErrorData contract = new CrudeDefaultErrorData {
                    DefaultErrorId = Guid.NewGuid(),
                    DefaultErrorTypeRcd = DefaultErrorTypeRef.SilentCaught,
                    DefaultErrorLayerRcd = DefaultErrorLayerRef.BusinessLogicLayerSoap,
                    // todo, layer address added ( in erwin )
                    DomainName = domainName,
                    ClassName = className,
                    MethodName = methodName,
                    StackTrace = stackTrace,
                    ErrorMessage = errorMessage,
                    DefaultUserId = userId,
                    DateTime = DateTime.UtcNow
                };
                contract.Insert();
            } catch {
                // never mind, most likely a network / environment issue
            };
        }
    }
}
