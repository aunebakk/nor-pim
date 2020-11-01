/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:26:43 PM
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
    public partial class ProductMaintenanceIdentifierIndexWithFilterData {
        
        public string ProductName { get; set; }
        
        public string StateRcd { get; set; }
        
        public string ProductIdentifierName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string ProductIdentifierRcd { get; set; }
        
        public string Identifier { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ProductIdentifierId { get; set; }
        
        public void Populate(IDataReader reader, ProductMaintenanceIdentifierIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.ProductIdentifierName)) ProductIdentifierName = reader.GetString(ordinals.ProductIdentifierName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductIdentifierRcd)) ProductIdentifierRcd = reader.GetString(ordinals.ProductIdentifierRcd);
            if (!reader.IsDBNull(ordinals.Identifier)) Identifier = reader.GetString(ordinals.Identifier);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductIdentifierId)) ProductIdentifierId = reader.GetGuid(ordinals.ProductIdentifierId);
        }
    }
    
    public partial class ProductMaintenanceIdentifierIndexWithFilterDataOrdinals {
        
        public int ProductName;
        
        public int StateRcd;
        
        public int ProductIdentifierName;
        
        public int DefaultUserName;
        
        public int ProductId;
        
        public int ProductIdentifierRcd;
        
        public int Identifier;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductIdentifierId;
        
        public ProductMaintenanceIdentifierIndexWithFilterDataOrdinals(IDataReader reader) {
            ProductName = reader.GetOrdinal("product_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            ProductIdentifierName = reader.GetOrdinal("product_identifier_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            ProductId = reader.GetOrdinal("product_id");
            ProductIdentifierRcd = reader.GetOrdinal("product_identifier_rcd");
            Identifier = reader.GetOrdinal("identifier");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductIdentifierId = reader.GetOrdinal("product_identifier_id");
        }
    }
}
