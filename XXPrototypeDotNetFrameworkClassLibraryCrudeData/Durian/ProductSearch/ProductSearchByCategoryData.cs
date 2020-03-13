/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:52:56 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class ProductSearchByCategoryData {
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductName { get; set; } //;
        
        public string Identifier { get; set; } //;
        
        public string Value { get; set; } //;
        
        public string ProductInfoValue { get; set; } //;
        
        public string ProductImageTypeRcd { get; set; } //;
        
        public string ProductImageTypeName { get; set; } //;
        
        public byte[] Image { get; set; } //;
        
        public void Populate(IDataReader reader, ProductSearchByCategoryDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.Identifier)) Identifier = reader.GetString(ordinals.Identifier);
            if (!reader.IsDBNull(ordinals.Value)) Value = reader.GetString(ordinals.Value);
            if (!reader.IsDBNull(ordinals.ProductInfoValue)) ProductInfoValue = reader.GetString(ordinals.ProductInfoValue);
            if (!reader.IsDBNull(ordinals.ProductImageTypeRcd)) ProductImageTypeRcd = reader.GetString(ordinals.ProductImageTypeRcd);
            if (!reader.IsDBNull(ordinals.ProductImageTypeName)) ProductImageTypeName = reader.GetString(ordinals.ProductImageTypeName);
            if (!reader.IsDBNull(ordinals.Image)) Image = (System.Byte[]) reader[ordinals.Image];
        }
    }
    
    public partial class ProductSearchByCategoryDataOrdinals {
        
        public int ProductId;
        
        public int ProductName;
        
        public int Identifier;
        
        public int Value;
        
        public int ProductInfoValue;
        
        public int ProductImageTypeRcd;
        
        public int ProductImageTypeName;
        
        public int Image;
        
        public ProductSearchByCategoryDataOrdinals(IDataReader reader) {
            ProductId = reader.GetOrdinal("product_id");
            ProductName = reader.GetOrdinal("product_name");
            Identifier = reader.GetOrdinal("identifier");
            Value = reader.GetOrdinal("value");
            ProductInfoValue = reader.GetOrdinal("product_info_value");
            ProductImageTypeRcd = reader.GetOrdinal("product_image_type_rcd");
            ProductImageTypeName = reader.GetOrdinal("product_image_type_name");
            Image = reader.GetOrdinal("image");
        }
    }
}
