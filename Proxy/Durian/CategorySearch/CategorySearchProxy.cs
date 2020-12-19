/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/19/2020 5:35:01 PM
  From Machine: DESKTOP-KE5CSN3
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICategorySearchService")]
    public interface ICategorySearchService {
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategorySearchService/CategoryFind", ReplyAction="http://tempuri.org/ICategorySearchService/CategoryFindResponse")]
        List<CategoryFindContract> CategoryFind (System.String findWhat);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategorySearchService/CategoryTree", ReplyAction="http://tempuri.org/ICategorySearchService/CategoryTreeResponse")]
        List<CategoryTreeContract> CategoryTree ();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategorySearchServiceChannel : ICategorySearchService, System.ServiceModel.IClientChannel {
    }
    
    public class CategorySearchService : System.ServiceModel.ClientBase<ICategorySearchService>, ICategorySearchService {
        public List<CategoryFindContract> CategoryFind (System.String findWhat) {
            return base.Channel.CategoryFind(findWhat);
        }
        public List<CategoryTreeContract> CategoryTree () {
            return base.Channel.CategoryTree();
        }
        
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
    }
}
