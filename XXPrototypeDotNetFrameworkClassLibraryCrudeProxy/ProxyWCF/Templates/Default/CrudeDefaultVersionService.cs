/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:32:21 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultVersion.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultVersionService")]
    public partial interface ICrudeDefaultVersionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/FetchByDefaultVersionId", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/FetchByDefaultVersionIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract FetchByDefaultVersionId(System.Guid defaultVersionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/DeleteResponse")]
        void Delete(System.Guid defaultVersionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultVersionService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultVersionService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultVersionServiceChannel : ICrudeDefaultVersionService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultVersionServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultVersionService>, ICrudeDefaultVersionService {
        
        public CrudeDefaultVersionServiceClient() {
        }
        
        public CrudeDefaultVersionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultVersionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultVersionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultVersionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract FetchByDefaultVersionId(System.Guid defaultVersionId) {
            return base.Channel.FetchByDefaultVersionId(defaultVersionId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultVersionId) {
            base.Channel.Delete(defaultVersionId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultVersionContract> FetchWithFilter(System.Guid defaultVersionId, string funVersion, string number, int majorNumber, int minorNumber, int sequenceNumber, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultVersionId: defaultVersionId,
                funVersion: funVersion,
                number: number,
                majorNumber: majorNumber,
                minorNumber: minorNumber,
                sequenceNumber: sequenceNumber,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
