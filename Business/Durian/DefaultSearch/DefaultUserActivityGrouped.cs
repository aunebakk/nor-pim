/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:44 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserActivityGrouped {

        public List<DefaultUserActivityGroupedContract> DefaultUserActivityGroupedFromDal(List<DefaultUserActivityGroupedData> dataList) {
            List<DefaultUserActivityGroupedContract> list = new List<DefaultUserActivityGroupedContract>();

            foreach (DefaultUserActivityGroupedData data in dataList) {
                DefaultUserActivityGroupedContract contract = new DefaultUserActivityGroupedContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultUserActivityGroupedData dalDefaultUserActivityGrouped, DefaultUserActivityGroupedContract dataContract) {
            dataContract.OriginatingAddress = dalDefaultUserActivityGrouped.OriginatingAddress;
            dataContract.UserActivityTypeName = dalDefaultUserActivityGrouped.UserActivityTypeName;
            dataContract.UserActivityNote = dalDefaultUserActivityGrouped.UserActivityNote;
            dataContract.Occurrences = dalDefaultUserActivityGrouped.Occurrences;
        }
    }
}
