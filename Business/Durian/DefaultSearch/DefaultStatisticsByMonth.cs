/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:16 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultStatisticsByMonth {

        public List<DefaultStatisticsByMonthContract> DefaultStatisticsByMonthFromDal(List<DefaultStatisticsByMonthData> dataList) {
            List<DefaultStatisticsByMonthContract> list = new List<DefaultStatisticsByMonthContract>();

            foreach (DefaultStatisticsByMonthData data in dataList) {
                DefaultStatisticsByMonthContract contract = new DefaultStatisticsByMonthContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultStatisticsByMonthData dalDefaultStatisticsByMonth, DefaultStatisticsByMonthContract dataContract) {
            dataContract.ActivityDate = dalDefaultStatisticsByMonth.ActivityDate;
            dataContract.DayCount = dalDefaultStatisticsByMonth.DayCount;
        }
    }
}
