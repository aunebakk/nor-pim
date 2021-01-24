/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:50:45 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ProxyGenerator.ProxyForMethodNewStyle
*/
using System.Collections.Generic;
// Namespace for a Business Logic Layer in a Proxy
// the Business Logic Layer contains domain logic that encodes real world business rules
//  that determine how data is created, stored and changed. Typically it will also deal with
//  import and export of data and integration with API's from other parts of the system or other systems
// the BusinessLogicLayer is where the DataAccessLayer is exposed as
//  REST http services
// links:
//  docLink: http://sql2x.org/documentationLink/2595ba81-a5dc-4b5a-8bc8-2f7ca6630d9b
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    // Interface class for an WCF Service contract
    // this interface is used to expose C# objects as SOAP services using WCF
    // interface is a common means for discrete objects to communicate with each other
    // links:
    //  docLink: http://sql2x.org/documentationLink/179373dc-6fcc-4fc3-a7aa-e57c35d4d1d4
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IProductSearchService")]
    public interface IProductSearchServiceClient {
        // returns a list of ProductSearchByCategoryType4 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType4", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType4Response")]
        List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4 (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchByCategoryType3 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType3", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType3Response")]
        List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3 (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchByCategoryType2 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType2", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType2Response")]
        List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2 (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchByCategoryType1 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType1", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryType1Response")]
        List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1 (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchByCategoryCode contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryCode: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategoryCode", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryCodeResponse")]
        List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode (System.String productCategoryCode,System.Boolean onParent);
        // returns a list of ProductSearchByCategory contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByCategory", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByCategoryResponse")]
        List<ProductSearchByCategoryContract> ProductSearchByCategory (System.Guid productCategoryId,System.Boolean onParent);
        // returns a list of ProductSearchById contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchById", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByIdResponse")]
        ProductSearchByIdContract ProductSearchById (System.Guid productId);
        // returns a list of ProductSearchByName contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductSearchByName", ReplyAction="http://tempuri.org/IProductSearchService/ProductSearchByNameResponse")]
        List<ProductSearchByNameContract> ProductSearchByName (System.String productName);
        // returns a list of ProductHistory contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductSearchService/ProductHistory", ReplyAction="http://tempuri.org/IProductSearchService/ProductHistoryResponse")]
        List<ProductHistoryContract> ProductHistory (System.Guid productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductSearchServiceChannel : IProductSearchServiceClient, System.ServiceModel.IClientChannel {
    }
    
    public class ProductSearchServiceClient : System.ServiceModel.ClientBase<IProductSearchServiceClient>, IProductSearchServiceClient {
        // returns a list of ProductSearchByCategoryType4 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryType4Contract> ProductSearchByCategoryType4 (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryType4(productCategoryId, onParent);
        }
        // returns a list of ProductSearchByCategoryType3 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryType3Contract> ProductSearchByCategoryType3 (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryType3(productCategoryId, onParent);
        }
        // returns a list of ProductSearchByCategoryType2 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryType2Contract> ProductSearchByCategoryType2 (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryType2(productCategoryId, onParent);
        }
        // returns a list of ProductSearchByCategoryType1 contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryType1Contract> ProductSearchByCategoryType1 (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryType1(productCategoryId, onParent);
        }
        // returns a list of ProductSearchByCategoryCode contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryCode: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryCodeContract> ProductSearchByCategoryCode (System.String productCategoryCode,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategoryCode(productCategoryCode, onParent);
        }
        // returns a list of ProductSearchByCategory contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productCategoryId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        //  onParent: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByCategoryContract> ProductSearchByCategory (System.Guid productCategoryId,System.Boolean onParent) {
            return base.Channel.ProductSearchByCategory(productCategoryId, onParent);
        }
        // returns a list of ProductSearchById contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public ProductSearchByIdContract ProductSearchById (System.Guid productId) {
            return base.Channel.ProductSearchById(productId);
        }
        // returns a list of ProductSearchByName contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productName: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductSearchByNameContract> ProductSearchByName (System.String productName) {
            return base.Channel.ProductSearchByName(productName);
        }
        // returns a list of ProductHistory contracts from ProductSearchService
        // links:
        //  docLink: http://sql2x.org/documentationLink/ca70bf3f-58a1-476b-8441-3946d79cbe03
        // parameters:
        //  productId: filter by this key, 00000000-0000-0000-0000-000000000000 for no filter
        public List<ProductHistoryContract> ProductHistory (System.Guid productId) {
            return base.Channel.ProductHistory(productId);
        }
        
        public ProductSearchServiceClient() {
        }
        
        public ProductSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}
