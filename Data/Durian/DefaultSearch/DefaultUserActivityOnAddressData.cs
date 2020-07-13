/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 11:01:32 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class DefaultUserActivityOnAddressData {
        
        public System.DateTime DateTime { get; set; }
        
        public string UserActivityTypeName { get; set; }
        
        public string OriginatingAddress { get; set; }
        
        public string UserActivityNote { get; set; }
        
        public void Populate(IDataReader reader, DefaultUserActivityOnAddressDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.UserActivityTypeName)) UserActivityTypeName = reader.GetString(ordinals.UserActivityTypeName);
            if (!reader.IsDBNull(ordinals.OriginatingAddress)) OriginatingAddress = reader.GetString(ordinals.OriginatingAddress);
            if (!reader.IsDBNull(ordinals.UserActivityNote)) UserActivityNote = reader.GetString(ordinals.UserActivityNote);
        }
    }
    
    public partial class DefaultUserActivityOnAddressDataOrdinals {
        
        public int DateTime;
        
        public int UserActivityTypeName;
        
        public int OriginatingAddress;
        
        public int UserActivityNote;
        
        public DefaultUserActivityOnAddressDataOrdinals(IDataReader reader) {
            DateTime = reader.GetOrdinal("date_time");
            UserActivityTypeName = reader.GetOrdinal("user_activity_type_name");
            OriginatingAddress = reader.GetOrdinal("originating_address");
            UserActivityNote = reader.GetOrdinal("user_activity_note");
        }
    }
}
