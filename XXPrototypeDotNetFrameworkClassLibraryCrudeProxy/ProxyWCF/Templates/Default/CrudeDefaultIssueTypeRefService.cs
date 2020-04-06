/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 4:37:03 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultIssueTypeRef.json
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
    
    
    public partial class DefaultIssueTypeRef {
        
        public const string Bug = "Bug";
        
        public const string ChangeRequest = "Change";
        
        public const string IncorrectBehavior = "Incorrect";
        
        public const string FeatureRequest = "Request";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultIssueTypeRefService")]
    public partial interface ICrudeDefaultIssueTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchByDefaultIssueTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchByDefaultIssueTypeRcdRes" +
            "ponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/DeleteResponse")]
        void Delete(string defaultIssueTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchByDefaultIssueTypeName", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchByDefaultIssueTypeNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeName(string defaultIssueTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultIssueTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchWithFilter(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultIssueTypeRefServiceChannel : ICrudeDefaultIssueTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultIssueTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultIssueTypeRefService>, ICrudeDefaultIssueTypeRefService {
        
        public CrudeDefaultIssueTypeRefServiceClient() {
        }
        
        public CrudeDefaultIssueTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultIssueTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultIssueTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeRcd(string defaultIssueTypeRcd) {
            return base.Channel.FetchByDefaultIssueTypeRcd(defaultIssueTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultIssueTypeRcd) {
            base.Channel.Delete(defaultIssueTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract FetchByDefaultIssueTypeName(string defaultIssueTypeName) {
            return base.Channel.FetchByDefaultIssueTypeName(defaultIssueTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultIssueTypeRefContract> FetchWithFilter(string defaultIssueTypeRcd, string defaultIssueTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultIssueTypeRcd: defaultIssueTypeRcd,
                defaultIssueTypeName: defaultIssueTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
