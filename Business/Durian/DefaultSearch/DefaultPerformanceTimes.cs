/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:25 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultPerformanceTimes {

        public List<DefaultPerformanceTimesContract> DefaultPerformanceTimesFromDal(List<DefaultPerformanceTimesData> dataList) {
            List<DefaultPerformanceTimesContract> list = new List<DefaultPerformanceTimesContract>();

            foreach (DefaultPerformanceTimesData data in dataList) {
                DefaultPerformanceTimesContract contract = new DefaultPerformanceTimesContract();
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
