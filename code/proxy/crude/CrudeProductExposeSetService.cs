using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductExposeSetContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductExposeSetContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductExposeSetIdField;
        
        private string ProductExposeSetTypeRcdField;
        
        private string ProductExposeSetNameField;
        
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
        public System.Guid ProductExposeSetId {
            get {
                return ProductExposeSetIdField;
            }
            set {
                ProductExposeSetIdField = value;
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
        public string ProductExposeSetName {
            get {
                return ProductExposeSetNameField;
            }
            set {
                ProductExposeSetNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductExposeSetService")]
    public interface ICrudeProductExposeSetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetId", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByProductExposeSetIdRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Insert", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductExposeSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Update", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductExposeSetContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/Delete", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/DeleteResponse")]
        void Delete(System.Guid productExposeSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductExposeSetService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductExposeSetService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductExposeSetServiceChannel : ICrudeProductExposeSetService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductExposeSetService : System.ServiceModel.ClientBase<ICrudeProductExposeSetService>, ICrudeProductExposeSetService {
        
        public CrudeProductExposeSetService() {
        }
        
        public CrudeProductExposeSetService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductExposeSetService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductExposeSetService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetContract FetchByProductExposeSetId(System.Guid productExposeSetId) {
            return base.Channel.FetchByProductExposeSetId(productExposeSetId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductExposeSetContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductExposeSetContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productExposeSetId) {
            base.Channel.Delete(productExposeSetId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductExposeSetContract[] FetchWithFilter(System.Guid productExposeSetId, string productExposeSetTypeRcd, string productExposeSetName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productExposeSetId,productExposeSetTypeRcd,productExposeSetName,userId,dateTime);
        }
    }
}
