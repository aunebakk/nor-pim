/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 12:03:29 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  business logic layer: https://en.wikipedia.org/wiki/Business_logic
// application programming interface: https://en.wikipedia.org/wiki/API
//  docLink: http://sql2x.org/documentationLink/89dc5b67-2bf9-4c88-8911-c3b6294c3a64
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class serves as a data access contract between c# and sql server
    // this class start with an identical representation of CrudeClientDocument's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    //  docLink: http://sql2x.org/documentationLink/ceb39174-f927-4fd8-8396-5ec4d04ea471
    [DataContract()]
    public partial class CrudeClientDocumentContract {
        
        [DataMember()]
        public System.Guid ClientDocumentId { get; set; }
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
        
        [DataMember()]
        public string ClientDocumentTypeRcd { get; set; }
        
        [DataMember()]
        public string DocumentName { get; set; }
        
        [DataMember()]
        public System.DateTime DocumentDateTime { get; set; }
        
        [DataMember()]
        public System.DateTime ExpiryDateTime { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
