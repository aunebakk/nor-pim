using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace norpim.DataAccessLayer {
    /// <summary> 
    /// Provides statistics on many data points
    /// </summary>
    /// <domain>Statistics</domain>
    public partial class StatisticsSearch {
        /// <summary>Get product statistics</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductStatistics> ProductStatistics() {
            var ret = new List<ProductStatistics>();

            string sql = @" 
                    select 
	                     convert(nvarchar(30), date_time, 2) as activity_date
	                    ,count(*) as day_count
                    from user_activity as ua
                    where 1=1
                    group by convert(nvarchar(30), date_time, 2)
                    order by convert(nvarchar(30), date_time, 2) desc
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductStatisticsOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductStatistics();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get product statistics by month</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductStatisticsByMonth> ProductStatisticsByMonth() {
            var ret = new List<ProductStatisticsByMonth>();

            string sql = @" 
                    select 
	                     convert(nvarchar(5), date_time, 2) as activity_date
	                    ,count(*) as day_count
                    from user_activity as ua
                    where 1=1
                    group by convert(nvarchar(5), date_time, 2)
                    order by convert(nvarchar(5), date_time, 2) desc
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductStatisticsByMonthOrdinals(reader);

                    while (reader.Read()) {
                        var data = new ProductStatisticsByMonth();
                        data.Populate(reader, ordinals);
                        ret.Add(data);
                    }

                    reader.Close();
                }

                return ret;
            }
        }

        /// <summary>Get product statistics</summary>
        /// <cardinality>Many</cardinality>
        public List<ProductStatisticsTop5> ProductStatisticsTop5() {
            var ret = new List<ProductStatisticsTop5>();

            string sql = @" 
                select 'utc' as measurement, convert(nvarchar(240), getutcdate(), 121) as value
                union all
                select 'db version', @@version
                union all
                select 'user activities', convert(nvarchar(240), count(*)) as value from user_activity
                union all
                select 'categories', convert(nvarchar(240), count(*)) from product_category as c 
                union all
                select 'categories active', convert(nvarchar(240), count(*)) from product_category as c where c.product_category_became_id is null
                union all
                select 'categories became', convert(nvarchar(240), count(*)) from product_category as c where c.product_category_became_id is not null
                union all
                select 'products', convert(nvarchar(240), count(*)) from product
                union all
                select 'products active', convert(nvarchar(240), count(*)) from product as p where p.product_became_id is null
                union all
                select 'products became', convert(nvarchar(240), count(*)) from product as p where p.product_became_id is not null
                union all
                select 'product identifiers', convert(nvarchar(240), count(*)) from product_identifier
                union all
                select 'product attributes', convert(nvarchar(240), count(*)) from product_attribute
                union all
                select 'product info', convert(nvarchar(240), count(*)) from product_info
                union all
                select 'product documentations', convert(nvarchar(240), count(*)) from product_documentation
                union all
                select 'product images', convert(nvarchar(240), count(*)) from product_image
                union all
                select 'users', convert(nvarchar(240), count(*)) from [user] as u
                union all
                select 'system settings', convert(nvarchar(240), count(*)) from system_setting as ss
                union all
                select 'system reference tables', convert(nvarchar(240), count(*)) from system_reference_table as srt
                union all
                select 'product gathers', convert(nvarchar(240), count(*)) from product_gather as pg
                union all
                select 'product field sets', convert(nvarchar(240), count(*)) from product_field_set as pfs
                union all
                select 'product exposes', convert(nvarchar(240), count(*)) from product_expose as pe
                ";

            using (var conn = new SqlConnection(ConfigurationManager.AppSettings["Conn"])) {
                conn.Open();

                using (var command = new SqlCommand(sql, conn)) {

                    IDataReader reader = command.ExecuteReader(CommandBehavior.SingleResult);

                    var ordinals = new ProductStatisticsTop5Ordinals(reader);

                    while (reader.Read()) {
                        var data = new ProductStatisticsTop5();
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
