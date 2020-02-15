/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 2/15/2020 3:39:25 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialCompany.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialCompanyService")]
    public partial interface ICrudeFinancialCompanyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/FetchByFinancialCompanyId", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/FetchByFinancialCompanyIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract FetchByFinancialCompanyId(System.Guid financialCompanyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/DeleteResponse")]
        void Delete(System.Guid financialCompanyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/FetchByFinancialCompanyName", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/FetchByFinancialCompanyNameRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract FetchByFinancialCompanyName(string financialCompanyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCompanyService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialCompanyService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchWithFilter(System.Guid financialCompanyId, string financialCompanyName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialCompanyServiceChannel : ICrudeFinancialCompanyService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialCompanyServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialCompanyService>, ICrudeFinancialCompanyService {
        
        public CrudeFinancialCompanyServiceClient() {
        }
        
        public CrudeFinancialCompanyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialCompanyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCompanyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCompanyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract FetchByFinancialCompanyId(System.Guid financialCompanyId) {
            return base.Channel.FetchByFinancialCompanyId(financialCompanyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialCompanyId) {
            base.Channel.Delete(financialCompanyId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract FetchByFinancialCompanyName(string financialCompanyName) {
            return base.Channel.FetchByFinancialCompanyName(financialCompanyName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCompanyContract> FetchWithFilter(System.Guid financialCompanyId, string financialCompanyName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialCompanyId: financialCompanyId,
                financialCompanyName: financialCompanyName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
