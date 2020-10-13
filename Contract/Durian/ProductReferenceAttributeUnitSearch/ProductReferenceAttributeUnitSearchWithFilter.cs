/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 2:26:51 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class ProductReferenceAttributeUnitSearchWithFilterContract {
        
        [DataMember()]
        public string ProductAttributeUnitName { get; set; }
        
        [DataMember()]
        public string ProductAttributeUnitRcd { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
