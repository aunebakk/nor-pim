using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class StateRef {
        
        public static string Created = "C";
        
        public static string Invalidated = "I";
        
        public static string Updated = "U";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeStateRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeStateRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string StateRcdField;
        
        private string StateNameField;
        
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
        public string StateRcd {
            get {
                return StateRcdField;
            }
            set {
                StateRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StateName {
            get {
                return StateNameField;
            }
            set {
                StateNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeStateRefService")]
    public interface ICrudeStateRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/FetchByStateRcd", ReplyAction="http://tempuri.org/ICrudeStateRefService/FetchByStateRcdResponse")]
        norpim.BusinessLogicLayer.CrudeStateRefContract FetchByStateRcd(string stateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/Insert", ReplyAction="http://tempuri.org/ICrudeStateRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeStateRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/Update", ReplyAction="http://tempuri.org/ICrudeStateRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeStateRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/Delete", ReplyAction="http://tempuri.org/ICrudeStateRefService/DeleteResponse")]
        void Delete(string stateRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeStateRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeStateRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeStateRefService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeStateRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeStateRefService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeStateRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeStateRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeStateRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeStateRefService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeStateRefContract[] FetchWithFilter(string stateRcd, string stateName, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeStateRefServiceChannel : ICrudeStateRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeStateRefService : System.ServiceModel.ClientBase<ICrudeStateRefService>, ICrudeStateRefService {
        
        public CrudeStateRefService() {
        }
        
        public CrudeStateRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeStateRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeStateRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeStateRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeStateRefContract FetchByStateRcd(string stateRcd) {
            return base.Channel.FetchByStateRcd(stateRcd);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeStateRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeStateRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string stateRcd) {
            base.Channel.Delete(stateRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeStateRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeStateRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeStateRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeStateRefContract[] FetchWithFilter(string stateRcd, string stateName, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(stateRcd,stateName,dateTime);
        }
    }
}
