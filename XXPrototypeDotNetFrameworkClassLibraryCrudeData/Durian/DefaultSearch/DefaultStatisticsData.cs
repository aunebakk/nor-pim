/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:07:45 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class DefaultStatisticsData {
        
        public string ActivityDate { get; set; } //;
        
        public int DayCount { get; set; } //;
        
        public void Populate(IDataReader reader, DefaultStatisticsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ActivityDate)) ActivityDate = reader.GetString(ordinals.ActivityDate);
            if (!reader.IsDBNull(ordinals.DayCount)) DayCount = reader.GetInt32(ordinals.DayCount);
        }
    }
    
    public partial class DefaultStatisticsDataOrdinals {
        
        public int ActivityDate;
        
        public int DayCount;
        
        public DefaultStatisticsDataOrdinals(IDataReader reader) {
            ActivityDate = reader.GetOrdinal("activity_date");
            DayCount = reader.GetOrdinal("day_count");
        }
    }
}
