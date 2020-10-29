/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 9:07:15 PM
  From Machine: DESKTOP-742U247
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
    public partial interface ICrudeProductImageService {
        
        [OperationContract()]
        CrudeProductImageContract FetchByProductImageId(System.Guid productImageId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchByProductId(System.Guid productId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [OperationContract()]
        CrudeProductImageContract FetchByImageFileName(string imageFileName);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchAll();
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeProductImageContract contract);
        
        [OperationContract()]
        void Update(CrudeProductImageContract contract);
        
        [OperationContract()]
        void Delete(System.Guid productImageId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_image's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductImageService : ICrudeProductImageService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productImageId: primary key of table product_image
        public CrudeProductImageContract FetchByProductImageId(System.Guid productImageId) {
            var dataAccessLayer = new CrudeProductImageData();
            var contract = new CrudeProductImageContract();

            dataAccessLayer.FetchByProductImageId(productImageId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeProductImageContract FetchByImageFileName(string imageFileName) {
            var dataAccessLayer = new CrudeProductImageData();
            var contract = new CrudeProductImageContract();

            dataAccessLayer.FetchByImageFileName(imageFileName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductImageContract> FetchByProductId(System.Guid productId) {
            return DataListToContractList(CrudeProductImageData.FetchByProductId(productId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductImageContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductImageData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeProductImageContract> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return DataListToContractList(CrudeProductImageData.FetchByProductImageTypeRcd(productImageTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductImageContract> DataListToContractList(List<CrudeProductImageData> dataList) {
            var contractList = new List<CrudeProductImageContract>();

            foreach (CrudeProductImageData data in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductImageContract> contractList, List<CrudeProductImageData> dataList) {
            foreach (CrudeProductImageContract contract in contractList) {
                var data = new CrudeProductImageData();
                CrudeProductImageService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeProductImageData to a List of SOAP Contracts
        public List<CrudeProductImageContract> FetchAll() {
            var list = new List<CrudeProductImageContract>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAll();

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductImageContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeProductImageContract>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAllWithLimit(limit);

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeProductImageContract>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductImageData crudeProductImage in dataList) {
                var contract = new CrudeProductImageContract();
                DataToContract(crudeProductImage, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductImageData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeProductImageContract>();
            List<CrudeProductImageData> dataList = CrudeProductImageData.FetchWithFilter(
                productImageId: productImageId,
                productId: productId,
                productImageTypeRcd: productImageTypeRcd,
                imageFileName: imageFileName,
                image: image,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductImageData data in dataList) {
                var crudeProductImageContract = new CrudeProductImageContract();
                DataToContract(data, crudeProductImageContract);
                list.Add(crudeProductImageContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeProductImageContract contract) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductImageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeProductImageContract contract) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductImageContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeProductImageData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid productImageId) {
            CrudeProductImageData.Delete(productImageId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductImageContract contract, CrudeProductImageData data) {
            data.ProductImageId = contract.ProductImageId;
            data.ProductId = contract.ProductId;
            data.ProductImageTypeRcd = contract.ProductImageTypeRcd;
            data.ImageFileName = contract.ImageFileName;
            data.Image = contract.Image;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductImageData data, CrudeProductImageContract contract) {
            contract.ProductImageId = data.ProductImageId;
            contract.ProductId = data.ProductId;
            contract.ProductImageTypeRcd = data.ProductImageTypeRcd;
            contract.ImageFileName = data.ImageFileName;
            contract.Image = data.Image;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
