/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:07 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultStatistics {

        public List<DefaultStatisticsContract> DefaultStatisticsFromDal(List<DefaultStatisticsData> dataList) {
            List<DefaultStatisticsContract> list = new List<DefaultStatisticsContract>();

            foreach (DefaultStatisticsData data in dataList) {
                DefaultStatisticsContract contract = new DefaultStatisticsContract();
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
