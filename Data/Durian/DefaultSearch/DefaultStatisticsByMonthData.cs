/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 9:43:35 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultStatisticsByMonthData {
        
        public string ActivityDate { get; set; }
        
        public int DayCount { get; set; }
        
        public void Populate(IDataReader reader, DefaultStatisticsByMonthDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ActivityDate)) ActivityDate = reader.GetString(ordinals.ActivityDate);
            if (!reader.IsDBNull(ordinals.DayCount)) DayCount = reader.GetInt32(ordinals.DayCount);
        }
    }
    
    public partial class DefaultStatisticsByMonthDataOrdinals {
        
        public int ActivityDate;
        
        public int DayCount;
        
        public DefaultStatisticsByMonthDataOrdinals(IDataReader reader) {
            ActivityDate = reader.GetOrdinal("activity_date");
            DayCount = reader.GetOrdinal("day_count");
        }
    }
}
