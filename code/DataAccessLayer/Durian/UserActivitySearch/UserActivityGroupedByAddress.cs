using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class UserActivityGroupedByAddress {
        
        public string OriginatingAddress { get; set; } //;
        
        public int Occurrences { get; set; } //;
        
        public void Populate(IDataReader reader, UserActivityGroupedByAddressOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.OriginatingAddress)) OriginatingAddress = reader.GetString(ordinals.OriginatingAddress);
            if (!reader.IsDBNull(ordinals.Occurrences)) Occurrences = reader.GetInt32(ordinals.Occurrences);
        }
    }
    
    public partial class UserActivityGroupedByAddressOrdinals {
        
        public int OriginatingAddress;
        
        public int Occurrences;
        
        public UserActivityGroupedByAddressOrdinals(IDataReader reader) {
            OriginatingAddress = reader.GetOrdinal("originating_address");
            Occurrences = reader.GetOrdinal("occurrences");
        }
    }
}
