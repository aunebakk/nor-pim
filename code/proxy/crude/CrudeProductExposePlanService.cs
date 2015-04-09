using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductExposePlanContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductExposePlanContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductExposePlanIdField;
        
        private System.Guid ProductIdField;
        
        private string ProductExposeSetTypeRcdField;
        
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
        public System.Guid ProductExposePlanId {
            get {
                return ProductExposePlanIdField;
            }
            set {
                ProductExposePlanIdField = value;
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
        public string ProductExposeSetTypeRcd {
            get {
                return ProductExposeSetTypeRcdField;
            }
            set {
                ProductExposeSetTypeRcdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposePlanService")]
    public interface ICrudeProductExposePlanService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposePlanId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductExposePlanIdRespo" +
            "nse")]
        norpim.BusinessLogicLayer.CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductExposePlanContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductExposePlanContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/DeleteResponse")]
        void Delete(System.Guid productExposePlanId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllWithLimitAndOffsetRespo" +
            "nse")]
        norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposePlanService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposePlanService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductExposePlanServiceChannel : ICrudeProductExposePlanService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposePlanService : System.ServiceModel.ClientBase<ICrudeProductExposePlanService>, ICrudeProductExposePlanService {
        
        public CrudeProductExposePlanService() {
        }
        
        public CrudeProductExposePlanService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposePlanService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposePlanService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposePlanService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposePlanContract FetchByProductExposePlanId(System.Guid productExposePlanId) {
            return base.Channel.FetchByProductExposePlanId(productExposePlanId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductExposePlanContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductExposePlanContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productExposePlanId) {
            base.Channel.Delete(productExposePlanId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposePlanContract[] FetchWithFilter(System.Guid productExposePlanId, System.Guid productId, string productExposeSetTypeRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productExposePlanId,productId,productExposeSetTypeRcd,userId,dateTime);
        }
    }
}
