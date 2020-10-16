/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:02:14 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultResourceDatabaseStatistics {

        public List<DefaultResourceDatabaseStatisticsContract> DefaultResourceDatabaseStatisticsFromDal(List<DefaultResourceDatabaseStatisticsData> dataList) {
            List<DefaultResourceDatabaseStatisticsContract> list = new List<DefaultResourceDatabaseStatisticsContract>();

            foreach (DefaultResourceDatabaseStatisticsData data in dataList) {
                DefaultResourceDatabaseStatisticsContract contract = new DefaultResourceDatabaseStatisticsContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultResourceDatabaseStatisticsData dalDefaultResourceDatabaseStatistics, DefaultResourceDatabaseStatisticsContract dataContract) {
            dataContract.ReservedPageCount = dalDefaultResourceDatabaseStatistics.ReservedPageCount;
        }
    }
}
