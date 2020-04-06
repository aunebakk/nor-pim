/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:49:22 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class ProductReferenceAttributeUnitSearchWithFilterContract {
        
        [DataMember()]
        public string ProductAttributeUnitName { get; set; } //;
        
        [DataMember()]
        public string DefaultUserName { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeUnitRcd { get; set; } //;
    }
}
