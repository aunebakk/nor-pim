/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:02 AM
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
    public partial interface ICrudeFinancialCouponService {
        
        [OperationContract()]
        CrudeFinancialCouponContract FetchByFinancialCouponId(System.Guid financialCouponId);
        
        [OperationContract()]
        List<CrudeFinancialCouponContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [OperationContract()]
        List<CrudeFinancialCouponContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeFinancialCouponContract> FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialCouponContract> FetchWithFilter(System.Guid financialCouponId, int couponNumber, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, string couponDescription, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialCouponTypeRcd);
        
        [OperationContract()]
        List<CrudeFinancialCouponContract> FetchAll();
        
        [OperationContract()]
        List<CrudeFinancialCouponContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeFinancialCouponContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeFinancialCouponContract contract);
        
        [OperationContract()]
        void Update(CrudeFinancialCouponContract contract);
        
        [OperationContract()]
        void Delete(System.Guid financialCouponId);
    }
    
    public partial class CrudeFinancialCouponService : ICrudeFinancialCouponService {
        
        public CrudeFinancialCouponContract FetchByFinancialCouponId(System.Guid financialCouponId) {
            var dataAccessLayer = new CrudeFinancialCouponData();
            var contract = new CrudeFinancialCouponContract();

            dataAccessLayer.FetchByFinancialCouponId(financialCouponId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public List<CrudeFinancialCouponContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return DataListToContractList(CrudeFinancialCouponData.FetchByFinancialCurrencyId(financialCurrencyId));
        }
        
        public List<CrudeFinancialCouponContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeFinancialCouponData.FetchByUserId(userId));
        }
        
        public List<CrudeFinancialCouponContract> FetchByFinancialCouponTypeRcd(string financialCouponTypeRcd) {
            return DataListToContractList(CrudeFinancialCouponData.FetchByFinancialCouponTypeRcd(financialCouponTypeRcd));
        }
        
        public static List<CrudeFinancialCouponContract> DataListToContractList(List<CrudeFinancialCouponData> dataList) {
            var contractList = new List<CrudeFinancialCouponContract>();

            foreach (CrudeFinancialCouponData data in dataList) {
                var contract = new CrudeFinancialCouponContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeFinancialCouponContract> contractList, List<CrudeFinancialCouponData> dataList) {
            foreach (CrudeFinancialCouponContract contract in contractList) {
                var data = new CrudeFinancialCouponData();
                CrudeFinancialCouponService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeFinancialCouponContract> FetchAll() {
            var list = new List<CrudeFinancialCouponContract>();
            List<CrudeFinancialCouponData> dataList = CrudeFinancialCouponData.FetchAll();

            foreach (CrudeFinancialCouponData crudeFinancialCoupon in dataList) {
                var contract = new CrudeFinancialCouponContract();
                DataToContract(crudeFinancialCoupon, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCouponContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeFinancialCouponContract>();
            List<CrudeFinancialCouponData> dataList = CrudeFinancialCouponData.FetchAllWithLimit(limit);

            foreach (CrudeFinancialCouponData crudeFinancialCoupon in dataList) {
                var contract = new CrudeFinancialCouponContract();
                DataToContract(crudeFinancialCoupon, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeFinancialCouponContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeFinancialCouponContract>();
            List<CrudeFinancialCouponData> dataList = CrudeFinancialCouponData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeFinancialCouponData crudeFinancialCoupon in dataList) {
                var contract = new CrudeFinancialCouponContract();
                DataToContract(crudeFinancialCoupon, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeFinancialCouponData.FetchAllCount();
        }
        
        public List<CrudeFinancialCouponContract> FetchWithFilter(System.Guid financialCouponId, int couponNumber, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, string couponDescription, System.Guid financialCurrencyId, System.Guid userId, System.DateTime dateTime, string financialCouponTypeRcd) {
            var list = new List<CrudeFinancialCouponContract>();
            List<CrudeFinancialCouponData> dataList = CrudeFinancialCouponData.FetchWithFilter(
                financialCouponId: financialCouponId,
                couponNumber: couponNumber,
                valueAmount: valueAmount,
                validFromDateTime: validFromDateTime,
                validUntilDateTime: validUntilDateTime,
                couponDescription: couponDescription,
                financialCurrencyId: financialCurrencyId,
                userId: userId,
                dateTime: dateTime,
                financialCouponTypeRcd: financialCouponTypeRcd
                );

            foreach (CrudeFinancialCouponData data in dataList) {
                var crudeFinancialCouponContract = new CrudeFinancialCouponContract();
                DataToContract(data, crudeFinancialCouponContract);
                list.Add(crudeFinancialCouponContract);
            }

            return list;
        }
        
        public void Insert(CrudeFinancialCouponContract contract) {
            var data = new CrudeFinancialCouponData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeFinancialCouponContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCouponData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeFinancialCouponContract contract) {
            var data = new CrudeFinancialCouponData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeFinancialCouponContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeFinancialCouponData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid financialCouponId) {
            CrudeFinancialCouponData.Delete(financialCouponId);
        }
        
        public static void ContractToData(CrudeFinancialCouponContract contract, CrudeFinancialCouponData data) {
            data.FinancialCouponId = contract.FinancialCouponId;
            data.CouponNumber = contract.CouponNumber;
            data.ValueAmount = contract.ValueAmount;
            data.ValidFromDateTime = contract.ValidFromDateTime;
            data.ValidUntilDateTime = contract.ValidUntilDateTime;
            data.CouponDescription = contract.CouponDescription;
            data.FinancialCurrencyId = contract.FinancialCurrencyId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
            data.FinancialCouponTypeRcd = contract.FinancialCouponTypeRcd;
        }
        
        public static void DataToContract(CrudeFinancialCouponData data, CrudeFinancialCouponContract contract) {
            contract.FinancialCouponId = data.FinancialCouponId;
            contract.CouponNumber = data.CouponNumber;
            contract.ValueAmount = data.ValueAmount;
            contract.ValidFromDateTime = data.ValidFromDateTime;
            contract.ValidUntilDateTime = data.ValidUntilDateTime;
            contract.CouponDescription = data.CouponDescription;
            contract.FinancialCurrencyId = data.FinancialCurrencyId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
            contract.FinancialCouponTypeRcd = data.FinancialCouponTypeRcd;
        }
    }
}
