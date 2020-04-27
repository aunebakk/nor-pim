/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/27/2020 3:45:11 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultPerformanceTimeModel {
        
        [Display(Name="Default Performance Time Id")]
        [Required()]
        public System.Guid DefaultPerformanceTimeId { get; set; } //;
        
        [Display(Name="Command Name")]
        [Required()]
        public string CommandName { get; set; } //;
        
        [Display(Name="Milliseconds")]
        [Required()]
        public int Milliseconds { get; set; } //;
        
        [Display(Name="Default User Id")]
        [Required()]
        public System.Guid DefaultUserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
