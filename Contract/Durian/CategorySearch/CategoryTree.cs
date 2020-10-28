/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 10:17:41 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class CategoryTreeContract {
        
        [DataMember()]
        public System.Guid ProductCategoryId { get; set; }
        
        [DataMember()]
        public System.Guid ProductCategoryParentId { get; set; }
        
        [DataMember()]
        public string ProductCategoryCode { get; set; }
        
        [DataMember()]
        public string ProductCategoryName { get; set; }
    }
}
