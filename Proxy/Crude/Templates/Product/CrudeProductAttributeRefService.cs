/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 2:49:49 PM
  From Machine: DESKTOP-517I8BU
  Filename: ProductAttributeRef.json
  MethodName: sql2x.TemplateCrudeProxy.CrudeProxy
  Template Style: CrudeProxy
  Documentation:
    WCF Client Proxy layer for accessing Azure Storage Tables through
      CIFUDE ( Create Insert Fetch Update Delete and Extra Operations )
      Works for dotNetFramework
*/
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    public partial class ProductAttributeRef {
        
        public const string Color = "Color";
        
        public const string Height = "H";
        
        public const string Length = "L";
        
        public const string Model = "MOD";
        
        public const string MaxTakeOffWeight = "MTOW";
        
        public const string PriceUnit = "PU";
        
        public const string RangeInKilometer = "RKM";
        
        public const string AverageSeats = "SEAT";
        
        public const string SupplierNumber = "SUP";
        
        public const string SuppliedId = "SUPID";
        
        public const string Width = "W";
        
        public const string Weight = "WE";
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeProductAttributeRefService")]
    public partial interface ICrudeProductAttributeRefService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeRcd", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeRcdRes" +
            "ponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchByUserId", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchByUserIdResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Insert", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Update", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/Delete", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/DeleteResponse")]
        void Delete(string productAttributeRcd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeName", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchByProductAttributeNameRe" +
            "sponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeName(string productAttributeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAll", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitAndOffset", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllWithLimitAndOffsetRes" +
            "ponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchAllCountResponse")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeProductAttributeRefService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeProductAttributeRefService/FetchWithFilterResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeProductAttributeRefServiceChannel : ICrudeProductAttributeRefService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeProductAttributeRefServiceClient : System.ServiceModel.ClientBase<ICrudeProductAttributeRefService>, ICrudeProductAttributeRefService {
        
        public CrudeProductAttributeRefServiceClient() {
        }
        
        public CrudeProductAttributeRefServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeProductAttributeRefServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeRefServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeProductAttributeRefServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeRcd(string productAttributeRcd) {
            return base.Channel.FetchByProductAttributeRcd(productAttributeRcd);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchByUserId(System.Guid userId) {
            return base.Channel.FetchByUserId(userId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(string productAttributeRcd) {
            base.Channel.Delete(productAttributeRcd);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract FetchByProductAttributeName(string productAttributeName) {
            return base.Channel.FetchByProductAttributeName(productAttributeName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeProductAttributeRefContract> FetchWithFilter(string productAttributeRcd, string productAttributeName, System.Guid userId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                productAttributeRcd: productAttributeRcd,
                productAttributeName: productAttributeName,
                userId: userId,
                dateTime: dateTime
                );
        }
    }
}
