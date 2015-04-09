using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductExposedSelectionContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductExposedSelectionContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductExposedSelectionIdField;
        
        private System.Guid ProductExposeIdField;
        
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
        public System.Guid ProductExposedSelectionId {
            get {
                return ProductExposedSelectionIdField;
            }
            set {
                ProductExposedSelectionIdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposedSelectionService")]
    public interface ICrudeProductExposedSelectionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByProductExposedSele" +
            "ctionId", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByProductExposedSele" +
            "ctionIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract FetchByProductExposedSelectionId(System.Guid productExposedSelectionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByProductExposeId", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByProductExposeIdRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchByProductExposeId(System.Guid productExposeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/DeleteResponse")]
        void Delete(System.Guid productExposedSelectionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllWithLimitResponse" +
            "")]
        norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposedSelectionService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposedSelectionService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductExposedSelectionServiceChannel : ICrudeProductExposedSelectionService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposedSelectionService : System.ServiceModel.ClientBase<ICrudeProductExposedSelectionService>, ICrudeProductExposedSelectionService {
        
        public CrudeProductExposedSelectionService() {
        }
        
        public CrudeProductExposedSelectionService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposedSelectionService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposedSelectionService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposedSelectionService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract FetchByProductExposedSelectionId(System.Guid productExposedSelectionId) {
            return base.Channel.FetchByProductExposedSelectionId(productExposedSelectionId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchByProductExposeId(System.Guid productExposeId) {
            return base.Channel.FetchByProductExposeId(productExposeId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productExposedSelectionId) {
            base.Channel.Delete(productExposedSelectionId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposedSelectionContract[] FetchWithFilter(System.Guid productExposedSelectionId, System.Guid productExposeId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productExposedSelectionId,productExposeId,userId,dateTime);
        }
    }
}
