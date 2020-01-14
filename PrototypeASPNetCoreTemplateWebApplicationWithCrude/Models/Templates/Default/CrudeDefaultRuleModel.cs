/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/14/2020 9:46:26 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultRuleModel {
        
        [Display(Name="Default Rule Id")]
        [Required()]
        public System.Guid DefaultRuleId { get; set; } //;
        
        [Display(Name="Default Rule Type")]
        [Required()]
        public string DefaultRuleTypeRcd { get; set; } //;
        
        [Display(Name="Address")]
        [Required()]
        public string Address { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
