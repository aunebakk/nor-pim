/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:28:19 PM
  Template: sql2x.ContractsGenerator.Method
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
