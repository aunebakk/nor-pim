/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:23:51 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialVoucherTypeRef.json
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
    
    
    public partial class FinancialVoucherTypeRef {
        
        public const string DisruptionVoucher = "DV";
        
        public const string FlightVoucher = "FV";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialVoucherTypeRefService")]
    public partial interface ICrudeFinancialVoucherTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchByFinancialVoucherTy" +
            "peRcd", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchByFinancialVoucherTy" +
            "peRcdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/DeleteResponse")]
        void Delete(string financialVoucherTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchByFinancialVoucherTy" +
            "peName", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchByFinancialVoucherTy" +
            "peNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract FetchByFinancialVoucherTypeName(string financialVoucherTypeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchAllWithLimitResponse" +
            "")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherTypeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchWithFilter(string financialVoucherTypeRcd, string financialVoucherTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialVoucherTypeRefServiceChannel : ICrudeFinancialVoucherTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialVoucherTypeRefServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialVoucherTypeRefService>, ICrudeFinancialVoucherTypeRefService {
        
        public CrudeFinancialVoucherTypeRefServiceClient() {
        }
        
        public CrudeFinancialVoucherTypeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialVoucherTypeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialVoucherTypeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialVoucherTypeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            return base.Channel.FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string financialVoucherTypeRcd) {
            base.Channel.Delete(financialVoucherTypeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract FetchByFinancialVoucherTypeName(string financialVoucherTypeName) {
            return base.Channel.FetchByFinancialVoucherTypeName(financialVoucherTypeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherTypeRefContract> FetchWithFilter(string financialVoucherTypeRcd, string financialVoucherTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                financialVoucherTypeRcd: financialVoucherTypeRcd,
                financialVoucherTypeName: financialVoucherTypeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
