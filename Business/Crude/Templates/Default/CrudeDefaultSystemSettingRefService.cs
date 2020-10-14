/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/14/2020 8:33:15 PM
  From Machine: DESKTOP-742U247
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
    public partial interface ICrudeDefaultSystemSettingRefService {
        
        [OperationContract()]
        CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingName(string defaultSystemSettingName);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultSystemSettingRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultSystemSettingRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultSystemSettingRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_system_setting_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultSystemSettingRefService : ICrudeDefaultSystemSettingRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultSystemSettingRcd: primary key of table default_system_setting_ref
        public CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            var dataAccessLayer = new CrudeDefaultSystemSettingRefData();
            var contract = new CrudeDefaultSystemSettingRefContract();

            dataAccessLayer.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingName(string defaultSystemSettingName) {
            var dataAccessLayer = new CrudeDefaultSystemSettingRefData();
            var contract = new CrudeDefaultSystemSettingRefContract();

            dataAccessLayer.FetchByDefaultSystemSettingName(defaultSystemSettingName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultSystemSettingRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultSystemSettingRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultSystemSettingRefContract> DataListToContractList(List<CrudeDefaultSystemSettingRefData> dataList) {
            var contractList = new List<CrudeDefaultSystemSettingRefContract>();

            foreach (CrudeDefaultSystemSettingRefData data in dataList) {
                var contract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultSystemSettingRefContract> contractList, List<CrudeDefaultSystemSettingRefData> dataList) {
            foreach (CrudeDefaultSystemSettingRefContract contract in contractList) {
                var data = new CrudeDefaultSystemSettingRefData();
                CrudeDefaultSystemSettingRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultSystemSettingRefData to a List of SOAP Contracts
        public List<CrudeDefaultSystemSettingRefContract> FetchAll() {
            var list = new List<CrudeDefaultSystemSettingRefContract>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAll();

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRef in dataList) {
                var contract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(crudeDefaultSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultSystemSettingRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultSystemSettingRefContract>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRef in dataList) {
                var contract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(crudeDefaultSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultSystemSettingRefContract>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultSystemSettingRefData crudeDefaultSystemSettingRef in dataList) {
                var contract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(crudeDefaultSystemSettingRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultSystemSettingRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultSystemSettingRefContract> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemSettingRefContract>();
            List<CrudeDefaultSystemSettingRefData> dataList = CrudeDefaultSystemSettingRefData.FetchWithFilter(
                defaultSystemSettingRcd: defaultSystemSettingRcd,
                defaultSystemSettingName: defaultSystemSettingName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultSystemSettingRefData data in dataList) {
                var crudeDefaultSystemSettingRefContract = new CrudeDefaultSystemSettingRefContract();
                DataToContract(data, crudeDefaultSystemSettingRefContract);
                list.Add(crudeDefaultSystemSettingRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultSystemSettingRefContract contract) {
            var data = new CrudeDefaultSystemSettingRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultSystemSettingRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultSystemSettingRefContract contract) {
            var data = new CrudeDefaultSystemSettingRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultSystemSettingRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(string defaultSystemSettingRcd) {
            CrudeDefaultSystemSettingRefData.Delete(defaultSystemSettingRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultSystemSettingRefContract contract, CrudeDefaultSystemSettingRefData data) {
            data.DefaultSystemSettingRcd = contract.DefaultSystemSettingRcd;
            data.DefaultSystemSettingName = contract.DefaultSystemSettingName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultSystemSettingRefData data, CrudeDefaultSystemSettingRefContract contract) {
            contract.DefaultSystemSettingRcd = data.DefaultSystemSettingRcd;
            contract.DefaultSystemSettingName = data.DefaultSystemSettingName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
