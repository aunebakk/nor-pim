/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:34:25 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Default\DefaultUser.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultUserService")]
    public partial interface ICrudeDefaultUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultUserIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchByCreatedByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchByCreatedByDefaultUserIdResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultStateRcd", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultStateRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchByDefaultStateRcd(string defaultStateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/DeleteResponse")]
        void Delete(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultUserName", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchByDefaultUserNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract FetchByDefaultUserName(string defaultUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultUserService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultUserService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultUserServiceChannel : ICrudeDefaultUserService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultUserServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultUserService>, ICrudeDefaultUserService {
        
        public CrudeDefaultUserServiceClient() {
        }
        
        public CrudeDefaultUserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultUserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultUserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchByCreatedByDefaultUserId(System.Guid createdByDefaultUserId) {
            return base.Channel.FetchByCreatedByDefaultUserId(createdByDefaultUserId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchByDefaultStateRcd(string defaultStateRcd) {
            return base.Channel.FetchByDefaultStateRcd(defaultStateRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultUserId) {
            base.Channel.Delete(defaultUserId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract FetchByDefaultUserName(string defaultUserName) {
            return base.Channel.FetchByDefaultUserName(defaultUserName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultUserContract> FetchWithFilter(System.Guid defaultUserId, string defaultUserCode, string defaultUserName, string email, string password, string defaultStateRcd, System.Guid createdByDefaultUserId, System.DateTime dateTime, System.DateTime lastActivityDateTime) {
            return base.Channel.FetchWithFilter(
                defaultUserId: defaultUserId,
                defaultUserCode: defaultUserCode,
                defaultUserName: defaultUserName,
                email: email,
                password: password,
                defaultStateRcd: defaultStateRcd,
                createdByDefaultUserId: createdByDefaultUserId,
                dateTime: dateTime,
                lastActivityDateTime: lastActivityDateTime
                );
        }
    }
}
