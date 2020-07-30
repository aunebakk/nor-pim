/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/30/2020 6:40:38 AM
  From Machine: DESKTOP-00MSEIL
  Filename: ProductCategoryImage.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryImageService")]
    public partial interface ICrudeProductCategoryImageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageI" +
            "d", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageI" +
            "dResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryIdResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageT" +
            "ypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageT" +
            "ypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/DeleteResponse")]
        void Delete(System.Guid productCategoryImageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductCategoryImageServiceChannel : ICrudeProductCategoryImageService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryImageServiceClient : System.ServiceModel.ClientBase<ICrudeProductCategoryImageService>, ICrudeProductCategoryImageService {
        
        public CrudeProductCategoryImageServiceClient() {
        }
        
        public CrudeProductCategoryImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId) {
            return base.Channel.FetchByProductCategoryImageId(productCategoryImageId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            return base.Channel.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productCategoryImageId) {
            base.Channel.Delete(productCategoryImageId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductCategoryImageContract> FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productCategoryImageId: productCategoryImageId,
                productCategoryId: productCategoryId,
                productCategoryImageTypeRcd: productCategoryImageTypeRcd,
                image: image,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
