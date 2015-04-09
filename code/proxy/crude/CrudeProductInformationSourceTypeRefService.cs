using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductInformationSourceTypeRef {
        
        public static string BasicProductIdentificationAndAttributes = "BPIA";
        
        public static string ProductSupplier = "PS";
        
        public static string AdditionalProductAttributes = "PAA";
        
        public static string TSQLScript = "tsql";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductInformationSourceTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductInformationSourceTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductInformationSourceTypeRcdField;
        
        private string ProductInformationSourceTypeNameField;
        
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
        public string ProductInformationSourceTypeRcd {
            get {
                return ProductInformationSourceTypeRcdField;
            }
            set {
                ProductInformationSourceTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductInformationSourceTypeName {
            get {
                return ProductInformationSourceTypeNameField;
            }
            set {
                ProductInformationSourceTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductInformationSourceTypeRefService")]
    public interface ICrudeProductInformationSourceTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/FetchByProductInf" +
            "ormationSourceTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/FetchByProductInf" +
            "ormationSourceTypeRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract FetchByProductInformationSourceTypeRcd(string productInformationSourceTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/FetchByUserIdResp" +
            "onse")]
        norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/DeleteResponse")]
        void Delete(string productInformationSourceTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductInformationSourceTypeRefService/FetchWithFilterRe" +
            "sponse")]
        norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract[] FetchWithFilter(string productInformationSourceTypeRcd, string productInformationSourceTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductInformationSourceTypeRefServiceChannel : ICrudeProductInformationSourceTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductInformationSourceTypeRefService : System.ServiceModel.ClientBase<ICrudeProductInformationSourceTypeRefService>, ICrudeProductInformationSourceTypeRefService {
        
        public CrudeProductInformationSourceTypeRefService() {
        }
        
        public CrudeProductInformationSourceTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductInformationSourceTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInformationSourceTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInformationSourceTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract FetchByProductInformationSourceTypeRcd(string productInformationSourceTypeRcd) {
            return base.Channel.FetchByProductInformationSourceTypeRcd(productInformationSourceTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productInformationSourceTypeRcd) {
            base.Channel.Delete(productInformationSourceTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInformationSourceTypeRefContract[] FetchWithFilter(string productInformationSourceTypeRcd, string productInformationSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productInformationSourceTypeRcd,productInformationSourceTypeName,userId,dateTime);
        }
    }
}
