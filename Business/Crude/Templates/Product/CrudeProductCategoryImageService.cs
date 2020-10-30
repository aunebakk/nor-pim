/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/30/2020 11:00:23 AM
  From Machine: DESKTOP-9A2DH39
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
    public partial interface ICrudeProductCategoryImageService {
        
        [OperationContract()]
        CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductCategoryImageContract contract);
        
        [OperationContract()]
        void Update(CrudeProductCategoryImageContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productCategoryImageId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_category_image's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductCategoryImageService : ICrudeProductCategoryImageService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productCategoryImageId: primary key of table product_category_image
        public CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId) {
            var dataAccessLayer = new CrudeProductCategoryImageData();
            var contract = new CrudeProductCategoryImageContract();

            dataAccessLayer.FetchByProductCategoryImageId(productCategoryImageId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return DataListToContractList(CrudeProductCategoryImageData.FetchByProductCategoryId(productCategoryId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductCategoryImageData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductCategoryImageContract> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            return DataListToContractList(CrudeProductCategoryImageData.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductCategoryImageContract> DataListToContractList(List<CrudeProductCategoryImageData> dataList) {
            var contractList = new List<CrudeProductCategoryImageContract>();

            foreach (CrudeProductCategoryImageData data in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductCategoryImageContract> contractList, List<CrudeProductCategoryImageData> dataList) {
            foreach (CrudeProductCategoryImageContract contract in contractList) {
                var data = new CrudeProductCategoryImageData();
                CrudeProductCategoryImageService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductCategoryImageData to a List of SOAP Contracts
        public List<CrudeProductCategoryImageContract> FetchAll() {
            var list = new List<CrudeProductCategoryImageContract>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAll();

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductCategoryImageContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductCategoryImageContract>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAllWithLimit(limit);

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductCategoryImageContract>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductCategoryImageData crudeProductCategoryImage in dataList) {
                var contract = new CrudeProductCategoryImageContract();
                DataToContract(crudeProductCategoryImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductCategoryImageData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductCategoryImageContract>();
            List<CrudeProductCategoryImageData> dataList = CrudeProductCategoryImageData.FetchWithFilter(
                productCategoryImageId: productCategoryImageId,
                productCategoryId: productCategoryId,
                productCategoryImageTypeRcd: productCategoryImageTypeRcd,
                image: image,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductCategoryImageData data in dataList) {
                var crudeProductCategoryImageContract = new CrudeProductCategoryImageContract();
                DataToContract(data, crudeProductCategoryImageContract);
                list.Add(crudeProductCategoryImageContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductCategoryImageContract contract) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductCategoryImageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductCategoryImageContract contract) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductCategoryImageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductCategoryImageData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productCategoryImageId) {
            CrudeProductCategoryImageData.Delete(productCategoryImageId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductCategoryImageContract contract, CrudeProductCategoryImageData data) {
            data.ProductCategoryImageId = contract.ProductCategoryImageId;
            data.ProductCategoryId = contract.ProductCategoryId;
            data.ProductCategoryImageTypeRcd = contract.ProductCategoryImageTypeRcd;
            data.Image = contract.Image;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductCategoryImageData data, CrudeProductCategoryImageContract contract) {
            contract.ProductCategoryImageId = data.ProductCategoryImageId;
            contract.ProductCategoryId = data.ProductCategoryId;
            contract.ProductCategoryImageTypeRcd = data.ProductCategoryImageTypeRcd;
            contract.Image = data.Image;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
