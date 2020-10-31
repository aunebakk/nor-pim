/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:24:17 AM
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

    public class DefaultUserActivityGrouped {
        
        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGroupedFromDal(List<DefaultUserActivityGroupedData> dataList) {
           var list = new List<DefaultUserActivityGroupedContract>();

           foreach (DefaultUserActivityGroupedData data in dataList) {
               var contract = new DefaultUserActivityGroupedContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultUserActivityGroupedData dalDefaultUserActivityGrouped, DefaultUserActivityGroupedContract dataContract) {
            dataContract.OriginatingAddress = dalDefaultUserActivityGrouped.OriginatingAddress;
            dataContract.UserActivityTypeName = dalDefaultUserActivityGrouped.UserActivityTypeName;
            dataContract.UserActivityNote = dalDefaultUserActivityGrouped.UserActivityNote;
            dataContract.Occurrences = dalDefaultUserActivityGrouped.Occurrences;
        }
    }
}
