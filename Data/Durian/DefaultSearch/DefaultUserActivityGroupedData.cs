/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 3:48:37 PM
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
    public partial class DefaultUserActivityGroupedData {
        
        public string OriginatingAddress { get; set; }
        
        public string UserActivityTypeName { get; set; }
        
        public string UserActivityNote { get; set; }
        
        public int Occurrences { get; set; }
        
        public void Populate(IDataReader reader, DefaultUserActivityGroupedDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.OriginatingAddress)) OriginatingAddress = reader.GetString(ordinals.OriginatingAddress);
            if (!reader.IsDBNull(ordinals.UserActivityTypeName)) UserActivityTypeName = reader.GetString(ordinals.UserActivityTypeName);
            if (!reader.IsDBNull(ordinals.UserActivityNote)) UserActivityNote = reader.GetString(ordinals.UserActivityNote);
            if (!reader.IsDBNull(ordinals.Occurrences)) Occurrences = reader.GetInt32(ordinals.Occurrences);
        }
    }
    
    public partial class DefaultUserActivityGroupedDataOrdinals {
        
        public int OriginatingAddress;
        
        public int UserActivityTypeName;
        
        public int UserActivityNote;
        
        public int Occurrences;
        
        public DefaultUserActivityGroupedDataOrdinals(IDataReader reader) {
            OriginatingAddress = reader.GetOrdinal("originating_address");
            UserActivityTypeName = reader.GetOrdinal("user_activity_type_name");
            UserActivityNote = reader.GetOrdinal("user_activity_note");
            Occurrences = reader.GetOrdinal("occurrences");
        }
    }
}
