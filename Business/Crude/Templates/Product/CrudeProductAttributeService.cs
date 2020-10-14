/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 2:45:41 PM
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
    public partial interface ICrudeProductAttributeService {
        
        [OperationContract()]
        CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByProductAttributeRcd(string productAttributeRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productAttributeId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_attribute's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductAttributeService : ICrudeProductAttributeService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productAttributeId: primary key of table product_attribute
        public CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId) {
            var dataAccessLayer = new CrudeProductAttributeData();
            var contract = new CrudeProductAttributeContract();

            dataAccessLayer.FetchByProductAttributeId(productAttributeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductAttributeContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductAttributeData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductAttributeContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductAttributeData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductAttributeContract> FetchByProductAttributeRcd(string productAttributeRcd) {
            return DataListToContractList(CrudeProductAttributeData.FetchByProductAttributeRcd(productAttributeRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductAttributeContract> FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            return DataListToContractList(CrudeProductAttributeData.FetchByProductAttributeUnitRcd(productAttributeUnitRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductAttributeContract> DataListToContractList(List<CrudeProductAttributeData> dataList) {
            var contractList = new List<CrudeProductAttributeContract>();

            foreach (CrudeProductAttributeData data in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductAttributeContract> contractList, List<CrudeProductAttributeData> dataList) {
            foreach (CrudeProductAttributeContract contract in contractList) {
                var data = new CrudeProductAttributeData();
                CrudeProductAttributeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductAttributeData to a List of SOAP Contracts
        public List<CrudeProductAttributeContract> FetchAll() {
            var list = new List<CrudeProductAttributeContract>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAll();

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductAttributeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeContract>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeContract>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeData crudeProductAttribute in dataList) {
                var contract = new CrudeProductAttributeContract();
                DataToContract(crudeProductAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductAttributeData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductAttributeContract> FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeContract>();
            List<CrudeProductAttributeData> dataList = CrudeProductAttributeData.FetchWithFilter(
                productAttributeId: productAttributeId,
                productId: productId,
                productAttributeRcd: productAttributeRcd,
                productAttributeUnitRcd: productAttributeUnitRcd,
                value: value,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductAttributeData data in dataList) {
                var crudeProductAttributeContract = new CrudeProductAttributeContract();
                DataToContract(data, crudeProductAttributeContract);
                list.Add(crudeProductAttributeContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductAttributeContract contract) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductAttributeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductAttributeContract contract) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductAttributeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productAttributeId) {
            CrudeProductAttributeData.Delete(productAttributeId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductAttributeContract contract, CrudeProductAttributeData data) {
            data.ProductAttributeId = contract.ProductAttributeId;
            data.ProductId = contract.ProductId;
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductAttributeUnitRcd = contract.ProductAttributeUnitRcd;
            data.Value = contract.Value;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductAttributeData data, CrudeProductAttributeContract contract) {
            contract.ProductAttributeId = data.ProductAttributeId;
            contract.ProductId = data.ProductId;
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductAttributeUnitRcd = data.ProductAttributeUnitRcd;
            contract.Value = data.Value;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
