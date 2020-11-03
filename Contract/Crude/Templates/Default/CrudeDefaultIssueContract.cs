/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:01:40 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeDefaultIssueContract {
        
        [DataMember()]
        public System.Guid DefaultIssueId { get; set; }
        
        [DataMember()]
        public string DefaultIssueTypeRcd { get; set; }
        
        [DataMember()]
        public string DefaultIssueStatusRcd { get; set; }
        
        [DataMember()]
        public System.Guid DefaultErrorId { get; set; }
        
        [DataMember()]
        public string IssueName { get; set; }
        
        [DataMember()]
        public string IssueDescription { get; set; }
        
        [DataMember()]
        public string StepsToReproduce { get; set; }
        
        [DataMember()]
        public string Link { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
        
        [DataMember()]
        public string FixedNote { get; set; }
    }
}
