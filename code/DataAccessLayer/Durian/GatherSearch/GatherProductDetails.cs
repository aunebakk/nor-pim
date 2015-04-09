using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class GatherProductDetails {
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductGatherKeyValue { get; set; } //;
        
        public string ProductName { get; set; } //;
        
        public string ProductCategoryName { get; set; } //;
        
        public string ProductUserName { get; set; } //;
        
        public System.DateTime ProductDateTime { get; set; } //;
        
        public string ProductStateName { get; set; } //;
        
        public void Populate(IDataReader reader, GatherProductDetailsOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductGatherKeyValue)) ProductGatherKeyValue = reader.GetString(ordinals.ProductGatherKeyValue);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.ProductCategoryName)) ProductCategoryName = reader.GetString(ordinals.ProductCategoryName);
            if (!reader.IsDBNull(ordinals.ProductUserName)) ProductUserName = reader.GetString(ordinals.ProductUserName);
            if (!reader.IsDBNull(ordinals.ProductDateTime)) ProductDateTime = reader.GetDateTime(ordinals.ProductDateTime);
            if (!reader.IsDBNull(ordinals.ProductStateName)) ProductStateName = reader.GetString(ordinals.ProductStateName);
        }
    }
    
    public partial class GatherProductDetailsOrdinals {
        
        public int ProductId;
        
        public int ProductGatherKeyValue;
        
        public int ProductName;
        
        public int ProductCategoryName;
        
        public int ProductUserName;
        
        public int ProductDateTime;
        
        public int ProductStateName;
        
        public GatherProductDetailsOrdinals(IDataReader reader) {
            ProductId = reader.GetOrdinal("product_id");
            ProductGatherKeyValue = reader.GetOrdinal("product_gather_key_value");
            ProductName = reader.GetOrdinal("product_name");
            ProductCategoryName = reader.GetOrdinal("product_category_name");
            ProductUserName = reader.GetOrdinal("product_user_name");
            ProductDateTime = reader.GetOrdinal("product_date_time");
            ProductStateName = reader.GetOrdinal("product_state_name");
        }
    }
}
