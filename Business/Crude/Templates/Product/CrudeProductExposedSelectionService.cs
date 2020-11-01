/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 12:52:51 PM
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
    public partial interface ICrudeProductExposedSelectionService {
        
        [OperationContract()]
        CrudeProductExposedSelectionContract FetchByProductExposedSelectionId(System.Guid productExposedSelectionId);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchByProductExposeId(System.Guid productExposeId);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposedSelectionContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposedSelectionContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productExposedSelectionId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_exposed_selection's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductExposedSelectionService : ICrudeProductExposedSelectionService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productExposedSelectionId: primary key of table product_exposed_selection
        public CrudeProductExposedSelectionContract FetchByProductExposedSelectionId(System.Guid productExposedSelectionId) {
            var dataAccessLayer = new CrudeProductExposedSelectionData();
            var contract = new CrudeProductExposedSelectionContract();

            dataAccessLayer.FetchByProductExposedSelectionId(productExposedSelectionId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposedSelectionContract> FetchByProductExposeId(System.Guid productExposeId) {
            return DataListToContractList(CrudeProductExposedSelectionData.FetchByProductExposeId(productExposeId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposedSelectionContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposedSelectionData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductExposedSelectionContract> DataListToContractList(List<CrudeProductExposedSelectionData> dataList) {
            var contractList = new List<CrudeProductExposedSelectionContract>();

            foreach (CrudeProductExposedSelectionData data in dataList) {
                var contract = new CrudeProductExposedSelectionContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductExposedSelectionContract> contractList, List<CrudeProductExposedSelectionData> dataList) {
            foreach (CrudeProductExposedSelectionContract contract in contractList) {
                var data = new CrudeProductExposedSelectionData();
                CrudeProductExposedSelectionService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductExposedSelectionData to a List of SOAP Contracts
        public List<CrudeProductExposedSelectionContract> FetchAll() {
            var list = new List<CrudeProductExposedSelectionContract>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAll();

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelection in dataList) {
                var contract = new CrudeProductExposedSelectionContract();
                DataToContract(crudeProductExposedSelection, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductExposedSelectionContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposedSelectionContract>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelection in dataList) {
                var contract = new CrudeProductExposedSelectionContract();
                DataToContract(crudeProductExposedSelection, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductExposedSelectionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposedSelectionContract>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelection in dataList) {
                var contract = new CrudeProductExposedSelectionContract();
                DataToContract(crudeProductExposedSelection, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductExposedSelectionData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductExposedSelectionContract> FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposedSelectionContract>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchWithFilter(
                productExposedSelectionId: productExposedSelectionId,
                productExposeId: productExposeId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposedSelectionData data in dataList) {
                var crudeProductExposedSelectionContract = new CrudeProductExposedSelectionContract();
                DataToContract(data, crudeProductExposedSelectionContract);
                list.Add(crudeProductExposedSelectionContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductExposedSelectionContract contract) {
            var data = new CrudeProductExposedSelectionData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductExposedSelectionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposedSelectionData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductExposedSelectionContract contract) {
            var data = new CrudeProductExposedSelectionData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductExposedSelectionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposedSelectionData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productExposedSelectionId) {
            CrudeProductExposedSelectionData.Delete(productExposedSelectionId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductExposedSelectionContract contract, CrudeProductExposedSelectionData data) {
            data.ProductExposedSelectionId = contract.ProductExposedSelectionId;
            data.ProductExposeId = contract.ProductExposeId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductExposedSelectionData data, CrudeProductExposedSelectionContract contract) {
            contract.ProductExposedSelectionId = data.ProductExposedSelectionId;
            contract.ProductExposeId = data.ProductExposeId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
