/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 4:12:22 AM
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
    public partial interface ICrudeProductExposeSetTypeRefService {
        
        [OperationContract()]
        CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeName(string productExposeSetTypeName);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeSetTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeSetTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productExposeSetTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_expose_set_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductExposeSetTypeRefService : ICrudeProductExposeSetTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productExposeSetTypeRcd: primary key of table product_expose_set_type_ref
        public CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var contract = new CrudeProductExposeSetTypeRefContract();

            dataAccessLayer.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeName(string productExposeSetTypeName) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var contract = new CrudeProductExposeSetTypeRefContract();

            dataAccessLayer.FetchByProductExposeSetTypeName(productExposeSetTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposeSetTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductExposeSetTypeRefContract> DataListToContractList(List<CrudeProductExposeSetTypeRefData> dataList) {
            var contractList = new List<CrudeProductExposeSetTypeRefContract>();

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductExposeSetTypeRefContract> contractList, List<CrudeProductExposeSetTypeRefData> dataList) {
            foreach (CrudeProductExposeSetTypeRefContract contract in contractList) {
                var data = new CrudeProductExposeSetTypeRefData();
                CrudeProductExposeSetTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductExposeSetTypeRefData to a List of SOAP Contracts
        public List<CrudeProductExposeSetTypeRefContract> FetchAll() {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAll();

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductExposeSetTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchWithFilter(
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                productExposeSetTypeName: productExposeSetTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var crudeProductExposeSetTypeRefContract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(data, crudeProductExposeSetTypeRefContract);
                list.Add(crudeProductExposeSetTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductExposeSetTypeRefContract contract) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductExposeSetTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductExposeSetTypeRefContract contract) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductExposeSetTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productExposeSetTypeRcd) {
            CrudeProductExposeSetTypeRefData.Delete(productExposeSetTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductExposeSetTypeRefContract contract, CrudeProductExposeSetTypeRefData data) {
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.ProductExposeSetTypeName = contract.ProductExposeSetTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductExposeSetTypeRefData data, CrudeProductExposeSetTypeRefContract contract) {
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.ProductExposeSetTypeName = data.ProductExposeSetTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
