/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 3/13/2020 10:45:52 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductGatherModel {
        
        [Display(Name="Product Gather Id")]
        [Required()]
        public System.Guid ProductGatherId { get; set; } //;
        
        [Display(Name="Start Date Time")]
        [Required()]
        public System.DateTime StartDateTime { get; set; } //;
        
        [Display(Name="Finish Date Time")]
        [Required()]
        public System.DateTime FinishDateTime { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
