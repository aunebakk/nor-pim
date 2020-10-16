/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 6:57:36 AM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeProductContract {
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public System.Guid ProductBecameId { get; set; }
        
        [DataMember()]
        public string ProductName { get; set; }
        
        [DataMember()]
        public string StateRcd { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
