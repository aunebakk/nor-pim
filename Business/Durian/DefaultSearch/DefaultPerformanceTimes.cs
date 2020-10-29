/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:26:33 PM
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

    public class DefaultPerformanceTimes {
        
        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimesFromDal(List<DefaultPerformanceTimesData> dataList) {
           var list = new List<DefaultPerformanceTimesContract>();

           foreach (DefaultPerformanceTimesData data in dataList) {
               var contract = new DefaultPerformanceTimesContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultPerformanceTimesData dalDefaultPerformanceTimes, DefaultPerformanceTimesContract dataContract) {
            dataContract.DateTime = dalDefaultPerformanceTimes.DateTime;
            dataContract.Milliseconds = dalDefaultPerformanceTimes.Milliseconds;
        }
    }
}
