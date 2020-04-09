/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:42:30 PM
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICategorySearchService")]
    public interface ICategorySearchService {
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/ICategorySearchService/CategoryTree", ReplyAction = "http://tempuri.org/ICategorySearchService/CategoryTreeResponse")]
        List<CategoryTreeContract> CategoryTree();
        [System.ServiceModel.OperationContract(Action = "http://tempuri.org/ICategorySearchService/CategoryFind", ReplyAction = "http://tempuri.org/ICategorySearchService/CategoryFindResponse")]
        List<CategoryFindContract> CategoryFind(string findWhat);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
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

        public List<CategoryTreeContract> CategoryTree() {
            return base.Channel.CategoryTree();
        }

        public List<CategoryFindContract> CategoryFind(string findWhat) {
            return base.Channel.CategoryFind(findWhat);
        }
    }
}
