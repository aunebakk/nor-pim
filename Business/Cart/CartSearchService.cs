/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:04:03 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System.Collections.Generic;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface ICartSearchService {

        [OperationContract()]
        List<GetCartProductWithFilterContract> GetCartProductWithFilter();
    }

    public partial class CartSearchService : ICartSearchService {

        public virtual List<GetCartProductWithFilterContract> GetCartProductWithFilter() {
            DataAccessLayer.CartSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.CartSearch();
            GetCartProductWithFilter businessLogicLayer = new GetCartProductWithFilter();
            return businessLogicLayer.GetCartProductWithFilterFromDal(dataAccessLayer.GetCartProductWithFilter());
        }
    }
}
