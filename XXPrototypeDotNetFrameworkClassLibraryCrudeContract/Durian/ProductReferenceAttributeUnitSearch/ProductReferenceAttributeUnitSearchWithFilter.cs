/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 12:04:02 PM
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class ProductReferenceAttributeUnitSearchWithFilterContract {
        
        [DataMember()]
        public string ProductAttributeUnitName { get; set; } //;
        
        [DataMember()]
        public string ProductAttributeUnitRcd { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
