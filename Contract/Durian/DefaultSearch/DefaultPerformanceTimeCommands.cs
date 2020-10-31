/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:14:13 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultPerformanceTimeCommandsContract {
        
        [DataMember()]
        public string CommandName { get; set; }
        
        [DataMember()]
        public string CommandDisplayName { get; set; }
    }
}
