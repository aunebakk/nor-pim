/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/16/2020 5:52:36 PM
  From Machine: DESKTOP-742U247
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeDefaultRuleTypeRefContract {

        [DataMember()]
        public string DefaultRuleTypeRcd { get; set; }

        [DataMember()]
        public string DefaultRuleTypeName { get; set; }

        [DataMember()]
        public System.Guid DefaultUserId { get; set; }

        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
