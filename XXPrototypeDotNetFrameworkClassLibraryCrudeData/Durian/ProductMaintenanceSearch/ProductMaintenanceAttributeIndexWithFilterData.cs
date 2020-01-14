/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:30:26 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class ProductMaintenanceAttributeIndexWithFilterData {
        
        public string ProductName { get; set; } //;
        
        public string StateRcd { get; set; } //;
        
        public string ProductAttributeName { get; set; } //;
        
        public string ProductAttributeUnitName { get; set; } //;
        
        public string DefaultUserName { get; set; } //;
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductAttributeRcd { get; set; } //;
        
        public string ProductAttributeUnitRcd { get; set; } //;
        
        public string Value { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public System.Guid ProductAttributeId { get; set; } //;
        
        public void Populate(IDataReader reader, ProductMaintenanceAttributeIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.ProductAttributeName)) ProductAttributeName = reader.GetString(ordinals.ProductAttributeName);
            if (!reader.IsDBNull(ordinals.ProductAttributeUnitName)) ProductAttributeUnitName = reader.GetString(ordinals.ProductAttributeUnitName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductAttributeRcd)) ProductAttributeRcd = reader.GetString(ordinals.ProductAttributeRcd);
            if (!reader.IsDBNull(ordinals.ProductAttributeUnitRcd)) ProductAttributeUnitRcd = reader.GetString(ordinals.ProductAttributeUnitRcd);
            if (!reader.IsDBNull(ordinals.Value)) Value = reader.GetString(ordinals.Value);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductAttributeId)) ProductAttributeId = reader.GetGuid(ordinals.ProductAttributeId);
        }
    }
    
    public partial class ProductMaintenanceAttributeIndexWithFilterDataOrdinals {
        
        public int ProductName;
        
        public int StateRcd;
        
        public int ProductAttributeName;
        
        public int ProductAttributeUnitName;
        
        public int DefaultUserName;
        
        public int ProductId;
        
        public int ProductAttributeRcd;
        
        public int ProductAttributeUnitRcd;
        
        public int Value;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductAttributeId;
        
        public ProductMaintenanceAttributeIndexWithFilterDataOrdinals(IDataReader reader) {
            ProductName = reader.GetOrdinal("product_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            ProductAttributeName = reader.GetOrdinal("product_attribute_name");
            ProductAttributeUnitName = reader.GetOrdinal("product_attribute_unit_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            ProductId = reader.GetOrdinal("product_id");
            ProductAttributeRcd = reader.GetOrdinal("product_attribute_rcd");
            ProductAttributeUnitRcd = reader.GetOrdinal("product_attribute_unit_rcd");
            Value = reader.GetOrdinal("value");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductAttributeId = reader.GetOrdinal("product_attribute_id");
        }
    }
}
