/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 7:40:19 AM
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
    public partial interface ICrudeProductIdentifierRefService {
        
        [OperationContract()]
        CrudeProductIdentifierRefContract FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductIdentifierRefContract FetchByProductIdentifierName(string productIdentifierName);
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductIdentifierRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductIdentifierRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductIdentifierRefContract contract);
        
        [OperationContract()]
        void Delete(string productIdentifierRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_identifier_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductIdentifierRefService : ICrudeProductIdentifierRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productIdentifierRcd: primary key of table product_identifier_ref
        public CrudeProductIdentifierRefContract FetchByProductIdentifierRcd(string productIdentifierRcd) {
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            var contract = new CrudeProductIdentifierRefContract();

            dataAccessLayer.FetchByProductIdentifierRcd(productIdentifierRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductIdentifierRefContract FetchByProductIdentifierName(string productIdentifierName) {
            var dataAccessLayer = new CrudeProductIdentifierRefData();
            var contract = new CrudeProductIdentifierRefContract();

            dataAccessLayer.FetchByProductIdentifierName(productIdentifierName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductIdentifierRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductIdentifierRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductIdentifierRefContract> DataListToContractList(List<CrudeProductIdentifierRefData> dataList) {
            var contractList = new List<CrudeProductIdentifierRefContract>();

            foreach (CrudeProductIdentifierRefData data in dataList) {
                var contract = new CrudeProductIdentifierRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductIdentifierRefContract> contractList, List<CrudeProductIdentifierRefData> dataList) {
            foreach (CrudeProductIdentifierRefContract contract in contractList) {
                var data = new CrudeProductIdentifierRefData();
                CrudeProductIdentifierRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductIdentifierRefContract> FetchAll() {
            var list = new List<CrudeProductIdentifierRefContract>();
            List<CrudeProductIdentifierRefData> dataList = CrudeProductIdentifierRefData.FetchAll();

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRef in dataList) {
                var contract = new CrudeProductIdentifierRefContract();
                DataToContract(crudeProductIdentifierRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductIdentifierRefContract>();
            List<CrudeProductIdentifierRefData> dataList = CrudeProductIdentifierRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRef in dataList) {
                var contract = new CrudeProductIdentifierRefContract();
                DataToContract(crudeProductIdentifierRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductIdentifierRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductIdentifierRefContract>();
            List<CrudeProductIdentifierRefData> dataList = CrudeProductIdentifierRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductIdentifierRefData crudeProductIdentifierRef in dataList) {
                var contract = new CrudeProductIdentifierRefContract();
                DataToContract(crudeProductIdentifierRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductIdentifierRefData.FetchAllCount();
        }
        
        public List<CrudeProductIdentifierRefContract> FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductIdentifierRefContract>();
            List<CrudeProductIdentifierRefData> dataList = CrudeProductIdentifierRefData.FetchWithFilter(
                productIdentifierRcd: productIdentifierRcd,
                productIdentifierName: productIdentifierName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductIdentifierRefData data in dataList) {
                var crudeProductIdentifierRefContract = new CrudeProductIdentifierRefContract();
                DataToContract(data, crudeProductIdentifierRefContract);
                list.Add(crudeProductIdentifierRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductIdentifierRefContract contract) {
            var data = new CrudeProductIdentifierRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductIdentifierRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductIdentifierRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductIdentifierRefContract contract) {
            var data = new CrudeProductIdentifierRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductIdentifierRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductIdentifierRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productIdentifierRcd) {
            CrudeProductIdentifierRefData.Delete(productIdentifierRcd);
        }
        
        public static void ContractToData(CrudeProductIdentifierRefContract contract, CrudeProductIdentifierRefData data) {
            data.ProductIdentifierRcd = contract.ProductIdentifierRcd;
            data.ProductIdentifierName = contract.ProductIdentifierName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductIdentifierRefData data, CrudeProductIdentifierRefContract contract) {
            contract.ProductIdentifierRcd = data.ProductIdentifierRcd;
            contract.ProductIdentifierName = data.ProductIdentifierName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
