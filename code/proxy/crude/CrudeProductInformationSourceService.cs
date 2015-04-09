using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductInformationSourceContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductInformationSourceContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductInformationSourceIdField;
        
        private string ProductInformationSourceTypeRcdField;
        
        private string ProductInformationSourceField;
        
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
        public System.Guid ProductInformationSourceId {
            get {
                return ProductInformationSourceIdField;
            }
            set {
                ProductInformationSourceIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductInformationSourceTypeRcd {
            get {
                return ProductInformationSourceTypeRcdField;
            }
            set {
                ProductInformationSourceTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductInformationSource {
            get {
                return ProductInformationSourceField;
            }
            set {
                ProductInformationSourceField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductInformationSourceService")]
    public interface ICrudeProductInformationSourceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceService/FetchByProductInformatio" +
            "nSourceId", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceService/FetchByProductInformatio" +
            "nSourceIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductInformationSourceContract FetchByProductInformationSourceId(System.Guid productInformationSourceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductInformationSourceContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceService/Insert", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductInformationSourceContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceService/Update", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductInformationSourceContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceService/Delete", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceService/DeleteResponse")]
        void Delete(System.Guid productInformationSourceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductInformationSourceContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductInformationSourceContract[] FetchWithFilter(System.Guid productInformationSourceId, string productInformationSourceTypeRcd, string productInformationSource, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductInformationSourceServiceChannel : ICrudeProductInformationSourceService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductInformationSourceService : System.ServiceModel.ClientBase<ICrudeProductInformationSourceService>, ICrudeProductInformationSourceService {
        
        public CrudeProductInformationSourceService() {
        }
        
        public CrudeProductInformationSourceService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductInformationSourceService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInformationSourceService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInformationSourceService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInformationSourceContract FetchByProductInformationSourceId(System.Guid productInformationSourceId) {
            return base.Channel.FetchByProductInformationSourceId(productInformationSourceId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInformationSourceContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductInformationSourceContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductInformationSourceContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productInformationSourceId) {
            base.Channel.Delete(productInformationSourceId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInformationSourceContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInformationSourceContract[] FetchWithFilter(System.Guid productInformationSourceId, string productInformationSourceTypeRcd, string productInformationSource, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productInformationSourceId,productInformationSourceTypeRcd,productInformationSource,userId,dateTime);
        }
    }
}
