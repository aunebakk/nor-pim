/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:06 AM
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
    public partial interface ICrudeClientDocumentTypeRefService {
        
        [OperationContract()]
        CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd);
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeName(string clientDocumentTypeName);
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchWithFilter(string clientDocumentTypeRcd, string clientDocumentTypeName, string clientDocumentTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientDocumentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientDocumentTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientDocumentTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string clientDocumentTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_document_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientDocumentTypeRefService : ICrudeClientDocumentTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientDocumentTypeRcd: primary key of table client_document_type_ref
        public CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            var dataAccessLayer = new CrudeClientDocumentTypeRefData();
            var contract = new CrudeClientDocumentTypeRefContract();

            dataAccessLayer.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientDocumentTypeRefContract FetchByClientDocumentTypeName(string clientDocumentTypeName) {
            var dataAccessLayer = new CrudeClientDocumentTypeRefData();
            var contract = new CrudeClientDocumentTypeRefContract();

            dataAccessLayer.FetchByClientDocumentTypeName(clientDocumentTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientDocumentTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientDocumentTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeClientDocumentTypeRefContract> DataListToContractList(List<CrudeClientDocumentTypeRefData> dataList) {
            var contractList = new List<CrudeClientDocumentTypeRefContract>();

            foreach (CrudeClientDocumentTypeRefData data in dataList) {
                var contract = new CrudeClientDocumentTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientDocumentTypeRefContract> contractList, List<CrudeClientDocumentTypeRefData> dataList) {
            foreach (CrudeClientDocumentTypeRefContract contract in contractList) {
                var data = new CrudeClientDocumentTypeRefData();
                CrudeClientDocumentTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientDocumentTypeRefContract> FetchAll() {
            var list = new List<CrudeClientDocumentTypeRefContract>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAll();

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRef in dataList) {
                var contract = new CrudeClientDocumentTypeRefContract();
                DataToContract(crudeClientDocumentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientDocumentTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientDocumentTypeRefContract>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRef in dataList) {
                var contract = new CrudeClientDocumentTypeRefContract();
                DataToContract(crudeClientDocumentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientDocumentTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientDocumentTypeRefContract>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientDocumentTypeRefData crudeClientDocumentTypeRef in dataList) {
                var contract = new CrudeClientDocumentTypeRefContract();
                DataToContract(crudeClientDocumentTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientDocumentTypeRefData.FetchAllCount();
        }
        
        public List<CrudeClientDocumentTypeRefContract> FetchWithFilter(string clientDocumentTypeRcd, string clientDocumentTypeName, string clientDocumentTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientDocumentTypeRefContract>();
            List<CrudeClientDocumentTypeRefData> dataList = CrudeClientDocumentTypeRefData.FetchWithFilter(
                clientDocumentTypeRcd: clientDocumentTypeRcd,
                clientDocumentTypeName: clientDocumentTypeName,
                clientDocumentTypeDescription: clientDocumentTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientDocumentTypeRefData data in dataList) {
                var crudeClientDocumentTypeRefContract = new CrudeClientDocumentTypeRefContract();
                DataToContract(data, crudeClientDocumentTypeRefContract);
                list.Add(crudeClientDocumentTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientDocumentTypeRefContract contract) {
            var data = new CrudeClientDocumentTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientDocumentTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientDocumentTypeRefContract contract) {
            var data = new CrudeClientDocumentTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientDocumentTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string clientDocumentTypeRcd) {
            CrudeClientDocumentTypeRefData.Delete(clientDocumentTypeRcd);
        }
        
        public static void ContractToData(CrudeClientDocumentTypeRefContract contract, CrudeClientDocumentTypeRefData data) {
            data.ClientDocumentTypeRcd = contract.ClientDocumentTypeRcd;
            data.ClientDocumentTypeName = contract.ClientDocumentTypeName;
            data.ClientDocumentTypeDescription = contract.ClientDocumentTypeDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientDocumentTypeRefData data, CrudeClientDocumentTypeRefContract contract) {
            contract.ClientDocumentTypeRcd = data.ClientDocumentTypeRcd;
            contract.ClientDocumentTypeName = data.ClientDocumentTypeName;
            contract.ClientDocumentTypeDescription = data.ClientDocumentTypeDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
