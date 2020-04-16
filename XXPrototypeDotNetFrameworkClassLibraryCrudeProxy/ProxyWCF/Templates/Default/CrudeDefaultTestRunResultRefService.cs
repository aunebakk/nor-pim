/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:04 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultTestRunResultRef.json
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
    
    
    public partial class DefaultTestRunResultRef {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultTestRunResultRefService")]
    public partial interface ICrudeDefaultTestRunResultRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchByDefaultTestRunResu" +
            "ltRcd", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchByDefaultTestRunResu" +
            "ltRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/DeleteResponse")]
        void Delete(string defaultTestRunResultRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchByDefaultTestRunResu" +
            "ltName", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchByDefaultTestRunResu" +
            "ltNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultName(string defaultTestRunResultName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunResultRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchWithFilter(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultTestRunResultRefServiceChannel : ICrudeDefaultTestRunResultRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultTestRunResultRefServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultTestRunResultRefService>, ICrudeDefaultTestRunResultRefService {
        
        public CrudeDefaultTestRunResultRefServiceClient() {
        }
        
        public CrudeDefaultTestRunResultRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultTestRunResultRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestRunResultRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestRunResultRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            return base.Channel.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string defaultTestRunResultRcd) {
            base.Channel.Delete(defaultTestRunResultRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract FetchByDefaultTestRunResultName(string defaultTestRunResultName) {
            return base.Channel.FetchByDefaultTestRunResultName(defaultTestRunResultName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunResultRefContract> FetchWithFilter(string defaultTestRunResultRcd, string defaultTestRunResultName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultTestRunResultRcd: defaultTestRunResultRcd,
                defaultTestRunResultName: defaultTestRunResultName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
