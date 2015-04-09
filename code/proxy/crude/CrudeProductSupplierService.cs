using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductSupplierContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductSupplierContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductSupplierIdField;
        
        private System.Guid ProductIdField;
        
        private string SupplierNameField;
        
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
        public System.Guid ProductSupplierId {
            get {
                return ProductSupplierIdField;
            }
            set {
                ProductSupplierIdField = value;
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
        public string SupplierName {
            get {
                return SupplierNameField;
            }
            set {
                SupplierNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductSupplierService")]
    public interface ICrudeProductSupplierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchByProductSupplierId", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchByProductSupplierIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchByProductId", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchByProductIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchByProductId(System.Guid productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/Insert", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductSupplierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/Update", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductSupplierContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/Delete", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/DeleteResponse")]
        void Delete(System.Guid productSupplierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductSupplierService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductSupplierService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductSupplierServiceChannel : ICrudeProductSupplierService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductSupplierService : System.ServiceModel.ClientBase<ICrudeProductSupplierService>, ICrudeProductSupplierService {
        
        public CrudeProductSupplierService() {
        }
        
        public CrudeProductSupplierService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductSupplierService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductSupplierService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductSupplierService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductSupplierContract FetchByProductSupplierId(System.Guid productSupplierId) {
            return base.Channel.FetchByProductSupplierId(productSupplierId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchByProductId(System.Guid productId) {
            return base.Channel.FetchByProductId(productId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductSupplierContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductSupplierContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productSupplierId) {
            base.Channel.Delete(productSupplierId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductSupplierContract[] FetchWithFilter(System.Guid productSupplierId, System.Guid productId, string supplierName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productSupplierId,productId,supplierName,userId,dateTime);
        }
    }
}
