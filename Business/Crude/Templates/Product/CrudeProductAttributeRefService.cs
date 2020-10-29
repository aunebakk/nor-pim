/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:18:35 PM
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
    public partial interface ICrudeProductAttributeRefService {
        
        [OperationContract()]
        CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductAttributeRefContract FetchByProductAttributeName(string productAttributeName);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeRefContract contract);
        
        [OperationContract()]
        void Delete(string productAttributeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_attribute_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductAttributeRefService : ICrudeProductAttributeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productAttributeRcd: primary key of table product_attribute_ref
        public CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd) {
            var dataAccessLayer = new CrudeProductAttributeRefData();
            var contract = new CrudeProductAttributeRefContract();

            dataAccessLayer.FetchByProductAttributeRcd(productAttributeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductAttributeRefContract FetchByProductAttributeName(string productAttributeName) {
            var dataAccessLayer = new CrudeProductAttributeRefData();
            var contract = new CrudeProductAttributeRefContract();

            dataAccessLayer.FetchByProductAttributeName(productAttributeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductAttributeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductAttributeRefContract> DataListToContractList(List<CrudeProductAttributeRefData> dataList) {
            var contractList = new List<CrudeProductAttributeRefContract>();

            foreach (CrudeProductAttributeRefData data in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductAttributeRefContract> contractList, List<CrudeProductAttributeRefData> dataList) {
            foreach (CrudeProductAttributeRefContract contract in contractList) {
                var data = new CrudeProductAttributeRefData();
                CrudeProductAttributeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductAttributeRefData to a List of SOAP Contracts
        public List<CrudeProductAttributeRefContract> FetchAll() {
            var list = new List<CrudeProductAttributeRefContract>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAll();

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductAttributeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeRefContract>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeRefContract>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeRefData crudeProductAttributeRef in dataList) {
                var contract = new CrudeProductAttributeRefContract();
                DataToContract(crudeProductAttributeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductAttributeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeRefContract>();
            List<CrudeProductAttributeRefData> dataList = CrudeProductAttributeRefData.FetchWithFilter(
                productAttributeRcd: productAttributeRcd,
                productAttributeName: productAttributeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductAttributeRefData data in dataList) {
                var crudeProductAttributeRefContract = new CrudeProductAttributeRefContract();
                DataToContract(data, crudeProductAttributeRefContract);
                list.Add(crudeProductAttributeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductAttributeRefContract contract) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductAttributeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductAttributeRefContract contract) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductAttributeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productAttributeRcd) {
            CrudeProductAttributeRefData.Delete(productAttributeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductAttributeRefContract contract, CrudeProductAttributeRefData data) {
            data.ProductAttributeRcd = contract.ProductAttributeRcd;
            data.ProductAttributeName = contract.ProductAttributeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductAttributeRefData data, CrudeProductAttributeRefContract contract) {
            contract.ProductAttributeRcd = data.ProductAttributeRcd;
            contract.ProductAttributeName = data.ProductAttributeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
