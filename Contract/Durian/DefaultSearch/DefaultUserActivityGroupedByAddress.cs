/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 9:07:09 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultUserActivityGroupedByAddressContract {
        
        [DataMember()]
        public string OriginatingAddress { get; set; }
        
        [DataMember()]
        public int Occurrences { get; set; }
    }
}
