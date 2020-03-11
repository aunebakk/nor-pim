/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:58:10 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Location\LocationCity.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeLocationCityService")]
    public partial interface ICrudeLocationCityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchByLocationCityId", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchByLocationCityIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract FetchByLocationCityId(System.Guid locationCityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchByLocationCountryId", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchByLocationCountryIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchByLocationCountryId(System.Guid locationCountryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/Insert", ReplyAction="http://tempuri.org/ICrudeLocationCityService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/Update", ReplyAction="http://tempuri.org/ICrudeLocationCityService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/Delete", ReplyAction="http://tempuri.org/ICrudeLocationCityService/DeleteResponse")]
        void Delete(System.Guid locationCityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchByLocationCityName", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchByLocationCityNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract FetchByLocationCityName(string locationCityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchAll", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCityService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeLocationCityService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchWithFilter(System.Guid locationCityId, System.Guid locationCountryId, string locationCityCode, string locationCityName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeLocationCityServiceChannel : ICrudeLocationCityService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeLocationCityServiceClient : System.ServiceModel.ClientBase<ICrudeLocationCityService>, ICrudeLocationCityService {
        
        public CrudeLocationCityServiceClient() {
        }
        
        public CrudeLocationCityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeLocationCityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeLocationCityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeLocationCityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract FetchByLocationCityId(System.Guid locationCityId) {
            return base.Channel.FetchByLocationCityId(locationCityId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchByLocationCountryId(System.Guid locationCountryId) {
            return base.Channel.FetchByLocationCountryId(locationCountryId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid locationCityId) {
            base.Channel.Delete(locationCityId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract FetchByLocationCityName(string locationCityName) {
            return base.Channel.FetchByLocationCityName(locationCityName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCityContract> FetchWithFilter(System.Guid locationCityId, System.Guid locationCountryId, string locationCityCode, string locationCityName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                locationCityId: locationCityId,
                locationCountryId: locationCountryId,
                locationCityCode: locationCityCode,
                locationCityName: locationCityName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
