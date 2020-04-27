/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:56:50 PM
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
            dataModel.ClientNationalityRcd = dalGetFinancialOrder.ClientNationalityRcd;
            dataModel.ClientGenderRcd = dalGetFinancialOrder.ClientGenderRcd;
            dataModel.ClientTitleRcd = dalGetFinancialOrder.ClientTitleRcd;
            dataModel.ClientTypeRcd = dalGetFinancialOrder.ClientTypeRcd;
            dataModel.ClientId = dalGetFinancialOrder.ClientId;
            dataModel.FinancialCurrencyTypeRcd = dalGetFinancialOrder.FinancialCurrencyTypeRcd;
            dataModel.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = dalGetFinancialOrder.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            dataModel.FinancialCurrencyTypeCode = dalGetFinancialOrder.FinancialCurrencyTypeCode;
            dataModel.FinancialCurrencyTypeName = dalGetFinancialOrder.FinancialCurrencyTypeName;
            dataModel.FinancialCurrencyId = dalGetFinancialOrder.FinancialCurrencyId;
            dataModel.LocationAddressTypeRcd = dalGetFinancialOrder.LocationAddressTypeRcd;
            dataModel.AddressOne = dalGetFinancialOrder.AddressOne;
            dataModel.AddressTwo = dalGetFinancialOrder.AddressTwo;
            dataModel.AddressThree = dalGetFinancialOrder.AddressThree;
            dataModel.City = dalGetFinancialOrder.City;
            dataModel.Street = dalGetFinancialOrder.Street;
            dataModel.State = dalGetFinancialOrder.State;
            dataModel.District = dalGetFinancialOrder.District;
            dataModel.Province = dalGetFinancialOrder.Province;
            dataModel.ZipCode = dalGetFinancialOrder.ZipCode;
            dataModel.PoBox = dalGetFinancialOrder.PoBox;
            dataModel.LocationAddressComment = dalGetFinancialOrder.LocationAddressComment;
            dataModel.LocationAddressId = dalGetFinancialOrder.LocationAddressId;
            dataModel.FinancialOrderSourceRcd = dalGetFinancialOrder.FinancialOrderSourceRcd;
            dataModel.ImageBlobFilename = dalGetFinancialOrder.ImageBlobFilename;
            dataModel.FinancialOrderSourceName = dalGetFinancialOrder.FinancialOrderSourceName;
            dataModel.Comment = dalGetFinancialOrder.Comment;
            dataModel.FinancialOrderComment = dalGetFinancialOrder.FinancialOrderComment;
            dataModel.UserId = dalGetFinancialOrder.UserId;
            dataModel.DefaultUserName = dalGetFinancialOrder.DefaultUserName;
            dataModel.DateTime = dalGetFinancialOrder.DateTime;
            dataModel.FinancialOrderId = dalGetFinancialOrder.FinancialOrderId;
        }
    }
}
