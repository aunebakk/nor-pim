using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeSystemReferenceTableContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeSystemReferenceTableContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid SystemReferenceTableIdField;
        
        private string SystemReferenceTableNameField;
        
        private string SystemReferenceDisplayNameField;
        
        private System.DateTime DateTimeField;
        
        private System.Guid UserIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid SystemReferenceTableId {
            get {
                return SystemReferenceTableIdField;
            }
            set {
                SystemReferenceTableIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemReferenceTableName {
            get {
                return SystemReferenceTableNameField;
            }
            set {
                SystemReferenceTableNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemReferenceDisplayName {
            get {
                return SystemReferenceDisplayNameField;
            }
            set {
                SystemReferenceDisplayNameField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId {
            get {
                return UserIdField;
            }
            set {
                UserIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeSystemReferenceTableService")]
    public interface ICrudeSystemReferenceTableService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/FetchBySystemReferenceTableI" +
            "d", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/FetchBySystemReferenceTableI" +
            "dResponse")]
        norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract FetchBySystemReferenceTableId(System.Guid systemReferenceTableId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/Insert", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/Update", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/Delete", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/DeleteResponse")]
        void Delete(System.Guid systemReferenceTableId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/FetchAll", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/FetchAllWithLimitAndOffsetRe" +
            "sponse")]
        norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemReferenceTableService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeSystemReferenceTableService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchWithFilter(System.Guid systemReferenceTableId, string systemReferenceTableName, string systemReferenceDisplayName, System.DateTime dateTime, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeSystemReferenceTableServiceChannel : ICrudeSystemReferenceTableService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeSystemReferenceTableService : System.ServiceModel.ClientBase<ICrudeSystemReferenceTableService>, ICrudeSystemReferenceTableService {
        
        public CrudeSystemReferenceTableService() {
        }
        
        public CrudeSystemReferenceTableService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeSystemReferenceTableService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeSystemReferenceTableService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeSystemReferenceTableService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract FetchBySystemReferenceTableId(System.Guid systemReferenceTableId) {
            return base.Channel.FetchBySystemReferenceTableId(systemReferenceTableId);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid systemReferenceTableId) {
            base.Channel.Delete(systemReferenceTableId);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemReferenceTableContract[] FetchWithFilter(System.Guid systemReferenceTableId, string systemReferenceTableName, string systemReferenceDisplayName, System.DateTime dateTime, System.Guid userId) {
            return base.Channel.FetchWithFilter(systemReferenceTableId,systemReferenceTableName,systemReferenceDisplayName,dateTime,userId);
        }
    }
}
