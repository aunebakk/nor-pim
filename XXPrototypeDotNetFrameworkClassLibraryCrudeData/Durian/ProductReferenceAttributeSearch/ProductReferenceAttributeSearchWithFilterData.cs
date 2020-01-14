/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:36:41 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class ProductReferenceAttributeSearchWithFilterData {
        
        public string ProductAttributeName { get; set; } //;
        
        public string DefaultUserName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string ProductAttributeRcd { get; set; } //;
        
        public void Populate(IDataReader reader, ProductReferenceAttributeSearchWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductAttributeName)) ProductAttributeName = reader.GetString(ordinals.ProductAttributeName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductAttributeRcd)) ProductAttributeRcd = reader.GetString(ordinals.ProductAttributeRcd);
        }
    }
    
    public partial class ProductReferenceAttributeSearchWithFilterDataOrdinals {
        
        public int ProductAttributeName;
        
        public int DefaultUserName;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductAttributeRcd;
        
        public ProductReferenceAttributeSearchWithFilterDataOrdinals(IDataReader reader) {
            ProductAttributeName = reader.GetOrdinal("product_attribute_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductAttributeRcd = reader.GetOrdinal("product_attribute_rcd");
        }
    }
}
