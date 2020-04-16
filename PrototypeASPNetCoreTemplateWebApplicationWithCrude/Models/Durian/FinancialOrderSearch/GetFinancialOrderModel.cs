using System.ComponentModel.DataAnnotations;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class GetFinancialOrderModel {
        
        [Display(Name="First Name")]
        [Required()]
        public string FirstName { get; set; } //;
        
        [Display(Name="Middle Name")]
        [Required()]
        public string MiddleName { get; set; } //;
        
        [Display(Name="Last Name")]
        [Required()]
        public string LastName { get; set; } //;
        
        [Display(Name="Client Nationality")]
        [Required()]
        public string ClientNationalityRcd { get; set; } //;
        
        [Display(Name="Client Gender")]
        [Required()]
        public string ClientGenderRcd { get; set; } //;
        
        [Display(Name="Client Title")]
        [Required()]
        public string ClientTitleRcd { get; set; } //;
        
        [Display(Name="Client Type")]
        [Required()]
        public string ClientTypeRcd { get; set; } //;
        
        [Display(Name="Client Id")]
        [Required()]
        public System.Guid ClientId { get; set; } //;
        
        [Display(Name="Financial Currency Type")]
        [Required()]
        public string FinancialCurrencyTypeRcd { get; set; } //;
        
        [Display(Name="Financial Currency Against Financial Currency Type")]
        [Required()]
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; } //;
        
        [Display(Name="Financial Currency Type Code")]
        [Required()]
        public string FinancialCurrencyTypeCode { get; set; } //;
        
        [Display(Name="Financial Currency Type Name")]
        [Required()]
        public string FinancialCurrencyTypeName { get; set; } //;
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        [Display(Name="Location Address Type")]
        [Required()]
        public string LocationAddressTypeRcd { get; set; } //;
        
        [Display(Name="Address One")]
        [Required()]
        public string AddressOne { get; set; } //;
        
        [Display(Name="Address Two")]
        [Required()]
        public string AddressTwo { get; set; } //;
        
        [Display(Name="Address Three")]
        [Required()]
        public string AddressThree { get; set; } //;
        
        [Display(Name="City")]
        [Required()]
        public string City { get; set; } //;
        
        [Display(Name="Street")]
        [Required()]
        public string Street { get; set; } //;
        
        [Display(Name="State")]
        [Required()]
        public string State { get; set; } //;
        
        [Display(Name="District")]
        [Required()]
        public string District { get; set; } //;
        
        [Display(Name="Province")]
        [Required()]
        public string Province { get; set; } //;
        
        [Display(Name="Zip Code")]
        [Required()]
        public string ZipCode { get; set; } //;
        
        [Display(Name="Po Box")]
        [Required()]
        public string PoBox { get; set; } //;
        
        [Display(Name="Location Address Comment")]
        [Required()]
        public string LocationAddressComment { get; set; } //;
        
        [Display(Name="Location Address Id")]
        [Required()]
        public System.Guid LocationAddressId { get; set; } //;
        
        [Display(Name="Financial Order Source")]
        [Required()]
        public string FinancialOrderSourceRcd { get; set; } //;
        
        [Display(Name="Image Blob Filename")]
        [Required()]
        public string ImageBlobFilename { get; set; } //;
        
        [Display(Name="Financial Order Source Name")]
        [Required()]
        public string FinancialOrderSourceName { get; set; } //;
        
        [Display(Name="Comment")]
        [Required()]
        public string Comment { get; set; } //;
        
        [Display(Name="Financial Order Comment")]
        [Required()]
        public string FinancialOrderComment { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Default User Name")]
        [Required()]
        public string DefaultUserName { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Financial Order Id")]
        [Required()]
        public System.Guid FinancialOrderId { get; set; } //;
    }
}
