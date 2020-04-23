/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:42:42 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeProductExposeSetContract {
        
        [DataMember()]
        public System.Guid ProductExposeSetId { get; set; } //;
        
        [DataMember()]
        public string ProductExposeSetTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductExposeSetName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
