/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 12:23:29 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeDefaultSystemSettingContract {
        
        [DataMember()]
        public System.Guid DefaultSystemSettingId { get; set; } //;
        
        [DataMember()]
        public string DefaultSystemSettingRcd { get; set; } //;
        
        [DataMember()]
        public string DefaultSystemSettingValue { get; set; } //;
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
