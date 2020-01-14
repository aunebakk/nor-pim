/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 8:27:59 PM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultTestOverviewContract {
        
        [DataMember()]
        public string TestArea { get; set; } //;
        
        [DataMember()]
        public System.DateTime StartDateTime { get; set; } //;
        
        [DataMember()]
        public string DefaultTestRunResultRcd { get; set; } //;
    }
}
