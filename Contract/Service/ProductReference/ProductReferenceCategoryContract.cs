/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:56:49 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductReferenceCategoryContract {
        
        [DataMember()]
        public List<CrudeProductCategoryContract> ProductCategory { get; set; }
        
        [DataMember()]
        public CrudeProductCategoryContract ProductCategoryNew { get; set; }
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; }
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductCategoryContract productCategory in ProductCategory)
                  hash += new {
                      productCategory.ProductCategoryCode,
                      productCategory.ProductCategoryName,
                      productCategory.StateRcd                  
                  }.GetHashCode();

            return hash;
        }
    }
}
