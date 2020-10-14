/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 8:42:36 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class CategoryFindData {
        
        public string ProductCategoryCode { get; set; }
        
        public string ProductName { get; set; }
        
        public System.Guid ProductCategoryId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public void Populate(IDataReader reader, CategoryFindDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductCategoryCode)) ProductCategoryCode = reader.GetString(ordinals.ProductCategoryCode);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.ProductCategoryId)) ProductCategoryId = reader.GetGuid(ordinals.ProductCategoryId);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
        }
    }
    
    public partial class CategoryFindDataOrdinals {
        
        public int ProductCategoryCode;
        
        public int ProductName;
        
        public int ProductCategoryId;
        
        public int ProductId;
        
        public CategoryFindDataOrdinals(IDataReader reader) {
            ProductCategoryCode = reader.GetOrdinal("product_category_code");
            ProductName = reader.GetOrdinal("product_name");
            ProductCategoryId = reader.GetOrdinal("product_category_id");
            ProductId = reader.GetOrdinal("product_id");
        }
    }
}
