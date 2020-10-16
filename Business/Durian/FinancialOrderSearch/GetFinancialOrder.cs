/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 3:05:58 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class GetFinancialOrder {
        
        public List<GetFinancialOrderContract> GetFinancialOrderFromDal(List<GetFinancialOrderData> dataList) {
           var list = new List<GetFinancialOrderContract>();

           foreach (GetFinancialOrderData data in dataList) {
               var contract = new GetFinancialOrderContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(GetFinancialOrderData dalGetFinancialOrder, GetFinancialOrderContract dataContract) {
            dataContract.FirstName = dalGetFinancialOrder.FirstName;
            dataContract.MiddleName = dalGetFinancialOrder.MiddleName;
            dataContract.LastName = dalGetFinancialOrder.LastName;
            dataContract.ClientNationalityRcd = dalGetFinancialOrder.ClientNationalityRcd;
            dataContract.ClientGenderRcd = dalGetFinancialOrder.ClientGenderRcd;
            dataContract.ClientTitleRcd = dalGetFinancialOrder.ClientTitleRcd;
            dataContract.ClientTypeRcd = dalGetFinancialOrder.ClientTypeRcd;
            dataContract.ClientId = dalGetFinancialOrder.ClientId;
            dataContract.FinancialCurrencyTypeRcd = dalGetFinancialOrder.FinancialCurrencyTypeRcd;
            dataContract.FinancialCurrencyAgainstFinancialCurrencyTypeRcd = dalGetFinancialOrder.FinancialCurrencyAgainstFinancialCurrencyTypeRcd;
            dataContract.FinancialCurrencyTypeCode = dalGetFinancialOrder.FinancialCurrencyTypeCode;
            dataContract.FinancialCurrencyTypeName = dalGetFinancialOrder.FinancialCurrencyTypeName;
            dataContract.FinancialCurrencyId = dalGetFinancialOrder.FinancialCurrencyId;
            dataContract.ImageBlobFilename = dalGetFinancialOrder.ImageBlobFilename;
            dataContract.Comment = dalGetFinancialOrder.Comment;
            dataContract.FinancialOrderComment = dalGetFinancialOrder.FinancialOrderComment;
            dataContract.UserId = dalGetFinancialOrder.UserId;
            dataContract.DefaultUserName = dalGetFinancialOrder.DefaultUserName;
            dataContract.DateTime = dalGetFinancialOrder.DateTime;
            dataContract.FinancialOrderId = dalGetFinancialOrder.FinancialOrderId;
        }
    }
}
