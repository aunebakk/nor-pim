/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/23/2020 12:01:46 PM
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultStatisticsTop5Contract {
        
        [DataMember()]
        public string Measurement { get; set; } //;
        
        [DataMember()]
        public string Value { get; set; } //;
    }
}
