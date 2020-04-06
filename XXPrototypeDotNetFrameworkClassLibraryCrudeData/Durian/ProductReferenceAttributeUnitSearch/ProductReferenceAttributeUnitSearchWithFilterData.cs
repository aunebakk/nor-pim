/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:53:13 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class ProductReferenceAttributeUnitSearchWithFilterData {
        
        public string ProductAttributeUnitName { get; set; } //;
        
        public string DefaultUserName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string ProductAttributeUnitRcd { get; set; } //;
        
        public void Populate(IDataReader reader, ProductReferenceAttributeUnitSearchWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductAttributeUnitName)) ProductAttributeUnitName = reader.GetString(ordinals.ProductAttributeUnitName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductAttributeUnitRcd)) ProductAttributeUnitRcd = reader.GetString(ordinals.ProductAttributeUnitRcd);
        }
    }
    
    public partial class ProductReferenceAttributeUnitSearchWithFilterDataOrdinals {
        
        public int ProductAttributeUnitName;
        
        public int DefaultUserName;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductAttributeUnitRcd;
        
        public ProductReferenceAttributeUnitSearchWithFilterDataOrdinals(IDataReader reader) {
            ProductAttributeUnitName = reader.GetOrdinal("product_attribute_unit_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductAttributeUnitRcd = reader.GetOrdinal("product_attribute_unit_rcd");
        }
    }
}
