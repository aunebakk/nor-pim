/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:09:19 PM
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
    public partial interface ICrudeProductExposeService {
        
        [OperationContract()]
        CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByExposeProductId(System.Guid exposeProductId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productExposeId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_expose's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductExposeService : ICrudeProductExposeService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productExposeId: primary key of table product_expose
        public CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId) {
            var dataAccessLayer = new CrudeProductExposeData();
            var contract = new CrudeProductExposeContract();

            dataAccessLayer.FetchByProductExposeId(productExposeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeContract> FetchByExposeProductId(System.Guid exposeProductId) {
            return DataListToContractList(CrudeProductExposeData.FetchByExposeProductId(exposeProductId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeContract> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId) {
            return DataListToContractList(CrudeProductExposeData.FetchByExposeBasedOnProductId(exposeBasedOnProductId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return DataListToContractList(CrudeProductExposeData.FetchByProductExposeSetId(productExposeSetId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposeData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductExposeContract> DataListToContractList(List<CrudeProductExposeData> dataList) {
            var contractList = new List<CrudeProductExposeContract>();

            foreach (CrudeProductExposeData data in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductExposeContract> contractList, List<CrudeProductExposeData> dataList) {
            foreach (CrudeProductExposeContract contract in contractList) {
                var data = new CrudeProductExposeData();
                CrudeProductExposeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductExposeData to a List of SOAP Contracts
        public List<CrudeProductExposeContract> FetchAll() {
            var list = new List<CrudeProductExposeContract>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAll();

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductExposeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeContract>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeContract>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductExposeData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeContract>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchWithFilter(
                productExposeId: productExposeId,
                exposeProductId: exposeProductId,
                exposeBasedOnProductId: exposeBasedOnProductId,
                productExposeSetId: productExposeSetId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposeData data in dataList) {
                var crudeProductExposeContract = new CrudeProductExposeContract();
                DataToContract(data, crudeProductExposeContract);
                list.Add(crudeProductExposeContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductExposeContract contract) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductExposeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductExposeContract contract) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductExposeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productExposeId) {
            CrudeProductExposeData.Delete(productExposeId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductExposeContract contract, CrudeProductExposeData data) {
            data.ProductExposeId = contract.ProductExposeId;
            data.ExposeProductId = contract.ExposeProductId;
            data.ExposeBasedOnProductId = contract.ExposeBasedOnProductId;
            data.ProductExposeSetId = contract.ProductExposeSetId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductExposeData data, CrudeProductExposeContract contract) {
            contract.ProductExposeId = data.ProductExposeId;
            contract.ExposeProductId = data.ExposeProductId;
            contract.ExposeBasedOnProductId = data.ExposeBasedOnProductId;
            contract.ProductExposeSetId = data.ProductExposeSetId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
