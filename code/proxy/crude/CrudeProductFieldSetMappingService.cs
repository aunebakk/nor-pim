using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductFieldSetMappingContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductFieldSetMappingContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductFieldSetMappingIdField;
        
        private System.Guid ProductFieldSetIdField;
        
        private string ProductIdentifierRcdField;
        
        private string ProductAttributeRcdField;
        
        private string ProductInfoRcdField;
        
        private string ProductImageTypeRcdField;
        
        private string ProductDocumentationTypeRcdField;
        
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
        public System.Guid ProductFieldSetMappingId {
            get {
                return ProductFieldSetMappingIdField;
            }
            set {
                ProductFieldSetMappingIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductFieldSetId {
            get {
                return ProductFieldSetIdField;
            }
            set {
                ProductFieldSetIdField = value;
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
        public string ProductAttributeRcd {
            get {
                return ProductAttributeRcdField;
            }
            set {
                ProductAttributeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductInfoRcd {
            get {
                return ProductInfoRcdField;
            }
            set {
                ProductInfoRcdField = value;
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
        public string ProductDocumentationTypeRcd {
            get {
                return ProductDocumentationTypeRcdField;
            }
            set {
                ProductDocumentationTypeRcdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductFieldSetMappingService")]
    public interface ICrudeProductFieldSetMappingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetMapp" +
            "ingId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetMapp" +
            "ingIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByProductFieldSetIdRe" +
            "sponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Insert", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Update", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/Delete", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/DeleteResponse")]
        void Delete(System.Guid productFieldSetMappingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllWithLimitAndOffset" +
            "Response")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductFieldSetMappingService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductFieldSetMappingServiceChannel : ICrudeProductFieldSetMappingService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductFieldSetMappingService : System.ServiceModel.ClientBase<ICrudeProductFieldSetMappingService>, ICrudeProductFieldSetMappingService {
        
        public CrudeProductFieldSetMappingService() {
        }
        
        public CrudeProductFieldSetMappingService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductFieldSetMappingService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductFieldSetMappingService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductFieldSetMappingService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract FetchByProductFieldSetMappingId(System.Guid productFieldSetMappingId) {
            return base.Channel.FetchByProductFieldSetMappingId(productFieldSetMappingId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchByProductFieldSetId(System.Guid productFieldSetId) {
            return base.Channel.FetchByProductFieldSetId(productFieldSetId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productFieldSetMappingId) {
            base.Channel.Delete(productFieldSetMappingId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetMappingContract[] FetchWithFilter(System.Guid productFieldSetMappingId, System.Guid productFieldSetId, string productIdentifierRcd, string productAttributeRcd, string productInfoRcd, string productImageTypeRcd, string productDocumentationTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productFieldSetMappingId,productFieldSetId,productIdentifierRcd,productAttributeRcd,productInfoRcd,productImageTypeRcd,productDocumentationTypeRcd,userId,dateTime);
        }
    }
}
