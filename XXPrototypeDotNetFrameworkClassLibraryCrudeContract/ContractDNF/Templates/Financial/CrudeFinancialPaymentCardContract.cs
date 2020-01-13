/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:27:46 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialPaymentCardContract {
        
        [DataMember()]
        public System.Guid FinancialPaymentCardId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string CardNumber { get; set; } //;
        
        [DataMember()]
        public string NameOnCard { get; set; } //;
        
        [DataMember()]
        public int ExpiryYear { get; set; } //;
        
        [DataMember()]
        public int ExpiryMonth { get; set; } //;
        
        [DataMember()]
        public string FinancialCardTypeRcd { get; set; } //;
        
        [DataMember()]
        public int CardVerificationValue { get; set; } //;
        
        [DataMember()]
        public int IssuedMonth { get; set; } //;
        
        [DataMember()]
        public int IssuedYear { get; set; } //;
        
        [DataMember()]
        public string AddressVerificationCode { get; set; } //;
        
        [DataMember()]
        public decimal Amount { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; } //;
    }
}
