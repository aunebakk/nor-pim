namespace norpim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IStatisticsSearchService")]
    public interface IStatisticsSearchService {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IStatisticsSearchService/ProductStatisticsTop5", ReplyAction = "http://tempuri.org/IStatisticsSearchService/ProductStatisticsTop5Response")]
        ProductStatisticsTop5Contract[] ProductStatisticsTop5();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IStatisticsSearchService/GatherProductDetails", ReplyAction = "http://tempuri.org/IStatisticsSearchService/GatherProductDetailsResponse")]
        GatherProductDetailsContract[] GatherProductDetails(System.Guid productGatherId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IStatisticsSearchService/ProductStatistics", ReplyAction = "http://tempuri.org/IStatisticsSearchService/ProductStatisticsResponse")]
        ProductStatisticsContract[] ProductStatistics();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IStatisticsSearchService/ProductStatisticsByMonth", ReplyAction = "http://tempuri.org/IStatisticsSearchService/ProductStatisticsByMonthResponse")]
        ProductStatisticsByMonthContract[] ProductStatisticsByMonth();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IStatisticsSearchServiceChannel : IStatisticsSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class StatisticsSearchService : System.ServiceModel.ClientBase<IStatisticsSearchService>, IStatisticsSearchService {
        
        public StatisticsSearchService() {
        }
        
        public StatisticsSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StatisticsSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatisticsSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatisticsSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public ProductStatisticsTop5Contract[] ProductStatisticsTop5() {
            return base.Channel.ProductStatisticsTop5();
        }

        public GatherProductDetailsContract[] GatherProductDetails(System.Guid productGatherId) {
            return base.Channel.GatherProductDetails(productGatherId);
        }

        public ProductStatisticsContract[] ProductStatistics() {
            return base.Channel.ProductStatistics();
        }

        public ProductStatisticsByMonthContract[] ProductStatisticsByMonth() {
            return base.Channel.ProductStatisticsByMonth();
        }
    }
}
