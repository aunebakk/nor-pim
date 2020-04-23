/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 12:02:57 PM
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class ProductSearchByCategoryType4Contract {
        
        [DataMember()]
        public string Hn { get; set; } //;
        
        [DataMember()]
        public string ProductName { get; set; } //;
        
        [DataMember()]
        public string Gtin13 { get; set; } //;
        
        [DataMember()]
        public string SupplierName { get; set; } //;
        
        [DataMember()]
        public System.Guid ProductId { get; set; } //;
    }
}
