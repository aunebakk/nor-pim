/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:36:04 AM
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
    public partial class DefaultPerformanceTimesData {
        
        public System.DateTime DateTime { get; set; }
        
        public int Milliseconds { get; set; }
        
        public void Populate(IDataReader reader, DefaultPerformanceTimesDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.Milliseconds)) Milliseconds = reader.GetInt32(ordinals.Milliseconds);
        }
    }
    
    public partial class DefaultPerformanceTimesDataOrdinals {
        
        public int DateTime;
        
        public int Milliseconds;
        
        public DefaultPerformanceTimesDataOrdinals(IDataReader reader) {
            DateTime = reader.GetOrdinal("date_time");
            Milliseconds = reader.GetOrdinal("milliseconds");
        }
    }
}
