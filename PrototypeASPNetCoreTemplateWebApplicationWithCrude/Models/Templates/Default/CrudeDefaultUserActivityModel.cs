/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/13/2020 5:44:38 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultUserActivityModel {
        
        [Display(Name="Default User Activity Id")]
        [Required()]
        public System.Guid DefaultUserActivityId { get; set; } //;
        
        [Display(Name="Default User Activity Type")]
        [Required()]
        public string DefaultUserActivityTypeRcd { get; set; } //;
        
        [Display(Name="User Activity Note")]
        [Required()]
        public string UserActivityNote { get; set; } //;
        
        [Display(Name="Originating Address")]
        [Required()]
        public string OriginatingAddress { get; set; } //;
        
        [Display(Name="Referrer")]
        [Required()]
        public string Referrer { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
