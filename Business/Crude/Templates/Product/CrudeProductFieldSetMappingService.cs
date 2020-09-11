/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:18 AM
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
        
        public static List<CrudeProductFieldSetMappingContract> DataListToContractList(List<CrudeProductFieldSetMappingData> dataList) {
            var contractList = new List<CrudeProductFieldSetMappingContract>();

            foreach (CrudeProductFieldSetMappingData data in dataList) {
                var contract = new CrudeProductFieldSetMappingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductFieldSetMappingContract> contractList, List<CrudeProductFieldSetMappingData> dataList) {
            foreach (CrudeProductFieldSetMappingContract contract in contractList) {
                var data = new CrudeProductFieldSetMappingData();
                CrudeProductFieldSetMappingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
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
        
        public int FetchAllCount() {
            return CrudeProductFieldSetMappingData.FetchAllCount();
        }
        
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
        
        public void Insert(CrudeProductFieldSetMappingContract contract) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductFieldSetMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductFieldSetMappingContract contract) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductFieldSetMappingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductFieldSetMappingData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productFieldSetMappingId) {
            CrudeProductFieldSetMappingData.Delete(productFieldSetMappingId);
        }
        
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
