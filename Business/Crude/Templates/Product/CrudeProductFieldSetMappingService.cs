/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 4:24:38 AM
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
    public partial interface ICrudeProductFieldSetMappingService {
        
        [OperationContract()]
        CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductAttributeRcd(string productAttributeRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductInfoRcd(string productInfoRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductFieldSetMappingContract contract);
        
        [OperationContract()]
        void Update(CrudeProductFieldSetMappingContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productFieldSetMappingId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_field_set_mapping's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductFieldSetMappingService : ICrudeProductFieldSetMappingService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productFieldSetMappingId: primary key of table product_field_set_mapping
        public CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            var dataAccessLayer = new CrudeProductFieldSetMappingData();
            var contract = new CrudeProductFieldSetMappingContract();

            dataAccessLayer.FetchByProductFieldSetMappingId(productFieldSetMappingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductFieldSetMappingContract> FetchByProductFieldSetId(System.Guid productFieldSetId) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductFieldSetId(productFieldSetId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductFieldSetMappingContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductFieldSetMappingContract> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductIdentifierRcd(productIdentifierRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductFieldSetMappingContract> FetchByProductAttributeRcd(string productAttributeRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductAttributeRcd(productAttributeRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductFieldSetMappingContract> FetchByProductInfoRcd(string productInfoRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductInfoRcd(productInfoRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductFieldSetMappingContract> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductImageTypeRcd(productImageTypeRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductFieldSetMappingContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return DataListToContractList(CrudeProductFieldSetMappingData.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductFieldSetMappingContract> DataListToContractList(List<CrudeProductFieldSetMappingData> dataList) {
            var contractList = new List<CrudeProductFieldSetMappingContract>();

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductFieldSetMappingContract> contractList, List<CrudeProductFieldSetMappingData> dataList) {
            foreach (CrudeProductFieldSetMappingContract contract in contractList) {
                var data = new CrudeProductFieldSetMappingData();
                CrudeProductFieldSetMappingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductFieldSetMappingData to a List of SOAP Contracts
        public List<CrudeProductFieldSetMappingContract> FetchAll() {
            var list = new List<CrudeProductFieldSetMappingContract>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAll();

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductFieldSetMappingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAllWithLimit(limit);

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductFieldSetMappingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductFieldSetMappingData crudeProductFieldSetMapping in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(crudeProductFieldSetMapping, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductFieldSetMappingData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductFieldSetMappingContract> FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductFieldSetMappingContract>();
            List<CrudeProductFieldSetMappingData> dataList = CrudeProductFieldSetMappingData.FetchWithFilter(
                productFieldSetMappingId: productFieldSetMappingId,
                productFieldSetId: productFieldSetId,
                productIdentifierRcd: productIdentifierRcd,
                productAttributeRcd: productAttributeRcd,
                productInfoRcd: productInfoRcd,
                productImageTypeRcd: productImageTypeRcd,
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var crudeProductFieldSetMappingContract = new CrudeProductFieldSetMappingContract();
                DataToContract(data, crudeProductFieldSetMappingContract);
                list.Add(crudeProductFieldSetMappingContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductFieldSetMappingContract contract) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductFieldSetMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductFieldSetMappingContract contract) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductFieldSetMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productFieldSetMappingId) {
            CrudeProductFieldSetMappingData.Delete(productFieldSetMappingId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductFieldSetMappingContract contract, CrudeProductFieldSetMappingData data) {
            data.ProductFieldSetMappingId = contract.ProductFieldSetMappingId;
            data.ProductFieldSetId = contract.ProductFieldSetId;
            data.ProductIdentifierRcd = contract.ProductIdentifierRcd;
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.ProductDocumentationTypeRcd = contract.ProductDocumentationTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductFieldSetMappingData data, CrudeProductFieldSetMappingContract contract) {
            contract.ProductFieldSetMappingId = data.ProductFieldSetMappingId;
            contract.ProductFieldSetId = data.ProductFieldSetId;
            contract.ProductIdentifierRcd = data.ProductIdentifierRcd;
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
