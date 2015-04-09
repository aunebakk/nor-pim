using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductGatherContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductGatherContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductGatherIdField;
        
        private System.DateTime StartDateTimeField;
        
        private System.DateTime FinishDateTimeField;
        
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
        public System.Guid ProductGatherId {
            get {
                return ProductGatherIdField;
            }
            set {
                ProductGatherIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDateTime {
            get {
                return StartDateTimeField;
            }
            set {
                StartDateTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FinishDateTime {
            get {
                return FinishDateTimeField;
            }
            set {
                FinishDateTimeField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherService")]
    public interface ICrudeProductGatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/FetchByProductGatherId", ReplyAction="http://tempuri.org/ICrudeProductGatherService/FetchByProductGatherIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherContract FetchByProductGatherId(System.Guid productGatherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductGatherContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductGatherContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherService/DeleteResponse")]
        void Delete(System.Guid productGatherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherService/FetchAllWithLimitAndOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductGatherServiceChannel : ICrudeProductGatherService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherService : System.ServiceModel.ClientBase<ICrudeProductGatherService>, ICrudeProductGatherService {
        
        public CrudeProductGatherService() {
        }
        
        public CrudeProductGatherService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherContract FetchByProductGatherId(System.Guid productGatherId) {
            return base.Channel.FetchByProductGatherId(productGatherId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductGatherContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductGatherContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productGatherId) {
            base.Channel.Delete(productGatherId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherContract[] FetchWithFilter(System.Guid productGatherId, System.DateTime startDateTime, System.DateTime finishDateTime, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productGatherId,startDateTime,finishDateTime,userId,dateTime);
        }
    }
}
