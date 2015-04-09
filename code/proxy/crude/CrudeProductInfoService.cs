using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductInfoContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductInfoContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductInfoIdField;
        
        private System.Guid ProductIdField;
        
        private string ProductInfoRcdField;
        
        private string ProductInfoValueField;
        
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
        public System.Guid ProductInfoId {
            get {
                return ProductInfoIdField;
            }
            set {
                ProductInfoIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductId {
            get {
                return ProductIdField;
            }
            set {
                ProductIdField = value;
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
        public string ProductInfoValue {
            get {
                return ProductInfoValueField;
            }
            set {
                ProductInfoValueField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductInfoService")]
    public interface ICrudeProductInfoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchByProductInfoId", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchByProductInfoIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/Insert", ReplyAction="http://tempuri.org/ICrudeProductInfoService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductInfoContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/Update", ReplyAction="http://tempuri.org/ICrudeProductInfoService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductInfoContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/Delete", ReplyAction="http://tempuri.org/ICrudeProductInfoService/DeleteResponse")]
        void Delete(System.Guid productInfoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductInfoService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductInfoService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductInfoServiceChannel : ICrudeProductInfoService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductInfoService : System.ServiceModel.ClientBase<ICrudeProductInfoService>, ICrudeProductInfoService {
        
        public CrudeProductInfoService() {
        }
        
        public CrudeProductInfoService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductInfoService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductInfoService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoContract FetchByProductInfoId(System.Guid productInfoId) {
            return base.Channel.FetchByProductInfoId(productInfoId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductInfoContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductInfoContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productInfoId) {
            base.Channel.Delete(productInfoId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductInfoContract[] FetchWithFilter(System.Guid productInfoId, System.Guid productId, string productInfoRcd, string productInfoValue, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productInfoId,productId,productInfoRcd,productInfoValue,userId,dateTime);
        }
    }
}
