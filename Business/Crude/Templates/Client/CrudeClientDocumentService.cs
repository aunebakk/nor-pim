/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:52:54 AM
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

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [ServiceContract()]
    public partial interface ICrudeClientDocumentService {
        
        [OperationContract()]
        CrudeClientDocumentContract FetchByClientDocumentId(System.Guid clientDocumentId);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd);
        
        [OperationContract()]
        CrudeClientDocumentContract FetchByDocumentName(string documentName);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientDocumentContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientDocumentContract contract);
        
        [OperationContract()]
        void Update(CrudeClientDocumentContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientDocumentId);
    }
    
    public partial class CrudeClientDocumentService : ICrudeClientDocumentService {
        
        public CrudeClientDocumentContract FetchByClientDocumentId(System.Guid clientDocumentId) {
            var dataAccessLayer = new CrudeClientDocumentData();
            var contract = new CrudeClientDocumentContract();

            dataAccessLayer.FetchByClientDocumentId(clientDocumentId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientDocumentContract FetchByDocumentName(string documentName) {
            var dataAccessLayer = new CrudeClientDocumentData();
            var contract = new CrudeClientDocumentContract();

            dataAccessLayer.FetchByDocumentName(documentName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientDocumentContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientDocumentData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientDocumentContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientDocumentData.FetchByUserId(userId));
        }
        
        public List<CrudeClientDocumentContract> FetchByClientDocumentTypeRcd(string clientDocumentTypeRcd) {
            return DataListToContractList(CrudeClientDocumentData.FetchByClientDocumentTypeRcd(clientDocumentTypeRcd));
        }
        
        public static List<CrudeClientDocumentContract> DataListToContractList(List<CrudeClientDocumentData> dataList) {
            var contractList = new List<CrudeClientDocumentContract>();

            foreach (CrudeClientDocumentData data in dataList) {
                var contract = new CrudeClientDocumentContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientDocumentContract> contractList, List<CrudeClientDocumentData> dataList) {
            foreach (CrudeClientDocumentContract contract in contractList) {
                var data = new CrudeClientDocumentData();
                CrudeClientDocumentService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientDocumentContract> FetchAll() {
            var list = new List<CrudeClientDocumentContract>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAll();

            foreach (CrudeClientDocumentData crudeClientDocument in dataList) {
                var contract = new CrudeClientDocumentContract();
                DataToContract(crudeClientDocument, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientDocumentContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientDocumentContract>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAllWithLimit(limit);

            foreach (CrudeClientDocumentData crudeClientDocument in dataList) {
                var contract = new CrudeClientDocumentContract();
                DataToContract(crudeClientDocument, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientDocumentContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientDocumentContract>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientDocumentData crudeClientDocument in dataList) {
                var contract = new CrudeClientDocumentContract();
                DataToContract(crudeClientDocument, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientDocumentData.FetchAllCount();
        }
        
        public List<CrudeClientDocumentContract> FetchWithFilter(System.Guid clientDocumentId, System.Guid clientId, string clientDocumentTypeRcd, string documentName, System.DateTime documentDateTime, System.DateTime expiryDateTime, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientDocumentContract>();
            List<CrudeClientDocumentData> dataList = CrudeClientDocumentData.FetchWithFilter(
                clientDocumentId: clientDocumentId,
                clientId: clientId,
                clientDocumentTypeRcd: clientDocumentTypeRcd,
                documentName: documentName,
                documentDateTime: documentDateTime,
                expiryDateTime: expiryDateTime,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientDocumentData data in dataList) {
                var crudeClientDocumentContract = new CrudeClientDocumentContract();
                DataToContract(data, crudeClientDocumentContract);
                list.Add(crudeClientDocumentContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientDocumentContract contract) {
            var data = new CrudeClientDocumentData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientDocumentContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientDocumentContract contract) {
            var data = new CrudeClientDocumentData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientDocumentContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientDocumentData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientDocumentId) {
            CrudeClientDocumentData.Delete(clientDocumentId);
        }
        
        public static void ContractToData(CrudeClientDocumentContract contract, CrudeClientDocumentData data) {
            data.ClientDocumentId = contract.ClientDocumentId;
            data.ClientId = contract.ClientId;
            data.ClientDocumentTypeRcd = contract.ClientDocumentTypeRcd;
            data.DocumentName = contract.DocumentName;
            data.DocumentDateTime = contract.DocumentDateTime;
            data.ExpiryDateTime = contract.ExpiryDateTime;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientDocumentData data, CrudeClientDocumentContract contract) {
            contract.ClientDocumentId = data.ClientDocumentId;
            contract.ClientId = data.ClientId;
            contract.ClientDocumentTypeRcd = data.ClientDocumentTypeRcd;
            contract.DocumentName = data.DocumentName;
            contract.DocumentDateTime = data.DocumentDateTime;
            contract.ExpiryDateTime = data.ExpiryDateTime;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
