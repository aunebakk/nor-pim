/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/16/2020 8:30:26 PM
  Template: sql2x.TemplateCrudeContract.CrudeContract
*/
using System.Runtime.Serialization;

namespace SolutionNorSolutionPim.BusinessLogicLayer {
    
    
    [DataContract()]
    public partial class CrudeClientNationalityRefContract {
        
        [DataMember()]
        public string ClientNationalityRcd { get; set; } //;
        
        [DataMember()]
        public string ClientNationalityName { get; set; } //;
        
        [DataMember()]
        public string ClientNationalityDescription { get; set; } //;
        
        [DataMember()]
        public bool ActiveFlag { get; set; } //;
        
        [DataMember()]
        public int SortOrder { get; set; } //;
        
        [DataMember()]
        public System.Guid UserId { get; set; } //;
        
        [DataMember()]
        public System.DateTime DateTime { get; set; } //;
    }
}
