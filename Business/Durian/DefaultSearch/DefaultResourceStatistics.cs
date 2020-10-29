/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:05:27 PM
  From Machine: DESKTOP-9A2DH39
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
