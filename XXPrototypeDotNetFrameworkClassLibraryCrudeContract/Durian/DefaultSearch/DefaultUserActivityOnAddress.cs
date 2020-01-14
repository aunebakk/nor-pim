/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:52:32 AM
  Template: sql2x.ContractsGenerator.Method
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public class DefaultUserActivityOnAddressContract {
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
        
        [DataMember()]
        public string UserActivityTypeName { get; set; } //;
        
        [DataMember()]
        public string OriginatingAddress { get; set; } //;
        
        [DataMember()]
        public string UserActivityNote { get; set; } //;
    }
}
