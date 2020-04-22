/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:01 AM
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
    public partial interface ICrudeDefaultUserService {
        
        [OperationContract()]
        CrudeDefaultUserContract FetchByDefaultUserId(System.Guid defaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchByDefaultStateRcd(string defaultStateRcd);
        
        [OperationContract()]
        CrudeDefaultUserContract FetchByDefaultUserName(string defaultUserName);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchAll();
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeDefaultUserContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeDefaultUserContract contract);
        
        [OperationContract()]
        void Update(CrudeDefaultUserContract contract);
        
        [OperationContract()]
        void Delete(System.Guid defaultUserId);
    }
    
    public partial class CrudeDefaultUserService : ICrudeDefaultUserService {
        
        public CrudeDefaultUserContract FetchByDefaultUserId(System.Guid defaultUserId) {
            var dataAccessLayer = new CrudeDefaultUserData();
            var contract = new CrudeDefaultUserContract();

            dataAccessLayer.FetchByDefaultUserId(defaultUserId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeDefaultUserContract FetchByDefaultUserName(string defaultUserName) {
            var dataAccessLayer = new CrudeDefaultUserData();
            var contract = new CrudeDefaultUserContract();

            dataAccessLayer.FetchByDefaultUserName(defaultUserName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeDefaultUserContract> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId) {
            return DataListToContractList(CrudeDefaultUserData.FetchByCreatedByDefaultUserId(createdByDefaultUserId));
        }
        
        public List<CrudeDefaultUserContract> FetchByDefaultStateRcd(string defaultStateRcd) {
            return DataListToContractList(CrudeDefaultUserData.FetchByDefaultStateRcd(defaultStateRcd));
        }
        
        public static List<CrudeDefaultUserContract> DataListToContractList(List<CrudeDefaultUserData> dataList) {
            var contractList = new List<CrudeDefaultUserContract>();

            foreach (CrudeDefaultUserData data in dataList) {
                var contract = new CrudeDefaultUserContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeDefaultUserContract> contractList, List<CrudeDefaultUserData> dataList) {
            foreach (CrudeDefaultUserContract contract in contractList) {
                var data = new CrudeDefaultUserData();
                CrudeDefaultUserService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeDefaultUserContract> FetchAll() {
            var list = new List<CrudeDefaultUserContract>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAll();

            foreach (CrudeDefaultUserData crudeDefaultUser in dataList) {
                var contract = new CrudeDefaultUserContract();
                DataToContract(crudeDefaultUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultUserContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeDefaultUserContract>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAllWithLimit(limit);

            foreach (CrudeDefaultUserData crudeDefaultUser in dataList) {
                var contract = new CrudeDefaultUserContract();
                DataToContract(crudeDefaultUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeDefaultUserContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeDefaultUserContract>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeDefaultUserData crudeDefaultUser in dataList) {
                var contract = new CrudeDefaultUserContract();
                DataToContract(crudeDefaultUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeDefaultUserData.FetchAllCount();
        }
        
        public List<CrudeDefaultUserContract> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime) {
            var list = new List<CrudeDefaultUserContract>();
            List<CrudeDefaultUserData> dataList = CrudeDefaultUserData.FetchWithFilter(
                defaultUserId: defaultUserId,
                defaultUserCode: defaultUserCode,
                defaultUserName: defaultUserName,
                email: email,
                password: password,
                defaultStateRcd: defaultStateRcd,
                createdByDefaultUserId: createdByDefaultUserId,
                dateTime: dateTime,
                lastActivityDateTime: lastActivityDateTime
                );

            foreach (CrudeDefaultUserData data in dataList) {
                var crudeDefaultUserContract = new CrudeDefaultUserContract();
                DataToContract(data, crudeDefaultUserContract);
                list.Add(crudeDefaultUserContract);
            }

            return list;
        }
        
        public void Insert(CrudeDefaultUserContract contract) {
            var data = new CrudeDefaultUserData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeDefaultUserContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeDefaultUserContract contract) {
            var data = new CrudeDefaultUserData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeDefaultUserContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeDefaultUserData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid defaultUserId) {
            CrudeDefaultUserData.Delete(defaultUserId);
        }
        
        public static void ContractToData(CrudeDefaultUserContract contract, CrudeDefaultUserData data) {
            data.DefaultUserId = contract.DefaultUserId;
            data.DefaultUserCode = contract.DefaultUserCode;
            data.DefaultUserName = contract.DefaultUserName;
            data.Email = contract.Email;
            data.Password = contract.Password;
            data.DefaultStateRcd = contract.DefaultStateRcd;
            data.CreatedByDefaultUserId = contract.CreatedByDefaultUserId;
            data.DateTime = contract.DateTime;
            data.LastActivityDateTime = contract.LastActivityDateTime;
        }
        
        public static void DataToContract(CrudeDefaultUserData data, CrudeDefaultUserContract contract) {
            contract.DefaultUserId = data.DefaultUserId;
            contract.DefaultUserCode = data.DefaultUserCode;
            contract.DefaultUserName = data.DefaultUserName;
            contract.Email = data.Email;
            contract.Password = data.Password;
            contract.DefaultStateRcd = data.DefaultStateRcd;
            contract.CreatedByDefaultUserId = data.CreatedByDefaultUserId;
            contract.DateTime = data.DateTime;
            contract.LastActivityDateTime = data.LastActivityDateTime;
        }
    }
}
