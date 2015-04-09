using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class ExposeProductDetails {
        
        public System.Guid ExposeProductId { get; set; } //;
        
        public string ProductName { get; set; } //;
        
        public string ProductCategoryName { get; set; } //;
        
        public string ProductUserName { get; set; } //;
        
        public System.DateTime ProductDateTime { get; set; } //;
        
        public string ProductStateName { get; set; } //;
        
        public void Populate(IDataReader reader, ExposeProductDetailsOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ExposeProductId)) ExposeProductId = reader.GetGuid(ordinals.ExposeProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.ProductCategoryName)) ProductCategoryName = reader.GetString(ordinals.ProductCategoryName);
            if (!reader.IsDBNull(ordinals.ProductUserName)) ProductUserName = reader.GetString(ordinals.ProductUserName);
            if (!reader.IsDBNull(ordinals.ProductDateTime)) ProductDateTime = reader.GetDateTime(ordinals.ProductDateTime);
            if (!reader.IsDBNull(ordinals.ProductStateName)) ProductStateName = reader.GetString(ordinals.ProductStateName);
        }
    }
    
    public partial class ExposeProductDetailsOrdinals {
        
        public int ExposeProductId;
        
        public int ProductName;
        
        public int ProductCategoryName;
        
        public int ProductUserName;
        
        public int ProductDateTime;
        
        public int ProductStateName;
        
        public ExposeProductDetailsOrdinals(IDataReader reader) {
            ExposeProductId = reader.GetOrdinal("expose_product_id");
            ProductName = reader.GetOrdinal("product_name");
            ProductCategoryName = reader.GetOrdinal("product_category_name");
            ProductUserName = reader.GetOrdinal("product_user_name");
            ProductDateTime = reader.GetOrdinal("product_date_time");
            ProductStateName = reader.GetOrdinal("product_state_name");
        }
    }
}
