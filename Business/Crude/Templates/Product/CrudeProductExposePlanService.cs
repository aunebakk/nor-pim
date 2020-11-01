/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 9:52:52 AM
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
    public partial interface ICrudeProductExposePlanService {
        
        [OperationContract()]
        CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposePlanContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposePlanContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productExposePlanId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_expose_plan's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductExposePlanService : ICrudeProductExposePlanService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productExposePlanId: primary key of table product_expose_plan
        public CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId) {
            var dataAccessLayer = new CrudeProductExposePlanData();
            var contract = new CrudeProductExposePlanContract();

            dataAccessLayer.FetchByProductExposePlanId(productExposePlanId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposePlanContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductExposePlanData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposePlanContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposePlanData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposePlanContract> FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return DataListToContractList(CrudeProductExposePlanData.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductExposePlanContract> DataListToContractList(List<CrudeProductExposePlanData> dataList) {
            var contractList = new List<CrudeProductExposePlanContract>();

            foreach (CrudeProductExposePlanData data in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductExposePlanContract> contractList, List<CrudeProductExposePlanData> dataList) {
            foreach (CrudeProductExposePlanContract contract in contractList) {
                var data = new CrudeProductExposePlanData();
                CrudeProductExposePlanService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductExposePlanData to a List of SOAP Contracts
        public List<CrudeProductExposePlanContract> FetchAll() {
            var list = new List<CrudeProductExposePlanContract>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAll();

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductExposePlanContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposePlanContract>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductExposePlanContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposePlanContract>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposePlanData crudeProductExposePlan in dataList) {
                var contract = new CrudeProductExposePlanContract();
                DataToContract(crudeProductExposePlan, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductExposePlanData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductExposePlanContract> FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposePlanContract>();
            List<CrudeProductExposePlanData> dataList = CrudeProductExposePlanData.FetchWithFilter(
                productExposePlanId: productExposePlanId,
                productId: productId,
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposePlanData data in dataList) {
                var crudeProductExposePlanContract = new CrudeProductExposePlanContract();
                DataToContract(data, crudeProductExposePlanContract);
                list.Add(crudeProductExposePlanContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductExposePlanContract contract) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductExposePlanContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductExposePlanContract contract) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductExposePlanContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposePlanData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productExposePlanId) {
            CrudeProductExposePlanData.Delete(productExposePlanId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductExposePlanContract contract, CrudeProductExposePlanData data) {
            data.ProductExposePlanId = contract.ProductExposePlanId;
            data.ProductId = contract.ProductId;
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductExposePlanData data, CrudeProductExposePlanContract contract) {
            contract.ProductExposePlanId = data.ProductExposePlanId;
            contract.ProductId = data.ProductId;
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
