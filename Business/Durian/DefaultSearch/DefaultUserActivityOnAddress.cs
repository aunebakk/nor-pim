/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:57:19 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using SolutionNorSolutionPim.DataAccessLayer;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserActivityOnAddress {
        
        public List<DefaultUserActivityOnAddressContract> DefaultUserActivityOnAddressFromDal(List<DefaultUserActivityOnAddressData> dataList) {
           var list = new List<DefaultUserActivityOnAddressContract>();

           foreach (DefaultUserActivityOnAddressData data in dataList) {
               var contract = new DefaultUserActivityOnAddressContract();
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
