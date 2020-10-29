/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/29/2020 6:51:43 PM
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
