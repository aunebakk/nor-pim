/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:25:22 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialUnitOfMeasurementRefContract {
        
        [DataMember()]
        public string FinancialUnitOfMeasurementRcd { get; set; } //;
        
        [DataMember()]
        public int SortSequenceNumber { get; set; } //;
        
        [DataMember()]
        public bool ChangeFlag { get; set; } //;
        
        [DataMember()]
        public string StatusCode { get; set; } //;
        
        [DataMember()]
        public string FinancialUnitOfMeasurementName { get; set; } //;
        
        [DataMember()]
        public string FinancialUnitOfMeasurementCode { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
