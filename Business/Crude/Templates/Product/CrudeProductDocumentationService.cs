/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:44:56 PM
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
    public partial interface ICrudeProductDocumentationService {
        
        [OperationContract()]
        CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductDocumentationContract contract);
        
        [OperationContract()]
        void Update(CrudeProductDocumentationContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productDocumentationId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_documentation's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductDocumentationService : ICrudeProductDocumentationService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productDocumentationId: primary key of table product_documentation
        public CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId) {
            var dataAccessLayer = new CrudeProductDocumentationData();
            var contract = new CrudeProductDocumentationContract();

            dataAccessLayer.FetchByProductDocumentationId(productDocumentationId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductDocumentationContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductDocumentationData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductDocumentationContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductDocumentationData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductDocumentationContract> FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return DataListToContractList(CrudeProductDocumentationData.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductDocumentationContract> DataListToContractList(List<CrudeProductDocumentationData> dataList) {
            var contractList = new List<CrudeProductDocumentationContract>();

            foreach (CrudeProductDocumentationData data in dataList) {
                var contract = new CrudeProductDocumentationContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductDocumentationContract> contractList, List<CrudeProductDocumentationData> dataList) {
            foreach (CrudeProductDocumentationContract contract in contractList) {
                var data = new CrudeProductDocumentationData();
                CrudeProductDocumentationService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductDocumentationData to a List of SOAP Contracts
        public List<CrudeProductDocumentationContract> FetchAll() {
            var list = new List<CrudeProductDocumentationContract>();
            List<CrudeProductDocumentationData> dataList = CrudeProductDocumentationData.FetchAll();

            foreach (CrudeProductDocumentationData crudeProductDocumentation in dataList) {
                var contract = new CrudeProductDocumentationContract();
                DataToContract(crudeProductDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductDocumentationContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductDocumentationContract>();
            List<CrudeProductDocumentationData> dataList = CrudeProductDocumentationData.FetchAllWithLimit(limit);

            foreach (CrudeProductDocumentationData crudeProductDocumentation in dataList) {
                var contract = new CrudeProductDocumentationContract();
                DataToContract(crudeProductDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductDocumentationContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductDocumentationContract>();
            List<CrudeProductDocumentationData> dataList = CrudeProductDocumentationData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductDocumentationData crudeProductDocumentation in dataList) {
                var contract = new CrudeProductDocumentationContract();
                DataToContract(crudeProductDocumentation, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductDocumentationData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductDocumentationContract> FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductDocumentationContract>();
            List<CrudeProductDocumentationData> dataList = CrudeProductDocumentationData.FetchWithFilter(
                productDocumentationId: productDocumentationId,
                productId: productId,
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                documentation: documentation,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductDocumentationData data in dataList) {
                var crudeProductDocumentationContract = new CrudeProductDocumentationContract();
                DataToContract(data, crudeProductDocumentationContract);
                list.Add(crudeProductDocumentationContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductDocumentationContract contract) {
            var data = new CrudeProductDocumentationData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductDocumentationContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductDocumentationContract contract) {
            var data = new CrudeProductDocumentationData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductDocumentationContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productDocumentationId) {
            CrudeProductDocumentationData.Delete(productDocumentationId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductDocumentationContract contract, CrudeProductDocumentationData data) {
            data.ProductDocumentationId = contract.ProductDocumentationId;
            data.ProductId = contract.ProductId;
            data.ProductDocumentationTypeRcd = contract.ProductDocumentationTypeRcd;
            data.Documentation = contract.Documentation;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductDocumentationData data, CrudeProductDocumentationContract contract) {
            contract.ProductDocumentationId = data.ProductDocumentationId;
            contract.ProductId = data.ProductId;
            contract.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            contract.Documentation = data.Documentation;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
