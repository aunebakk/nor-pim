using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductFieldSetContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductFieldSetContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductFieldSetIdField;
        
        private string ProductFieldSetNameField;
        
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
        public System.Guid ProductFieldSetId {
            get {
                return ProductFieldSetIdField;
            }
            set {
                ProductFieldSetIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductFieldSetName {
            get {
                return ProductFieldSetNameField;
            }
            set {
                ProductFieldSetNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductFieldSetService")]
    public interface ICrudeProductFieldSetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchByProductFieldSetId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchByProductFieldSetIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/Insert", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductFieldSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/Update", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductFieldSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/Delete", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/DeleteResponse")]
        void Delete(System.Guid productFieldSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchAllWithLimitAndOffsetRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductFieldSetService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductFieldSetService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductFieldSetServiceChannel : ICrudeProductFieldSetService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductFieldSetService : System.ServiceModel.ClientBase<ICrudeProductFieldSetService>, ICrudeProductFieldSetService {
        
        public CrudeProductFieldSetService() {
        }
        
        public CrudeProductFieldSetService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductFieldSetService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductFieldSetService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductFieldSetService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetContract FetchByProductFieldSetId(System.Guid productFieldSetId) {
            return base.Channel.FetchByProductFieldSetId(productFieldSetId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductFieldSetContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductFieldSetContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productFieldSetId) {
            base.Channel.Delete(productFieldSetId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductFieldSetContract[] FetchWithFilter(System.Guid productFieldSetId, string productFieldSetName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productFieldSetId,productFieldSetName,userId,dateTime);
        }
    }
}
