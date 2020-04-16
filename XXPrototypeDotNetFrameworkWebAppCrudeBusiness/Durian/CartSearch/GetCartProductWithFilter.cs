/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:43:42 PM
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public class GetCartProductWithFilter {
        
        public List<GetCartProductWithFilterContract> GetCartProductWithFilterFromDal(List<GetCartProductWithFilterData> dataList) {
           var list = new List<GetCartProductWithFilterContract>();

           foreach (GetCartProductWithFilterData data in dataList) {
               var contract = new GetCartProductWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(GetCartProductWithFilterData dalGetCartProductWithFilter, GetCartProductWithFilterContract dataContract) {
            dataContract.ProductId = dalGetCartProductWithFilter.ProductId;
            dataContract.ProductName = dalGetCartProductWithFilter.ProductName;
            dataContract.Amount = dalGetCartProductWithFilter.Amount;
            dataContract.FinancialCurrencyId = dalGetCartProductWithFilter.FinancialCurrencyId;
            dataContract.FinancialCurrencyTypeName = dalGetCartProductWithFilter.FinancialCurrencyTypeName;
            dataContract.StateRcd = dalGetCartProductWithFilter.StateRcd;
            dataContract.UserId = dalGetCartProductWithFilter.UserId;
            dataContract.DefaultUserName = dalGetCartProductWithFilter.DefaultUserName;
            dataContract.DateTime = dalGetCartProductWithFilter.DateTime;
            dataContract.CartProductId = dalGetCartProductWithFilter.CartProductId;
        }
    }
}
