/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 8:13:02 PM
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

    public class DefaultStatisticsTop5 {
        
        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5FromDal(List<DefaultStatisticsTop5Data> dataList) {
           var list = new List<DefaultStatisticsTop5Contract>();

           foreach (DefaultStatisticsTop5Data data in dataList) {
               var contract = new DefaultStatisticsTop5Contract();
               DataToContract(data, contract);
               list.Add(contract);
           }

           return list;
        }
        
        public void DataToContract(DefaultStatisticsTop5Data dalDefaultStatisticsTop5, DefaultStatisticsTop5Contract dataContract) {
            dataContract.Measurement = dalDefaultStatisticsTop5.Measurement;
            dataContract.Value = dalDefaultStatisticsTop5.Value;
        }
    }
}
