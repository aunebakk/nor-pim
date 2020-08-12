/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:17 AM
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
    public partial interface ICrudeProductExposedSelectionService {
        
        [OperationContract()]
        CrudeProductExposedSelectionContract FetchByProductExposedSelectionId(System.Guid productExposedSelectionId);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchByProductExposeId(System.Guid productExposeId);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposedSelectionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposedSelectionContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposedSelectionContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productExposedSelectionId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_exposed_selection's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductExposedSelectionService : ICrudeProductExposedSelectionService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productExposedSelectionId: primary key of table product_exposed_selection
        public CrudeProductExposedSelectionContract FetchByProductExposedSelectionId(System.Guid productExposedSelectionId) {
            var dataAccessLayer = new CrudeProductExposedSelectionData();
            var contract = new CrudeProductExposedSelectionContract();

            dataAccessLayer.FetchByProductExposedSelectionId(productExposedSelectionId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposedSelectionContract> FetchByProductExposeId(System.Guid productExposeId) {
            return DataListToContractList(CrudeProductExposedSelectionData.FetchByProductExposeId(productExposeId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposedSelectionContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposedSelectionData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposedSelectionContract> DataListToContractList(List<CrudeProductExposedSelectionData> dataList) {
            var contractList = new List<CrudeProductExposedSelectionContract>();

            foreach (CrudeProductExposedSelectionData data in dataList) {
                var contract = new CrudeProductExposedSelectionContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposedSelectionContract> contractList, List<CrudeProductExposedSelectionData> dataList) {
            foreach (CrudeProductExposedSelectionContract contract in contractList) {
                var data = new CrudeProductExposedSelectionData();
                CrudeProductExposedSelectionService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposedSelectionContract> FetchAll() {
            var list = new List<CrudeProductExposedSelectionContract>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAll();

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelection in dataList) {
                var contract = new CrudeProductExposedSelectionContract();
                DataToContract(crudeProductExposedSelection, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposedSelectionContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposedSelectionContract>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelection in dataList) {
                var contract = new CrudeProductExposedSelectionContract();
                DataToContract(crudeProductExposedSelection, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposedSelectionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposedSelectionContract>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposedSelectionData crudeProductExposedSelection in dataList) {
                var contract = new CrudeProductExposedSelectionContract();
                DataToContract(crudeProductExposedSelection, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposedSelectionData.FetchAllCount();
        }
        
        public List<CrudeProductExposedSelectionContract> FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposedSelectionContract>();
            List<CrudeProductExposedSelectionData> dataList = CrudeProductExposedSelectionData.FetchWithFilter(
                productExposedSelectionId: productExposedSelectionId,
                productExposeId: productExposeId,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposedSelectionData data in dataList) {
                var crudeProductExposedSelectionContract = new CrudeProductExposedSelectionContract();
                DataToContract(data, crudeProductExposedSelectionContract);
                list.Add(crudeProductExposedSelectionContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposedSelectionContract contract) {
            var data = new CrudeProductExposedSelectionData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposedSelectionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposedSelectionData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposedSelectionContract contract) {
            var data = new CrudeProductExposedSelectionData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposedSelectionContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposedSelectionData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(System.Guid productExposedSelectionId) {
            CrudeProductExposedSelectionData.Delete(productExposedSelectionId);
        }
        
        public static void ContractToData(CrudeProductExposedSelectionContract contract, CrudeProductExposedSelectionData data) {
            data.ProductExposedSelectionId = contract.ProductExposedSelectionId;
            data.ProductExposeId = contract.ProductExposeId;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposedSelectionData data, CrudeProductExposedSelectionContract contract) {
            contract.ProductExposedSelectionId = data.ProductExposedSelectionId;
            contract.ProductExposeId = data.ProductExposeId;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
