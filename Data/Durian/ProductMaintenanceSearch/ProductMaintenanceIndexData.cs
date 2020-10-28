/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 9:31:40 PM
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
    public partial class ProductMaintenanceIndexData {
        
        public string ProductName { get; set; }
        
        public string StateRcd { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public void Populate(IDataReader reader, ProductMaintenanceIndexDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
        }
    }
    
    public partial class ProductMaintenanceIndexDataOrdinals {
        
        public int ProductName;
        
        public int StateRcd;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductId;
        
        public int DefaultUserName;
        
        public ProductMaintenanceIndexDataOrdinals(IDataReader reader) {
            ProductName = reader.GetOrdinal("product_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductId = reader.GetOrdinal("product_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
        }
    }
}
