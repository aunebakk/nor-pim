using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserActivityGroupedContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class UserActivityGroupedContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string OriginatingAddressField;
        
        private string UserActivityTypeNameField;
        
        private string UserActivityNoteField;
        
        private int OccurrencesField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
        public string UserActivityNote {
            get {
                return UserActivityNoteField;
            }
            set {
                UserActivityNoteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Occurrences {
            get {
                return OccurrencesField;
            }
            set {
                OccurrencesField = value;
            }
        }
    }
}
