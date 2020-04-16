using System.ComponentModel.DataAnnotations;

namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class GetCartProductModel {
        
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
        
        [Display(Name="Product Name")]
        [Required()]
        public string ProductName { get; set; } //;
        
        [Display(Name="Product State")]
        [Required()]
        public string ProductStateRcd { get; set; } //;
        
        [Display(Name="Product Id")]
        [Required()]
        public System.Guid ProductId { get; set; } //;
        
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
        
        [Display(Name="Amount")]
        [Required()]
        public decimal Amount { get; set; } //;
        
        [Display(Name="Cart Product State")]
        [Required()]
        public string CartProductStateRcd { get; set; } //;
        
        [Display(Name="Image Blob Filename")]
        [Required()]
        public string ImageBlobFilename { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Default User Name")]
        [Required()]
        public string DefaultUserName { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Cart Product Id")]
        [Required()]
        public System.Guid CartProductId { get; set; } //;
    }
}
