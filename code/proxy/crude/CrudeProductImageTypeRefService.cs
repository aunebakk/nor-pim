using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductImageTypeRef {
        
        public static string InternalStockPhoto = "ISP";
        
        public static string ProductImageVariableSize = "PI";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductImageTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductImageTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductImageTypeRcdField;
        
        private string ProductImageTypeNameField;
        
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
        public string ProductImageTypeRcd {
            get {
                return ProductImageTypeRcdField;
            }
            set {
                ProductImageTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductImageTypeName {
            get {
                return ProductImageTypeNameField;
            }
            set {
                ProductImageTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductImageTypeRefService")]
    public interface ICrudeProductImageTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByProductImageTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByProductImageTypeRcdRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/DeleteResponse")]
        void Delete(string productImageTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductImageTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductImageTypeRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductImageTypeRefServiceChannel : ICrudeProductImageTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductImageTypeRefService : System.ServiceModel.ClientBase<ICrudeProductImageTypeRefService>, ICrudeProductImageTypeRefService {
        
        public CrudeProductImageTypeRefService() {
        }
        
        public CrudeProductImageTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductImageTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductImageTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract FetchByProductImageTypeRcd(string productImageTypeRcd) {
            return base.Channel.FetchByProductImageTypeRcd(productImageTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productImageTypeRcd) {
            base.Channel.Delete(productImageTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductImageTypeRefContract[] FetchWithFilter(string productImageTypeRcd, string productImageTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productImageTypeRcd,productImageTypeName,userId,dateTime);
        }
    }
}
