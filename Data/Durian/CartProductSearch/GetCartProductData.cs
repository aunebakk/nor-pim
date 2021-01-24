/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:45:08 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetFramework
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

// Data Access Layer
// the DataAccessLayer is the first layer that has access to data coming from
//  sql server after being streamed over a net or internal process
// links:
//  docLink: http://sql2x.org/documentationLink/42e5ad27-4aa5-4a5b-a42d-59f1659fcdf6
namespace SolutionNorSolutionPim.DataAccessLayer {

    // this class serves as a data access layer between c# and sql server
    // it is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in GetCartProductData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/d360d55c-efab-4b5b-99be-9425d91ebd59
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
        
        // use ordinals to speed up access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/327451c3-64a8-4de8-b359-76742d634497
        // parameters:
        //  reader: IDataReader from SQLClient
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
    
    // this class holds ordinals used to data access the DataReader between c# and sql server
    // this class start with an identical representation of the method in GetCartProductData's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )  with a number indicating the columns position in the original ansi sql select statement
    // links:
    //  docLink: http://sql2x.org/documentationLink/0d935f44-0309-4dca-a8f2-a4e8eafd2201
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
        
        // get ordinals in order to speed up subsequent access to DataReader
        // links:
        //  docLink: http://sql2x.org/documentationLink/41a04ed0-5ed8-4d0e-bb90-ccfbfd219e82
        // parameters:
        //  reader: IDataReader from SQLClient
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
