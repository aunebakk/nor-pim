/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:52 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultIssueModel {
        
        [Display(Name="Default Issue Id")]
        [Required()]
        public System.Guid DefaultIssueId { get; set; } //;
        
        [Display(Name="Default Issue Type")]
        [Required()]
        public string DefaultIssueTypeRcd { get; set; } //;
        
        [Display(Name="Default Issue Status")]
        [Required()]
        public string DefaultIssueStatusRcd { get; set; } //;
        
        [Display(Name="Default Error Id")]
        [Required()]
        public System.Guid DefaultErrorId { get; set; } //;
        
        [Display(Name="Issue Name")]
        [Required()]
        public string IssueName { get; set; } //;
        
        [Display(Name="Issue Description")]
        [Required()]
        public string IssueDescription { get; set; } //;
        
        [Display(Name="Steps To Reproduce")]
        [Required()]
        public string StepsToReproduce { get; set; } //;
        
        [Display(Name="Link")]
        [Required()]
        public string Link { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
        
        [Display(Name="Fixed Note")]
        [Required()]
        public string FixedNote { get; set; } //;
    }
}
