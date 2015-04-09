using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductGatherSourceContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductGatherSourceContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductGatherSourceIdField;
        
        private System.Guid ProductGatherIdField;
        
        private System.Guid UserIdField;
        
        private System.DateTime DateTimeField;
        
        private string ProductGatherSourceTypeRcdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductGatherSourceId {
            get {
                return ProductGatherSourceIdField;
            }
            set {
                ProductGatherSourceIdField = value;
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
        public string ProductGatherSourceTypeRcd {
            get {
                return ProductGatherSourceTypeRcdField;
            }
            set {
                ProductGatherSourceTypeRcdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherSourceService")]
    public interface ICrudeProductGatherSourceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherSourceIdR" +
            "esponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByProductGatherIdRespons" +
            "e")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchByProductGatherId(System.Guid productGatherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchByUserIdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductGatherSourceContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductGatherSourceContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/DeleteResponse")]
        void Delete(System.Guid productGatherSourceId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherSourceService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherSourceService/FetchWithFilterResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime, string productGatherSourceTypeRcd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductGatherSourceServiceChannel : ICrudeProductGatherSourceService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherSourceService : System.ServiceModel.ClientBase<ICrudeProductGatherSourceService>, ICrudeProductGatherSourceService {
        
        public CrudeProductGatherSourceService() {
        }
        
        public CrudeProductGatherSourceService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherSourceService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherSourceService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceContract FetchByProductGatherSourceId(System.Guid productGatherSourceId) {
            return base.Channel.FetchByProductGatherSourceId(productGatherSourceId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchByProductGatherId(System.Guid productGatherId) {
            return base.Channel.FetchByProductGatherId(productGatherId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductGatherSourceContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductGatherSourceContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid productGatherSourceId) {
            base.Channel.Delete(productGatherSourceId);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherSourceContract[] FetchWithFilter(System.Guid productGatherSourceId, System.Guid productGatherId, System.Guid userId, System.DateTime dateTime, string productGatherSourceTypeRcd) {
            return base.Channel.FetchWithFilter(productGatherSourceId,productGatherId,userId,dateTime,productGatherSourceTypeRcd);
        }
    }
}
