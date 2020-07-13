/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 1:46:05 PM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultUserActivityTypeRef.json
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

    public partial class DefaultUserActivityTypeRef {
        
        public const string BusinessLogicMethodInvoked = "blmi";
        
        public const string FormOpened = "fo";
        
        public const string Login = "li";
        
        public const string Logout = "lo";
        
        public const string ScheduledEvent = "se";
        
        public const string WebPageOpened = "wpo";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultUserActivityTypeRefService")]
    public partial interface ICrudeDefaultUserActivityTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserActi" +
            "vityTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserActi" +
            "vityTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/DeleteResponse")]
        void Delete(string defaultUserActivityTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserActi" +
            "vityTypeName", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchByDefaultUserActi" +
            "vityTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllWithLimitRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllWithLimitAndOf" +
            "fset", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllWithLimitAndOf" +
            "fsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultUserActivityTypeRefService/FetchWithFilterRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultUserActivityTypeRefServiceChannel : ICrudeDefaultUserActivityTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultUserActivityTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultUserActivityTypeRefService>, ICrudeDefaultUserActivityTypeRefService {
        
        public CrudeDefaultUserActivityTypeRefServiceClient() {
        }
        
        public CrudeDefaultUserActivityTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultUserActivityTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserActivityTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserActivityTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeRcd(string defaultUserActivityTypeRcd) {
            return base.Channel.FetchByDefaultUserActivityTypeRcd(defaultUserActivityTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultUserActivityTypeRcd) {
            base.Channel.Delete(defaultUserActivityTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract FetchByDefaultUserActivityTypeName(string defaultUserActivityTypeName) {
            return base.Channel.FetchByDefaultUserActivityTypeName(defaultUserActivityTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserActivityTypeRefContract> FetchWithFilter(string defaultUserActivityTypeRcd, string defaultUserActivityTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultUserActivityTypeRcd: defaultUserActivityTypeRcd,
                defaultUserActivityTypeName: defaultUserActivityTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
