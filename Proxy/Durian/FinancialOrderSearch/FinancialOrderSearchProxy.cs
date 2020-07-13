/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:56:23 PM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IFinancialOrderSearchService")]
    public interface IFinancialOrderSearchService {
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/IFinancialOrderSearchService/GetFinancialOrder", ReplyAction = "http://tempuri.org/IFinancialOrderSearchService/GetFinancialOrderResponse")]
        List<GetFinancialOrderContract> GetFinancialOrder(System.Guid clientId, System.Guid financialCurrencyId, System.Guid locationAddressId, string financialOrderSourceRcd, System.Guid userId, System.Guid financialOrderId);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFinancialOrderSearchServiceChannel : IFinancialOrderSearchService, System.ServiceModel.IClientChannel {
    }
    
    public class FinancialOrderSearchService : System.ServiceModel.ClientBase<IFinancialOrderSearchService>, IFinancialOrderSearchService {
        
        public FinancialOrderSearchService() {
        }
        
        public FinancialOrderSearchService(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FinancialOrderSearchService(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinancialOrderSearchService(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FinancialOrderSearchService(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public List<GetFinancialOrderContract> GetFinancialOrder(System.Guid clientId, System.Guid financialCurrencyId, System.Guid locationAddressId, string financialOrderSourceRcd, System.Guid userId, System.Guid financialOrderId) {
            return base.Channel.GetFinancialOrder(clientId, financialCurrencyId, locationAddressId, financialOrderSourceRcd, userId, financialOrderId);
        }
    }
}
