/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:20 AM
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
    public partial interface ICrudeProductInfoService {
        
        [OperationContract()]
        CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchByProductInfoRcd(string productInfoRcd);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductInfoContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductInfoContract contract);
        
        [OperationContract()]
        void Update(CrudeProductInfoContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productInfoId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_info's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductInfoService : ICrudeProductInfoService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productInfoId: primary key of table product_info
        public CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId) {
            var dataAccessLayer = new CrudeProductInfoData();
            var contract = new CrudeProductInfoContract();

            dataAccessLayer.FetchByProductInfoId(productInfoId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductInfoContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductInfoData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductInfoContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductInfoData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductInfoContract> FetchByProductInfoRcd(string productInfoRcd) {
            return DataListToContractList(CrudeProductInfoData.FetchByProductInfoRcd(productInfoRcd));
        }
        
        public static List<CrudeProductInfoContract> DataListToContractList(List<CrudeProductInfoData> dataList) {
            var contractList = new List<CrudeProductInfoContract>();

            foreach (CrudeProductInfoData data in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductInfoContract> contractList, List<CrudeProductInfoData> dataList) {
            foreach (CrudeProductInfoContract contract in contractList) {
                var data = new CrudeProductInfoData();
                CrudeProductInfoService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductInfoContract> FetchAll() {
            var list = new List<CrudeProductInfoContract>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAll();

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductInfoContract>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAllWithLimit(limit);

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductInfoContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductInfoContract>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductInfoData crudeProductInfo in dataList) {
                var contract = new CrudeProductInfoContract();
                DataToContract(crudeProductInfo, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductInfoData.FetchAllCount();
        }
        
        public List<CrudeProductInfoContract> FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductInfoContract>();
            List<CrudeProductInfoData> dataList = CrudeProductInfoData.FetchWithFilter(
                productInfoId: productInfoId,
                productId: productId,
                productInfoRcd: productInfoRcd,
                productInfoValue: productInfoValue,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductInfoData data in dataList) {
                var crudeProductInfoContract = new CrudeProductInfoContract();
                DataToContract(data, crudeProductInfoContract);
                list.Add(crudeProductInfoContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductInfoContract contract) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductInfoContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductInfoContract contract) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductInfoContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductInfoData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productInfoId) {
            CrudeProductInfoData.Delete(productInfoId);
        }
        
        public static void ContractToData(CrudeProductInfoContract contract, CrudeProductInfoData data) {
            data.ProductInfoId = contract.ProductInfoId;
            data.ProductId = contract.ProductId;
            data.ProductInfoRcd = contract.ProductInfoRcd;
            data.ProductInfoValue = contract.ProductInfoValue;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductInfoData data, CrudeProductInfoContract contract) {
            contract.ProductInfoId = data.ProductInfoId;
            contract.ProductId = data.ProductId;
            contract.ProductInfoRcd = data.ProductInfoRcd;
            contract.ProductInfoValue = data.ProductInfoValue;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
