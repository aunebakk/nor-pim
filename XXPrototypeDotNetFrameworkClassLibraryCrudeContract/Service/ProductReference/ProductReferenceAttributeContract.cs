/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:30:44 PM
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class ProductReferenceAttributeContract {
        
        [DataMember()]
        public List<CrudeProductAttributeRefContract> ProductAttributeRef { get; set; } //;
        
        [DataMember()]
        public CrudeProductAttributeRefContract ProductAttributeRefNew { get; set; } //;
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; } //;
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductAttributeRefContract productAttributeRef in ProductAttributeRef)
                  hash += new {
                      productAttributeRef.ProductAttributeRcd,
                      productAttributeRef.ProductAttributeName                  
                  }.GetHashCode();

            return hash;
        }
    }
}