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
    // this class start with an identical representation of CrudeClient's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  POCO ( Plain old CLR object ): https://en.wikipedia.org/wiki/Plain_old_CLR_object
    //  docLink: http://sql2x.org/documentationLink/ceb39174-f927-4fd8-8396-5ec4d04ea471
    [DataContract()]
    public partial class CrudeClientContract {
        
        [DataMember()]
        public System.Guid ClientId { get; set; }
        
        [DataMember()]
        public string ClientTypeRcd { get; set; }
        
        [DataMember()]
        public string ClientNationalityRcd { get; set; }
        
        [DataMember()]
        public string ClientGenderRcd { get; set; }
        
        [DataMember()]
        public string ClientTitleRcd { get; set; }
        
        [DataMember()]
        public System.Guid ClientAddressId { get; set; }
        
        [DataMember()]
        public string FirstName { get; set; }
        
        [DataMember()]
        public string MiddleName { get; set; }
        
        [DataMember()]
        public string LastName { get; set; }
        
        [DataMember()]
        public byte[] Image { get; set; }
        
        [DataMember()]
        public string ImageBlobFilename { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
