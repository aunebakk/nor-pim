using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductAttributeContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductAttributeContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductAttributeIdField;
        
        private System.Guid ProductIdField;
        
        private string ProductAttributeRcdField;
        
        private string ProductAttributeUnitRcdField;
        
        private string ValueField;
        
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
        public System.Guid ProductAttributeId {
            get {
                return ProductAttributeIdField;
            }
            set {
                ProductAttributeIdField = value;
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
        public string ProductAttributeRcd {
            get {
                return ProductAttributeRcdField;
            }
            set {
                ProductAttributeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductAttributeUnitRcd {
            get {
                return ProductAttributeUnitRcdField;
            }
            set {
                ProductAttributeUnitRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return ValueField;
            }
            set {
                ValueField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductAttributeService")]
    public interface ICrudeProductAttributeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchByProductAttributeId", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchByProductAttributeIdRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/Insert", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductAttributeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/Update", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductAttributeContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/Delete", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/DeleteResponse")]
        void Delete(System.Guid productAttributeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductAttributeService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductAttributeServiceChannel : ICrudeProductAttributeService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductAttributeService : System.ServiceModel.ClientBase<ICrudeProductAttributeService>, ICrudeProductAttributeService {
        
        public CrudeProductAttributeService() {
        }
        
        public CrudeProductAttributeService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductAttributeService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeContract FetchByProductAttributeId(System.Guid productAttributeId) {
            return base.Channel.FetchByProductAttributeId(productAttributeId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductAttributeContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductAttributeContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productAttributeId) {
            base.Channel.Delete(productAttributeId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeContract[] FetchWithFilter(System.Guid productAttributeId, System.Guid productId, string productAttributeRcd, string productAttributeUnitRcd, string value, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productAttributeId,productId,productAttributeRcd,productAttributeUnitRcd,value,userId,dateTime);
        }
    }
}
