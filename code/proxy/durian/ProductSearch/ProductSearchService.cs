namespace norpim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductSearchService")]
    public interface IProductSearchService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IProductSearchService/ProductSearchById", ReplyAction = "http://tempuri.org/IProductSearchService/ProductSearchByIdResponse")]
        ProductSearchByIdContract[] ProductSearchById(System.Guid productId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IProductSearchService/ProductSearchByCategory", ReplyAction = "http://tempuri.org/IProductSearchService/ProductSearchByCategoryResponse")]
        ProductSearchByCategoryContract[] ProductSearchByCategory(System.Guid productCategoryId, bool onParent);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IProductSearchService/ProductSearchByCategoryType1", ReplyAction = "http://tempuri.org/IProductSearchService/ProductSearchByCategoryType1Response")]
        ProductSearchByCategoryType1Contract[] ProductSearchByCategoryType1(System.Guid productCategoryId, bool onParent);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IProductSearchService/ProductSearchByCategoryType2", ReplyAction = "http://tempuri.org/IProductSearchService/ProductSearchByCategoryType2Response")]
        ProductSearchByCategoryType2Contract[] ProductSearchByCategoryType2(System.Guid productCategoryId, bool onParent);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IProductSearchService/ProductSearchByCategoryType3", ReplyAction = "http://tempuri.org/IProductSearchService/ProductSearchByCategoryType3Response")]
        ProductSearchByCategoryType3Contract[] ProductSearchByCategoryType3(System.Guid productCategoryId, bool onParent);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IProductSearchService/ProductSearchByName", ReplyAction = "http://tempuri.org/IProductSearchService/ProductSearchByNameResponse")]
        ProductSearchByNameContract[] ProductSearchByName(string productName);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IProductSearchService/ProductHistory", ReplyAction = "http://tempuri.org/IProductSearchService/ProductHistoryResponse")]
        ProductHistoryContract[] ProductHistory(System.Guid productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IProductSearchServiceChannel : IProductSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ProductSearchService : System.ServiceModel.ClientBase<IProductSearchService>, IProductSearchService {
        
        public ProductSearchService() {
        }
        
        public ProductSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
                }

        public ProductSearchByIdContract[] ProductSearchById(System.Guid productId)
        {
            return base.Channel.ProductSearchById(productId);
        }

        public ProductSearchByCategoryContract[] ProductSearchByCategory(System.Guid productCategoryId, bool onParent)
        {
            return base.Channel.ProductSearchByCategory(productCategoryId, onParent);
        }

        public ProductSearchByCategoryType1Contract[] ProductSearchByCategoryType1(System.Guid productCategoryId, bool onParent)
        {
            return base.Channel.ProductSearchByCategoryType1(productCategoryId, onParent);
        }

        public ProductSearchByCategoryType2Contract[] ProductSearchByCategoryType2(System.Guid productCategoryId, bool onParent)
        {
            return base.Channel.ProductSearchByCategoryType2(productCategoryId, onParent);
        }

        public ProductSearchByCategoryType3Contract[] ProductSearchByCategoryType3(System.Guid productCategoryId, bool onParent)
        {
            return base.Channel.ProductSearchByCategoryType3(productCategoryId, onParent);
        }

        public ProductSearchByNameContract[] ProductSearchByName(string productName)
        {
            return base.Channel.ProductSearchByName(productName);
        }

        public ProductHistoryContract[] ProductHistory(System.Guid productId) {
            return base.Channel.ProductHistory(productId);
        }
    }
}
