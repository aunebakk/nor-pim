/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:43:27 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialOrderEventTypeRef.json
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
    
    
    public partial class FinancialOrderEventTypeRef {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialOrderEventTypeRefService")]
    public partial interface ICrudeFinancialOrderEventTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchByFinancialOrderE" +
            "ventTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchByFinancialOrderE" +
            "ventTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/DeleteResponse")]
        void Delete(string financialOrderEventTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchByFinancialOrderE" +
            "ventTypeName", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchByFinancialOrderE" +
            "ventTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract FetchByFinancialOrderEventTypeName(string financialOrderEventTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchAllWithLimitRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchAllWithLimitAndOf" +
            "fset", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchAllWithLimitAndOf" +
            "fsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialOrderEventTypeRefService/FetchWithFilterRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchWithFilter(string financialOrderEventTypeRcd, string financialOrderEventTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialOrderEventTypeRefServiceChannel : ICrudeFinancialOrderEventTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialOrderEventTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialOrderEventTypeRefService>, ICrudeFinancialOrderEventTypeRefService {
        
        public CrudeFinancialOrderEventTypeRefServiceClient() {
        }
        
        public CrudeFinancialOrderEventTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialOrderEventTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderEventTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialOrderEventTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract FetchByFinancialOrderEventTypeRcd(string financialOrderEventTypeRcd) {
            return base.Channel.FetchByFinancialOrderEventTypeRcd(financialOrderEventTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialOrderEventTypeRcd) {
            base.Channel.Delete(financialOrderEventTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract FetchByFinancialOrderEventTypeName(string financialOrderEventTypeName) {
            return base.Channel.FetchByFinancialOrderEventTypeName(financialOrderEventTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialOrderEventTypeRefContract> FetchWithFilter(string financialOrderEventTypeRcd, string financialOrderEventTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialOrderEventTypeRcd: financialOrderEventTypeRcd,
                financialOrderEventTypeName: financialOrderEventTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
