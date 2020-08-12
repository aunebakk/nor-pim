/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:15 AM
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
    public partial interface ICrudeProductCategoryDocumentationTypeRefService {
        
        [OperationContract()]
        CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productCategoryDocumentationTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_category_documentation_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductCategoryDocumentationTypeRefService : ICrudeProductCategoryDocumentationTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productCategoryDocumentationTypeRcd: primary key of table product_category_documentation_type_ref
        public CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            var contract = new CrudeProductCategoryDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeName(string productCategoryDocumentationTypeName) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationTypeRefData();
            var contract = new CrudeProductCategoryDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductCategoryDocumentationTypeName(productCategoryDocumentationTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryDocumentationTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductCategoryDocumentationTypeRefContract> DataListToContractList(List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            var contractList = new List<CrudeProductCategoryDocumentationTypeRefContract>();

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductCategoryDocumentationTypeRefContract> contractList, List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            foreach (CrudeProductCategoryDocumentationTypeRefContract contract in contractList) {
                var data = new CrudeProductCategoryDocumentationTypeRefData();
                CrudeProductCategoryDocumentationTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAll() {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAll();

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryDocumentationTypeRefData crudeProductCategoryDocumentationTypeRef in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(crudeProductCategoryDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductCategoryDocumentationTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductCategoryDocumentationTypeRefContract> FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryDocumentationTypeRefContract>();
            List<CrudeProductCategoryDocumentationTypeRefData> dataList = CrudeProductCategoryDocumentationTypeRefData.FetchWithFilter(
                productCategoryDocumentationTypeRcd: productCategoryDocumentationTypeRcd,
                productCategoryDocumentationTypeName: productCategoryDocumentationTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var crudeProductCategoryDocumentationTypeRefContract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(data, crudeProductCategoryDocumentationTypeRefContract);
                list.Add(crudeProductCategoryDocumentationTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductCategoryDocumentationTypeRefContract contract) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductCategoryDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductCategoryDocumentationTypeRefContract contract) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductCategoryDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productCategoryDocumentationTypeRcd) {
            CrudeProductCategoryDocumentationTypeRefData.Delete(productCategoryDocumentationTypeRcd);
        }
        
        public static void ContractToData(CrudeProductCategoryDocumentationTypeRefContract contract, CrudeProductCategoryDocumentationTypeRefData data) {
            data.ProductCategoryDocumentationTypeRcd = contract.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryDocumentationTypeName = contract.ProductCategoryDocumentationTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductCategoryDocumentationTypeRefData data, CrudeProductCategoryDocumentationTypeRefContract contract) {
            contract.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            contract.ProductCategoryDocumentationTypeName = data.ProductCategoryDocumentationTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
