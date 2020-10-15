/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 8:58:30 AM
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
    public partial interface ICrudeProductFieldSetService {
        
        [OperationContract()]
        CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductFieldSetContract FetchByProductFieldSetName(string productFieldSetName);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductFieldSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductFieldSetContract contract);
        
        [OperationContract()]
        void Update(CrudeProductFieldSetContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productFieldSetId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_field_set's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductFieldSetService : ICrudeProductFieldSetService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productFieldSetId: primary key of table product_field_set
        public CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId) {
            var dataAccessLayer = new CrudeProductFieldSetData();
            var contract = new CrudeProductFieldSetContract();

            dataAccessLayer.FetchByProductFieldSetId(productFieldSetId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductFieldSetContract FetchByProductFieldSetName(string productFieldSetName) {
            var dataAccessLayer = new CrudeProductFieldSetData();
            var contract = new CrudeProductFieldSetContract();

            dataAccessLayer.FetchByProductFieldSetName(productFieldSetName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductFieldSetContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductFieldSetData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductFieldSetContract> DataListToContractList(List<CrudeProductFieldSetData> dataList) {
            var contractList = new List<CrudeProductFieldSetContract>();

            foreach (CrudeProductFieldSetData data in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductFieldSetContract> contractList, List<CrudeProductFieldSetData> dataList) {
            foreach (CrudeProductFieldSetContract contract in contractList) {
                var data = new CrudeProductFieldSetData();
                CrudeProductFieldSetService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductFieldSetData to a List of SOAP Contracts
        public List<CrudeProductFieldSetContract> FetchAll() {
            var list = new List<CrudeProductFieldSetContract>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAll();

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductFieldSetContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductFieldSetContract>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAllWithLimit(limit);

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductFieldSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductFieldSetContract>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductFieldSetData crudeProductFieldSet in dataList) {
                var contract = new CrudeProductFieldSetContract();
                DataToContract(crudeProductFieldSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductFieldSetData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductFieldSetContract> FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductFieldSetContract>();
            List<CrudeProductFieldSetData> dataList = CrudeProductFieldSetData.FetchWithFilter(
                productFieldSetId: productFieldSetId,
                productFieldSetName: productFieldSetName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductFieldSetData data in dataList) {
                var crudeProductFieldSetContract = new CrudeProductFieldSetContract();
                DataToContract(data, crudeProductFieldSetContract);
                list.Add(crudeProductFieldSetContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductFieldSetContract contract) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductFieldSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductFieldSetContract contract) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductFieldSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productFieldSetId) {
            CrudeProductFieldSetData.Delete(productFieldSetId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductFieldSetContract contract, CrudeProductFieldSetData data) {
            data.ProductFieldSetId = contract.ProductFieldSetId;
            data.ProductFieldSetName = contract.ProductFieldSetName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductFieldSetData data, CrudeProductFieldSetContract contract) {
            contract.ProductFieldSetId = data.ProductFieldSetId;
            contract.ProductFieldSetName = data.ProductFieldSetName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
