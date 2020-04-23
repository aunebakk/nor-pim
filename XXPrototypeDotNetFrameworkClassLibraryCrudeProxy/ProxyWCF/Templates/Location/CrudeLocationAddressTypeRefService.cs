/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 11:44:04 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Location\LocationAddressTypeRef.json
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
    
    
    public partial class LocationAddressTypeRef {
        
        public const string Office = "Office";
        
        public const string Primary = "Primary";
        
        public const string Private = "Private";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeLocationAddressTypeRefService")]
    public partial interface ICrudeLocationAddressTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchByLocationAddressType" +
            "Rcd", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchByLocationAddressType" +
            "RcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract FetchByLocationAddressTypeRcd(string locationAddressTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/DeleteResponse")]
        void Delete(string locationAddressTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchByLocationAddressType" +
            "Name", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchByLocationAddressType" +
            "NameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract FetchByLocationAddressTypeName(string locationAddressTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeLocationAddressTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchWithFilter(string locationAddressTypeRcd, string locationAddressTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeLocationAddressTypeRefServiceChannel : ICrudeLocationAddressTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeLocationAddressTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeLocationAddressTypeRefService>, ICrudeLocationAddressTypeRefService {
        
        public CrudeLocationAddressTypeRefServiceClient() {
        }
        
        public CrudeLocationAddressTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeLocationAddressTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeLocationAddressTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeLocationAddressTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract FetchByLocationAddressTypeRcd(string locationAddressTypeRcd) {
            return base.Channel.FetchByLocationAddressTypeRcd(locationAddressTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string locationAddressTypeRcd) {
            base.Channel.Delete(locationAddressTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract FetchByLocationAddressTypeName(string locationAddressTypeName) {
            return base.Channel.FetchByLocationAddressTypeName(locationAddressTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeLocationAddressTypeRefContract> FetchWithFilter(string locationAddressTypeRcd, string locationAddressTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                locationAddressTypeRcd: locationAddressTypeRcd,
                locationAddressTypeName: locationAddressTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
