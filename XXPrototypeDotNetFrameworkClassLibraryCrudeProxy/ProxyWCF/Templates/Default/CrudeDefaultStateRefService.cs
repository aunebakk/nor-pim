/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:57 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultStateRef.json
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
    
    
    public partial class DefaultStateRef {
        
        public const string Created = "C";
        
        public const string Invalidated = "I";
        
        public const string Updated = "U";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultStateRefService")]
    public partial interface ICrudeDefaultStateRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/FetchByDefaultStateRcd", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/FetchByDefaultStateRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract FetchByDefaultStateRcd(string defaultStateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/DeleteResponse")]
        void Delete(string defaultStateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/FetchByDefaultStateName", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/FetchByDefaultStateNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract FetchByDefaultStateName(string defaultStateName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultStateRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultStateRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchWithFilter(string defaultStateRcd, string defaultStateName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultStateRefServiceChannel : ICrudeDefaultStateRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultStateRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultStateRefService>, ICrudeDefaultStateRefService {
        
        public CrudeDefaultStateRefServiceClient() {
        }
        
        public CrudeDefaultStateRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultStateRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultStateRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultStateRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract FetchByDefaultStateRcd(string defaultStateRcd) {
            return base.Channel.FetchByDefaultStateRcd(defaultStateRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultStateRcd) {
            base.Channel.Delete(defaultStateRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract FetchByDefaultStateName(string defaultStateName) {
            return base.Channel.FetchByDefaultStateName(defaultStateName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultStateRefContract> FetchWithFilter(string defaultStateRcd, string defaultStateName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultStateRcd: defaultStateRcd,
                defaultStateName: defaultStateName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
