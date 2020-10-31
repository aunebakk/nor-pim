/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:23:35 AM
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

    public class DefaultTestOverview {
        
        public List<DefaultTestOverviewContract> DefaultTestOverviewFromDal(List<DefaultTestOverviewData> dataList) {
           var list = new List<DefaultTestOverviewContract>();

           foreach (DefaultTestOverviewData data in dataList) {
               var contract = new DefaultTestOverviewContract();
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
