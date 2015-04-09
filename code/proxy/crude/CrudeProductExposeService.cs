using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductExposeContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductExposeContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductExposeIdField;
        
        private System.Guid ExposeProductIdField;
        
        private System.Guid ExposeBasedOnProductIdField;
        
        private System.Guid ProductExposeSetIdField;
        
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
        public System.Guid ProductExposeId {
            get {
                return ProductExposeIdField;
            }
            set {
                ProductExposeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ExposeProductId {
            get {
                return ExposeProductIdField;
            }
            set {
                ExposeProductIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ExposeBasedOnProductId {
            get {
                return ExposeBasedOnProductIdField;
            }
            set {
                ExposeBasedOnProductIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductExposeSetId {
            get {
                return ProductExposeSetIdField;
            }
            set {
                ProductExposeSetIdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposeService")]
    public interface ICrudeProductExposeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeSetId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByProductExposeSetIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposeService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductExposeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposeService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductExposeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposeService/DeleteResponse")]
        void Delete(System.Guid productExposeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposeService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductExposeServiceChannel : ICrudeProductExposeService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposeService : System.ServiceModel.ClientBase<ICrudeProductExposeService>, ICrudeProductExposeService {
        
        public CrudeProductExposeService() {
        }
        
        public CrudeProductExposeService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposeService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeContract FetchByProductExposeId(System.Guid productExposeId) {
            return base.Channel.FetchByProductExposeId(productExposeId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return base.Channel.FetchByProductExposeSetId(productExposeSetId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductExposeContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductExposeContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productExposeId) {
            base.Channel.Delete(productExposeId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeContract[] FetchWithFilter(System.Guid productExposeId, System.Guid exposeProductId, System.Guid exposeBasedOnProductId, System.Guid productExposeSetId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productExposeId,exposeProductId,exposeBasedOnProductId,productExposeSetId,userId,dateTime);
        }
    }
}
