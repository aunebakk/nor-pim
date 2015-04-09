using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class ProductStatisticsByMonth {
        
        public string ActivityDate { get; set; } //;
        
        public int DayCount { get; set; } //;
        
        public void Populate(IDataReader reader, ProductStatisticsByMonthOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ActivityDate)) ActivityDate = reader.GetString(ordinals.ActivityDate);
            if (!reader.IsDBNull(ordinals.DayCount)) DayCount = reader.GetInt32(ordinals.DayCount);
        }
    }
    
    public partial class ProductStatisticsByMonthOrdinals {
        
        public int ActivityDate;
        
        public int DayCount;
        
        public ProductStatisticsByMonthOrdinals(IDataReader reader) {
            ActivityDate = reader.GetOrdinal("activity_date");
            DayCount = reader.GetOrdinal("day_count");
        }
    }
}
