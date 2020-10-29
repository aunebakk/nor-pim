/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 5:48:51 PM
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
    public partial interface ICrudeProductIdentifierService {
        
        [OperationContract()]
        CrudeProductIdentifierContract FetchByProductIdentifierId(System.Guid productIdentifierId);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductIdentifierContract contract);
        
        [OperationContract()]
        void Update(CrudeProductIdentifierContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productIdentifierId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_identifier's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductIdentifierService : ICrudeProductIdentifierService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productIdentifierId: primary key of table product_identifier
        public CrudeProductIdentifierContract FetchByProductIdentifierId(System.Guid productIdentifierId) {
            var dataAccessLayer = new CrudeProductIdentifierData();
            var contract = new CrudeProductIdentifierContract();

            dataAccessLayer.FetchByProductIdentifierId(productIdentifierId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductIdentifierContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductIdentifierData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductIdentifierContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductIdentifierData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductIdentifierContract> FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return DataListToContractList(CrudeProductIdentifierData.FetchByProductIdentifierRcd(productIdentifierRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductIdentifierContract> DataListToContractList(List<CrudeProductIdentifierData> dataList) {
            var contractList = new List<CrudeProductIdentifierContract>();

            foreach (CrudeProductIdentifierData data in dataList) {
                var contract = new CrudeProductIdentifierContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductIdentifierContract> contractList, List<CrudeProductIdentifierData> dataList) {
            foreach (CrudeProductIdentifierContract contract in contractList) {
                var data = new CrudeProductIdentifierData();
                CrudeProductIdentifierService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductIdentifierData to a List of SOAP Contracts
        public List<CrudeProductIdentifierContract> FetchAll() {
            var list = new List<CrudeProductIdentifierContract>();
            List<CrudeProductIdentifierData> dataList = CrudeProductIdentifierData.FetchAll();

            foreach (CrudeProductIdentifierData crudeProductIdentifier in dataList) {
                var contract = new CrudeProductIdentifierContract();
                DataToContract(crudeProductIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductIdentifierContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductIdentifierContract>();
            List<CrudeProductIdentifierData> dataList = CrudeProductIdentifierData.FetchAllWithLimit(limit);

            foreach (CrudeProductIdentifierData crudeProductIdentifier in dataList) {
                var contract = new CrudeProductIdentifierContract();
                DataToContract(crudeProductIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductIdentifierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductIdentifierContract>();
            List<CrudeProductIdentifierData> dataList = CrudeProductIdentifierData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductIdentifierData crudeProductIdentifier in dataList) {
                var contract = new CrudeProductIdentifierContract();
                DataToContract(crudeProductIdentifier, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductIdentifierData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductIdentifierContract> FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductIdentifierContract>();
            List<CrudeProductIdentifierData> dataList = CrudeProductIdentifierData.FetchWithFilter(
                productIdentifierId: productIdentifierId,
                productId: productId,
                productIdentifierRcd: productIdentifierRcd,
                identifier: identifier,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductIdentifierData data in dataList) {
                var crudeProductIdentifierContract = new CrudeProductIdentifierContract();
                DataToContract(data, crudeProductIdentifierContract);
                list.Add(crudeProductIdentifierContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductIdentifierContract contract) {
            var data = new CrudeProductIdentifierData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductIdentifierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductIdentifierData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductIdentifierContract contract) {
            var data = new CrudeProductIdentifierData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductIdentifierContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductIdentifierData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productIdentifierId) {
            CrudeProductIdentifierData.Delete(productIdentifierId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductIdentifierContract contract, CrudeProductIdentifierData data) {
            data.ProductIdentifierId = contract.ProductIdentifierId;
            data.ProductId = contract.ProductId;
            data.ProductIdentifierRcd = contract.ProductIdentifierRcd;
            data.Identifier = contract.Identifier;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductIdentifierData data, CrudeProductIdentifierContract contract) {
            contract.ProductIdentifierId = data.ProductIdentifierId;
            contract.ProductId = data.ProductId;
            contract.ProductIdentifierRcd = data.ProductIdentifierRcd;
            contract.Identifier = data.Identifier;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
