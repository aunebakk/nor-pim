/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 9/12/2020 3:39:40 PM
  From Machine: DESKTOP-517I8BU
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
    public partial interface ICrudeProductAttributeUnitRefService {
        
        [OperationContract()]
        CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitName(string productAttributeUnitName);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductAttributeUnitRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductAttributeUnitRefContract contract);
        
        [OperationContract()]
        void Delete(string productAttributeUnitRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_attribute_unit_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductAttributeUnitRefService : ICrudeProductAttributeUnitRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productAttributeUnitRcd: primary key of table product_attribute_unit_ref
        public CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            var contract = new CrudeProductAttributeUnitRefContract();

            dataAccessLayer.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitName(string productAttributeUnitName) {
            var dataAccessLayer = new CrudeProductAttributeUnitRefData();
            var contract = new CrudeProductAttributeUnitRefContract();

            dataAccessLayer.FetchByProductAttributeUnitName(productAttributeUnitName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductAttributeUnitRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductAttributeUnitRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductAttributeUnitRefContract> DataListToContractList(List<CrudeProductAttributeUnitRefData> dataList) {
            var contractList = new List<CrudeProductAttributeUnitRefContract>();

            foreach (CrudeProductAttributeUnitRefData data in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductAttributeUnitRefContract> contractList, List<CrudeProductAttributeUnitRefData> dataList) {
            foreach (CrudeProductAttributeUnitRefContract contract in contractList) {
                var data = new CrudeProductAttributeUnitRefData();
                CrudeProductAttributeUnitRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductAttributeUnitRefData to a List of SOAP Contracts
        public List<CrudeProductAttributeUnitRefContract> FetchAll() {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAll();

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductAttributeUnitRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductAttributeUnitRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductAttributeUnitRefData crudeProductAttributeUnitRef in dataList) {
                var contract = new CrudeProductAttributeUnitRefContract();
                DataToContract(crudeProductAttributeUnitRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductAttributeUnitRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductAttributeUnitRefContract> FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductAttributeUnitRefContract>();
            List<CrudeProductAttributeUnitRefData> dataList = CrudeProductAttributeUnitRefData.FetchWithFilter(
                productAttributeUnitRcd: productAttributeUnitRcd,
                productAttributeUnitName: productAttributeUnitName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductAttributeUnitRefData data in dataList) {
                var crudeProductAttributeUnitRefContract = new CrudeProductAttributeUnitRefContract();
                DataToContract(data, crudeProductAttributeUnitRefContract);
                list.Add(crudeProductAttributeUnitRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductAttributeUnitRefContract contract) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductAttributeUnitRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductAttributeUnitRefContract contract) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductAttributeUnitRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductAttributeUnitRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productAttributeUnitRcd) {
            CrudeProductAttributeUnitRefData.Delete(productAttributeUnitRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductAttributeUnitRefContract contract, CrudeProductAttributeUnitRefData data) {
            data.ProductAttributeUnitRcd = contract.ProductAttributeUnitRcd;
            data.ProductAttributeUnitName = contract.ProductAttributeUnitName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductAttributeUnitRefData data, CrudeProductAttributeUnitRefContract contract) {
            contract.ProductAttributeUnitRcd = data.ProductAttributeUnitRcd;
            contract.ProductAttributeUnitName = data.ProductAttributeUnitName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
