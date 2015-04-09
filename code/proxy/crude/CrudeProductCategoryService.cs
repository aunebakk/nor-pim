using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductCategoryContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductCategoryContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductCategoryIdField;
        
        private System.Guid ProductCategoryBecameIdField;
        
        private System.Guid ProductCategoryParentIdField;
        
        private string ProductCategoryCodeField;
        
        private string ProductCategoryNameField;
        
        private int ProductCategoryPositionField;
        
        private string StateRcdField;
        
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
        public System.Guid ProductCategoryId {
            get {
                return ProductCategoryIdField;
            }
            set {
                ProductCategoryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductCategoryBecameId {
            get {
                return ProductCategoryBecameIdField;
            }
            set {
                ProductCategoryBecameIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductCategoryParentId {
            get {
                return ProductCategoryParentIdField;
            }
            set {
                ProductCategoryParentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategoryCode {
            get {
                return ProductCategoryCodeField;
            }
            set {
                ProductCategoryCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategoryName {
            get {
                return ProductCategoryNameField;
            }
            set {
                ProductCategoryNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductCategoryPosition {
            get {
                return ProductCategoryPositionField;
            }
            set {
                ProductCategoryPositionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StateRcd {
            get {
                return StateRcdField;
            }
            set {
                StateRcdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductCategoryService")]
    public interface ICrudeProductCategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Insert", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Update", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductCategoryContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/Delete", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/DeleteResponse")]
        void Delete(System.Guid productCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryCode", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchByProductCategoryCodeRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryCode(string productCategoryCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductCategoryService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductCategoryService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductCategoryServiceChannel : ICrudeProductCategoryService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductCategoryService : System.ServiceModel.ClientBase<ICrudeProductCategoryService>, ICrudeProductCategoryService {
        
        public CrudeProductCategoryService() {
        }
        
        public CrudeProductCategoryService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductCategoryService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductCategoryService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryId(System.Guid productCategoryId) {
            return base.Channel.FetchByProductCategoryId(productCategoryId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductCategoryContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductCategoryContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productCategoryId) {
            base.Channel.Delete(productCategoryId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryContract FetchByProductCategoryCode(string productCategoryCode) {
            return base.Channel.FetchByProductCategoryCode(productCategoryCode);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductCategoryContract[] FetchWithFilter(System.Guid productCategoryId, System.Guid productCategoryBecameId, System.Guid productCategoryParentId, string productCategoryCode, string productCategoryName, int productCategoryPosition, string stateRcd, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productCategoryId,productCategoryBecameId,productCategoryParentId,productCategoryCode,productCategoryName,productCategoryPosition,stateRcd,userId,dateTime);
        }
    }
}
