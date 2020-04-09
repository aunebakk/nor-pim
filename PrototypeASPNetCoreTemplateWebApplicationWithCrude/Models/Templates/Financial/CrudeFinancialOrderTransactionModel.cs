/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:54 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeFinancialOrderTransactionModel {
        
        [Display(Name="Financial Booking Transaction Id")]
        [Required()]
        public System.Guid FinancialBookingTransactionId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Amount")]
        [Required()]
        public decimal Amount { get; set; } //;
        
        [Display(Name="Financial Fee Id")]
        [Required()]
        public System.Guid FinancialFeeId { get; set; } //;
        
        [Display(Name="Financial Tax Id")]
        [Required()]
        public System.Guid FinancialTaxId { get; set; } //;
        
        [Display(Name="Financial Payment Id")]
        [Required()]
        public System.Guid FinancialPaymentId { get; set; } //;
        
        [Display(Name="Financial Currency Id")]
        [Required()]
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        [Display(Name="Transaction Number")]
        [Required()]
        public int TransactionNumber { get; set; } //;
        
        [Display(Name="Financial Costcentre Id")]
        [Required()]
        public System.Guid FinancialCostcentreId { get; set; } //;
        
        [Display(Name="Financial Adjustment Id")]
        [Required()]
        public System.Guid FinancialAdjustmentId { get; set; } //;
        
        [Display(Name="Financial Order Transaction Type")]
        [Required()]
        public string FinancialOrderTransactionTypeRcd { get; set; } //;
        
        [Display(Name="Financial Order Id")]
        [Required()]
        public System.Guid FinancialOrderId { get; set; } //;
    }
}
