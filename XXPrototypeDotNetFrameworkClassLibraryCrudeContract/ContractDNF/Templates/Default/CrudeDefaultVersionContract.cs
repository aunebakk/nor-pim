/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:25:16 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeDefaultVersionContract {
        
        [DataMember()]
        public System.Guid DefaultVersionId { get; set; } //;
        
        [DataMember()]
        public string FunVersion { get; set; } //;
        
        [DataMember()]
        public string Number { get; set; } //;
        
        [DataMember()]
        public int MajorNumber { get; set; } //;
        
        [DataMember()]
        public int MinorNumber { get; set; } //;
        
        [DataMember()]
        public int SequenceNumber { get; set; } //;
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
