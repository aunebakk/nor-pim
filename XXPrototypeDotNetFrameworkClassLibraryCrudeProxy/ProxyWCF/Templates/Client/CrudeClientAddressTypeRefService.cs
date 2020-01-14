/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:43:03 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Client\ClientAddressTypeRef.json
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
    
    
    public partial class ClientAddressTypeRef {
        
        public const string Office = "OFA";
        
        public const string Private = "PRA";
        
        public const string Temporary = "TEA";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientAddressTypeRefService")]
    public partial interface ICrudeClientAddressTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchByClientAddressTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchByClientAddressTypeRcdR" +
            "esponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract FetchByClientAddressTypeRcd(string clientAddressTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/DeleteResponse")]
        void Delete(string clientAddressTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchByClientAddressTypeName" +
            "", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchByClientAddressTypeName" +
            "Response")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract FetchByClientAddressTypeName(string clientAddressTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientAddressTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchWithFilter(string clientAddressTypeRcd, string clientAddressTypeName, string clientAddressTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientAddressTypeRefServiceChannel : ICrudeClientAddressTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientAddressTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientAddressTypeRefService>, ICrudeClientAddressTypeRefService {
        
        public CrudeClientAddressTypeRefServiceClient() {
        }
        
        public CrudeClientAddressTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientAddressTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientAddressTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientAddressTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract FetchByClientAddressTypeRcd(string clientAddressTypeRcd) {
            return base.Channel.FetchByClientAddressTypeRcd(clientAddressTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientAddressTypeRcd) {
            base.Channel.Delete(clientAddressTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract FetchByClientAddressTypeName(string clientAddressTypeName) {
            return base.Channel.FetchByClientAddressTypeName(clientAddressTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientAddressTypeRefContract> FetchWithFilter(string clientAddressTypeRcd, string clientAddressTypeName, string clientAddressTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientAddressTypeRcd: clientAddressTypeRcd,
                clientAddressTypeName: clientAddressTypeName,
                clientAddressTypeDescription: clientAddressTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
