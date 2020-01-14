/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:23:51 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeProductIdentifierContract {
        
        [DataMember()]
        public System.Guid ProductIdentifierId { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductIdentifierRcd { get; set; } //;
        
        [DataMember()]
        public string Identifier { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
