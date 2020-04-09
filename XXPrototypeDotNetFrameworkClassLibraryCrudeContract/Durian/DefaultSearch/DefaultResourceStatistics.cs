/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:44:59 PM
  Template: sql2x.ContractsGenerator.MethodNewStyle
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
