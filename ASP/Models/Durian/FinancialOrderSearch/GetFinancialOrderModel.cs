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
        
        [Display(Name="Image Blob Filename")]
        [Required()]
        public string ImageBlobFilename { get; set; } //;
        
        [Display(Name="Default User Name")]
        [Required()]
        public string DefaultUserName { get; set; } //;
        
        [Display(Name="Financial Currency Type Name")]
        [Required()]
        public string FinancialCurrencyTypeName { get; set; } //;
        
        [Display(Name="Financial Order Source Name")]
        [Required()]
        public string FinancialOrderSourceName { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Comment")]
        [Required()]
        public string Comment { get; set; } //;
        
        [Display(Name="Financial Currency Type")]
        [Required()]
        public string FinancialCurrencyTypeRcd { get; set; } //;
        
        [Display(Name="Financial Currency Against Financial Currency Type")]
        [Required()]
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; } //;
        
        [Display(Name="Financial Currency Type Code")]
        [Required()]
        public string FinancialCurrencyTypeCode { get; set; } //;
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        [Display(Name="Financial Order Source")]
        [Required()]
        public string FinancialOrderSourceRcd { get; set; } //;
        
        [Display(Name="Client Id")]
        [Required()]
        public System.Guid ClientId { get; set; } //;
        
        [Display(Name="Financial Order Id")]
        [Required()]
        public System.Guid FinancialOrderId { get; set; } //;
        
        [Display(Name="Location Address Id")]
        [Required()]
        public System.Guid LocationAddressId { get; set; } //;
    }
}
