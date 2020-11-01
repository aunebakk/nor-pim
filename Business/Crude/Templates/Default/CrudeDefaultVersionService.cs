/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:17:14 PM
  From Machine: DESKTOP-742U247
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
    public partial interface ICrudeDefaultVersionService {
        
        [OperationContract()]
        CrudeDefaultVersionContract FetchByDefaultVersionId(System.Guid defaultVersionId);
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultVersionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultVersionContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultVersionContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultVersionId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_version's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultVersionService : ICrudeDefaultVersionService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultVersionId: primary key of table default_version
        public CrudeDefaultVersionContract FetchByDefaultVersionId(System.Guid defaultVersionId) {
            var dataAccessLayer = new CrudeDefaultVersionData();
            var contract = new CrudeDefaultVersionContract();

            dataAccessLayer.FetchByDefaultVersionId(defaultVersionId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultVersionContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultVersionData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultVersionContract> DataListToContractList(List<CrudeDefaultVersionData> dataList) {
            var contractList = new List<CrudeDefaultVersionContract>();

            foreach (CrudeDefaultVersionData data in dataList) {
                var contract = new CrudeDefaultVersionContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultVersionContract> contractList, List<CrudeDefaultVersionData> dataList) {
            foreach (CrudeDefaultVersionContract contract in contractList) {
                var data = new CrudeDefaultVersionData();
                CrudeDefaultVersionService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultVersionData to a List of SOAP Contracts
        public List<CrudeDefaultVersionContract> FetchAll() {
            var list = new List<CrudeDefaultVersionContract>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAll();

            foreach (CrudeDefaultVersionData crudeDefaultVersion in dataList) {
                var contract = new CrudeDefaultVersionContract();
                DataToContract(crudeDefaultVersion, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultVersionContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultVersionContract>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultVersionData crudeDefaultVersion in dataList) {
                var contract = new CrudeDefaultVersionContract();
                DataToContract(crudeDefaultVersion, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultVersionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultVersionContract>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultVersionData crudeDefaultVersion in dataList) {
                var contract = new CrudeDefaultVersionContract();
                DataToContract(crudeDefaultVersion, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultVersionData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultVersionContract> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultVersionContract>();
            List<CrudeDefaultVersionData> dataList = CrudeDefaultVersionData.FetchWithFilter(
                defaultVersionId: defaultVersionId,
                funVersion: funVersion,
                number: number,
                majorNumber: majorNumber,
                minorNumber: minorNumber,
                sequenceNumber: sequenceNumber,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultVersionData data in dataList) {
                var crudeDefaultVersionContract = new CrudeDefaultVersionContract();
                DataToContract(data, crudeDefaultVersionContract);
                list.Add(crudeDefaultVersionContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultVersionContract contract) {
            var data = new CrudeDefaultVersionData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultVersionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultVersionData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultVersionContract contract) {
            var data = new CrudeDefaultVersionData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultVersionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultVersionData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultVersionId) {
            CrudeDefaultVersionData.Delete(defaultVersionId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultVersionContract contract, CrudeDefaultVersionData data) {
            data.DefaultVersionId = contract.DefaultVersionId;
            data.FunVersion = contract.FunVersion;
            data.Number = contract.Number;
            data.MajorNumber = contract.MajorNumber;
            data.MinorNumber = contract.MinorNumber;
            data.SequenceNumber = contract.SequenceNumber;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultVersionData data, CrudeDefaultVersionContract contract) {
            contract.DefaultVersionId = data.DefaultVersionId;
            contract.FunVersion = data.FunVersion;
            contract.Number = data.Number;
            contract.MajorNumber = data.MajorNumber;
            contract.MinorNumber = data.MinorNumber;
            contract.SequenceNumber = data.SequenceNumber;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
