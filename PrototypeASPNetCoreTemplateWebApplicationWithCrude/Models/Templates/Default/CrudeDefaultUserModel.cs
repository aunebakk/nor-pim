/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/6/2020 12:33:39 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultUserModel {
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Default User Code")]
        [Required()]
        public string DefaultUserCode { get; set; } //;
        
        [Display(Name="Default User Name")]
        [Required()]
        public string DefaultUserName { get; set; } //;
        
        [Display(Name="Email")]
        [Required()]
        public string Email { get; set; } //;
        
        [Display(Name="Password")]
        [Required()]
        public string Password { get; set; } //;
        
        [Display(Name="Default State")]
        [Required()]
        public string DefaultStateRcd { get; set; } //;
        
        [Display(Name="Created By Default User Id")]
        [Required()]
        public System.Guid CreatedByDefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Last Activity Date Time")]
        [Required()]
        public System.DateTime LastActivityDateTime { get; set; } //;
    }
}
