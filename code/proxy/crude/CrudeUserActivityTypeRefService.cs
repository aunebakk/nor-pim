using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class UserActivityTypeRef {
        
        public static string BusinessLogicMethodInvoked = "blmi";
        
        public static string FormOpened = "fo";
        
        public static string Login = "li";
        
        public static string Logout = "lo";
        
        public static string ScheduledEvent = "se";
        
        public static string WebPageOpened = "wpo";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeUserActivityTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeUserActivityTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string UserActivityTypeRcdField;
        
        private string UserActivityTypeNameField;
        
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
        public string UserActivityTypeRcd {
            get {
                return UserActivityTypeRcdField;
            }
            set {
                UserActivityTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserActivityTypeName {
            get {
                return UserActivityTypeNameField;
            }
            set {
                UserActivityTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeUserActivityTypeRefService")]
    public interface ICrudeUserActivityTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchByUserActivityTypeRcd", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchByUserActivityTypeRcdRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract FetchByUserActivityTypeRcd(string userActivityTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/DeleteResponse")]
        void Delete(string userActivityTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeUserActivityTypeRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchWithFilter(string userActivityTypeRcd, string userActivityTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeUserActivityTypeRefServiceChannel : ICrudeUserActivityTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeUserActivityTypeRefService : System.ServiceModel.ClientBase<ICrudeUserActivityTypeRefService>, ICrudeUserActivityTypeRefService {
        
        public CrudeUserActivityTypeRefService() {
        }
        
        public CrudeUserActivityTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeUserActivityTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeUserActivityTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeUserActivityTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract FetchByUserActivityTypeRcd(string userActivityTypeRcd) {
            return base.Channel.FetchByUserActivityTypeRcd(userActivityTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string userActivityTypeRcd) {
            base.Channel.Delete(userActivityTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeUserActivityTypeRefContract[] FetchWithFilter(string userActivityTypeRcd, string userActivityTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(userActivityTypeRcd,userActivityTypeName,userId,dateTime);
        }
    }
}
