/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:47:28 PM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetCore
*/
using System.Data;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class GetFinancialOrderData {
        
        public string FirstName { get; set; } //;
        
        public string MiddleName { get; set; } //;
        
        public string LastName { get; set; } //;
        
        public string ImageBlobFilename { get; set; } //;
        
        public string DefaultUserName { get; set; } //;
        
        public string FinancialCurrencyTypeName { get; set; } //;
        
        public string FinancialOrderSourceName { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public string Comment { get; set; } //;
        
        public string FinancialCurrencyTypeRcd { get; set; } //;
        
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; } //;
        
        public string FinancialCurrencyTypeCode { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public string FinancialOrderSourceRcd { get; set; } //;
        
        public System.Guid ClientId { get; set; } //;
        
        public System.Guid FinancialOrderId { get; set; } //;
        
        public System.Guid LocationAddressId { get; set; } //;
        
        public void Populate(IDataReader reader, GetFinancialOrderDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FirstName)) FirstName = reader.GetString(ordinals.FirstName);
            if (!reader.IsDBNull(ordinals.MiddleName)) MiddleName = reader.GetString(ordinals.MiddleName);
            if (!reader.IsDBNull(ordinals.LastName)) LastName = reader.GetString(ordinals.LastName);
            if (!reader.IsDBNull(ordinals.ImageBlobFilename)) ImageBlobFilename = reader.GetString(ordinals.ImageBlobFilename);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.FinancialOrderSourceName)) FinancialOrderSourceName = reader.GetString(ordinals.FinancialOrderSourceName);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.Comment)) Comment = reader.GetString(ordinals.Comment);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeRcd)) FinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyAgainstFinancialCurrencyTypeRcd)) FinancialCurrencyAgainstFinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyAgainstFinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeCode)) FinancialCurrencyTypeCode = reader.GetString(ordinals.FinancialCurrencyTypeCode);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyId)) FinancialCurrencyId = reader.GetGuid(ordinals.FinancialCurrencyId);
            if (!reader.IsDBNull(ordinals.FinancialOrderSourceRcd)) FinancialOrderSourceRcd = reader.GetString(ordinals.FinancialOrderSourceRcd);
            if (!reader.IsDBNull(ordinals.ClientId)) ClientId = reader.GetGuid(ordinals.ClientId);
            if (!reader.IsDBNull(ordinals.FinancialOrderId)) FinancialOrderId = reader.GetGuid(ordinals.FinancialOrderId);
            if (!reader.IsDBNull(ordinals.LocationAddressId)) LocationAddressId = reader.GetGuid(ordinals.LocationAddressId);
        }
    }
    
    public partial class GetFinancialOrderDataOrdinals {
        
        public int FirstName;
        
        public int MiddleName;
        
        public int LastName;
        
        public int ImageBlobFilename;
        
        public int DefaultUserName;
        
        public int FinancialCurrencyTypeName;
        
        public int FinancialOrderSourceName;
        
        public int UserId;
        
        public int DateTime;
        
        public int Comment;
        
        public int FinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyTypeCode;
        
        public int FinancialCurrencyId;
        
        public int FinancialOrderSourceRcd;
        
        public int ClientId;
        
        public int FinancialOrderId;
        
        public int LocationAddressId;
        
        public GetFinancialOrderDataOrdinals(IDataReader reader) {
            FirstName = reader.GetOrdinal("first_name");
            MiddleName = reader.GetOrdinal("middle_name");
            LastName = reader.GetOrdinal("last_name");
            ImageBlobFilename = reader.GetOrdinal("image_blob_filename");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            FinancialOrderSourceName = reader.GetOrdinal("financial_order_source_name");
            UserId = reader.GetOrdinal("user_id");
            DateTime = reader.GetOrdinal("date_time");
            Comment = reader.GetOrdinal("comment");
            FinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_type_rcd");
            FinancialCurrencyAgainstFinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_against_financial_currency_type_rcd");
            FinancialCurrencyTypeCode = reader.GetOrdinal("financial_currency_type_code");
            FinancialCurrencyId = reader.GetOrdinal("financial_currency_id");
            FinancialOrderSourceRcd = reader.GetOrdinal("financial_order_source_rcd");
            ClientId = reader.GetOrdinal("client_id");
            FinancialOrderId = reader.GetOrdinal("financial_order_id");
            LocationAddressId = reader.GetOrdinal("location_address_id");
        }
    }
}
