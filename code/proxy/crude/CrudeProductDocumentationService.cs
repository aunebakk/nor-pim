using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductDocumentationContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductDocumentationContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductDocumentationIdField;
        
        private System.Guid ProductIdField;
        
        private string ProductDocumentationTypeRcdField;
        
        private string DocumentationField;
        
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
        public System.Guid ProductDocumentationId {
            get {
                return ProductDocumentationIdField;
            }
            set {
                ProductDocumentationIdField = value;
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
        public string ProductDocumentationTypeRcd {
            get {
                return ProductDocumentationTypeRcdField;
            }
            set {
                ProductDocumentationTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Documentation {
            get {
                return DocumentationField;
            }
            set {
                DocumentationField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductDocumentationService")]
    public interface ICrudeProductDocumentationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationI" +
            "d", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductDocumentationI" +
            "dResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Insert", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductDocumentationContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Update", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductDocumentationContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/Delete", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/DeleteResponse")]
        void Delete(System.Guid productDocumentationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductDocumentationService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductDocumentationServiceChannel : ICrudeProductDocumentationService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductDocumentationService : System.ServiceModel.ClientBase<ICrudeProductDocumentationService>, ICrudeProductDocumentationService {
        
        public CrudeProductDocumentationService() {
        }
        
        public CrudeProductDocumentationService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductDocumentationService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationContract FetchByProductDocumentationId(System.Guid productDocumentationId) {
            return base.Channel.FetchByProductDocumentationId(productDocumentationId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductDocumentationContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductDocumentationContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productDocumentationId) {
            base.Channel.Delete(productDocumentationId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationContract[] FetchWithFilter(System.Guid productDocumentationId, System.Guid productId, string productDocumentationTypeRcd, string documentation, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productDocumentationId,productId,productDocumentationTypeRcd,documentation,userId,dateTime);
        }
    }
}
