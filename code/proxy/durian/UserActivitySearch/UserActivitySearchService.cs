namespace norpim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IUserActivitySearchService")]
    public interface IUserActivitySearchService {
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserActivitySearchService/UserActivityRecent", ReplyAction = "http://tempuri.org/IUserActivitySearchService/UserActivityRecentResponse")]
        UserActivityRecentContract[] UserActivityRecent();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserActivitySearchService/UserActivityGrouped", ReplyAction = "http://tempuri.org/IUserActivitySearchService/UserActivityGroupedResponse")]
        UserActivityGroupedContract[] UserActivityGrouped();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserActivitySearchService/UserActivityGroupedByAddress", ReplyAction = "http://tempuri.org/IUserActivitySearchService/UserActivityGroupedByAddressResponse")]
        UserActivityGroupedByAddressContract[] UserActivityGroupedByAddress();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IUserActivitySearchServiceChannel : IUserActivitySearchService, System.ServiceModel.IClientChannel {
    }
    
    public class UserActivitySearchService : System.ServiceModel.ClientBase<IUserActivitySearchService>, IUserActivitySearchService {
        
        public UserActivitySearchService() {
        }
        
        public UserActivitySearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserActivitySearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserActivitySearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserActivitySearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public UserActivityRecentContract[] UserActivityRecent() {
            return base.Channel.UserActivityRecent();
        }

        public UserActivityGroupedContract[] UserActivityGrouped() {
            return base.Channel.UserActivityGrouped();
        }

        public UserActivityGroupedByAddressContract[] UserActivityGroupedByAddress() {
            return base.Channel.UserActivityGroupedByAddress();
        }
    }
}
