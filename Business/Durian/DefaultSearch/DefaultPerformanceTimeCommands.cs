/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 7:49:53 AM
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

    public class DefaultPerformanceTimeCommands {
        
        public List<DefaultPerformanceTimeCommandsContract> DefaultPerformanceTimeCommandsFromDal(List<DefaultPerformanceTimeCommandsData> dataList) {
           var list = new List<DefaultPerformanceTimeCommandsContract>();

           foreach (DefaultPerformanceTimeCommandsData data in dataList) {
               var contract = new DefaultPerformanceTimeCommandsContract();
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
