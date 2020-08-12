/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 8/12/2020 10:45:22 AM
  From Machine: DESKTOP-00MSEIL
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeProductExposeContract {
        
        [DataMember()]
        public System.Guid ProductExposeId { get; set; }
        
        [DataMember()]
        public System.Guid ExposeProductId { get; set; }
        
        [DataMember()]
        public System.Guid ExposeBasedOnProductId { get; set; }
        
        [DataMember()]
        public System.Guid ProductExposeSetId { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
