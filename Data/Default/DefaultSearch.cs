using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SolutionNorSolutionPim.DataAccessLayer
{
    /// <summary> 
    /// Provides error search durians
    /// </summary>
    /// <domain>Default</domain>
    public class DefaultSearch
    {
        /// <summary>Get Default Performance Issue</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultTestOverviewData> DefaultTestOverview(
            System.String commandName
            ) {

            var ret = new List<DefaultTestOverviewData>();
            string sql = @"
                select 
	                 dt.test_area
	                ,dtr.start_date_time
	                ,dtr.default_test_run_result_rcd
                from default_test_run	as dtr
                inner join default_test as dt	on dt.default_test_id = dtr.default_test_id
                order by dtr.date_time desc
                ";

            Logging log = Logging.PerformanceTimeStart("DefaultTestOverview");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultTestOverviewDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultTestOverviewData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get Dashboard statistics</summary>
        /// <cardinality>Many</cardinality>
        public List<DashboardCountsData> DashboardCounts(string dashboardLayoutRcd) {
            var ret = new List<DashboardCountsData>();

            string sql = @" 
                select 
                      'UTC'                                     as dashboard_item_rcd
                     ,'Universal Time Coordinated'              as dashboard_item_name
                     ,''                                        as image_source
                     ,convert(nvarchar(240), getutcdate(), 121) as value
					 ,0                                         as last_24_hours_count
                     ,convert(nvarchar(240), getutcdate(), 121) as last_date_time
                     ,''                                        as last_user_name
                     ,''                                        as url
                     ,0                                         as position_left
                     ,0                                         as position_top
                     ,0                                         as position_offset
                union all
                select 
                      'DBV'                                     as dashboard_item_rcd
                     ,'DB Version'                              as dashboard_item_name
                     ,''                                        as image_source
                     ,@@version                                 as value
					 ,0                                         as last_24_hours_count
                     ,convert(nvarchar(240), getutcdate(), 121) as last_date_time
                     ,''                                        as last_user_name
                     ,''                                        as url
                     ,0                                         as position_left
                     ,0                                         as position_top
                     ,0                                         as position_offset";

            sql += "\r\n";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();
                conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                using ( var command = new SqlCommand(sql, conn) ) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new DashboardCountsDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new DashboardCountsData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }
            }
            return ret;
        }

        /// <summary>Get Default Performance Issue</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultPerformanceIssueFetchWithFilterData> DefaultPerformanceIssueFetchWithFilter(
            System.String commandName
            ) {

            var ret = new List<DefaultPerformanceIssueFetchWithFilterData>();
            string sql = @"select
                     dpi.date_time
                    ,dpi.command_name
                    ,dpi.milliseconds
                    ,dpi.default_performance_issue_id
                from default_performance_issue as dpi
                order by dpi.date_time desc
                ";

            Logging log = Logging.PerformanceTimeStart("DefaultPerformanceIssueFetchWithFilter");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultPerformanceIssueFetchWithFilterDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultPerformanceIssueFetchWithFilterData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get Default Issue</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultIssueWithFilterData> DefaultIssueWithFilter(
             System.String defaultIssueTypeRcd
            , System.String defaultIssueStatusRcd
            ) {

            var ret = new List<DefaultIssueWithFilterData>();
            string sql = @"
                select
                     di.default_issue_type_rcd
                    ,ditr.default_issue_type_name
                    ,di.default_issue_status_rcd
                    ,disr.default_issue_status_name
                    ,di.default_error_id
                    ,de.method_name as method_name
                    ,di.issue_name
                    ,di.issue_description
                    ,di.steps_to_reproduce
                    ,di.link
                    ,di.date_time
                    ,di.default_issue_id
                from default_issue as di
                inner join default_issue_type_ref as ditr on ditr.default_issue_type_rcd = di.default_issue_type_rcd
                inner join default_issue_status_ref as disr on disr.default_issue_status_rcd = di.default_issue_status_rcd
                left join default_error as de on de.default_error_id = di.default_error_id
                where 1=1
";

            Logging log = Logging.PerformanceTimeStart("DefaultIssueWithFilter");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        if ( defaultIssueTypeRcd != null ) {
                            command.Parameters.Add("@default_issue_type_rcd", SqlDbType.NVarChar).Value = defaultIssueTypeRcd;
                            sql += "               and di.default_issue_type_rcd = @default_issue_type_rcd\r\n";
                        }

                        if ( defaultIssueStatusRcd != null ) {
                            command.Parameters.Add("@default_issue_status_rcd", SqlDbType.NVarChar).Value = defaultIssueStatusRcd;
                            sql += "               and di.default_issue_status_rcd = @default_issue_status_rcd\r\n";
                        }

                        sql += @"               order by     
	                                            di.date_time desc";

                        command.CommandText = sql;
                        log.PerformanceTimePrepare(command);

                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultIssueWithFilterDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultIssueWithFilterData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Error overview, last first </summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultErrorOverviewData> DefaultErrorOverview() {
            var ret = new List<DefaultErrorOverviewData>();

            string sql = @" 
                select top 50
	                 de.default_error_id
	                ,de.date_time
	                ,delr.default_error_layer_name
	                ,detr.default_error_type_name
	                ,de.domain_name
	                ,de.class_name
	                ,de.method_name
	                ,de.error_message
                from default_error					as de
                inner join default_error_layer_ref	as delr	on delr.default_error_layer_rcd = de.default_error_layer_rcd
                inner join default_error_type_ref	as detr on detr.default_error_type_rcd = de.default_error_type_rcd
                order by de.date_time desc
                ";

            Logging log = Logging.PerformanceTimeStart("DefaultErrorOverview");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultErrorOverviewDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultErrorOverviewData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get default statistics</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultPerformanceIndicatorsData> DefaultPerformanceIndicators() {
            var ret = new List<DefaultPerformanceIndicatorsData>();

            string sql = @" 
                select 
	                 dpt.command_name
	                ,dpt.hits				as hit_count
	                ,cast(dpt.milliseconds 
						/ dpt.hits as int)	as average_milliseconds
                from default_performance_time_rollup as dpt
                order by dpt.command_name
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultPerformanceIndicators");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultPerformanceIndicatorsDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultPerformanceIndicatorsData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get default statistics</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultStatisticsData> DefaultStatistics() {
            var ret = new List<DefaultStatisticsData>();

            string sql = @" 
                    select top 50 
	                     convert(nvarchar(30), date_time, 2) as activity_date
	                    ,count(*) as day_count
                    from default_user_activity as ua
                    group by convert(nvarchar(30), date_time, 2)
                    order by convert(nvarchar(30), date_time, 2) desc
                ";

            // where 1=1

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultStatistics");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultStatisticsDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultStatisticsData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get default User Activity By Hour</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultUserActivityByHourData> DefaultUserActivityByHour() {
            var ret = new List<DefaultUserActivityByHourData>();

            string sql = @" 
                select 
	                 convert(varchar(2), datepart(dd, date_time)) + '.' + convert(varchar(2), datepart(hh, date_time)) as hour_number
	                ,count(1) as hour_count
                from default_user_activity
                where date_time > dateadd(hh, -24, getutcdate())
                group by 	 
	                 datepart(dd, date_time)
	                ,datepart(hh, date_time)
                order by 	 
	                 datepart(dd, date_time)
	                ,datepart(hh, date_time)
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultUserActivityByHour");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultUserActivityByHourDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultUserActivityByHourData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get default statistics by month</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultStatisticsByMonthData> DefaultStatisticsByMonth() {
            var ret = new List<DefaultStatisticsByMonthData>();

            string sql = @" 
                    select top 50 
	                     convert(nvarchar(5), date_time, 2) as activity_date
	                    ,count(*) as day_count
                    from default_user_activity as ua
                    where 1=1
                    group by convert(nvarchar(5), date_time, 2)
                    order by convert(nvarchar(5), date_time, 2) desc
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultStatisticsByMonth");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultStatisticsByMonthDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultStatisticsByMonthData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get default statistics</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultStatisticsTop5Data> DefaultStatisticsTop5() {
            var ret = new List<DefaultStatisticsTop5Data>();

            string sql = @" 
                select 'utc' as measurement, convert(nvarchar(240),				getutcdate(), 121) as value
                union all
                select 'db version', @@version
                union all
                select 'default change log', convert(nvarchar(240),				count(*)) from default_change_log					
                union all
                select 'default error', convert(nvarchar(240),					count(*)) from default_error
                union all
                select 'default issue', convert(nvarchar(240),					count(*)) from default_issue
                union all
                select 'default performance issue', convert(nvarchar(240),		count(*)) from default_performance_issue
                union all
                select 'default performance time', convert(nvarchar(240),		count(*)) from default_performance_time
                union all
                select 'default rule', convert(nvarchar(240),					count(*)) from default_rule
                union all
                select 'default system reference table', convert(nvarchar(240),	count(*)) from default_system_reference_table
                union all
                select 'default system setting', convert(nvarchar(240),			count(*)) from default_system_setting
                union all
                select 'default user', convert(nvarchar(240),					count(*)) from default_user
                union all
                select 'default user activity', convert(nvarchar(240),			count(*)) from default_user_activity
                union all
                select 'products', convert(nvarchar(240),			            count(*)) from product
                union all
                select 'categories', convert(nvarchar(240),			            count(*)) from product_category
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultStatisticsTop5");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultStatisticsTop5DataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultStatisticsTop5Data();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get list of available performance time commands</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultPerformanceTimesData> DefaultPerformanceTimes(
            string commandName
            ) {

            var ret = new List<DefaultPerformanceTimesData>();

            string sql = @" 
                 select top 50
	                dpt.date_time,
	                dpt.milliseconds
                 from default_performance_time as dpt
                 where dpt.command_name = @command_name
                 order by date_time
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultPerformanceTimes");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        command.Parameters.Add("@command_name", SqlDbType.VarChar).Value = commandName;
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultPerformanceTimesDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultPerformanceTimesData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get list of available performance time commands</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultPerformanceTimeCommandsData> DefaultPerformanceTimeCommands(
            ) {

            var ret = new List<DefaultPerformanceTimeCommandsData>();

            string sql = @" 
                 select  
					 dpt.command_name 
					,iif(
						substring(	dpt.command_name, 
							len(dpt.command_name) 
							- charindex(
								'.', 
								reverse(dpt.command_name)) + 2, 200) = '', 
						dpt.command_name, 
						substring(	dpt.command_name, 
							len(dpt.command_name) 
							- charindex(
								'.', 
								reverse(dpt.command_name)) + 2, 200)
						)	as command_display_name
						
                from default_performance_time as dpt
                order by dpt.command_name 
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultPerformanceTimeCommands");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultPerformanceTimeCommandsDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultPerformanceTimeCommandsData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get recent user activities</summary>
        /// <summary>Filters out activities with rule in default_rule ( Type 'Hide' ) </summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultUserActivityRecentData> DefaultUserActivityRecent(
            Guid defaultUserId
            ) {

            var ret = new List<DefaultUserActivityRecentData>();

            string sql = @" 
                    select top 50
	                     ua.date_time
	                    ,uatr.default_user_activity_type_name   as user_activity_type_name
	                    ,ua.originating_address
						,ua.referrer
	                    ,ua.user_activity_note
					from default_user_activity                  as ua
                    inner join default_user_activity_type_ref   as uatr on uatr.default_user_activity_type_rcd = ua.default_user_activity_type_rcd
            ";
            if ( defaultUserId == Guid.Empty ) {
                sql += @"
					 left join default_rule						as der	on der.address = ua.originating_address
																	   and der.default_rule_type_rcd = @default_rule_type_rcd
					where der.default_rule_id is null
                   ";
            }

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultUserActivityRecent");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        if ( defaultUserId == Guid.Empty ) {
                            command.Parameters.Add("@default_rule_type_rcd", SqlDbType.NVarChar).Value = DefaultRuleTypeRef.HideLayerAddress;
                        } else {
                            sql += " where ua.default_user_id = @default_user_id\r\n";
                            command.Parameters.Add("@default_user_id", SqlDbType.UniqueIdentifier).Value = defaultUserId;
                        }

                        sql += "                    order by ua.date_time desc";
                        log.PerformanceTimePrepare(command);

                        command.CommandText = sql;

                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultUserActivityRecentDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultUserActivityRecentData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get recent user activities with address filter</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultUserActivityOnAddressData> DefaultUserActivityOnAddress(
            string originatingAddress
            ) {
            var ret = new List<DefaultUserActivityOnAddressData>();

            string sql = @" 
                    select top 50
	                     ua.date_time
	                    ,uatr.default_user_activity_type_name   as user_activity_type_name
	                    ,ua.originating_address
	                    ,ua.user_activity_note
					from default_user_activity                  as ua
                    inner join default_user_activity_type_ref   as uatr on uatr.default_user_activity_type_rcd = ua.default_user_activity_type_rcd
					--realwhere
					where ua.originating_address = @originating_address
                    order by ua.date_time desc                   
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultUserActivityOnAddress");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        command.Parameters.Add("@originating_address", SqlDbType.VarChar).Value = originatingAddress;
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultUserActivityOnAddressDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultUserActivityOnAddressData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>User activities grouped</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultUserActivityGroupedData> DefaultUserActivityGrouped() {
            var ret = new List<DefaultUserActivityGroupedData>();

            string sql = @" 
                    select top 50
	                     ua.originating_address
	                    ,uatr.default_user_activity_type_name as user_activity_type_name
						,ua.user_activity_note
	                    ,count(1) as occurrences
                    from default_user_activity as ua
                    inner join default_user_activity_type_ref as uatr on uatr.default_user_activity_type_rcd = ua.default_user_activity_type_rcd
					group by 
	                     ua.originating_address
	                    ,uatr.default_user_activity_type_name
						,ua.user_activity_note
                    order by 
						count(1) desc
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultUserActivityGrouped");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultUserActivityGroupedDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultUserActivityGroupedData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>User activities grouped by address</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultUserActivityGroupedByAddressData> DefaultUserActivityGroupedByAddress() {
            var ret = new List<DefaultUserActivityGroupedByAddressData>();

            string sql = @" 
                    select top 50
	                     ua.originating_address
	                    ,count(1) as occurrences
                    from default_user_activity as ua
                    inner join default_user_activity_type_ref as uatr on uatr.default_user_activity_type_rcd = ua.default_user_activity_type_rcd
					group by 
	                     ua.originating_address
                    order by 
						count(1) desc
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultUserActivityGroupedByAddress");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultUserActivityGroupedByAddressDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultUserActivityGroupedByAddressData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get user list</summary>
        /// <summary>With indicators of user activities</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultUserListData> DefaultUserList() {
            var ret = new List<DefaultUserListData>();

            string sql = @" 
                select top 100
	                 du.last_activity_date_time
	                ,du.default_user_name
	                ,du.default_user_code
	                ,du.date_time				as created_date_time
	                ,du.email
	                ,dsr.default_state_name
	                ,(	select 
			                count(*)
		                from default_user_activity as dua
		                where dua.default_user_id = du.default_user_id
		                )						as activity_count
	                ,duc.default_user_code		as created_by_default_user_code
	                ,duc.default_user_name		as created_by_default_user_name
	                ,du.default_user_id
                from default_user				as du
                inner join default_state_ref	as dsr	on dsr.default_state_rcd = du.default_state_rcd
                inner join default_user			as duc	on duc.default_user_id = du.created_by_default_user_id
                --realwhere
                order by du.last_activity_date_time desc
                ";
            /*
                                ,(	select count(*) 
                                    from default_user_activity as dua 
                                    where dua.originating_address = du.default_user_code
                                    ) 					    as activity_count
            */
            /*
                                ,(	select 
                                        count(*)
                                    from default_user_activity as dua
                                    where dua.default_user_id = du.default_user_id
                                    )						as activity_count
            */
            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultUserList");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultUserListDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultUserListData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get user list for use in dashboard</summary>
        /// <summary>With indicators of user activities</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultUserListForDashboardData> DefaultUserListForDashboard() {
            var ret = new List<DefaultUserListForDashboardData>();

            string sql = @" 
                select top 25
	                 du.default_user_code
	                ,du.default_user_name
	                ,du.email
	                ,dsr.default_state_name
	                ,(	select 
			                count(*)
		                from default_user_activity as dua
		                where dua.default_user_id = du.default_user_id
		                )						as activity_count

                    ,convert(
                        nvarchar(240), 
                        du.last_activity_date_time, 
                        121
                        )                       as last_activity_date_time

                    ,convert(
                        nvarchar(240), 
                        du.date_time, 
                        121
                        )                       as created_date_time

	                ,duc.default_user_code		as created_by_default_user_code
	                ,duc.default_user_name		as created_by_default_user_name
	                ,du.default_user_id
                from default_user				as du
                inner join default_state_ref	as dsr	on dsr.default_state_rcd = du.default_state_rcd
                inner join default_user			as duc	on duc.default_user_id = du.created_by_default_user_id
                --realwhere
                order by du.last_activity_date_time desc
                ";
            /*
                                ,(	select count(*) 
                                    from default_user_activity as dua 
                                    where dua.originating_address = du.default_user_code
                                    ) 					    as activity_count
            */
            /*
                                ,(	select 
                                        count(*)
                                    from default_user_activity as dua
                                    where dua.default_user_id = du.default_user_id
                                    )						as activity_count
            */
            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultUserListForDashboard");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultUserListForDashboardDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultUserListForDashboardData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get Default Change Log</summary>
        /// <cardinality>Many</cardinality>
        public List<GetDefaultChangeLogData> GetDefaultChangeLog(
             System.String defaultChangeName
            , System.String defaultChangeLogTypeRcd
            , System.Guid defaultIssueId
            , System.Guid defaultChangeLogId
            ) {

            var ret = new List<GetDefaultChangeLogData>();
            string sql = @"select
     dcl.default_change_name
    ,dcl.default_change_description
    ,dcl.date_time
    ,dcl.default_change_log_type_rcd
    ,dcltr.default_change_log_type_name
    ,dcl.default_issue_id
    ,di.issue_name as issue_name
    ,dcl.default_change_log_id
from default_change_log as dcl
inner join default_change_log_type_ref as dcltr on dcltr.default_change_log_type_rcd = dcl.default_change_log_type_rcd
left join default_issue as di on di.default_issue_id = dcl.default_issue_id
where 1 = 1
";

            using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                conn.Open();

                using ( var command = new SqlCommand(sql, conn) ) {
                    if ( !String.IsNullOrEmpty(defaultChangeName) ) {
                        command.Parameters.Add("@default_change_name", SqlDbType.NVarChar).Value = ( System.String ) defaultChangeName;
                        sql += " and dcl.default_change_name = @default_change_name";
                    }
                    if ( !String.IsNullOrEmpty(defaultChangeLogTypeRcd) ) {
                        command.Parameters.Add("@default_change_log_type_rcd", SqlDbType.NVarChar).Value = ( System.String ) defaultChangeLogTypeRcd;
                        sql += " and dcl.default_change_log_type_rcd = @default_change_log_type_rcd";
                    }
                    if ( defaultIssueId != Guid.Empty ) {
                        command.Parameters.Add("@default_issue_id", SqlDbType.UniqueIdentifier).Value = ( System.Guid ) defaultIssueId;
                        sql += " and dcl.default_issue_id = @default_issue_id";
                    }
                    if ( defaultChangeLogId != Guid.Empty ) {
                        command.Parameters.Add("@default_change_log_id", SqlDbType.UniqueIdentifier).Value = ( System.Guid ) defaultChangeLogId;
                        sql += " and dcl.default_change_log_id = @default_change_log_id";
                    }

                    Logging log = Logging.PerformanceTimeStart("GetDefaultChangeLog");
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    log.PerformanceTimeStop(sql, command);

                    var ordinals = new GetDefaultChangeLogDataOrdinals(reader);

                    while ( reader.Read() ) {
                        var data = new GetDefaultChangeLogData();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get default resource statistics</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultResourceStatisticsData> DefaultResourceStatistics() {
            var ret = new List<DefaultResourceStatisticsData>();

            string sql = @" 
select top 20 
	 convert(varchar(2), datepart(day, date_time)) 
		+ '.' + convert(varchar(2), datepart(hour, date_time)) 
		+ '.' + convert(varchar(2), datepart(minute, date_time)) as hour_number
	,drm.client_workingset_bytes
	,drm.business_workingset_bytes
	,drm.database_size_bytes
from default_resource_measurement as drm
order by date_time desc
                ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultResourceStatistics");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultResourceStatisticsDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultResourceStatisticsData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }

        /// <summary>Get default database size</summary>
        /// <cardinality>Many</cardinality>
        public List<DefaultResourceDatabaseStatisticsData> DefaultResourceDatabaseStatistics() {
            var ret = new List<DefaultResourceDatabaseStatisticsData>();

            string sql = @" 
                select cast(sum(reserved_page_count) * 8.0 as int) as reserved_page_count
                from sys.dm_db_partition_stats
            ";

            Logging log = Logging.PerformanceTimeStart("Default", "DataAccessLayer", "DefaultSearch", "DefaultResourceDatabaseStatistics");
            try {
                using ( var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"]) ) {
                    conn.Open();
                    conn.BeginTransaction(IsolationLevel.ReadUncommitted).Commit();

                    using ( var command = new SqlCommand(sql, conn) ) {
                        log.PerformanceTimePrepare(command);
                        IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                        log.PerformanceTimeCheck();

                        var ordinals = new DefaultResourceDatabaseStatisticsDataOrdinals(reader);
                        while ( reader.Read() ) {
                            var data = new DefaultResourceDatabaseStatisticsData();
                            data.Populate(reader, ordinals);
                            ret.Add(data);
                        }

                        reader.Close();
                    }
                }
            } catch ( Exception ex ) {
                log.Error(ex);
            }
            return ret;
        }
    }
}
