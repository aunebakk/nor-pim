/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:45:42 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/c8b78807-5be0-4da9-89f2-2d7f8dac1c12
    [ServiceContract()]
    public partial interface IClientSearchService {
        
        // returns a list of GetClientWithFilter contracts from ClientSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/cdd86da0-630c-402b-b72a-8dabf924530d
        // parameters:
        //  lastName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  clientTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [OperationContract()]
        List<GetClientWithFilterContract> GetClientWithFilter(string lastName, string clientTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a Contract
    // links:
    //  docLink: http://sql2x.org/documentationLink/0b3269e5-2c52-47e6-a294-51407ea7c523
    public partial class ClientSearchService : IClientSearchService {
        
        // returns a list of GetClientWithFilter contracts from ClientSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/0b582d9b-64df-473e-9f42-7ce7701e67f0
        // parameters:
        //  lastName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  clientTypeRcd: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public virtual List<GetClientWithFilterContract> GetClientWithFilter(string lastName, string clientTypeRcd) {
            // transfer all GetClientWithFilter serialized objects from ClientSearch as GetClientWithFilter contracts
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ClientSearch();
            var businessLogicLayer = new GetClientWithFilter();
            return businessLogicLayer.GetClientWithFilterFromDal(dataAccessLayer.GetClientWithFilter(lastName, clientTypeRcd));
        }
    }
}
