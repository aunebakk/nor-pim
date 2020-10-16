/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:03 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultPerformanceIndicators {

        public List<DefaultPerformanceIndicatorsContract> DefaultPerformanceIndicatorsFromDal(List<DefaultPerformanceIndicatorsData> dataList) {
            List<DefaultPerformanceIndicatorsContract> list = new List<DefaultPerformanceIndicatorsContract>();

            foreach (DefaultPerformanceIndicatorsData data in dataList) {
                DefaultPerformanceIndicatorsContract contract = new DefaultPerformanceIndicatorsContract();
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
