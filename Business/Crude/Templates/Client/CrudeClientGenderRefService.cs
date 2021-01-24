/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:24:49 AM
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

// Namespace for the Business Logic Layer
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  SOAP http services, using Windows Communication Framework
// links:
//  docLink: http://sql2x.org/documentationLink/0f3a62ca-e301-4d44-8e1a-de9198ba8967
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/a968e8fb-5158-4625-8911-47504426078b
    [ServiceContract()]
    public partial interface ICrudeClientGenderRefService {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/bbab4791-c9e7-49bf-90d5-fca19b1fedaa
        // parameters:
        //  clientGenderRcd: primary key of table client_gender_ref
        [OperationContract()]
        CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientGenderRefContract contract);
        
        [OperationContract()]
        void Update(CrudeClientGenderRefContract contract);
        
        [OperationContract()]
        void Delete(string clientGenderRcd);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //  and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_gender_ref's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/bccca991-4801-4ad4-80f0-0357a1249606
    public partial class CrudeClientGenderRefService : ICrudeClientGenderRefService {
        
        // fetch by Primary key into current object
        // links:
        //  docLink: http://sql2x.org/documentationLink/bbab4791-c9e7-49bf-90d5-fca19b1fedaa
        // parameters:
        //  clientGenderRcd: primary key of table client_gender_ref
        public CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd) {
            var dataAccessLayer = new CrudeClientGenderRefData();
            var contract = new CrudeClientGenderRefContract();

            dataAccessLayer.FetchByClientGenderRcd(clientGenderRcd);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName) {
            var dataAccessLayer = new CrudeClientGenderRefData();
            var contract = new CrudeClientGenderRefContract();

            dataAccessLayer.FetchByClientGenderName(clientGenderName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        // links:
        //  docLink: http://sql2x.org/documentationLink/a7599485-4f00-4ebf-974d-53f69c43654e
        public List<CrudeClientGenderRefContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientGenderRefData.FetchByUserId(userId));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/7467f97d-14e5-4ccf-9282-ef8df4f63088
        public static List<CrudeClientGenderRefContract> DataListToContractList(List<CrudeClientGenderRefData> dataList) {
            var contractList = new List<CrudeClientGenderRefContract>();

            foreach (CrudeClientGenderRefData data in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        // links:
        //  docLink: http://sql2x.org/documentationLink/1c6c6b9c-e201-4590-8c69-d38a0ad2a9f7
        public static void ContractListToDataList(List<CrudeClientGenderRefContract> contractList, List<CrudeClientGenderRefData> dataList) {
            foreach (CrudeClientGenderRefContract contract in contractList) {
                var data = new CrudeClientGenderRefData();
                CrudeClientGenderRefService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientGenderRefData to a List of SOAP Contracts
        // links:
        //  docLink: http://sql2x.org/documentationLink/9204c68e-93b8-4c77-af3c-3181985ff75f
        public List<CrudeClientGenderRefContract> FetchAll() {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAll();

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        // links:
        //  docLink: http://sql2x.org/documentationLink/f23c4cd8-e941-4b3e-8fda-7b2ac6a399f7
        public List<CrudeClientGenderRefContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAllWithLimit(limit);

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        // links:
        //  docLink: http://sql2x.org/documentationLink/3fe9f1b3-97b6-4f58-a0f2-adfcbd973bfc
        public List<CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientGenderRefData crudeClientGenderRef in dataList) {
                var contract = new CrudeClientGenderRefContract();
                DataToContract(crudeClientGenderRef, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/7cd5e52c-b3d7-4566-a27a-408d0732dd88
        public int FetchAllCount() {
            return CrudeClientGenderRefData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce01ef4a-5cd0-4e51-b211-9c0a15b791a0
        public List<CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            var list = new List<CrudeClientGenderRefContract>();
            List<CrudeClientGenderRefData> dataList = CrudeClientGenderRefData.FetchWithFilter(
                clientGenderRcd: clientGenderRcd,
                clientGenderName: clientGenderName,
                clientGenderDescription: clientGenderDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientGenderRefData data in dataList) {
                var crudeClientGenderRefContract = new CrudeClientGenderRefContract();
                DataToContract(data, crudeClientGenderRefContract);
                list.Add(crudeClientGenderRefContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        // links:
        //  docLink: http://sql2x.org/documentationLink/75aad010-e6aa-4f19-a6e5-597456aa20d8
        public void Insert(CrudeClientGenderRefContract contract) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/542f9458-c3b9-4edf-8575-0870086f3a7f
        public void Insert(CrudeClientGenderRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/ce75e72e-fb16-4f4e-a2e6-dbd079dfa206
        public void Update(CrudeClientGenderRefContract contract) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        // links:
        //  docLink: http://sql2x.org/documentationLink/b798ad6b-f4b8-466a-9086-6588a814fcf3
        public void Update(CrudeClientGenderRefContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientGenderRefData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        // links:
        //  docLink: http://sql2x.org/documentationLink/eb0597e0-8ea0-425c-88af-213a170bbd5e
        public void Delete(string clientGenderRcd) {
            CrudeClientGenderRefData.Delete(clientGenderRcd);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        // links:
        //  docLink: http://sql2x.org/documentationLink/10700d38-2227-4021-be12-2f4f206f5dd9
        public static void ContractToData(CrudeClientGenderRefContract contract, CrudeClientGenderRefData data) {
            data.ClientGenderRcd = contract.ClientGenderRcd;
            data.ClientGenderName = contract.ClientGenderName;
            data.ClientGenderDescription = contract.ClientGenderDescription;
            data.ActiveFlag = contract.ActiveFlag;
            data.SortOrder = contract.SortOrder;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        // links:
        //  docLink: http://sql2x.org/documentationLink/7553d6dd-da65-4a72-84c8-81f2f99ef4f5
        public static void DataToContract(CrudeClientGenderRefData data, CrudeClientGenderRefContract contract) {
            contract.ClientGenderRcd = data.ClientGenderRcd;
            contract.ClientGenderName = data.ClientGenderName;
            contract.ClientGenderDescription = data.ClientGenderDescription;
            contract.ActiveFlag = data.ActiveFlag;
            contract.SortOrder = data.SortOrder;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
