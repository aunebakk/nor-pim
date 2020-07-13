/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:58:59 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CartProductContract {
        
        [DataMember()]
        public List<CrudeCartProductContract> CartProduct { get; set; }
        
        [DataMember()]
        public CrudeCartProductContract CartProductNew { get; set; }
        
        [DataMember()]
        public List<CrudeClientContract> Client { get; set; }
        
        [DataMember()]
        public List<CrudeProductContract> Product { get; set; }
        
        [DataMember()]
        public List<CrudeFinancialCurrencyContract> FinancialCurrency { get; set; }
        
        [DataMember()]
        public int ChecksumAfterGet { get; set; }
        
        // Gets checksum from parent and children
        public int Checksum() {
            // check parent
            int hash = new {
            }.GetHashCode();

              foreach (CrudeCartProductContract cartProduct in CartProduct)
                  hash += new {
                      cartProduct.SessionIdentificator,
                      cartProduct.StateRcd                  
                  }.GetHashCode();

            return hash;
        }
    }
}
