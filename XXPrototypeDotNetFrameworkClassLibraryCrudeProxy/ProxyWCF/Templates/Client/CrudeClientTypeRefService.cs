/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 2:57:56 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Client\ClientTypeRef.json
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
    
    
    public partial class ClientTypeRef {
        
        public const string Business = "BUA";
        
        public const string Private = "PRA";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientTypeRefService")]
    public partial interface ICrudeClientTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/FetchByClientTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/FetchByClientTypeRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract FetchByClientTypeRcd(string clientTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/DeleteResponse")]
        void Delete(string clientTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/FetchByClientTypeName", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/FetchByClientTypeNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract FetchByClientTypeName(string clientTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchWithFilter(string clientTypeRcd, string clientTypeName, string clientTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientTypeRefServiceChannel : ICrudeClientTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientTypeRefService>, ICrudeClientTypeRefService {
        
        public CrudeClientTypeRefServiceClient() {
        }
        
        public CrudeClientTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract FetchByClientTypeRcd(string clientTypeRcd) {
            return base.Channel.FetchByClientTypeRcd(clientTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientTypeRcd) {
            base.Channel.Delete(clientTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract FetchByClientTypeName(string clientTypeName) {
            return base.Channel.FetchByClientTypeName(clientTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTypeRefContract> FetchWithFilter(string clientTypeRcd, string clientTypeName, string clientTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientTypeRcd: clientTypeRcd,
                clientTypeName: clientTypeName,
                clientTypeDescription: clientTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
