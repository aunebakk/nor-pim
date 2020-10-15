/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 3:04:12 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultIssueWithFilterContract {
        
        [DataMember()]
        public string DefaultIssueTypeRcd { get; set; }
        
        [DataMember()]
        public string DefaultIssueTypeName { get; set; }
        
        [DataMember()]
        public string DefaultIssueStatusRcd { get; set; }
        
        [DataMember()]
        public string DefaultIssueStatusName { get; set; }
        
        [DataMember()]
        public System.Guid DefaultErrorId { get; set; }
        
        [DataMember()]
        public string MethodName { get; set; }
        
        [DataMember()]
        public string IssueName { get; set; }
        
        [DataMember()]
        public string IssueDescription { get; set; }
        
        [DataMember()]
        public string StepsToReproduce { get; set; }
        
        [DataMember()]
        public string Link { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public System.Guid DefaultIssueId { get; set; }
    }
}
