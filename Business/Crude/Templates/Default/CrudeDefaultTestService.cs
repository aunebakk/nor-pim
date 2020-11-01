/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:28:00 AM
  From Machine: DESKTOP-9A2DH39
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
    public partial interface ICrudeDefaultTestService {
        
        [OperationContract()]
        CrudeDefaultTestContract FetchByDefaultTestId(System.Guid defaultTestId);
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeDefaultTestContract FetchBySystemName(string systemName);
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultTestContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultTestContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultTestContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultTestId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_test's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultTestService : ICrudeDefaultTestService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultTestId: primary key of table default_test
        public CrudeDefaultTestContract FetchByDefaultTestId(System.Guid defaultTestId) {
            var dataAccessLayer = new CrudeDefaultTestData();
            var contract = new CrudeDefaultTestContract();

            dataAccessLayer.FetchByDefaultTestId(defaultTestId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultTestContract FetchBySystemName(string systemName) {
            var dataAccessLayer = new CrudeDefaultTestData();
            var contract = new CrudeDefaultTestContract();

            dataAccessLayer.FetchBySystemName(systemName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultTestContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeDefaultTestData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultTestContract> DataListToContractList(List<CrudeDefaultTestData> dataList) {
            var contractList = new List<CrudeDefaultTestContract>();

            foreach (CrudeDefaultTestData data in dataList) {
                var contract = new CrudeDefaultTestContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultTestContract> contractList, List<CrudeDefaultTestData> dataList) {
            foreach (CrudeDefaultTestContract contract in contractList) {
                var data = new CrudeDefaultTestData();
                CrudeDefaultTestService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultTestData to a List of SOAP Contracts
        public List<CrudeDefaultTestContract> FetchAll() {
            var list = new List<CrudeDefaultTestContract>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAll();

            foreach (CrudeDefaultTestData crudeDefaultTest in dataList) {
                var contract = new CrudeDefaultTestContract();
                DataToContract(crudeDefaultTest, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultTestContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultTestContract>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultTestData crudeDefaultTest in dataList) {
                var contract = new CrudeDefaultTestContract();
                DataToContract(crudeDefaultTest, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultTestContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultTestContract>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultTestData crudeDefaultTest in dataList) {
                var contract = new CrudeDefaultTestContract();
                DataToContract(crudeDefaultTest, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultTestData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultTestContract> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultTestContract>();
            List<CrudeDefaultTestData> dataList = CrudeDefaultTestData.FetchWithFilter(
                defaultTestId: defaultTestId,
                systemName: systemName,
                testArea: testArea,
                testSubArea: testSubArea,
                testAddress: testAddress,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultTestData data in dataList) {
                var crudeDefaultTestContract = new CrudeDefaultTestContract();
                DataToContract(data, crudeDefaultTestContract);
                list.Add(crudeDefaultTestContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultTestContract contract) {
            var data = new CrudeDefaultTestData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultTestContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultTestContract contract) {
            var data = new CrudeDefaultTestData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultTestContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultTestData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultTestId) {
            CrudeDefaultTestData.Delete(defaultTestId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultTestContract contract, CrudeDefaultTestData data) {
            data.DefaultTestId = contract.DefaultTestId;
            data.SystemName = contract.SystemName;
            data.TestArea = contract.TestArea;
            data.TestSubArea = contract.TestSubArea;
            data.TestAddress = contract.TestAddress;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultTestData data, CrudeDefaultTestContract contract) {
            contract.DefaultTestId = data.DefaultTestId;
            contract.SystemName = data.SystemName;
            contract.TestArea = data.TestArea;
            contract.TestSubArea = data.TestSubArea;
            contract.TestAddress = data.TestAddress;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
