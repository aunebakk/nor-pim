/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 5:07:31 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class GetCartProduct {
        
        public List<GetCartProductContract> GetCartProductFromDal(List<GetCartProductData> dataList) {
           var list = new List<GetCartProductContract>();

           foreach (GetCartProductData data in dataList) {
               var contract = new GetCartProductContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(GetCartProductData dalGetCartProduct, GetCartProductContract dataContract) {
            dataContract.ClientId = dalGetCartProduct.ClientId;
            dataContract.ProductName = dalGetCartProduct.ProductName;
            dataContract.ProductStateRcd = dalGetCartProduct.ProductStateRcd;
            dataContract.ProductId = dalGetCartProduct.ProductId;
            dataContract.FinancialCurrencyTypeRcd = dalGetCartProduct.FinancialCurrencyTypeRcd;
            dataContract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = dalGetCartProduct.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            dataContract.FinancialCurrencyTypeCode = dalGetCartProduct.FinancialCurrencyTypeCode;
            dataContract.FinancialCurrencyTypeName = dalGetCartProduct.FinancialCurrencyTypeName;
            dataContract.FinancialCurrencyId = dalGetCartProduct.FinancialCurrencyId;
            dataContract.Amount = dalGetCartProduct.Amount;
            dataContract.CartProductStateRcd = dalGetCartProduct.CartProductStateRcd;
            dataContract.ImageBlobFilename = dalGetCartProduct.ImageBlobFilename;
            dataContract.UserId = dalGetCartProduct.UserId;
            dataContract.DefaultUserName = dalGetCartProduct.DefaultUserName;
            dataContract.DateTime = dalGetCartProduct.DateTime;
            dataContract.CartProductId = dalGetCartProduct.CartProductId;
            dataContract.SessionIdentificator = dalGetCartProduct.SessionIdentificator;
        }
    }
}
