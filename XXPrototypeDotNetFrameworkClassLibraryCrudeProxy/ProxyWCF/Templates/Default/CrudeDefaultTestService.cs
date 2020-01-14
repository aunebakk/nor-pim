/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:24:43 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultTest.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultTestService")]
    public partial interface ICrudeDefaultTestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/FetchByDefaultTestId", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/FetchByDefaultTestIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract FetchByDefaultTestId(System.Guid defaultTestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/DeleteResponse")]
        void Delete(System.Guid defaultTestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/FetchBySystemName", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/FetchBySystemNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract FetchBySystemName(string systemName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultTestService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultTestService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultTestServiceChannel : ICrudeDefaultTestService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultTestServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultTestService>, ICrudeDefaultTestService {
        
        public CrudeDefaultTestServiceClient() {
        }
        
        public CrudeDefaultTestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultTestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultTestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract FetchByDefaultTestId(System.Guid defaultTestId) {
            return base.Channel.FetchByDefaultTestId(defaultTestId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultTestId) {
            base.Channel.Delete(defaultTestId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract FetchBySystemName(string systemName) {
            return base.Channel.FetchBySystemName(systemName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultTestContract> FetchWithFilter(System.Guid defaultTestId, string systemName, string testArea, string testSubArea, string testAddress, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultTestId: defaultTestId,
                systemName: systemName,
                testArea: testArea,
                testSubArea: testSubArea,
                testAddress: testAddress,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
