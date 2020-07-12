/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/12/2020 10:41:15 AM
  From Machine: DESKTOP-517I8BU
  Filename: ClientIdentifierTypeRef.json
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

    public partial class ClientIdentifierTypeRef {
        
        public const string EmployeeNumber = "ENR";
        
        public const string PassportNumber = "PNR";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientIdentifierTypeRefService")]
    public partial interface ICrudeClientIdentifierTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByClientIdentifierTy" +
            "peRcd", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByClientIdentifierTy" +
            "peRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/DeleteResponse")]
        void Delete(string clientIdentifierTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByClientIdentifierTy" +
            "peName", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchByClientIdentifierTy" +
            "peNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeName(string clientIdentifierTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientIdentifierTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchWithFilter(string clientIdentifierTypeRcd, string clientIdentifierTypeName, string clientIdentifierTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientIdentifierTypeRefServiceChannel : ICrudeClientIdentifierTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientIdentifierTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientIdentifierTypeRefService>, ICrudeClientIdentifierTypeRefService {
        
        public CrudeClientIdentifierTypeRefServiceClient() {
        }
        
        public CrudeClientIdentifierTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientIdentifierTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientIdentifierTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientIdentifierTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeRcd(string clientIdentifierTypeRcd) {
            return base.Channel.FetchByClientIdentifierTypeRcd(clientIdentifierTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientIdentifierTypeRcd) {
            base.Channel.Delete(clientIdentifierTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract FetchByClientIdentifierTypeName(string clientIdentifierTypeName) {
            return base.Channel.FetchByClientIdentifierTypeName(clientIdentifierTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientIdentifierTypeRefContract> FetchWithFilter(string clientIdentifierTypeRcd, string clientIdentifierTypeName, string clientIdentifierTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientIdentifierTypeRcd: clientIdentifierTypeRcd,
                clientIdentifierTypeName: clientIdentifierTypeName,
                clientIdentifierTypeDescription: clientIdentifierTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
