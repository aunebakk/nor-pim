using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GatherOverviewContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class GatherOverviewContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductGatherIdField;
        
        private System.DateTime StartDateTimeField;
        
        private System.DateTime FinishDateTimeField;
        
        private string ProductGatherSourceTypeRcdField;
        
        private string ProductGatherSourceTypeNameField;
        
        private int KeyCountField;
        
        private string UserNameField;
        
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
        public string ProductGatherSourceTypeRcd {
            get {
                return ProductGatherSourceTypeRcdField;
            }
            set {
                ProductGatherSourceTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductGatherSourceTypeName {
            get {
                return ProductGatherSourceTypeNameField;
            }
            set {
                ProductGatherSourceTypeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int KeyCount {
            get {
                return KeyCountField;
            }
            set {
                KeyCountField = value;
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
        public System.DateTime DateTime {
            get {
                return DateTimeField;
            }
            set {
                DateTimeField = value;
            }
        }
    }
}
