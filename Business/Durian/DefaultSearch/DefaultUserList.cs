/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:54 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserList {

        public List<DefaultUserListContract> DefaultUserListFromDal(List<DefaultUserListData> dataList) {
            List<DefaultUserListContract> list = new List<DefaultUserListContract>();

            foreach (DefaultUserListData data in dataList) {
                DefaultUserListContract contract = new DefaultUserListContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultUserListData dalDefaultUserList, DefaultUserListContract dataContract) {
            dataContract.LastActivityDateTime = dalDefaultUserList.LastActivityDateTime;
            dataContract.DefaultUserName = dalDefaultUserList.DefaultUserName;
            dataContract.DefaultUserCode = dalDefaultUserList.DefaultUserCode;
            dataContract.CreatedDateTime = dalDefaultUserList.CreatedDateTime;
            dataContract.Email = dalDefaultUserList.Email;
            dataContract.DefaultStateName = dalDefaultUserList.DefaultStateName;
            dataContract.ActivityCount = dalDefaultUserList.ActivityCount;
            dataContract.CreatedByDefaultUserCode = dalDefaultUserList.CreatedByDefaultUserCode;
            dataContract.CreatedByDefaultUserName = dalDefaultUserList.CreatedByDefaultUserName;
            dataContract.DefaultUserId = dalDefaultUserList.DefaultUserId;
        }
    }
}
