/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 4:18:39 PM
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
    public partial interface ICrudeProductGatherAttributeService {
        
        [OperationContract()]
        CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherAttributeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherAttributeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productGatherAttributeId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_gather_attribute's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductGatherAttributeService : ICrudeProductGatherAttributeService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productGatherAttributeId: primary key of table product_gather_attribute
        public CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            var dataAccessLayer = new CrudeProductGatherAttributeData();
            var contract = new CrudeProductGatherAttributeContract();

            dataAccessLayer.FetchByProductGatherAttributeId(productGatherAttributeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherAttributeContract> FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return DataListToContractList(CrudeProductGatherAttributeData.FetchByProductGatherKeyId(productGatherKeyId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherAttributeContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherAttributeData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherAttributeContract> FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            return DataListToContractList(CrudeProductGatherAttributeData.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductGatherAttributeContract> DataListToContractList(List<CrudeProductGatherAttributeData> dataList) {
            var contractList = new List<CrudeProductGatherAttributeContract>();

            foreach (CrudeProductGatherAttributeData data in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductGatherAttributeContract> contractList, List<CrudeProductGatherAttributeData> dataList) {
            foreach (CrudeProductGatherAttributeContract contract in contractList) {
                var data = new CrudeProductGatherAttributeData();
                CrudeProductGatherAttributeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductGatherAttributeData to a List of SOAP Contracts
        public List<CrudeProductGatherAttributeContract> FetchAll() {
            var list = new List<CrudeProductGatherAttributeContract>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAll();

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductGatherAttributeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherAttributeContract>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductGatherAttributeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherAttributeContract>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherAttributeData crudeProductGatherAttribute in dataList) {
                var contract = new CrudeProductGatherAttributeContract();
                DataToContract(crudeProductGatherAttribute, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductGatherAttributeData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductGatherAttributeContract> FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherAttributeContract>();
            List<CrudeProductGatherAttributeData> dataList = CrudeProductGatherAttributeData.FetchWithFilter(
                productGatherAttributeId: productGatherAttributeId,
                productGatherAttributeValue: productGatherAttributeValue,
                productGatherAttributeTypeRcd: productGatherAttributeTypeRcd,
                productGatherKeyId: productGatherKeyId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherAttributeData data in dataList) {
                var crudeProductGatherAttributeContract = new CrudeProductGatherAttributeContract();
                DataToContract(data, crudeProductGatherAttributeContract);
                list.Add(crudeProductGatherAttributeContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductGatherAttributeContract contract) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductGatherAttributeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductGatherAttributeContract contract) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductGatherAttributeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherAttributeData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productGatherAttributeId) {
            CrudeProductGatherAttributeData.Delete(productGatherAttributeId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductGatherAttributeContract contract, CrudeProductGatherAttributeData data) {
            data.ProductGatherAttributeId = contract.ProductGatherAttributeId;
            data.ProductGatherAttributeValue = contract.ProductGatherAttributeValue;
            data.ProductGatherAttributeTypeRcd = contract.ProductGatherAttributeTypeRcd;
            data.ProductGatherKeyId = contract.ProductGatherKeyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductGatherAttributeData data, CrudeProductGatherAttributeContract contract) {
            contract.ProductGatherAttributeId = data.ProductGatherAttributeId;
            contract.ProductGatherAttributeValue = data.ProductGatherAttributeValue;
            contract.ProductGatherAttributeTypeRcd = data.ProductGatherAttributeTypeRcd;
            contract.ProductGatherKeyId = data.ProductGatherKeyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
