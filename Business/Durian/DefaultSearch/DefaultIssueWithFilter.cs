/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:54:19 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultIssueWithFilter {
        
        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilterFromDal(List<DefaultIssueWithFilterData> dataList) {
           var list = new List<DefaultIssueWithFilterContract>();

           foreach (DefaultIssueWithFilterData data in dataList) {
               var contract = new DefaultIssueWithFilterContract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultIssueWithFilterData dalDefaultIssueWithFilter, DefaultIssueWithFilterContract dataContract) {
            dataContract.DefaultIssueTypeRcd = dalDefaultIssueWithFilter.DefaultIssueTypeRcd;
            dataContract.DefaultIssueTypeName = dalDefaultIssueWithFilter.DefaultIssueTypeName;
            dataContract.DefaultIssueStatusRcd = dalDefaultIssueWithFilter.DefaultIssueStatusRcd;
            dataContract.DefaultIssueStatusName = dalDefaultIssueWithFilter.DefaultIssueStatusName;
            dataContract.DefaultErrorId = dalDefaultIssueWithFilter.DefaultErrorId;
            dataContract.MethodName = dalDefaultIssueWithFilter.MethodName;
            dataContract.IssueName = dalDefaultIssueWithFilter.IssueName;
            dataContract.IssueDescription = dalDefaultIssueWithFilter.IssueDescription;
            dataContract.StepsToReproduce = dalDefaultIssueWithFilter.StepsToReproduce;
            dataContract.Link = dalDefaultIssueWithFilter.Link;
            dataContract.DateTime = dalDefaultIssueWithFilter.DateTime;
            dataContract.DefaultIssueId = dalDefaultIssueWithFilter.DefaultIssueId;
        }
    }
}
