/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:16 AM
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
    public partial interface ICrudeProductExposeService {
        
        [OperationContract()]
        CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByExposeProductId(System.Guid exposeProductId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productExposeId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_expose's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductExposeService : ICrudeProductExposeService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productExposeId: primary key of table product_expose
        public CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId) {
            var dataAccessLayer = new CrudeProductExposeData();
            var contract = new CrudeProductExposeContract();

            dataAccessLayer.FetchByProductExposeId(productExposeId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeContract> FetchByExposeProductId(System.Guid exposeProductId) {
            return DataListToContractList(CrudeProductExposeData.FetchByExposeProductId(exposeProductId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeContract> FetchByExposeBasedOnProductId(System.Guid exposeBasedOnProductId) {
            return DataListToContractList(CrudeProductExposeData.FetchByExposeBasedOnProductId(exposeBasedOnProductId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeContract> FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return DataListToContractList(CrudeProductExposeData.FetchByProductExposeSetId(productExposeSetId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposeData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeContract> DataListToContractList(List<CrudeProductExposeData> dataList) {
            var contractList = new List<CrudeProductExposeContract>();

            foreach (CrudeProductExposeData data in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposeContract> contractList, List<CrudeProductExposeData> dataList) {
            foreach (CrudeProductExposeContract contract in contractList) {
                var data = new CrudeProductExposeData();
                CrudeProductExposeService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeContract> FetchAll() {
            var list = new List<CrudeProductExposeContract>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAll();

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeContract>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeContract>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeData crudeProductExpose in dataList) {
                var contract = new CrudeProductExposeContract();
                DataToContract(crudeProductExpose, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposeData.FetchAllCount();
        }
        
        public List<CrudeProductExposeContract> FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeContract>();
            List<CrudeProductExposeData> dataList = CrudeProductExposeData.FetchWithFilter(
                productExposeId: productExposeId,
                exposeProductId: exposeProductId,
                exposeBasedOnProductId: exposeBasedOnProductId,
                productExposeSetId: productExposeSetId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposeData data in dataList) {
                var crudeProductExposeContract = new CrudeProductExposeContract();
                DataToContract(data, crudeProductExposeContract);
                list.Add(crudeProductExposeContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeContract contract) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposeContract contract) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposeContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productExposeId) {
            CrudeProductExposeData.Delete(productExposeId);
        }
        
        public static void ContractToData(CrudeProductExposeContract contract, CrudeProductExposeData data) {
            data.ProductExposeId = contract.ProductExposeId;
            data.ExposeProductId = contract.ExposeProductId;
            data.ExposeBasedOnProductId = contract.ExposeBasedOnProductId;
            data.ProductExposeSetId = contract.ProductExposeSetId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposeData data, CrudeProductExposeContract contract) {
            contract.ProductExposeId = data.ProductExposeId;
            contract.ExposeProductId = data.ExposeProductId;
            contract.ExposeBasedOnProductId = data.ExposeBasedOnProductId;
            contract.ProductExposeSetId = data.ProductExposeSetId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
