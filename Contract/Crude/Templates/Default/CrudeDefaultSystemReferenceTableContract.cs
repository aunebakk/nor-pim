/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 10/31/2020 7:05:49 AM
  From Machine: DESKTOP-9A2DH39
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {

    [DataContract()]
    public partial class CrudeDefaultSystemReferenceTableContract {
        
        [DataMember()]
        public System.Guid DefaultSystemReferenceTableId { get; set; }
        
        [DataMember()]
        public string DefaultSystemReferenceTableName { get; set; }
        
        [DataMember()]
        public string DefaultSystemReferenceDisplayName { get; set; }
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; }
        
        [DataMember()]
        public System.DateTime DateTime { get; set; }
    }
}
