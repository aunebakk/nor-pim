/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:59 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserListForDashboard {

        public List<DefaultUserListForDashboardContract> DefaultUserListForDashboardFromDal(List<DefaultUserListForDashboardData> dataList) {
            List<DefaultUserListForDashboardContract> list = new List<DefaultUserListForDashboardContract>();

            foreach (DefaultUserListForDashboardData data in dataList) {
                DefaultUserListForDashboardContract contract = new DefaultUserListForDashboardContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultUserListForDashboardData dalDefaultUserListForDashboard, DefaultUserListForDashboardContract dataContract) {
            dataContract.DefaultUserCode = dalDefaultUserListForDashboard.DefaultUserCode;
            dataContract.DefaultUserName = dalDefaultUserListForDashboard.DefaultUserName;
            dataContract.Email = dalDefaultUserListForDashboard.Email;
            dataContract.DefaultStateName = dalDefaultUserListForDashboard.DefaultStateName;
            dataContract.ActivityCount = dalDefaultUserListForDashboard.ActivityCount;
            dataContract.LastActivityDateTime = dalDefaultUserListForDashboard.LastActivityDateTime;
            dataContract.CreatedDateTime = dalDefaultUserListForDashboard.CreatedDateTime;
            dataContract.CreatedByDefaultUserCode = dalDefaultUserListForDashboard.CreatedByDefaultUserCode;
            dataContract.CreatedByDefaultUserName = dalDefaultUserListForDashboard.CreatedByDefaultUserName;
            dataContract.DefaultUserId = dalDefaultUserListForDashboard.DefaultUserId;
        }
    }
}
