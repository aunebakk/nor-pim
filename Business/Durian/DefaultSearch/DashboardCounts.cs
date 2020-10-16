/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:00:44 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DashboardCounts {

        public List<DashboardCountsContract> DashboardCountsFromDal(List<DashboardCountsData> dataList) {
            List<DashboardCountsContract> list = new List<DashboardCountsContract>();

            foreach (DashboardCountsData data in dataList) {
                DashboardCountsContract contract = new DashboardCountsContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DashboardCountsData dalDashboardCounts, DashboardCountsContract dataContract) {
            dataContract.DashboardItemRcd = dalDashboardCounts.DashboardItemRcd;
            dataContract.DashboardItemName = dalDashboardCounts.DashboardItemName;
            dataContract.ImageSource = dalDashboardCounts.ImageSource;
            dataContract.Value = dalDashboardCounts.Value;
            dataContract.Last24HoursCount = dalDashboardCounts.Last24HoursCount;
            dataContract.LastDateTime = dalDashboardCounts.LastDateTime;
            dataContract.LastUserName = dalDashboardCounts.LastUserName;
            dataContract.Url = dalDashboardCounts.Url;
            dataContract.PositionLeft = dalDashboardCounts.PositionLeft;
            dataContract.PositionTop = dalDashboardCounts.PositionTop;
            dataContract.PositionOffset = dalDashboardCounts.PositionOffset;
        }
    }
}
