using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductCategoryImageTypeRef {
        
        public static string LargeSize = "LS";
        
        public static string SmallSize = "SS";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductCategoryImageTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductCategoryImageTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductCategoryImageTypeRcdField;
        
        private string ProductCategoryImageTypeNameField;
        
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
        public string ProductCategoryImageTypeRcd {
            get {
                return ProductCategoryImageTypeRcdField;
            }
            set {
                ProductCategoryImageTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategoryImageTypeName {
            get {
                return ProductCategoryImageTypeNameField;
            }
            set {
                ProductCategoryImageTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryImageTypeRefService")]
    public interface ICrudeProductCategoryImageTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByProductCategor" +
            "yImageTypeRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchByUserIdResponse" +
            "")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/DeleteResponse")]
        void Delete(string productCategoryImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitResp" +
            "onse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitAndO" +
            "ffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllWithLimitAndO" +
            "ffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchAllCountResponse" +
            "")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryImageTypeRefService/FetchWithFilterRespon" +
            "se")]
        norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductCategoryImageTypeRefServiceChannel : ICrudeProductCategoryImageTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryImageTypeRefService : System.ServiceModel.ClientBase<ICrudeProductCategoryImageTypeRefService>, ICrudeProductCategoryImageTypeRefService {
        
        public CrudeProductCategoryImageTypeRefService() {
        }
        
        public CrudeProductCategoryImageTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryImageTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryImageTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract FetchByProductCategoryImageTypeRcd(string productCategoryImageTypeRcd) {
            return base.Channel.FetchByProductCategoryImageTypeRcd(productCategoryImageTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productCategoryImageTypeRcd) {
            base.Channel.Delete(productCategoryImageTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryImageTypeRefContract[] FetchWithFilter(string productCategoryImageTypeRcd, string productCategoryImageTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productCategoryImageTypeRcd,productCategoryImageTypeName,userId,dateTime);
        }
    }
}
