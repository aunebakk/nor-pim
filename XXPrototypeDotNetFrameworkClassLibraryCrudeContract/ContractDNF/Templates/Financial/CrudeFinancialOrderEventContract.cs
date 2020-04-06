/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:36:10 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialOrderEventContract {
        
        [DataMember()]
        public System.Guid FiancialOrderEventId { get; set; } //;
        
        [DataMember()]
        public System.Guid FinancialOrderId { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string Comment { get; set; } //;
        
        [DataMember()]
        public string FinancialOrderEventTypeRcd { get; set; } //;
    }
}
