/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:45:49 AM
  From Machine: DESKTOP-00MSEIL
  Filename: DefaultErrorLayerRef.json
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

    public partial class DefaultErrorLayerRef {
        
        public const string BusinessLogicLayer = "BLL";
        
        public const string BusinessLayerEngine = "BLLEngine";
        
        public const string BusinessLogicLayerRest = "BLLRest";
        
        public const string BusinessLogicLayerSoap = "BLLSoap";
        
        public const string ClientEngine = "CEngine";
        
        public const string Database = "DB";
        
        public const string DataAccessLayer = "DLL";
        
        public const string Documentation = "DOC";
        
        public const string ASPModelViewController = "MVC";
        
        public const string ClientProxy = "Proxy";
        
        public const string Sql2Wcf = "S2W";
        
        public const string AutomatedTesting = "Test";
        
        public const string TestFront = "TestF";
        
        public const string WindowsWinforms = "WinForms";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultErrorLayerRefService")]
    public partial interface ICrudeDefaultErrorLayerRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultErrorLayerRcd", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultErrorLayerRcdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/DeleteResponse")]
        void Delete(string defaultErrorLayerRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultErrorLayerName" +
            "", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchByDefaultErrorLayerName" +
            "Response")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerName(string defaultErrorLayerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultErrorLayerRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultErrorLayerRefServiceChannel : ICrudeDefaultErrorLayerRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultErrorLayerRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultErrorLayerRefService>, ICrudeDefaultErrorLayerRefService {
        
        public CrudeDefaultErrorLayerRefServiceClient() {
        }
        
        public CrudeDefaultErrorLayerRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultErrorLayerRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorLayerRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultErrorLayerRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerRcd(string defaultErrorLayerRcd) {
            return base.Channel.FetchByDefaultErrorLayerRcd(defaultErrorLayerRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultErrorLayerRcd) {
            base.Channel.Delete(defaultErrorLayerRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract FetchByDefaultErrorLayerName(string defaultErrorLayerName) {
            return base.Channel.FetchByDefaultErrorLayerName(defaultErrorLayerName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultErrorLayerRefContract> FetchWithFilter(string defaultErrorLayerRcd, string defaultErrorLayerName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultErrorLayerRcd: defaultErrorLayerRcd,
                defaultErrorLayerName: defaultErrorLayerName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
