/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 1:20:35 PM
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

    public class DefaultUserActivityRecent {
        
        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecentFromDal(List<DefaultUserActivityRecentData> dataList) {
           var list = new List<DefaultUserActivityRecentContract>();

           foreach (DefaultUserActivityRecentData data in dataList) {
               var contract = new DefaultUserActivityRecentContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultUserActivityRecentData dalDefaultUserActivityRecent, DefaultUserActivityRecentContract dataContract) {
            dataContract.DateTime = dalDefaultUserActivityRecent.DateTime;
            dataContract.UserActivityTypeName = dalDefaultUserActivityRecent.UserActivityTypeName;
            dataContract.OriginatingAddress = dalDefaultUserActivityRecent.OriginatingAddress;
            dataContract.Referrer = dalDefaultUserActivityRecent.Referrer;
            dataContract.UserActivityNote = dalDefaultUserActivityRecent.UserActivityNote;
        }
    }
}
