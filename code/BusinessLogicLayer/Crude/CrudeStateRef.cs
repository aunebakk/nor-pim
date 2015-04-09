using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data;
using norpim.DataAccessLayer;

namespace norpim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class CrudeStateRefContract {
        
        [DataMember()]
        public string StateRcd { get; set; } //;
        
        [DataMember()]
        public string StateName { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
    
    [ServiceContract()]
    public interface ICrudeStateRefService {
        
        [OperationContract()]
        CrudeStateRefContract FetchByStateRcd(string stateRcd);
        
        [OperationContract()]
        List<CrudeStateRefContract> FetchWithFilter(string stateRcd, string stateName, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeStateRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeStateRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeStateRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeStateRefContract contract);
        
        [OperationContract()]
        void Update(CrudeStateRefContract contract);
        
        [OperationContract()]
        void Delete(System.Guid id);
    }
    
    public class CrudeStateRefService : ICrudeStateRefService {
        
        public CrudeStateRefContract FetchByStateRcd(string stateRcd) {
            var dataAccessLayer = new CrudeStateRefData();
            var contract = new CrudeStateRefContract();

            dataAccessLayer.FetchByStateRcd(stateRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public static List<CrudeStateRefContract> DataListToContractList(List<CrudeStateRefData> dataList) {
            var contractList = new List<CrudeStateRefContract>();

            foreach (CrudeStateRefData data in dataList) {
                var contract = new CrudeStateRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeStateRefContract> contractList, List<CrudeStateRefData> dataList) {
            foreach (CrudeStateRefContract contract in contractList) {
                var data = new CrudeStateRefData();
                CrudeStateRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeStateRefContract> FetchAll() {
            var list = new List<CrudeStateRefContract>();
            var dataAccessLayer = new CrudeStateRefData();
            List<CrudeStateRefData> dataList = dataAccessLayer.FetchAll();

            foreach (CrudeStateRefData crudeStateRef in dataList) {
                var contract = new CrudeStateRefContract();
                DataToContract(crudeStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeStateRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeStateRefContract>();
            var dataAccessLayer = new CrudeStateRefData();
            List<CrudeStateRefData> dataList = dataAccessLayer.FetchAllWithLimit(limit);

            foreach (CrudeStateRefData crudeStateRef in dataList) {
                var contract = new CrudeStateRefContract();
                DataToContract(crudeStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeStateRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeStateRefContract>();
            var dataAccessLayer = new CrudeStateRefData();
            List<CrudeStateRefData> dataList = dataAccessLayer.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeStateRefData crudeStateRef in dataList) {
                var contract = new CrudeStateRefContract();
                DataToContract(crudeStateRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return new CrudeStateRefData().FetchAllCount();

        }
        
        public List<CrudeStateRefContract> FetchWithFilter(string stateRcd, string stateName, System.DateTime dateTime) {
            var list = new List<CrudeStateRefContract>();
            var dataAccessLayer = new CrudeStateRefData();
            List<CrudeStateRefData> dataList = dataAccessLayer.FetchWithFilter(stateRcd,stateName,dateTime);

            foreach (CrudeStateRefData data in dataList) {
                var crudeStateRefContract = new CrudeStateRefContract();
                DataToContract(data, crudeStateRefContract);
                list.Add(crudeStateRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeStateRefContract contract) {
            var data = new CrudeStateRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Update(CrudeStateRefContract contract) {
            var data = new CrudeStateRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Delete(System.Guid id) {
            var data = new CrudeStateRefData();
            data.Delete(id);
        }
        
        public static void ContractToData(CrudeStateRefContract contract, CrudeStateRefData data) {
            data.StateRcd = contract.StateRcd;
            data.StateName = contract.StateName;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeStateRefData data, CrudeStateRefContract contract) {
            contract.StateRcd = data.StateRcd;
            contract.StateName = data.StateName;
            contract.DateTime = data.DateTime;
        }
    }
}
