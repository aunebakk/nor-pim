/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 7:09:55 AM
  From Machine: DESKTOP-9A2DH39
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
