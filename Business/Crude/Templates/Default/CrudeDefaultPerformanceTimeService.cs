/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:10 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel.Activation;
using SolutionNorSolutionPim.DataAccessLayer;

// Business Logic Layer
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//   https://en.wikipedia.org/wiki/Business_logic: business logic layer
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface is used to expose C# objects as SOAP services using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [ServiceContract()]
    public partial interface ICrudeDefaultPerformanceTimeService {
        
        [OperationContract()]
        CrudeDefaultPerformanceTimeContract FetchByDefaultPerformanceTimeId(System.Guid defaultPerformanceTimeId);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultPerformanceTimeContract FetchByCommandName(string commandName);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeContract> FetchWithFilter(System.Guid defaultPerformanceTimeId, string commandName, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultPerformanceTimeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultPerformanceTimeContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultPerformanceTimeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultPerformanceTimeId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_performance_time's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultPerformanceTimeService : ICrudeDefaultPerformanceTimeService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultPerformanceTimeId: primary key of table default_performance_time
        public CrudeDefaultPerformanceTimeContract FetchByDefaultPerformanceTimeId(System.Guid defaultPerformanceTimeId) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeData();
            var contract = new CrudeDefaultPerformanceTimeContract();

            dataAccessLayer.FetchByDefaultPerformanceTimeId(defaultPerformanceTimeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultPerformanceTimeContract FetchByCommandName(string commandName) {
            var dataAccessLayer = new CrudeDefaultPerformanceTimeData();
            var contract = new CrudeDefaultPerformanceTimeContract();

            dataAccessLayer.FetchByCommandName(commandName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultPerformanceTimeContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultPerformanceTimeData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultPerformanceTimeContract> DataListToContractList(List<CrudeDefaultPerformanceTimeData> dataList) {
            var contractList = new List<CrudeDefaultPerformanceTimeContract>();

            foreach (CrudeDefaultPerformanceTimeData data in dataList) {
                var contract = new CrudeDefaultPerformanceTimeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultPerformanceTimeContract> contractList, List<CrudeDefaultPerformanceTimeData> dataList) {
            foreach (CrudeDefaultPerformanceTimeContract contract in contractList) {
                var data = new CrudeDefaultPerformanceTimeData();
                CrudeDefaultPerformanceTimeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultPerformanceTimeContract> FetchAll() {
            var list = new List<CrudeDefaultPerformanceTimeContract>();
            List<CrudeDefaultPerformanceTimeData> dataList = CrudeDefaultPerformanceTimeData.FetchAll();

            foreach (CrudeDefaultPerformanceTimeData crudeDefaultPerformanceTime in dataList) {
                var contract = new CrudeDefaultPerformanceTimeContract();
                DataToContract(crudeDefaultPerformanceTime, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceTimeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultPerformanceTimeContract>();
            List<CrudeDefaultPerformanceTimeData> dataList = CrudeDefaultPerformanceTimeData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultPerformanceTimeData crudeDefaultPerformanceTime in dataList) {
                var contract = new CrudeDefaultPerformanceTimeContract();
                DataToContract(crudeDefaultPerformanceTime, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultPerformanceTimeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultPerformanceTimeContract>();
            List<CrudeDefaultPerformanceTimeData> dataList = CrudeDefaultPerformanceTimeData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultPerformanceTimeData crudeDefaultPerformanceTime in dataList) {
                var contract = new CrudeDefaultPerformanceTimeContract();
                DataToContract(crudeDefaultPerformanceTime, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultPerformanceTimeData.FetchAllCount();
        }
        
        public List<CrudeDefaultPerformanceTimeContract> FetchWithFilter(System.Guid defaultPerformanceTimeId, string commandName, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultPerformanceTimeContract>();
            List<CrudeDefaultPerformanceTimeData> dataList = CrudeDefaultPerformanceTimeData.FetchWithFilter(
                defaultPerformanceTimeId: defaultPerformanceTimeId,
                commandName: commandName,
                milliseconds: milliseconds,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultPerformanceTimeData data in dataList) {
                var crudeDefaultPerformanceTimeContract = new CrudeDefaultPerformanceTimeContract();
                DataToContract(data, crudeDefaultPerformanceTimeContract);
                list.Add(crudeDefaultPerformanceTimeContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultPerformanceTimeContract contract) {
            var data = new CrudeDefaultPerformanceTimeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultPerformanceTimeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultPerformanceTimeContract contract) {
            var data = new CrudeDefaultPerformanceTimeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultPerformanceTimeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultPerformanceTimeData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultPerformanceTimeId) {
            CrudeDefaultPerformanceTimeData.Delete(defaultPerformanceTimeId);
        }
        
        public static void ContractToData(CrudeDefaultPerformanceTimeContract contract, CrudeDefaultPerformanceTimeData data) {
            data.DefaultPerformanceTimeId = contract.DefaultPerformanceTimeId;
            data.CommandName = contract.CommandName;
            data.Milliseconds = contract.Milliseconds;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultPerformanceTimeData data, CrudeDefaultPerformanceTimeContract contract) {
            contract.DefaultPerformanceTimeId = data.DefaultPerformanceTimeId;
            contract.CommandName = data.CommandName;
            contract.Milliseconds = data.Milliseconds;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
