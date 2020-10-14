/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 5:48:10 PM
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
    public partial interface ICrudeProductCategoryMappingService {
        
        [OperationContract()]
        CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryMappingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryMappingContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryMappingContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productCategoryMappingId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_category_mapping's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductCategoryMappingService : ICrudeProductCategoryMappingService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productCategoryMappingId: primary key of table product_category_mapping
        public CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId) {
            var dataAccessLayer = new CrudeProductCategoryMappingData();
            var contract = new CrudeProductCategoryMappingContract();

            dataAccessLayer.FetchByProductCategoryMappingId(productCategoryMappingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryMappingContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToContractList(CrudeProductCategoryMappingData.FetchByProductCategoryId(productCategoryId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryMappingContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductCategoryMappingData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryMappingContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryMappingData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductCategoryMappingContract> DataListToContractList(List<CrudeProductCategoryMappingData> dataList) {
            var contractList = new List<CrudeProductCategoryMappingContract>();

            foreach (CrudeProductCategoryMappingData data in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductCategoryMappingContract> contractList, List<CrudeProductCategoryMappingData> dataList) {
            foreach (CrudeProductCategoryMappingContract contract in contractList) {
                var data = new CrudeProductCategoryMappingData();
                CrudeProductCategoryMappingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductCategoryMappingData to a List of SOAP Contracts
        public List<CrudeProductCategoryMappingContract> FetchAll() {
            var list = new List<CrudeProductCategoryMappingContract>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAll();

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductCategoryMappingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryMappingContract>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductCategoryMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryMappingContract>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryMappingData crudeProductCategoryMapping in dataList) {
                var contract = new CrudeProductCategoryMappingContract();
                DataToContract(crudeProductCategoryMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductCategoryMappingData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductCategoryMappingContract> FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryMappingContract>();
            List<CrudeProductCategoryMappingData> dataList = CrudeProductCategoryMappingData.FetchWithFilter(
                productCategoryMappingId: productCategoryMappingId,
                productCategoryId: productCategoryId,
                productId: productId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryMappingData data in dataList) {
                var crudeProductCategoryMappingContract = new CrudeProductCategoryMappingContract();
                DataToContract(data, crudeProductCategoryMappingContract);
                list.Add(crudeProductCategoryMappingContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductCategoryMappingContract contract) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductCategoryMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductCategoryMappingContract contract) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductCategoryMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryMappingData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productCategoryMappingId) {
            CrudeProductCategoryMappingData.Delete(productCategoryMappingId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductCategoryMappingContract contract, CrudeProductCategoryMappingData data) {
            data.ProductCategoryMappingId = contract.ProductCategoryMappingId;
            data.ProductCategoryId = contract.ProductCategoryId;
            data.ProductId = contract.ProductId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductCategoryMappingData data, CrudeProductCategoryMappingContract contract) {
            contract.ProductCategoryMappingId = data.ProductCategoryMappingId;
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.ProductId = data.ProductId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
