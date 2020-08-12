/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:45:42 AM
  From Machine: DESKTOP-00MSEIL
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
    public partial interface ICrudeProductDocumentationTypeRefService {
        
        [OperationContract()]
        CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeName(string productDocumentationTypeName);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductDocumentationTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productDocumentationTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_documentation_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductDocumentationTypeRefService : ICrudeProductDocumentationTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productDocumentationTypeRcd: primary key of table product_documentation_type_ref
        public CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            var contract = new CrudeProductDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeName(string productDocumentationTypeName) {
            var dataAccessLayer = new CrudeProductDocumentationTypeRefData();
            var contract = new CrudeProductDocumentationTypeRefContract();

            dataAccessLayer.FetchByProductDocumentationTypeName(productDocumentationTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductDocumentationTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductDocumentationTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductDocumentationTypeRefContract> DataListToContractList(List<CrudeProductDocumentationTypeRefData> dataList) {
            var contractList = new List<CrudeProductDocumentationTypeRefContract>();

            foreach (CrudeProductDocumentationTypeRefData data in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductDocumentationTypeRefContract> contractList, List<CrudeProductDocumentationTypeRefData> dataList) {
            foreach (CrudeProductDocumentationTypeRefContract contract in contractList) {
                var data = new CrudeProductDocumentationTypeRefData();
                CrudeProductDocumentationTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductDocumentationTypeRefData to a List of SOAP Contracts
        public List<CrudeProductDocumentationTypeRefContract> FetchAll() {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAll();

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductDocumentationTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductDocumentationTypeRefData crudeProductDocumentationTypeRef in dataList) {
                var contract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(crudeProductDocumentationTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductDocumentationTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductDocumentationTypeRefContract> FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductDocumentationTypeRefContract>();
            List<CrudeProductDocumentationTypeRefData> dataList = CrudeProductDocumentationTypeRefData.FetchWithFilter(
                productDocumentationTypeRcd: productDocumentationTypeRcd,
                productDocumentationTypeName: productDocumentationTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductDocumentationTypeRefData data in dataList) {
                var crudeProductDocumentationTypeRefContract = new CrudeProductDocumentationTypeRefContract();
                DataToContract(data, crudeProductDocumentationTypeRefContract);
                list.Add(crudeProductDocumentationTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductDocumentationTypeRefContract contract) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductDocumentationTypeRefContract contract) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductDocumentationTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductDocumentationTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productDocumentationTypeRcd) {
            CrudeProductDocumentationTypeRefData.Delete(productDocumentationTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductDocumentationTypeRefContract contract, CrudeProductDocumentationTypeRefData data) {
            data.ProductDocumentationTypeRcd = contract.ProductDocumentationTypeRcd;
            data.ProductDocumentationTypeName = contract.ProductDocumentationTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductDocumentationTypeRefData data, CrudeProductDocumentationTypeRefContract contract) {
            contract.ProductDocumentationTypeRcd = data.ProductDocumentationTypeRcd;
            contract.ProductDocumentationTypeName = data.ProductDocumentationTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
