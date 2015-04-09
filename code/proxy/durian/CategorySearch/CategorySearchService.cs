namespace norpim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICategorySearchService")]
    public interface ICategorySearchService {
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICategorySearchService/CategoryTree", ReplyAction = "http://tempuri.org/ICategorySearchService/CategoryTreeResponse")]
        CategoryTreeContract[] CategoryTree();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICategorySearchService/CategoryFind", ReplyAction = "http://tempuri.org/ICategorySearchService/CategoryFindResponse")]
        CategoryFindContract[] CategoryFind(string findWhat);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICategorySearchServiceChannel : ICategorySearchService, System.ServiceModel.IClientChannel {
    }
    
    public class CategorySearchService : System.ServiceModel.ClientBase<ICategorySearchService>, ICategorySearchService {
        
        public CategorySearchService() {
        }
        
        public CategorySearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategorySearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategorySearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategorySearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public CategoryTreeContract[] CategoryTree() {
            return base.Channel.CategoryTree();
        }

        public CategoryFindContract[] CategoryFind(string findWhat) {
            return base.Channel.CategoryFind(findWhat);
        }
    }
}
