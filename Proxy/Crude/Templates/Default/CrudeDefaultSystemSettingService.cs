/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:50:54 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultSystemSetting.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultSystemSettingService")]
    public partial interface ICrudeDefaultSystemSettingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultSystemSettingI" +
            "d", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultSystemSettingI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultSystemSettingR" +
            "cd", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchByDefaultSystemSettingR" +
            "cdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/DeleteResponse")]
        void Delete(System.Guid defaultSystemSettingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultSystemSettingServiceChannel : ICrudeDefaultSystemSettingService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultSystemSettingServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultSystemSettingService>, ICrudeDefaultSystemSettingService {
        
        public CrudeDefaultSystemSettingServiceClient() {
        }
        
        public CrudeDefaultSystemSettingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultSystemSettingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemSettingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemSettingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract FetchByDefaultSystemSettingId(System.Guid defaultSystemSettingId) {
            return base.Channel.FetchByDefaultSystemSettingId(defaultSystemSettingId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            return base.Channel.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultSystemSettingId) {
            base.Channel.Delete(defaultSystemSettingId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingContract> FetchWithFilter(System.Guid defaultSystemSettingId, string defaultSystemSettingRcd, string defaultSystemSettingValue, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultSystemSettingId: defaultSystemSettingId,
                defaultSystemSettingRcd: defaultSystemSettingRcd,
                defaultSystemSettingValue: defaultSystemSettingValue,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
