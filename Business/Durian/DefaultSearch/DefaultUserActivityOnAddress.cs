/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:39 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserActivityOnAddress {

        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddressFromDal(List<DefaultUserActivityOnAddressData> dataList) {
            List<DefaultUserActivityOnAddressContract> list = new List<DefaultUserActivityOnAddressContract>();

            foreach (DefaultUserActivityOnAddressData data in dataList) {
                DefaultUserActivityOnAddressContract contract = new DefaultUserActivityOnAddressContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultUserActivityOnAddressData dalDefaultUserActivityOnAddress, DefaultUserActivityOnAddressContract dataContract) {
            dataContract.DateTime = dalDefaultUserActivityOnAddress.DateTime;
            dataContract.UserActivityTypeName = dalDefaultUserActivityOnAddress.UserActivityTypeName;
            dataContract.OriginatingAddress = dalDefaultUserActivityOnAddress.OriginatingAddress;
            dataContract.UserActivityNote = dalDefaultUserActivityOnAddress.UserActivityNote;
        }
    }
}
