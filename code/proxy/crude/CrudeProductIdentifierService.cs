using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductIdentifierContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductIdentifierContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductIdentifierIdField;
        
        private System.Guid ProductIdField;
        
        private string ProductIdentifierRcdField;
        
        private string IdentifierField;
        
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
        public System.Guid ProductIdentifierId {
            get {
                return ProductIdentifierIdField;
            }
            set {
                ProductIdentifierIdField = value;
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
        public string ProductIdentifierRcd {
            get {
                return ProductIdentifierRcdField;
            }
            set {
                ProductIdentifierRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Identifier {
            get {
                return IdentifierField;
            }
            set {
                IdentifierField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductIdentifierService")]
    public interface ICrudeProductIdentifierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductIdentifierId", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductIdentifierIdRespo" +
            "nse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierContract FetchByProductIdentifierId(System.Guid productIdentifierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/Insert", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductIdentifierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/Update", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductIdentifierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/Delete", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/DeleteResponse")]
        void Delete(System.Guid productIdentifierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchAllWithLimitAndOffsetRespo" +
            "nse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductIdentifierService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductIdentifierServiceChannel : ICrudeProductIdentifierService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductIdentifierService : System.ServiceModel.ClientBase<ICrudeProductIdentifierService>, ICrudeProductIdentifierService {
        
        public CrudeProductIdentifierService() {
        }
        
        public CrudeProductIdentifierService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductIdentifierService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductIdentifierService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductIdentifierService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierContract FetchByProductIdentifierId(System.Guid productIdentifierId) {
            return base.Channel.FetchByProductIdentifierId(productIdentifierId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductIdentifierContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductIdentifierContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productIdentifierId) {
            base.Channel.Delete(productIdentifierId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierContract[] FetchWithFilter(System.Guid productIdentifierId, System.Guid productId, string productIdentifierRcd, string identifier, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productIdentifierId,productId,productIdentifierRcd,identifier,userId,dateTime);
        }
    }
}
