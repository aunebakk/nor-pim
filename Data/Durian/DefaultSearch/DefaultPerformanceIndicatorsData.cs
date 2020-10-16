/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 7:05:55 AM
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
    public partial class DefaultPerformanceIndicatorsData {
        
        public string CommandName { get; set; }
        
        public long HitCount { get; set; }
        
        public int AverageMilliseconds { get; set; }
        
        public void Populate(IDataReader reader, DefaultPerformanceIndicatorsDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.CommandName)) CommandName = reader.GetString(ordinals.CommandName);
            if (!reader.IsDBNull(ordinals.HitCount)) HitCount = reader.GetInt64(ordinals.HitCount);
            if (!reader.IsDBNull(ordinals.AverageMilliseconds)) AverageMilliseconds = reader.GetInt32(ordinals.AverageMilliseconds);
        }
    }
    
    public partial class DefaultPerformanceIndicatorsDataOrdinals {
        
        public int CommandName;
        
        public int HitCount;
        
        public int AverageMilliseconds;
        
        public DefaultPerformanceIndicatorsDataOrdinals(IDataReader reader) {
            CommandName = reader.GetOrdinal("command_name");
            HitCount = reader.GetOrdinal("hit_count");
            AverageMilliseconds = reader.GetOrdinal("average_milliseconds");
        }
    }
}
