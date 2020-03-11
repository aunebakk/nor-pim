/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:52:43 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultResourceStatisticsContract {
        
        [DataMember()]
        public string HourNumber { get; set; } //;
        
        [DataMember()]
        public int ClientWorkingsetBytes { get; set; } //;
        
        [DataMember()]
        public int BusinessWorkingsetBytes { get; set; } //;
        
        [DataMember()]
        public int DatabaseSizeBytes { get; set; } //;
    }
}
