/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:07 AM
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
    public partial interface ICrudeClientGenderRefService {
        
        [OperationContract()]
        CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientGenderRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientGenderRefContract contract);
        
        [OperationContract()]
        void Delete(string clientGenderRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_gender_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientGenderRefService : ICrudeClientGenderRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientGenderRcd: primary key of table client_gender_ref
        public CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd) {
            var dataAccessLayer = new CrudeClientGenderRefData();
            var contract = new CrudeClientGenderRefContract();

            dataAccessLayer.FetchByClientGenderRcd(clientGenderRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName) {
            var dataAccessLayer = new CrudeClientGenderRefData();
            var contract = new CrudeClientGenderRefContract();

            dataAccessLayer.FetchByClientGenderName(clientGenderName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientGenderRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientGenderRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientGenderRefContract> DataListToContractList(List<CrudeClientGenderRefData> dataList) {
            var contractList = new List<CrudeClientGenderRefContract>();

            foreach (CrudeClientGenderRefData data in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientGenderRefContract> contractList, List<CrudeClientGenderRefData> dataList) {
            foreach (CrudeClientGenderRefContract contract in contractList) {
                var data = new CrudeClientGenderRefData();
                CrudeClientGenderRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientGenderRefContract> FetchAll() {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAll();

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientGenderRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientGenderRefData.FetchAllCount();
        }
        
        public List<CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchWithFilter(
                clientGenderRcd: clientGenderRcd,
                clientGenderName: clientGenderName,
                clientGenderDescription: clientGenderDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientGenderRefData data in dataList) {
                var crudeClientGenderRefContract = new CrudeClientGenderRefContract();
                DataToContract(data, crudeClientGenderRefContract);
                list.Add(crudeClientGenderRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientGenderRefContract contract) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientGenderRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientGenderRefContract contract) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientGenderRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientGenderRcd) {
            CrudeClientGenderRefData.Delete(clientGenderRcd);
        }
        
        public static void ContractToData(CrudeClientGenderRefContract contract, CrudeClientGenderRefData data) {
            data.ClientGenderRcd = contract.ClientGenderRcd;
            data.ClientGenderName = contract.ClientGenderName;
            data.ClientGenderDescription = contract.ClientGenderDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientGenderRefData data, CrudeClientGenderRefContract contract) {
            contract.ClientGenderRcd = data.ClientGenderRcd;
            contract.ClientGenderName = data.ClientGenderName;
            contract.ClientGenderDescription = data.ClientGenderDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
