/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:29 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialPaymentCardModel {
        
        [Display(Name="Financial Payment Card Id")]
        [Required()]
        public System.Guid FinancialPaymentCardId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Card Number")]
        [Required()]
        public string CardNumber { get; set; } //;
        
        [Display(Name="Name On Card")]
        [Required()]
        public string NameOnCard { get; set; } //;
        
        [Display(Name="Expiry Year")]
        [Required()]
        public int ExpiryYear { get; set; } //;
        
        [Display(Name="Expiry Month")]
        [Required()]
        public int ExpiryMonth { get; set; } //;
        
        [Display(Name="Financial Card Type")]
        [Required()]
        public string FinancialCardTypeRcd { get; set; } //;
        
        [Display(Name="Card Verification Value")]
        [Required()]
        public int CardVerificationValue { get; set; } //;
        
        [Display(Name="Issued Month")]
        [Required()]
        public int IssuedMonth { get; set; } //;
        
        [Display(Name="Issued Year")]
        [Required()]
        public int IssuedYear { get; set; } //;
        
        [Display(Name="Address Verification Code")]
        [Required()]
        public string AddressVerificationCode { get; set; } //;
        
        [Display(Name="Amount")]
        [Required()]
        public decimal Amount { get; set; } //;
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; } //;
    }
}
