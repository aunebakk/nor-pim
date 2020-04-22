/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:37:58 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialPaymentVoucherModel {
        
        [Display(Name="Financial Payment Voucher Id")]
        [Required()]
        public System.Guid FinancialPaymentVoucherId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Financial Voucher Id")]
        [Required()]
        public System.Guid FinancialVoucherId { get; set; } //;
        
        [Display(Name="Amount")]
        [Required()]
        public decimal Amount { get; set; } //;
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; } //;
    }
}
