using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductCategoryImageContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductCategoryImageContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductCategoryImageIdField;
        
        private System.Guid ProductCategoryIdField;
        
        private string ProductCategoryImageTypeRcdField;
        
        private byte[] ImageField;
        
        private System.Guid UserIdField;
        
        private System.DateTime DateTimeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductCategoryImageId {
            get {
                return ProductCategoryImageIdField;
            }
            set {
                ProductCategoryImageIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductCategoryId {
            get {
                return ProductCategoryIdField;
            }
            set {
                ProductCategoryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategoryImageTypeRcd {
            get {
                return ProductCategoryImageTypeRcdField;
            }
            set {
                ProductCategoryImageTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return ImageField;
            }
            set {
                ImageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId {
            get {
                return UserIdField;
            }
            set {
                UserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTime {
            get {
                return DateTimeField;
            }
            set {
                DateTimeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryImageService")]
    public interface ICrudeProductCategoryImageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageI" +
            "d", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryImageI" +
            "dResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByProductCategoryIdResp" +
            "onse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchByProductCategoryId(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryImageContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductCategoryImageContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/DeleteResponse")]
        void Delete(System.Guid productCategoryImageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductCategoryImageServiceChannel : ICrudeProductCategoryImageService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryImageService : System.ServiceModel.ClientBase<ICrudeProductCategoryImageService>, ICrudeProductCategoryImageService {
        
        public CrudeProductCategoryImageService() {
        }
        
        public CrudeProductCategoryImageService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryImageService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageContract FetchByProductCategoryImageId(System.Guid productCategoryImageId) {
            return base.Channel.FetchByProductCategoryImageId(productCategoryImageId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryImageContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductCategoryImageContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productCategoryImageId) {
            base.Channel.Delete(productCategoryImageId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageContract[] FetchWithFilter(System.Guid productCategoryImageId, System.Guid productCategoryId, string productCategoryImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productCategoryImageId,productCategoryId,productCategoryImageTypeRcd,image,userId,dateTime);
        }
    }
}
