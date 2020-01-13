/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:36:03 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Location\LocationCountry.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeLocationCountryService")]
    public partial interface ICrudeLocationCountryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/FetchByLocationCountryId", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/FetchByLocationCountryIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract FetchByLocationCountryId(System.Guid locationCountryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/Insert", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/Update", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/Delete", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/DeleteResponse")]
        void Delete(System.Guid locationCountryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/FetchByLocationCountryName", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/FetchByLocationCountryNameRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract FetchByLocationCountryName(string locationCountryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/FetchAll", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationCountryService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeLocationCountryService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchWithFilter(System.Guid locationCountryId, string locationCountryCode, string locationCountryName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeLocationCountryServiceChannel : ICrudeLocationCountryService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeLocationCountryServiceClient : System.ServiceModel.ClientBase<ICrudeLocationCountryService>, ICrudeLocationCountryService {
        
        public CrudeLocationCountryServiceClient() {
        }
        
        public CrudeLocationCountryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeLocationCountryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeLocationCountryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeLocationCountryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract FetchByLocationCountryId(System.Guid locationCountryId) {
            return base.Channel.FetchByLocationCountryId(locationCountryId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid locationCountryId) {
            base.Channel.Delete(locationCountryId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract FetchByLocationCountryName(string locationCountryName) {
            return base.Channel.FetchByLocationCountryName(locationCountryName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationCountryContract> FetchWithFilter(System.Guid locationCountryId, string locationCountryCode, string locationCountryName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                locationCountryId: locationCountryId,
                locationCountryCode: locationCountryCode,
                locationCountryName: locationCountryName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
