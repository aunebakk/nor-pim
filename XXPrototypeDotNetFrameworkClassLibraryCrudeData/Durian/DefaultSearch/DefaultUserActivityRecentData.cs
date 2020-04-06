/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:47:19 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class DefaultUserActivityRecentData {
        
        public System.DateTime DateTime { get; set; } //;
        
        public string UserActivityTypeName { get; set; } //;
        
        public string OriginatingAddress { get; set; } //;
        
        public string Referrer { get; set; } //;
        
        public string UserActivityNote { get; set; } //;
        
        public void Populate(IDataReader reader, DefaultUserActivityRecentDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.UserActivityTypeName)) UserActivityTypeName = reader.GetString(ordinals.UserActivityTypeName);
            if (!reader.IsDBNull(ordinals.OriginatingAddress)) OriginatingAddress = reader.GetString(ordinals.OriginatingAddress);
            if (!reader.IsDBNull(ordinals.Referrer)) Referrer = reader.GetString(ordinals.Referrer);
            if (!reader.IsDBNull(ordinals.UserActivityNote)) UserActivityNote = reader.GetString(ordinals.UserActivityNote);
        }
    }
    
    public partial class DefaultUserActivityRecentDataOrdinals {
        
        public int DateTime;
        
        public int UserActivityTypeName;
        
        public int OriginatingAddress;
        
        public int Referrer;
        
        public int UserActivityNote;
        
        public DefaultUserActivityRecentDataOrdinals(IDataReader reader) {
            DateTime = reader.GetOrdinal("date_time");
            UserActivityTypeName = reader.GetOrdinal("user_activity_type_name");
            OriginatingAddress = reader.GetOrdinal("originating_address");
            Referrer = reader.GetOrdinal("referrer");
            UserActivityNote = reader.GetOrdinal("user_activity_note");
        }
    }
}
