/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 9:44:04 AM
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
    public partial interface ICrudeLocationAddressTypeRefService {
        
        [OperationContract()]
        CrudeLocationAddressTypeRefContract FetchByLocationAddressTypeRcd(string locationAddressTypeRcd);
        
        [OperationContract()]
        List<CrudeLocationAddressTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeLocationAddressTypeRefContract FetchByLocationAddressTypeName(string locationAddressTypeName);
        
        [OperationContract()]
        List<CrudeLocationAddressTypeRefContract> FetchWithFilter(string locationAddressTypeRcd, string locationAddressTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeLocationAddressTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeLocationAddressTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeLocationAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeLocationAddressTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeLocationAddressTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string locationAddressTypeRcd);
    }
    
    public partial class CrudeLocationAddressTypeRefService : ICrudeLocationAddressTypeRefService {
        
        public CrudeLocationAddressTypeRefContract FetchByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            var dataAccessLayer = new CrudeLocationAddressTypeRefData();
            var contract = new CrudeLocationAddressTypeRefContract();

            dataAccessLayer.FetchByLocationAddressTypeRcd(locationAddressTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeLocationAddressTypeRefContract FetchByLocationAddressTypeName(string locationAddressTypeName) {
            var dataAccessLayer = new CrudeLocationAddressTypeRefData();
            var contract = new CrudeLocationAddressTypeRefContract();

            dataAccessLayer.FetchByLocationAddressTypeName(locationAddressTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeLocationAddressTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeLocationAddressTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeLocationAddressTypeRefContract> DataListToContractList(List<CrudeLocationAddressTypeRefData> dataList) {
            var contractList = new List<CrudeLocationAddressTypeRefContract>();

            foreach (CrudeLocationAddressTypeRefData data in dataList) {
                var contract = new CrudeLocationAddressTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeLocationAddressTypeRefContract> contractList, List<CrudeLocationAddressTypeRefData> dataList) {
            foreach (CrudeLocationAddressTypeRefContract contract in contractList) {
                var data = new CrudeLocationAddressTypeRefData();
                CrudeLocationAddressTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeLocationAddressTypeRefContract> FetchAll() {
            var list = new List<CrudeLocationAddressTypeRefContract>();
            List<CrudeLocationAddressTypeRefData> dataList = CrudeLocationAddressTypeRefData.FetchAll();

            foreach (CrudeLocationAddressTypeRefData crudeLocationAddressTypeRef in dataList) {
                var contract = new CrudeLocationAddressTypeRefContract();
                DataToContract(crudeLocationAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeLocationAddressTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeLocationAddressTypeRefContract>();
            List<CrudeLocationAddressTypeRefData> dataList = CrudeLocationAddressTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeLocationAddressTypeRefData crudeLocationAddressTypeRef in dataList) {
                var contract = new CrudeLocationAddressTypeRefContract();
                DataToContract(crudeLocationAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeLocationAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeLocationAddressTypeRefContract>();
            List<CrudeLocationAddressTypeRefData> dataList = CrudeLocationAddressTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeLocationAddressTypeRefData crudeLocationAddressTypeRef in dataList) {
                var contract = new CrudeLocationAddressTypeRefContract();
                DataToContract(crudeLocationAddressTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeLocationAddressTypeRefData.FetchAllCount();
        }
        
        public List<CrudeLocationAddressTypeRefContract> FetchWithFilter(string locationAddressTypeRcd, string locationAddressTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeLocationAddressTypeRefContract>();
            List<CrudeLocationAddressTypeRefData> dataList = CrudeLocationAddressTypeRefData.FetchWithFilter(
                locationAddressTypeRcd: locationAddressTypeRcd,
                locationAddressTypeName: locationAddressTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeLocationAddressTypeRefData data in dataList) {
                var crudeLocationAddressTypeRefContract = new CrudeLocationAddressTypeRefContract();
                DataToContract(data, crudeLocationAddressTypeRefContract);
                list.Add(crudeLocationAddressTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeLocationAddressTypeRefContract contract) {
            var data = new CrudeLocationAddressTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeLocationAddressTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationAddressTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeLocationAddressTypeRefContract contract) {
            var data = new CrudeLocationAddressTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeLocationAddressTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeLocationAddressTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string locationAddressTypeRcd) {
            CrudeLocationAddressTypeRefData.Delete(locationAddressTypeRcd);
        }
        
        public static void ContractToData(CrudeLocationAddressTypeRefContract contract, CrudeLocationAddressTypeRefData data) {
            data.LocationAddressTypeRcd = contract.LocationAddressTypeRcd;
            data.LocationAddressTypeName = contract.LocationAddressTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeLocationAddressTypeRefData data, CrudeLocationAddressTypeRefContract contract) {
            contract.LocationAddressTypeRcd = data.LocationAddressTypeRcd;
            contract.LocationAddressTypeName = data.LocationAddressTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
