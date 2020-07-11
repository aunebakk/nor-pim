/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/11/2020 11:34:42 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class CategoryTreeData {
        
        public System.Guid ProductCategoryId { get; set; }
        
        public System.Guid ProductCategoryParentId { get; set; }
        
        public string ProductCategoryCode { get; set; }
        
        public string ProductCategoryName { get; set; }
        
        public void Populate(IDataReader reader, CategoryTreeDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductCategoryId)) ProductCategoryId = reader.GetGuid(ordinals.ProductCategoryId);
            if (!reader.IsDBNull(ordinals.ProductCategoryParentId)) ProductCategoryParentId = reader.GetGuid(ordinals.ProductCategoryParentId);
            if (!reader.IsDBNull(ordinals.ProductCategoryCode)) ProductCategoryCode = reader.GetString(ordinals.ProductCategoryCode);
            if (!reader.IsDBNull(ordinals.ProductCategoryName)) ProductCategoryName = reader.GetString(ordinals.ProductCategoryName);
        }
    }
    
    public partial class CategoryTreeDataOrdinals {
        
        public int ProductCategoryId;
        
        public int ProductCategoryParentId;
        
        public int ProductCategoryCode;
        
        public int ProductCategoryName;
        
        public CategoryTreeDataOrdinals(IDataReader reader) {
            ProductCategoryId = reader.GetOrdinal("product_category_id");
            ProductCategoryParentId = reader.GetOrdinal("product_category_parent_id");
            ProductCategoryCode = reader.GetOrdinal("product_category_code");
            ProductCategoryName = reader.GetOrdinal("product_category_name");
        }
    }
}
