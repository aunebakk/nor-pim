using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductCategoryDocumentationContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductCategoryDocumentationContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductCategoryDocumentationIdField;
        
        private string ProductCategoryDocumentationTypeRcdField;
        
        private System.Guid ProductCategoryIdField;
        
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
        public System.Guid ProductCategoryDocumentationId {
            get {
                return ProductCategoryDocumentationIdField;
            }
            set {
                ProductCategoryDocumentationIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategoryDocumentationTypeRcd {
            get {
                return ProductCategoryDocumentationTypeRcdField;
            }
            set {
                ProductCategoryDocumentationTypeRcdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryDocumentationService")]
    public interface ICrudeProductCategoryDocumentationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryDocumentationIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByProductCatego" +
            "ryIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchByProductCategoryId(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchByUserIdRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/DeleteResponse")]
        void Delete(System.Guid productCategoryDocumentationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitAnd" +
            "Offset", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllWithLimitAnd" +
            "OffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchAllCountRespons" +
            "e")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationService/FetchWithFilterRespo" +
            "nse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductCategoryDocumentationServiceChannel : ICrudeProductCategoryDocumentationService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryDocumentationService : System.ServiceModel.ClientBase<ICrudeProductCategoryDocumentationService>, ICrudeProductCategoryDocumentationService {
        
        public CrudeProductCategoryDocumentationService() {
        }
        
        public CrudeProductCategoryDocumentationService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryDocumentationService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract FetchByProductCategoryDocumentationId(System.Guid productCategoryDocumentationId) {
            return base.Channel.FetchByProductCategoryDocumentationId(productCategoryDocumentationId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productCategoryDocumentationId) {
            base.Channel.Delete(productCategoryDocumentationId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationContract[] FetchWithFilter(System.Guid productCategoryDocumentationId, string productCategoryDocumentationTypeRcd, System.Guid productCategoryId, string documentation, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productCategoryDocumentationId,productCategoryDocumentationTypeRcd,productCategoryId,documentation,userId,dateTime);
        }
    }
}
