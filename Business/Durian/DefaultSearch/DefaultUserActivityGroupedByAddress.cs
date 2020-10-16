/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:49 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserActivityGroupedByAddress {

        public List<DefaultUserActivityGroupedByAddressContract> DefaultUserActivityGroupedByAddressFromDal(List<DefaultUserActivityGroupedByAddressData> dataList) {
            List<DefaultUserActivityGroupedByAddressContract> list = new List<DefaultUserActivityGroupedByAddressContract>();

            foreach (DefaultUserActivityGroupedByAddressData data in dataList) {
                DefaultUserActivityGroupedByAddressContract contract = new DefaultUserActivityGroupedByAddressContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultUserActivityGroupedByAddressData dalDefaultUserActivityGroupedByAddress, DefaultUserActivityGroupedByAddressContract dataContract) {
            dataContract.OriginatingAddress = dalDefaultUserActivityGroupedByAddress.OriginatingAddress;
            dataContract.Occurrences = dalDefaultUserActivityGroupedByAddress.Occurrences;
        }
    }
}
