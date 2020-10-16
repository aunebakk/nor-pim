/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:00:58 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultErrorOverview {

        public List<DefaultErrorOverviewContract> DefaultErrorOverviewFromDal(List<DefaultErrorOverviewData> dataList) {
            List<DefaultErrorOverviewContract> list = new List<DefaultErrorOverviewContract>();

            foreach (DefaultErrorOverviewData data in dataList) {
                DefaultErrorOverviewContract contract = new DefaultErrorOverviewContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultErrorOverviewData dalDefaultErrorOverview, DefaultErrorOverviewContract dataContract) {
            dataContract.DefaultErrorId = dalDefaultErrorOverview.DefaultErrorId;
            dataContract.DateTime = dalDefaultErrorOverview.DateTime;
            dataContract.DefaultErrorLayerName = dalDefaultErrorOverview.DefaultErrorLayerName;
            dataContract.DefaultErrorTypeName = dalDefaultErrorOverview.DefaultErrorTypeName;
            dataContract.DomainName = dalDefaultErrorOverview.DomainName;
            dataContract.ClassName = dalDefaultErrorOverview.ClassName;
            dataContract.MethodName = dalDefaultErrorOverview.MethodName;
            dataContract.ErrorMessage = dalDefaultErrorOverview.ErrorMessage;
        }
    }
}
