/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 10:47:48 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultSystemSettingModel {
        
        [Display(Name="Default System Setting Id")]
        [Required()]
        public System.Guid DefaultSystemSettingId { get; set; } //;
        
        [Display(Name="Default System Setting")]
        [Required()]
        public string DefaultSystemSettingRcd { get; set; } //;
        
        [Display(Name="Default System Setting Value")]
        [Required()]
        public string DefaultSystemSettingValue { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
