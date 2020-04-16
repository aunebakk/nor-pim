/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:31:04 PM
  Filename: C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkClassLibraryCrudeProxy\Template\Product\ProductImage.json
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductImageService")]
    public partial interface ICrudeProductImageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByProductImageId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByProductImageIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract FetchByProductImageId(System.Guid productImageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByProductIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByProductImageTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByProductImageTypeRcdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Insert", ReplyAction="http://tempuri.org/ICrudeProductImageService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Update", ReplyAction="http://tempuri.org/ICrudeProductImageService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Delete", ReplyAction="http://tempuri.org/ICrudeProductImageService/DeleteResponse")]
        void Delete(System.Guid productImageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByImageFileName", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByImageFileNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract FetchByImageFileName(string imageFileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitAndOffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductImageServiceChannel : ICrudeProductImageService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductImageServiceClient : System.ServiceModel.ClientBase<ICrudeProductImageService>, ICrudeProductImageService {
        
        public CrudeProductImageServiceClient() {
        }
        
        public CrudeProductImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract FetchByProductImageId(System.Guid productImageId) {
            return base.Channel.FetchByProductImageId(productImageId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return base.Channel.FetchByProductImageTypeRcd(productImageTypeRcd);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productImageId) {
            base.Channel.Delete(productImageId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract FetchByImageFileName(string imageFileName) {
            return base.Channel.FetchByImageFileName(imageFileName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductImageContract> FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, string imageFileName, byte[] image, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productImageId: productImageId,
                productId: productId,
                productImageTypeRcd: productImageTypeRcd,
                imageFileName: imageFileName,
                image: image,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
