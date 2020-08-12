/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:09 AM
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
    public partial interface ICrudeDefaultErrorLayerRefService {
        
        [OperationContract()]
        CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd);
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerName(string defaultErrorLayerName);
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultErrorLayerRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultErrorLayerRefContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultErrorLayerRefContract contract);
        
        [OperationContract()]
        void Delete(string defaultErrorLayerRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_error_layer_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultErrorLayerRefService : ICrudeDefaultErrorLayerRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultErrorLayerRcd: primary key of table default_error_layer_ref
        public CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            var dataAccessLayer = new CrudeDefaultErrorLayerRefData();
            var contract = new CrudeDefaultErrorLayerRefContract();

            dataAccessLayer.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerName(string defaultErrorLayerName) {
            var dataAccessLayer = new CrudeDefaultErrorLayerRefData();
            var contract = new CrudeDefaultErrorLayerRefContract();

            dataAccessLayer.FetchByDefaultErrorLayerName(defaultErrorLayerName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultErrorLayerRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultErrorLayerRefData.FetchByDefaultUserId(defaultUserId));
        }
        
        public static List<CrudeDefaultErrorLayerRefContract> DataListToContractList(List<CrudeDefaultErrorLayerRefData> dataList) {
            var contractList = new List<CrudeDefaultErrorLayerRefContract>();

            foreach (CrudeDefaultErrorLayerRefData data in dataList) {
                var contract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultErrorLayerRefContract> contractList, List<CrudeDefaultErrorLayerRefData> dataList) {
            foreach (CrudeDefaultErrorLayerRefContract contract in contractList) {
                var data = new CrudeDefaultErrorLayerRefData();
                CrudeDefaultErrorLayerRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchAll() {
            var list = new List<CrudeDefaultErrorLayerRefContract>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAll();

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRef in dataList) {
                var contract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(crudeDefaultErrorLayerRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultErrorLayerRefContract>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRef in dataList) {
                var contract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(crudeDefaultErrorLayerRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultErrorLayerRefContract>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultErrorLayerRefData crudeDefaultErrorLayerRef in dataList) {
                var contract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(crudeDefaultErrorLayerRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultErrorLayerRefData.FetchAllCount();
        }
        
        public List<CrudeDefaultErrorLayerRefContract> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultErrorLayerRefContract>();
            List<CrudeDefaultErrorLayerRefData> dataList = CrudeDefaultErrorLayerRefData.FetchWithFilter(
                defaultErrorLayerRcd: defaultErrorLayerRcd,
                defaultErrorLayerName: defaultErrorLayerName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultErrorLayerRefData data in dataList) {
                var crudeDefaultErrorLayerRefContract = new CrudeDefaultErrorLayerRefContract();
                DataToContract(data, crudeDefaultErrorLayerRefContract);
                list.Add(crudeDefaultErrorLayerRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultErrorLayerRefContract contract) {
            var data = new CrudeDefaultErrorLayerRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultErrorLayerRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorLayerRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultErrorLayerRefContract contract) {
            var data = new CrudeDefaultErrorLayerRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultErrorLayerRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultErrorLayerRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string defaultErrorLayerRcd) {
            CrudeDefaultErrorLayerRefData.Delete(defaultErrorLayerRcd);
        }
        
        public static void ContractToData(CrudeDefaultErrorLayerRefContract contract, CrudeDefaultErrorLayerRefData data) {
            data.DefaultErrorLayerRcd = contract.DefaultErrorLayerRcd;
            data.DefaultErrorLayerName = contract.DefaultErrorLayerName;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultErrorLayerRefData data, CrudeDefaultErrorLayerRefContract contract) {
            contract.DefaultErrorLayerRcd = data.DefaultErrorLayerRcd;
            contract.DefaultErrorLayerName = data.DefaultErrorLayerName;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
