/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:46:35 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class ProductReferenceIdentifierContract {
        
        [DataMember()]
        public List<CrudeProductIdentifierContract> ProductIdentifier { get; set; }
        
        [DataMember()]
        public CrudeProductIdentifierContract ProductIdentifierNew { get; set; }
        
        [DataMember()]
        public List<CrudeProductContract> Product { get; set; }
        
        [DataMember()]
        public List<CrudeProductIdentifierRefContract> ProductIdentifierRef { get; set; }
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; }
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeProductIdentifierContract productIdentifier in ProductIdentifier)
                  hash += new {
                      productIdentifier.ProductIdentifierRcd,
                      productIdentifier.Identifier                  
                  }.GetHashCode();

            return hash;
        }
    }
}
