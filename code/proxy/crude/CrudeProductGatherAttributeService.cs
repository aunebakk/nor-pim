using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductGatherAttributeContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductGatherAttributeContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductGatherAttributeIdField;
        
        private string ProductGatherAttributeValueField;
        
        private string ProductGatherAttributeTypeRcdField;
        
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
        public System.Guid ProductGatherAttributeId {
            get {
                return ProductGatherAttributeIdField;
            }
            set {
                ProductGatherAttributeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductGatherAttributeValue {
            get {
                return ProductGatherAttributeValueField;
            }
            set {
                ProductGatherAttributeValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductGatherAttributeTypeRcd {
            get {
                return ProductGatherAttributeTypeRcdField;
            }
            set {
                ProductGatherAttributeTypeRcdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherAttributeService")]
    public interface ICrudeProductGatherAttributeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherAttrib" +
            "uteIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherKeyId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByProductGatherKeyIdR" +
            "esponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchByProductGatherKeyId(System.Guid productGatherKeyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/DeleteResponse")]
        void Delete(System.Guid productGatherAttributeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitAndOffset" +
            "", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllWithLimitAndOffset" +
            "Response")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductGatherAttributeServiceChannel : ICrudeProductGatherAttributeService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherAttributeService : System.ServiceModel.ClientBase<ICrudeProductGatherAttributeService>, ICrudeProductGatherAttributeService {
        
        public CrudeProductGatherAttributeService() {
        }
        
        public CrudeProductGatherAttributeService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherAttributeService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract FetchByProductGatherAttributeId(System.Guid productGatherAttributeId) {
            return base.Channel.FetchByProductGatherAttributeId(productGatherAttributeId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchByProductGatherKeyId(System.Guid productGatherKeyId) {
            return base.Channel.FetchByProductGatherKeyId(productGatherKeyId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productGatherAttributeId) {
            base.Channel.Delete(productGatherAttributeId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeContract[] FetchWithFilter(System.Guid productGatherAttributeId, string productGatherAttributeValue, string productGatherAttributeTypeRcd, System.Guid productGatherKeyId, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productGatherAttributeId,productGatherAttributeValue,productGatherAttributeTypeRcd,productGatherKeyId,userId,dateTime);
        }
    }
}
