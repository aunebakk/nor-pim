/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:18 AM
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
    public partial interface ICrudeProductGatherKeyService {
        
        [OperationContract()]
        CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductGatherKeyContract contract);
        
        [OperationContract()]
        void Update(CrudeProductGatherKeyContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productGatherKeyId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_gather_key's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductGatherKeyService : ICrudeProductGatherKeyService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productGatherKeyId: primary key of table product_gather_key
        public CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            var dataAccessLayer = new CrudeProductGatherKeyData();
            var contract = new CrudeProductGatherKeyContract();

            dataAccessLayer.FetchByProductGatherKeyId(productGatherKeyId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherKeyContract> FetchByProductGatherId(System.Guid productGatherId) {
            return DataListToContractList(CrudeProductGatherKeyData.FetchByProductGatherId(productGatherId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherKeyContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherKeyData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductGatherKeyContract> DataListToContractList(List<CrudeProductGatherKeyData> dataList) {
            var contractList = new List<CrudeProductGatherKeyContract>();

            foreach (CrudeProductGatherKeyData data in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductGatherKeyContract> contractList, List<CrudeProductGatherKeyData> dataList) {
            foreach (CrudeProductGatherKeyContract contract in contractList) {
                var data = new CrudeProductGatherKeyData();
                CrudeProductGatherKeyService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductGatherKeyContract> FetchAll() {
            var list = new List<CrudeProductGatherKeyContract>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAll();

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherKeyContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductGatherKeyContract>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductGatherKeyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductGatherKeyContract>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherKeyData crudeProductGatherKey in dataList) {
                var contract = new CrudeProductGatherKeyContract();
                DataToContract(crudeProductGatherKey, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductGatherKeyData.FetchAllCount();
        }
        
        public List<CrudeProductGatherKeyContract> FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductGatherKeyContract>();
            List<CrudeProductGatherKeyData> dataList = CrudeProductGatherKeyData.FetchWithFilter(
                productGatherKeyId: productGatherKeyId,
                productGatherKeyValue: productGatherKeyValue,
                productGatherId: productGatherId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherKeyData data in dataList) {
                var crudeProductGatherKeyContract = new CrudeProductGatherKeyContract();
                DataToContract(data, crudeProductGatherKeyContract);
                list.Add(crudeProductGatherKeyContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductGatherKeyContract contract) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductGatherKeyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductGatherKeyContract contract) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductGatherKeyContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductGatherKeyData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productGatherKeyId) {
            CrudeProductGatherKeyData.Delete(productGatherKeyId);
        }
        
        public static void ContractToData(CrudeProductGatherKeyContract contract, CrudeProductGatherKeyData data) {
            data.ProductGatherKeyId = contract.ProductGatherKeyId;
            data.ProductGatherKeyValue = contract.ProductGatherKeyValue;
            data.ProductGatherId = contract.ProductGatherId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductGatherKeyData data, CrudeProductGatherKeyContract contract) {
            contract.ProductGatherKeyId = data.ProductGatherKeyId;
            contract.ProductGatherKeyValue = data.ProductGatherKeyValue;
            contract.ProductGatherId = data.ProductGatherId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
