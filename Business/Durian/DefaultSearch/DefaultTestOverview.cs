/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:00:37 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultTestOverview {

        public List<DefaultTestOverviewContract> DefaultTestOverviewFromDal(List<DefaultTestOverviewData> dataList) {
            List<DefaultTestOverviewContract> list = new List<DefaultTestOverviewContract>();

            foreach (DefaultTestOverviewData data in dataList) {
                DefaultTestOverviewContract contract = new DefaultTestOverviewContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultTestOverviewData dalDefaultTestOverview, DefaultTestOverviewContract dataContract) {
            dataContract.TestArea = dalDefaultTestOverview.TestArea;
            dataContract.StartDateTime = dalDefaultTestOverview.StartDateTime;
            dataContract.DefaultTestRunResultRcd = dalDefaultTestOverview.DefaultTestRunResultRcd;
        }
    }
}
