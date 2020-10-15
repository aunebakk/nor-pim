/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 5:29:48 PM
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
    public partial interface ICrudeProductExposeSetService {
        
        [OperationContract()]
        CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [OperationContract()]
        CrudeProductExposeSetContract FetchByProductExposeSetName(string productExposeSetName);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeSetContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeSetContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productExposeSetId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_expose_set's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductExposeSetService : ICrudeProductExposeSetService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productExposeSetId: primary key of table product_expose_set
        public CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId) {
            var dataAccessLayer = new CrudeProductExposeSetData();
            var contract = new CrudeProductExposeSetContract();

            dataAccessLayer.FetchByProductExposeSetId(productExposeSetId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductExposeSetContract FetchByProductExposeSetName(string productExposeSetName) {
            var dataAccessLayer = new CrudeProductExposeSetData();
            var contract = new CrudeProductExposeSetContract();

            dataAccessLayer.FetchByProductExposeSetName(productExposeSetName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeSetContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposeSetData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeSetContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return DataListToContractList(CrudeProductExposeSetData.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductExposeSetContract> DataListToContractList(List<CrudeProductExposeSetData> dataList) {
            var contractList = new List<CrudeProductExposeSetContract>();

            foreach (CrudeProductExposeSetData data in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductExposeSetContract> contractList, List<CrudeProductExposeSetData> dataList) {
            foreach (CrudeProductExposeSetContract contract in contractList) {
                var data = new CrudeProductExposeSetData();
                CrudeProductExposeSetService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductExposeSetData to a List of SOAP Contracts
        public List<CrudeProductExposeSetContract> FetchAll() {
            var list = new List<CrudeProductExposeSetContract>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAll();

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductExposeSetContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeSetContract>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductExposeSetContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeSetContract>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeSetData crudeProductExposeSet in dataList) {
                var contract = new CrudeProductExposeSetContract();
                DataToContract(crudeProductExposeSet, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductExposeSetData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductExposeSetContract> FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetContract>();
            List<CrudeProductExposeSetData> dataList = CrudeProductExposeSetData.FetchWithFilter(
                productExposeSetId: productExposeSetId,
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                productExposeSetName: productExposeSetName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposeSetData data in dataList) {
                var crudeProductExposeSetContract = new CrudeProductExposeSetContract();
                DataToContract(data, crudeProductExposeSetContract);
                list.Add(crudeProductExposeSetContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductExposeSetContract contract) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductExposeSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductExposeSetContract contract) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductExposeSetContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productExposeSetId) {
            CrudeProductExposeSetData.Delete(productExposeSetId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductExposeSetContract contract, CrudeProductExposeSetData data) {
            data.ProductExposeSetId = contract.ProductExposeSetId;
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.ProductExposeSetName = contract.ProductExposeSetName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductExposeSetData data, CrudeProductExposeSetContract contract) {
            contract.ProductExposeSetId = data.ProductExposeSetId;
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.ProductExposeSetName = data.ProductExposeSetName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
