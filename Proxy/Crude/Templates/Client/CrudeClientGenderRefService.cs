/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:49:49 PM
  From Machine: DESKTOP-517I8BU
  Filename: ClientGenderRef.json
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

    public partial class ClientGenderRef {
        
        public const string Female = "FEA";
        
        public const string Male = "MAA";
        
        public const string Unknown = "UNA";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientGenderRefService")]
    public partial interface ICrudeClientGenderRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchByClientGenderRcd", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchByClientGenderRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/DeleteResponse")]
        void Delete(string clientGenderRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchByClientGenderName", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchByClientGenderNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientGenderRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientGenderRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientGenderRefServiceChannel : ICrudeClientGenderRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientGenderRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientGenderRefService>, ICrudeClientGenderRefService {
        
        public CrudeClientGenderRefServiceClient() {
        }
        
        public CrudeClientGenderRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientGenderRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientGenderRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientGenderRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract FetchByClientGenderRcd(string clientGenderRcd) {
            return base.Channel.FetchByClientGenderRcd(clientGenderRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientGenderRcd) {
            base.Channel.Delete(clientGenderRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract FetchByClientGenderName(string clientGenderName) {
            return base.Channel.FetchByClientGenderName(clientGenderName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientGenderRefContract> FetchWithFilter(string clientGenderRcd, string clientGenderName, string clientGenderDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientGenderRcd: clientGenderRcd,
                clientGenderName: clientGenderName,
                clientGenderDescription: clientGenderDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
