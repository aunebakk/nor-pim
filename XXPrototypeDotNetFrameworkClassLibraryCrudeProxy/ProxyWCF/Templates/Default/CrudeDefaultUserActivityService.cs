/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:35:49 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultUserActivity.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultUserActivityService")]
    public partial interface ICrudeDefaultUserActivityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/FetchByDefaultUserActivityId", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/FetchByDefaultUserActivityIdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract FetchByDefaultUserActivityId(System.Guid defaultUserActivityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/FetchByDefaultUserActivityTyp" +
            "eRcd", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/FetchByDefaultUserActivityTyp" +
            "eRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/DeleteResponse")]
        void Delete(System.Guid defaultUserActivityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultUserActivityServiceChannel : ICrudeDefaultUserActivityService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultUserActivityServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultUserActivityService>, ICrudeDefaultUserActivityService {
        
        public CrudeDefaultUserActivityServiceClient() {
        }
        
        public CrudeDefaultUserActivityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultUserActivityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserActivityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserActivityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract FetchByDefaultUserActivityId(System.Guid defaultUserActivityId) {
            return base.Channel.FetchByDefaultUserActivityId(defaultUserActivityId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            return base.Channel.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultUserActivityId) {
            base.Channel.Delete(defaultUserActivityId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityContract> FetchWithFilter(System.Guid defaultUserActivityId, string defaultUserActivityTypeRcd, string userActivityNote, string originatingAddress, string referrer, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultUserActivityId: defaultUserActivityId,
                defaultUserActivityTypeRcd: defaultUserActivityTypeRcd,
                userActivityNote: userActivityNote,
                originatingAddress: originatingAddress,
                referrer: referrer,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
