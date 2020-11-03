/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:12:40 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class ProductSearchByCategoryCodeContract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public string Identifier { get; set; }
        
        [DataMember()]
        public string Value { get; set; }
        
        [DataMember()]
        public string ProductInfoValue { get; set; }
        
        [DataMember()]
        public string ProductImageTypeRcd { get; set; }
        
        [DataMember()]
        public string ProductImageTypeName { get; set; }
        
        [DataMember()]
        public byte[] Image { get; set; }
    }
}
