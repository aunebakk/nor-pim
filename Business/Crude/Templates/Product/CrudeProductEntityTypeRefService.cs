/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 8:58:29 AM
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
    public partial interface ICrudeProductEntityTypeRefService {
        
        [OperationContract()]
        CrudeProductEntityTypeRefContract FetchByProductEntityTypeRcd(string productEntityTypeRcd);
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductEntityTypeRefContract FetchByProductEntityTypeName(string productEntityTypeName);
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchWithFilter(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductEntityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductEntityTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductEntityTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productEntityTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_entity_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductEntityTypeRefService : ICrudeProductEntityTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productEntityTypeRcd: primary key of table product_entity_type_ref
        public CrudeProductEntityTypeRefContract FetchByProductEntityTypeRcd(string productEntityTypeRcd) {
            var dataAccessLayer = new CrudeProductEntityTypeRefData();
            var contract = new CrudeProductEntityTypeRefContract();

            dataAccessLayer.FetchByProductEntityTypeRcd(productEntityTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductEntityTypeRefContract FetchByProductEntityTypeName(string productEntityTypeName) {
            var dataAccessLayer = new CrudeProductEntityTypeRefData();
            var contract = new CrudeProductEntityTypeRefContract();

            dataAccessLayer.FetchByProductEntityTypeName(productEntityTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductEntityTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductEntityTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductEntityTypeRefContract> DataListToContractList(List<CrudeProductEntityTypeRefData> dataList) {
            var contractList = new List<CrudeProductEntityTypeRefContract>();

            foreach (CrudeProductEntityTypeRefData data in dataList) {
                var contract = new CrudeProductEntityTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductEntityTypeRefContract> contractList, List<CrudeProductEntityTypeRefData> dataList) {
            foreach (CrudeProductEntityTypeRefContract contract in contractList) {
                var data = new CrudeProductEntityTypeRefData();
                CrudeProductEntityTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductEntityTypeRefData to a List of SOAP Contracts
        public List<CrudeProductEntityTypeRefContract> FetchAll() {
            var list = new List<CrudeProductEntityTypeRefContract>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAll();

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRef in dataList) {
                var contract = new CrudeProductEntityTypeRefContract();
                DataToContract(crudeProductEntityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductEntityTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductEntityTypeRefContract>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRef in dataList) {
                var contract = new CrudeProductEntityTypeRefContract();
                DataToContract(crudeProductEntityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductEntityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductEntityTypeRefContract>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductEntityTypeRefData crudeProductEntityTypeRef in dataList) {
                var contract = new CrudeProductEntityTypeRefContract();
                DataToContract(crudeProductEntityTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductEntityTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductEntityTypeRefContract> FetchWithFilter(string productEntityTypeRcd, string productEntityTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductEntityTypeRefContract>();
            List<CrudeProductEntityTypeRefData> dataList = CrudeProductEntityTypeRefData.FetchWithFilter(
                productEntityTypeRcd: productEntityTypeRcd,
                productEntityTypeName: productEntityTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductEntityTypeRefData data in dataList) {
                var crudeProductEntityTypeRefContract = new CrudeProductEntityTypeRefContract();
                DataToContract(data, crudeProductEntityTypeRefContract);
                list.Add(crudeProductEntityTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductEntityTypeRefContract contract) {
            var data = new CrudeProductEntityTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductEntityTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductEntityTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductEntityTypeRefContract contract) {
            var data = new CrudeProductEntityTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductEntityTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductEntityTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productEntityTypeRcd) {
            CrudeProductEntityTypeRefData.Delete(productEntityTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductEntityTypeRefContract contract, CrudeProductEntityTypeRefData data) {
            data.ProductEntityTypeRcd = contract.ProductEntityTypeRcd;
            data.ProductEntityTypeName = contract.ProductEntityTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductEntityTypeRefData data, CrudeProductEntityTypeRefContract contract) {
            contract.ProductEntityTypeRcd = data.ProductEntityTypeRcd;
            contract.ProductEntityTypeName = data.ProductEntityTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
