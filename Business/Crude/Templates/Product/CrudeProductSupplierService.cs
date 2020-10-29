/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:45:01 PM
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
    public partial interface ICrudeProductSupplierService {
        
        [OperationContract()]
        CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductSupplierContract FetchBySupplierName(string supplierName);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductSupplierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductSupplierContract contract);
        
        [OperationContract()]
        void Update(CrudeProductSupplierContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productSupplierId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_supplier's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductSupplierService : ICrudeProductSupplierService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productSupplierId: primary key of table product_supplier
        public CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId) {
            var dataAccessLayer = new CrudeProductSupplierData();
            var contract = new CrudeProductSupplierContract();

            dataAccessLayer.FetchByProductSupplierId(productSupplierId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductSupplierContract FetchBySupplierName(string supplierName) {
            var dataAccessLayer = new CrudeProductSupplierData();
            var contract = new CrudeProductSupplierContract();

            dataAccessLayer.FetchBySupplierName(supplierName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductSupplierContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductSupplierData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductSupplierContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductSupplierData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductSupplierContract> DataListToContractList(List<CrudeProductSupplierData> dataList) {
            var contractList = new List<CrudeProductSupplierContract>();

            foreach (CrudeProductSupplierData data in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductSupplierContract> contractList, List<CrudeProductSupplierData> dataList) {
            foreach (CrudeProductSupplierContract contract in contractList) {
                var data = new CrudeProductSupplierData();
                CrudeProductSupplierService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductSupplierData to a List of SOAP Contracts
        public List<CrudeProductSupplierContract> FetchAll() {
            var list = new List<CrudeProductSupplierContract>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAll();

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductSupplierContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductSupplierContract>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAllWithLimit(limit);

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductSupplierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductSupplierContract>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductSupplierData crudeProductSupplier in dataList) {
                var contract = new CrudeProductSupplierContract();
                DataToContract(crudeProductSupplier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductSupplierData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductSupplierContract> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductSupplierContract>();
            List<CrudeProductSupplierData> dataList = CrudeProductSupplierData.FetchWithFilter(
                productSupplierId: productSupplierId,
                productId: productId,
                supplierName: supplierName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductSupplierData data in dataList) {
                var crudeProductSupplierContract = new CrudeProductSupplierContract();
                DataToContract(data, crudeProductSupplierContract);
                list.Add(crudeProductSupplierContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductSupplierContract contract) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductSupplierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductSupplierContract contract) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductSupplierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductSupplierData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productSupplierId) {
            CrudeProductSupplierData.Delete(productSupplierId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductSupplierContract contract, CrudeProductSupplierData data) {
            data.ProductSupplierId = contract.ProductSupplierId;
            data.ProductId = contract.ProductId;
            data.SupplierName = contract.SupplierName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductSupplierData data, CrudeProductSupplierContract contract) {
            contract.ProductSupplierId = data.ProductSupplierId;
            contract.ProductId = data.ProductId;
            contract.SupplierName = data.SupplierName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
