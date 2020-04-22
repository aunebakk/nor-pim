/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 7:01:23 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialPaymentModel {
        
        [Display(Name="Financial Payment Id")]
        [Required()]
        public System.Guid FinancialPaymentId { get; set; } //;
        
        [Display(Name="Financial Payment Type")]
        [Required()]
        public string FinancialPaymentTypeRcd { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Financial Payment Accounting Id")]
        [Required()]
        public System.Guid FinancialPaymentAccountingId { get; set; } //;
        
        [Display(Name="Financial Payment Bank Id")]
        [Required()]
        public System.Guid FinancialPaymentBankId { get; set; } //;
        
        [Display(Name="Financial Payment Voucher Id")]
        [Required()]
        public System.Guid FinancialPaymentVoucherId { get; set; } //;
        
        [Display(Name="Financial Payment Card Id")]
        [Required()]
        public System.Guid FinancialPaymentCardId { get; set; } //;
        
        [Display(Name="Financial Payment Cash Id")]
        [Required()]
        public System.Guid FinancialPaymentCashId { get; set; } //;
        
        [Display(Name="Financial Payment Coupon Id")]
        [Required()]
        public System.Guid FinancialPaymentCouponId { get; set; } //;
    }
}
