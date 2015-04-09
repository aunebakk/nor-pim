using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductCategoryMappingContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductCategoryMappingContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductCategoryMappingIdField;
        
        private System.Guid ProductCategoryIdField;
        
        private System.Guid ProductIdField;
        
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
        public System.Guid ProductCategoryMappingId {
            get {
                return ProductCategoryMappingIdField;
            }
            set {
                ProductCategoryMappingIdField = value;
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
        public System.Guid ProductId {
            get {
                return ProductIdField;
            }
            set {
                ProductIdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryMappingService")]
    public interface ICrudeProductCategoryMappingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductCategoryMapp" +
            "ingId", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductCategoryMapp" +
            "ingIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductCategoryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductCategoryIdRe" +
            "sponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchByProductCategoryId(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/DeleteResponse")]
        void Delete(System.Guid productCategoryMappingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllWithLimitAndOffset" +
            "Response")]
        norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryMappingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryMappingService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductCategoryMappingServiceChannel : ICrudeProductCategoryMappingService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryMappingService : System.ServiceModel.ClientBase<ICrudeProductCategoryMappingService>, ICrudeProductCategoryMappingService {
        
        public CrudeProductCategoryMappingService() {
        }
        
        public CrudeProductCategoryMappingService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryMappingService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryMappingService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryMappingService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract FetchByProductCategoryMappingId(System.Guid productCategoryMappingId) {
            return base.Channel.FetchByProductCategoryMappingId(productCategoryMappingId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productCategoryMappingId) {
            base.Channel.Delete(productCategoryMappingId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryMappingContract[] FetchWithFilter(System.Guid productCategoryMappingId, System.Guid productCategoryId, System.Guid productId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productCategoryMappingId,productCategoryId,productId,userId,dateTime);
        }
    }
}
