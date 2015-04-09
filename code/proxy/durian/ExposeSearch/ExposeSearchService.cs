namespace norpim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IExposeSearchService")]
    public interface IExposeSearchService {
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IExposeSearchService/ExposeProductDetails", ReplyAction = "http://tempuri.org/IExposeSearchService/ExposeProductDetailsResponse")]
        ExposeProductDetailsContract[] ExposeProductDetails(System.Guid productExposeSetId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IExposeSearchServiceChannel : IExposeSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class ExposeSearchService : System.ServiceModel.ClientBase<IExposeSearchService>, IExposeSearchService {
        
        public ExposeSearchService() {
        }
        
        public ExposeSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExposeSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExposeSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExposeSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public ExposeProductDetailsContract[] ExposeProductDetails(System.Guid productExposeSetId) {
            return base.Channel.ExposeProductDetails(productExposeSetId);
        }
    }
}
