/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/12/2020 12:49:53 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultStatisticsContract {
        
        [DataMember()]
        public string ActivityDate { get; set; } //;
        
        [DataMember()]
        public int DayCount { get; set; } //;
    }
}
