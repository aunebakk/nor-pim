/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 4:00:48 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductReferenceDocumentationTypeContract {
        
        [DataMember()]
        public List<CrudeProductDocumentationTypeRefContract> ProductDocumentationTypeRef { get; set; }
        
        [DataMember()]
        public CrudeProductDocumentationTypeRefContract ProductDocumentationTypeRefNew { get; set; }
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; }
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductDocumentationTypeRefContract productDocumentationTypeRef in ProductDocumentationTypeRef)
                  hash += new {
                      productDocumentationTypeRef.ProductDocumentationTypeRcd,
                      productDocumentationTypeRef.ProductDocumentationTypeName                  
                  }.GetHashCode();

            return hash;
        }
    }
}
