/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 1:25:28 PM
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
    public partial interface ICrudeProductService {
        
        [OperationContract()]
        CrudeProductContract FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductContract> FetchByProductBecameId(System.Guid productBecameId);
        
        [OperationContract()]
        List<CrudeProductContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductContract> FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        CrudeProductContract FetchByProductName(string productName);
        
        [OperationContract()]
        List<CrudeProductContract> FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductContract contract);
        
        [OperationContract()]
        void Update(CrudeProductContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductService : ICrudeProductService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productId: primary key of table product
        public CrudeProductContract FetchByProductId(System.Guid productId) {
            var dataAccessLayer = new CrudeProductData();
            var contract = new CrudeProductContract();

            dataAccessLayer.FetchByProductId(productId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductContract FetchByProductName(string productName) {
            var dataAccessLayer = new CrudeProductData();
            var contract = new CrudeProductContract();

            dataAccessLayer.FetchByProductName(productName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductContract> FetchByProductBecameId(System.Guid productBecameId) {
            return DataListToContractList(CrudeProductData.FetchByProductBecameId(productBecameId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductContract> FetchByStateRcd(string stateRcd) {
            return DataListToContractList(CrudeProductData.FetchByStateRcd(stateRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductContract> DataListToContractList(List<CrudeProductData> dataList) {
            var contractList = new List<CrudeProductContract>();

            foreach (CrudeProductData data in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductContract> contractList, List<CrudeProductData> dataList) {
            foreach (CrudeProductContract contract in contractList) {
                var data = new CrudeProductData();
                CrudeProductService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductData to a List of SOAP Contracts
        public List<CrudeProductContract> FetchAll() {
            var list = new List<CrudeProductContract>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAll();

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductContract>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAllWithLimit(limit);

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductContract>();
            List<CrudeProductData> dataList = CrudeProductData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductData crudeProduct in dataList) {
                var contract = new CrudeProductContract();
                DataToContract(crudeProduct, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductContract> FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductContract>();
            List<CrudeProductData> dataList = CrudeProductData.FetchWithFilter(
                productId: productId,
                productBecameId: productBecameId,
                productName: productName,
                stateRcd: stateRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductData data in dataList) {
                var crudeProductContract = new CrudeProductContract();
                DataToContract(data, crudeProductContract);
                list.Add(crudeProductContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductContract contract) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductContract contract) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productId) {
            CrudeProductData.Delete(productId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductContract contract, CrudeProductData data) {
            data.ProductId = contract.ProductId;
            data.ProductBecameId = contract.ProductBecameId;
            data.ProductName = contract.ProductName;
            data.StateRcd = contract.StateRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductData data, CrudeProductContract contract) {
            contract.ProductId = data.ProductId;
            contract.ProductBecameId = data.ProductBecameId;
            contract.ProductName = data.ProductName;
            contract.StateRcd = data.StateRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
