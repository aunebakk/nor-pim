/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/13/2020 5:33:35 PM
  From Machine: DESKTOP-742U247
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
