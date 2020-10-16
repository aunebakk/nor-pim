/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:00:32 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System.Collections.Generic;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface IClientSearchService {

        [OperationContract()]
        List<GetClientWithFilterContract> GetClientWithFilter(string lastName, string clientTypeRcd);
    }

    public partial class ClientSearchService : IClientSearchService {

        public virtual List<GetClientWithFilterContract> GetClientWithFilter(string lastName, string clientTypeRcd) {
            DataAccessLayer.ClientSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.ClientSearch();
            GetClientWithFilter businessLogicLayer = new GetClientWithFilter();
            return businessLogicLayer.GetClientWithFilterFromDal(dataAccessLayer.GetClientWithFilter(lastName, clientTypeRcd));
        }
    }
}
