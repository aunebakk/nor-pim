using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductAttributeRef {
        
        public static string Color = "Color";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductAttributeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductAttributeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductAttributeRcdField;
        
        private string ProductAttributeNameField;
        
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
        public string ProductAttributeRcd {
            get {
                return ProductAttributeRcdField;
            }
            set {
                ProductAttributeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductAttributeName {
            get {
                return ProductAttributeNameField;
            }
            set {
                ProductAttributeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductAttributeRefService")]
    public interface ICrudeProductAttributeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeRcd", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeRcdRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductAttributeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductAttributeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/DeleteResponse")]
        void Delete(string productAttributeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductAttributeRefServiceChannel : ICrudeProductAttributeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductAttributeRefService : System.ServiceModel.ClientBase<ICrudeProductAttributeRefService>, ICrudeProductAttributeRefService {
        
        public CrudeProductAttributeRefService() {
        }
        
        public CrudeProductAttributeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductAttributeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd) {
            return base.Channel.FetchByProductAttributeRcd(productAttributeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductAttributeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductAttributeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productAttributeRcd) {
            base.Channel.Delete(productAttributeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductAttributeRefContract[] FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productAttributeRcd,productAttributeName,userId,dateTime);
        }
    }
}
