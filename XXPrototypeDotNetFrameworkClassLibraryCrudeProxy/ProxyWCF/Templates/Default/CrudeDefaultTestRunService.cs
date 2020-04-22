/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:51:52 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultTestRun.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultTestRunService")]
    public partial interface ICrudeDefaultTestRunService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract FetchByDefaultTestRunId(System.Guid defaultTestRunId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestId(System.Guid defaultTestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunResultRcd", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchByDefaultTestRunResultRcdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/DeleteResponse")]
        void Delete(System.Guid defaultTestRunId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestRunService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultTestRunService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultTestRunServiceChannel : ICrudeDefaultTestRunService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultTestRunServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultTestRunService>, ICrudeDefaultTestRunService {
        
        public CrudeDefaultTestRunServiceClient() {
        }
        
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestRunServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestRunServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract FetchByDefaultTestRunId(System.Guid defaultTestRunId) {
            return base.Channel.FetchByDefaultTestRunId(defaultTestRunId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestId(System.Guid defaultTestId) {
            return base.Channel.FetchByDefaultTestId(defaultTestId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchByDefaultTestRunResultRcd(string defaultTestRunResultRcd) {
            return base.Channel.FetchByDefaultTestRunResultRcd(defaultTestRunResultRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultTestRunId) {
            base.Channel.Delete(defaultTestRunId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestRunContract> FetchWithFilter(System.Guid defaultTestRunId, System.Guid defaultTestId, string defaultTestRunResultRcd, string result, System.DateTime startDateTime, System.DateTime endDateTime, int elapsedMilliseconds, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultTestRunId: defaultTestRunId,
                defaultTestId: defaultTestId,
                defaultTestRunResultRcd: defaultTestRunResultRcd,
                result: result,
                startDateTime: startDateTime,
                endDateTime: endDateTime,
                elapsedMilliseconds: elapsedMilliseconds,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
