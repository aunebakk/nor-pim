/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 4/25/2020 8:22:59 AM
  Template: sql2x.CrudeDotNetCoreGenerator.CrudeRESTDotNetCoreModel
*/
using System.ComponentModel.DataAnnotations;
namespace SolutionNorSolutionPim.BusinessLogicLayer.Models {
    
    
    public partial class CrudeProductGatherKeyModel {
        
        [Display(Name="Product Gather Key Id")]
        [Required()]
        public System.Guid ProductGatherKeyId { get; set; } //;
        
        [Display(Name="Product Gather Key Value")]
        [Required()]
        public string ProductGatherKeyValue { get; set; } //;
        
        [Display(Name="Product Gather Id")]
        [Required()]
        public System.Guid ProductGatherId { get; set; } //;
        
        [Display(Name="User Id")]
        [Required()]
        public System.Guid UserId { get; set; } //;
        
        [Display(Name="Date Time")]
        [Required()]
        public System.DateTime DateTime { get; set; } //;
    }
}
