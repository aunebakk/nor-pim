using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Transactions;
using System.Configuration;

namespace norpim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class CategoryTree {
        
        public System.Guid ProductCategoryId { get; set; } //;
        
        public System.Guid ProductCategoryParentId { get; set; } //;
        
        public string ProductCategoryCode { get; set; } //;
        
        public string ProductCategoryName { get; set; } //;
        
        public void Populate(IDataReader reader, CategoryTreeOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductCategoryId)) ProductCategoryId = reader.GetGuid(ordinals.ProductCategoryId);
            if (!reader.IsDBNull(ordinals.ProductCategoryParentId)) ProductCategoryParentId = reader.GetGuid(ordinals.ProductCategoryParentId);
            if (!reader.IsDBNull(ordinals.ProductCategoryCode)) ProductCategoryCode = reader.GetString(ordinals.ProductCategoryCode);
            if (!reader.IsDBNull(ordinals.ProductCategoryName)) ProductCategoryName = reader.GetString(ordinals.ProductCategoryName);
        }
    }
    
    public partial class CategoryTreeOrdinals {
        
        public int ProductCategoryId;
        
        public int ProductCategoryParentId;
        
        public int ProductCategoryCode;
        
        public int ProductCategoryName;
        
        public CategoryTreeOrdinals(IDataReader reader) {
            ProductCategoryId = reader.GetOrdinal("product_category_id");
            ProductCategoryParentId = reader.GetOrdinal("product_category_parent_id");
            ProductCategoryCode = reader.GetOrdinal("product_category_code");
            ProductCategoryName = reader.GetOrdinal("product_category_name");
        }
    }
}
