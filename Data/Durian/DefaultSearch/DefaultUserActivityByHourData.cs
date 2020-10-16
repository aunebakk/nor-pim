/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 9:43:30 AM
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
    public partial class DefaultUserActivityByHourData {
        
        public string HourNumber { get; set; }
        
        public int HourCount { get; set; }
        
        public void Populate(IDataReader reader, DefaultUserActivityByHourDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.HourNumber)) HourNumber = reader.GetString(ordinals.HourNumber);
            if (!reader.IsDBNull(ordinals.HourCount)) HourCount = reader.GetInt32(ordinals.HourCount);
        }
    }
    
    public partial class DefaultUserActivityByHourDataOrdinals {
        
        public int HourNumber;
        
        public int HourCount;
        
        public DefaultUserActivityByHourDataOrdinals(IDataReader reader) {
            HourNumber = reader.GetOrdinal("hour_number");
            HourCount = reader.GetOrdinal("hour_count");
        }
    }
}
