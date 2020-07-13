/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 10:53:23 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultError.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultErrorService")]
    public partial interface ICrudeDefaultErrorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorId", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract FetchByDefaultErrorId(System.Guid defaultErrorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorLayerRcd", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorLayerRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorTypeRcd", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByDefaultErrorTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/DeleteResponse")]
        void Delete(System.Guid defaultErrorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchByMethodName", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchByMethodNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract FetchByMethodName(string methodName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultErrorService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultErrorServiceChannel : ICrudeDefaultErrorService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultErrorServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultErrorService>, ICrudeDefaultErrorService {
        
        public CrudeDefaultErrorServiceClient() {
        }
        
        public CrudeDefaultErrorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultErrorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract FetchByDefaultErrorId(System.Guid defaultErrorId) {
            return base.Channel.FetchByDefaultErrorId(defaultErrorId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            return base.Channel.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchByDefaultErrorTypeRcd(string defaultErrorTypeRcd) {
            return base.Channel.FetchByDefaultErrorTypeRcd(defaultErrorTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultErrorId) {
            base.Channel.Delete(defaultErrorId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract FetchByMethodName(string methodName) {
            return base.Channel.FetchByMethodName(methodName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorContract> FetchWithFilter(System.Guid defaultErrorId, string defaultErrorLayerRcd, string defaultErrorTypeRcd, string layerAddress, string errorMessage, string stackTrace, string methodName, string domainName, string className, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultErrorId: defaultErrorId,
                defaultErrorLayerRcd: defaultErrorLayerRcd,
                defaultErrorTypeRcd: defaultErrorTypeRcd,
                layerAddress: layerAddress,
                errorMessage: errorMessage,
                stackTrace: stackTrace,
                methodName: methodName,
                domainName: domainName,
                className: className,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
