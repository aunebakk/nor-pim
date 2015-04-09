using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductIdField;
        
        private System.Guid ProductBecameIdField;
        
        private string ProductNameField;
        
        private string StateRcdField;
        
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
        public System.Guid ProductId {
            get {
                return ProductIdField;
            }
            set {
                ProductIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductBecameId {
            get {
                return ProductBecameIdField;
            }
            set {
                ProductBecameIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return ProductNameField;
            }
            set {
                ProductNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StateRcd {
            get {
                return StateRcdField;
            }
            set {
                StateRcdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductService")]
    public interface ICrudeProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductContract FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/Insert", ReplyAction="http://tempuri.org/ICrudeProductService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/Update", ReplyAction="http://tempuri.org/ICrudeProductService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/Delete", ReplyAction="http://tempuri.org/ICrudeProductService/DeleteResponse")]
        void Delete(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchByProductName", ReplyAction="http://tempuri.org/ICrudeProductService/FetchByProductNameResponse")]
        norpim.BusinessLogicLayer.CrudeProductContract FetchByProductName(string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductContract[] FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductServiceChannel : ICrudeProductService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductService : System.ServiceModel.ClientBase<ICrudeProductService>, ICrudeProductService {
        
        public CrudeProductService() {
        }
        
        public CrudeProductService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductContract FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productId) {
            base.Channel.Delete(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductContract FetchByProductName(string productName) {
            return base.Channel.FetchByProductName(productName);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductContract[] FetchWithFilter(System.Guid productId, System.Guid productBecameId, string productName, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productId,productBecameId,productName,stateRcd,userId,dateTime);
        }
    }
}
