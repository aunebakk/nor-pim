/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/25/2020 9:24:18 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class CategoryFindContract {
        
        [DataMember()]
        public string ProductCategoryCode { get; set; }
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
    }
}
