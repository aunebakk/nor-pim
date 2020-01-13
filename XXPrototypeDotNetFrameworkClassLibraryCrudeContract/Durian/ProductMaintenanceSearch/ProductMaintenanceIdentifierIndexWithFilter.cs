/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:56:51 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class ProductMaintenanceIdentifierIndexWithFilterContract {
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public string ProductIdentifierName { get; set; } //;
        
        [DataMember()]
        public string DefaultUserName { get; set; } //;
        
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
        
        [DataMember()]
        public System.Guid ProductIdentifierId { get; set; } //;
    }
}
