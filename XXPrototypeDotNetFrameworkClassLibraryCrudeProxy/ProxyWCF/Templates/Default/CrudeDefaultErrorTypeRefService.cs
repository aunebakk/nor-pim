/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:57:41 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultErrorTypeRef.json
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
    
    
    public partial class DefaultErrorTypeRef {
        
        public const string Engine = "Engine";
        
        public const string SilentCaught = "Silent";
        
        public const string AutomatedTest = "Test";
        
        public const string UserInitiated = "User";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultErrorTypeRefService")]
    public partial interface ICrudeDefaultErrorTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchByDefaultErrorTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchByDefaultErrorTypeRcdRes" +
            "ponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/DeleteResponse")]
        void Delete(string defaultErrorTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchByDefaultErrorTypeName", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchByDefaultErrorTypeNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeName(string defaultErrorTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultErrorTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchWithFilter(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultErrorTypeRefServiceChannel : ICrudeDefaultErrorTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultErrorTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultErrorTypeRefService>, ICrudeDefaultErrorTypeRefService {
        
        public CrudeDefaultErrorTypeRefServiceClient() {
        }
        
        public CrudeDefaultErrorTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultErrorTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            return base.Channel.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultErrorTypeRcd) {
            base.Channel.Delete(defaultErrorTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract FetchByDefaultErrorTypeName(string defaultErrorTypeName) {
            return base.Channel.FetchByDefaultErrorTypeName(defaultErrorTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorTypeRefContract> FetchWithFilter(string defaultErrorTypeRcd, string defaultErrorTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultErrorTypeRcd: defaultErrorTypeRcd,
                defaultErrorTypeName: defaultErrorTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
