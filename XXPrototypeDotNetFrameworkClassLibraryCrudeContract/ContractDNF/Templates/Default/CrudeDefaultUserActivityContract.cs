/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 7:18:14 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeDefaultUserActivityContract {
        
        [DataMember()]
        public System.Guid DefaultUserActivityId { get; set; } //;
        
        [DataMember()]
        public string DefaultUserActivityTypeRcd { get; set; } //;
        
        [DataMember()]
        public string UserActivityNote { get; set; } //;
        
        [DataMember()]
        public string OriginatingAddress { get; set; } //;
        
        [DataMember()]
        public string Referrer { get; set; } //;
        
        [DataMember()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}