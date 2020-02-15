/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:39:26 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialFee.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialFeeService")]
    public partial interface ICrudeFinancialFeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchByFinancialFeeId", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchByFinancialFeeIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract FetchByFinancialFeeId(System.Guid financialFeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchByFinancialCurrencyIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchByFinancialFeeTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchByFinancialFeeTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/DeleteResponse")]
        void Delete(System.Guid financialFeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialFeeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialFeeService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchWithFilter(System.Guid financialFeeId, System.Guid userId, System.DateTime dateTime, string financialFeeTypeRcd, System.Guid financialCurrencyId, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialFeeServiceChannel : ICrudeFinancialFeeService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialFeeServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialFeeService>, ICrudeFinancialFeeService {
        
        public CrudeFinancialFeeServiceClient() {
        }
        
        public CrudeFinancialFeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialFeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialFeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialFeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract FetchByFinancialFeeId(System.Guid financialFeeId) {
            return base.Channel.FetchByFinancialFeeId(financialFeeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchByFinancialFeeTypeRcd(string financialFeeTypeRcd) {
            return base.Channel.FetchByFinancialFeeTypeRcd(financialFeeTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialFeeId) {
            base.Channel.Delete(financialFeeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialFeeContract> FetchWithFilter(System.Guid financialFeeId, System.Guid userId, System.DateTime dateTime, string financialFeeTypeRcd, System.Guid financialCurrencyId, decimal amount) {
            return base.Channel.FetchWithFilter(
                financialFeeId: financialFeeId,
                userId: userId,
                dateTime: dateTime,
                financialFeeTypeRcd: financialFeeTypeRcd,
                financialCurrencyId: financialCurrencyId,
                amount: amount
                );
        }
    }
}
