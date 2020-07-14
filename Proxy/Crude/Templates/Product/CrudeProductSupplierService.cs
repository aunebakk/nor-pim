/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/14/2020 11:35:48 AM
  From Machine: DESKTOP-517I8BU
  Filename: ProductSupplier.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductSupplierService")]
    public partial interface ICrudeProductSupplierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchByProductSupplierId", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchByProductSupplierIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/Insert", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/Update", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/Delete", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/DeleteResponse")]
        void Delete(System.Guid productSupplierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchBySupplierName", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchBySupplierNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract FetchBySupplierName(string supplierName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductSupplierServiceChannel : ICrudeProductSupplierService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductSupplierServiceClient : System.ServiceModel.ClientBase<ICrudeProductSupplierService>, ICrudeProductSupplierService {
        
        public CrudeProductSupplierServiceClient() {
        }
        
        public CrudeProductSupplierServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductSupplierServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductSupplierServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductSupplierServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId) {
            return base.Channel.FetchByProductSupplierId(productSupplierId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productSupplierId) {
            base.Channel.Delete(productSupplierId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract FetchBySupplierName(string supplierName) {
            return base.Channel.FetchBySupplierName(supplierName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductSupplierContract> FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productSupplierId: productSupplierId,
                productId: productId,
                supplierName: supplierName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
