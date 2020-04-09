/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 7:20:34 AM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Client\ClientTitleRef.json
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
    
    
    public partial class ClientTitleRef {
        
        public const string Child = "CHA";
        
        public const string Infant = "INA";
        
        public const string Mr = "MR";
        
        public const string Mrs = "MRS";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeClientTitleRefService")]
    public partial interface ICrudeClientTitleRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchByClientTitleRcd", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchByClientTitleRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract FetchByClientTitleRcd(string clientTitleRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/Insert", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/Update", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/Delete", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/DeleteResponse")]
        void Delete(string clientTitleRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchByClientTitleName", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchByClientTitleNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract FetchByClientTitleName(string clientTitleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeClientTitleRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeClientTitleRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeClientTitleRefServiceChannel : ICrudeClientTitleRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeClientTitleRefServiceClient : System.ServiceModel.ClientBase<ICrudeClientTitleRefService>, ICrudeClientTitleRefService {
        
        public CrudeClientTitleRefServiceClient() {
        }
        
        public CrudeClientTitleRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeClientTitleRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientTitleRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeClientTitleRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract FetchByClientTitleRcd(string clientTitleRcd) {
            return base.Channel.FetchByClientTitleRcd(clientTitleRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string clientTitleRcd) {
            base.Channel.Delete(clientTitleRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract FetchByClientTitleName(string clientTitleName) {
            return base.Channel.FetchByClientTitleName(clientTitleName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeClientTitleRefContract> FetchWithFilter(string clientTitleRcd, string clientTitleName, string clientTitleDescription, bool activeFlag, int sortOrder, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                clientTitleRcd: clientTitleRcd,
                clientTitleName: clientTitleName,
                clientTitleDescription: clientTitleDescription,
                activeFlag: activeFlag,
                sortOrder: sortOrder,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
