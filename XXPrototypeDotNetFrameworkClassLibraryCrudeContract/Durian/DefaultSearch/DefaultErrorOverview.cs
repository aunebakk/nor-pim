/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:28:43 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultErrorOverviewContract {
        
        [DataMember()]
        public System.Guid DefaultErrorId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string DefaultErrorLayerName { get; set; } //;
        
        [DataMember()]
        public string DefaultErrorTypeName { get; set; } //;
        
        [DataMember()]
        public string DomainName { get; set; } //;
        
        [DataMember()]
        public string ClassName { get; set; } //;
        
        [DataMember()]
        public string MethodName { get; set; } //;
        
        [DataMember()]
        public string ErrorMessage { get; set; } //;
    }
}