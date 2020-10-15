/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 1:45:12 PM
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
    public partial class ProductSearchByCategoryType4Data {
        
        public string Hn { get; set; }
        
        public string ProductName { get; set; }
        
        public string Gtin13 { get; set; }
        
        public string SupplierName { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public void Populate(IDataReader reader, ProductSearchByCategoryType4DataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.Hn)) Hn = reader.GetString(ordinals.Hn);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.Gtin13)) Gtin13 = reader.GetString(ordinals.Gtin13);
            if (!reader.IsDBNull(ordinals.SupplierName)) SupplierName = reader.GetString(ordinals.SupplierName);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
        }
    }
    
    public partial class ProductSearchByCategoryType4DataOrdinals {
        
        public int Hn;
        
        public int ProductName;
        
        public int Gtin13;
        
        public int SupplierName;
        
        public int ProductId;
        
        public ProductSearchByCategoryType4DataOrdinals(IDataReader reader) {
            Hn = reader.GetOrdinal("hn");
            ProductName = reader.GetOrdinal("product_name");
            Gtin13 = reader.GetOrdinal("gtin13");
            SupplierName = reader.GetOrdinal("supplier_name");
            ProductId = reader.GetOrdinal("product_id");
        }
    }
}
