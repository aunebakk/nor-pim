using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductAttributeUnitRef {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductAttributeUnitRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductAttributeUnitRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductAttributeUnitRcdField;
        
        private string ProductAttributeUnitNameField;
        
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
        public string ProductAttributeUnitRcd {
            get {
                return ProductAttributeUnitRcdField;
            }
            set {
                ProductAttributeUnitRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductAttributeUnitName {
            get {
                return ProductAttributeUnitNameField;
            }
            set {
                ProductAttributeUnitNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductAttributeUnitRefService")]
    public interface ICrudeProductAttributeUnitRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itRcd", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByProductAttributeUn" +
            "itRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/DeleteResponse")]
        void Delete(string productAttributeUnitRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitResponse" +
            "")]
        norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductAttributeUnitRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductAttributeUnitRefServiceChannel : ICrudeProductAttributeUnitRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductAttributeUnitRefService : System.ServiceModel.ClientBase<ICrudeProductAttributeUnitRefService>, ICrudeProductAttributeUnitRefService {
        
        public CrudeProductAttributeUnitRefService() {
        }
        
        public CrudeProductAttributeUnitRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductAttributeUnitRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeUnitRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeUnitRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract FetchByProductAttributeUnitRcd(string productAttributeUnitRcd) {
            return base.Channel.FetchByProductAttributeUnitRcd(productAttributeUnitRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productAttributeUnitRcd) {
            base.Channel.Delete(productAttributeUnitRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeUnitRefContract[] FetchWithFilter(string productAttributeUnitRcd, string productAttributeUnitName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productAttributeUnitRcd,productAttributeUnitName,userId,dateTime);
        }
    }
}
