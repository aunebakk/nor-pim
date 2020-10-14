/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 5:56:05 PM
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

    public class DefaultStatistics {
        
        public List<DefaultStatisticsContract> DefaultStatisticsFromDal(List<DefaultStatisticsData> dataList) {
           var list = new List<DefaultStatisticsContract>();

           foreach (DefaultStatisticsData data in dataList) {
               var contract = new DefaultStatisticsContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultStatisticsData dalDefaultStatistics, DefaultStatisticsContract dataContract) {
            dataContract.ActivityDate = dalDefaultStatistics.ActivityDate;
            dataContract.DayCount = dalDefaultStatistics.DayCount;
        }
    }
}
