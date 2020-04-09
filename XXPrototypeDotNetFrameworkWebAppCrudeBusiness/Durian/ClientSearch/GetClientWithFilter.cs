/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 10:05:48 AM
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    public class GetClientWithFilter {
        
        public List<GetClientWithFilterContract> GetClientWithFilterFromDal(List<GetClientWithFilterData> dataList) {
           var list = new List<GetClientWithFilterContract>();

           foreach (GetClientWithFilterData data in dataList) {
               var contract = new GetClientWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(GetClientWithFilterData dalGetClientWithFilter, GetClientWithFilterContract dataContract) {
            dataContract.FirstName = dalGetClientWithFilter.FirstName;
            dataContract.MiddleName = dalGetClientWithFilter.MiddleName;
            dataContract.LastName = dalGetClientWithFilter.LastName;
            dataContract.ClientTypeRcd = dalGetClientWithFilter.ClientTypeRcd;
            dataContract.ClientTypeName = dalGetClientWithFilter.ClientTypeName;
            dataContract.ClientNationalityRcd = dalGetClientWithFilter.ClientNationalityRcd;
            dataContract.ClientNationalityName = dalGetClientWithFilter.ClientNationalityName;
            dataContract.ClientGenderRcd = dalGetClientWithFilter.ClientGenderRcd;
            dataContract.ClientGenderName = dalGetClientWithFilter.ClientGenderName;
            dataContract.ClientTitleRcd = dalGetClientWithFilter.ClientTitleRcd;
            dataContract.ClientTitleName = dalGetClientWithFilter.ClientTitleName;
            dataContract.UserId = dalGetClientWithFilter.UserId;
            dataContract.DefaultUserName = dalGetClientWithFilter.DefaultUserName;
            dataContract.DateTime = dalGetClientWithFilter.DateTime;
            dataContract.ClientId = dalGetClientWithFilter.ClientId;
            dataContract.ClientUserId = dalGetClientWithFilter.ClientUserId;
        }
    }
}
