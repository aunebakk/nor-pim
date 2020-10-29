/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:51:17 PM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICartProductSearchService")]
    public interface ICartProductSearchService {
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/ICartProductSearchService/GetCartProduct", ReplyAction = "http://tempuri.org/ICartProductSearchService/GetCartProductResponse")]
        List<GetCartProductContract> GetCartProduct(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId, System.Guid cartProductId, string sessionIdentificator);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICartProductSearchServiceChannel : ICartProductSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class CartProductSearchService : System.ServiceModel.ClientBase<ICartProductSearchService>, ICartProductSearchService {
        
        public CartProductSearchService() {
        }
        
        public CartProductSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CartProductSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartProductSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartProductSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public List<GetCartProductContract> GetCartProduct(System.Guid clientId, System.Guid productId, System.Guid financialCurrencyId, System.Guid userId, System.Guid cartProductId, string sessionIdentificator) {
            return base.Channel.GetCartProduct(clientId, productId, financialCurrencyId, userId, cartProductId, sessionIdentificator);
        }
    }
}
