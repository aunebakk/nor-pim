/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/7/2020 10:54:50 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace SolutionNorSolutionPim.BusinessLogicLayer {


    [ServiceContract()]
    public partial interface IFinancialOrderSearchService {
        [OperationContract()]
        List<GetFinancialOrderContract> GetFinancialOrder(Guid clientId, Guid financialCurrencyId, Guid locationAddressId, string financialOrderSourceRcd, Guid userId, Guid financialOrderId);
    }

    public partial class FinancialOrderSearchService : IFinancialOrderSearchService {
        public List<GetFinancialOrderContract> GetFinancialOrder(Guid clientId, Guid financialCurrencyId, Guid locationAddressId, string financialOrderSourceRcd, Guid userId, Guid financialOrderId) {
            DataAccessLayer.FinancialOrderSearch dataAccessLayer = new SolutionNorSolutionPim.DataAccessLayer.FinancialOrderSearch();
            GetFinancialOrder businessLogicLayer = new GetFinancialOrder();
            return businessLogicLayer.GetFinancialOrderFromDal(dataAccessLayer.GetFinancialOrder(clientId, financialCurrencyId, locationAddressId, financialOrderSourceRcd, userId, financialOrderId));
        }
    }
}
