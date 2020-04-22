/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 6:49:56 AM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeDefaultPerformanceTimeRollupContract {
        
        [DataMember()]
        public System.Guid DefaultPerformanceTimeRollupId { get; set; } //;
        
        [DataMember()]
        public string CommandName { get; set; } //;
        
        [DataMember()]
        public long Milliseconds { get; set; } //;
        
        [DataMember()]
        public long Hits { get; set; } //;
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
