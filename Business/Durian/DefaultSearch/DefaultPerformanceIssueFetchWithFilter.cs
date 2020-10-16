/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:00:48 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultPerformanceIssueFetchWithFilter {

        public List<DefaultPerformanceIssueFetchWithFilterContract> DefaultPerformanceIssueFetchWithFilterFromDal(List<DefaultPerformanceIssueFetchWithFilterData> dataList) {
            List<DefaultPerformanceIssueFetchWithFilterContract> list = new List<DefaultPerformanceIssueFetchWithFilterContract>();

            foreach (DefaultPerformanceIssueFetchWithFilterData data in dataList) {
                DefaultPerformanceIssueFetchWithFilterContract contract = new DefaultPerformanceIssueFetchWithFilterContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultPerformanceIssueFetchWithFilterData dalDefaultPerformanceIssueFetchWithFilter, DefaultPerformanceIssueFetchWithFilterContract dataContract) {
            dataContract.DateTime = dalDefaultPerformanceIssueFetchWithFilter.DateTime;
            dataContract.CommandName = dalDefaultPerformanceIssueFetchWithFilter.CommandName;
            dataContract.Milliseconds = dalDefaultPerformanceIssueFetchWithFilter.Milliseconds;
            dataContract.DefaultPerformanceIssueId = dalDefaultPerformanceIssueFetchWithFilter.DefaultPerformanceIssueId;
        }
    }
}
