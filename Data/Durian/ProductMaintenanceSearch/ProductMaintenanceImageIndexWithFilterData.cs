/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:34:38 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class ProductMaintenanceImageIndexWithFilterData {
        
        public string ProductName { get; set; }
        
        public string StateRcd { get; set; }
        
        public string ProductImageTypeName { get; set; }
        
        public string ImageFileName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string ProductImageTypeRcd { get; set; }
        
        public byte[] Image { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ProductImageId { get; set; }
        
        public void Populate(IDataReader reader, ProductMaintenanceImageIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.ProductImageTypeName)) ProductImageTypeName = reader.GetString(ordinals.ProductImageTypeName);
            if (!reader.IsDBNull(ordinals.ImageFileName)) ImageFileName = reader.GetString(ordinals.ImageFileName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductImageTypeRcd)) ProductImageTypeRcd = reader.GetString(ordinals.ProductImageTypeRcd);
            if (!reader.IsDBNull(ordinals.Image)) Image = (System.Byte[]) reader[ordinals.Image];
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductImageId)) ProductImageId = reader.GetGuid(ordinals.ProductImageId);
        }
    }
    
    public partial class ProductMaintenanceImageIndexWithFilterDataOrdinals {
        
        public int ProductName;
        
        public int StateRcd;
        
        public int ProductImageTypeName;
        
        public int ImageFileName;
        
        public int DefaultUserName;
        
        public int ProductId;
        
        public int ProductImageTypeRcd;
        
        public int Image;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductImageId;
        
        public ProductMaintenanceImageIndexWithFilterDataOrdinals(IDataReader reader) {
            ProductName = reader.GetOrdinal("product_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            ProductImageTypeName = reader.GetOrdinal("product_image_type_name");
            ImageFileName = reader.GetOrdinal("image_file_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            ProductId = reader.GetOrdinal("product_id");
            ProductImageTypeRcd = reader.GetOrdinal("product_image_type_rcd");
            Image = reader.GetOrdinal("image");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductImageId = reader.GetOrdinal("product_image_id");
        }
    }
}
