/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:15:36 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateByServiceTableCrudGenerator.ContractUsing
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in 's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    // SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/879e25f6-a7dc-48a3-8a47-549046832bb1
    [DataContract()]
    public partial class CartProductContract {
        
        // this class is a DataMember for WCF between business and client proxy for parent class CartProduct
        // data class is serializable in order to speed up processing between the data access and business layers
        // this class start with an identical representation of a ansi sql select statement in 's columns
        //  formatted to follow C# casing guidelines ( Pascal casing )
        // links:
        //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
        //  docLink: http://sql2x.org/documentationLink/0b48790a-4ff4-48dc-8ecc-51049c93b7df
        [DataMember()]
        public List<CrudeCartProductContract> CartProduct { get; set; }
        
        // this class is a DataMember for WCF between business and client proxy for parent class CartProduct
        // data class is serializable in order to speed up processing between the data access and business layers
        // this class start with an identical representation of a ansi sql select statement in 's columns
        //  formatted to follow C# casing guidelines ( Pascal casing )
        // links:
        //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
        //  docLink: http://sql2x.org/documentationLink/8b9d29e8-371f-4ae9-9ed2-f04ae029ce4b
        [DataMember()]
        public CrudeCartProductContract CartProductNew { get; set; }
        
        // this class is a DataMember for WCF between business and client proxy for parent class CartProduct
        // data class is serializable in order to speed up processing between the data access and business layers
        // this class start with an identical representation of a ansi sql select statement in 's columns
        //  formatted to follow C# casing guidelines ( Pascal casing )
        // links:
        //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
        //  docLink: http://sql2x.org/documentationLink/06b838a9-6237-474b-9cca-f9583b1e4223
        [DataMember()]
        public List<CrudeClientContract> Client { get; set; }
        
        // this class is a DataMember for WCF between business and client proxy for parent class CartProduct
        // data class is serializable in order to speed up processing between the data access and business layers
        // this class start with an identical representation of a ansi sql select statement in 's columns
        //  formatted to follow C# casing guidelines ( Pascal casing )
        // links:
        //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
        //  docLink: http://sql2x.org/documentationLink/06b838a9-6237-474b-9cca-f9583b1e4223
        [DataMember()]
        public List<CrudeProductContract> Product { get; set; }
        
        // this class is a DataMember for WCF between business and client proxy for parent class CartProduct
        // data class is serializable in order to speed up processing between the data access and business layers
        // this class start with an identical representation of a ansi sql select statement in 's columns
        //  formatted to follow C# casing guidelines ( Pascal casing )
        // links:
        //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
        //  docLink: http://sql2x.org/documentationLink/06b838a9-6237-474b-9cca-f9583b1e4223
        [DataMember()]
        public List<CrudeFinancialCurrencyContract> FinancialCurrency { get; set; }
        
        // this member holds a checksum for the objects members
        // it is used to make sure the data has not been changed while modified
        // links:
        //  isolation: https://en.wikipedia.org/wiki/Isolation_(database_systems)
        //  docLink: http://sql2x.org/documentationLink/534ca384-e70b-443d-8a19-3210cfe58f64
        [DataMember()]
        public int ChecksumAfterGet { get; set; }
        
        // this method calculates a checksum for the objects parent and children
        // it is used to make sure the data has not been changed while modified
        // links:
        //  isolation: https://en.wikipedia.org/wiki/Isolation_(database_systems)
        //  docLink: http://sql2x.org/documentationLink/a7c89d10-e938-4fb6-a1e6-2f2b5fdb8bf8
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
