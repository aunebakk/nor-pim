using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class GatherOverview {
        
        public System.Guid ProductGatherId { get; set; } //;
        
        public System.DateTime StartDateTime { get; set; } //;
        
        public System.DateTime FinishDateTime { get; set; } //;
        
        public string ProductGatherSourceTypeRcd { get; set; } //;
        
        public string ProductGatherSourceTypeName { get; set; } //;
        
        public int KeyCount { get; set; } //;
        
        public string UserName { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public void Populate(IDataReader reader, GatherOverviewOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductGatherId)) ProductGatherId = reader.GetGuid(ordinals.ProductGatherId);
            if (!reader.IsDBNull(ordinals.StartDateTime)) StartDateTime = reader.GetDateTime(ordinals.StartDateTime);
            if (!reader.IsDBNull(ordinals.FinishDateTime)) FinishDateTime = reader.GetDateTime(ordinals.FinishDateTime);
            if (!reader.IsDBNull(ordinals.ProductGatherSourceTypeRcd)) ProductGatherSourceTypeRcd = reader.GetString(ordinals.ProductGatherSourceTypeRcd);
            if (!reader.IsDBNull(ordinals.ProductGatherSourceTypeName)) ProductGatherSourceTypeName = reader.GetString(ordinals.ProductGatherSourceTypeName);
            if (!reader.IsDBNull(ordinals.KeyCount)) KeyCount = reader.GetInt32(ordinals.KeyCount);
            if (!reader.IsDBNull(ordinals.UserName)) UserName = reader.GetString(ordinals.UserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
        }
    }
    
    public partial class GatherOverviewOrdinals {
        
        public int ProductGatherId;
        
        public int StartDateTime;
        
        public int FinishDateTime;
        
        public int ProductGatherSourceTypeRcd;
        
        public int ProductGatherSourceTypeName;
        
        public int KeyCount;
        
        public int UserName;
        
        public int DateTime;
        
        public GatherOverviewOrdinals(IDataReader reader) {
            ProductGatherId = reader.GetOrdinal("product_gather_id");
            StartDateTime = reader.GetOrdinal("start_date_time");
            FinishDateTime = reader.GetOrdinal("finish_date_time");
            ProductGatherSourceTypeRcd = reader.GetOrdinal("product_gather_source_type_rcd");
            ProductGatherSourceTypeName = reader.GetOrdinal("product_gather_source_type_name");
            KeyCount = reader.GetOrdinal("key_count");
            UserName = reader.GetOrdinal("user_name");
            DateTime = reader.GetOrdinal("date_time");
        }
    }
}
