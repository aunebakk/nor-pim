/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:49:56 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialOrderTransactionContract {
        
        [DataMember()]
        public System.Guid FinancialBookingTransactionId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public decimal Amount { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialFeeId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialTaxId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialPaymentId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        [DataMember()]
        public int TransactionNumber { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialCostcentreId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialAdjustmentId { get; set; } //;
        
        [DataMember()]
        public string FinancialOrderTransactionTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialOrderId { get; set; } //;
    }
}
