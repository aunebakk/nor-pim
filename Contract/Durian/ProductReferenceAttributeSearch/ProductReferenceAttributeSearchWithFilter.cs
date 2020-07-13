/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 5:03:54 PM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class ProductReferenceAttributeSearchWithFilterContract {
        
        [DataMember()]
        public string ProductAttributeName { get; set; }
        
        [DataMember()]
        public string ProductAttributeRcd { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
