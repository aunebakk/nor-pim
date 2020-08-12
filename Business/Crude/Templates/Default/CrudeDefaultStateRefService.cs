/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:11 AM
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
    public partial interface ICrudeDefaultStateRefService {
        
        [OperationContract()]
        CrudeDefaultStateRefContract FetchByDefaultStateRcd(string defaultStateRcd);
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultStateRefContract FetchByDefaultStateName(string defaultStateName);
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchWithFilter(string defaultStateRcd, string defaultStateName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultStateRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultStateRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultStateRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultStateRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_state_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultStateRefService : ICrudeDefaultStateRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultStateRcd: primary key of table default_state_ref
        public CrudeDefaultStateRefContract FetchByDefaultStateRcd(string defaultStateRcd) {
            var dataAccessLayer = new CrudeDefaultStateRefData();
            var contract = new CrudeDefaultStateRefContract();

            dataAccessLayer.FetchByDefaultStateRcd(defaultStateRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultStateRefContract FetchByDefaultStateName(string defaultStateName) {
            var dataAccessLayer = new CrudeDefaultStateRefData();
            var contract = new CrudeDefaultStateRefContract();

            dataAccessLayer.FetchByDefaultStateName(defaultStateName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultStateRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultStateRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultStateRefContract> DataListToContractList(List<CrudeDefaultStateRefData> dataList) {
            var contractList = new List<CrudeDefaultStateRefContract>();

            foreach (CrudeDefaultStateRefData data in dataList) {
                var contract = new CrudeDefaultStateRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultStateRefContract> contractList, List<CrudeDefaultStateRefData> dataList) {
            foreach (CrudeDefaultStateRefContract contract in contractList) {
                var data = new CrudeDefaultStateRefData();
                CrudeDefaultStateRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultStateRefContract> FetchAll() {
            var list = new List<CrudeDefaultStateRefContract>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAll();

            foreach (CrudeDefaultStateRefData crudeDefaultStateRef in dataList) {
                var contract = new CrudeDefaultStateRefContract();
                DataToContract(crudeDefaultStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultStateRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultStateRefContract>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultStateRefData crudeDefaultStateRef in dataList) {
                var contract = new CrudeDefaultStateRefContract();
                DataToContract(crudeDefaultStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultStateRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultStateRefContract>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultStateRefData crudeDefaultStateRef in dataList) {
                var contract = new CrudeDefaultStateRefContract();
                DataToContract(crudeDefaultStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultStateRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultStateRefContract> FetchWithFilter(string defaultStateRcd, string defaultStateName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultStateRefContract>();
            List<CrudeDefaultStateRefData> dataList = CrudeDefaultStateRefData.FetchWithFilter(
                defaultStateRcd: defaultStateRcd,
                defaultStateName: defaultStateName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultStateRefData data in dataList) {
                var crudeDefaultStateRefContract = new CrudeDefaultStateRefContract();
                DataToContract(data, crudeDefaultStateRefContract);
                list.Add(crudeDefaultStateRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultStateRefContract contract) {
            var data = new CrudeDefaultStateRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultStateRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultStateRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultStateRefContract contract) {
            var data = new CrudeDefaultStateRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultStateRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultStateRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultStateRcd) {
            CrudeDefaultStateRefData.Delete(defaultStateRcd);
        }
        
        public static void ContractToData(CrudeDefaultStateRefContract contract, CrudeDefaultStateRefData data) {
            data.DefaultStateRcd = contract.DefaultStateRcd;
            data.DefaultStateName = contract.DefaultStateName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultStateRefData data, CrudeDefaultStateRefContract contract) {
            contract.DefaultStateRcd = data.DefaultStateRcd;
            contract.DefaultStateName = data.DefaultStateName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
