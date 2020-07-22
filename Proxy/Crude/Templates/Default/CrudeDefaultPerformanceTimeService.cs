/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/22/2020 9:24:26 AM
  From Machine: DESKTOP-00MSEIL
  Filename: DefaultPerformanceTime.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultPerformanceTimeService")]
    public partial interface ICrudeDefaultPerformanceTimeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchByDefaultPerformanceT" +
            "imeId", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchByDefaultPerformanceT" +
            "imeIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract FetchByDefaultPerformanceTimeId(System.Guid defaultPerformanceTimeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchByDefaultUserIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/DeleteResponse")]
        void Delete(System.Guid defaultPerformanceTimeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchByCommandName", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchByCommandNameResponse" +
            "")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract FetchByCommandName(string commandName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultPerformanceTimeService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchWithFilter(System.Guid defaultPerformanceTimeId, string commandName, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultPerformanceTimeServiceChannel : ICrudeDefaultPerformanceTimeService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultPerformanceTimeServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultPerformanceTimeService>, ICrudeDefaultPerformanceTimeService {
        
        public CrudeDefaultPerformanceTimeServiceClient() {
        }
        
        public CrudeDefaultPerformanceTimeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultPerformanceTimeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceTimeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultPerformanceTimeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract FetchByDefaultPerformanceTimeId(System.Guid defaultPerformanceTimeId) {
            return base.Channel.FetchByDefaultPerformanceTimeId(defaultPerformanceTimeId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultPerformanceTimeId) {
            base.Channel.Delete(defaultPerformanceTimeId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract FetchByCommandName(string commandName) {
            return base.Channel.FetchByCommandName(commandName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultPerformanceTimeContract> FetchWithFilter(System.Guid defaultPerformanceTimeId, string commandName, int milliseconds, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultPerformanceTimeId: defaultPerformanceTimeId,
                commandName: commandName,
                milliseconds: milliseconds,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
