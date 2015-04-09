using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    public partial class ProductGatherAttributeTypeRef {
        
        public static string Color = "color";
        
        public static string Name = "name";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CrudeProductGatherAttributeTypeRefContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CrudeProductGatherAttributeTypeRefContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductGatherAttributeTypeRcdField;
        
        private string ProductGatherAttributeTypeNameField;
        
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
        public string ProductGatherAttributeTypeRcd {
            get {
                return ProductGatherAttributeTypeRcdField;
            }
            set {
                ProductGatherAttributeTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductGatherAttributeTypeName {
            get {
                return ProductGatherAttributeTypeNameField;
            }
            set {
                ProductGatherAttributeTypeNameField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductGatherAttributeTypeRefService")]
    public interface ICrudeProductGatherAttributeTypeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeRcd", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByProductGathe" +
            "rAttributeTypeRcdResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchByUserIdRespon" +
            "se")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/InsertResponse")]
        void Insert(norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/UpdateResponse")]
        void Update(norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/DeleteResponse")]
        void Delete(string productGatherAttributeTypeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitRe" +
            "sponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitAn" +
            "dOffset", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllWithLimitAn" +
            "dOffsetResponse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchAllCountRespon" +
            "se")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductGatherAttributeTypeRefService/FetchWithFilterResp" +
            "onse")]
        norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICrudeProductGatherAttributeTypeRefServiceChannel : ICrudeProductGatherAttributeTypeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductGatherAttributeTypeRefService : System.ServiceModel.ClientBase<ICrudeProductGatherAttributeTypeRefService>, ICrudeProductGatherAttributeTypeRefService {
        
        public CrudeProductGatherAttributeTypeRefService() {
        }
        
        public CrudeProductGatherAttributeTypeRefService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductGatherAttributeTypeRefService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeTypeRefService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductGatherAttributeTypeRefService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract FetchByProductGatherAttributeTypeRcd(string productGatherAttributeTypeRcd) {
            return base.Channel.FetchByProductGatherAttributeTypeRcd(productGatherAttributeTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productGatherAttributeTypeRcd) {
            base.Channel.Delete(productGatherAttributeTypeRcd);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public norpim.BusinessLogicLayer.CrudeProductGatherAttributeTypeRefContract[] FetchWithFilter(string productGatherAttributeTypeRcd, string productGatherAttributeTypeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(productGatherAttributeTypeRcd,productGatherAttributeTypeName,userId,dateTime);
        }
    }
}
