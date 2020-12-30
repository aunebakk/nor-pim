/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:16:00 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.ContractUsing
*/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in ProductInfo's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    // SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/c9c59f0d-f00d-4489-af20-d8e0e955b8df
    [DataContract()]
    public partial class ProductInfoContract {
        
        // this class is a DataMember for WCF between business and client proxy for parent class ProductInfo
        // data class is serializable in order to speed up processing between the data access and business layers
        // this class start with an identical representation of a ansi sql select statement in ProductInfo's columns
        //  formatted to follow C# casing guidelines ( Pascal casing )
        // links:
        //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a54
        [DataMember()]
        public CrudeProductInfoContract ProductInfo { get; set; }
    }
}
