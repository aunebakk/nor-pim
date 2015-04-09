using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class ProductStatisticsTop5 {
        
        public string Measurement { get; set; } //;
        
        public string Value { get; set; } //;
        
        public void Populate(IDataReader reader, ProductStatisticsTop5Ordinals ordinals) {
            if (!reader.IsDBNull(ordinals.Measurement)) Measurement = reader.GetString(ordinals.Measurement);
            if (!reader.IsDBNull(ordinals.Value)) Value = reader.GetString(ordinals.Value);
        }
    }
    
    public partial class ProductStatisticsTop5Ordinals {
        
        public int Measurement;
        
        public int Value;
        
        public ProductStatisticsTop5Ordinals(IDataReader reader) {
            Measurement = reader.GetOrdinal("measurement");
            Value = reader.GetOrdinal("value");
        }
    }
}
