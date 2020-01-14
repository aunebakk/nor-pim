/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:56:00 AM
  Template: sql2x.DotNetCoreGenerateBusinessLogicLayer.DefaultUsing
*/

using System.Collections.Generic;
using SolutionNorSolutionPim.BusinessLogicLayer.Models;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public class GetFinancialOrder {
        
        public List<GetFinancialOrderModel> GetFinancialOrderFromDal(List<GetFinancialOrderData> dataList) {
           var list = new List<GetFinancialOrderModel>();

           foreach (GetFinancialOrderData data in dataList) {
               var model = new GetFinancialOrderModel();
               DataToModel(data, model);
               list.Add(model);
           }

           return list;
        }
        
        public void DataToModel(GetFinancialOrderData dalGetFinancialOrder, GetFinancialOrderModel dataModel) {
            dataModel.FirstName = dalGetFinancialOrder.FirstName;
            dataModel.MiddleName = dalGetFinancialOrder.MiddleName;
            dataModel.LastName = dalGetFinancialOrder.LastName;
            dataModel.ImageBlobFilename = dalGetFinancialOrder.ImageBlobFilename;
            dataModel.DefaultUserName = dalGetFinancialOrder.DefaultUserName;
            dataModel.FinancialCurrencyTypeName = dalGetFinancialOrder.FinancialCurrencyTypeName;
            dataModel.FinancialOrderSourceName = dalGetFinancialOrder.FinancialOrderSourceName;
            dataModel.UserId = dalGetFinancialOrder.UserId;
            dataModel.DateTime = dalGetFinancialOrder.DateTime;
            dataModel.Comment = dalGetFinancialOrder.Comment;
            dataModel.FinancialCurrencyTypeRcd = dalGetFinancialOrder.FinancialCurrencyTypeRcd;
            dataModel.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = dalGetFinancialOrder.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            dataModel.FinancialCurrencyTypeCode = dalGetFinancialOrder.FinancialCurrencyTypeCode;
            dataModel.FinancialCurrencyId = dalGetFinancialOrder.FinancialCurrencyId;
            dataModel.FinancialOrderSourceRcd = dalGetFinancialOrder.FinancialOrderSourceRcd;
            dataModel.ClientId = dalGetFinancialOrder.ClientId;
            dataModel.FinancialOrderId = dalGetFinancialOrder.FinancialOrderId;
            dataModel.LocationAddressId = dalGetFinancialOrder.LocationAddressId;
        }
    }
}
