using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class SystemSettingRef {
        
        public static string DarkColorScheme = "dcs";
        
        public static string ProductGridLayout = "pl";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeSystemSettingRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeSystemSettingRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string SystemSettingRcdField;
        
        private string SystemSettingNameField;
        
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
        public string SystemSettingRcd {
            get {
                return SystemSettingRcdField;
            }
            set {
                SystemSettingRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemSettingName {
            get {
                return SystemSettingNameField;
            }
            set {
                SystemSettingNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeSystemSettingRefService")]
    public interface ICrudeSystemSettingRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/FetchBySystemSettingRcd", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/FetchBySystemSettingRcdResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingRefContract FetchBySystemSettingRcd(string systemSettingRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/Insert", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeSystemSettingRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/Update", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeSystemSettingRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/Delete", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/DeleteResponse")]
        void Delete(string systemSettingRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/FetchAllWithLimitAndOffsetRespon" +
            "se")]
        norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeSystemSettingRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeSystemSettingRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchWithFilter(string systemSettingRcd, string systemSettingName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeSystemSettingRefServiceChannel : ICrudeSystemSettingRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeSystemSettingRefService : System.ServiceModel.ClientBase<ICrudeSystemSettingRefService>, ICrudeSystemSettingRefService {
        
        public CrudeSystemSettingRefService() {
        }
        
        public CrudeSystemSettingRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeSystemSettingRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeSystemSettingRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeSystemSettingRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingRefContract FetchBySystemSettingRcd(string systemSettingRcd) {
            return base.Channel.FetchBySystemSettingRcd(systemSettingRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeSystemSettingRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeSystemSettingRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string systemSettingRcd) {
            base.Channel.Delete(systemSettingRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeSystemSettingRefContract[] FetchWithFilter(string systemSettingRcd, string systemSettingName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(systemSettingRcd,systemSettingName,userId,dateTime);
        }
    }
}
