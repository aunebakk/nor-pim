/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:43:41 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SolutionNorSolutionPim.DataAccessLayer {
    
    
    [Serializable()]
    public partial class GetCartProductWithFilterData {
        
        public System.Guid ProductId { get; set; } //;
        
        public string ProductName { get; set; } //;
        
        public decimal Amount { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public string FinancialCurrencyTypeName { get; set; } //;
        
        public string StateRcd { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public string DefaultUserName { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public System.Guid CartProductId { get; set; } //;
        
        public void Populate(IDataReader reader, GetCartProductWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.Amount)) Amount = reader.GetDecimal(ordinals.Amount);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyId)) FinancialCurrencyId = reader.GetGuid(ordinals.FinancialCurrencyId);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.StateRcd)) StateRcd = reader.GetString(ordinals.StateRcd);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.CartProductId)) CartProductId = reader.GetGuid(ordinals.CartProductId);
        }
    }
    
    public partial class GetCartProductWithFilterDataOrdinals {
        
        public int ProductId;
        
        public int ProductName;
        
        public int Amount;
        
        public int FinancialCurrencyId;
        
        public int FinancialCurrencyTypeName;
        
        public int StateRcd;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int CartProductId;
        
        public GetCartProductWithFilterDataOrdinals(IDataReader reader) {
            ProductId = reader.GetOrdinal("product_id");
            ProductName = reader.GetOrdinal("product_name");
            Amount = reader.GetOrdinal("amount");
            FinancialCurrencyId = reader.GetOrdinal("financial_currency_id");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            StateRcd = reader.GetOrdinal("state_rcd");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            CartProductId = reader.GetOrdinal("cart_product_id");
        }
    }
}
