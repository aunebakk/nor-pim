/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:46:57 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.BusinessLogicLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface IClientSearchService {
        
        [OperationContract()]
        List<GetClientWithFilterContract> GetClientWithFilter(string lastName, string clientTypeRcd);
    }
    
    public partial class ClientSearchService : IClientSearchService {
        
        public virtual List<GetClientWithFilterContract> GetClientWithFilter(string lastName, string clientTypeRcd) {
            var dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ClientSearch();
            var businessLogicLayer = new GetClientWithFilter();
            return businessLogicLayer.GetClientWithFilterFromDal(dataAccessLayer.GetClientWithFilter(lastName, clientTypeRcd));
        }
    }
}
