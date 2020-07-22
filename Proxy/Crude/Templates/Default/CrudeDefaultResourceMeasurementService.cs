/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:26 AM
  From Machine: DESKTOP-00MSEIL
  Filename: DefaultResourceMeasurement.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultResourceMeasurementService")]
    public partial interface ICrudeDefaultResourceMeasurementService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchByDefaultResource" +
            "MeasurementId", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchByDefaultResource" +
            "MeasurementIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract FetchByDefaultResourceMeasurementId(System.Guid defaultResourceMeasurementId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchByDefaultUserIdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/DeleteResponse")]
        void Delete(System.Guid defaultResourceMeasurementId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchAllWithLimitRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchAllWithLimitAndOf" +
            "fset", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchAllWithLimitAndOf" +
            "fsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultResourceMeasurementService/FetchWithFilterRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchWithFilter(System.Guid defaultResourceMeasurementId, int clientWorkingsetBytes, int businessWorkingsetBytes, int databaseSizeBytes, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultResourceMeasurementServiceChannel : ICrudeDefaultResourceMeasurementService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultResourceMeasurementServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultResourceMeasurementService>, ICrudeDefaultResourceMeasurementService {
        
        public CrudeDefaultResourceMeasurementServiceClient() {
        }
        
        public CrudeDefaultResourceMeasurementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultResourceMeasurementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultResourceMeasurementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultResourceMeasurementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract FetchByDefaultResourceMeasurementId(System.Guid defaultResourceMeasurementId) {
            return base.Channel.FetchByDefaultResourceMeasurementId(defaultResourceMeasurementId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultResourceMeasurementId) {
            base.Channel.Delete(defaultResourceMeasurementId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultResourceMeasurementContract> FetchWithFilter(System.Guid defaultResourceMeasurementId, int clientWorkingsetBytes, int businessWorkingsetBytes, int databaseSizeBytes, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultResourceMeasurementId: defaultResourceMeasurementId,
                clientWorkingsetBytes: clientWorkingsetBytes,
                businessWorkingsetBytes: businessWorkingsetBytes,
                databaseSizeBytes: databaseSizeBytes,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
