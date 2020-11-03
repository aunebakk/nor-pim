/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:47:48 AM
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
    public partial interface ICrudeProductInfoRefService {
        
        [OperationContract()]
        CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductInfoRefContract FetchByProductInfoName(string productInfoName);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductInfoRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductInfoRefContract contract);
        
        [OperationContract()]
        void Delete(string productInfoRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_info_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductInfoRefService : ICrudeProductInfoRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productInfoRcd: primary key of table product_info_ref
        public CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd) {
            var dataAccessLayer = new CrudeProductInfoRefData();
            var contract = new CrudeProductInfoRefContract();

            dataAccessLayer.FetchByProductInfoRcd(productInfoRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductInfoRefContract FetchByProductInfoName(string productInfoName) {
            var dataAccessLayer = new CrudeProductInfoRefData();
            var contract = new CrudeProductInfoRefContract();

            dataAccessLayer.FetchByProductInfoName(productInfoName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductInfoRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductInfoRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductInfoRefContract> DataListToContractList(List<CrudeProductInfoRefData> dataList) {
            var contractList = new List<CrudeProductInfoRefContract>();

            foreach (CrudeProductInfoRefData data in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductInfoRefContract> contractList, List<CrudeProductInfoRefData> dataList) {
            foreach (CrudeProductInfoRefContract contract in contractList) {
                var data = new CrudeProductInfoRefData();
                CrudeProductInfoRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductInfoRefData to a List of SOAP Contracts
        public List<CrudeProductInfoRefContract> FetchAll() {
            var list = new List<CrudeProductInfoRefContract>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAll();

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductInfoRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductInfoRefContract>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductInfoRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductInfoRefContract>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductInfoRefData crudeProductInfoRef in dataList) {
                var contract = new CrudeProductInfoRefContract();
                DataToContract(crudeProductInfoRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductInfoRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductInfoRefContract> FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInfoRefContract>();
            List<CrudeProductInfoRefData> dataList = CrudeProductInfoRefData.FetchWithFilter(
                productInfoRcd: productInfoRcd,
                productInfoName: productInfoName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductInfoRefData data in dataList) {
                var crudeProductInfoRefContract = new CrudeProductInfoRefContract();
                DataToContract(data, crudeProductInfoRefContract);
                list.Add(crudeProductInfoRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductInfoRefContract contract) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductInfoRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductInfoRefContract contract) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductInfoRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productInfoRcd) {
            CrudeProductInfoRefData.Delete(productInfoRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductInfoRefContract contract, CrudeProductInfoRefData data) {
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductInfoName = contract.ProductInfoName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductInfoRefData data, CrudeProductInfoRefContract contract) {
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductInfoName = data.ProductInfoName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
