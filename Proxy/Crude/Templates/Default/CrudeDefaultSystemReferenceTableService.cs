/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 3:50:54 AM
  From Machine: DESKTOP-517I8BU
  Filename: DefaultSystemReferenceTable.json
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICrudeDefaultSystemReferenceTableService")]
    public partial interface ICrudeDefaultSystemReferenceTableService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultSystemR" +
            "eferenceTableId", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultSystemR" +
            "eferenceTableIdResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultUserId", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultUserIdR" +
            "esponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/Insert", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/InsertResponse")]
        void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/Update", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/UpdateResponse")]
        void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract contract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/Delete", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/DeleteResponse")]
        void Delete(System.Guid defaultSystemReferenceTableId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultSystemR" +
            "eferenceTableName", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchByDefaultSystemR" +
            "eferenceTableNameResponse")]
        SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAll", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllWithLimit", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllWithLimitResp" +
            "onse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllWithLimitAndO" +
            "ffset", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllWithLimitAndO" +
            "ffsetResponse")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllCount", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchAllCountResponse" +
            "")]
        int FetchAllCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchWithFilter", ReplyAction="http://tempuri.org/ICrudeDefaultSystemReferenceTableService/FetchWithFilterRespon" +
            "se")]
        List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudeDefaultSystemReferenceTableServiceChannel : ICrudeDefaultSystemReferenceTableService, System.ServiceModel.IClientChannel {
    }
    
    public class CrudeDefaultSystemReferenceTableServiceClient : System.ServiceModel.ClientBase<ICrudeDefaultSystemReferenceTableService>, ICrudeDefaultSystemReferenceTableService {
        
        public CrudeDefaultSystemReferenceTableServiceClient() {
        }
        
        public CrudeDefaultSystemReferenceTableServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudeDefaultSystemReferenceTableServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemReferenceTableServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudeDefaultSystemReferenceTableServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableId(System.Guid defaultSystemReferenceTableId) {
            return base.Channel.FetchByDefaultSystemReferenceTableId(defaultSystemReferenceTableId);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchByDefaultUserId(System.Guid defaultUserId) {
            return base.Channel.FetchByDefaultUserId(defaultUserId);
        }
        
        public void Insert(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract contract) {
            base.Channel.Insert(contract);
        }
        
        public void Update(SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract contract) {
            base.Channel.Update(contract);
        }
        
        public void Delete(System.Guid defaultSystemReferenceTableId) {
            base.Channel.Delete(defaultSystemReferenceTableId);
        }
        
        public SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract FetchByDefaultSystemReferenceTableName(string defaultSystemReferenceTableName) {
            return base.Channel.FetchByDefaultSystemReferenceTableName(defaultSystemReferenceTableName);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAll() {
            return base.Channel.FetchAll();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAllWithLimit(int limit) {
            return base.Channel.FetchAllWithLimit(limit);
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchAllWithLimitAndOffset(int limit, int offset) {
            return base.Channel.FetchAllWithLimitAndOffset(limit,offset);
        }
        
        public int FetchAllCount() {
            return base.Channel.FetchAllCount();
        }
        
        public List<SolutionNorSolutionPim.BusinessLogicLayer.CrudeDefaultSystemReferenceTableContract> FetchWithFilter(System.Guid defaultSystemReferenceTableId, string defaultSystemReferenceTableName, string defaultSystemReferenceDisplayName, System.Guid defaultUserId, System.DateTime dateTime) {
            return base.Channel.FetchWithFilter(
                defaultSystemReferenceTableId: defaultSystemReferenceTableId,
                defaultSystemReferenceTableName: defaultSystemReferenceTableName,
                defaultSystemReferenceDisplayName: defaultSystemReferenceDisplayName,
                defaultUserId: defaultUserId,
                dateTime: dateTime
                );
        }
    }
}
