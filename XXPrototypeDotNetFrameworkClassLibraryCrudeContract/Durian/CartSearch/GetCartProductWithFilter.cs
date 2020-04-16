/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:43:42 PM
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class GetCartProductWithFilterContract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public decimal Amount { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; } //;
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public string DefaultUserName { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public System.Guid CartProductId { get; set; } //;
    }
}
