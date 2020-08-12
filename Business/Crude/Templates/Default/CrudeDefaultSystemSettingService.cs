/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:11 AM
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
    public partial interface ICrudeDefaultSystemSettingService {
        
        [OperationContract()]
        CrudeDefaultSystemSettingContract FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingContract> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingContract> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultSystemSettingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultSystemSettingContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultSystemSettingContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultSystemSettingId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of default_system_setting's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeDefaultSystemSettingService : ICrudeDefaultSystemSettingService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   defaultSystemSettingId: primary key of table default_system_setting
        public CrudeDefaultSystemSettingContract FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId) {
            var dataAccessLayer = new CrudeDefaultSystemSettingData();
            var contract = new CrudeDefaultSystemSettingContract();

            dataAccessLayer.FetchByDefaultSystemSettingId(defaultSystemSettingId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultSystemSettingContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return DataListToContractList(CrudeDefaultSystemSettingData.FetchByDefaultUserId(defaultUserId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeDefaultSystemSettingContract> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            return DataListToContractList(CrudeDefaultSystemSettingData.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd));
        }
        
        public static List<CrudeDefaultSystemSettingContract> DataListToContractList(List<CrudeDefaultSystemSettingData> dataList) {
            var contractList = new List<CrudeDefaultSystemSettingContract>();

            foreach (CrudeDefaultSystemSettingData data in dataList) {
                var contract = new CrudeDefaultSystemSettingContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultSystemSettingContract> contractList, List<CrudeDefaultSystemSettingData> dataList) {
            foreach (CrudeDefaultSystemSettingContract contract in contractList) {
                var data = new CrudeDefaultSystemSettingData();
                CrudeDefaultSystemSettingService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultSystemSettingContract> FetchAll() {
            var list = new List<CrudeDefaultSystemSettingContract>();
            List<CrudeDefaultSystemSettingData> dataList = CrudeDefaultSystemSettingData.FetchAll();

            foreach (CrudeDefaultSystemSettingData crudeDefaultSystemSetting in dataList) {
                var contract = new CrudeDefaultSystemSettingContract();
                DataToContract(crudeDefaultSystemSetting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemSettingContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultSystemSettingContract>();
            List<CrudeDefaultSystemSettingData> dataList = CrudeDefaultSystemSettingData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultSystemSettingData crudeDefaultSystemSetting in dataList) {
                var contract = new CrudeDefaultSystemSettingContract();
                DataToContract(crudeDefaultSystemSetting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultSystemSettingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultSystemSettingContract>();
            List<CrudeDefaultSystemSettingData> dataList = CrudeDefaultSystemSettingData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultSystemSettingData crudeDefaultSystemSetting in dataList) {
                var contract = new CrudeDefaultSystemSettingContract();
                DataToContract(crudeDefaultSystemSetting, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultSystemSettingData.FetchAllCount();
        }
        
        public List<CrudeDefaultSystemSettingContract> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime) {
            var list = new List<CrudeDefaultSystemSettingContract>();
            List<CrudeDefaultSystemSettingData> dataList = CrudeDefaultSystemSettingData.FetchWithFilter(
                defaultSystemSettingId: defaultSystemSettingId,
                defaultSystemSettingRcd: defaultSystemSettingRcd,
                defaultSystemSettingValue: defaultSystemSettingValue,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );

            foreach (CrudeDefaultSystemSettingData data in dataList) {
                var crudeDefaultSystemSettingContract = new CrudeDefaultSystemSettingContract();
                DataToContract(data, crudeDefaultSystemSettingContract);
                list.Add(crudeDefaultSystemSettingContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultSystemSettingContract contract) {
            var data = new CrudeDefaultSystemSettingData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultSystemSettingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultSystemSettingContract contract) {
            var data = new CrudeDefaultSystemSettingData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultSystemSettingContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultSystemSettingData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultSystemSettingId) {
            CrudeDefaultSystemSettingData.Delete(defaultSystemSettingId);
        }
        
        public static void ContractToData(CrudeDefaultSystemSettingContract contract, CrudeDefaultSystemSettingData data) {
            data.DefaultSystemSettingId = contract.DefaultSystemSettingId;
            data.DefaultSystemSettingRcd = contract.DefaultSystemSettingRcd;
            data.DefaultSystemSettingValue = contract.DefaultSystemSettingValue;
            data.DefaultUserId = contract.DefaultUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeDefaultSystemSettingData data, CrudeDefaultSystemSettingContract contract) {
            contract.DefaultSystemSettingId = data.DefaultSystemSettingId;
            contract.DefaultSystemSettingRcd = data.DefaultSystemSettingRcd;
            contract.DefaultSystemSettingValue = data.DefaultSystemSettingValue;
            contract.DefaultUserId = data.DefaultUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
