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
    public partial class CrudeClientContactMethodRefContract {

        [DataMember()]
        public string ClientContactMethodRcd { get; set; }

        [DataMember()]
        public string ClientContactMethodName { get; set; }

        [DataMember()]
        public string ClientContactMethodDescription { get; set; }

        [DataMember()]
        public bool ActiveFlag { get; set; }

        [DataMember()]
        public int SortOrder { get; set; }

        [DataMember()]
        public System.Guid UserId { get; set; }

        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
