/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:34:56 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class DefaultStatisticsTop5Data {
        
        public string Measurement { get; set; } //;
        
        public string Value { get; set; } //;
        
        public void Populate(IDataReader reader, DefaultStatisticsTop5DataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.Measurement)) Measurement = reader.GetString(ordinals.Measurement);
            if (!reader.IsDBNull(ordinals.Value)) Value = reader.GetString(ordinals.Value);
        }
    }
    
    public partial class DefaultStatisticsTop5DataOrdinals {
        
        public int Measurement;
        
        public int Value;
        
        public DefaultStatisticsTop5DataOrdinals(IDataReader reader) {
            Measurement = reader.GetOrdinal("measurement");
            Value = reader.GetOrdinal("value");
        }
    }
}
