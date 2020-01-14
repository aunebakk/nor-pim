/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:56:55 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeClientAddressTypeRefContract {
        
        [DataMember()]
        public string ClientAddressTypeRcd { get; set; } //;
        
        [DataMember()]
        public string ClientAddressTypeName { get; set; } //;
        
        [DataMember()]
        public string ClientAddressTypeDescription { get; set; } //;
        
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
