/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 1:21:00 PM
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
    public partial interface ICrudeProductCategoryDocumentationService {
        
        [OperationContract()]
        CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryDocumentationContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryDocumentationContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productCategoryDocumentationId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_category_documentation's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductCategoryDocumentationService : ICrudeProductCategoryDocumentationService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productCategoryDocumentationId: primary key of table product_category_documentation
        public CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId) {
            var dataAccessLayer = new CrudeProductCategoryDocumentationData();
            var contract = new CrudeProductCategoryDocumentationContract();

            dataAccessLayer.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToContractList(CrudeProductCategoryDocumentationData.FetchByProductCategoryId(productCategoryId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryDocumentationContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryDocumentationData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryDocumentationContract> FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            return DataListToContractList(CrudeProductCategoryDocumentationData.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductCategoryDocumentationContract> DataListToContractList(List<CrudeProductCategoryDocumentationData> dataList) {
            var contractList = new List<CrudeProductCategoryDocumentationContract>();

            foreach (CrudeProductCategoryDocumentationData data in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductCategoryDocumentationContract> contractList, List<CrudeProductCategoryDocumentationData> dataList) {
            foreach (CrudeProductCategoryDocumentationContract contract in contractList) {
                var data = new CrudeProductCategoryDocumentationData();
                CrudeProductCategoryDocumentationService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductCategoryDocumentationData to a List of SOAP Contracts
        public List<CrudeProductCategoryDocumentationContract> FetchAll() {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAll();

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductCategoryDocumentationContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductCategoryDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryDocumentationData crudeProductCategoryDocumentation in dataList) {
                var contract = new CrudeProductCategoryDocumentationContract();
                DataToContract(crudeProductCategoryDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductCategoryDocumentationData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductCategoryDocumentationContract> FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryDocumentationContract>();
            List<CrudeProductCategoryDocumentationData> dataList = CrudeProductCategoryDocumentationData.FetchWithFilter(
                productCategoryDocumentationId: productCategoryDocumentationId,
                productCategoryDocumentationTypeRcd: productCategoryDocumentationTypeRcd,
                productCategoryId: productCategoryId,
                documentation: documentation,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryDocumentationData data in dataList) {
                var crudeProductCategoryDocumentationContract = new CrudeProductCategoryDocumentationContract();
                DataToContract(data, crudeProductCategoryDocumentationContract);
                list.Add(crudeProductCategoryDocumentationContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductCategoryDocumentationContract contract) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductCategoryDocumentationContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductCategoryDocumentationContract contract) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductCategoryDocumentationContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryDocumentationData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productCategoryDocumentationId) {
            CrudeProductCategoryDocumentationData.Delete(productCategoryDocumentationId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductCategoryDocumentationContract contract, CrudeProductCategoryDocumentationData data) {
            data.ProductCategoryDocumentationId = contract.ProductCategoryDocumentationId;
            data.ProductCategoryDocumentationTypeRcd = contract.ProductCategoryDocumentationTypeRcd;
            data.ProductCategoryId = contract.ProductCategoryId;
            data.Documentation = contract.Documentation;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductCategoryDocumentationData data, CrudeProductCategoryDocumentationContract contract) {
            contract.ProductCategoryDocumentationId = data.ProductCategoryDocumentationId;
            contract.ProductCategoryDocumentationTypeRcd = data.ProductCategoryDocumentationTypeRcd;
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.Documentation = data.Documentation;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
