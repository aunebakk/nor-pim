using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductSearchByCategoryType2Contract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class ProductSearchByCategoryType2Contract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductIdField;
        
        private string ProductNameField;
        
        private string GtinField;
        
        private string HnField;
        
        private string ColorField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductId {
            get {
                return ProductIdField;
            }
            set {
                ProductIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return ProductNameField;
            }
            set {
                ProductNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gtin {
            get {
                return GtinField;
            }
            set {
                GtinField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hn {
            get {
                return HnField;
            }
            set {
                HnField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color {
            get {
                return ColorField;
            }
            set {
                ColorField = value;
            }
        }
    }
}
