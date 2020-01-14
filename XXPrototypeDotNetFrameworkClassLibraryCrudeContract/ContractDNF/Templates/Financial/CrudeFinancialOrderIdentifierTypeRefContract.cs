/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:42:08 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialOrderIdentifierTypeRefContract {
        
        [DataMember()]
        public string FinancialOrderIdentifierTypeRcd { get; set; } //;
        
        [DataMember()]
        public string FinancialOrderIdentifierTypeCode { get; set; } //;
        
        [DataMember()]
        public string FinancialOrderIdentifierTypeName { get; set; } //;
        
        [DataMember()]
        public int SortSequenceNumber { get; set; } //;
        
        [DataMember()]
        public bool ChangeFlag { get; set; } //;
        
        [DataMember()]
        public string StatusCode { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
