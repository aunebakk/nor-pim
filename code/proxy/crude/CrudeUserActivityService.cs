using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeUserActivityContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeUserActivityContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid UserActivityIdField;
        
        private string UserActivityTypeRcdField;
        
        private string UserActivityNoteField;
        
        private System.Guid UserIdField;
        
        private System.DateTime DateTimeField;
        
        private string OriginatingAddressField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserActivityId {
            get {
                return UserActivityIdField;
            }
            set {
                UserActivityIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserActivityTypeRcd {
            get {
                return UserActivityTypeRcdField;
            }
            set {
                UserActivityTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserActivityNote {
            get {
                return UserActivityNoteField;
            }
            set {
                UserActivityNoteField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginatingAddress {
            get {
                return OriginatingAddressField;
            }
            set {
                OriginatingAddressField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeUserActivityService")]
    public interface ICrudeUserActivityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/FetchByUserActivityId", ReplyAction="http://tempuri.org/ICrudeUserActivityService/FetchByUserActivityIdResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityContract FetchByUserActivityId(System.Guid userActivityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeUserActivityService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/Insert", ReplyAction="http://tempuri.org/ICrudeUserActivityService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeUserActivityContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/Update", ReplyAction="http://tempuri.org/ICrudeUserActivityService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeUserActivityContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/Delete", ReplyAction="http://tempuri.org/ICrudeUserActivityService/DeleteResponse")]
        void Delete(System.Guid userActivityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/FetchAll", ReplyAction="http://tempuri.org/ICrudeUserActivityService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeUserActivityService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeUserActivityService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeUserActivityService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeUserActivityService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchWithFilter(System.Guid userActivityId, string userActivityTypeRcd, string userActivityNote, System.Guid userId, System.DateTime dateTime, string originatingAddress);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeUserActivityServiceChannel : ICrudeUserActivityService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeUserActivityService : System.ServiceModel.ClientBase<ICrudeUserActivityService>, ICrudeUserActivityService {
        
        public CrudeUserActivityService() {
        }
        
        public CrudeUserActivityService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeUserActivityService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeUserActivityService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeUserActivityService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityContract FetchByUserActivityId(System.Guid userActivityId) {
            return base.Channel.FetchByUserActivityId(userActivityId);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeUserActivityContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeUserActivityContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid userActivityId) {
            base.Channel.Delete(userActivityId);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityContract[] FetchWithFilter(System.Guid userActivityId, string userActivityTypeRcd, string userActivityNote, System.Guid userId, System.DateTime dateTime, string originatingAddress) {
            return base.Channel.FetchWithFilter(userActivityId,userActivityTypeRcd,userActivityNote,userId,dateTime,originatingAddress);
        }
    }
}
