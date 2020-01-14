/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 3:07:34 PM
  Template: sql2x.ContractsGenerator.Method
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
