/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 11:01:36 AM
  From Machine: DESKTOP-517I8BU
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
