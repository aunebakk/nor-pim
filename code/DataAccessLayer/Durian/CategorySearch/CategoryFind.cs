using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CategoryFind {
        
        public string ProductCategoryCode { get; set; } //;
        
        public string ProductName { get; set; } //;
        
        public System.Guid ProductCategoryId { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public void Populate(IDataReader reader, CategoryFindOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductCategoryCode)) ProductCategoryCode = reader.GetString(ordinals.ProductCategoryCode);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.ProductCategoryId)) ProductCategoryId = reader.GetGuid(ordinals.ProductCategoryId);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
        }
    }
    
    public partial class CategoryFindOrdinals {
        
        public int ProductCategoryCode;
        
        public int ProductName;
        
        public int ProductCategoryId;
        
        public int ProductId;
        
        public CategoryFindOrdinals(IDataReader reader) {
            ProductCategoryCode = reader.GetOrdinal("product_category_code");
            ProductName = reader.GetOrdinal("product_name");
            ProductCategoryId = reader.GetOrdinal("product_category_id");
            ProductId = reader.GetOrdinal("product_id");
        }
    }
}
