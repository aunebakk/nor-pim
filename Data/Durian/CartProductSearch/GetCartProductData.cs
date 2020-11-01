/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:24:15 PM
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
    public partial class GetCartProductData {
        
        public System.Guid ClientId { get; set; }
        
        public string ProductName { get; set; }
        
        public string ProductStateRcd { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string FinancialCurrencyTypeRcd { get; set; }
        
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; }
        
        public string FinancialCurrencyTypeCode { get; set; }
        
        public string FinancialCurrencyTypeName { get; set; }
        
        public System.Guid FinancialCurrencyId { get; set; }
        
        public decimal Amount { get; set; }
        
        public string CartProductStateRcd { get; set; }
        
        public string ImageBlobFilename { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid CartProductId { get; set; }
        
        public string SessionIdentificator { get; set; }
        
        public void Populate(IDataReader reader, GetCartProductDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.ClientId)) ClientId = reader.GetGuid(ordinals.ClientId);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.ProductStateRcd)) ProductStateRcd = reader.GetString(ordinals.ProductStateRcd);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeRcd)) FinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyAgainstFinancialCurrencyTypeRcd)) FinancialCurrencyAgainstFinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyAgainstFinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeCode)) FinancialCurrencyTypeCode = reader.GetString(ordinals.FinancialCurrencyTypeCode);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyId)) FinancialCurrencyId = reader.GetGuid(ordinals.FinancialCurrencyId);
            if (!reader.IsDBNull(ordinals.Amount)) Amount = reader.GetDecimal(ordinals.Amount);
            if (!reader.IsDBNull(ordinals.CartProductStateRcd)) CartProductStateRcd = reader.GetString(ordinals.CartProductStateRcd);
            if (!reader.IsDBNull(ordinals.ImageBlobFilename)) ImageBlobFilename = reader.GetString(ordinals.ImageBlobFilename);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.CartProductId)) CartProductId = reader.GetGuid(ordinals.CartProductId);
            if (!reader.IsDBNull(ordinals.SessionIdentificator)) SessionIdentificator = reader.GetString(ordinals.SessionIdentificator);
        }
    }
    
    public partial class GetCartProductDataOrdinals {
        
        public int ClientId;
        
        public int ProductName;
        
        public int ProductStateRcd;
        
        public int ProductId;
        
        public int FinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyTypeCode;
        
        public int FinancialCurrencyTypeName;
        
        public int FinancialCurrencyId;
        
        public int Amount;
        
        public int CartProductStateRcd;
        
        public int ImageBlobFilename;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int CartProductId;
        
        public int SessionIdentificator;
        
        public GetCartProductDataOrdinals(IDataReader reader) {
            ClientId = reader.GetOrdinal("client_id");
            ProductName = reader.GetOrdinal("product_name");
            ProductStateRcd = reader.GetOrdinal("product_state_rcd");
            ProductId = reader.GetOrdinal("product_id");
            FinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_type_rcd");
            FinancialCurrencyAgainstFinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_against_financial_currency_type_rcd");
            FinancialCurrencyTypeCode = reader.GetOrdinal("financial_currency_type_code");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            FinancialCurrencyId = reader.GetOrdinal("financial_currency_id");
            Amount = reader.GetOrdinal("amount");
            CartProductStateRcd = reader.GetOrdinal("cart_product_state_rcd");
            ImageBlobFilename = reader.GetOrdinal("image_blob_filename");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            CartProductId = reader.GetOrdinal("cart_product_id");
            SessionIdentificator = reader.GetOrdinal("session_identificator");
        }
    }
}
