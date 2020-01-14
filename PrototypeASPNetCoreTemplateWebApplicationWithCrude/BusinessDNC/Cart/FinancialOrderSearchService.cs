/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 17.03.2018 17:06:09
  Template: sql2x.DotNetCoreGenerateBusinessLogicLayer.DefaultUsing
*/

using System.Collections.Generic;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public partial class FinancialOrderSearchService
    {
        public List<GetFinancialOrderModel> GetFinancialOrder(System.Guid userId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId, System.Guid financialOrderId, System.Guid locationAddressId)
        {
            var dataAccessLayer = new SolutionNorSolutionPim.BusinessLogicLayer.FinancialOrderSearch();
            var businessLogicLayer = new GetFinancialOrder();
            return businessLogicLayer.GetFinancialOrderFromDal(dataAccessLayer.GetFinancialOrder(userId, financialCurrencyId, financialOrderSourceRcd, clientId, financialOrderId, locationAddressId));
        }
    }
}
