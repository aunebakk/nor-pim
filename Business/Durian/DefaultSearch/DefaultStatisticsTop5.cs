/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:20 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultStatisticsTop5 {

        public List<DefaultStatisticsTop5Contract> DefaultStatisticsTop5FromDal(List<DefaultStatisticsTop5Data> dataList) {
            List<DefaultStatisticsTop5Contract> list = new List<DefaultStatisticsTop5Contract>();

            foreach (DefaultStatisticsTop5Data data in dataList) {
                DefaultStatisticsTop5Contract contract = new DefaultStatisticsTop5Contract();
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
