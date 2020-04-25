/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:38:45 AM
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
            dataModel.ClientNationalityRcd = dalGetCartProduct.ClientNationalityRcd;
            dataModel.ClientGenderRcd = dalGetCartProduct.ClientGenderRcd;
            dataModel.ClientTitleRcd = dalGetCartProduct.ClientTitleRcd;
            dataModel.ClientTypeRcd = dalGetCartProduct.ClientTypeRcd;
            dataModel.ClientId = dalGetCartProduct.ClientId;
            dataModel.ProductName = dalGetCartProduct.ProductName;
            dataModel.ProductStateRcd = dalGetCartProduct.ProductStateRcd;
            dataModel.ProductId = dalGetCartProduct.ProductId;
            dataModel.FinancialCurrencyTypeRcd = dalGetCartProduct.FinancialCurrencyTypeRcd;
            dataModel.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = dalGetCartProduct.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            dataModel.FinancialCurrencyTypeCode = dalGetCartProduct.FinancialCurrencyTypeCode;
            dataModel.FinancialCurrencyTypeName = dalGetCartProduct.FinancialCurrencyTypeName;
            dataModel.FinancialCurrencyId = dalGetCartProduct.FinancialCurrencyId;
            dataModel.Amount = dalGetCartProduct.Amount;
            dataModel.CartProductStateRcd = dalGetCartProduct.CartProductStateRcd;
            dataModel.ImageBlobFilename = dalGetCartProduct.ImageBlobFilename;
            dataModel.UserId = dalGetCartProduct.UserId;
            dataModel.DefaultUserName = dalGetCartProduct.DefaultUserName;
            dataModel.DateTime = dalGetCartProduct.DateTime;
            dataModel.CartProductId = dalGetCartProduct.CartProductId;
        }
    }
}
