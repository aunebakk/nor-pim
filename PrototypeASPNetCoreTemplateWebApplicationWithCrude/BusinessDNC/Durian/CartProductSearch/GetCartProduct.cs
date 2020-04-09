/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:47:25 PM
  Template: sql2x.DotNetCoreGenerateBusinessLogicLayer.DefaultUsing
*/

using System.Collections.Generic;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public class GetCartProduct {
        
        public List<GetCartProductModel> GetCartProductFromDal(List<GetCartProductData> dataList) {
           var list = new List<GetCartProductModel>();

           foreach (GetCartProductData data in dataList) {
               var model = new GetCartProductModel();
               DataToModel(data, model);
               list.Add(model);
           }

           return list;
        }
        
        public void DataToModel(GetCartProductData dalGetCartProduct, GetCartProductModel dataModel) {
            dataModel.FirstName = dalGetCartProduct.FirstName;
            dataModel.MiddleName = dalGetCartProduct.MiddleName;
            dataModel.LastName = dalGetCartProduct.LastName;
            dataModel.ProductName = dalGetCartProduct.ProductName;
            dataModel.ImageBlobFilename = dalGetCartProduct.ImageBlobFilename;
            dataModel.ProductStateRcd = dalGetCartProduct.ProductStateRcd;
            dataModel.FinancialCurrencyTypeName = dalGetCartProduct.FinancialCurrencyTypeName;
            dataModel.DefaultUserName = dalGetCartProduct.DefaultUserName;
            dataModel.ClientId = dalGetCartProduct.ClientId;
            dataModel.ProductId = dalGetCartProduct.ProductId;
            dataModel.FinancialCurrencyTypeRcd = dalGetCartProduct.FinancialCurrencyTypeRcd;
            dataModel.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = dalGetCartProduct.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            dataModel.FinancialCurrencyTypeCode = dalGetCartProduct.FinancialCurrencyTypeCode;
            dataModel.FinancialCurrencyId = dalGetCartProduct.FinancialCurrencyId;
            dataModel.Amount = dalGetCartProduct.Amount;
            dataModel.CartProductStateRcd = dalGetCartProduct.CartProductStateRcd;
            dataModel.UserId = dalGetCartProduct.UserId;
            dataModel.DateTime = dalGetCartProduct.DateTime;
            dataModel.CartProductId = dalGetCartProduct.CartProductId;
        }
    }
}
