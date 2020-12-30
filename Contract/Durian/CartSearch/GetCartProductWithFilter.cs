/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:15:36 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in GetCartProductWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  serialization: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    // SOAP ( Simple Object Access Protocol ): https://en.wikipedia.org/wiki/SOAP
    // WCF ( Windows Communication Foundation ): https://en.wikipedia.org/wiki/Windows_Communication_Foundation
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
    [DataContract()]
    public class GetCartProductWithFilterContract {
        
        [DataMember()]
        public string FirstName { get; set; }
        
        [DataMember()]
        public string MiddleName { get; set; }
        
        [DataMember()]
        public string LastName { get; set; }
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeName { get; set; }
        
        [DataMember()]
        public string DefaultUserName { get; set; }
        
        [DataMember()]
        public string ImageBlobFilename { get; set; }
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
        
        [DataMember()]
        public string ProductStateRcd { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeRcd { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyAgainstFinancialCurrencyTypeRcd { get; set; }
        
        [DataMember()]
        public string FinancialCurrencyTypeCode { get; set; }
        
        [DataMember()]
        public System.Guid FinancialCurrencyId { get; set; }
        
        [DataMember()]
        public decimal Amount { get; set; }
        
        [DataMember()]
        public string SessionIdentificator { get; set; }
        
        [DataMember()]
        public string CartProductStateRcd { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid CartProductId { get; set; }
        
        [DataMember()]
        public System.Guid SessionId { get; set; }
        
        [DataMember()]
        public System.Guid AspId { get; set; }
    }
}
