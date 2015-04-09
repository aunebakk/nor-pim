using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeUserContract {
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public string UserCode { get; set; } //;
        
        [DataMember()]
        public string UserName { get; set; } //;
        
        [DataMember()]
        public string Email { get; set; } //;
        
        [DataMember()]
        public string Password { get; set; } //;
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public System.Guid CreatedByUserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeUserService {
        
        [OperationContract()]
        CrudeUserContract FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeUserContract FetchByUserCode(string userCode);
        
        [OperationContract()]
        List<CrudeUserContract> FetchWithFilter(System.Guid userId, string userCode, string userName, string email, string password, string stateRcd, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeUserContract> FetchAll();
        
        [OperationContract()]
        List<CrudeUserContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeUserContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeUserContract contract);
        
        [OperationContract()]
        void Update(CrudeUserContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeUserService : ICrudeUserService {
        
        public CrudeUserContract FetchByUserId(System.Guid userId) {
            var dataAccessLayer = new CrudeUserData();
            var contract = new CrudeUserContract();

            dataAccessLayer.FetchByUserId(userId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeUserContract FetchByUserCode(string userCode) {
            var dataAccessLayer = new CrudeUserData();
            var contract = new CrudeUserContract();

            dataAccessLayer.FetchByUserCode(userCode);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public static List<CrudeUserContract> DataListToContractList(List<CrudeUserData> dataList) {
            var contractList = new List<CrudeUserContract>();

            foreach (CrudeUserData data in dataList) {
                var contract = new CrudeUserContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeUserContract> contractList, List<CrudeUserData> dataList) {
            foreach (CrudeUserContract contract in contractList) {
                var data = new CrudeUserData();
                CrudeUserService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeUserContract> FetchAll() {
            var list = new List<CrudeUserContract>();
            var dataAccessLayer = new CrudeUserData();
            List<CrudeUserData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeUserData crudeUser in dataList) {
                var contract = new CrudeUserContract();
                DataToContract(crudeUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeUserContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeUserContract>();
            var dataAccessLayer = new CrudeUserData();
            List<CrudeUserData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeUserData crudeUser in dataList) {
                var contract = new CrudeUserContract();
                DataToContract(crudeUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeUserContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeUserContract>();
            var dataAccessLayer = new CrudeUserData();
            List<CrudeUserData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeUserData crudeUser in dataList) {
                var contract = new CrudeUserContract();
                DataToContract(crudeUser, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeUserData().FetchAllCount();

        }
        
        public List<CrudeUserContract> FetchWithFilter(System.Guid userId, string userCode, string userName, string email, string password, string stateRcd, System.DateTime dateTime) {
            var list = new List<CrudeUserContract>();
            var dataAccessLayer = new CrudeUserData();
            List<CrudeUserData> dataList = dataAccessLayer.FetchWithFilter(userId,userCode,userName,email,password,stateRcd,dateTime);

            foreach (CrudeUserData data in dataList) {
                var crudeUserContract = new CrudeUserContract();
                DataToContract(data, crudeUserContract);
                list.Add(crudeUserContract);
            }

            return list;
        }
        
        public void Insert(CrudeUserContract contract) {
            var data = new CrudeUserData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeUserContract contract) {
            var data = new CrudeUserData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeUserData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeUserContract contract, CrudeUserData data) {
            data.UserId = contract.UserId;
            data.UserCode = contract.UserCode;
            data.UserName = contract.UserName;
            data.Email = contract.Email;
            data.Password = contract.Password;
            data.StateRcd = contract.StateRcd;
            data.CreatedByUserId = contract.CreatedByUserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeUserData data, CrudeUserContract contract) {
            contract.UserId = data.UserId;
            contract.UserCode = data.UserCode;
            contract.UserName = data.UserName;
            contract.Email = data.Email;
            contract.Password = data.Password;
            contract.StateRcd = data.StateRcd;
            contract.CreatedByUserId = data.CreatedByUserId;
            contract.DateTime = data.DateTime;
        }
    }
}
