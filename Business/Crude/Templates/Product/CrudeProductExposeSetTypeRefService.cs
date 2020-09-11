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
    public partial interface ICrudeProductExposeSetTypeRefService {
        
        [OperationContract()]
        CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeName(string productExposeSetTypeName);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductExposeSetTypeRefContract contract);
        
        [OperationContract()]
        void Update(CrudeProductExposeSetTypeRefContract contract);
        
        [OperationContract()]
        void Delete(string productExposeSetTypeRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_expose_set_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductExposeSetTypeRefService : ICrudeProductExposeSetTypeRefService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productExposeSetTypeRcd: primary key of table product_expose_set_type_ref
        public CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var contract = new CrudeProductExposeSetTypeRefContract();

            dataAccessLayer.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeName(string productExposeSetTypeName) {
            var dataAccessLayer = new CrudeProductExposeSetTypeRefData();
            var contract = new CrudeProductExposeSetTypeRefContract();

            dataAccessLayer.FetchByProductExposeSetTypeName(productExposeSetTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductExposeSetTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductExposeSetTypeRefData.FetchByUserId(userId));
        }
        
        public static List<CrudeProductExposeSetTypeRefContract> DataListToContractList(List<CrudeProductExposeSetTypeRefData> dataList) {
            var contractList = new List<CrudeProductExposeSetTypeRefContract>();

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        public static void ContractListToDataList(List<CrudeProductExposeSetTypeRefContract> contractList, List<CrudeProductExposeSetTypeRefData> dataList) {
            foreach (CrudeProductExposeSetTypeRefContract contract in contractList) {
                var data = new CrudeProductExposeSetTypeRefData();
                CrudeProductExposeSetTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAll() {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAll();

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductExposeSetTypeRefData crudeProductExposeSetTypeRef in dataList) {
                var contract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(crudeProductExposeSetTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        public int FetchAllCount() {
            return CrudeProductExposeSetTypeRefData.FetchAllCount();
        }
        
        public List<CrudeProductExposeSetTypeRefContract> FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductExposeSetTypeRefContract>();
            List<CrudeProductExposeSetTypeRefData> dataList = CrudeProductExposeSetTypeRefData.FetchWithFilter(
                productExposeSetTypeRcd: productExposeSetTypeRcd,
                productExposeSetTypeName: productExposeSetTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductExposeSetTypeRefData data in dataList) {
                var crudeProductExposeSetTypeRefContract = new CrudeProductExposeSetTypeRefContract();
                DataToContract(data, crudeProductExposeSetTypeRefContract);
                list.Add(crudeProductExposeSetTypeRefContract);
            }

            return list;
        }
        
        public void Insert(CrudeProductExposeSetTypeRefContract contract) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        public void Insert(CrudeProductExposeSetTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        public void Update(CrudeProductExposeSetTypeRefContract contract) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        public void Update(CrudeProductExposeSetTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductExposeSetTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        public void Delete(string productExposeSetTypeRcd) {
            CrudeProductExposeSetTypeRefData.Delete(productExposeSetTypeRcd);
        }
        
        public static void ContractToData(CrudeProductExposeSetTypeRefContract contract, CrudeProductExposeSetTypeRefData data) {
            data.ProductExposeSetTypeRcd = contract.ProductExposeSetTypeRcd;
            data.ProductExposeSetTypeName = contract.ProductExposeSetTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        public static void DataToContract(CrudeProductExposeSetTypeRefData data, CrudeProductExposeSetTypeRefContract contract) {
            contract.ProductExposeSetTypeRcd = data.ProductExposeSetTypeRcd;
            contract.ProductExposeSetTypeName = data.ProductExposeSetTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
