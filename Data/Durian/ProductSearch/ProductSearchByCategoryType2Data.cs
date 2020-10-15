/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 9:08:26 AM
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
    public partial class ProductSearchByCategoryType2Data {
        
        public System.Guid ProductId { get; set; }
        
        public string ProductName { get; set; }
        
        public string Gtin13 { get; set; }
        
        public string Hn { get; set; }
        
        public string Color { get; set; }
        
        public void Populate(IDataReader reader, ProductSearchByCategoryType2DataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.Gtin13)) Gtin13 = reader.GetString(ordinals.Gtin13);
            if (!reader.IsDBNull(ordinals.Hn)) Hn = reader.GetString(ordinals.Hn);
            if (!reader.IsDBNull(ordinals.Color)) Color = reader.GetString(ordinals.Color);
        }
    }
    
    public partial class ProductSearchByCategoryType2DataOrdinals {
        
        public int ProductId;
        
        public int ProductName;
        
        public int Gtin13;
        
        public int Hn;
        
        public int Color;
        
        public ProductSearchByCategoryType2DataOrdinals(IDataReader reader) {
            ProductId = reader.GetOrdinal("product_id");
            ProductName = reader.GetOrdinal("product_name");
            Gtin13 = reader.GetOrdinal("gtin13");
            Hn = reader.GetOrdinal("hn");
            Color = reader.GetOrdinal("color");
        }
    }
}
