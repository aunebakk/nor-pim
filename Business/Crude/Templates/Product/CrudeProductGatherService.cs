/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:47:46 AM
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
    public partial interface ICrudeProductGatherService {
        
        [OperationContract()]
        CrudeProductGatherContract FetchByProductGatherId(System.Guid productGatherId);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productGatherId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_gather's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductGatherService : ICrudeProductGatherService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productGatherId: primary key of table product_gather
        public CrudeProductGatherContract FetchByProductGatherId(System.Guid productGatherId) {
            var dataAccessLayer = new CrudeProductGatherData();
            var contract = new CrudeProductGatherContract();

            dataAccessLayer.FetchByProductGatherId(productGatherId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductGatherContract> DataListToContractList(List<CrudeProductGatherData> dataList) {
            var contractList = new List<CrudeProductGatherContract>();

            foreach (CrudeProductGatherData data in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductGatherContract> contractList, List<CrudeProductGatherData> dataList) {
            foreach (CrudeProductGatherContract contract in contractList) {
                var data = new CrudeProductGatherData();
                CrudeProductGatherService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductGatherData to a List of SOAP Contracts
        public List<CrudeProductGatherContract> FetchAll() {
            var list = new List<CrudeProductGatherContract>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAll();

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductGatherContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherContract>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductGatherContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherContract>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherData crudeProductGather in dataList) {
                var contract = new CrudeProductGatherContract();
                DataToContract(crudeProductGather, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductGatherData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductGatherContract> FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherContract>();
            List<CrudeProductGatherData> dataList = CrudeProductGatherData.FetchWithFilter(
                productGatherId: productGatherId,
                startDateTime: startDateTime,
                finishDateTime: finishDateTime,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherData data in dataList) {
                var crudeProductGatherContract = new CrudeProductGatherContract();
                DataToContract(data, crudeProductGatherContract);
                list.Add(crudeProductGatherContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductGatherContract contract) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductGatherContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductGatherContract contract) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductGatherContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productGatherId) {
            CrudeProductGatherData.Delete(productGatherId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductGatherContract contract, CrudeProductGatherData data) {
            data.ProductGatherId = contract.ProductGatherId;
            data.StartDateTime = contract.StartDateTime;
            data.FinishDateTime = contract.FinishDateTime;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductGatherData data, CrudeProductGatherContract contract) {
            contract.ProductGatherId = data.ProductGatherId;
            contract.StartDateTime = data.StartDateTime;
            contract.FinishDateTime = data.FinishDateTime;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
