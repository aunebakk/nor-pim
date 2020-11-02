/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 8:36:37 PM
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
    public partial class GetCartProductWithFilterData {
        
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        public string LastName { get; set; }
        
        public string ProductName { get; set; }
        
        public string ImageBlobFilename { get; set; }
        
        public string ProductStateRcd { get; set; }
        
        public string FinancialCurrencyTypeName { get; set; }
        
        public string DefaultUserName { get; set; }
        
        public System.Guid ClientId { get; set; }
        
        public System.Guid ProductId { get; set; }
        
        public string FinancialCurrencyTypeRcd { get; set; }
        
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; }
        
        public string FinancialCurrencyTypeCode { get; set; }
        
        public System.Guid FinancialCurrencyId { get; set; }
        
        public decimal Amount { get; set; }
        
        public string SessionIdentificator { get; set; }
        
        public string CartProductStateRcd { get; set; }
        
        public System.Guid UserId { get; set; }
        
        public System.DateTime DateTime { get; set; }
        
        public System.Guid CartProductId { get; set; }
        
        public System.Guid SessionId { get; set; }
        
        public System.Guid AspId { get; set; }
        
        public void Populate(IDataReader reader, GetCartProductWithFilterDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FirstName)) FirstName = reader.GetString(ordinals.FirstName);
            if (!reader.IsDBNull(ordinals.MiddleName)) MiddleName = reader.GetString(ordinals.MiddleName);
            if (!reader.IsDBNull(ordinals.LastName)) LastName = reader.GetString(ordinals.LastName);
            if (!reader.IsDBNull(ordinals.ProductName)) ProductName = reader.GetString(ordinals.ProductName);
            if (!reader.IsDBNull(ordinals.ImageBlobFilename)) ImageBlobFilename = reader.GetString(ordinals.ImageBlobFilename);
            if (!reader.IsDBNull(ordinals.ProductStateRcd)) ProductStateRcd = reader.GetString(ordinals.ProductStateRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.ClientId)) ClientId = reader.GetGuid(ordinals.ClientId);
            if (!reader.IsDBNull(ordinals.ProductId)) ProductId = reader.GetGuid(ordinals.ProductId);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeRcd)) FinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyAgainstFinancialCurrencyTypeRcd)) FinancialCurrencyAgainstFinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyAgainstFinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeCode)) FinancialCurrencyTypeCode = reader.GetString(ordinals.FinancialCurrencyTypeCode);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyId)) FinancialCurrencyId = reader.GetGuid(ordinals.FinancialCurrencyId);
            if (!reader.IsDBNull(ordinals.Amount)) Amount = reader.GetDecimal(ordinals.Amount);
            if (!reader.IsDBNull(ordinals.SessionIdentificator)) SessionIdentificator = reader.GetString(ordinals.SessionIdentificator);
            if (!reader.IsDBNull(ordinals.CartProductStateRcd)) CartProductStateRcd = reader.GetString(ordinals.CartProductStateRcd);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.CartProductId)) CartProductId = reader.GetGuid(ordinals.CartProductId);
            if (!reader.IsDBNull(ordinals.SessionId)) SessionId = reader.GetGuid(ordinals.SessionId);
            if (!reader.IsDBNull(ordinals.AspId)) AspId = reader.GetGuid(ordinals.AspId);
        }
    }
    
    public partial class GetCartProductWithFilterDataOrdinals {
        
        public int FirstName;
        
        public int MiddleName;
        
        public int LastName;
        
        public int ProductName;
        
        public int ImageBlobFilename;
        
        public int ProductStateRcd;
        
        public int FinancialCurrencyTypeName;
        
        public int DefaultUserName;
        
        public int ClientId;
        
        public int ProductId;
        
        public int FinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyTypeCode;
        
        public int FinancialCurrencyId;
        
        public int Amount;
        
        public int SessionIdentificator;
        
        public int CartProductStateRcd;
        
        public int UserId;
        
        public int DateTime;
        
        public int CartProductId;
        
        public int SessionId;
        
        public int AspId;
        
        public GetCartProductWithFilterDataOrdinals(IDataReader reader) {
            FirstName = reader.GetOrdinal("first_name");
            MiddleName = reader.GetOrdinal("middle_name");
            LastName = reader.GetOrdinal("last_name");
            ProductName = reader.GetOrdinal("product_name");
            ImageBlobFilename = reader.GetOrdinal("image_blob_filename");
            ProductStateRcd = reader.GetOrdinal("product_state_rcd");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            ClientId = reader.GetOrdinal("client_id");
            ProductId = reader.GetOrdinal("product_id");
            FinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_type_rcd");
            FinancialCurrencyAgainstFinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_against_financial_currency_type_rcd");
            FinancialCurrencyTypeCode = reader.GetOrdinal("financial_currency_type_code");
            FinancialCurrencyId = reader.GetOrdinal("financial_currency_id");
            Amount = reader.GetOrdinal("amount");
            SessionIdentificator = reader.GetOrdinal("session_identificator");
            CartProductStateRcd = reader.GetOrdinal("cart_product_state_rcd");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            CartProductId = reader.GetOrdinal("cart_product_id");
            SessionId = reader.GetOrdinal("session_id");
            AspId = reader.GetOrdinal("asp_id");
        }
    }
}
