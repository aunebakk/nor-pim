using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductCategoryDocumentationTypeRef {
        
        public static string BottomText = "BT";
        
        public static string TopText = "TT";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductCategoryDocumentationTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductCategoryDocumentationTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductCategoryDocumentationTypeRcdField;
        
        private string ProductCategoryDocumentationTypeNameField;
        
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
        public string ProductCategoryDocumentationTypeRcd {
            get {
                return ProductCategoryDocumentationTypeRcdField;
            }
            set {
                ProductCategoryDocumentationTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategoryDocumentationTypeName {
            get {
                return ProductCategoryDocumentationTypeNameField;
            }
            set {
                ProductCategoryDocumentationTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryDocumentationTypeRefService")]
    public interface ICrudeProductCategoryDocumentationTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByProduc" +
            "tCategoryDocumentationTypeRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByUserId" +
            "", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchByUserId" +
            "Response")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/InsertRespons" +
            "e")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/UpdateRespons" +
            "e")]
        void Update(norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/DeleteRespons" +
            "e")]
        void Delete(string productCategoryDocumentationTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllRespo" +
            "nse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imit", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllWithL" +
            "imitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllCount" +
            "", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchAllCount" +
            "Response")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchWithFilt" +
            "er", ReplyAction="http://tempuri.org/ICrudeProductCategoryDocumentationTypeRefService/FetchWithFilt" +
            "erResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductCategoryDocumentationTypeRefServiceChannel : ICrudeProductCategoryDocumentationTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryDocumentationTypeRefService : System.ServiceModel.ClientBase<ICrudeProductCategoryDocumentationTypeRefService>, ICrudeProductCategoryDocumentationTypeRefService {
        
        public CrudeProductCategoryDocumentationTypeRefService() {
        }
        
        public CrudeProductCategoryDocumentationTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryDocumentationTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract FetchByProductCategoryDocumentationTypeRcd(string productCategoryDocumentationTypeRcd) {
            return base.Channel.FetchByProductCategoryDocumentationTypeRcd(productCategoryDocumentationTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productCategoryDocumentationTypeRcd) {
            base.Channel.Delete(productCategoryDocumentationTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryDocumentationTypeRefContract[] FetchWithFilter(string productCategoryDocumentationTypeRcd, string productCategoryDocumentationTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productCategoryDocumentationTypeRcd,productCategoryDocumentationTypeName,userId,dateTime);
        }
    }
}
