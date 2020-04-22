/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:32:18 AM
  Template: sql2x.GenerateDataAccessLayerV0.UsingDotNetCore
*/
using System.Data;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class GetFinancialOrderData {
        
        public string FirstName { get; set; } //;
        
        public string MiddleName { get; set; } //;
        
        public string LastName { get; set; } //;
        
        public string ClientNationalityRcd { get; set; } //;
        
        public string ClientGenderRcd { get; set; } //;
        
        public string ClientTitleRcd { get; set; } //;
        
        public string ClientTypeRcd { get; set; } //;
        
        public System.Guid ClientId { get; set; } //;
        
        public string FinancialCurrencyTypeRcd { get; set; } //;
        
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; } //;
        
        public string FinancialCurrencyTypeCode { get; set; } //;
        
        public string FinancialCurrencyTypeName { get; set; } //;
        
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        public string LocationAddressTypeRcd { get; set; } //;
        
        public string AddressOne { get; set; } //;
        
        public string AddressTwo { get; set; } //;
        
        public string AddressThree { get; set; } //;
        
        public string City { get; set; } //;
        
        public string Street { get; set; } //;
        
        public string State { get; set; } //;
        
        public string District { get; set; } //;
        
        public string Province { get; set; } //;
        
        public string ZipCode { get; set; } //;
        
        public string PoBox { get; set; } //;
        
        public string LocationAddressComment { get; set; } //;
        
        public System.Guid LocationAddressId { get; set; } //;
        
        public string FinancialOrderSourceRcd { get; set; } //;
        
        public string ImageBlobFilename { get; set; } //;
        
        public string FinancialOrderSourceName { get; set; } //;
        
        public string Comment { get; set; } //;
        
        public string FinancialOrderComment { get; set; } //;
        
        public System.Guid UserId { get; set; } //;
        
        public string DefaultUserName { get; set; } //;
        
        public System.DateTime DateTime { get; set; } //;
        
        public System.Guid FinancialOrderId { get; set; } //;
        
        public void Populate(IDataReader reader, GetFinancialOrderDataOrdinals ordinals) {
            if (!reader.IsDBNull(ordinals.FirstName)) FirstName = reader.GetString(ordinals.FirstName);
            if (!reader.IsDBNull(ordinals.MiddleName)) MiddleName = reader.GetString(ordinals.MiddleName);
            if (!reader.IsDBNull(ordinals.LastName)) LastName = reader.GetString(ordinals.LastName);
            if (!reader.IsDBNull(ordinals.ClientNationalityRcd)) ClientNationalityRcd = reader.GetString(ordinals.ClientNationalityRcd);
            if (!reader.IsDBNull(ordinals.ClientGenderRcd)) ClientGenderRcd = reader.GetString(ordinals.ClientGenderRcd);
            if (!reader.IsDBNull(ordinals.ClientTitleRcd)) ClientTitleRcd = reader.GetString(ordinals.ClientTitleRcd);
            if (!reader.IsDBNull(ordinals.ClientTypeRcd)) ClientTypeRcd = reader.GetString(ordinals.ClientTypeRcd);
            if (!reader.IsDBNull(ordinals.ClientId)) ClientId = reader.GetGuid(ordinals.ClientId);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeRcd)) FinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyAgainstFinancialCurrencyTypeRcd)) FinancialCurrencyAgainstFinancialCurrencyTypeRcd = reader.GetString(ordinals.FinancialCurrencyAgainstFinancialCurrencyTypeRcd);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeCode)) FinancialCurrencyTypeCode = reader.GetString(ordinals.FinancialCurrencyTypeCode);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyTypeName)) FinancialCurrencyTypeName = reader.GetString(ordinals.FinancialCurrencyTypeName);
            if (!reader.IsDBNull(ordinals.FinancialCurrencyId)) FinancialCurrencyId = reader.GetGuid(ordinals.FinancialCurrencyId);
            if (!reader.IsDBNull(ordinals.LocationAddressTypeRcd)) LocationAddressTypeRcd = reader.GetString(ordinals.LocationAddressTypeRcd);
            if (!reader.IsDBNull(ordinals.AddressOne)) AddressOne = reader.GetString(ordinals.AddressOne);
            if (!reader.IsDBNull(ordinals.AddressTwo)) AddressTwo = reader.GetString(ordinals.AddressTwo);
            if (!reader.IsDBNull(ordinals.AddressThree)) AddressThree = reader.GetString(ordinals.AddressThree);
            if (!reader.IsDBNull(ordinals.City)) City = reader.GetString(ordinals.City);
            if (!reader.IsDBNull(ordinals.Street)) Street = reader.GetString(ordinals.Street);
            if (!reader.IsDBNull(ordinals.State)) State = reader.GetString(ordinals.State);
            if (!reader.IsDBNull(ordinals.District)) District = reader.GetString(ordinals.District);
            if (!reader.IsDBNull(ordinals.Province)) Province = reader.GetString(ordinals.Province);
            if (!reader.IsDBNull(ordinals.ZipCode)) ZipCode = reader.GetString(ordinals.ZipCode);
            if (!reader.IsDBNull(ordinals.PoBox)) PoBox = reader.GetString(ordinals.PoBox);
            if (!reader.IsDBNull(ordinals.LocationAddressComment)) LocationAddressComment = reader.GetString(ordinals.LocationAddressComment);
            if (!reader.IsDBNull(ordinals.LocationAddressId)) LocationAddressId = reader.GetGuid(ordinals.LocationAddressId);
            if (!reader.IsDBNull(ordinals.FinancialOrderSourceRcd)) FinancialOrderSourceRcd = reader.GetString(ordinals.FinancialOrderSourceRcd);
            if (!reader.IsDBNull(ordinals.ImageBlobFilename)) ImageBlobFilename = reader.GetString(ordinals.ImageBlobFilename);
            if (!reader.IsDBNull(ordinals.FinancialOrderSourceName)) FinancialOrderSourceName = reader.GetString(ordinals.FinancialOrderSourceName);
            if (!reader.IsDBNull(ordinals.Comment)) Comment = reader.GetString(ordinals.Comment);
            if (!reader.IsDBNull(ordinals.FinancialOrderComment)) FinancialOrderComment = reader.GetString(ordinals.FinancialOrderComment);
            if (!reader.IsDBNull(ordinals.UserId)) UserId = reader.GetGuid(ordinals.UserId);
            if (!reader.IsDBNull(ordinals.DefaultUserName)) DefaultUserName = reader.GetString(ordinals.DefaultUserName);
            if (!reader.IsDBNull(ordinals.DateTime)) DateTime = reader.GetDateTime(ordinals.DateTime);
            if (!reader.IsDBNull(ordinals.FinancialOrderId)) FinancialOrderId = reader.GetGuid(ordinals.FinancialOrderId);
        }
    }
    
    public partial class GetFinancialOrderDataOrdinals {
        
        public int FirstName;
        
        public int MiddleName;
        
        public int LastName;
        
        public int ClientNationalityRcd;
        
        public int ClientGenderRcd;
        
        public int ClientTitleRcd;
        
        public int ClientTypeRcd;
        
        public int ClientId;
        
        public int FinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
        
        public int FinancialCurrencyTypeCode;
        
        public int FinancialCurrencyTypeName;
        
        public int FinancialCurrencyId;
        
        public int LocationAddressTypeRcd;
        
        public int AddressOne;
        
        public int AddressTwo;
        
        public int AddressThree;
        
        public int City;
        
        public int Street;
        
        public int State;
        
        public int District;
        
        public int Province;
        
        public int ZipCode;
        
        public int PoBox;
        
        public int LocationAddressComment;
        
        public int LocationAddressId;
        
        public int FinancialOrderSourceRcd;
        
        public int ImageBlobFilename;
        
        public int FinancialOrderSourceName;
        
        public int Comment;
        
        public int FinancialOrderComment;
        
        public int UserId;
        
        public int DefaultUserName;
        
        public int DateTime;
        
        public int FinancialOrderId;
        
        public GetFinancialOrderDataOrdinals(IDataReader reader) {
            FirstName = reader.GetOrdinal("first_name");
            MiddleName = reader.GetOrdinal("middle_name");
            LastName = reader.GetOrdinal("last_name");
            ClientNationalityRcd = reader.GetOrdinal("client_nationality_rcd");
            ClientGenderRcd = reader.GetOrdinal("client_gender_rcd");
            ClientTitleRcd = reader.GetOrdinal("client_title_rcd");
            ClientTypeRcd = reader.GetOrdinal("client_type_rcd");
            ClientId = reader.GetOrdinal("client_id");
            FinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_type_rcd");
            FinancialCurrencyAgainstFinancialCurrencyTypeRcd = reader.GetOrdinal("financial_currency_against_financial_currency_type_rcd");
            FinancialCurrencyTypeCode = reader.GetOrdinal("financial_currency_type_code");
            FinancialCurrencyTypeName = reader.GetOrdinal("financial_currency_type_name");
            FinancialCurrencyId = reader.GetOrdinal("financial_currency_id");
            LocationAddressTypeRcd = reader.GetOrdinal("location_address_type_rcd");
            AddressOne = reader.GetOrdinal("address_one");
            AddressTwo = reader.GetOrdinal("address_two");
            AddressThree = reader.GetOrdinal("address_three");
            City = reader.GetOrdinal("city");
            Street = reader.GetOrdinal("street");
            State = reader.GetOrdinal("state");
            District = reader.GetOrdinal("district");
            Province = reader.GetOrdinal("province");
            ZipCode = reader.GetOrdinal("zip_code");
            PoBox = reader.GetOrdinal("po_box");
            LocationAddressComment = reader.GetOrdinal("location_address_comment");
            LocationAddressId = reader.GetOrdinal("location_address_id");
            FinancialOrderSourceRcd = reader.GetOrdinal("financial_order_source_rcd");
            ImageBlobFilename = reader.GetOrdinal("image_blob_filename");
            FinancialOrderSourceName = reader.GetOrdinal("financial_order_source_name");
            Comment = reader.GetOrdinal("comment");
            FinancialOrderComment = reader.GetOrdinal("financial_order_comment");
            UserId = reader.GetOrdinal("user_id");
            DefaultUserName = reader.GetOrdinal("default_user_name");
            DateTime = reader.GetOrdinal("date_time");
            FinancialOrderId = reader.GetOrdinal("financial_order_id");
        }
    }
}
