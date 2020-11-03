/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 1:34:31 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class ProductSearchByCategoryType1Data {
        
        public System.Guid ProductId { get; set; }
        
        public string ProductName { get; set; }
        
        public string Gtin13 { get; set; }
        
        public string Color { get; set; }
        
        public void Populate(IDataReader reader, ProductSearchByCategoryType1DataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.Gtin13)) Gtin13 = reader.GetString(ordinals.Gtin13);
            if (!reader.IsDBNull(ordinals.Color)) Color = reader.GetString(ordinals.Color);
        }
    }
    
    public partial class ProductSearchByCategoryType1DataOrdinals {
        
        public int ProductId;
        
        public int ProductName;
        
        public int Gtin13;
        
        public int Color;
        
        public ProductSearchByCategoryType1DataOrdinals(IDataReader reader) {
            ProductId = reader.GetOrdinal("product_id");
            ProductName = reader.GetOrdinal("product_name");
            Gtin13 = reader.GetOrdinal("gtin13");
            Color = reader.GetOrdinal("color");
        }
    }
}
