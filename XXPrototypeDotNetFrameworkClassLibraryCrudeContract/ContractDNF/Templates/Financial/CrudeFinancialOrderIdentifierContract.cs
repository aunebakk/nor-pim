/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:33:32 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialOrderIdentifierContract {
        
        [DataMember()]
        public System.Guid FinancialOrderIdentifierId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialOrderId { get; set; } //;
        
        [DataMember()]
        public string FinancialOrderIdentifierTypeRcd { get; set; } //;
        
        [DataMember()]
        public string FinancialOrderIdentifierCode { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
