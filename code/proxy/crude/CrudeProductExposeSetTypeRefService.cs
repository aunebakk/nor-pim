using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductExposeSetTypeRef {
        
        public static string Customer = "Customer";
        
        public static string Export = "Export";
        
        public static string Print = "Print";
        
        public static string Web = "Web";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductExposeSetTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductExposeSetTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductExposeSetTypeRcdField;
        
        private string ProductExposeSetTypeNameField;
        
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
        public string ProductExposeSetTypeRcd {
            get {
                return ProductExposeSetTypeRcdField;
            }
            set {
                ProductExposeSetTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductExposeSetTypeName {
            get {
                return ProductExposeSetTypeNameField;
            }
            set {
                ProductExposeSetTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposeSetTypeRefService")]
    public interface ICrudeProductExposeSetTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByProductExposeSetTy" +
            "peRcd", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByProductExposeSetTy" +
            "peRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/DeleteResponse")]
        void Delete(string productExposeSetTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllWithLimitResponse" +
            "")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllWithLimitAndOffse" +
            "t", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllWithLimitAndOffse" +
            "tResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposeSetTypeRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductExposeSetTypeRefServiceChannel : ICrudeProductExposeSetTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposeSetTypeRefService : System.ServiceModel.ClientBase<ICrudeProductExposeSetTypeRefService>, ICrudeProductExposeSetTypeRefService {
        
        public CrudeProductExposeSetTypeRefService() {
        }
        
        public CrudeProductExposeSetTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposeSetTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract FetchByProductExposeSetTypeRcd(string productExposeSetTypeRcd) {
            return base.Channel.FetchByProductExposeSetTypeRcd(productExposeSetTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productExposeSetTypeRcd) {
            base.Channel.Delete(productExposeSetTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetTypeRefContract[] FetchWithFilter(string productExposeSetTypeRcd, string productExposeSetTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productExposeSetTypeRcd,productExposeSetTypeName,userId,dateTime);
        }
    }
}
