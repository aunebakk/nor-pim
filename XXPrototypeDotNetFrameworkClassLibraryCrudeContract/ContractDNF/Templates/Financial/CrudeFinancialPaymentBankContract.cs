/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:38:39 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialPaymentBankContract {
        
        [DataMember()]
        public System.Guid FinancialPaymentBankId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string BankName { get; set; } //;
        
        [DataMember()]
        public string BankAccount { get; set; } //;
        
        [DataMember()]
        public string BankNumber { get; set; } //;
        
        [DataMember()]
        public string FinancialBankAccountNumberTypeRcd { get; set; } //;
        
        [DataMember()]
        public decimal Amount { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; } //;
    }
}
