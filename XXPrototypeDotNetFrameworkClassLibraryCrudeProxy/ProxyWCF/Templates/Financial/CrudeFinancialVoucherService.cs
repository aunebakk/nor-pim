/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 8:58:08 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Financial\FinancialVoucher.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeFinancialVoucherService")]
    public partial interface ICrudeFinancialVoucherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchByFinancialVoucherId", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchByFinancialVoucherIdRespons" +
            "e")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract FetchByFinancialVoucherId(System.Guid financialVoucherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchByFinancialCurrencyId", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchByFinancialCurrencyIdRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchByFinancialVoucherTypeRcd", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchByFinancialVoucherTypeRcdRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/Insert", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/Update", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/Delete", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/DeleteResponse")]
        void Delete(System.Guid financialVoucherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchAll", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeFinancialVoucherService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeFinancialVoucherService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchWithFilter(System.Guid financialVoucherId, System.Guid userId, System.DateTime dateTime, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, System.Guid financialCurrencyId, int voucherNumber, string voucherDescription, string financialVoucherTypeRcd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeFinancialVoucherServiceChannel : ICrudeFinancialVoucherService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeFinancialVoucherServiceClient : System.ServiceModel.ClientBase<ICrudeFinancialVoucherService>, ICrudeFinancialVoucherService {
        
        public CrudeFinancialVoucherServiceClient() {
        }
        
        public CrudeFinancialVoucherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeFinancialVoucherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialVoucherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeFinancialVoucherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract FetchByFinancialVoucherId(System.Guid financialVoucherId) {
            return base.Channel.FetchByFinancialVoucherId(financialVoucherId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchByFinancialCurrencyId(System.Guid financialCurrencyId) {
            return base.Channel.FetchByFinancialCurrencyId(financialCurrencyId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchByFinancialVoucherTypeRcd(string financialVoucherTypeRcd) {
            return base.Channel.FetchByFinancialVoucherTypeRcd(financialVoucherTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid financialVoucherId) {
            base.Channel.Delete(financialVoucherId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeFinancialVoucherContract> FetchWithFilter(System.Guid financialVoucherId, System.Guid userId, System.DateTime dateTime, decimal valueAmount, System.DateTime validFromDateTime, System.DateTime validUntilDateTime, System.Guid financialCurrencyId, int voucherNumber, string voucherDescription, string financialVoucherTypeRcd) {
            return base.Channel.FetchWithFilter(
                financialVoucherId: financialVoucherId,
                userId: userId,
                dateTime: dateTime,
                valueAmount: valueAmount,
                validFromDateTime: validFromDateTime,
                validUntilDateTime: validUntilDateTime,
                financialCurrencyId: financialCurrencyId,
                voucherNumber: voucherNumber,
                voucherDescription: voucherDescription,
                financialVoucherTypeRcd: financialVoucherTypeRcd
                );
        }
    }
}
