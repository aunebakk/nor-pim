/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:33:46 PM
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
    public partial interface ICrudeClientAddressService {
        
        [OperationContract()]
        CrudeClientAddressContract FetchByClientAddressId(System.Guid clientAddressId);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchByClientId(System.Guid clientId);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchByUserId(System.Guid userId);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchByClientAddressTypeRcd(string clientAddressTypeRcd);
        
        [OperationContract()]
        CrudeClientAddressContract FetchByAddressLineOneName(string addressLineOneName);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchWithFilter(
                    System.Guid clientAddressId, 
                    System.Guid clientId, 
                    string clientAddressTypeRcd, 
                    string addressLineOneName, 
                    string addressLineTwoName, 
                    string addressLineThreeName, 
                    string cityName, 
                    string streetName, 
                    string stateName, 
                    string districtName, 
                    string provinceName, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchAll();
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchAllWithLimit(int limit);
        
        [OperationContract()]
        List<CrudeClientAddressContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [OperationContract()]
        int FetchAllCount();
        
        [OperationContract()]
        void Insert(CrudeClientAddressContract contract);
        
        [OperationContract()]
        void Update(CrudeClientAddressContract contract);
        
        [OperationContract()]
        void Delete(System.Guid clientAddressId);
    }
    
    // this class serves as a link to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //and transfers that data to a SOAP Contract ready to be exposed through WCF
    // this contract is an identical representation of client_address's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public partial class CrudeClientAddressService : ICrudeClientAddressService {
        
        // fetch by Primary key into current object
        // links:
        //   https://en.wikipedia.org/wiki/Create,_read,_update_and_delete: crud definition
        // parameters:
        //   clientAddressId: primary key of table client_address
        public CrudeClientAddressContract FetchByClientAddressId(System.Guid clientAddressId) {
            var dataAccessLayer = new CrudeClientAddressData();
            var contract = new CrudeClientAddressContract();

            dataAccessLayer.FetchByClientAddressId(clientAddressId);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        public CrudeClientAddressContract FetchByAddressLineOneName(string addressLineOneName) {
            var dataAccessLayer = new CrudeClientAddressData();
            var contract = new CrudeClientAddressContract();

            dataAccessLayer.FetchByAddressLineOneName(addressLineOneName);
            DataToContract(dataAccessLayer, contract);

            return contract;
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientAddressContract> FetchByClientId(System.Guid clientId) {
            return DataListToContractList(CrudeClientAddressData.FetchByClientId(clientId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientAddressContract> FetchByUserId(System.Guid userId) {
            return DataListToContractList(CrudeClientAddressData.FetchByUserId(userId));
        }
        
        // fetch by Foreign key into new List of class instances
        public List<CrudeClientAddressContract> FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            return DataListToContractList(CrudeClientAddressData.FetchByClientAddressTypeRcd(clientAddressTypeRcd));
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts
        public static List<CrudeClientAddressContract> DataListToContractList(List<CrudeClientAddressData> dataList) {
            var contractList = new List<CrudeClientAddressContract>();

            foreach (CrudeClientAddressData data in dataList) {
                var contract = new CrudeClientAddressContract();
                DataToContract(data, contract);
                contractList.Add(contract);
            }

            return contractList;
        }
        
        // copy all rows from a List of SOAP Contracts to a List of serialized data objects
        public static void ContractListToDataList(List<CrudeClientAddressContract> contractList, List<CrudeClientAddressData> dataList) {
            foreach (CrudeClientAddressContract contract in contractList) {
                var data = new CrudeClientAddressData();
                CrudeClientAddressService.ContractToData(contract, data);
                dataList.Add(data);
            }
        }
        
        // copy all rows from a List of serialized data objects in CrudeClientAddressData to a List of SOAP Contracts
        public List<CrudeClientAddressContract> FetchAll() {
            var list = new List<CrudeClientAddressContract>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAll();

            foreach (CrudeClientAddressData crudeClientAddress in dataList) {
                var contract = new CrudeClientAddressContract();
                DataToContract(crudeClientAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns
        public List<CrudeClientAddressContract> FetchAllWithLimit(int limit) {
            var list = new List<CrudeClientAddressContract>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAllWithLimit(limit);

            foreach (CrudeClientAddressData crudeClientAddress in dataList) {
                var contract = new CrudeClientAddressContract();
                DataToContract(crudeClientAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // copy all rows from a List of serialized data objects to a List of SOAP Contracts, 
        //  with a limit on number of returned rows and order by columns, starting at a specific row
        public List<CrudeClientAddressContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            var list = new List<CrudeClientAddressContract>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchAllWithLimitAndOffset(limit, offset);

            foreach (CrudeClientAddressData crudeClientAddress in dataList) {
                var contract = new CrudeClientAddressContract();
                DataToContract(crudeClientAddress, contract);
                list.Add(contract);
            }

            return list;
        }
        
        // get a count of rows in table
        public int FetchAllCount() {
            return CrudeClientAddressData.FetchAllCount();
        }
        
        // fetch all rows from table into new List of Contracts, filtered by any column
        public List<CrudeClientAddressContract> FetchWithFilter(
                    System.Guid clientAddressId, 
                    System.Guid clientId, 
                    string clientAddressTypeRcd, 
                    string addressLineOneName, 
                    string addressLineTwoName, 
                    string addressLineThreeName, 
                    string cityName, 
                    string streetName, 
                    string stateName, 
                    string districtName, 
                    string provinceName, 
                    string zipCode, 
                    string poBox, 
                    string comment, 
                    System.Guid userId, 
                    System.DateTime dateTime) {
            var list = new List<CrudeClientAddressContract>();
            List<CrudeClientAddressData> dataList = CrudeClientAddressData.FetchWithFilter(
                clientAddressId: clientAddressId,
                clientId: clientId,
                clientAddressTypeRcd: clientAddressTypeRcd,
                addressLineOneName: addressLineOneName,
                addressLineTwoName: addressLineTwoName,
                addressLineThreeName: addressLineThreeName,
                cityName: cityName,
                streetName: streetName,
                stateName: stateName,
                districtName: districtName,
                provinceName: provinceName,
                zipCode: zipCode,
                poBox: poBox,
                comment: comment,
                userId: userId,
                dateTime: dateTime
                );

            foreach (CrudeClientAddressData data in dataList) {
                var crudeClientAddressContract = new CrudeClientAddressContract();
                DataToContract(data, crudeClientAddressContract);
                list.Add(crudeClientAddressContract);
            }

            return list;
        }
        
        // insert all object members as a new row in table
        public void Insert(CrudeClientAddressContract contract) {
            var data = new CrudeClientAddressData();
            ContractToData(contract, data);
            data.Insert();
        }
        
        // insert all object members as a new row in table, in a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Insert(CrudeClientAddressContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressData();
            ContractToData(contract, data);
            data.Insert(connection, transaction);
        }
        
        // update all object members on a row in table based on primary key
        public void Update(CrudeClientAddressContract contract) {
            var data = new CrudeClientAddressData();
            ContractToData(contract, data);
            data.Update();
        }
        
        // update all object members on a row in table based on primary key, on a transaction
        // the transaction and or connection state is not changed in any way other than what SqlClient does to it.
        // it is the callers responsibility to commit or rollback the transaction
        public void Update(CrudeClientAddressContract contract, SqlConnection connection, SqlTransaction transaction) {
            var data = new CrudeClientAddressData();
            ContractToData(contract, data);
            data.Update(connection, transaction);
        }
        
        // delete a row in table based on primary key
        public void Delete(System.Guid clientAddressId) {
            CrudeClientAddressData.Delete(clientAddressId);
        }
        
        // copy all columns from a SOAP Contract to a serialized data object
        public static void ContractToData(CrudeClientAddressContract contract, CrudeClientAddressData data) {
            data.ClientAddressId = contract.ClientAddressId;
            data.ClientId = contract.ClientId;
            data.ClientAddressTypeRcd = contract.ClientAddressTypeRcd;
            data.AddressLineOneName = contract.AddressLineOneName;
            data.AddressLineTwoName = contract.AddressLineTwoName;
            data.AddressLineThreeName = contract.AddressLineThreeName;
            data.CityName = contract.CityName;
            data.StreetName = contract.StreetName;
            data.StateName = contract.StateName;
            data.DistrictName = contract.DistrictName;
            data.ProvinceName = contract.ProvinceName;
            data.ZipCode = contract.ZipCode;
            data.PoBox = contract.PoBox;
            data.Comment = contract.Comment;
            data.UserId = contract.UserId;
            data.DateTime = contract.DateTime;
        }
        
        // copy all columns from a serialized data object to a SOAP Contract
        public static void DataToContract(CrudeClientAddressData data, CrudeClientAddressContract contract) {
            contract.ClientAddressId = data.ClientAddressId;
            contract.ClientId = data.ClientId;
            contract.ClientAddressTypeRcd = data.ClientAddressTypeRcd;
            contract.AddressLineOneName = data.AddressLineOneName;
            contract.AddressLineTwoName = data.AddressLineTwoName;
            contract.AddressLineThreeName = data.AddressLineThreeName;
            contract.CityName = data.CityName;
            contract.StreetName = data.StreetName;
            contract.StateName = data.StateName;
            contract.DistrictName = data.DistrictName;
            contract.ProvinceName = data.ProvinceName;
            contract.ZipCode = data.ZipCode;
            contract.PoBox = data.PoBox;
            contract.Comment = data.Comment;
            contract.UserId = data.UserId;
            contract.DateTime = data.DateTime;
        }
    }
}
