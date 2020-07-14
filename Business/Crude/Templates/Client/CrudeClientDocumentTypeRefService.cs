/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:35:31 AM
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
    
    public partial class CrudeClientDocumentTypeRefService : ICrudeClientDocumentTypeRefService {
        
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
