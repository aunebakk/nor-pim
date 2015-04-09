using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class UserActivityGrouped {
        
        public string OriginatingAddress { get; set; } //;
        
        public string UserActivityTypeName { get; set; } //;
        
        public string UserActivityNote { get; set; } //;
        
        public int Occurrences { get; set; } //;
        
        public void Populate(IDataReader reader, UserActivityGroupedOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.OriginatingAddress)) OriginatingAddress = reader.GetString(ordinals.OriginatingAddress);
            if (!reader.IsDBNull(ordinals.UserActivityTypeName)) UserActivityTypeName = reader.GetString(ordinals.UserActivityTypeName);
            if (!reader.IsDBNull(ordinals.UserActivityNote)) UserActivityNote = reader.GetString(ordinals.UserActivityNote);
            if (!reader.IsDBNull(ordinals.Occurrences)) Occurrences = reader.GetInt32(ordinals.Occurrences);
        }
    }
    
    public partial class UserActivityGroupedOrdinals {
        
        public int OriginatingAddress;
        
        public int UserActivityTypeName;
        
        public int UserActivityNote;
        
        public int Occurrences;
        
        public UserActivityGroupedOrdinals(IDataReader reader) {
            OriginatingAddress = reader.GetOrdinal("originating_address");
            UserActivityTypeName = reader.GetOrdinal("user_activity_type_name");
            UserActivityNote = reader.GetOrdinal("user_activity_note");
            Occurrences = reader.GetOrdinal("occurrences");
        }
    }
}
