using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace norpim.DataAccessLayer {
    /// <summary> 
    /// Provides user activity search 
    /// </summary>
    /// <domain>User</domain>
    public partial class UserActivitySearch {
        /// <summary>Get recent user activities</summary>
        /// <cardinality>Many</cardinality>
        public List<UserActivityRecent> UserActivityRecent() {
            var ret = new List<UserActivityRecent>();

            string sql = @" 
                    select top 200
	                     ua.date_time
	                    ,uatr.user_activity_type_name
	                    ,ua.originating_address
	                    ,ua.user_activity_note
                    from user_activity as ua
                    inner join user_activity_type_ref as uatr on uatr.user_activity_type_rcd = ua.user_activity_type_rcd
                    order by ua.date_time desc                   
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    var ordinals = new UserActivityRecentOrdinals(reader);
                    while (reader.Read()) {
                        var data = new UserActivityRecent();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }
                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>User activities grouped</summary>
        /// <cardinality>Many</cardinality>
        public List<UserActivityGrouped> UserActivityGrouped() {
            var ret = new List<UserActivityGrouped>();

            string sql = @" 
                    select 
	                     ua.originating_address
	                    ,uatr.user_activity_type_name
						,ua.user_activity_note
	                    ,count(1) as occurrences
                    from user_activity as ua
                    inner join user_activity_type_ref as uatr on uatr.user_activity_type_rcd = ua.user_activity_type_rcd
					group by 
	                     ua.originating_address
	                    ,uatr.user_activity_type_name
						,ua.user_activity_note
                    order by 
						count(1) desc
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    var ordinals = new UserActivityGroupedOrdinals(reader);
                    while (reader.Read()) {
                        var data = new UserActivityGrouped();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }
                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>User activities grouped by address</summary>
        /// <cardinality>Many</cardinality>
        public List<UserActivityGroupedByAddress> UserActivityGroupedByAddress() {
            var ret = new List<UserActivityGroupedByAddress>();

            string sql = @" 
                    select 
	                     ua.originating_address
	                    ,count(1) as occurrences
                    from user_activity as ua
                    inner join user_activity_type_ref as uatr on uatr.user_activity_type_rcd = ua.user_activity_type_rcd
					group by 
	                     ua.originating_address
                    order by 
						count(1) desc
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {
                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    var ordinals = new UserActivityGroupedByAddressOrdinals(reader);
                    while (reader.Read()) {
                        var data = new UserActivityGroupedByAddress();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }
                    reader.Close();
                }

                return ret;
            }
        }
    }
}