using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class UserActivityRecent {
        
        public System.DateTime DateTime { get; set; } //;
        
        public string UserActivityTypeName { get; set; } //;
        
        public string OriginatingAddress { get; set; } //;
        
        public string UserActivityNote { get; set; } //;
        
        public void Populate(IDataReader reader, UserActivityRecentOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.UserActivityTypeName)) UserActivityTypeName = reader.GetString(ordinals.UserActivityTypeName);
            if (!reader.IsDBNull(ordinals.OriginatingAddress)) OriginatingAddress = reader.GetString(ordinals.OriginatingAddress);
            if (!reader.IsDBNull(ordinals.UserActivityNote)) UserActivityNote = reader.GetString(ordinals.UserActivityNote);
        }
    }
    
    public partial class UserActivityRecentOrdinals {
        
        public int DateTime;
        
        public int UserActivityTypeName;
        
        public int OriginatingAddress;
        
        public int UserActivityNote;
        
        public UserActivityRecentOrdinals(IDataReader reader) {
            DateTime = reader.GetOrdinal("date_time");
            UserActivityTypeName = reader.GetOrdinal("user_activity_type_name");
            OriginatingAddress = reader.GetOrdinal("originating_address");
            UserActivityNote = reader.GetOrdinal("user_activity_note");
        }
    }
}
