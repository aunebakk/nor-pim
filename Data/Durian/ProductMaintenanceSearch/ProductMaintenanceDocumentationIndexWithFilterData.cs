/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 7:07:18 AM
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
    public partial class ProductMaintenanceDocumentationIndexWithFilterData {
        
        public string ProductName { get; set; }
        
        public string StateRcd { get; set; }
        
        public string ProductDocumentationTypeName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string ProductDocumentationTypeRcd { get; set; }
        
        public string Documentation { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ProductDocumentationId { get; set; }
        
        public void Populate(IDataReader reader, ProductMaintenanceDocumentationIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.ProductDocumentationTypeName)) ProductDocumentationTypeName = reader.GetString(ordinals.ProductDocumentationTypeName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductDocumentationTypeRcd)) ProductDocumentationTypeRcd = reader.GetString(ordinals.ProductDocumentationTypeRcd);
            if (!reader.IsDBNull(ordinals.Documentation)) Documentation = reader.GetString(ordinals.Documentation);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductDocumentationId)) ProductDocumentationId = reader.GetGuid(ordinals.ProductDocumentationId);
        }
    }
    
    public partial class ProductMaintenanceDocumentationIndexWithFilterDataOrdinals {
        
        public int ProductName;
        
        public int StateRcd;
        
        public int ProductDocumentationTypeName;
        
        public int DefaultUserName;
        
        public int ProductId;
        
        public int ProductDocumentationTypeRcd;
        
        public int Documentation;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductDocumentationId;
        
        public ProductMaintenanceDocumentationIndexWithFilterDataOrdinals(IDataReader reader) {
            ProductName = reader.GetOrdinal("product_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            ProductDocumentationTypeName = reader.GetOrdinal("product_documentation_type_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            ProductId = reader.GetOrdinal("product_id");
            ProductDocumentationTypeRcd = reader.GetOrdinal("product_documentation_type_rcd");
            Documentation = reader.GetOrdinal("documentation");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductDocumentationId = reader.GetOrdinal("product_documentation_id");
        }
    }
}
