/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:52:55 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultPerformanceIndicatorsContract {
        
        [DataMember()]
        public string CommandName { get; set; } //;
        
        [DataMember()]
        public long HitCount { get; set; } //;
        
        [DataMember()]
        public int AverageMilliseconds { get; set; } //;
    }
}
