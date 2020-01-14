/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:29:04 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialPaymentBankModel {
        
        [Display(Name="Financial Payment Bank Id")]
        [Required()]
        public System.Guid FinancialPaymentBankId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Bank Name")]
        [Required()]
        public string BankName { get; set; } //;
        
        [Display(Name="Bank Account")]
        [Required()]
        public string BankAccount { get; set; } //;
        
        [Display(Name="Bank Number")]
        [Required()]
        public string BankNumber { get; set; } //;
        
        [Display(Name="Financial Bank Account Number Type")]
        [Required()]
        public string FinancialBankAccountNumberTypeRcd { get; set; } //;
        
        [Display(Name="Amount")]
        [Required()]
        public decimal Amount { get; set; } //;
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; } //;
    }
}
