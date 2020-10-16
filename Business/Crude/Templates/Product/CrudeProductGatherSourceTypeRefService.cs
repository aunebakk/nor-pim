/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:58:04 AM
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
    public partial interface ICrudeProductGatherSourceTypeRefService {
        
        [OperationContract()]
        CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeName(string productGatherSourceTypeName);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherSourceTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherSourceTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productGatherSourceTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_gather_source_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductGatherSourceTypeRefService : ICrudeProductGatherSourceTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productGatherSourceTypeRcd: primary key of table product_gather_source_type_ref
        public CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            var contract = new CrudeProductGatherSourceTypeRefContract();

            dataAccessLayer.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeName(string productGatherSourceTypeName) {
            var dataAccessLayer = new CrudeProductGatherSourceTypeRefData();
            var contract = new CrudeProductGatherSourceTypeRefContract();

            dataAccessLayer.FetchByProductGatherSourceTypeName(productGatherSourceTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherSourceTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherSourceTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductGatherSourceTypeRefContract> DataListToContractList(List<CrudeProductGatherSourceTypeRefData> dataList) {
            var contractList = new List<CrudeProductGatherSourceTypeRefContract>();

            foreach (CrudeProductGatherSourceTypeRefData data in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductGatherSourceTypeRefContract> contractList, List<CrudeProductGatherSourceTypeRefData> dataList) {
            foreach (CrudeProductGatherSourceTypeRefContract contract in contractList) {
                var data = new CrudeProductGatherSourceTypeRefData();
                CrudeProductGatherSourceTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductGatherSourceTypeRefData to a List of SOAP Contracts
        public List<CrudeProductGatherSourceTypeRefContract> FetchAll() {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAll();

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductGatherSourceTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherSourceTypeRefData crudeProductGatherSourceTypeRef in dataList) {
                var contract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(crudeProductGatherSourceTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductGatherSourceTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductGatherSourceTypeRefContract> FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherSourceTypeRefContract>();
            List<CrudeProductGatherSourceTypeRefData> dataList = CrudeProductGatherSourceTypeRefData.FetchWithFilter(
                productGatherSourceTypeRcd: productGatherSourceTypeRcd,
                productGatherSourceTypeName: productGatherSourceTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherSourceTypeRefData data in dataList) {
                var crudeProductGatherSourceTypeRefContract = new CrudeProductGatherSourceTypeRefContract();
                DataToContract(data, crudeProductGatherSourceTypeRefContract);
                list.Add(crudeProductGatherSourceTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductGatherSourceTypeRefContract contract) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductGatherSourceTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductGatherSourceTypeRefContract contract) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductGatherSourceTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherSourceTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productGatherSourceTypeRcd) {
            CrudeProductGatherSourceTypeRefData.Delete(productGatherSourceTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductGatherSourceTypeRefContract contract, CrudeProductGatherSourceTypeRefData data) {
            data.ProductGatherSourceTypeRcd = contract.ProductGatherSourceTypeRcd;
            data.ProductGatherSourceTypeName = contract.ProductGatherSourceTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductGatherSourceTypeRefData data, CrudeProductGatherSourceTypeRefContract contract) {
            contract.ProductGatherSourceTypeRcd = data.ProductGatherSourceTypeRcd;
            contract.ProductGatherSourceTypeName = data.ProductGatherSourceTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
