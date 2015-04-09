using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductChangeSetContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductChangeSetContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductChangeSetIdField;
        
        private System.Guid ProductIdField;
        
        private System.Guid ProductGatherKeyIdField;
        
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
        public System.Guid ProductChangeSetId {
            get {
                return ProductChangeSetIdField;
            }
            set {
                ProductChangeSetIdField = value;
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
        public System.Guid ProductGatherKeyId {
            get {
                return ProductGatherKeyIdField;
            }
            set {
                ProductGatherKeyIdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductChangeSetService")]
    public interface ICrudeProductChangeSetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductChangeSetId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductChangeSetIdRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByProductGatherKeyIdRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Insert", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductChangeSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Update", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductChangeSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/Delete", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/DeleteResponse")]
        void Delete(System.Guid productChangeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductChangeSetService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductChangeSetService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductChangeSetServiceChannel : ICrudeProductChangeSetService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductChangeSetService : System.ServiceModel.ClientBase<ICrudeProductChangeSetService>, ICrudeProductChangeSetService {
        
        public CrudeProductChangeSetService() {
        }
        
        public CrudeProductChangeSetService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductChangeSetService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductChangeSetService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductChangeSetService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductChangeSetContract FetchByProductChangeSetId(System.Guid productChangeSetId) {
            return base.Channel.FetchByProductChangeSetId(productChangeSetId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductChangeSetContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductChangeSetContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productChangeSetId) {
            base.Channel.Delete(productChangeSetId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductChangeSetContract[] FetchWithFilter(System.Guid productChangeSetId, System.Guid productId, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productChangeSetId,productId,productGatherKeyId,userId,dateTime);
        }
    }
}
