/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:33:59 PM
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
    public partial interface ICrudeClientLinkService {
        
        [OperationContract()]
        CrudeClientLinkContract FetchByClientLinkId(System.Guid clientLinkId);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchByClientLinkTypeRcd(string clientLinkTypeRcd);
        
        [OperationContract()]
        CrudeClientLinkContract FetchByLinkName(string linkName);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientLinkContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientLinkContract contract);
        
        [OperationContract()]
        void Update(CrudeClientLinkContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientLinkId);
    }
    
    public partial class CrudeClientLinkService : ICrudeClientLinkService {
        
        public CrudeClientLinkContract FetchByClientLinkId(System.Guid clientLinkId) {
            var dataAccessLayer = new CrudeClientLinkData();
            var contract = new CrudeClientLinkContract();

            dataAccessLayer.FetchByClientLinkId(clientLinkId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientLinkContract FetchByLinkName(string linkName) {
            var dataAccessLayer = new CrudeClientLinkData();
            var contract = new CrudeClientLinkContract();

            dataAccessLayer.FetchByLinkName(linkName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientLinkContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientLinkData.FetchByClientId(clientId));
        }
        
        public List<CrudeClientLinkContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientLinkData.FetchByUserId(userId));
        }
        
        public List<CrudeClientLinkContract> FetchByClientLinkTypeRcd(string clientLinkTypeRcd) {
            return DataListToContractList(CrudeClientLinkData.FetchByClientLinkTypeRcd(clientLinkTypeRcd));
        }
        
        public static List<CrudeClientLinkContract> DataListToContractList(List<CrudeClientLinkData> dataList) {
            var contractList = new List<CrudeClientLinkContract>();

            foreach (CrudeClientLinkData data in dataList) {
                var contract = new CrudeClientLinkContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientLinkContract> contractList, List<CrudeClientLinkData> dataList) {
            foreach (CrudeClientLinkContract contract in contractList) {
                var data = new CrudeClientLinkData();
                CrudeClientLinkService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientLinkContract> FetchAll() {
            var list = new List<CrudeClientLinkContract>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAll();

            foreach (CrudeClientLinkData crudeClientLink in dataList) {
                var contract = new CrudeClientLinkContract();
                DataToContract(crudeClientLink, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientLinkContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientLinkContract>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAllWithLimit(limit);

            foreach (CrudeClientLinkData crudeClientLink in dataList) {
                var contract = new CrudeClientLinkContract();
                DataToContract(crudeClientLink, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientLinkContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientLinkContract>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientLinkData crudeClientLink in dataList) {
                var contract = new CrudeClientLinkContract();
                DataToContract(crudeClientLink, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientLinkData.FetchAllCount();
        }
        
        public List<CrudeClientLinkContract> FetchWithFilter(System.Guid clientLinkId, System.Guid clientId, string clientLinkTypeRcd, string linkName, string link, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientLinkContract>();
            List<CrudeClientLinkData> dataList = CrudeClientLinkData.FetchWithFilter(
                clientLinkId: clientLinkId,
                clientId: clientId,
                clientLinkTypeRcd: clientLinkTypeRcd,
                linkName: linkName,
                link: link,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientLinkData data in dataList) {
                var crudeClientLinkContract = new CrudeClientLinkContract();
                DataToContract(data, crudeClientLinkContract);
                list.Add(crudeClientLinkContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientLinkContract contract) {
            var data = new CrudeClientLinkData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientLinkContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientLinkContract contract) {
            var data = new CrudeClientLinkData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientLinkContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientLinkData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientLinkId) {
            CrudeClientLinkData.Delete(clientLinkId);
        }
        
        public static void ContractToData(CrudeClientLinkContract contract, CrudeClientLinkData data) {
            data.ClientLinkId = contract.ClientLinkId;
            data.ClientId = contract.ClientId;
            data.ClientLinkTypeRcd = contract.ClientLinkTypeRcd;
            data.LinkName = contract.LinkName;
            data.Link = contract.Link;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientLinkData data, CrudeClientLinkContract contract) {
            contract.ClientLinkId = data.ClientLinkId;
            contract.ClientId = data.ClientId;
            contract.ClientLinkTypeRcd = data.ClientLinkTypeRcd;
            contract.LinkName = data.LinkName;
            contract.Link = data.Link;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
