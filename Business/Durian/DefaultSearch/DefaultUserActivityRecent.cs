/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:35 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserActivityRecent {

        public List<DefaultUserActivityRecentContract> DefaultUserActivityRecentFromDal(List<DefaultUserActivityRecentData> dataList) {
            List<DefaultUserActivityRecentContract> list = new List<DefaultUserActivityRecentContract>();

            foreach (DefaultUserActivityRecentData data in dataList) {
                DefaultUserActivityRecentContract contract = new DefaultUserActivityRecentContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultUserActivityRecentData dalDefaultUserActivityRecent, DefaultUserActivityRecentContract dataContract) {
            dataContract.DateTime = dalDefaultUserActivityRecent.DateTime;
            dataContract.UserActivityTypeName = dalDefaultUserActivityRecent.UserActivityTypeName;
            dataContract.OriginatingAddress = dalDefaultUserActivityRecent.OriginatingAddress;
            dataContract.Referrer = dalDefaultUserActivityRecent.Referrer;
            dataContract.UserActivityNote = dalDefaultUserActivityRecent.UserActivityNote;
        }
    }
}
