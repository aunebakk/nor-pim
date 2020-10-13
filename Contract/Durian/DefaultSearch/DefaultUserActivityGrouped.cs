/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:42:28 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultUserActivityGroupedContract {
        
        [DataMember()]
        public string OriginatingAddress { get; set; }
        
        [DataMember()]
        public string UserActivityTypeName { get; set; }
        
        [DataMember()]
        public string UserActivityNote { get; set; }
        
        [DataMember()]
        public int Occurrences { get; set; }
    }
}
