/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/1/2020 4:11:53 PM
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
    public partial interface ICrudeDefaultUserActivityService {
        
        [OperationContract()]
        CrudeDefaultUserActivityContract FetchByDefaultUserActivityId(System.Guid defaultUserActivityId);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultUserActivityContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultUserActivityContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultUserActivityContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultUserActivityId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_user_activity's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultUserActivityService : ICrudeDefaultUserActivityService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultUserActivityId: primary key of table default_user_activity
        public CrudeDefaultUserActivityContract FetchByDefaultUserActivityId(System.Guid defaultUserActivityId) {
            var dataAccessLayer = new CrudeDefaultUserActivityData();
            var contract = new CrudeDefaultUserActivityContract();

            dataAccessLayer.FetchByDefaultUserActivityId(defaultUserActivityId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultUserActivityContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultUserActivityData.FetchByDefaultUserId(defaultUserId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultUserActivityContract> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            return DataListToContractList(CrudeDefaultUserActivityData.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultUserActivityContract> DataListToContractList(List<CrudeDefaultUserActivityData> dataList) {
            var contractList = new List<CrudeDefaultUserActivityContract>();

            foreach (CrudeDefaultUserActivityData data in dataList) {
                var contract = new CrudeDefaultUserActivityContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultUserActivityContract> contractList, List<CrudeDefaultUserActivityData> dataList) {
            foreach (CrudeDefaultUserActivityContract contract in contractList) {
                var data = new CrudeDefaultUserActivityData();
                CrudeDefaultUserActivityService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultUserActivityData to a List of SOAP Contracts
        public List<CrudeDefaultUserActivityContract> FetchAll() {
            var list = new List<CrudeDefaultUserActivityContract>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAll();

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivity in dataList) {
                var contract = new CrudeDefaultUserActivityContract();
                DataToContract(crudeDefaultUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultUserActivityContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultUserActivityContract>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivity in dataList) {
                var contract = new CrudeDefaultUserActivityContract();
                DataToContract(crudeDefaultUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultUserActivityContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultUserActivityContract>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultUserActivityData crudeDefaultUserActivity in dataList) {
                var contract = new CrudeDefaultUserActivityContract();
                DataToContract(crudeDefaultUserActivity, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultUserActivityData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultUserActivityContract> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultUserActivityContract>();
            List<CrudeDefaultUserActivityData> dataList = CrudeDefaultUserActivityData.FetchWithFilter(
                defaultUserActivityId: defaultUserActivityId,
                defaultUserActivityTypeRcd: defaultUserActivityTypeRcd,
                userActivityNote: userActivityNote,
                originatingAddress: originatingAddress,
                referrer: referrer,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultUserActivityData data in dataList) {
                var crudeDefaultUserActivityContract = new CrudeDefaultUserActivityContract();
                DataToContract(data, crudeDefaultUserActivityContract);
                list.Add(crudeDefaultUserActivityContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultUserActivityContract contract) {
            var data = new CrudeDefaultUserActivityData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultUserActivityContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultUserActivityContract contract) {
            var data = new CrudeDefaultUserActivityData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultUserActivityContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserActivityData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultUserActivityId) {
            CrudeDefaultUserActivityData.Delete(defaultUserActivityId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultUserActivityContract contract, CrudeDefaultUserActivityData data) {
            data.DefaultUserActivityId = contract.DefaultUserActivityId;
            data.DefaultUserActivityTypeRcd = contract.DefaultUserActivityTypeRcd;
            data.UserActivityNote = contract.UserActivityNote;
            data.OriginatingAddress = contract.OriginatingAddress;
            data.Referrer = contract.Referrer;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultUserActivityData data, CrudeDefaultUserActivityContract contract) {
            contract.DefaultUserActivityId = data.DefaultUserActivityId;
            contract.DefaultUserActivityTypeRcd = data.DefaultUserActivityTypeRcd;
            contract.UserActivityNote = data.UserActivityNote;
            contract.OriginatingAddress = data.OriginatingAddress;
            contract.Referrer = data.Referrer;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
