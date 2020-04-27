/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:27 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialCurrency.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: CrudeProxy
  Documentation:
    WCF Client Proxy layer for accessing Azure Storage Tables through
      CIFUDE ( Create Insert Fetch Update Delete and Extra Operations )
      Works for dotNetFramework
*/
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialCurrencyService")]
    public partial interface ICrudeFinancialCurrencyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyIdRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyTypeRcd" +
            "", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyTypeRcd" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyAgainst" +
            "FinancialCurrencyTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyAgainst" +
            "FinancialCurrencyTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/DeleteResponse")]
        void Delete(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyTypeNam" +
            "e", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchByFinancialCurrencyTypeNam" +
            "eResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllWithLimitAndOffsetRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCurrencyService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialCurrencyService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchWithFilter(System.Guid financialCurrencyId, string financialCurrencyTypeRcd, string financialCurrencyAgainstFinancialCurrencyTypeRcd, System.Guid userId, System.DateTime dateTime, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, decimal amount, decimal equalsAmount, int decimalCount, string financialCurrencyTypeCode, string financialCurrencyTypeName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialCurrencyServiceChannel : ICrudeFinancialCurrencyService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialCurrencyServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialCurrencyService>, ICrudeFinancialCurrencyService {
        
        public CrudeFinancialCurrencyServiceClient() {
        }
        
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
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByFinancialCurrencyTypeRcd(string financialCurrencyTypeRcd) {
            return base.Channel.FetchByFinancialCurrencyTypeRcd(financialCurrencyTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(string financialCurrencyAgainstFinancialCurrencyTypeRcd) {
            return base.Channel.FetchByFinancialCurrencyAgainstFinancialCurrencyTypeRcd(financialCurrencyAgainstFinancialCurrencyTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialCurrencyId) {
            base.Channel.Delete(financialCurrencyId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract FetchByFinancialCurrencyTypeName(string financialCurrencyTypeName) {
            return base.Channel.FetchByFinancialCurrencyTypeName(financialCurrencyTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCurrencyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
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
