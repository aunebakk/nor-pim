/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:38:11 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialOrderLineContract {
        
        [DataMember()]
        public System.Guid FinancialOrderLineId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialOrderId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string Comment { get; set; } //;
        
        [DataMember()]
        public int LineNumber { get; set; } //;
        
        [DataMember()]
        public string FinancialUnitOfMeasurementRcd { get; set; } //;
        
        [DataMember()]
        public int QuantityNumber { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; } //;
        
        [DataMember()]
        public decimal Amount { get; set; } //;
    }
}
