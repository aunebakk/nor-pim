﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:53:49 AM
  Template: sql2x.TemplateReturnInstruction.ProxyUsing
*/
using System;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICartProductService")]
    public partial interface ICartProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartProductService/CartProductCompleteGet", ReplyAction="http://tempuri.org/ICartProductService/CartProductCompleteGetResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CartProductContract CartProductCompleteGet(System.Guid cartProductId, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartProductService/CartProductCompleteUpdate", ReplyAction="http://tempuri.org/ICartProductService/CartProductCompleteUpdateResponse")]
        System.Guid CartProductCompleteUpdate(System.Guid cartProductId, SolutionNorSolutionPim.BusinessLogicLayer.CartProductContract cartProductContract, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICartProductServiceChannel : ICartProductService, System.ServiceModel.IClientChannel {
    }
    
    public class CartProductServiceClient : System.ServiceModel.ClientBase<ICartProductService>, ICartProductService {
        
        public CartProductServiceClient() {
        }
        
        public CartProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CartProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CartProductContract CartProductCompleteGet(System.Guid cartProductId, System.Guid userId) {
            return base.Channel.CartProductCompleteGet(cartProductId, userId);
        }
        
        public System.Guid CartProductCompleteUpdate(System.Guid cartProductId, SolutionNorSolutionPim.BusinessLogicLayer.CartProductContract cartProductContract, System.Guid userId) {
            return base.Channel.CartProductCompleteUpdate(cartProductId, cartProductContract, userId);
        }
    }
}
