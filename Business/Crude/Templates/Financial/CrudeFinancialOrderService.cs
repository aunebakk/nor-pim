/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:13 AM
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
    public partial interface ICrudeFinancialOrderService {
        
        [OperationContract()]
        CrudeFinancialOrderContract FetchByFinancialOrderId(System.Guid financialOrderId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByLocationAddressId(System.Guid locationAddressId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialOrderContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialOrderContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialOrderContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialOrderId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of financial_order's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeFinancialOrderService : ICrudeFinancialOrderService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   financialOrderId: primary key of table financial_order
        public CrudeFinancialOrderContract FetchByFinancialOrderId(System.Guid financialOrderId) {
            var dataAccessLayer = new CrudeFinancialOrderData();
            var contract = new CrudeFinancialOrderContract();

            dataAccessLayer.FetchByFinancialOrderId(financialOrderId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeFinancialOrderContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeFinancialOrderContract> FetchByLocationAddressId(System.Guid locationAddressId) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByLocationAddressId(locationAddressId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeFinancialOrderContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeFinancialOrderContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByClientId(clientId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeFinancialOrderContract> FetchByFinancialOrderSourceRcd(string financialOrderSourceRcd) {
            return DataListToContractList(CrudeFinancialOrderData.FetchByFinancialOrderSourceRcd(financialOrderSourceRcd));
        }
        
        public static List<CrudeFinancialOrderContract> DataListToContractList(List<CrudeFinancialOrderData> dataList) {
            var contractList = new List<CrudeFinancialOrderContract>();

            foreach (CrudeFinancialOrderData data in dataList) {
                var contract = new CrudeFinancialOrderContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialOrderContract> contractList, List<CrudeFinancialOrderData> dataList) {
            foreach (CrudeFinancialOrderContract contract in contractList) {
                var data = new CrudeFinancialOrderData();
                CrudeFinancialOrderService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialOrderContract> FetchAll() {
            var list = new List<CrudeFinancialOrderContract>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAll();

            foreach (CrudeFinancialOrderData crudeFinancialOrder in dataList) {
                var contract = new CrudeFinancialOrderContract();
                DataToContract(crudeFinancialOrder, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialOrderContract>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialOrderData crudeFinancialOrder in dataList) {
                var contract = new CrudeFinancialOrderContract();
                DataToContract(crudeFinancialOrder, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialOrderContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialOrderContract>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialOrderData crudeFinancialOrder in dataList) {
                var contract = new CrudeFinancialOrderContract();
                DataToContract(crudeFinancialOrder, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialOrderData.FetchAllCount();
        }
        
        public List<CrudeFinancialOrderContract> FetchWithFilter(System.Guid financialOrderId, System.Guid userId, System.DateTime dateTime, string comment, System.Guid locationAddressId, System.Guid financialCurrencyId, string financialOrderSourceRcd, System.Guid clientId) {
            var list = new List<CrudeFinancialOrderContract>();
            List<CrudeFinancialOrderData> dataList = CrudeFinancialOrderData.FetchWithFilter(
                financialOrderId: financialOrderId,
                userId: userId,
                dateTime: dateTime,
                comment: comment,
                locationAddressId: locationAddressId,
                financialCurrencyId: financialCurrencyId,
                financialOrderSourceRcd: financialOrderSourceRcd,
                clientId: clientId
                );

            foreach (CrudeFinancialOrderData data in dataList) {
                var crudeFinancialOrderContract = new CrudeFinancialOrderContract();
                DataToContract(data, crudeFinancialOrderContract);
                list.Add(crudeFinancialOrderContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialOrderContract contract) {
            var data = new CrudeFinancialOrderData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialOrderContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialOrderContract contract) {
            var data = new CrudeFinancialOrderData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialOrderContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialOrderData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialOrderId) {
            CrudeFinancialOrderData.Delete(financialOrderId);
        }
        
        public static void ContractToData(CrudeFinancialOrderContract contract, CrudeFinancialOrderData data) {
            data.FinancialOrderId = contract.FinancialOrderId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.Comment = contract.Comment;
            data.LocationAddressId = contract.LocationAddressId;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.FinancialOrderSourceRcd = contract.FinancialOrderSourceRcd;
            data.ClientId = contract.ClientId;
        }
        
        public static void DataToContract(CrudeFinancialOrderData data, CrudeFinancialOrderContract contract) {
            contract.FinancialOrderId = data.FinancialOrderId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.Comment = data.Comment;
            contract.LocationAddressId = data.LocationAddressId;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.FinancialOrderSourceRcd = data.FinancialOrderSourceRcd;
            contract.ClientId = data.ClientId;
        }
    }
}
