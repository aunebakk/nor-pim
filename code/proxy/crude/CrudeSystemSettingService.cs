using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeSystemSettingContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeSystemSettingContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid SystemSettingIdField;
        
        private string SystemSettingRcdField;
        
        private string SystemSettingValueField;
        
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
        public System.Guid SystemSettingId {
            get {
                return SystemSettingIdField;
            }
            set {
                SystemSettingIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemSettingRcd {
            get {
                return SystemSettingRcdField;
            }
            set {
                SystemSettingRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemSettingValue {
            get {
                return SystemSettingValueField;
            }
            set {
                SystemSettingValueField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeSystemSettingService")]
    public interface ICrudeSystemSettingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/FetchBySystemSettingId", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/FetchBySystemSettingIdResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingContract FetchBySystemSettingId(System.Guid systemSettingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/Insert", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeSystemSettingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/Update", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeSystemSettingContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/Delete", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/DeleteResponse")]
        void Delete(System.Guid systemSettingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/FetchAll", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeSystemSettingService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchWithFilter(System.Guid systemSettingId, string systemSettingRcd, string systemSettingValue, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeSystemSettingServiceChannel : ICrudeSystemSettingService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeSystemSettingService : System.ServiceModel.ClientBase<ICrudeSystemSettingService>, ICrudeSystemSettingService {
        
        public CrudeSystemSettingService() {
        }
        
        public CrudeSystemSettingService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeSystemSettingService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeSystemSettingService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeSystemSettingService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingContract FetchBySystemSettingId(System.Guid systemSettingId) {
            return base.Channel.FetchBySystemSettingId(systemSettingId);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeSystemSettingContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeSystemSettingContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid systemSettingId) {
            base.Channel.Delete(systemSettingId);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingContract[] FetchWithFilter(System.Guid systemSettingId, string systemSettingRcd, string systemSettingValue, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(systemSettingId,systemSettingRcd,systemSettingValue,userId,dateTime);
        }
    }
}
