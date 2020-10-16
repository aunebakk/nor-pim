/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:00:53 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultIssueWithFilter {

        public List<DefaultIssueWithFilterContract> DefaultIssueWithFilterFromDal(List<DefaultIssueWithFilterData> dataList) {
            List<DefaultIssueWithFilterContract> list = new List<DefaultIssueWithFilterContract>();

            foreach (DefaultIssueWithFilterData data in dataList) {
                DefaultIssueWithFilterContract contract = new DefaultIssueWithFilterContract();
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
