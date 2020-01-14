/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:16 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialPaymentContract {
        
        [DataMember()]
        public System.Guid FinancialPaymentId { get; set; } //;
        
        [DataMember()]
        public string FinancialPaymentTypeRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialPaymentAccountingId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialPaymentBankId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialPaymentVoucherId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialPaymentCardId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialPaymentCashId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialPaymentCouponId { get; set; } //;
    }
}