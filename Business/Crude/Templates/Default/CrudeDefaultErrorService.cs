/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 5:17:13 AM
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
    public partial interface ICrudeDefaultErrorService {
        
        [OperationContract()]
        CrudeDefaultErrorContract FetchByDefaultErrorId(System.Guid defaultErrorId);
        
        [OperationContract()]
        List<CrudeDefaultErrorContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultErrorContract> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd);
        
        [OperationContract()]
        List<CrudeDefaultErrorContract> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd);
        
        [OperationContract()]
        CrudeDefaultErrorContract FetchByMethodName(string methodName);
        
        [OperationContract()]
        List<CrudeDefaultErrorContract> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultErrorContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultErrorContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultErrorContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultErrorContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultErrorContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultErrorId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_error's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultErrorService : ICrudeDefaultErrorService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultErrorId: primary key of table default_error
        public CrudeDefaultErrorContract FetchByDefaultErrorId(System.Guid defaultErrorId) {
            var dataAccessLayer = new CrudeDefaultErrorData();
            var contract = new CrudeDefaultErrorContract();

            dataAccessLayer.FetchByDefaultErrorId(defaultErrorId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultErrorContract FetchByMethodName(string methodName) {
            var dataAccessLayer = new CrudeDefaultErrorData();
            var contract = new CrudeDefaultErrorContract();

            dataAccessLayer.FetchByMethodName(methodName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultErrorContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultErrorData.FetchByDefaultUserId(defaultUserId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultErrorContract> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            return DataListToContractList(CrudeDefaultErrorData.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultErrorContract> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            return DataListToContractList(CrudeDefaultErrorData.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeDefaultErrorContract> DataListToContractList(List<CrudeDefaultErrorData> dataList) {
            var contractList = new List<CrudeDefaultErrorContract>();

            foreach (CrudeDefaultErrorData data in dataList) {
                var contract = new CrudeDefaultErrorContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeDefaultErrorContract> contractList, List<CrudeDefaultErrorData> dataList) {
            foreach (CrudeDefaultErrorContract contract in contractList) {
                var data = new CrudeDefaultErrorData();
                CrudeDefaultErrorService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeDefaultErrorData to a List of SOAP Contracts
        public List<CrudeDefaultErrorContract> FetchAll() {
            var list = new List<CrudeDefaultErrorContract>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAll();

            foreach (CrudeDefaultErrorData crudeDefaultError in dataList) {
                var contract = new CrudeDefaultErrorContract();
                DataToContract(crudeDefaultError, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeDefaultErrorContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultErrorContract>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultErrorData crudeDefaultError in dataList) {
                var contract = new CrudeDefaultErrorContract();
                DataToContract(crudeDefaultError, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeDefaultErrorContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultErrorContract>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultErrorData crudeDefaultError in dataList) {
                var contract = new CrudeDefaultErrorContract();
                DataToContract(crudeDefaultError, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeDefaultErrorData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeDefaultErrorContract> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorContract>();
            List<CrudeDefaultErrorData> dataList = CrudeDefaultErrorData.FetchWithFilter(
                defaultErrorId: defaultErrorId,
                defaultErrorLayerRcd: defaultErrorLayerRcd,
                defaultErrorTypeRcd: defaultErrorTypeRcd,
                layerAddress: layerAddress,
                errorMessage: errorMessage,
                stackTrace: stackTrace,
                methodName: methodName,
                domainName: domainName,
                className: className,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultErrorData data in dataList) {
                var crudeDefaultErrorContract = new CrudeDefaultErrorContract();
                DataToContract(data, crudeDefaultErrorContract);
                list.Add(crudeDefaultErrorContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeDefaultErrorContract contract) {
            var data = new CrudeDefaultErrorData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeDefaultErrorContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeDefaultErrorContract contract) {
            var data = new CrudeDefaultErrorData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeDefaultErrorContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid defaultErrorId) {
            CrudeDefaultErrorData.Delete(defaultErrorId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeDefaultErrorContract contract, CrudeDefaultErrorData data) {
            data.DefaultErrorId = contract.DefaultErrorId;
            data.DefaultErrorLayerRcd = contract.DefaultErrorLayerRcd;
            data.DefaultErrorTypeRcd = contract.DefaultErrorTypeRcd;
            data.LayerAddress = contract.LayerAddress;
            data.ErrorMessage = contract.ErrorMessage;
            data.StackTrace = contract.StackTrace;
            data.MethodName = contract.MethodName;
            data.DomainName = contract.DomainName;
            data.ClassName = contract.ClassName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeDefaultErrorData data, CrudeDefaultErrorContract contract) {
            contract.DefaultErrorId = data.DefaultErrorId;
            contract.DefaultErrorLayerRcd = data.DefaultErrorLayerRcd;
            contract.DefaultErrorTypeRcd = data.DefaultErrorTypeRcd;
            contract.LayerAddress = data.LayerAddress;
            contract.ErrorMessage = data.ErrorMessage;
            contract.StackTrace = data.StackTrace;
            contract.MethodName = data.MethodName;
            contract.DomainName = data.DomainName;
            contract.ClassName = data.ClassName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
