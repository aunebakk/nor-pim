/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 10:00:28 AM
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
    public partial class ProductHistoryData {
        
        public System.Guid ProductId { get; set; }
        
        public string ProductName { get; set; }
        
        public string StateName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public string UserName { get; set; }
        
        public System.Guid ProductBecameId { get; set; }
        
        public void Populate(IDataReader reader, ProductHistoryDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.StateName)) StateName = reader.GetString(ordinals.StateName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.UserName)) UserName = reader.GetString(ordinals.UserName);
            if (!reader.IsDBNull(ordinals.ProductBecameId)) ProductBecameId = reader.GetGuid(ordinals.ProductBecameId);
        }
    }
    
    public partial class ProductHistoryDataOrdinals {
        
        public int ProductId;
        
        public int ProductName;
        
        public int StateName;
        
        public int DateTime;
        
        public int UserName;
        
        public int ProductBecameId;
        
        public ProductHistoryDataOrdinals(IDataReader reader) {
            ProductId = reader.GetOrdinal("product_id");
            ProductName = reader.GetOrdinal("product_name");
            StateName = reader.GetOrdinal("state_name");
            DateTime = reader.GetOrdinal("date_time");
            UserName = reader.GetOrdinal("user_name");
            ProductBecameId = reader.GetOrdinal("product_became_id");
        }
    }
}
