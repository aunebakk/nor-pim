/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:09 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultResourceStatistics {

        public List<DefaultResourceStatisticsContract> DefaultResourceStatisticsFromDal(List<DefaultResourceStatisticsData> dataList) {
            List<DefaultResourceStatisticsContract> list = new List<DefaultResourceStatisticsContract>();

            foreach (DefaultResourceStatisticsData data in dataList) {
                DefaultResourceStatisticsContract contract = new DefaultResourceStatisticsContract();
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
