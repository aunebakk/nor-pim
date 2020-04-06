/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:48:53 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class ProductMaintenanceAttributeIndexWithFilterContract {
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeName { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeUnitName { get; set; } //;
        
        [DataMember()]
        public string DefaultUserName { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeRcd { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeUnitRcd { get; set; } //;
        
        [DataMember()]
        public string Value { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductAttributeId { get; set; } //;
    }
}
