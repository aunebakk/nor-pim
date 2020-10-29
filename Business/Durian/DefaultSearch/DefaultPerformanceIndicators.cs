/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:13:35 AM
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

    public class DefaultPerformanceIndicators {
        
        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicatorsFromDal(List<DefaultPerformanceIndicatorsData> dataList) {
           var list = new List<DefaultPerformanceIndicatorsContract>();

           foreach (DefaultPerformanceIndicatorsData data in dataList) {
               var contract = new DefaultPerformanceIndicatorsContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultPerformanceIndicatorsData dalDefaultPerformanceIndicators, DefaultPerformanceIndicatorsContract dataContract) {
            dataContract.CommandName = dalDefaultPerformanceIndicators.CommandName;
            dataContract.HitCount = dalDefaultPerformanceIndicators.HitCount;
            dataContract.AverageMilliseconds = dalDefaultPerformanceIndicators.AverageMilliseconds;
        }
    }
}
