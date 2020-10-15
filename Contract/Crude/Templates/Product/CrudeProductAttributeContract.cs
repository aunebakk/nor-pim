/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/15/2020 2:55:14 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeProductAttributeContract {
        
        [DataMember()]
        public System.Guid ProductAttributeId { get; set; }
        
        [DataMember()]
        public System.Guid ProductId { get; set; }
        
        [DataMember()]
        public string ProductAttributeRcd { get; set; }
        
        [DataMember()]
        public string ProductAttributeUnitRcd { get; set; }
        
        [DataMember()]
        public string Value { get; set; }
        
        [DataMember()]
        public System.Guid UserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
