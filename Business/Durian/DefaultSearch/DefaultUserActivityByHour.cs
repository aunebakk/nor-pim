/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:11 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultUserActivityByHour {

        public List<DefaultUserActivityByHourContract> DefaultUserActivityByHourFromDal(List<DefaultUserActivityByHourData> dataList) {
            List<DefaultUserActivityByHourContract> list = new List<DefaultUserActivityByHourContract>();

            foreach (DefaultUserActivityByHourData data in dataList) {
                DefaultUserActivityByHourContract contract = new DefaultUserActivityByHourContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultUserActivityByHourData dalDefaultUserActivityByHour, DefaultUserActivityByHourContract dataContract) {
            dataContract.HourNumber = dalDefaultUserActivityByHour.HourNumber;
            dataContract.HourCount = dalDefaultUserActivityByHour.HourCount;
        }
    }
}
