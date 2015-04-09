using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserActivityGroupedByAddressContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class UserActivityGroupedByAddressContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string OriginatingAddressField;
        
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
