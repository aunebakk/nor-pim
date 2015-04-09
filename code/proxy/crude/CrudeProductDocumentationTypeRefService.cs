using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductDocumentationTypeRef {
        
        public static string Headline = "HD";
        
        public static string LongDescription = "LD";
        
        public static string ShortDescription = "SD";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductDocumentationTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductDocumentationTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductDocumentationTypeRcdField;
        
        private string ProductDocumentationTypeNameField;
        
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
        public string ProductDocumentationTypeRcd {
            get {
                return ProductDocumentationTypeRcdField;
            }
            set {
                ProductDocumentationTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductDocumentationTypeName {
            get {
                return ProductDocumentationTypeNameField;
            }
            set {
                ProductDocumentationTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductDocumentationTypeRefService")]
    public interface ICrudeProductDocumentationTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByProductDocumen" +
            "tationTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByProductDocumen" +
            "tationTypeRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchByUserIdResponse" +
            "")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/DeleteResponse")]
        void Delete(string productDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllWithLimitResp" +
            "onse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllWithLimitAndO" +
            "ffset", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllWithLimitAndO" +
            "ffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchAllCountResponse" +
            "")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductDocumentationTypeRefService/FetchWithFilterRespon" +
            "se")]
        norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductDocumentationTypeRefServiceChannel : ICrudeProductDocumentationTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductDocumentationTypeRefService : System.ServiceModel.ClientBase<ICrudeProductDocumentationTypeRefService>, ICrudeProductDocumentationTypeRefService {
        
        public CrudeProductDocumentationTypeRefService() {
        }
        
        public CrudeProductDocumentationTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductDocumentationTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductDocumentationTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract FetchByProductDocumentationTypeRcd(string productDocumentationTypeRcd) {
            return base.Channel.FetchByProductDocumentationTypeRcd(productDocumentationTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productDocumentationTypeRcd) {
            base.Channel.Delete(productDocumentationTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductDocumentationTypeRefContract[] FetchWithFilter(string productDocumentationTypeRcd, string productDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productDocumentationTypeRcd,productDocumentationTypeName,userId,dateTime);
        }
    }
}
