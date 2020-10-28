/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/28/2020 7:03:12 PM
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
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductCategoryDocumentationTypeRefContract> DataListToContractList(List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            var contractList = new List<CrudeProductCategoryDocumentationTypeRefContract>();

            foreach (CrudeProductCategoryDocumentationTypeRefData data in dataList) {
                var contract = new CrudeProductCategoryDocumentationTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductCategoryDocumentationTypeRefContract> contractList, List<CrudeProductCategoryDocumentationTypeRefData> dataList) {
            foreach (CrudeProductCategoryDocumentationTypeRefContract contract in contractList) {
                var data = new CrudeProductCategoryDocumentationTypeRefData();
                CrudeProductCategoryDocumentationTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductCategoryDocumentationTypeRefData to a List of SOAP Contracts
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
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
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
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
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
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductCategoryDocumentationTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
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
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductCategoryDocumentationTypeRefContract contract) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductCategoryDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductCategoryDocumentationTypeRefContract contract) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductCategoryDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productCategoryDocumentationTypeRcd) {
            CrudeProductCategoryDocumentationTypeRefData.Delete(productCategoryDocumentationTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductCategoryDocumentationTypeRefContract contract, CrudeProductCategoryDocumentationTypeRefData data) {
            data.ProductCategoryDocumentationTypeRcd = contract.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryDocumentationTypeName = contract.ProductCategoryDocumentationTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductCategoryDocumentationTypeRefData data, CrudeProductCategoryDocumentationTypeRefContract contract) {
            contract.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            contract.ProductCategoryDocumentationTypeName = data.ProductCategoryDocumentationTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
