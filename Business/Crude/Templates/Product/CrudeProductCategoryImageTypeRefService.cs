/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 7:44:27 PM
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
    public partial interface ICrudeProductCategoryImageTypeRefService {
        
        [OperationContract()]
        CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeName(string productCategoryImageTypeName);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryImageTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryImageTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productCategoryImageTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_category_image_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductCategoryImageTypeRefService : ICrudeProductCategoryImageTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productCategoryImageTypeRcd: primary key of table product_category_image_type_ref
        public CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            var contract = new CrudeProductCategoryImageTypeRefContract();

            dataAccessLayer.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeName(string productCategoryImageTypeName) {
            var dataAccessLayer = new CrudeProductCategoryImageTypeRefData();
            var contract = new CrudeProductCategoryImageTypeRefContract();

            dataAccessLayer.FetchByProductCategoryImageTypeName(productCategoryImageTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryImageTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryImageTypeRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductCategoryImageTypeRefContract> DataListToContractList(List<CrudeProductCategoryImageTypeRefData> dataList) {
            var contractList = new List<CrudeProductCategoryImageTypeRefContract>();

            foreach (CrudeProductCategoryImageTypeRefData data in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductCategoryImageTypeRefContract> contractList, List<CrudeProductCategoryImageTypeRefData> dataList) {
            foreach (CrudeProductCategoryImageTypeRefContract contract in contractList) {
                var data = new CrudeProductCategoryImageTypeRefData();
                CrudeProductCategoryImageTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductCategoryImageTypeRefData to a List of SOAP Contracts
        public List<CrudeProductCategoryImageTypeRefContract> FetchAll() {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAll();

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductCategoryImageTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryImageTypeRefData crudeProductCategoryImageTypeRef in dataList) {
                var contract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(crudeProductCategoryImageTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductCategoryImageTypeRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductCategoryImageTypeRefContract> FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryImageTypeRefContract>();
            List<CrudeProductCategoryImageTypeRefData> dataList = CrudeProductCategoryImageTypeRefData.FetchWithFilter(
                productCategoryImageTypeRcd: productCategoryImageTypeRcd,
                productCategoryImageTypeName: productCategoryImageTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryImageTypeRefData data in dataList) {
                var crudeProductCategoryImageTypeRefContract = new CrudeProductCategoryImageTypeRefContract();
                DataToContract(data, crudeProductCategoryImageTypeRefContract);
                list.Add(crudeProductCategoryImageTypeRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductCategoryImageTypeRefContract contract) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductCategoryImageTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductCategoryImageTypeRefContract contract) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductCategoryImageTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string productCategoryImageTypeRcd) {
            CrudeProductCategoryImageTypeRefData.Delete(productCategoryImageTypeRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductCategoryImageTypeRefContract contract, CrudeProductCategoryImageTypeRefData data) {
            data.ProductCategoryImageTypeRcd = contract.ProductCategoryImageTypeRcd;
            data.ProductCategoryImageTypeName = contract.ProductCategoryImageTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductCategoryImageTypeRefData data, CrudeProductCategoryImageTypeRefContract contract) {
            contract.ProductCategoryImageTypeRcd = data.ProductCategoryImageTypeRcd;
            contract.ProductCategoryImageTypeName = data.ProductCategoryImageTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
