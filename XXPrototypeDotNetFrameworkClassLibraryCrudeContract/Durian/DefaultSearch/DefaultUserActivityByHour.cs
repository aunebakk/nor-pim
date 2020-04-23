/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 12:01:39 PM
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultUserActivityByHourContract {
        
        [DataMember()]
        public string HourNumber { get; set; } //;
        
        [DataMember()]
        public int HourCount { get; set; } //;
    }
}
