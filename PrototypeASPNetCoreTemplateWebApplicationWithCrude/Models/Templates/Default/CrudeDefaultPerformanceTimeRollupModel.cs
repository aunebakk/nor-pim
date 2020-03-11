/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/11/2020 1:37:30 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultPerformanceTimeRollupModel {
        
        [Display(Name="Default Performance Time Rollup Id")]
        [Required()]
        public System.Guid DefaultPerformanceTimeRollupId { get; set; } //;
        
        [Display(Name="Command Name")]
        [Required()]
        public string CommandName { get; set; } //;
        
        [Display(Name="Milliseconds")]
        [Required()]
        public long Milliseconds { get; set; } //;
        
        [Display(Name="Hits")]
        [Required()]
        public long Hits { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
