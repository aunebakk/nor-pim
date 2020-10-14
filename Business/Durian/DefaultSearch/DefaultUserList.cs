/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:54:34 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserList {
        
        public List<DefaultUserListContract> DefaultUserListFromDal(List<DefaultUserListData> dataList) {
           var list = new List<DefaultUserListContract>();

           foreach (DefaultUserListData data in dataList) {
               var contract = new DefaultUserListContract();
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
