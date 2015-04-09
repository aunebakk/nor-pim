using System.Runtime.Serialization;

namespace norpim.BusinessLogicLayer {
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryTreeContract", Namespace="http://schemas.datacontract.org/2004/07/norpim.BusinessLogicLayer")]
    public partial class CategoryTreeContract : System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid ProductCategoryIdField;
        
        private System.Guid ProductCategoryParentIdField;
        
        private string ProductCategoryCodeField;
        
        private string ProductCategoryNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductCategoryId {
            get {
                return ProductCategoryIdField;
            }
            set {
                ProductCategoryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductCategoryParentId {
            get {
                return ProductCategoryParentIdField;
            }
            set {
                ProductCategoryParentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategoryCode {
            get {
                return ProductCategoryCodeField;
            }
            set {
                ProductCategoryCodeField = value;
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
    }
}
