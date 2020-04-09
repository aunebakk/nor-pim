/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:46:17 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class ProductMaintenanceDocumentationIndexWithFilterContract {
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public string ProductDocumentationTypeName { get; set; } //;
        
        [DataMember()]
        public string DefaultUserName { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
        
        [DataMember()]
        public string ProductDocumentationTypeRcd { get; set; } //;
        
        [DataMember()]
        public string Documentation { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductDocumentationId { get; set; } //;
    }
}
