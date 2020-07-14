/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:35:30 AM
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
    public partial interface ICrudeClientService {
        
        [OperationContract()]
        CrudeClientContract FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientAddressId(System.Guid clientAddressId);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientTypeRcd(string clientTypeRcd);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientNationalityRcd(string clientNationalityRcd);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientGenderRcd(string clientGenderRcd);
        
        [OperationContract()]
        List<CrudeClientContract> FetchByClientTitleRcd(string clientTitleRcd);
        
        [OperationContract()]
        CrudeClientContract FetchByFirstName(string firstName);
        
        [OperationContract()]
        List<CrudeClientContract> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientContract contract);
        
        [OperationContract()]
        void Update(CrudeClientContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientId);
    }
    
    public partial class CrudeClientService : ICrudeClientService {
        
        public CrudeClientContract FetchByClientId(System.Guid clientId) {
            var dataAccessLayer = new CrudeClientData();
            var contract = new CrudeClientContract();

            dataAccessLayer.FetchByClientId(clientId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientContract FetchByFirstName(string firstName) {
            var dataAccessLayer = new CrudeClientData();
            var contract = new CrudeClientContract();

            dataAccessLayer.FetchByFirstName(firstName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeClientContract> FetchByClientAddressId(System.Guid clientAddressId) {
            return DataListToContractList(CrudeClientData.FetchByClientAddressId(clientAddressId));
        }
        
        public List<CrudeClientContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientData.FetchByUserId(userId));
        }
        
        public List<CrudeClientContract> FetchByClientTypeRcd(string clientTypeRcd) {
            return DataListToContractList(CrudeClientData.FetchByClientTypeRcd(clientTypeRcd));
        }
        
        public List<CrudeClientContract> FetchByClientNationalityRcd(string clientNationalityRcd) {
            return DataListToContractList(CrudeClientData.FetchByClientNationalityRcd(clientNationalityRcd));
        }
        
        public List<CrudeClientContract> FetchByClientGenderRcd(string clientGenderRcd) {
            return DataListToContractList(CrudeClientData.FetchByClientGenderRcd(clientGenderRcd));
        }
        
        public List<CrudeClientContract> FetchByClientTitleRcd(string clientTitleRcd) {
            return DataListToContractList(CrudeClientData.FetchByClientTitleRcd(clientTitleRcd));
        }
        
        public static List<CrudeClientContract> DataListToContractList(List<CrudeClientData> dataList) {
            var contractList = new List<CrudeClientContract>();

            foreach (CrudeClientData data in dataList) {
                var contract = new CrudeClientContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeClientContract> contractList, List<CrudeClientData> dataList) {
            foreach (CrudeClientContract contract in contractList) {
                var data = new CrudeClientData();
                CrudeClientService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeClientContract> FetchAll() {
            var list = new List<CrudeClientContract>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAll();

            foreach (CrudeClientData crudeClient in dataList) {
                var contract = new CrudeClientContract();
                DataToContract(crudeClient, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientContract>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAllWithLimit(limit);

            foreach (CrudeClientData crudeClient in dataList) {
                var contract = new CrudeClientContract();
                DataToContract(crudeClient, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeClientContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientContract>();
            List<CrudeClientData> dataList = CrudeClientData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientData crudeClient in dataList) {
                var contract = new CrudeClientContract();
                DataToContract(crudeClient, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeClientData.FetchAllCount();
        }
        
        public List<CrudeClientContract> FetchWithFilter(System.Guid clientId, string clientTypeRcd, string clientNationalityRcd, string clientGenderRcd, string clientTitleRcd, System.Guid clientAddressId, string firstName, string middleName, string lastName, byte[] image, string imageBlobFilename, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientContract>();
            List<CrudeClientData> dataList = CrudeClientData.FetchWithFilter(
                clientId: clientId,
                clientTypeRcd: clientTypeRcd,
                clientNationalityRcd: clientNationalityRcd,
                clientGenderRcd: clientGenderRcd,
                clientTitleRcd: clientTitleRcd,
                clientAddressId: clientAddressId,
                firstName: firstName,
                middleName: middleName,
                lastName: lastName,
                image: image,
                imageBlobFilename: imageBlobFilename,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientData data in dataList) {
                var crudeClientContract = new CrudeClientContract();
                DataToContract(data, crudeClientContract);
                list.Add(crudeClientContract);
            }

            return list;
        }
        
        public void Insert(CrudeClientContract contract) {
            var data = new CrudeClientData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeClientContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeClientContract contract) {
            var data = new CrudeClientData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeClientContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid clientId) {
            CrudeClientData.Delete(clientId);
        }
        
        public static void ContractToData(CrudeClientContract contract, CrudeClientData data) {
            data.ClientId = contract.ClientId;
            data.ClientTypeRcd = contract.ClientTypeRcd;
            data.ClientNationalityRcd = contract.ClientNationalityRcd;
            data.ClientGenderRcd = contract.ClientGenderRcd;
            data.ClientTitleRcd = contract.ClientTitleRcd;
            data.ClientAddressId = contract.ClientAddressId;
            data.FirstName = contract.FirstName;
            data.MiddleName = contract.MiddleName;
            data.LastName = contract.LastName;
            data.Image = contract.Image;
            data.ImageBlobFilename = contract.ImageBlobFilename;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeClientData data, CrudeClientContract contract) {
            contract.ClientId = data.ClientId;
            contract.ClientTypeRcd = data.ClientTypeRcd;
            contract.ClientNationalityRcd = data.ClientNationalityRcd;
            contract.ClientGenderRcd = data.ClientGenderRcd;
            contract.ClientTitleRcd = data.ClientTitleRcd;
            contract.ClientAddressId = data.ClientAddressId;
            contract.FirstName = data.FirstName;
            contract.MiddleName = data.MiddleName;
            contract.LastName = data.LastName;
            contract.Image = data.Image;
            contract.ImageBlobFilename = data.ImageBlobFilename;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
