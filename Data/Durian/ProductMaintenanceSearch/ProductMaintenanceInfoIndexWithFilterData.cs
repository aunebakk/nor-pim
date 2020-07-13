/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 11:03:39 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {

    [Serializable()]
    public partial class ProductMaintenanceInfoIndexWithFilterData {
        
        public string ProductName { get; set; }
        
        public string StateRcd { get; set; }
        
        public string ProductInfoName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string ProductInfoRcd { get; set; }
        
        public string ProductInfoValue { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid ProductInfoId { get; set; }
        
        public void Populate(IDataReader reader, ProductMaintenanceInfoIndexWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.ProductInfoName)) ProductInfoName = reader.GetString(ordinals.ProductInfoName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductInfoRcd)) ProductInfoRcd = reader.GetString(ordinals.ProductInfoRcd);
            if (!reader.IsDBNull(ordinals.ProductInfoValue)) ProductInfoValue = reader.GetString(ordinals.ProductInfoValue);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.ProductInfoId)) ProductInfoId = reader.GetGuid(ordinals.ProductInfoId);
        }
    }
    
    public partial class ProductMaintenanceInfoIndexWithFilterDataOrdinals {
        
        public int ProductName;
        
        public int StateRcd;
        
        public int ProductInfoName;
        
        public int DefaultUserName;
        
        public int ProductId;
        
        public int ProductInfoRcd;
        
        public int ProductInfoValue;
        
        public int UserId;
        
        public int DateTime;
        
        public int ProductInfoId;
        
        public ProductMaintenanceInfoIndexWithFilterDataOrdinals(IDataReader reader) {
            ProductName = reader.GetOrdinal("product_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            ProductInfoName = reader.GetOrdinal("product_info_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            ProductId = reader.GetOrdinal("product_id");
            ProductInfoRcd = reader.GetOrdinal("product_info_rcd");
            ProductInfoValue = reader.GetOrdinal("product_info_value");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            ProductInfoId = reader.GetOrdinal("product_info_id");
        }
    }
}
