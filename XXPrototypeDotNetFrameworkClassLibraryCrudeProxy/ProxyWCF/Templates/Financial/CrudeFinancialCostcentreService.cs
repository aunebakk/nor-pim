/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:43:08 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialCostcentre.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialCostcentreService")]
    public partial interface ICrudeFinancialCostcentreService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchByFinancialCostcentreId", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchByFinancialCostcentreIdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract FetchByFinancialCostcentreId(System.Guid financialCostcentreId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchByFinancialCompanyId", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchByFinancialCompanyIdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchByFinancialCompanyId(System.Guid financialCompanyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/DeleteResponse")]
        void Delete(System.Guid financialCostcentreId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchByFinancialCostcentreNam" +
            "e", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchByFinancialCostcentreNam" +
            "eResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract FetchByFinancialCostcentreName(string financialCostcentreName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialCostcentreService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialCostcentreService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchWithFilter(System.Guid financialCostcentreId, string financialCostcentreName, string financialCostcentreCode, System.Guid financialCompanyId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialCostcentreServiceChannel : ICrudeFinancialCostcentreService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialCostcentreServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialCostcentreService>, ICrudeFinancialCostcentreService {
        
        public CrudeFinancialCostcentreServiceClient() {
        }
        
        public CrudeFinancialCostcentreServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialCostcentreServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCostcentreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialCostcentreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract FetchByFinancialCostcentreId(System.Guid financialCostcentreId) {
            return base.Channel.FetchByFinancialCostcentreId(financialCostcentreId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchByFinancialCompanyId(System.Guid financialCompanyId) {
            return base.Channel.FetchByFinancialCompanyId(financialCompanyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialCostcentreId) {
            base.Channel.Delete(financialCostcentreId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract FetchByFinancialCostcentreName(string financialCostcentreName) {
            return base.Channel.FetchByFinancialCostcentreName(financialCostcentreName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialCostcentreContract> FetchWithFilter(System.Guid financialCostcentreId, string financialCostcentreName, string financialCostcentreCode, System.Guid financialCompanyId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialCostcentreId: financialCostcentreId,
                financialCostcentreName: financialCostcentreName,
                financialCostcentreCode: financialCostcentreCode,
                financialCompanyId: financialCompanyId,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
