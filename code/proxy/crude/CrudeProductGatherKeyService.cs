using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductGatherKeyContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductGatherKeyContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductGatherKeyIdField;
        
        private string ProductGatherKeyValueField;
        
        private System.Guid ProductGatherIdField;
        
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
        public System.Guid ProductGatherKeyId {
            get {
                return ProductGatherKeyIdField;
            }
            set {
                ProductGatherKeyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductGatherKeyValue {
            get {
                return ProductGatherKeyValueField;
            }
            set {
                ProductGatherKeyValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductGatherId {
            get {
                return ProductGatherIdField;
            }
            set {
                ProductGatherIdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherKeyService")]
    public interface ICrudeProductGatherKeyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherKeyIdRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByProductGatherIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchByProductGatherId(System.Guid productGatherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductGatherKeyContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductGatherKeyContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/DeleteResponse")]
        void Delete(System.Guid productGatherKeyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherKeyService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherKeyService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductGatherKeyServiceChannel : ICrudeProductGatherKeyService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherKeyService : System.ServiceModel.ClientBase<ICrudeProductGatherKeyService>, ICrudeProductGatherKeyService {
        
        public CrudeProductGatherKeyService() {
        }
        
        public CrudeProductGatherKeyService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherKeyService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherKeyService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherKeyService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherKeyContract FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchByProductGatherId(System.Guid productGatherId) {
            return base.Channel.FetchByProductGatherId(productGatherId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductGatherKeyContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductGatherKeyContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productGatherKeyId) {
            base.Channel.Delete(productGatherKeyId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherKeyContract[] FetchWithFilter(System.Guid productGatherKeyId, string productGatherKeyValue, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productGatherKeyId,productGatherKeyValue,productGatherId,userId,dateTime);
        }
    }
}
