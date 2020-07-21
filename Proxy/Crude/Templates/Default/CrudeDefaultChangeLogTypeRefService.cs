/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/21/2020 9:16:28 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultChangeLogTypeRef.json
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

    public partial class DefaultChangeLogTypeRef {
        
        public const string ChangedFeature = "Change";
        
        public const string Issue = "Issue";
        
        public const string NewFeature = "New";
        
        public const string RemovedFeature = "Removed";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultChangeLogTypeRefService")]
    public partial interface ICrudeDefaultChangeLogTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultChangeLogTy" +
            "peRcd", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultChangeLogTy" +
            "peRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultUserIdRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/DeleteResponse")]
        void Delete(string defaultChangeLogTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultChangeLogTy" +
            "peName", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchByDefaultChangeLogTy" +
            "peNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultChangeLogTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultChangeLogTypeRefServiceChannel : ICrudeDefaultChangeLogTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultChangeLogTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultChangeLogTypeRefService>, ICrudeDefaultChangeLogTypeRefService {
        
        public CrudeDefaultChangeLogTypeRefServiceClient() {
        }
        
        public CrudeDefaultChangeLogTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultChangeLogTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultChangeLogTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultChangeLogTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeRcd(string defaultChangeLogTypeRcd) {
            return base.Channel.FetchByDefaultChangeLogTypeRcd(defaultChangeLogTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultChangeLogTypeRcd) {
            base.Channel.Delete(defaultChangeLogTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract FetchByDefaultChangeLogTypeName(string defaultChangeLogTypeName) {
            return base.Channel.FetchByDefaultChangeLogTypeName(defaultChangeLogTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultChangeLogTypeRefContract> FetchWithFilter(string defaultChangeLogTypeRcd, string defaultChangeLogTypeName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultChangeLogTypeRcd: defaultChangeLogTypeRcd,
                defaultChangeLogTypeName: defaultChangeLogTypeName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
