/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:49:49 PM
  From Machine: DESKTOP-517I8BU
  Filename: ClientContactMethodRef.json
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

    public partial class ClientContactMethodRef {
        
        public const string BusinessPhone = "BPE";
        
        public const string EMail = "EMA";
        
        public const string Fax = "FAX";
        
        public const string HomePhone = "HPE";
        
        public const string InternationalPhone = "IPE";
        
        public const string LocalPhone = "LPE";
        
        public const string MMSMobile = "MME";
        
        public const string Mobile = "MOA";
        
        public const string SMSMobile = "SME";
        
        public const string Telephone = "TEA";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientContactMethodRefService")]
    public partial interface ICrudeClientContactMethodRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByClientContactMethod" +
            "Rcd", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByClientContactMethod" +
            "RcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract FetchByClientContactMethodRcd(string clientContactMethodRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/DeleteResponse")]
        void Delete(string clientContactMethodRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByClientContactMethod" +
            "Name", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchByClientContactMethod" +
            "NameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract FetchByClientContactMethodName(string clientContactMethodName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllWithLimitAndOffset" +
            "Response")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientContactMethodRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientContactMethodRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientContactMethodRefServiceChannel : ICrudeClientContactMethodRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientContactMethodRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientContactMethodRefService>, ICrudeClientContactMethodRefService {
        
        public CrudeClientContactMethodRefServiceClient() {
        }
        
        public CrudeClientContactMethodRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientContactMethodRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientContactMethodRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientContactMethodRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract FetchByClientContactMethodRcd(string clientContactMethodRcd) {
            return base.Channel.FetchByClientContactMethodRcd(clientContactMethodRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientContactMethodRcd) {
            base.Channel.Delete(clientContactMethodRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract FetchByClientContactMethodName(string clientContactMethodName) {
            return base.Channel.FetchByClientContactMethodName(clientContactMethodName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientContactMethodRefContract> FetchWithFilter(string clientContactMethodRcd, string clientContactMethodName, string clientContactMethodDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientContactMethodRcd: clientContactMethodRcd,
                clientContactMethodName: clientContactMethodName,
                clientContactMethodDescription: clientContactMethodDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
