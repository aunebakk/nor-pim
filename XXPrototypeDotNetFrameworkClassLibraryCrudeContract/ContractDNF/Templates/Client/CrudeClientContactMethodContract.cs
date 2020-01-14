/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:17:46 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeClientContactMethodContract {
        
        [DataMember()]
        public System.Guid ClientContactMethodId { get; set; } //;
        
        [DataMember()]
        public System.Guid ClientId { get; set; } //;
        
        [DataMember()]
        public string ClientContactMethodRcd { get; set; } //;
        
        [DataMember()]
        public string ContactMethodWay { get; set; } //;
        
        [DataMember()]
        public string Comment { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
