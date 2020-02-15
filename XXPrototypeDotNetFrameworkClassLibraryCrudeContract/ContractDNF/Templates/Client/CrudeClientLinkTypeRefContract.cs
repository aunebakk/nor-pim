/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:38:06 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeClientLinkTypeRefContract {
        
        [DataMember()]
        public string ClientLinkTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ClientLinkTypeName { get; set; } //;
        
        [DataMember()]
        public string ClientLinkTypeDescription { get; set; } //;
        
        [DataMember()]
        public bool ActiveFlag { get; set; } //;
        
        [DataMember()]
        public int SortOrder { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
