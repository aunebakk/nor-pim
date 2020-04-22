/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/22/2020 5:52:05 AM
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultUserActivityGroupedContract {
        
        [DataMember()]
        public string OriginatingAddress { get; set; } //;
        
        [DataMember()]
        public string UserActivityTypeName { get; set; } //;
        
        [DataMember()]
        public string UserActivityNote { get; set; } //;
        
        [DataMember()]
        public int Occurrences { get; set; } //;
    }
}
