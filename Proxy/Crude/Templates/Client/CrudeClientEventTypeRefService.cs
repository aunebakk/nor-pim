/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:35:48 AM
  From Machine: DESKTOP-517I8BU
  Filename: ClientEventTypeRef.json
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

    public partial class ClientEventTypeRef {
        
        public const string Created = "CRA";
        
        public const string IntroductionMailConfirmed = "IMC";
        
        public const string Inactivated = "INA";
        
        public const string PackageMailSent = "PMS";
        
        public const string PackageOrdered = "POD";
        
        public const string PackageSiteViewed = "PSV";
        
        public const string SentIntroductionMail = "SIM";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientEventTypeRefService")]
    public partial interface ICrudeClientEventTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/FetchByClientEventTypeRcd", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/FetchByClientEventTypeRcdRespo" +
            "nse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract FetchByClientEventTypeRcd(string clientEventTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/DeleteResponse")]
        void Delete(string clientEventTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/FetchByClientEventTypeName", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/FetchByClientEventTypeNameResp" +
            "onse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract FetchByClientEventTypeName(string clientEventTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/FetchAllWithLimitAndOffsetResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientEventTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientEventTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchWithFilter(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientEventTypeRefServiceChannel : ICrudeClientEventTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientEventTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientEventTypeRefService>, ICrudeClientEventTypeRefService {
        
        public CrudeClientEventTypeRefServiceClient() {
        }
        
        public CrudeClientEventTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientEventTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientEventTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientEventTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract FetchByClientEventTypeRcd(string clientEventTypeRcd) {
            return base.Channel.FetchByClientEventTypeRcd(clientEventTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientEventTypeRcd) {
            base.Channel.Delete(clientEventTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract FetchByClientEventTypeName(string clientEventTypeName) {
            return base.Channel.FetchByClientEventTypeName(clientEventTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientEventTypeRefContract> FetchWithFilter(string clientEventTypeRcd, string clientEventTypeName, string clientEventTypeDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientEventTypeRcd: clientEventTypeRcd,
                clientEventTypeName: clientEventTypeName,
                clientEventTypeDescription: clientEventTypeDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
