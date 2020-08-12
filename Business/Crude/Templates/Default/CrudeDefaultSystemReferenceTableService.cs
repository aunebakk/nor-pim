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
    public partial interface ICrudeDefaultSystemReferenceTableService {
        
        [OperationContract()]
        CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultSystemReferenceTableContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultSystemReferenceTableContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultSystemReferenceTableId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_system_reference_table's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultSystemReferenceTableService : ICrudeDefaultSystemReferenceTableService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultSystemReferenceTableId: primary key of table default_system_reference_table
        public CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId) {
            var dataAccessLayer = new CrudeDefaultSystemReferenceTableData();
            var contract = new CrudeDefaultSystemReferenceTableContract();

            dataAccessLayer.FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName) {
            var dataAccessLayer = new CrudeDefaultSystemReferenceTableData();
            var contract = new CrudeDefaultSystemReferenceTableContract();

            dataAccessLayer.FetchByDefaultSystemReferenceTableName(defaultSystemReferenceTableName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultSystemReferenceTableData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultSystemReferenceTableContract> DataListToContractList(List<CrudeDefaultSystemReferenceTableData> dataList) {
            var contractList = new List<CrudeDefaultSystemReferenceTableContract>();

            foreach (CrudeDefaultSystemReferenceTableData data in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultSystemReferenceTableContract> contractList, List<CrudeDefaultSystemReferenceTableData> dataList) {
            foreach (CrudeDefaultSystemReferenceTableContract contract in contractList) {
                var data = new CrudeDefaultSystemReferenceTableData();
                CrudeDefaultSystemReferenceTableService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchAll() {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAll();

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultSystemReferenceTableData crudeDefaultSystemReferenceTable in dataList) {
                var contract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(crudeDefaultSystemReferenceTable, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultSystemReferenceTableData.FetchAllCount();
        }
        
        public List<CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemReferenceTableContract>();
            List<CrudeDefaultSystemReferenceTableData> dataList = CrudeDefaultSystemReferenceTableData.FetchWithFilter(
                defaultSystemReferenceTableId: defaultSystemReferenceTableId,
                defaultSystemReferenceTableName: defaultSystemReferenceTableName,
                defaultSystemReferenceDisplayName: defaultSystemReferenceDisplayName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultSystemReferenceTableData data in dataList) {
                var crudeDefaultSystemReferenceTableContract = new CrudeDefaultSystemReferenceTableContract();
                DataToContract(data, crudeDefaultSystemReferenceTableContract);
                list.Add(crudeDefaultSystemReferenceTableContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultSystemReferenceTableContract contract) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultSystemReferenceTableContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultSystemReferenceTableContract contract) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultSystemReferenceTableContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemReferenceTableData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultSystemReferenceTableId) {
            CrudeDefaultSystemReferenceTableData.Delete(defaultSystemReferenceTableId);
        }
        
        public static void ContractToData(CrudeDefaultSystemReferenceTableContract contract, CrudeDefaultSystemReferenceTableData data) {
            data.DefaultSystemReferenceTableId = contract.DefaultSystemReferenceTableId;
            data.DefaultSystemReferenceTableName = contract.DefaultSystemReferenceTableName;
            data.DefaultSystemReferenceDisplayName = contract.DefaultSystemReferenceDisplayName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultSystemReferenceTableData data, CrudeDefaultSystemReferenceTableContract contract) {
            contract.DefaultSystemReferenceTableId = data.DefaultSystemReferenceTableId;
            contract.DefaultSystemReferenceTableName = data.DefaultSystemReferenceTableName;
            contract.DefaultSystemReferenceDisplayName = data.DefaultSystemReferenceDisplayName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
