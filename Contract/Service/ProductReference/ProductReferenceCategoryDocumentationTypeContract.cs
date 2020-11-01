/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:22:10 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductReferenceCategoryDocumentationTypeContract {
        
        [DataMember()]
        public List<CrudeProductCategoryDocumentationTypeRefContract> ProductCategoryDocumentationTypeRef { get; set; }
        
        [DataMember()]
        public CrudeProductCategoryDocumentationTypeRefContract ProductCategoryDocumentationTypeRefNew { get; set; }
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; }
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductCategoryDocumentationTypeRefContract productCategoryDocumentationTypeRef in ProductCategoryDocumentationTypeRef)
                  hash += new {
                      productCategoryDocumentationTypeRef.ProductCategoryDocumentationTypeRcd,
                      productCategoryDocumentationTypeRef.ProductCategoryDocumentationTypeName                  
                  }.GetHashCode();

            return hash;
        }
    }
}
