/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:47:06 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DashboardCounts {
        
        public List<DashboardCountsContract> DashboardCountsFromDal(List<DashboardCountsData> dataList) {
           var list = new List<DashboardCountsContract>();

           foreach (DashboardCountsData data in dataList) {
               var contract = new DashboardCountsContract();
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
