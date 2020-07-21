/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:25:50 AM
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

    public class DefaultResourceStatistics {
        
        public List<DefaultResourceStatisticsContract> DefaultResourceStatisticsFromDal(List<DefaultResourceStatisticsData> dataList) {
           var list = new List<DefaultResourceStatisticsContract>();

           foreach (DefaultResourceStatisticsData data in dataList) {
               var contract = new DefaultResourceStatisticsContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultResourceStatisticsData dalDefaultResourceStatistics, DefaultResourceStatisticsContract dataContract) {
            dataContract.HourNumber = dalDefaultResourceStatistics.HourNumber;
            dataContract.ClientWorkingsetBytes = dalDefaultResourceStatistics.ClientWorkingsetBytes;
            dataContract.BusinessWorkingsetBytes = dalDefaultResourceStatistics.BusinessWorkingsetBytes;
            dataContract.DatabaseSizeBytes = dalDefaultResourceStatistics.DatabaseSizeBytes;
        }
    }
}
