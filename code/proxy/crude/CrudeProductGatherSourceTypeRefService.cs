using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductGatherSourceTypeRef {
        
        public static string TSQLScript = "tsql";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductGatherSourceTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductGatherSourceTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductGatherSourceTypeRcdField;
        
        private string ProductGatherSourceTypeNameField;
        
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
        public string ProductGatherSourceTypeRcd {
            get {
                return ProductGatherSourceTypeRcdField;
            }
            set {
                ProductGatherSourceTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductGatherSourceTypeName {
            get {
                return ProductGatherSourceTypeNameField;
            }
            set {
                ProductGatherSourceTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherSourceTypeRefService")]
    public interface ICrudeProductGatherSourceTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByProductGatherSo" +
            "urceTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByProductGatherSo" +
            "urceTypeRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/DeleteResponse")]
        void Delete(string productGatherSourceTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllWithLimitRespo" +
            "nse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllWithLimitAndOf" +
            "fset", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllWithLimitAndOf" +
            "fsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceTypeRefService/FetchWithFilterRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductGatherSourceTypeRefServiceChannel : ICrudeProductGatherSourceTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherSourceTypeRefService : System.ServiceModel.ClientBase<ICrudeProductGatherSourceTypeRefService>, ICrudeProductGatherSourceTypeRefService {
        
        public CrudeProductGatherSourceTypeRefService() {
        }
        
        public CrudeProductGatherSourceTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherSourceTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract FetchByProductGatherSourceTypeRcd(string productGatherSourceTypeRcd) {
            return base.Channel.FetchByProductGatherSourceTypeRcd(productGatherSourceTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productGatherSourceTypeRcd) {
            base.Channel.Delete(productGatherSourceTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceTypeRefContract[] FetchWithFilter(string productGatherSourceTypeRcd, string productGatherSourceTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productGatherSourceTypeRcd,productGatherSourceTypeName,userId,dateTime);
        }
    }
}
