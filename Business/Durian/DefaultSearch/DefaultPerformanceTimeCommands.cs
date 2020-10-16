/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:01:30 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.GenerateBusinessLogicLayer.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public class DefaultPerformanceTimeCommands {

        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommandsFromDal(List<DefaultPerformanceTimeCommandsData> dataList) {
            List<DefaultPerformanceTimeCommandsContract> list = new List<DefaultPerformanceTimeCommandsContract>();

            foreach (DefaultPerformanceTimeCommandsData data in dataList) {
                DefaultPerformanceTimeCommandsContract contract = new DefaultPerformanceTimeCommandsContract();
                DataToContract(data, contract);
                list.Add(contract);
            }

            return list;
        }

        public void DataToContract(DefaultPerformanceTimeCommandsData dalDefaultPerformanceTimeCommands, DefaultPerformanceTimeCommandsContract dataContract) {
            dataContract.CommandName = dalDefaultPerformanceTimeCommands.CommandName;
            dataContract.CommandDisplayName = dalDefaultPerformanceTimeCommands.CommandDisplayName;
        }
    }
}
