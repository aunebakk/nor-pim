/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 11/3/2020 6:54:25 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultPerformanceIndicatorsContract {
        
        [DataMember()]
        public string CommandName { get; set; }
        
        [DataMember()]
        public long HitCount { get; set; }
        
        [DataMember()]
        public int AverageMilliseconds { get; set; }
    }
}
