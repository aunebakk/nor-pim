/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/24/2021 8:46:36 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    // this class is the contract for WCF between business and client proxy
    // data class is serializable in order to speed up processing between the data access and business layers
    // this class start with an identical representation of a ansi sql select statement in DefaultIssueWithFilter's columns
    //  formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/86781214-890e-420a-b31f-5bd141c32c4a
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
