/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:49:49 PM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultSystemSettingRef.json
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

    public partial class DefaultSystemSettingRef {
        
        public const string EAN13WebLink = "EANLINK";
        
        public const string TheGlobalLanguageOfBusiness = "GS1LINK";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultSystemSettingRefService")]
    public partial interface ICrudeDefaultSystemSettingRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultSystemSetti" +
            "ngRcd", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultSystemSetti" +
            "ngRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultUserIdRespo" +
            "nse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/DeleteResponse")]
        void Delete(string defaultSystemSettingRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultSystemSetti" +
            "ngName", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchByDefaultSystemSetti" +
            "ngNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingName(string defaultSystemSettingName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultSystemSettingRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultSystemSettingRefServiceChannel : ICrudeDefaultSystemSettingRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultSystemSettingRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultSystemSettingRefService>, ICrudeDefaultSystemSettingRefService {
        
        public CrudeDefaultSystemSettingRefServiceClient() {
        }
        
        public CrudeDefaultSystemSettingRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultSystemSettingRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemSettingRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemSettingRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingRcd(string defaultSystemSettingRcd) {
            return base.Channel.FetchByDefaultSystemSettingRcd(defaultSystemSettingRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultSystemSettingRcd) {
            base.Channel.Delete(defaultSystemSettingRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract FetchByDefaultSystemSettingName(string defaultSystemSettingName) {
            return base.Channel.FetchByDefaultSystemSettingName(defaultSystemSettingName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemSettingRefContract> FetchWithFilter(string defaultSystemSettingRcd, string defaultSystemSettingName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultSystemSettingRcd: defaultSystemSettingRcd,
                defaultSystemSettingName: defaultSystemSettingName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
