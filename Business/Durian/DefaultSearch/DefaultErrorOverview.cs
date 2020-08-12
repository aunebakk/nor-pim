/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:51:57 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultErrorOverview {
        
        public List<DefaultErrorOverviewContract> DefaultErrorOverviewFromDal(List<DefaultErrorOverviewData> dataList) {
           var list = new List<DefaultErrorOverviewContract>();

           foreach (DefaultErrorOverviewData data in dataList) {
               var contract = new DefaultErrorOverviewContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultErrorOverviewData dalDefaultErrorOverview, DefaultErrorOverviewContract dataContract) {
            dataContract.DefaultErrorId = dalDefaultErrorOverview.DefaultErrorId;
            dataContract.DateTime = dalDefaultErrorOverview.DateTime;
            dataContract.DefaultErrorLayerName = dalDefaultErrorOverview.DefaultErrorLayerName;
            dataContract.DefaultErrorTypeName = dalDefaultErrorOverview.DefaultErrorTypeName;
            dataContract.DomainName = dalDefaultErrorOverview.DomainName;
            dataContract.ClassName = dalDefaultErrorOverview.ClassName;
            dataContract.MethodName = dalDefaultErrorOverview.MethodName;
            dataContract.ErrorMessage = dalDefaultErrorOverview.ErrorMessage;
        }
    }
}
