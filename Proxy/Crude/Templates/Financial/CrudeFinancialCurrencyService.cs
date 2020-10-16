/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:53:11 PM
  From Machine: DESKTOP-742U247
  Filename: FinancialCurrency.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: CrudeProxy
  Documentation:
    WCF Client Proxy layer for accessing Azure Storage Tables through
      CIFUDE ( Create Insert Fetch Update Delete and Extra Operations )
      Works for dotNetFramework
*/
using System.Collections.Generic;

// Client Proxy Layer
// the ClientProxyLayer is where the SOAP services ties into the Client layer
//  this layer is used for, among other technologies, dotNetFramework WinForm,
//  ASP and TypeScript User Interfaces or from one business layer to another
// links:
//   https://en.wikipedia.org/wiki/Business_logic: business logic layer
//   https://www.c-sharpcorner.com/UploadFile/8a67c0/proxy-class-for-the-wcf-service/: client Proxy
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this interface is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ICrudeFinancialCurrencyService")]
    public partial interface ICrudeFinancialCurrencyService {

        // fetch one row by the tables primary key
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyId", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyIdRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract FetchByFinancialCurrencyId(System.Guid financialCurrencyId);

        // fetch all rows matching foreign key: UserId
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByUserId", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByUserId(System.Guid userId);

        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyTypeRcd" +
            "", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyTypeRcd" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd);

        // Fetch by Foreign key (reference)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyAgainst" +
            "FinancialCurrencyTypeRcd", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyAgainst" +
            "FinancialCurrencyTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd);

        // insert all object members as a new row in table
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/Insert", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract contract);

        // update all object members on a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/Update", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract contract);

        // delete a row in table based on primary key
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/Delete", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/DeleteResponse")]
        void Delete(System.Guid financialCurrencyId);

        // fetch by Picker Member into new class instance
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyTypeNam" +
            "e", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyTypeNam" +
            "eResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName);

        // fetch all rows from table financial_currency into new List of class instances
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchAll", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAll();

        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllWithLimit", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAllWithLimit(int limit);

        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllWithLimitAndOffset", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllWithLimitAndOffsetRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAllWithLimitAndOffset(int limit, int offset);

        // get a count of rows in table
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllCount", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllCountResponse")]
        int FetchAllCount();

        // fetch all from table into new List of class instances, filtered by any column
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchWithFilter", ReplyAction = "http://tempuri.org/ICrudeFinancialCurrencyService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchWithFilter(System.Guid financialCurrencyId, string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime dateTime, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName);
    }

    // this service channel class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialCurrencyServiceChannel : ICrudeFinancialCurrencyService, System.ServiceModel.IClientChannel {
    }

    // this service model class is used to consume SOAP Services as C# objects using WCF
    // links:
    //   https://en.wikipedia.org/wiki/SOAP: SOAP ( Simple Object Access Protocol )
    //   https://en.wikipedia.org/wiki/Windows_Communication_Foundation: WCF ( Windows Communication Foundation )
    public class CrudeFinancialCurrencyServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialCurrencyService>, ICrudeFinancialCurrencyService {

        public CrudeFinancialCurrencyServiceClient() {
        }

        // constructors for end point address, binding and contracts
        public CrudeFinancialCurrencyServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        public CrudeFinancialCurrencyServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public CrudeFinancialCurrencyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public CrudeFinancialCurrencyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        // fetch one row by the tables primary key
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }

        // fetch all rows matching foreign key: UserId
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }

        // fetch all rows matching foreign key: FinancialCurrencyTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            return base.Channel.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd);
        }

        // fetch all rows matching foreign key: FinancialCurrencyAgainstFinancialCurrencyTypeRcd
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd) {
            return base.Channel.FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(financialCurrencyAgainstFinancialCurrencyTypeRcd);
        }

        // insert all object members as a new row in table
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract contract) {
            base.Channel.Insert(contract);
        }

        // update all object members on a row in table based on primary key
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract contract) {
            base.Channel.Update(contract);
        }

        // delete a row in table based on primary key
        public void Delete(System.Guid financialCurrencyId) {
            base.Channel.Delete(financialCurrencyId);
        }

        // fetch by Picker Member into new class instance
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            return base.Channel.FetchByFinancialCurrencyTypeName(financialCurrencyTypeName);
        }

        // fetch all rows from table financial_currency into new List of class instances
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAll() {
            return base.Channel.FetchAll();
        }

        // fetch all from table into new List of class instances, with a limit on number of returned rows and order by columns
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }

        // fetch all from table into new List of class instances, only populating specific columns,
        //  with a limit on number of returned rows and order by columns starting at a specific row
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit, offset);
        }

        // get a count of rows in table
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }

        // fetch all from table into new List of class instances, filtered by any column
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchWithFilter(System.Guid financialCurrencyId, string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime dateTime, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName) {
            return base.Channel.FetchWithFilter(
                financialCurrencyId: financialCurrencyId,
                financialCurrencyTypeRcd: financialCurrencyTypeRcd,
                financialCurrencyAgainstFinancialCurrencyTypeRcd: financialCurrencyAgainstFinancialCurrencyTypeRcd,
                userId: userId,
                dateTime: dateTime,
                validFromDateTime: validFromDateTime,
                validUntilDateTime: validUntilDateTime,
                amount: amount,
                equalsAmount: equalsAmount,
                decimalCount: decimalCount,
                financialCurrencyTypeCode: financialCurrencyTypeCode,
                financialCurrencyTypeName: financialCurrencyTypeName
                );
        }
    }
}
