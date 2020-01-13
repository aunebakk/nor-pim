/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:27:40 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialCurrencyTypeRefContract {
        
        [DataMember()]
        public string FinancialCurrencyTypeRcd { get; set; } //;
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public int DecimalCount { get; set; } //;
        
        [DataMember()]
        public string FinancialCurrencyTypeCode { get; set; } //;
    }
}
