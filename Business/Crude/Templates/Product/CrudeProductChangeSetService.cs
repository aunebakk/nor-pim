/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:21:32 PM
  From Machine: DESKTOP-KE5CSN3
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
    public partial interface ICrudeProductChangeSetService {
        
        [OperationContract()]
        CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductChangeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductChangeSetContract contract);
        
        [OperationContract()]
        void Update(CrudeProductChangeSetContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productChangeSetId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_change_set's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductChangeSetService : ICrudeProductChangeSetService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productChangeSetId: primary key of table product_change_set
        public CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId) {
            var dataAccessLayer = new CrudeProductChangeSetData();
            var contract = new CrudeProductChangeSetContract();

            dataAccessLayer.FetchByProductChangeSetId(productChangeSetId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductChangeSetContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductChangeSetData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductChangeSetContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return DataListToContractList(CrudeProductChangeSetData.FetchByProductGatherKeyId(productGatherKeyId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductChangeSetContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductChangeSetData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductChangeSetContract> DataListToContractList(List<CrudeProductChangeSetData> dataList) {
            var contractList = new List<CrudeProductChangeSetContract>();

            foreach (CrudeProductChangeSetData data in dataList) {
                var contract = new CrudeProductChangeSetContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductChangeSetContract> contractList, List<CrudeProductChangeSetData> dataList) {
            foreach (CrudeProductChangeSetContract contract in contractList) {
                var data = new CrudeProductChangeSetData();
                CrudeProductChangeSetService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductChangeSetData to a List of SOAP Contracts
        public List<CrudeProductChangeSetContract> FetchAll() {
            var list = new List<CrudeProductChangeSetContract>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAll();

            foreach (CrudeProductChangeSetData crudeProductChangeSet in dataList) {
                var contract = new CrudeProductChangeSetContract();
                DataToContract(crudeProductChangeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductChangeSetContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductChangeSetContract>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAllWithLimit(limit);

            foreach (CrudeProductChangeSetData crudeProductChangeSet in dataList) {
                var contract = new CrudeProductChangeSetContract();
                DataToContract(crudeProductChangeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductChangeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductChangeSetContract>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductChangeSetData crudeProductChangeSet in dataList) {
                var contract = new CrudeProductChangeSetContract();
                DataToContract(crudeProductChangeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductChangeSetData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductChangeSetContract> FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductChangeSetContract>();
            List<CrudeProductChangeSetData> dataList = CrudeProductChangeSetData.FetchWithFilter(
                productChangeSetId: productChangeSetId,
                productId: productId,
                productGatherKeyId: productGatherKeyId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductChangeSetData data in dataList) {
                var crudeProductChangeSetContract = new CrudeProductChangeSetContract();
                DataToContract(data, crudeProductChangeSetContract);
                list.Add(crudeProductChangeSetContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductChangeSetContract contract) {
            var data = new CrudeProductChangeSetData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductChangeSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductChangeSetData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductChangeSetContract contract) {
            var data = new CrudeProductChangeSetData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductChangeSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductChangeSetData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productChangeSetId) {
            CrudeProductChangeSetData.Delete(productChangeSetId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductChangeSetContract contract, CrudeProductChangeSetData data) {
            data.ProductChangeSetId = contract.ProductChangeSetId;
            data.ProductId = contract.ProductId;
            data.ProductGatherKeyId = contract.ProductGatherKeyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductChangeSetData data, CrudeProductChangeSetContract contract) {
            contract.ProductChangeSetId = data.ProductChangeSetId;
            contract.ProductId = data.ProductId;
            contract.ProductGatherKeyId = data.ProductGatherKeyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
