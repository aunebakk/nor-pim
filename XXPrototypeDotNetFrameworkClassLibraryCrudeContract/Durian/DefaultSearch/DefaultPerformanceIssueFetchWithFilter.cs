/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:51:23 AM
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultPerformanceIssueFetchWithFilterContract {
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string CommandName { get; set; } //;
        
        [DataMember()]
        public int Milliseconds { get; set; } //;
        
        [DataMember()]
        public System.Guid DefaultPerformanceIssueId { get; set; } //;
    }
}
