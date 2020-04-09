/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/9/2020 5:38:53 PM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeDefaultTestRunModel {
        
        [Display(Name="Default Test Run Id")]
        [Required()]
        public System.Guid DefaultTestRunId { get; set; } //;
        
        [Display(Name="Default Test Id")]
        [Required()]
        public System.Guid DefaultTestId { get; set; } //;
        
        [Display(Name="Default Test Run Result")]
        [Required()]
        public string DefaultTestRunResultRcd { get; set; } //;
        
        [Display(Name="Result")]
        [Required()]
        public string Result { get; set; } //;
        
        [Display(Name="Start Date Time")]
        [Required()]
        public System.DateTime StartDateTime { get; set; } //;
        
        [Display(Name="End Date Time")]
        [Required()]
        public System.DateTime EndDateTime { get; set; } //;
        
        [Display(Name="Elapsed Milliseconds")]
        [Required()]
        public int ElapsedMilliseconds { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
