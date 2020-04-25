/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:14:53 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeFinancialOrderSourceRefContract {
        
        [DataMember()]
        public string FinancialOrderSourceRcd { get; set; } //;
        
        [DataMember()]
        public string FinancialOrderSourceName { get; set; } //;
        
        [DataMember()]
        public string FinancialOrderSourceCode { get; set; } //;
        
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
