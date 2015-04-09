using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeUserContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeUserContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid UserIdField;
        
        private string UserCodeField;
        
        private string UserNameField;
        
        private string EmailField;
        
        private string PasswordField;
        
        private string StateRcdField;
        
        private System.Guid CreatedByUserIdField;
        
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
        public System.Guid UserId {
            get {
                return UserIdField;
            }
            set {
                UserIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserCode {
            get {
                return UserCodeField;
            }
            set {
                UserCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return UserNameField;
            }
            set {
                UserNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return EmailField;
            }
            set {
                EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return PasswordField;
            }
            set {
                PasswordField = value;
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
        public System.Guid CreatedByUserId {
            get {
                return CreatedByUserIdField;
            }
            set {
                CreatedByUserIdField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeUserService")]
    public interface ICrudeUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeUserService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeUserContract FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/Insert", ReplyAction="http://tempuri.org/ICrudeUserService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeUserContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/Update", ReplyAction="http://tempuri.org/ICrudeUserService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeUserContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/Delete", ReplyAction="http://tempuri.org/ICrudeUserService/DeleteResponse")]
        void Delete(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/FetchByUserCode", ReplyAction="http://tempuri.org/ICrudeUserService/FetchByUserCodeResponse")]
        norpim.BusinessLogicLayer.CrudeUserContract FetchByUserCode(string userCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/FetchAll", ReplyAction="http://tempuri.org/ICrudeUserService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeUserContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeUserService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeUserContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeUserService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeUserContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeUserService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeUserService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeUserService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeUserContract[] FetchWithFilter(System.Guid userId, string userCode, string userName, string email, string password, string stateRcd, System.Guid createdByUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeUserServiceChannel : ICrudeUserService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeUserService : System.ServiceModel.ClientBase<ICrudeUserService>, ICrudeUserService {
        
        public CrudeUserService() {
        }
        
        public CrudeUserService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeUserService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeUserService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeUserService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeUserContract FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeUserContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeUserContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid userId) {
            base.Channel.Delete(userId);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserContract FetchByUserCode(string userCode) {
            return base.Channel.FetchByUserCode(userCode);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeUserContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeUserContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeUserContract[] FetchWithFilter(System.Guid userId, string userCode, string userName, string email, string password, string stateRcd, System.Guid createdByUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(userId,userCode,userName,email,password,stateRcd,createdByUserId,dateTime);
        }
    }
}
