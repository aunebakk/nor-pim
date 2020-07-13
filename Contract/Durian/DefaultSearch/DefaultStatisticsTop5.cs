/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 7/13/2020 11:01:19 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.ContractsGenerator.MethodNewStyle
*/
using System.Runtime.Serialization;
namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public class DefaultStatisticsTop5Contract {
        
        [DataMember()]
        public string Measurement { get; set; }
        
        [DataMember()]
        public string Value { get; set; }
    }
}
