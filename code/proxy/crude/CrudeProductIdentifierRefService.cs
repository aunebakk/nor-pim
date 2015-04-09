using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductIdentifierRef {
        
        public static string GTIN = "GTIN";
        
        public static string HN = "HN";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductIdentifierRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductIdentifierRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductIdentifierRcdField;
        
        private string ProductIdentifierNameField;
        
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
        public string ProductIdentifierRcd {
            get {
                return ProductIdentifierRcdField;
            }
            set {
                ProductIdentifierRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductIdentifierName {
            get {
                return ProductIdentifierNameField;
            }
            set {
                ProductIdentifierNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductIdentifierRefService")]
    public interface ICrudeProductIdentifierRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByProductIdentifierRcd", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByProductIdentifierRcdR" +
            "esponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract FetchByProductIdentifierRcd(string productIdentifierRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/DeleteResponse")]
        void Delete(string productIdentifierRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductIdentifierRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductIdentifierRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductIdentifierRefServiceChannel : ICrudeProductIdentifierRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductIdentifierRefService : System.ServiceModel.ClientBase<ICrudeProductIdentifierRefService>, ICrudeProductIdentifierRefService {
        
        public CrudeProductIdentifierRefService() {
        }
        
        public CrudeProductIdentifierRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductIdentifierRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductIdentifierRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductIdentifierRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract FetchByProductIdentifierRcd(string productIdentifierRcd) {
            return base.Channel.FetchByProductIdentifierRcd(productIdentifierRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productIdentifierRcd) {
            base.Channel.Delete(productIdentifierRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductIdentifierRefContract[] FetchWithFilter(string productIdentifierRcd, string productIdentifierName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productIdentifierRcd,productIdentifierName,userId,dateTime);
        }
    }
}
