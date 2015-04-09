namespace norpim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IGatherSearchService")]
    public interface IGatherSearchService {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGatherSearchService/GatherOverview", ReplyAction = "http://tempuri.org/IGatherSearchService/GatherOverviewResponse")]
        GatherOverviewContract[] GatherOverview();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IGatherSearchService/GatherProductDetails", ReplyAction = "http://tempuri.org/IGatherSearchService/GatherProductDetailsResponse")]
        GatherProductDetailsContract[] GatherProductDetails(System.Guid productGatherId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IGatherSearchServiceChannel : IGatherSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class GatherSearchService : System.ServiceModel.ClientBase<IGatherSearchService>, IGatherSearchService {
        
        public GatherSearchService() {
        }
        
        public GatherSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GatherSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GatherSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GatherSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public GatherOverviewContract[] GatherOverview() {
            return base.Channel.GatherOverview();
        }

        public GatherProductDetailsContract[] GatherProductDetails(System.Guid productGatherId) {
            return base.Channel.GatherProductDetails(productGatherId);
        }
    }
}
