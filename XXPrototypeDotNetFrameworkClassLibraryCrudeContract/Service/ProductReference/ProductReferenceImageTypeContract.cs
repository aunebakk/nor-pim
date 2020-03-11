/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 2:00:32 PM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class ProductReferenceImageTypeContract {
        
        [DataMember()]
        public List<CrudeProductImageTypeRefContract> ProductImageTypeRef { get; set; } //;
        
        [DataMember()]
        public CrudeProductImageTypeRefContract ProductImageTypeRefNew { get; set; } //;
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; } //;
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductImageTypeRefContract productImageTypeRef in ProductImageTypeRef)
                  hash += new {
                      productImageTypeRef.ProductImageTypeRcd,
                      productImageTypeRef.ProductImageTypeName                  
                  }.GetHashCode();

            return hash;
        }
    }
}
