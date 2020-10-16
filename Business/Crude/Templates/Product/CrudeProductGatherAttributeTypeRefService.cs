/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:04 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeSoap.DefaultUsing
*/
using SolutionNorSolutionPim.DataAccessLayer;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ServiceModel;

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
    public partial interface ICrudeProductGatherAttributeTypeRefService {

        [OperationContract()]
        CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);

        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId);

        [OperationContract()]
        CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName);

        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime);

        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAll();

        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit);

        [OperationContract()]
        List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);

        [OperationContract()]
        int FetchAllCount();

        [OperationContract()]
        void Insert(CrudeProductGatherAttributeTypeRefContract contract);

        [OperationContract()]
        void Update(CrudeProductGatherAttributeTypeRefContract contract);

        [OperationContract()]
        void Delete(string productGatherAttributeTypeRcd);
    }

    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of product_gather_attribute_type_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeProductGatherAttributeTypeRefService : ICrudeProductGatherAttributeTypeRefService {

        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   productGatherAttributeTypeRcd: primary key of table product_gather_attribute_type_ref
        public CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            CrudeProductGatherAttributeTypeRefData dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            CrudeProductGatherAttributeTypeRefContract contract = new CrudeProductGatherAttributeTypeRefContract();

            dataAccessLayer.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }

        public CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeName(string productGatherAttributeTypeName) {
            CrudeProductGatherAttributeTypeRefData dataAccessLayer = new CrudeProductGatherAttributeTypeRefData();
            CrudeProductGatherAttributeTypeRefContract contract = new CrudeProductGatherAttributeTypeRefContract();

            dataAccessLayer.FetchByProductGatherAttributeTypeName(productGatherAttributeTypeName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }

        // fetch by Foreign key into new List of class instances
        public List<CrudeProductGatherAttributeTypeRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeProductGatherAttributeTypeRefData.FetchByUserId(userId));
        }

        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeProductGatherAttributeTypeRefContract> DataListToContractList(List<CrudeProductGatherAttributeTypeRefData> dataList) {
            List<CrudeProductGatherAttributeTypeRefContract> contractList = new List<CrudeProductGatherAttributeTypeRefContract>();

            foreach (CrudeProductGatherAttributeTypeRefData data in dataList) {
                CrudeProductGatherAttributeTypeRefContract contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }

        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeProductGatherAttributeTypeRefContract> contractList, List<CrudeProductGatherAttributeTypeRefData> dataList) {
            foreach (CrudeProductGatherAttributeTypeRefContract contract in contractList) {
                CrudeProductGatherAttributeTypeRefData data = new CrudeProductGatherAttributeTypeRefData();
                CrudeProductGatherAttributeTypeRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }

        // copy all rows from a List of serialized data objects in CrudeProductGatherAttributeTypeRefData to a List of SOAP Contracts
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAll() {
            List<CrudeProductGatherAttributeTypeRefContract> list = new List<CrudeProductGatherAttributeTypeRefContract>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAll();

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                CrudeProductGatherAttributeTypeRefContract contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }

        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimit(int limit) {
            List<CrudeProductGatherAttributeTypeRefContract> list = new List<CrudeProductGatherAttributeTypeRefContract>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAllWithLimit(limit);

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                CrudeProductGatherAttributeTypeRefContract contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }

        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeProductGatherAttributeTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            List<CrudeProductGatherAttributeTypeRefContract> list = new List<CrudeProductGatherAttributeTypeRefContract>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeProductGatherAttributeTypeRefData crudeProductGatherAttributeTypeRef in dataList) {
                CrudeProductGatherAttributeTypeRefContract contract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(crudeProductGatherAttributeTypeRef, contract);
                list.Add(contract);
            }

            return list;
        }

        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeProductGatherAttributeTypeRefData.FetchAllCount();
        }

        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeProductGatherAttributeTypeRefContract> FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime) {
            List<CrudeProductGatherAttributeTypeRefContract> list = new List<CrudeProductGatherAttributeTypeRefContract>();
            List<CrudeProductGatherAttributeTypeRefData> dataList = CrudeProductGatherAttributeTypeRefData.FetchWithFilter(
                productGatherAttributeTypeRcd: productGatherAttributeTypeRcd,
                productGatherAttributeTypeName: productGatherAttributeTypeName,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeProductGatherAttributeTypeRefData data in dataList) {
                CrudeProductGatherAttributeTypeRefContract crudeProductGatherAttributeTypeRefContract = new CrudeProductGatherAttributeTypeRefContract();
                DataToContract(data, crudeProductGatherAttributeTypeRefContract);
                list.Add(crudeProductGatherAttributeTypeRefContract);
            }

            return list;
        }

        // insert all object members as a new row in table
        public void Insert(CrudeProductGatherAttributeTypeRefContract contract) {
            CrudeProductGatherAttributeTypeRefData data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Insert();
        }

        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeProductGatherAttributeTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            CrudeProductGatherAttributeTypeRefData data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }

        // update all object members on a row in table based on primary key
        public void Update(CrudeProductGatherAttributeTypeRefContract contract) {
            CrudeProductGatherAttributeTypeRefData data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Update();
        }

        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeProductGatherAttributeTypeRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            CrudeProductGatherAttributeTypeRefData data = new CrudeProductGatherAttributeTypeRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }

        // delete a row in table based on primary key
        public void Delete(string productGatherAttributeTypeRcd) {
            CrudeProductGatherAttributeTypeRefData.Delete(productGatherAttributeTypeRcd);
        }

        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeProductGatherAttributeTypeRefContract contract, CrudeProductGatherAttributeTypeRefData data) {
            data.ProductGatherAttributeTypeRcd = contract.ProductGatherAttributeTypeRcd;
            data.ProductGatherAttributeTypeName = contract.ProductGatherAttributeTypeName;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }

        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeProductGatherAttributeTypeRefData data, CrudeProductGatherAttributeTypeRefContract contract) {
            contract.ProductGatherAttributeTypeRcd = data.ProductGatherAttributeTypeRcd;
            contract.ProductGatherAttributeTypeName = data.ProductGatherAttributeTypeName;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
