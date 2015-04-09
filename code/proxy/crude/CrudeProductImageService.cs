using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductImageContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductImageContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductImageIdField;
        
        private System.Guid ProductIdField;
        
        private string ProductImageTypeRcdField;
        
        private byte[] ImageField;
        
        private System.Guid UserIdField;
        
        private System.DateTime DateTimeField;
        
        private string ImageFileNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductImageId {
            get {
                return ProductImageIdField;
            }
            set {
                ProductImageIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductId {
            get {
                return ProductIdField;
            }
            set {
                ProductIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductImageTypeRcd {
            get {
                return ProductImageTypeRcdField;
            }
            set {
                ProductImageTypeRcdField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFileName {
            get {
                return ImageFileNameField;
            }
            set {
                ImageFileNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductImageService")]
    public interface ICrudeProductImageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByProductImageId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByProductImageIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageContract FetchByProductImageId(System.Guid productImageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Insert", ReplyAction="http://tempuri.org/ICrudeProductImageService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductImageContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Update", ReplyAction="http://tempuri.org/ICrudeProductImageService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductImageContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/Delete", ReplyAction="http://tempuri.org/ICrudeProductImageService/DeleteResponse")]
        void Delete(System.Guid productImageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductImageService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime, string imageFileName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductImageServiceChannel : ICrudeProductImageService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductImageService : System.ServiceModel.ClientBase<ICrudeProductImageService>, ICrudeProductImageService {
        
        public CrudeProductImageService() {
        }
        
        public CrudeProductImageService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductImageService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageContract FetchByProductImageId(System.Guid productImageId) {
            return base.Channel.FetchByProductImageId(productImageId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductImageContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductImageContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productImageId) {
            base.Channel.Delete(productImageId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageContract[] FetchWithFilter(System.Guid productImageId, System.Guid productId, string productImageTypeRcd, byte[] image, System.Guid userId, System.DateTime dateTime, string imageFileName) {
            return base.Channel.FetchWithFilter(productImageId,productId,productImageTypeRcd,image,userId,dateTime,imageFileName);
        }
    }
}
