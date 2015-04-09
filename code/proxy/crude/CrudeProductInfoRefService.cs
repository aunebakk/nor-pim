using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductInfoRef {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductInfoRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductInfoRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductInfoRcdField;
        
        private string ProductInfoNameField;
        
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
        public string ProductInfoRcd {
            get {
                return ProductInfoRcdField;
            }
            set {
                ProductInfoRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductInfoName {
            get {
                return ProductInfoNameField;
            }
            set {
                ProductInfoNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductInfoRefService")]
    public interface ICrudeProductInfoRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoRcd", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchByProductInfoRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductInfoRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductInfoRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/DeleteResponse")]
        void Delete(string productInfoRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllWithLimitAndOffsetResponse" +
            "")]
        norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductInfoRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductInfoRefServiceChannel : ICrudeProductInfoRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductInfoRefService : System.ServiceModel.ClientBase<ICrudeProductInfoRefService>, ICrudeProductInfoRefService {
        
        public CrudeProductInfoRefService() {
        }
        
        public CrudeProductInfoRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductInfoRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoRefContract FetchByProductInfoRcd(string productInfoRcd) {
            return base.Channel.FetchByProductInfoRcd(productInfoRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductInfoRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductInfoRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productInfoRcd) {
            base.Channel.Delete(productInfoRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoRefContract[] FetchWithFilter(string productInfoRcd, string productInfoName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productInfoRcd,productInfoName,userId,dateTime);
        }
    }
}
