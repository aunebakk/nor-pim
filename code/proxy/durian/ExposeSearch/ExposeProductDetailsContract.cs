using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExposeProductDetailsContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class ExposeProductDetailsContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ExposeProductIdField;
        
        private string ProductNameField;
        
        private string ProductCategoryNameField;
        
        private string ProductUserNameField;
        
        private System.DateTime ProductDateTimeField;
        
        private string ProductStateNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ExposeProductId {
            get {
                return ExposeProductIdField;
            }
            set {
                ExposeProductIdField = value;
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
        public string ProductCategoryName {
            get {
                return ProductCategoryNameField;
            }
            set {
                ProductCategoryNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductUserName {
            get {
                return ProductUserNameField;
            }
            set {
                ProductUserNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ProductDateTime {
            get {
                return ProductDateTimeField;
            }
            set {
                ProductDateTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductStateName {
            get {
                return ProductStateNameField;
            }
            set {
                ProductStateNameField = value;
            }
        }
    }
}
