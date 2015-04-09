using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductSearchByIdContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class ProductSearchByIdContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ProductNameField;
        
        private string IdentifierField;
        
        private string ValueField;
        
        private string ProductInfoValueField;
        
        private string ProductImageTypeRcdField;
        
        private string ProductImageTypeNameField;
        
        private byte[] ImageField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
        public string Identifier {
            get {
                return IdentifierField;
            }
            set {
                IdentifierField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return ValueField;
            }
            set {
                ValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductInfoValue {
            get {
                return ProductInfoValueField;
            }
            set {
                ProductInfoValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductImageTypeRcd {
            get {
                return ProductImageTypeRcdField;
            }
            set {
                ProductImageTypeRcdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductImageTypeName {
            get {
                return ProductImageTypeNameField;
            }
            set {
                ProductImageTypeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return ImageField;
            }
            set {
                ImageField = value;
            }
        }
    }
}
